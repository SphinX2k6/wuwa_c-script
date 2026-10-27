using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EE6 RID: 28390
	[NullableContext(2)]
	[Nullable(0)]
	public class DollGrabMachineCaptionPanel : UiPanelBase
	{
		// Token: 0x0604525E RID: 283230 RVA: 0x0111A480 File Offset: 0x01118680
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBackButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnHelpInfoButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604525F RID: 283231 RVA: 0x0111A610 File Offset: 0x01118810
		protected override UniTask OnBeforeStartAsync()
		{
			DollGrabMachineCaptionPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DollGrabMachineCaptionPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06045260 RID: 283232 RVA: 0x0111A654 File Offset: 0x01118854
		protected override void OnBeforeCreate()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(true);
			}
			this.BtnBack = base.GetButton(3);
			this.BtnHelpInfo = base.GetButton(2);
			UUIButtonComponent btnBack = this.BtnBack;
			if (btnBack != null)
			{
				btnBack.SetSelfInteractive(true);
			}
			UUIButtonComponent btnHelpInfo = this.BtnHelpInfo;
			if (btnHelpInfo != null)
			{
				btnHelpInfo.SetSelfInteractive(true);
			}
			EventSystem.Instance.Add<EDollGrabMachineEndReason>(EEventName.OnDollGrabMachineEnd, new Action<EDollGrabMachineEndReason>(this.OnDollGrabMachineEnd));
			EventSystem.Instance.Add(EEventName.OnDollGrabMachineRestart, new Action(this.OnDollGrabMachineRestart));
			EventSystem.Instance.Add<Action>(EEventName.OnDollGrabMachineStartCoolDown, new Action<Action>(this.OnDollGrabMachineStartCoolDown));
		}

		// Token: 0x06045261 RID: 283233 RVA: 0x0111A708 File Offset: 0x01118908
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<EDollGrabMachineEndReason>(EEventName.OnDollGrabMachineEnd, new Action<EDollGrabMachineEndReason>(this.OnDollGrabMachineEnd));
			EventSystem.Instance.Remove(EEventName.OnDollGrabMachineRestart, new Action(this.OnDollGrabMachineRestart));
			EventSystem.Instance.Remove<Action>(EEventName.OnDollGrabMachineStartCoolDown, new Action<Action>(this.OnDollGrabMachineStartCoolDown));
			if (EventSystem.Instance.Has(EEventName.OnDollGrabMachineEndCoolDown, new Action(this.OnDollGrabMachineEndCoolDown)))
			{
				EventSystem.Instance.Remove(EEventName.OnDollGrabMachineEndCoolDown, new Action(this.OnDollGrabMachineEndCoolDown));
			}
		}

		// Token: 0x06045262 RID: 283234 RVA: 0x0111A7A2 File Offset: 0x011189A2
		private void OnBackButtonClick()
		{
			DollGrabMachineController.Instance.PauseDollGrabMachine(false);
		}

		// Token: 0x06045263 RID: 283235 RVA: 0x0111A7AF File Offset: 0x011189AF
		private void OnHelpInfoButtonClick()
		{
			DollGrabMachineController.Instance.PauseDollGrabMachine(true);
		}

		// Token: 0x06045264 RID: 283236 RVA: 0x0111A7BC File Offset: 0x011189BC
		private void RefreashButton(bool toggle)
		{
			UUIButtonComponent btnBack = this.BtnBack;
			if (btnBack != null)
			{
				btnBack.SetSelfInteractive(toggle);
			}
			UUIButtonComponent btnHelpInfo = this.BtnHelpInfo;
			if (btnHelpInfo == null)
			{
				return;
			}
			btnHelpInfo.SetSelfInteractive(toggle);
		}

		// Token: 0x06045265 RID: 283237 RVA: 0x0111A7E1 File Offset: 0x011189E1
		private void OnDollGrabMachineEnd(EDollGrabMachineEndReason endReason)
		{
			this.RefreashButton(false);
		}

		// Token: 0x06045266 RID: 283238 RVA: 0x0111A7EA File Offset: 0x011189EA
		private void OnDollGrabMachineRestart()
		{
			this.RefreashButton(true);
			if (!DollGrabMachineController.Instance.IsEndlessMode)
			{
				base.GetItem(4).SetUIActive(true);
			}
		}

		// Token: 0x06045267 RID: 283239 RVA: 0x0111A80C File Offset: 0x01118A0C
		private void OnDollGrabMachineStartCoolDown(Action callback)
		{
			this.RefreashButton(false);
			EventSystem.Instance.Once(EEventName.OnDollGrabMachineEndCoolDown, new Action(this.OnDollGrabMachineEndCoolDown));
			if (!DollGrabMachineController.Instance.IsEndlessMode)
			{
				base.GetItem(4).SetUIActive(false);
			}
		}

		// Token: 0x06045268 RID: 283240 RVA: 0x0111A84A File Offset: 0x01118A4A
		private void OnDollGrabMachineEndCoolDown()
		{
			this.RefreashButton(true);
		}

		// Token: 0x0402404B RID: 147531
		private UUIButtonComponent BtnHelpInfo;

		// Token: 0x0402404C RID: 147532
		private UUIButtonComponent BtnBack;
	}
}
