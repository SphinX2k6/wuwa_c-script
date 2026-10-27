using System;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x02006875 RID: 26741
	public sealed class RevertOperation : IInteractionOperation
	{
		// Token: 0x1700979F RID: 38815
		// (get) Token: 0x06042C52 RID: 273490 RVA: 0x01040272 File Offset: 0x0103E472
		public EDangoBrawlOptionType Type
		{
			get
			{
				return EDangoBrawlOptionType.Revoke;
			}
		}

		// Token: 0x06042C53 RID: 273491 RVA: 0x01040275 File Offset: 0x0103E475
		public bool CanExecute(in OperationContext ctx)
		{
			return true;
		}

		// Token: 0x06042C54 RID: 273492 RVA: 0x01040278 File Offset: 0x0103E478
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

		// Token: 0x06042C56 RID: 273494 RVA: 0x010402A3 File Offset: 0x0103E4A3
		bool IInteractionOperation.CanExecute(in OperationContext ctx)
		{
			return this.CanExecute(ctx);
		}

		// Token: 0x06042C57 RID: 273495 RVA: 0x010402AC File Offset: 0x0103E4AC
		UniTask<bool> IInteractionOperation.Execute(in OperationContext ctx)
		{
			return this.Execute(ctx);
		}
	}
}
