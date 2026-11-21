using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02003681 RID: 13953
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoPullRodEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x06024325 RID: 148261 RVA: 0x00A3D9F1 File Offset: 0x00A3BBF1
		public WuWaGoPullRodEntity(int pbDataId, Vector coordinate, Rotator rotator, IWuWaGoPullRod config) : base(EWuWaGoEntityType.PullRod, pbDataId, coordinate, rotator)
		{
		}

		// Token: 0x06024326 RID: 148262 RVA: 0x00A3DA0C File Offset: 0x00A3BC0C
		public IPullRodInteractResult Interact()
		{
			EGameplayEntityState state = base.State;
			EGameplayEntityState egameplayEntityState = (base.State == EGameplayEntityState.Normal) ? EGameplayEntityState.Activated : EGameplayEntityState.Normal;
			this.SetState(egameplayEntityState);
			return new PullRodInteractResult
			{
				PreviousState = state,
				CurrentState = egameplayEntityState,
				StateAction = this.GetActionByState(state)
			};
		}

		// Token: 0x06024327 RID: 148263 RVA: 0x00A3DA56 File Offset: 0x00A3BC56
		[NullableContext(2)]
		public IWuWaGoInteractStateAction GetActionByState()
		{
			return this.GetActionByState(base.State);
		}

		// Token: 0x06024328 RID: 148264 RVA: 0x00A3DA64 File Offset: 0x00A3BC64
		[NullableContext(2)]
		public IWuWaGoInteractStateAction GetActionByState(EGameplayEntityState state)
		{
			for (int i = 0; i < this.InteractConfig.Count; i++)
			{
				IWuWaGoInteractStateAction wuWaGoInteractStateAction = this.InteractConfig[i];
				EGameplayEntityState egameplayEntityState;
				if (EGameplayEntityStateExtensions.TryFromString(wuWaGoInteractStateAction.EntityState, out egameplayEntityState) && egameplayEntityState == state)
				{
					return wuWaGoInteractStateAction;
				}
			}
			return null;
		}

		// Token: 0x06024329 RID: 148265 RVA: 0x00A3DAAA File Offset: 0x00A3BCAA
		public override void RestoreInitialStateForGameOver()
		{
			base.RestoreInitialStateWithStateChanged();
		}

		// Token: 0x0602432A RID: 148266 RVA: 0x00A3DAB2 File Offset: 0x00A3BCB2
		public override IRollbackCapture CaptureRollback()
		{
			return new PullRodRollbackCapture(this);
		}

		// Token: 0x0602432B RID: 148267 RVA: 0x00A3DABA File Offset: 0x00A3BCBA
		public void SyncPresentationForRollback()
		{
			base.SwitchSceneItemStateByGameplayEntityState(base.State, false, true);
		}

		// Token: 0x0602432C RID: 148268 RVA: 0x00A3DACC File Offset: 0x00A3BCCC
		[NullableContext(2)]
		public Vector GetFacingTargetWorldPosition()
		{
			AActor actorRaw = this.GetActorRaw();
			if (actorRaw == null || !actorRaw.IsValid())
			{
				return null;
			}
			TArray<AActor> tarray = new TArray<AActor>();
			actorRaw.GetAttachedActors(ref tarray, true);
			AActor aactor = (tarray.Num() > 0) ? tarray.Get(0) : null;
			AActor aactor2 = (aactor != null && aactor.IsValid()) ? aactor : actorRaw;
			if (aactor != null && aactor.IsValid())
			{
				TArray<AActor> tarray2 = new TArray<AActor>();
				aactor.GetAttachedActors(ref tarray2, true);
				AActor aactor3 = (tarray2.Num() > 0) ? tarray2.Get(0) : null;
				if (aactor3 != null && aactor3.IsValid())
				{
					aactor2 = aactor3;
				}
			}
			return Vector.Create(aactor2.D_K2_GetActorLocation());
		}

		// Token: 0x0602432D RID: 148269 RVA: 0x00A3DB78 File Offset: 0x00A3BD78
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			base.SwitchSceneItemStateByGameplayEntityState(newState, true, false);
		}

		// Token: 0x040142B7 RID: 82615
		public readonly IReadOnlyList<IWuWaGoInteractStateAction> InteractConfig = config.InteractConfig;
	}
}
