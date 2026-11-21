using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;

// Token: 0x02002748 RID: 10056
[NullableContext(1)]
[Nullable(0)]
public class NpcPawnPassThroughComponent : EntityComponent
{
	// Token: 0x060193BE RID: 103358 RVA: 0x007B4B8C File Offset: 0x007B2D8C
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

	// Token: 0x060193BF RID: 103359 RVA: 0x007B4CC8 File Offset: 0x007B2EC8
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

	// Token: 0x060193C0 RID: 103360 RVA: 0x007B4D60 File Offset: 0x007B2F60
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

	// Token: 0x060193C1 RID: 103361 RVA: 0x007B4E48 File Offset: 0x007B3048
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

	// Token: 0x060193C2 RID: 103362 RVA: 0x007B4EE8 File Offset: 0x007B30E8
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

	// Token: 0x060193C3 RID: 103363 RVA: 0x007B4F40 File Offset: 0x007B3140
	private void RestoreCollision()
	{
		foreach (ECollisionChannel channel in this.DowngradedChannels)
		{
			this.Capsule.SetCollisionResponseToChannel(channel, ECollisionResponse.ECR_Block);
		}
	}

	// Token: 0x060193C4 RID: 103364 RVA: 0x007B4F9C File Offset: 0x007B319C
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

	// Token: 0x060193C5 RID: 103365 RVA: 0x007B4FF8 File Offset: 0x007B31F8
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

	// Token: 0x060193C6 RID: 103366 RVA: 0x007B503C File Offset: 0x007B323C
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

	// Token: 0x060193C7 RID: 103367 RVA: 0x007B5084 File Offset: 0x007B3284
	private void MarkOverlapEmpty()
	{
		if (this.DisableHandle == null)
		{
			this.DisableHandle = new int?(base.Disable("PawnPassThrough无重叠"));
		}
	}

	// Token: 0x060193C8 RID: 103368 RVA: 0x007B50AC File Offset: 0x007B32AC
	private float CalcDitherAlpha(BaseCharacterComponent otherActorComp)
	{
		float val = this.GetSegmentDistToOwnCapsule(otherActorComp) - otherActorComp.ScaledRadius;
		return MathUtils.Instance.RangeClamp(Math.Max(0f, val) / this.ReferenceRadius, 0f, 1f, 0.3f, 1f);
	}

	// Token: 0x060193C9 RID: 103369 RVA: 0x007B50F8 File Offset: 0x007B32F8
	private void UpdateSelfCapsuleSegment()
	{
		Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		Vector actorUpProxy = this.ActorComp.ActorUpProxy;
		float num = Math.Max(0f, this.ActorComp.ScaledHalfHeight - this.ActorComp.ScaledRadius);
		actorUpProxy.Multiply((double)num, this.TmpSeg);
		actorLocationProxy.Addition(this.TmpSeg, this.SelfPointA);
		actorLocationProxy.Subtraction(this.TmpSeg, this.SelfPointB);
	}

	// Token: 0x060193CA RID: 103370 RVA: 0x007B5170 File Offset: 0x007B3370
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

	// Token: 0x060193CB RID: 103371 RVA: 0x007B51F7 File Offset: 0x007B33F7
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

	// Token: 0x060193CC RID: 103372 RVA: 0x007B5218 File Offset: 0x007B3418
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

	// Token: 0x060193CD RID: 103373 RVA: 0x007B5268 File Offset: 0x007B3468
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		NpcPawnPassThroughComponent npcPawnPassThroughComponent = (NpcPawnPassThroughComponent)componentTemplate;
		if (npcPawnPassThroughComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (npcPawnPassThroughComponent.Capsule == null)
		{
			this.Capsule = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Capsule), "Capsule"))
		{
			return false;
		}
		this.ReferenceRadius = npcPawnPassThroughComponent.ReferenceRadius;
		if (npcPawnPassThroughComponent.OverlapActorComps != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<BaseCharacterComponent>(this.OverlapActorComps), "OverlapActorComps"))
		{
			return false;
		}
		if (npcPawnPassThroughComponent.DowngradedChannels != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DowngradedChannels), "DowngradedChannels"))
		{
			return false;
		}
		this.DisableHandle = npcPawnPassThroughComponent.DisableHandle;
		return (npcPawnPassThroughComponent.SelfPointA == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.SelfPointA), "SelfPointA")) && (npcPawnPassThroughComponent.SelfPointB == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.SelfPointB), "SelfPointB")) && (npcPawnPassThroughComponent.TmpSeg == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpSeg), "TmpSeg")) && (npcPawnPassThroughComponent.OtherPointA == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.OtherPointA), "OtherPointA")) && (npcPawnPassThroughComponent.OtherPointB == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.OtherPointB), "OtherPointB"));
	}

	// Token: 0x17002834 RID: 10292
	// (get) Token: 0x060193CE RID: 103374 RVA: 0x007B53E4 File Offset: 0x007B35E4
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002835 RID: 10293
	// (get) Token: 0x060193CF RID: 103375 RVA: 0x007B53E7 File Offset: 0x007B35E7
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002836 RID: 10294
	// (get) Token: 0x060193D0 RID: 103376 RVA: 0x007B53EA File Offset: 0x007B35EA
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DCB7 RID: 56503
	[StaticVariableRuleIgnore]
	private static readonly ECollisionChannel[] PASS_THROUGH_CHANNELS = new ECollisionChannel[]
	{
		KuroCollisionChannel.Pawn,
		KuroCollisionChannel.PawnPlayer,
		KuroCollisionChannel.PawnMonster,
		KuroCollisionChannel.Vehicle
	};

	// Token: 0x0400DCB8 RID: 56504
	private const float MIN_DITHER_ALPHA = 0.3f;

	// Token: 0x0400DCB9 RID: 56505
	[Nullable(2)]
	private BaseCharacterComponent ActorComp;

	// Token: 0x0400DCBA RID: 56506
	[Nullable(2)]
	private UCapsuleComponent Capsule;

	// Token: 0x0400DCBB RID: 56507
	private float ReferenceRadius;

	// Token: 0x0400DCBC RID: 56508
	private readonly HashSet<BaseCharacterComponent> OverlapActorComps = new HashSet<BaseCharacterComponent>();

	// Token: 0x0400DCBD RID: 56509
	private readonly List<ECollisionChannel> DowngradedChannels = new List<ECollisionChannel>();

	// Token: 0x0400DCBE RID: 56510
	private int? DisableHandle;

	// Token: 0x0400DCBF RID: 56511
	private readonly Vector SelfPointA = Vector.Create();

	// Token: 0x0400DCC0 RID: 56512
	private readonly Vector SelfPointB = Vector.Create();

	// Token: 0x0400DCC1 RID: 56513
	private readonly Vector TmpSeg = Vector.Create();

	// Token: 0x0400DCC2 RID: 56514
	private readonly Vector OtherPointA = Vector.Create();

	// Token: 0x0400DCC3 RID: 56515
	private readonly Vector OtherPointB = Vector.Create();
}
