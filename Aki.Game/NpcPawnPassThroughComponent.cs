using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;

// Token: 0x020031D9 RID: 12761
[NullableContext(1)]
[Nullable(0)]
public class NpcPawnPassThroughComponent : EntityComponent
{
	// Token: 0x0601B853 RID: 112723 RVA: 0x0078C744 File Offset: 0x0078A944
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<BaseCharacterComponent>();
		BaseCharacterComponent actorComp = this.ActorComp;
		UCapsuleComponent ucapsuleComponent;
		if (actorComp == null)
		{
			ucapsuleComponent = null;
		}
		else
		{
			TsBaseCharacter actor = actorComp.Actor;
			ucapsuleComponent = ((actor != null) ? actor.CapsuleComponent : null);
		}
		UCapsuleComponent ucapsuleComponent2 = ucapsuleComponent;
		if (this.ActorComp == null || ucapsuleComponent2 == null)
		{
			this.DisableHandle = new int?(base.Disable("PawnPassThrough缺少依赖"));
			return true;
		}
		this.Capsule = ucapsuleComponent2;
		ModelComponent modelComponent = this.ActorComp.CreatureData.GetModelComponent();
		ECollisionChannelPreset? ecollisionChannelPreset;
		if (modelComponent == null)
		{
			ecollisionChannelPreset = null;
		}
		else
		{
			ICollisionChannelConfig collisionChannelConfig = modelComponent.CollisionChannelConfig;
			if (collisionChannelConfig == null)
			{
				ecollisionChannelPreset = null;
			}
			else
			{
				IOverrideCollisionChannel overrideCollisionChannel = collisionChannelConfig.OverrideCollisionChannel;
				ecollisionChannelPreset = ((overrideCollisionChannel != null) ? overrideCollisionChannel.CollisionChannelPreset : null);
			}
		}
		ECollisionChannelPreset? ecollisionChannelPreset2 = ecollisionChannelPreset;
		ECollisionChannelPreset ecollisionChannelPreset3 = ECollisionChannelPreset.CanBePassedThrough;
		if (!(ecollisionChannelPreset2.GetValueOrDefault() == ecollisionChannelPreset3 & ecollisionChannelPreset2 != null))
		{
			this.DisableHandle = new int?(base.Disable("PawnPassThrough未配置可穿透预设"));
			return true;
		}
		this.InitReferenceRadius();
		this.DowngradeCollision();
		ucapsuleComponent2.SetGenerateOverlapEvents(true);
		ucapsuleComponent2.OnComponentBeginOverlap.Add(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>(this.OnCapsuleBeginOverlap));
		ucapsuleComponent2.OnComponentEndOverlap.Add(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>(this.OnCapsuleEndOverlap));
		this.DisableHandle = new int?(base.Disable("PawnPassThrough初始禁用"));
		return true;
	}

	// Token: 0x0601B854 RID: 112724 RVA: 0x0078C880 File Offset: 0x0078AA80
	protected override bool OnEnd()
	{
		UCapsuleComponent capsule = this.Capsule;
		if (capsule != null && capsule.IsValid())
		{
			this.Capsule.OnComponentBeginOverlap.Remove(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int, bool, FHitResult>(this.OnCapsuleBeginOverlap));
			this.Capsule.OnComponentEndOverlap.Remove(new Action<UPrimitiveComponent, AActor, UPrimitiveComponent, int>(this.OnCapsuleEndOverlap));
			this.RestoreCollision();
		}
		this.ResetSelfDither();
		this.OverlapActorComps.Clear();
		this.DowngradedChannels.Clear();
		this.Capsule = null;
		this.ActorComp = null;
		this.DisableHandle = null;
		return true;
	}

	// Token: 0x0601B855 RID: 112725 RVA: 0x0078C918 File Offset: 0x0078AB18
	protected override void OnTick(float delta)
	{
		if (this.OverlapActorComps.Count == 0)
		{
			Log.Instance.Error(ELogModule.Character, ELogAuthor.LCZ, "NpcPawnPassThroughComponent.OnTick时OverlapActorComps为空，可能逻辑有误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		float num = 1f;
		this.UpdateSelfCapsuleSegment();
		foreach (BaseCharacterComponent baseCharacterComponent in this.OverlapActorComps)
		{
			if (!baseCharacterComponent.Active)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "NpcPawnPassThroughComponent.OnTick Actor非激活状态";
				string item = "Actor";
				TsBaseCharacter actor = baseCharacterComponent.Actor;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, ((actor != null) ? actor.GetName() : null) ?? "Unknown");
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				float num2 = this.CalcDitherAlpha(baseCharacterComponent);
				if (num2 < num)
				{
					num = num2;
				}
			}
		}
		this.SetSelfDither(num);
	}

	// Token: 0x0601B856 RID: 112726 RVA: 0x0078CA00 File Offset: 0x0078AC00
	private void InitReferenceRadius()
	{
		float scaledRadius = this.ActorComp.ScaledRadius;
		ModelComponent modelComponent = this.ActorComp.CreatureData.GetModelComponent();
		float? num;
		if (modelComponent == null)
		{
			num = null;
		}
		else
		{
			ICollisionChannelConfig collisionChannelConfig = modelComponent.CollisionChannelConfig;
			if (collisionChannelConfig == null)
			{
				num = null;
			}
			else
			{
				IOverrideCollisionChannel overrideCollisionChannel = collisionChannelConfig.OverrideCollisionChannel;
				num = ((overrideCollisionChannel != null) ? overrideCollisionChannel.BlurResponseRadius : null);
			}
		}
		float? num2 = num;
		float num3 = (num2 > 0f) ? Math.Min(scaledRadius, num2.Value) : scaledRadius;
		this.ReferenceRadius = ((num3 > 0f) ? num3 : scaledRadius);
	}

	// Token: 0x0601B857 RID: 112727 RVA: 0x0078CAA0 File Offset: 0x0078ACA0
	private void DowngradeCollision()
	{
		foreach (ECollisionChannel ecollisionChannel in NpcPawnPassThroughComponent.PASS_THROUGH_CHANNELS)
		{
			if (this.Capsule.GetCollisionResponseToChannel(ecollisionChannel) == ECollisionResponse.ECR_Block)
			{
				this.Capsule.SetCollisionResponseToChannel(ecollisionChannel, ECollisionResponse.ECR_Overlap);
				this.DowngradedChannels.Add(ecollisionChannel);
			}
		}
	}

	// Token: 0x0601B858 RID: 112728 RVA: 0x0078CAF8 File Offset: 0x0078ACF8
	private void RestoreCollision()
	{
		foreach (ECollisionChannel channel in this.DowngradedChannels)
		{
			this.Capsule.SetCollisionResponseToChannel(channel, ECollisionResponse.ECR_Block);
		}
	}

	// Token: 0x0601B859 RID: 112729 RVA: 0x0078CB54 File Offset: 0x0078AD54
	[NullableContext(2)]
	private void OnCapsuleBeginOverlap(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex, bool bFromSweep, [Nullable(1)] FHitResult sweepResult)
	{
		BaseCharacterComponent characterActorComp = this.GetCharacterActorComp(otherActor);
		if (characterActorComp == null || characterActorComp == this.ActorComp)
		{
			return;
		}
		this.OverlapActorComps.Add(characterActorComp);
		if (this.DisableHandle != null)
		{
			base.Enable(this.DisableHandle, "PawnPassThrough存在重叠");
			this.DisableHandle = null;
		}
	}

	// Token: 0x0601B85A RID: 112730 RVA: 0x0078CBB0 File Offset: 0x0078ADB0
	[NullableContext(2)]
	private void OnCapsuleEndOverlap(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex)
	{
		BaseCharacterComponent characterActorComp = this.GetCharacterActorComp(otherActor);
		if (characterActorComp == null)
		{
			return;
		}
		if (!this.OverlapActorComps.Remove(characterActorComp))
		{
			return;
		}
		if (this.OverlapActorComps.Count == 0)
		{
			this.ResetSelfDither();
			this.MarkOverlapEmpty();
		}
	}

	// Token: 0x0601B85B RID: 112731 RVA: 0x0078CBF4 File Offset: 0x0078ADF4
	[NullableContext(2)]
	private BaseCharacterComponent GetCharacterActorComp(AActor otherActor)
	{
		EntityHandle entityByActor = ActorUtils.GetEntityByActor(otherActor, false);
		if (entityByActor == null || !entityByActor.Valid)
		{
			return null;
		}
		CharacterActorComponent component = entityByActor.Entity.GetComponent<CharacterActorComponent>();
		if (component == null || !component.Valid)
		{
			return null;
		}
		return component;
	}

	// Token: 0x0601B85C RID: 112732 RVA: 0x0078CC3C File Offset: 0x0078AE3C
	private void MarkOverlapEmpty()
	{
		if (this.DisableHandle == null)
		{
			this.DisableHandle = new int?(base.Disable("PawnPassThrough无重叠"));
		}
	}

	// Token: 0x0601B85D RID: 112733 RVA: 0x0078CC64 File Offset: 0x0078AE64
	private float CalcDitherAlpha(BaseCharacterComponent otherActorComp)
	{
		float val = this.GetSegmentDistToOwnCapsule(otherActorComp) - otherActorComp.ScaledRadius;
		return MathUtils.Instance.RangeClamp(Math.Max(0f, val) / this.ReferenceRadius, 0f, 1f, 0.3f, 1f);
	}

	// Token: 0x0601B85E RID: 112734 RVA: 0x0078CCB0 File Offset: 0x0078AEB0
	private void UpdateSelfCapsuleSegment()
	{
		Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		Vector actorUpProxy = this.ActorComp.ActorUpProxy;
		float num = Math.Max(0f, this.ActorComp.ScaledHalfHeight - this.ActorComp.ScaledRadius);
		actorUpProxy.Multiply((double)num, this.TmpSeg);
		actorLocationProxy.Addition(this.TmpSeg, this.SelfPointA);
		actorLocationProxy.Subtraction(this.TmpSeg, this.SelfPointB);
	}

	// Token: 0x0601B85F RID: 112735 RVA: 0x0078CD28 File Offset: 0x0078AF28
	private float GetSegmentDistToOwnCapsule(BaseCharacterComponent otherActorComp)
	{
		Vector actorLocationProxy = otherActorComp.ActorLocationProxy;
		Vector actorUpProxy = otherActorComp.ActorUpProxy;
		float num = Math.Max(0f, otherActorComp.ScaledHalfHeight - otherActorComp.ScaledRadius);
		actorUpProxy.Multiply((double)num, this.TmpSeg);
		actorLocationProxy.Addition(this.TmpSeg, this.OtherPointA);
		actorLocationProxy.Subtraction(this.TmpSeg, this.OtherPointB);
		return (float)MathUtils.Instance.SegmentToSegmentDistance(this.SelfPointA, this.SelfPointB, this.OtherPointA, this.OtherPointB);
	}

	// Token: 0x0601B860 RID: 112736 RVA: 0x0078CDAF File Offset: 0x0078AFAF
	private void SetSelfDither(float alpha)
	{
		BaseCharacterComponent actorComp = this.ActorComp;
		if (actorComp == null)
		{
			return;
		}
		TsBaseCharacter actor = actorComp.Actor;
		if (actor == null)
		{
			return;
		}
		actor.SetDitherEffect(alpha, ECharacterDitherType.CanBePassedThrough);
	}

	// Token: 0x0601B861 RID: 112737 RVA: 0x0078CDD0 File Offset: 0x0078AFD0
	private void ResetSelfDither()
	{
		BaseCharacterComponent actorComp = this.ActorComp;
		if (actorComp != null && actorComp.Valid)
		{
			TsBaseCharacter actor = this.ActorComp.Actor;
			if (actor != null && actor.IsValid())
			{
				this.ActorComp.Actor.SetDitherEffect(1f, ECharacterDitherType.CanBePassedThrough);
			}
		}
	}

	// Token: 0x0601B862 RID: 112738 RVA: 0x0078CE20 File Offset: 0x0078B020
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		NpcPawnPassThroughComponent npcPawnPassThroughComponent = (NpcPawnPassThroughComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (npcPawnPassThroughComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseCharacterComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("Capsule"))
		{
			if (npcPawnPassThroughComponent.Capsule == null)
			{
				this.Capsule = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UCapsuleComponent>(this.Capsule), "Capsule"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ReferenceRadius"))
		{
			this.ReferenceRadius = npcPawnPassThroughComponent.ReferenceRadius;
		}
		if (base.CanResetComponentProperty("OverlapActorComps") && npcPawnPassThroughComponent.OverlapActorComps != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<BaseCharacterComponent>(this.OverlapActorComps), "OverlapActorComps"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("DowngradedChannels") && npcPawnPassThroughComponent.DowngradedChannels != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ECollisionChannel>>(this.DowngradedChannels), "DowngradedChannels"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("DisableHandle"))
		{
			this.DisableHandle = npcPawnPassThroughComponent.DisableHandle;
		}
		return (!base.CanResetComponentProperty("SelfPointA") || npcPawnPassThroughComponent.SelfPointA == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.SelfPointA), "SelfPointA")) && (!base.CanResetComponentProperty("SelfPointB") || npcPawnPassThroughComponent.SelfPointB == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.SelfPointB), "SelfPointB")) && (!base.CanResetComponentProperty("TmpSeg") || npcPawnPassThroughComponent.TmpSeg == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpSeg), "TmpSeg")) && (!base.CanResetComponentProperty("OtherPointA") || npcPawnPassThroughComponent.OtherPointA == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.OtherPointA), "OtherPointA")) && (!base.CanResetComponentProperty("OtherPointB") || npcPawnPassThroughComponent.OtherPointB == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.OtherPointB), "OtherPointB"));
	}

	// Token: 0x0400D825 RID: 55333
	[StaticVariableRuleIgnore]
	private static readonly ECollisionChannel[] PASS_THROUGH_CHANNELS = new ECollisionChannel[]
	{
		KuroCollisionChannel.Pawn,
		KuroCollisionChannel.PawnPlayer,
		KuroCollisionChannel.PawnMonster,
		KuroCollisionChannel.Vehicle
	};

	// Token: 0x0400D826 RID: 55334
	private const float MIN_DITHER_ALPHA = 0.3f;

	// Token: 0x0400D827 RID: 55335
	[Nullable(2)]
	private BaseCharacterComponent ActorComp;

	// Token: 0x0400D828 RID: 55336
	[Nullable(2)]
	private UCapsuleComponent Capsule;

	// Token: 0x0400D829 RID: 55337
	private float ReferenceRadius;

	// Token: 0x0400D82A RID: 55338
	private readonly HashSet<BaseCharacterComponent> OverlapActorComps = new HashSet<BaseCharacterComponent>();

	// Token: 0x0400D82B RID: 55339
	private readonly List<ECollisionChannel> DowngradedChannels = new List<ECollisionChannel>();

	// Token: 0x0400D82C RID: 55340
	private int? DisableHandle;

	// Token: 0x0400D82D RID: 55341
	private readonly Vector SelfPointA = Vector.Create();

	// Token: 0x0400D82E RID: 55342
	private readonly Vector SelfPointB = Vector.Create();

	// Token: 0x0400D82F RID: 55343
	private readonly Vector TmpSeg = Vector.Create();

	// Token: 0x0400D830 RID: 55344
	private readonly Vector OtherPointA = Vector.Create();

	// Token: 0x0400D831 RID: 55345
	private readonly Vector OtherPointB = Vector.Create();
}
