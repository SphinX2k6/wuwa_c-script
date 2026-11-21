using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

// Token: 0x02002409 RID: 9225
[NullableContext(1)]
[Nullable(0)]
public class CustomMoveToLocation : CustomActionBase
{
	// Token: 0x06017174 RID: 94580 RVA: 0x006BFD3E File Offset: 0x006BDF3E
	public CustomMoveToLocation(CharacterMoveComponent moveComp, CharacterAnimationComponent animComp, Vector targetLocation, [Nullable(2)] Action callback = null, [Nullable(2)] Action onStart = null, int modelBufferTime = 200)
	{
		this.MoveComp = moveComp;
		this.AnimComp = animComp;
		this.TargetLocation = targetLocation;
		this.Callback = callback;
		this.OnStart = onStart;
		this.ModelBufferTime = modelBufferTime;
	}

	// Token: 0x06017175 RID: 94581 RVA: 0x006BFD74 File Offset: 0x006BDF74
	protected override void OnRunAction()
	{
		if (this.MoveComp == null || this.TargetLocation == null)
		{
			base.Finish(false);
			return;
		}
		MoveCharacterPoint value = new MoveCharacterPoint
		{
			Index = 0,
			Position = this.TargetLocation,
			MoveState = new EPatrolMoveState?(EPatrolMoveState.Walk)
		};
		MoveCharacterConfig config = new MoveCharacterConfig
		{
			Points = value,
			Navigation = true,
			IsFly = false,
			DebugMode = true,
			Loop = false,
			Callback = delegate(ELevelEventState result)
			{
				CharacterAnimationComponent animComp = this.AnimComp;
				FTransformDouble? ftransformDouble = (animComp != null) ? new FTransformDouble?(animComp.GetMeshTransform()) : null;
				if (ftransformDouble != null)
				{
					CharacterActorComponent actorComp = this.MoveComp.ActorComp;
					if (actorComp != null)
					{
						actorComp.SetActorLocation(this.TargetLocation.ToUeVector(false), "[CharacterCustomActionComponent]", false);
					}
					CharacterAnimationComponent animComp2 = this.AnimComp;
					if (animComp2 != null)
					{
						animComp2.SetModelBuffer(ftransformDouble.Value, (float)this.ModelBufferTime);
					}
				}
				CharacterUnifiedStateComponent component = this.MoveComp.Entity.GetComponent<CharacterUnifiedStateComponent>();
				if (component != null)
				{
					component.SetMoveState(ECharMoveState.Stand);
				}
				base.Finish(true);
			},
			ReturnTimeoutFailed = new float?((float)2),
			ReturnFalseWhenNavigationFailed = false,
			Distance = new float?((float)10)
		};
		this.MoveComp.MoveAlongPath(config, "CustomMoveToLocation.OnStart");
	}

	// Token: 0x06017176 RID: 94582 RVA: 0x006BFE32 File Offset: 0x006BE032
	protected override void OnAbort()
	{
		this.MoveComp.MoveController.StopMoveWithCallback(ELevelEventState.Success, null);
	}

	// Token: 0x0400C24B RID: 49739
	private readonly CharacterMoveComponent MoveComp;

	// Token: 0x0400C24C RID: 49740
	private readonly CharacterAnimationComponent AnimComp;

	// Token: 0x0400C24D RID: 49741
	private readonly Vector TargetLocation;

	// Token: 0x0400C24E RID: 49742
	private readonly int ModelBufferTime;
}
