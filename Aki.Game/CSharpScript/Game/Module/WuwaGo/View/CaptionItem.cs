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
	// Token: 0x02003650 RID: 13904
	public class CaptionItem : UiPanelBase
	{
		// Token: 0x0602411A RID: 147738 RVA: 0x00A35320 File Offset: 0x00A33520
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

		// Token: 0x0602411B RID: 147739 RVA: 0x00A3542C File Offset: 0x00A3362C
		protected override UniTask OnBeforeStartAsync()
		{
			CaptionItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CaptionItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602411C RID: 147740 RVA: 0x00A3546F File Offset: 0x00A3366F
		private void OnHelpInfoButtonClick()
		{
			HelpController.Instance.OpenHelpById(WuWaGoGlobal.Setting.HelpId);
		}

		// Token: 0x0602411D RID: 147741 RVA: 0x00A35485 File Offset: 0x00A33685
		private void OnCloseButtonClick()
		{
			if (WuWaGoController.Instance.IsDamageBatchActive())
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.WuWaGoPauseView, null, null);
		}

		// Token: 0x0602411E RID: 147742 RVA: 0x00A354A5 File Offset: 0x00A336A5
		public void SetCloseButtonInteractive(bool interactive)
		{
			UUIButtonComponent button = base.GetButton(3);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(interactive);
		}

		// Token: 0x0602411F RID: 147743 RVA: 0x00A354BC File Offset: 0x00A336BC
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

		// Token: 0x02009326 RID: 37670
		private enum EViewComponent
		{
			// Token: 0x0402E0A9 RID: 188585
			SpriteTitleIcon,
			// Token: 0x0402E0AA RID: 188586
			TitleText,
			// Token: 0x0402E0AB RID: 188587
			HelpInfoButton,
			// Token: 0x0402E0AC RID: 188588
			CloseButton
		}
	}
}
