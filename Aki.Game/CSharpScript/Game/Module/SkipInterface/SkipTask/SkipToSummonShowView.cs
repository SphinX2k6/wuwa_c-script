using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BD9 RID: 19417
	public class SkipToSummonShowView : SkipTask
	{
		// Token: 0x06032343 RID: 205635 RVA: 0x00BAA8E8 File Offset: 0x00BA8AE8
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
