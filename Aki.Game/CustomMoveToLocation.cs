using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

// Token: 0x02002EB6 RID: 11958
[NullableContext(1)]
[Nullable(0)]
public class CustomMoveToLocation : CustomActionBase
{
	// Token: 0x0601988E RID: 104590 RVA: 0x00699A7E File Offset: 0x00697C7E
	public CustomMoveToLocation(CharacterMoveComponent moveComp, CharacterAnimationComponent animComp, Vector targetLocation, [Nullable(2)] Action callback = null, [Nullable(2)] Action onStart = null, int modelBufferTime = 200)
	{
		this.MoveComp = moveComp;
		this.AnimComp = animComp;
		this.TargetLocation = targetLocation;
		this.Callback = callback;
		this.OnStart = onStart;
		this.ModelBufferTime = modelBufferTime;
	}

	// Token: 0x0601988F RID: 104591 RVA: 0x00699AB4 File Offset: 0x00697CB4
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

	// Token: 0x06019890 RID: 104592 RVA: 0x00699B72 File Offset: 0x00697D72
	protected override void OnAbort()
	{
		this.MoveComp.MoveController.StopMoveWithCallback(ELevelEventState.Success, null);
	}

	// Token: 0x0400BEB0 RID: 48816
	private readonly CharacterMoveComponent MoveComp;

	// Token: 0x0400BEB1 RID: 48817
	private readonly CharacterAnimationComponent AnimComp;

	// Token: 0x0400BEB2 RID: 48818
	private readonly Vector TargetLocation;

	// Token: 0x0400BEB3 RID: 48819
	private readonly int ModelBufferTime;
}
