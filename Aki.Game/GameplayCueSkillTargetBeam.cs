using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002527 RID: 9511
public class GameplayCueSkillTargetBeam : GameplayCueBase
{
	// Token: 0x0601785C RID: 96348 RVA: 0x006F12F4 File Offset: 0x006EF4F4
	protected override void OnInit()
	{
		this.Socket = FNameUtil.GetDynamicFName(this.CueConfig.Socket);
		Aki.Config.Vector value = this.CueConfig.Location.Value;
		this.MyOffset = new FVectorDouble((double)value.X, (double)value.Y, (double)value.Z);
		Aki.Config.Vector value2 = this.CueConfig.Rotation.Value;
		this.TargetOffset = new FVectorDouble((double)value2.X, (double)value2.Y, (double)value2.Z);
		this.TargetPoint = this.ActorInternal.D_GetTransform().TransformPositionNoScale(this.MyOffset);
	}

	// Token: 0x0601785D RID: 96349 RVA: 0x006F13A4 File Offset: 0x006EF5A4
	protected override void OnTick(float delta)
	{
		FVectorDouble fvectorDouble = (this.Socket != null) ? this.ActorInternal.Mesh.D_GetSocketLocation(this.Socket.Value) : this.ActorInternal.D_K2_GetActorLocation();
		ValueTuple<EntityHandle, string> targetAndSocket = this.GetTargetAndSocket();
		EntityHandle item = targetAndSocket.Item1;
		string item2 = targetAndSocket.Item2;
		if (item != null)
		{
			if (!string.IsNullOrEmpty(item2))
			{
				WorldEntity entity = item.Entity;
				CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
				if (characterActorComponent != null)
				{
					FVectorDouble fvectorDouble2 = characterActorComponent.Actor.Mesh.D_GetSocketLocation(FNameUtil.GetDynamicFName(item2).Value);
					FQuat actorQuat = characterActorComponent.ActorQuat;
					FVectorDouble actorScale = characterActorComponent.ActorScale;
					FTransformDouble targetTransform = this.TargetTransform;
					this.TargetTransform.SetLocation(fvectorDouble2);
					this.TargetTransform.SetRotation(actorQuat);
					this.TargetTransform.SetScale3D(actorScale);
					this.TargetPoint = this.TargetTransform.TransformPositionNoScale(this.TargetOffset);
				}
			}
			else
			{
				WorldEntity entity2 = item.Entity;
				BaseActorComponent baseActorComponent = (entity2 != null) ? entity2.GetComponent<BaseActorComponent>() : null;
				if (baseActorComponent != null)
				{
					this.TargetPoint = baseActorComponent.ActorTransform.TransformPositionNoScale(this.TargetOffset);
				}
			}
		}
		this.BeamItem.Tick(new FVectorDouble[]
		{
			fvectorDouble,
			this.TargetPoint
		}, delta);
	}

	// Token: 0x0601785E RID: 96350 RVA: 0x006F14F7 File Offset: 0x006EF6F7
	[return: TupleElementNames(new string[]
	{
		"Target",
		"TargetSocket"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2,
		1
	})]
	private ValueTuple<EntityHandle, string> GetTargetAndSocket()
	{
		if (GameplayCueController.GetTargetSourceType(this.CueConfig) == ETargetSourceType.Skill)
		{
			return this.GetSkillTargetAndSocket();
		}
		return this.GetLockOnTargetAndSocket();
	}

	// Token: 0x0601785F RID: 96351 RVA: 0x006F1514 File Offset: 0x006EF714
	[return: TupleElementNames(new string[]
	{
		"Target",
		"TargetSocket"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2,
		1
	})]
	private ValueTuple<EntityHandle, string> GetLockOnTargetAndSocket()
	{
		EntityHandle item = null;
		string item2 = string.Empty;
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterLockOnComponent characterLockOnComponent = (entity != null) ? entity.GetComponent<CharacterLockOnComponent>() : null;
		WorldEntity entity2 = this.EntityHandle.Entity;
		CharacterActorComponent characterActorComponent = (entity2 != null) ? entity2.GetComponent<CharacterActorComponent>() : null;
		if (characterLockOnComponent != null && characterActorComponent != null && characterActorComponent.IsAutonomousProxy)
		{
			item = characterLockOnComponent.GetCurrentTarget();
			item2 = characterLockOnComponent.GetCurrentTargetSocketName();
		}
		else
		{
			WorldEntity entity3 = this.EntityHandle.Entity;
			CharacterSkillComponent characterSkillComponent = (entity3 != null) ? entity3.GetComponent<CharacterSkillComponent>() : null;
			if (characterSkillComponent != null)
			{
				item = characterSkillComponent.SkillTarget;
				item2 = characterSkillComponent.SkillTargetSocket;
			}
		}
		return new ValueTuple<EntityHandle, string>(item, item2);
	}

	// Token: 0x06017860 RID: 96352 RVA: 0x006F15AC File Offset: 0x006EF7AC
	[return: TupleElementNames(new string[]
	{
		"Target",
		"TargetSocket"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2,
		1
	})]
	private ValueTuple<EntityHandle, string> GetSkillTargetAndSocket()
	{
		EntityHandle item = null;
		string item2 = string.Empty;
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterSkillComponent characterSkillComponent = (entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null;
		if (characterSkillComponent != null)
		{
			item = characterSkillComponent.SkillTarget;
			item2 = characterSkillComponent.SkillTargetSocket;
		}
		return new ValueTuple<EntityHandle, string>(item, item2);
	}

	// Token: 0x06017861 RID: 96353 RVA: 0x006F15F1 File Offset: 0x006EF7F1
	protected override void OnCreate()
	{
		this.BeamItem = GameplayCueBeamCommonItem.Spawn(this.ActorInternal, this.CueConfig.Path, null);
	}

	// Token: 0x06017862 RID: 96354 RVA: 0x006F1610 File Offset: 0x006EF810
	protected override void OnDestroy()
	{
		this.BeamItem.Destroy();
	}

	// Token: 0x06017863 RID: 96355 RVA: 0x006F161D File Offset: 0x006EF81D
	public override void OnEnable()
	{
		this.BeamItem.GetOwner().SetActorHiddenInGame(false);
	}

	// Token: 0x06017864 RID: 96356 RVA: 0x006F1630 File Offset: 0x006EF830
	public override void OnDisable()
	{
		this.BeamItem.GetOwner().SetActorHiddenInGame(true);
	}

	// Token: 0x0400C824 RID: 51236
	private FName? Socket;

	// Token: 0x0400C825 RID: 51237
	[Nullable(2)]
	private GameplayCueBeamCommonItem BeamItem;

	// Token: 0x0400C826 RID: 51238
	private FVectorDouble MyOffset;

	// Token: 0x0400C827 RID: 51239
	private FVectorDouble TargetOffset;

	// Token: 0x0400C828 RID: 51240
	private FVectorDouble TargetPoint;

	// Token: 0x0400C829 RID: 51241
	private FTransformDouble TargetTransform;
}
