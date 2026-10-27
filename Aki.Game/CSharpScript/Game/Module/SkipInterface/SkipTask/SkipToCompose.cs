using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Manufacture.Compose;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BC2 RID: 19394
	public class SkipToCompose : SkipTask
	{
		// Token: 0x06032313 RID: 205587 RVA: 0x00BA9C78 File Offset: 0x00BA7E78
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			string s = (string)data[0];
			string text = (string)data[1];
			string text2 = (string)data[2];
			int num = (data.Length > 3 && data[3] != null) ? ((int)data[3]) : 0;
			int num2 = int.Parse(s);
			int num3 = (text != null) ? int.Parse(text) : 0;
			if (UiManager.Instance.IsViewShow(EUiViewName.ComposeCarryOnView))
			{
				EventSystem.Instance.Emit<EComposeListType, int>(EEventName.ComposeSwitchType, (EComposeListType)num2, num);
				if (UiManager.Instance.IsViewShow(EUiViewName.ItemTipsView))
				{
					UiManager.Instance.CloseView(EUiViewName.ItemTipsView, null);
				}
				return;
			}
			ComposeViewOpenData composeViewOpenData = new ComposeViewOpenData();
			composeViewOpenData.Type = (EComposeListType)num2;
			composeViewOpenData.SkipSourceView = ComposeModel.Instance.ComposeSkipSourceView;
			if (ComposeModel.Instance.ComposeSelectItem != null)
			{
				composeViewOpenData.SelectData = ComposeModel.Instance.ComposeSelectItem;
			}
			else if (num != 0)
			{
				composeViewOpenData.SelectData = new SelectedData
				{
					ItemId = num,
					IncId = 0,
					Count = 0,
					SelectedCount = 0
				};
			}
			else if (num3 != 0)
			{
				composeViewOpenData.SelectData = new SelectedData
				{
					ItemId = num3,
					IncId = 0,
					Count = 0,
					SelectedCount = 0
				};
			}
			UiManager.Instance.OpenView(EUiViewName.ComposeCarryOnView, composeViewOpenData, null);
			ComposeModel.Instance.ComposeSelectItem = null;
			ComposeModel.Instance.ComposeSkipSourceView = null;
			if (UiManager.Instance.IsViewShow(EUiViewName.ItemTipsView))
			{
				UiManager.Instance.CloseView(EUiViewName.ItemTipsView, null);
			}
			base.Finish();
		}
	}
}
