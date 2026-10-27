using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BC4 RID: 19396
	public class SkipToComposePurification : SkipTask
	{
		// Token: 0x06032317 RID: 205591 RVA: 0x00BA9EE4 File Offset: 0x00BA80E4
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
				EventSystem.Instance.Emit<EComposeListType, int>(EEventName.ComposeSwitchType, EComposeListType.Purification, p);
				if (UiManager.Instance.IsViewShow(EUiViewName.ItemTipsView))
				{
					UiManager.Instance.CloseView(EUiViewName.ItemTipsView, null);
				}
				return;
			}
			ComposeViewOpenData composeViewOpenData = new ComposeViewOpenData();
			composeViewOpenData.Type = EComposeListType.Purification;
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
