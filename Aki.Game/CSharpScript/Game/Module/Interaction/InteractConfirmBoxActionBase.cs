using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004828 RID: 18472
	public abstract class InteractConfirmBoxActionBase : InteractConfirmActionBase
	{
		// Token: 0x0602E698 RID: 190104 RVA: 0x00CF329C File Offset: 0x00CF149C
		[NullableContext(1)]
		protected override bool OnExecute(InteractSecondConfirmContext context)
		{
			CommonInteractOption option = context.Option;
			if (((option != null) ? option.ConfirmBox : null) == null)
			{
				return false;
			}
			ConfirmBoxDataNew confirmBoxDataNew = this.ConfigConfirmBoxData();
			if (confirmBoxDataNew != null)
			{
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return true;
			}
			return false;
		}

		// Token: 0x0602E699 RID: 190105 RVA: 0x00CF32D8 File Offset: 0x00CF14D8
		protected override void OnCancel()
		{
			if (ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
			{
				ConfirmBoxController.Instance.CloseConfirmBoxView();
			}
			base.ExecuteFinish(false);
		}

		// Token: 0x0602E69A RID: 190106
		[NullableContext(2)]
		protected abstract ConfirmBoxDataNew ConfigConfirmBoxData();
	}
}
