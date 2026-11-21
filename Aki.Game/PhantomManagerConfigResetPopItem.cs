using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001916 RID: 6422
public class PhantomManagerConfigResetPopItem : UiViewBase
{
	// Token: 0x0600FDFD RID: 65021 RVA: 0x004A22CA File Offset: 0x004A04CA
	[NullableContext(1)]
	public PhantomManagerConfigResetPopItem(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FDFE RID: 65022 RVA: 0x004A22D4 File Offset: 0x004A04D4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedCancel));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickedConfirm));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickedReset1));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnClickedReset2));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FDFF RID: 65023 RVA: 0x004A2425 File Offset: 0x004A0625
	protected override void OnStart()
	{
		base.GetExtendToggle(2).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		this.OnSuccessCb = (this.OpenParam as Action);
	}

	// Token: 0x0600FE00 RID: 65024 RVA: 0x004A2449 File Offset: 0x004A0649
	private void OnClickedReset1(EToggleState state)
	{
		base.GetExtendToggle(3).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.CurrentSelectId = 0;
	}

	// Token: 0x0600FE01 RID: 65025 RVA: 0x004A2463 File Offset: 0x004A0663
	private void OnClickedReset2(EToggleState state)
	{
		base.GetExtendToggle(2).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.CurrentSelectId = 1;
	}

	// Token: 0x0600FE02 RID: 65026 RVA: 0x004A247D File Offset: 0x004A067D
	private void OnClickedCancel()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600FE03 RID: 65027 RVA: 0x004A2486 File Offset: 0x004A0686
	private void OnClickedConfirm()
	{
		PhantomBattleModel.Instance.GetPhantomConfigData().ResetAllFetterOpen(this.CurrentSelectId == 1).ContinueWith(delegate(bool value)
		{
			if (value)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomProject_CleanPlan_Des_6", Array.Empty<object>());
				Action onSuccessCb = this.OnSuccessCb;
				if (onSuccessCb != null)
				{
					onSuccessCb();
				}
				base.CloseMe(null);
			}
		}).Forget();
	}

	// Token: 0x04008D4A RID: 36170
	private int CurrentSelectId;

	// Token: 0x04008D4B RID: 36171
	[Nullable(2)]
	private Action OnSuccessCb;

	// Token: 0x02007B3A RID: 31546
	private enum EDefine
	{
		// Token: 0x04027EFE RID: 163582
		BtnCancel,
		// Token: 0x04027EFF RID: 163583
		BtnConfirm,
		// Token: 0x04027F00 RID: 163584
		ResetToggle1,
		// Token: 0x04027F01 RID: 163585
		ResetToggle2
	}
}
