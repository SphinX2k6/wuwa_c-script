using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CC0 RID: 3264
public class CommonConditionFilterItem : UiPanelBase
{
	// Token: 0x06008852 RID: 34898 RVA: 0x0029622D File Offset: 0x0029442D
	[NullableContext(1)]
	public CommonConditionFilterItem(UUIItem uiItem, QualityInfo qualityInfo)
	{
		this.QualityInfo = qualityInfo;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008853 RID: 34899 RVA: 0x0029624C File Offset: 0x0029444C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008854 RID: 34900 RVA: 0x002962F2 File Offset: 0x002944F2
	private void ToggleClick(EToggleState state)
	{
		if (this.ToggleFunction != null)
		{
			this.ToggleFunction(this.QualityInfo.Id, this.QualityInfo.ConsumeFilterText);
		}
	}

	// Token: 0x06008855 RID: 34901 RVA: 0x0029631D File Offset: 0x0029451D
	protected override void OnStart()
	{
		base.GetText(1).ShowTextNew(this.QualityInfo.ConsumeFilterText);
	}

	// Token: 0x06008856 RID: 34902 RVA: 0x00296338 File Offset: 0x00294538
	public void SetToggleState(bool bSelected, bool bFire = true)
	{
		EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06008857 RID: 34903 RVA: 0x0029635E File Offset: 0x0029455E
	[NullableContext(1)]
	public void SetToggleFunction(TCommonConditionFilterItemFunction toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x06008858 RID: 34904 RVA: 0x00296367 File Offset: 0x00294567
	public QualityInfo GetQualityInfo()
	{
		return this.QualityInfo;
	}

	// Token: 0x04005219 RID: 21017
	[Nullable(2)]
	protected TCommonConditionFilterItemFunction ToggleFunction;

	// Token: 0x0400521A RID: 21018
	protected QualityInfo QualityInfo;

	// Token: 0x02006F83 RID: 28547
	private class ECommonConditionFilterItem
	{
		// Token: 0x040246D3 RID: 149203
		public const int Toggle = 0;

		// Token: 0x040246D4 RID: 149204
		public const int Text = 1;
	}
}
