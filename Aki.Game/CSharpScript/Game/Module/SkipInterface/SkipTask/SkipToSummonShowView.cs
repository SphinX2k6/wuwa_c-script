using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B83 RID: 15235
	public class SkipToSummonShowView : SkipTask
	{
		// Token: 0x060270D4 RID: 159956 RVA: 0x00AEEBA0 File Offset: 0x00AECDA0
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.ItemTipsView))
			{
				UiManager.Instance.CloseView(EUiViewName.ItemTipsView, null);
			}
			int num = Convert.ToInt32(data[0]);
			UiManager.Instance.OpenView(EUiViewName.SpecialItemSummonShowView, num, null);
			base.Finish();
		}
	}
}
