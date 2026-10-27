using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BB2 RID: 19378
	public class SkipTaskPayShopToSpecifyTab : SkipTask
	{
		// Token: 0x060322F2 RID: 205554 RVA: 0x00BA9308 File Offset: 0x00BA7508
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			string s2 = (string)data[1];
			if (data.Length > 2)
			{
				string text = (string)data[2];
			}
			base.Finish();
			if (UiManager.Instance.IsViewShow(EUiViewName.PayShopRootView))
			{
				GenericPromptController.Instance.ShowPromptByCode("IsInView", Array.Empty<object>());
				return;
			}
			PayShopViewData payShopViewData = new PayShopViewData();
			payShopViewData.PayShopId = (PayShopDefine.EPayShopTabType)int.Parse(s);
			payShopViewData.SwitchId = new int?(int.Parse(s2));
			PayShopController.Instance.OpenPayShopView(payShopViewData, null);
		}
	}
}
