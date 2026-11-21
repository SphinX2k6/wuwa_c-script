using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02003684 RID: 13956
	public class WuWaGoTraversalGridEntity : WuWaGoGameplayEntityBase
	{
		// Token: 0x06024343 RID: 148291 RVA: 0x00A3DDA7 File Offset: 0x00A3BFA7
		[NullableContext(1)]
		public WuWaGoTraversalGridEntity(EWuWaGoEntityType entityType, int pbDataId, Vector coordinate, Rotator rotator) : base(entityType, pbDataId, coordinate, rotator)
		{
		}

		// Token: 0x170049FE RID: 18942
		// (get) Token: 0x06024344 RID: 148292 RVA: 0x00A3DDB4 File Offset: 0x00A3BFB4
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

		// Token: 0x06024345 RID: 148293 RVA: 0x00A3DDBC File Offset: 0x00A3BFBC
		public void SetHintSteps([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<IWuWaGoHintStepBase> steps)
		{
			this.HintStepsInner = steps;
		}

		// Token: 0x06024346 RID: 148294 RVA: 0x00A3DDC8 File Offset: 0x00A3BFC8
		public override void Unlock()
		{
			EGameplayEntityState state = (this.EntityType == EWuWaGoEntityType.StartGrid) ? EGameplayEntityState.Activated : EGameplayEntityState.Normal;
			this.SetState(state);
		}

		// Token: 0x06024347 RID: 148295 RVA: 0x00A3DDEC File Offset: 0x00A3BFEC
		public override void RestoreInitialStateForGameOver()
		{
			this.SetState(EGameplayEntityState.Locked);
		}

		// Token: 0x06024348 RID: 148296 RVA: 0x00A3DDF6 File Offset: 0x00A3BFF6
		protected override void OnStateChanged(EGameplayEntityState newState)
		{
			base.SwitchSceneItemStateByGameplayEntityState(newState, true, false);
		}

		// Token: 0x040142C0 RID: 82624
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IReadOnlyList<IWuWaGoHintStepBase> HintStepsInner;
	}
}
