using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02004750 RID: 18256
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoPullRodEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x0602FB5B RID: 195419 RVA: 0x00B0DA11 File Offset: 0x00B0BC11
		public WuWaGoPullRodEntity(int pbDataId, Vector coordinate, Rotator rotator, IWuWaGoPullRod config) : base(EWuWaGoEntityType.PullRod, pbDataId, coordinate, rotator)
		{
		}

		// Token: 0x0602FB5C RID: 195420 RVA: 0x00B0DA2C File Offset: 0x00B0BC2C
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

		// Token: 0x0602FB5D RID: 195421 RVA: 0x00B0DA76 File Offset: 0x00B0BC76
		[NullableContext(2)]
		public IWuWaGoInteractStateAction GetActionByState()
		{
			return this.GetActionByState(base.State);
		}

		// Token: 0x0602FB5E RID: 195422 RVA: 0x00B0DA84 File Offset: 0x00B0BC84
		[NullableContext(2)]
		public IWuWaGoInteractStateAction GetActionByState(EGameplayEntityState state)
		{
			return this.InteractConfig.FirstOrDefault(delegate(IWuWaGoInteractStateAction config)
			{
				EGameplayEntityState egameplayEntityState;
				return EGameplayEntityStateExtensions.TryFromString(config.EntityState, out egameplayEntityState) && egameplayEntityState == state;
			});
		}

		// Token: 0x0602FB5F RID: 195423 RVA: 0x00B0DAB5 File Offset: 0x00B0BCB5
		public override void RestoreInitialStateForGameOver()
		{
			base.RestoreInitialStateWithStateChanged();
		}

		// Token: 0x0602FB60 RID: 195424 RVA: 0x00B0DABD File Offset: 0x00B0BCBD
		public override IRollbackCapture CaptureRollback()
		{
			return new PullRodRollbackCapture(this);
		}

		// Token: 0x0602FB61 RID: 195425 RVA: 0x00B0DAC5 File Offset: 0x00B0BCC5
		public void SyncPresentationForRollback()
		{
			base.SwitchSceneItemStateByGameplayEntityState(base.State, false, true);
		}

		// Token: 0x0602FB62 RID: 195426 RVA: 0x00B0DAD8 File Offset: 0x00B0BCD8
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

		// Token: 0x0602FB63 RID: 195427 RVA: 0x00B0DB84 File Offset: 0x00B0BD84
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			base.SwitchSceneItemStateByGameplayEntityState(newState, true, false);
		}

		// Token: 0x04019C07 RID: 105479
		public readonly IReadOnlyList<IWuWaGoInteractStateAction> InteractConfig = config.InteractConfig;
	}
}
