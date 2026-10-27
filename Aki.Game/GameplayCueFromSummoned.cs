using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x02002FC0 RID: 12224
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueFromSummoned : GameplayCueBase
{
	// Token: 0x06019EAF RID: 106159 RVA: 0x006C7648 File Offset: 0x006C5848
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

	// Token: 0x06019EB0 RID: 106160 RVA: 0x006C7710 File Offset: 0x006C5910
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

	// Token: 0x06019EB1 RID: 106161 RVA: 0x006C77A3 File Offset: 0x006C59A3
	protected override void OnTick(float delta)
	{
		if (this.NeedAttach)
		{
			this.UpdateEffect();
		}
	}

	// Token: 0x06019EB2 RID: 106162 RVA: 0x006C77B4 File Offset: 0x006C59B4
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

	// Token: 0x06019EB3 RID: 106163 RVA: 0x006C7830 File Offset: 0x006C5A30
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

	// Token: 0x06019EB4 RID: 106164 RVA: 0x006C7948 File Offset: 0x006C5B48
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

	// Token: 0x0400C41E RID: 50206
	private TsBaseCharacter Summoned;

	// Token: 0x0400C41F RID: 50207
	private int? SummonedEntityId;

	// Token: 0x0400C420 RID: 50208
	private List<FName> Sockets;

	// Token: 0x0400C421 RID: 50209
	private Transform RelativeTransform;

	// Token: 0x0400C422 RID: 50210
	private int EffectViewHandle;

	// Token: 0x0400C423 RID: 50211
	private Transform CurrentTransform;

	// Token: 0x0400C424 RID: 50212
	private Transform EffectTransform;

	// Token: 0x0400C425 RID: 50213
	private bool NeedAttach;
}
