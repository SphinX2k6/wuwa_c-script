using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001807 RID: 6151
public class CommonConditionFilterItem : UiPanelBase
{
	// Token: 0x0600B467 RID: 46183 RVA: 0x0028BB0D File Offset: 0x00289D0D
	[NullableContext(1)]
	public CommonConditionFilterItem(UUIItem uiItem, QualityInfo qualityInfo)
	{
		this.QualityInfo = qualityInfo;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B468 RID: 46184 RVA: 0x0028BB2C File Offset: 0x00289D2C
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

	// Token: 0x0600B469 RID: 46185 RVA: 0x0028BBD2 File Offset: 0x00289DD2
	private void ToggleClick(EToggleState state)
	{
		if (this.ToggleFunction != null)
		{
			this.ToggleFunction(this.QualityInfo.Id, this.QualityInfo.ConsumeFilterText);
		}
	}

	// Token: 0x0600B46A RID: 46186 RVA: 0x0028BBFD File Offset: 0x00289DFD
	protected override void OnStart()
	{
		base.GetText(1).ShowTextNew(this.QualityInfo.ConsumeFilterText);
	}

	// Token: 0x0600B46B RID: 46187 RVA: 0x0028BC18 File Offset: 0x00289E18
	public void SetToggleState(bool bSelected, bool bFire = true)
	{
		EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x0600B46C RID: 46188 RVA: 0x0028BC3E File Offset: 0x00289E3E
	[NullableContext(1)]
	public void SetToggleFunction(TCommonConditionFilterItemFunction toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x0600B46D RID: 46189 RVA: 0x0028BC47 File Offset: 0x00289E47
	public QualityInfo GetQualityInfo()
	{
		return this.QualityInfo;
	}

	// Token: 0x0400516E RID: 20846
	[Nullable(2)]
	protected TCommonConditionFilterItemFunction ToggleFunction;

	// Token: 0x0400516F RID: 20847
	protected QualityInfo QualityInfo;

	// Token: 0x02007DFD RID: 32253
	private class ECommonConditionFilterItem
	{
		// Token: 0x040293A8 RID: 168872
		public const int Toggle = 0;

		// Token: 0x040293A9 RID: 168873
		public const int Text = 1;
	}
}
