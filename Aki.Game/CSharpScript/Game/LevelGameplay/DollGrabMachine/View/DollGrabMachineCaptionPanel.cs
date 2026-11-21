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
	// Token: 0x02006066 RID: 24678
	[NullableContext(2)]
	[Nullable(0)]
	public class DollGrabMachineCaptionPanel : UiPanelBase
	{
		// Token: 0x0603B407 RID: 242695 RVA: 0x010C4210 File Offset: 0x010C2410
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

		// Token: 0x0603B408 RID: 242696 RVA: 0x010C43A0 File Offset: 0x010C25A0
		protected override UniTask OnBeforeStartAsync()
		{
			DollGrabMachineCaptionPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DollGrabMachineCaptionPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B409 RID: 242697 RVA: 0x010C43E4 File Offset: 0x010C25E4
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

		// Token: 0x0603B40A RID: 242698 RVA: 0x010C4498 File Offset: 0x010C2698
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

		// Token: 0x0603B40B RID: 242699 RVA: 0x010C4532 File Offset: 0x010C2732
		private void OnBackButtonClick()
		{
			DollGrabMachineController.Instance.PauseDollGrabMachine(false);
		}

		// Token: 0x0603B40C RID: 242700 RVA: 0x010C453F File Offset: 0x010C273F
		private void OnHelpInfoButtonClick()
		{
			DollGrabMachineController.Instance.PauseDollGrabMachine(true);
		}

		// Token: 0x0603B40D RID: 242701 RVA: 0x010C454C File Offset: 0x010C274C
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

		// Token: 0x0603B40E RID: 242702 RVA: 0x010C4571 File Offset: 0x010C2771
		private void OnDollGrabMachineEnd(EDollGrabMachineEndReason endReason)
		{
			this.RefreashButton(false);
		}

		// Token: 0x0603B40F RID: 242703 RVA: 0x010C457A File Offset: 0x010C277A
		private void OnDollGrabMachineRestart()
		{
			this.RefreashButton(true);
			if (!DollGrabMachineController.Instance.IsEndlessMode)
			{
				base.GetItem(4).SetUIActive(true);
			}
		}

		// Token: 0x0603B410 RID: 242704 RVA: 0x010C459C File Offset: 0x010C279C
		private void OnDollGrabMachineStartCoolDown(Action callback)
		{
			this.RefreashButton(false);
			EventSystem.Instance.Once(EEventName.OnDollGrabMachineEndCoolDown, new Action(this.OnDollGrabMachineEndCoolDown));
			if (!DollGrabMachineController.Instance.IsEndlessMode)
			{
				base.GetItem(4).SetUIActive(false);
			}
		}

		// Token: 0x0603B411 RID: 242705 RVA: 0x010C45DA File Offset: 0x010C27DA
		private void OnDollGrabMachineEndCoolDown()
		{
			this.RefreashButton(true);
		}

		// Token: 0x0401F2FE RID: 127742
		private UUIButtonComponent BtnHelpInfo;

		// Token: 0x0401F2FF RID: 127743
		private UUIButtonComponent BtnBack;
	}
}
