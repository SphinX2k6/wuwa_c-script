using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x02002514 RID: 9492
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueFromSummoned : GameplayCueBase
{
	// Token: 0x060177C1 RID: 96193 RVA: 0x006EDF14 File Offset: 0x006EC114
	protected override void OnInit()
	{
		EntityHandle instigator = this.Instigator;
		WorldEntity worldEntity = (instigator != null) ? instigator.Entity : null;
		if (worldEntity == null)
		{
			Log.Instance.Warn(ELogModule.Battle, ELogAuthor.LYY, "无法获取Buff施放者", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.InitConfig();
		this.CurrentTransform = Transform.Create();
		this.CurrentTransform.SetScale3D(global::Vector.OneVectorProxy);
		this.EffectTransform = Transform.Create();
		int? intValueByEntity = BlackboardController.Instance.GetIntValueByEntity(worldEntity.Id, this.CueConfig.CompName);
		Entity entity = EntitySystem.Instance.Get(intValueByEntity.Value);
		TsBaseCharacter summoned;
		if (entity == null)
		{
			summoned = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = entity.CheckGetComponent<CharacterActorComponent>();
			summoned = ((characterActorComponent != null) ? characterActorComponent.Actor : null);
		}
		this.Summoned = summoned;
		this.SummonedEntityId = new int?(worldEntity.Id);
	}

	// Token: 0x060177C2 RID: 96194 RVA: 0x006EDFDC File Offset: 0x006EC1DC
	protected override void OnCreate()
	{
		if (this.Summoned == null)
		{
			Log.Instance.Warn(ELogModule.Battle, ELogAuthor.LYY, "无法获取召唤物", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		EffectSystem instance = EffectSystem.Instance;
		UObject summoned = this.Summoned;
		FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble());
		this.EffectViewHandle = instance.SpawnEffect(summoned, ftransformDouble, this.CueConfig.Path, "[GameplayCueFromSummoned.OnCreate]", new EffectContext(this.SummonedEntityId, null, false), EEffectType.Fight, null, null, null, false, false);
		this.UpdateEffect();
		if (this.CueConfig.Comp == 1)
		{
			this.NeedAttach = true;
		}
	}

	// Token: 0x060177C3 RID: 96195 RVA: 0x006EE06F File Offset: 0x006EC26F
	protected override void OnTick(float delta)
	{
		if (this.NeedAttach)
		{
			this.UpdateEffect();
		}
	}

	// Token: 0x060177C4 RID: 96196 RVA: 0x006EE080 File Offset: 0x006EC280
	protected override void OnDestroy()
	{
		this.Summoned = null;
		this.SummonedEntityId = null;
		this.NeedAttach = false;
		this.RelativeTransform = null;
		this.Sockets = null;
		this.CurrentTransform = null;
		this.EffectTransform = null;
		if (EffectSystem.Instance.IsValid(this.EffectViewHandle))
		{
			EffectSystem.Instance.StopEffectById(this.EffectViewHandle, "[GameplayCueEffect.OnDestroy]", false, null);
			this.EffectViewHandle = 0;
		}
	}

	// Token: 0x060177C5 RID: 96197 RVA: 0x006EE0FC File Offset: 0x006EC2FC
	private void InitConfig()
	{
		Aki.Config.Vector value = this.CueConfig.Location.Value;
		global::Vector inT = global::Vector.Create((double)value.X, (double)value.Y, (double)value.Z);
		Aki.Config.Vector value2 = this.CueConfig.Rotation.Value;
		Rotator rotator = Rotator.Create(value2.Y, value2.Z, value2.X);
		Aki.Config.Vector value3 = this.CueConfig.Scale.Value;
		global::Vector inS = global::Vector.Create((double)value3.X, (double)value3.Y, (double)value3.Z);
		this.RelativeTransform = Transform.Create(rotator.Quaternion(null), inT, inS);
		string[] array = this.CueConfig.Socket.Split('#', StringSplitOptions.None);
		this.Sockets = new List<FName>(array.Length);
		foreach (string key in array)
		{
			this.Sockets.Add(FNameUtil.GetDynamicFName(key).Value);
		}
	}

	// Token: 0x060177C6 RID: 96198 RVA: 0x006EE214 File Offset: 0x006EC414
	private void UpdateEffect()
	{
		if (!EffectSystem.Instance.IsValid(this.EffectViewHandle))
		{
			return;
		}
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.EffectViewHandle);
		if (!effectActor.IsValid())
		{
			return;
		}
		global::Vector location = this.CurrentTransform.GetLocation();
		FVectorDouble fvectorDouble;
		if (this.Sockets.Count > 0)
		{
			global::Vector vector = location;
			fvectorDouble = this.Summoned.Mesh.D_GetSocketLocation(this.Sockets[0]);
			vector.FromUeVector(fvectorDouble);
		}
		else
		{
			location.DeepCopy(this.Summoned.CharacterActorComponent.ActorLocationProxy);
		}
		global::Vector location2 = this.EffectTransform.GetLocation();
		if (this.Sockets.Count > 1)
		{
			global::Vector vector2 = location2;
			fvectorDouble = this.ActorInternal.Mesh.D_GetSocketLocation(this.Sockets[1]);
			vector2.FromUeVector(fvectorDouble);
		}
		else
		{
			location2.DeepCopy(base.GetActorComponent().ActorLocationProxy);
		}
		Quat rotation = this.CurrentTransform.GetRotation();
		location2.SubtractionEqual(location).ToOrientationQuat(rotation);
		this.RelativeTransform.ComposeTransforms(this.CurrentTransform, this.EffectTransform);
		OneOf<KuroEffectActorHandle, AActor> self = effectActor;
		fvectorDouble = this.EffectTransform.GetLocation().ToUeVector(false);
		FRotator frotator = this.EffectTransform.GetRotation().Rotator(null).ToUeRotator();
		self.D_K2_SetActorLocationAndRotation(fvectorDouble, frotator, false, ref WorldGlobal.SweepHitResult, true);
	}

	// Token: 0x0400C7C7 RID: 51143
	private TsBaseCharacter Summoned;

	// Token: 0x0400C7C8 RID: 51144
	private int? SummonedEntityId;

	// Token: 0x0400C7C9 RID: 51145
	private List<FName> Sockets;

	// Token: 0x0400C7CA RID: 51146
	private Transform RelativeTransform;

	// Token: 0x0400C7CB RID: 51147
	private int EffectViewHandle;

	// Token: 0x0400C7CC RID: 51148
	private Transform CurrentTransform;

	// Token: 0x0400C7CD RID: 51149
	private Transform EffectTransform;

	// Token: 0x0400C7CE RID: 51150
	private bool NeedAttach;
}
