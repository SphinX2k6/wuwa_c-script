using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.WuwaGo.Controller;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.View
{
	// Token: 0x02004720 RID: 18208
	public class CaptionItem : UiPanelBase
	{
		// Token: 0x0602F954 RID: 194900 RVA: 0x00B05650 File Offset: 0x00B03850
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnHelpInfoButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnCloseButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602F955 RID: 194901 RVA: 0x00B0575C File Offset: 0x00B0395C
		protected override UniTask OnBeforeStartAsync()
		{
			CaptionItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CaptionItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F956 RID: 194902 RVA: 0x00B0579F File Offset: 0x00B0399F
		private void OnHelpInfoButtonClick()
		{
			HelpController.Instance.OpenHelpById(WuWaGoGlobal.Setting.HelpId);
		}

		// Token: 0x0602F957 RID: 194903 RVA: 0x00B057B5 File Offset: 0x00B039B5
		private void OnCloseButtonClick()
		{
			if (WuWaGoController.Instance.IsDamageBatchActive())
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.WuWaGoPauseView, null, null);
		}

		// Token: 0x0602F958 RID: 194904 RVA: 0x00B057D5 File Offset: 0x00B039D5
		public void SetCloseButtonInteractive(bool interactive)
		{
			UUIButtonComponent button = base.GetButton(3);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(interactive);
		}

		// Token: 0x0602F959 RID: 194905 RVA: 0x00B057EC File Offset: 0x00B039EC
		public void SetRightTopButtonsVisible(bool visible)
		{
			UUIButtonComponent button = base.GetButton(3);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(visible);
		}

		// Token: 0x0200A96C RID: 43372
		private enum EViewComponent
		{
			// Token: 0x04033919 RID: 211225
			SpriteTitleIcon,
			// Token: 0x0403391A RID: 211226
			TitleText,
			// Token: 0x0403391B RID: 211227
			HelpInfoButton,
			// Token: 0x0403391C RID: 211228
			CloseButton
		}
	}
}
