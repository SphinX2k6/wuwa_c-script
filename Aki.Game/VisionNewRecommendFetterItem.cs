using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020024E2 RID: 9442
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionNewRecommendFetterItem : GridProxyAbstract<VisionFetterRecommendInfo>
{
	// Token: 0x06012FC5 RID: 77765 RVA: 0x004B3860 File Offset: 0x004B1A60
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x06012FC6 RID: 77766 RVA: 0x004B38E0 File Offset: 0x004B1AE0
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		extendToggle.bLockStateOnSelect = true;
		this.ElementLayout = new GenericLayout<FetterIconItem, IVisionNewRecommendFetterItemData>(base.GetLayoutBase(1), new Func<FetterIconItem>(this.InitElementItem), null, false, true);
	}

	// Token: 0x06012FC7 RID: 77767 RVA: 0x004B392C File Offset: 0x004B1B2C
	private FetterIconItem InitElementItem()
	{
		return new FetterIconItem();
	}

	// Token: 0x06012FC8 RID: 77768 RVA: 0x004B3933 File Offset: 0x004B1B33
	public override void Refresh(VisionFetterRecommendInfo data, bool isSelected, int gridIndex)
	{
		this.ElementLayout.RefreshByData(data.BuildFetterItemDataList(), null, false);
		this.RefreshUsage(data.GetUsageText());
	}

	// Token: 0x06012FC9 RID: 77769 RVA: 0x004B3954 File Offset: 0x004B1B54
	private void RefreshUsage(string txt)
	{
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText(txt, true);
	}

	// Token: 0x06012FCA RID: 77770 RVA: 0x004B3969 File Offset: 0x004B1B69
	private void OnToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<int> onSelectedCallback = this.OnSelectedCallback;
			if (onSelectedCallback == null)
			{
				return;
			}
			onSelectedCallback(base.GridIndex);
		}
	}

	// Token: 0x06012FCB RID: 77771 RVA: 0x004B3985 File Offset: 0x004B1B85
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x06012FCC RID: 77772 RVA: 0x004B398F File Offset: 0x004B1B8F
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x06012FCD RID: 77773 RVA: 0x004B3999 File Offset: 0x004B1B99
	private void SetToggleState(bool isSelected, bool fireEvent = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06012FCE RID: 77774 RVA: 0x004B39B6 File Offset: 0x004B1BB6
	public override object GetKey(VisionFetterRecommendInfo data, int displayIndex)
	{
		return data.GetPlanId();
	}

	// Token: 0x04008EE7 RID: 36583
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FetterIconItem, IVisionNewRecommendFetterItemData> ElementLayout;

	// Token: 0x04008EE8 RID: 36584
	[Nullable(2)]
	public Action<int> OnSelectedCallback;

	// Token: 0x02008A71 RID: 35441
	[NullableContext(0)]
	private enum EComp
	{
		// Token: 0x0402CF49 RID: 184137
		Toggle,
		// Token: 0x0402CF4A RID: 184138
		ElementLayout,
		// Token: 0x0402CF4B RID: 184139
		UsageText
	}
}
