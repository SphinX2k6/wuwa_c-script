using System;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x020057C5 RID: 22469
	public sealed class RevertOperation : IInteractionOperation
	{
		// Token: 0x17006AE0 RID: 27360
		// (get) Token: 0x060377A9 RID: 227241 RVA: 0x00F81752 File Offset: 0x00F7F952
		public EDangoBrawlOptionType Type
		{
			get
			{
				return EDangoBrawlOptionType.Revoke;
			}
		}

		// Token: 0x060377AA RID: 227242 RVA: 0x00F81755 File Offset: 0x00F7F955
		public bool CanExecute(in OperationContext ctx)
		{
			return true;
		}

		// Token: 0x060377AB RID: 227243 RVA: 0x00F81758 File Offset: 0x00F7F958
		public UniTask<bool> Execute(in OperationContext ctx)
		{
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			if (instance != null)
			{
				DangoBrawlTouchController touchController = instance.GetTouchController();
				if (touchController != null)
				{
					touchController.CancelBlockingInAny();
				}
			}
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x060377AD RID: 227245 RVA: 0x00F81783 File Offset: 0x00F7F983
		bool IInteractionOperation.CanExecute(in OperationContext ctx)
		{
			return this.CanExecute(ctx);
		}

		// Token: 0x060377AE RID: 227246 RVA: 0x00F8178C File Offset: 0x00F7F98C
		UniTask<bool> IInteractionOperation.Execute(in OperationContext ctx)
		{
			return this.Execute(ctx);
		}
	}
}
