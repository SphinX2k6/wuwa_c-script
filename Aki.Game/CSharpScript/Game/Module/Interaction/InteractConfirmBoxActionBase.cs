using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02005850 RID: 22608
	public abstract class InteractConfirmBoxActionBase : InteractConfirmActionBase
	{
		// Token: 0x0603977C RID: 235388 RVA: 0x00DA45DC File Offset: 0x00DA27DC
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

		// Token: 0x0603977D RID: 235389 RVA: 0x00DA4618 File Offset: 0x00DA2818
		protected override void OnCancel()
		{
			if (ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
			{
				ConfirmBoxController.Instance.CloseConfirmBoxView();
			}
			base.ExecuteFinish(false);
		}

		// Token: 0x0603977E RID: 235390
		[NullableContext(2)]
		protected abstract ConfirmBoxDataNew ConfigConfirmBoxData();
	}
}
