using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B6E RID: 15214
	public class SkipToComposePurification : SkipTask
	{
		// Token: 0x060270A8 RID: 159912 RVA: 0x00AEE190 File Offset: 0x00AEC390
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
