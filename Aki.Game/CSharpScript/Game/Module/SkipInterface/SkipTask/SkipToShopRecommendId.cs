using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BD8 RID: 19416
	public class SkipToShopRecommendId : SkipTask
	{
		// Token: 0x06032341 RID: 205633 RVA: 0x00BAA854 File Offset: 0x00BA8A54
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
			payShopViewData.RecommendId = new int?(int.Parse(s2));
			PayShopController.Instance.OpenPayShopView(payShopViewData, null);
		}
	}
}
