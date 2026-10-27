using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002431 RID: 9265
public class PhantomManagerConfigResetPopItem : UiViewBase
{
	// Token: 0x06012947 RID: 76103 RVA: 0x00494CFE File Offset: 0x00492EFE
	[NullableContext(1)]
	public PhantomManagerConfigResetPopItem(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012948 RID: 76104 RVA: 0x00494D08 File Offset: 0x00492F08
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

	// Token: 0x06012949 RID: 76105 RVA: 0x00494E59 File Offset: 0x00493059
	protected override void OnStart()
	{
		base.GetExtendToggle(2).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		this.OnSuccessCb = (this.OpenParam as Action);
	}

	// Token: 0x0601294A RID: 76106 RVA: 0x00494E7D File Offset: 0x0049307D
	private void OnClickedReset1(EToggleState state)
	{
		base.GetExtendToggle(3).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.CurrentSelectId = 0;
	}

	// Token: 0x0601294B RID: 76107 RVA: 0x00494E97 File Offset: 0x00493097
	private void OnClickedReset2(EToggleState state)
	{
		base.GetExtendToggle(2).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.CurrentSelectId = 1;
	}

	// Token: 0x0601294C RID: 76108 RVA: 0x00494EB1 File Offset: 0x004930B1
	private void OnClickedCancel()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601294D RID: 76109 RVA: 0x00494EBA File Offset: 0x004930BA
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

	// Token: 0x04008C03 RID: 35843
	private int CurrentSelectId;

	// Token: 0x04008C04 RID: 35844
	[Nullable(2)]
	private Action OnSuccessCb;

	// Token: 0x020089B3 RID: 35251
	private enum EDefine
	{
		// Token: 0x0402CBE8 RID: 183272
		BtnCancel,
		// Token: 0x0402CBE9 RID: 183273
		BtnConfirm,
		// Token: 0x0402CBEA RID: 183274
		ResetToggle1,
		// Token: 0x0402CBEB RID: 183275
		ResetToggle2
	}
}
