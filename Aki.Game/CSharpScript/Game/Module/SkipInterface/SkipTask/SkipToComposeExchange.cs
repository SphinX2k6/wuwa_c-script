using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B6D RID: 15213
	public class SkipToComposeExchange : SkipTask
	{
		// Token: 0x060270A6 RID: 159910 RVA: 0x00AEE0B0 File Offset: 0x00AEC2B0
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
