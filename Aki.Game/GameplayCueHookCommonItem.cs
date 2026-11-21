using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x020024FF RID: 9471
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueHookCommonItem
{
	// Token: 0x0601771A RID: 96026 RVA: 0x006EA3E9 File Offset: 0x006E85E9
	private GameplayCueHookCommonItem(ABaseCharacter owner, FName socket, FVectorDouble targetPosition, string[] paths)
	{
		this.Owner = owner;
		this.Socket = socket;
		this.TargetPosition = targetPosition;
		this.Paths = paths;
	}

	// Token: 0x0601771B RID: 96027 RVA: 0x006EA40E File Offset: 0x006E860E
	public static GameplayCueHookCommonItem Spawn(ABaseCharacter owner, FName socket, FVectorDouble targetPosition, string[] paths, bool lineAttach = true)
	{
		GameplayCueHookCommonItem gameplayCueHookCommonItem = new GameplayCueHookCommonItem(owner, socket, targetPosition, paths);
		gameplayCueHookCommonItem.IsActive = true;
		gameplayCueHookCommonItem.HookActor = gameplayCueHookCommonItem.SpawnHookActor(lineAttach);
		gameplayCueHookCommonItem.EffectViewHandle = gameplayCueHookCommonItem.CreateBallEffect();
		return gameplayCueHookCommonItem;
	}

	// Token: 0x0601771C RID: 96028 RVA: 0x006EA43C File Offset: 0x006E863C
	public void Destroy()
	{
		this.IsActive = false;
		this.NiagaraComp = null;
		ActorSystem.Instance.Put("GameplayCueHookCommonItem.Destroy", this.HookActor, null);
		if (EffectSystem.Instance.IsValid(this.EffectViewHandle))
		{
			EffectSystem.Instance.StopEffectById(this.EffectViewHandle, "[GameplayCueHookCommonItem.Destroy]", true, null);
		}
		this.DestroyBallEffect();
	}

	// Token: 0x0601771D RID: 96029 RVA: 0x006EA4A8 File Offset: 0x006E86A8
	public void Tick(FVectorDouble position)
	{
		this.TargetPosition.Set(position.X, position.Y, position.Z);
		if (EffectSystem.Instance.IsValid(this.EffectViewHandle))
		{
			EffectSystem.Instance.GetEffectActor(this.EffectViewHandle).D_K2_SetActorLocation(position, false, ref WorldGlobal.SweepHitResult, true);
		}
		FVector inValue = UKismetMathLibrary.WD_WorldToLocal(GlobalData.World, position);
		UNiagaraComponent niagaraComp = this.NiagaraComp;
		if (niagaraComp == null)
		{
			return;
		}
		niagaraComp.SetNiagaraVariableVec3("end", inValue);
	}

	// Token: 0x0601771E RID: 96030 RVA: 0x006EA528 File Offset: 0x006E8728
	private AActor SpawnHookActor(bool needAttach = true)
	{
		AActor actor = ActorSystem.Instance.Get(AActor.StaticClass(), this.Owner.D_GetTransform(), null, true);
		TTimerAction <>9__1;
		ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(this.Paths[0], delegate([Nullable(2)] UNiagaraSystem effectObject, string _)
		{
			if (this.IsActive && effectObject != null && effectObject.IsValid())
			{
				AActor actor = actor;
				if (actor != null && actor.IsValid())
				{
					this.NiagaraComp = (actor.AddComponentByClass(UNiagaraComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UNiagaraComponent);
					this.NiagaraComp.SetAsset(effectObject, true);
					this.NiagaraComp.SetRenderInBurst(true);
					FVector inValue = UKismetMathLibrary.WD_WorldToLocal(GlobalData.World, this.TargetPosition);
					this.NiagaraComp.SetNiagaraVariableVec3("end", inValue);
					TimerSystemInstance instance = TimerSystem.Instance;
					TTimerAction action;
					if ((action = <>9__1) == null)
					{
						action = (<>9__1 = delegate(float _)
						{
							UKuroEffectLibrary.SetNiagaraSimulationMinDeltaTime(this.NiagaraComp, -1f);
						});
					}
					instance.Next(action, null, null);
					if (needAttach)
					{
						actor.K2_AttachToComponent(this.Owner.Mesh, this.Socket, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
						return;
					}
					USkeletalMeshComponent mesh = this.Owner.Mesh;
					FTransformDouble ftransformDouble = (mesh != null) ? mesh.D_GetSocketTransform(this.Socket, ERelativeTransformSpace.RTS_World) : this.Owner.D_GetTransform();
					actor.D_K2_SetActorTransform(ftransformDouble, false, null, false);
					return;
				}
			}
		}, 100, "js_undefined");
		return actor;
	}

	// Token: 0x0601771F RID: 96031 RVA: 0x006EA598 File Offset: 0x006E8798
	private int CreateBallEffect()
	{
		if (this.Paths.Length < 2)
		{
			return 0;
		}
		ABaseCharacter owner = this.Owner;
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		int entityId;
		if (tsBaseCharacter == null)
		{
			TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
			if (tsBaseVehicle == null)
			{
				<PrivateImplementationDetails>.ThrowSwitchExpressionException(owner);
			}
			else
			{
				entityId = tsBaseVehicle.EntityId;
			}
		}
		else
		{
			entityId = tsBaseCharacter.EntityId;
		}
		int num = entityId;
		EffectSystem instance = EffectSystem.Instance;
		UObject owner2 = this.Owner;
		FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref this.TargetPosition));
		int num2 = instance.SpawnEffect(owner2, ftransformDouble, this.Paths[1], "[GameplayCueHookCommonItem.CreateBallEffect]", new EffectContext(new int?(num), null, false), EEffectType.Fight, null, null, null, false, false);
		EffectUtil.SetAdditionalEffectTimeScaleByEntity(CreatureModel.Instance.GetEntityById(num), num2);
		return num2;
	}

	// Token: 0x06017720 RID: 96032 RVA: 0x006EA648 File Offset: 0x006E8848
	private void DestroyBallEffect()
	{
		if (this.Paths.Length < 3)
		{
			return;
		}
		ABaseCharacter owner = this.Owner;
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		int entityId;
		if (tsBaseCharacter == null)
		{
			TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
			if (tsBaseVehicle == null)
			{
				<PrivateImplementationDetails>.ThrowSwitchExpressionException(owner);
			}
			else
			{
				entityId = tsBaseVehicle.EntityId;
			}
		}
		else
		{
			entityId = tsBaseCharacter.EntityId;
		}
		int num = entityId;
		EffectSystem instance = EffectSystem.Instance;
		UObject owner2 = this.Owner;
		FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref this.TargetPosition));
		int effectId = instance.SpawnEffect(owner2, ftransformDouble, this.Paths[2], "[GameplayCueHookCommonItem.DestroyBallEffect]", new EffectContext(new int?(num), null, false), EEffectType.Fight, null, null, null, false, false);
		EffectUtil.SetAdditionalEffectTimeScaleByEntity(CreatureModel.Instance.GetEntityById(num), effectId);
	}

	// Token: 0x0400C753 RID: 51027
	[Nullable(2)]
	private AActor HookActor;

	// Token: 0x0400C754 RID: 51028
	private int EffectViewHandle;

	// Token: 0x0400C755 RID: 51029
	private bool IsActive;

	// Token: 0x0400C756 RID: 51030
	[Nullable(2)]
	private UNiagaraComponent NiagaraComp;

	// Token: 0x0400C757 RID: 51031
	private readonly ABaseCharacter Owner;

	// Token: 0x0400C758 RID: 51032
	private readonly FName Socket;

	// Token: 0x0400C759 RID: 51033
	public FVectorDouble TargetPosition;

	// Token: 0x0400C75A RID: 51034
	public readonly string[] Paths;
}
