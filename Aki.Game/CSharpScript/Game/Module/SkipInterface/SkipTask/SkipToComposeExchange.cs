using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BC3 RID: 19395
	public class SkipToComposeExchange : SkipTask
	{
		// Token: 0x06032315 RID: 205589 RVA: 0x00BA9E04 File Offset: 0x00BA8004
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string text = (string)data[0];
			string text2 = (string)data[1];
			string text3 = (string)data[2];
			int p = (int)data[3];
			if (UiManager.Instance.IsViewShow(EUiViewName.ComposeCarryOnView))
			{
				EventSystem.Instance.Emit<EComposeListType, int>(EEventName.ComposeSwitchType, EComposeListType.Exchange, p);
				if (UiManager.Instance.IsViewShow(EUiViewName.ItemTipsView))
				{
					UiManager.Instance.CloseView(EUiViewName.ItemTipsView, null);
				}
				return;
			}
			ComposeViewOpenData composeViewOpenData = new ComposeViewOpenData();
			composeViewOpenData.Type = EComposeListType.Exchange;
			composeViewOpenData.SelectData = ComposeModel.Instance.ComposeSelectItem;
			UiManager.Instance.OpenView(EUiViewName.ComposeCarryOnView, composeViewOpenData, null);
			ComposeModel.Instance.ComposeSelectItem = null;
			if (UiManager.Instance.IsViewShow(EUiViewName.ItemTipsView))
			{
				UiManager.Instance.CloseView(EUiViewName.ItemTipsView, null);
			}
			base.Finish();
		}
	}
}
