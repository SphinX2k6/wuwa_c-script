using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002FD3 RID: 12243
public class GameplayCueSkillTargetBeam : GameplayCueBase
{
	// Token: 0x06019F4A RID: 106314 RVA: 0x006CAA00 File Offset: 0x006C8C00
	protected override void OnInit()
	{
		this.Socket = FNameUtil.GetDynamicFName(this.CueConfig.Socket);
		Aki.Config.Vector value = this.CueConfig.Location.Value;
		this.MyOffset = new FVectorDouble((double)value.X, (double)value.Y, (double)value.Z);
		Aki.Config.Vector value2 = this.CueConfig.Rotation.Value;
		this.TargetOffset = new FVectorDouble((double)value2.X, (double)value2.Y, (double)value2.Z);
		this.TargetPoint = this.ActorInternal.D_GetTransform().TransformPositionNoScale(this.MyOffset);
	}

	// Token: 0x06019F4B RID: 106315 RVA: 0x006CAAB0 File Offset: 0x006C8CB0
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

	// Token: 0x06019F4C RID: 106316 RVA: 0x006CAC03 File Offset: 0x006C8E03
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

	// Token: 0x06019F4D RID: 106317 RVA: 0x006CAC20 File Offset: 0x006C8E20
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

	// Token: 0x06019F4E RID: 106318 RVA: 0x006CACB8 File Offset: 0x006C8EB8
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

	// Token: 0x06019F4F RID: 106319 RVA: 0x006CACFD File Offset: 0x006C8EFD
	protected override void OnCreate()
	{
		this.BeamItem = GameplayCueBeamCommonItem.Spawn(this.ActorInternal, this.CueConfig.Path, null);
	}

	// Token: 0x06019F50 RID: 106320 RVA: 0x006CAD1C File Offset: 0x006C8F1C
	protected override void OnDestroy()
	{
		this.BeamItem.Destroy();
	}

	// Token: 0x06019F51 RID: 106321 RVA: 0x006CAD29 File Offset: 0x006C8F29
	public override void OnEnable()
	{
		this.BeamItem.GetOwner().SetActorHiddenInGame(false);
	}

	// Token: 0x06019F52 RID: 106322 RVA: 0x006CAD3C File Offset: 0x006C8F3C
	public override void OnDisable()
	{
		this.BeamItem.GetOwner().SetActorHiddenInGame(true);
	}

	// Token: 0x0400C47B RID: 50299
	private FName? Socket;

	// Token: 0x0400C47C RID: 50300
	[Nullable(2)]
	private GameplayCueBeamCommonItem BeamItem;

	// Token: 0x0400C47D RID: 50301
	private FVectorDouble MyOffset;

	// Token: 0x0400C47E RID: 50302
	private FVectorDouble TargetOffset;

	// Token: 0x0400C47F RID: 50303
	private FVectorDouble TargetPoint;

	// Token: 0x0400C480 RID: 50304
	private FTransformDouble TargetTransform;
}
