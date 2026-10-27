using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02004753 RID: 18259
	public class WuWaGoTraversalGridEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x0602FB79 RID: 195449 RVA: 0x00B0DDB3 File Offset: 0x00B0BFB3
		[NullableContext(1)]
		public WuWaGoTraversalGridEntity(EWuWaGoEntityType entityType, int pbDataId, Vector coordinate, Rotator rotator) : base(entityType, pbDataId, coordinate, rotator)
		{
		}

		// Token: 0x17007742 RID: 30530
		// (get) Token: 0x0602FB7A RID: 195450 RVA: 0x00B0DDC0 File Offset: 0x00B0BFC0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<IWuWaGoHintStepBase> HintSteps
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this.HintStepsInner;
			}
		}

		// Token: 0x0602FB7B RID: 195451 RVA: 0x00B0DDC8 File Offset: 0x00B0BFC8
		public void SetHintSteps([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<IWuWaGoHintStepBase> steps)
		{
			this.HintStepsInner = steps;
		}

		// Token: 0x0602FB7C RID: 195452 RVA: 0x00B0DDD4 File Offset: 0x00B0BFD4
		public override void Unlock()
		{
			EGameplayEntityState state = (this.EntityType == EWuWaGoEntityType.StartGrid) ? EGameplayEntityState.Activated : EGameplayEntityState.Normal;
			this.SetState(state);
		}

		// Token: 0x0602FB7D RID: 195453 RVA: 0x00B0DDF8 File Offset: 0x00B0BFF8
		public override void RestoreInitialStateForGameOver()
		{
			this.SetState(EGameplayEntityState.Locked);
		}

		// Token: 0x0602FB7E RID: 195454 RVA: 0x00B0DE02 File Offset: 0x00B0C002
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			base.SwitchSceneItemStateByGameplayEntityState(newState, true, false);
		}

		// Token: 0x04019C10 RID: 105488
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IReadOnlyList<IWuWaGoHintStepBase> HintStepsInner;
	}
}
