using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001778 RID: 6008
[NullableContext(1)]
[Nullable(0)]
public class VisionRefineTabCostItem : UiPanelBase, IGridProxy<VisionRefineTabCostItemData>
{
	// Token: 0x0600AE36 RID: 44598 RVA: 0x00274293 File Offset: 0x00272493
	public void Clear()
	{
		this.DataCache = null;
		this.DisplayIndex = 0;
		this.GridIndex = 0;
	}

	// Token: 0x17000E77 RID: 3703
	// (get) Token: 0x0600AE37 RID: 44599 RVA: 0x002742AA File Offset: 0x002724AA
	// (set) Token: 0x0600AE38 RID: 44600 RVA: 0x002742B2 File Offset: 0x002724B2
	public int DisplayIndex { get; set; }

	// Token: 0x0600AE39 RID: 44601 RVA: 0x002742BB File Offset: 0x002724BB
	[return: Nullable(2)]
	public object GetKey(VisionRefineTabCostItemData data, int gridIndex)
	{
		return data.CostType;
	}

	// Token: 0x17000E78 RID: 3704
	// (get) Token: 0x0600AE3A RID: 44602 RVA: 0x002742C8 File Offset: 0x002724C8
	// (set) Token: 0x0600AE3B RID: 44603 RVA: 0x002742D0 File Offset: 0x002724D0
	public int GridIndex { get; set; }

	// Token: 0x0600AE3C RID: 44604 RVA: 0x002742DC File Offset: 0x002724DC
	public void OnDeselected(bool fireEvent)
	{
		if (this.DataCache != null)
		{
			this.DataCache.IsChosen = false;
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}
	}

	// Token: 0x0600AE3D RID: 44605 RVA: 0x00274314 File Offset: 0x00272514
	public void OnSelected(bool fireEvent)
	{
		if (this.DataCache != null)
		{
			this.DataCache.IsChosen = true;
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}
	}

	// Token: 0x17000E79 RID: 3705
	// (get) Token: 0x0600AE3E RID: 44606 RVA: 0x0027434B File Offset: 0x0027254B
	// (set) Token: 0x0600AE3F RID: 44607 RVA: 0x00274353 File Offset: 0x00272553
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<VisionRefineTabCostItemData>, VisionRefineTabCostItemData> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x0600AE40 RID: 44608 RVA: 0x0027435C File Offset: 0x0027255C
	public void Refresh(VisionRefineTabCostItemData data, bool isSelected, int gridIndex)
	{
		this.DataCache = data;
		if (data.TabTextId != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TabTextId, Array.Empty<object>());
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(data.IsChosen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x0600AE41 RID: 44609 RVA: 0x002743B5 File Offset: 0x002725B5
	public UniTask RefreshAsync(VisionRefineTabCostItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
		return UniTask.CompletedTask;
	}

	// Token: 0x0600AE42 RID: 44610 RVA: 0x002743C8 File Offset: 0x002725C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClick))
		};
	}

	// Token: 0x0600AE43 RID: 44611 RVA: 0x0027442F File Offset: 0x0027262F
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x0600AE44 RID: 44612 RVA: 0x0027443E File Offset: 0x0027263E
	private void OnClick(EToggleState toggleState)
	{
		VisionRefineTabCostItemData dataCache = this.DataCache;
		if (dataCache == null)
		{
			return;
		}
		Action onClick = dataCache.OnClick;
		if (onClick == null)
		{
			return;
		}
		onClick();
	}

	// Token: 0x0600AE45 RID: 44613 RVA: 0x0027445C File Offset: 0x0027265C
	public bool CheckChosen(EVisionRefineCostType currentChosen)
	{
		VisionRefineTabCostItemData dataCache = this.DataCache;
		EVisionRefineCostType? evisionRefineCostType = (dataCache != null) ? new EVisionRefineCostType?(dataCache.CostType) : null;
		return currentChosen == evisionRefineCostType.GetValueOrDefault() & evisionRefineCostType != null;
	}

	// Token: 0x04004F30 RID: 20272
	[Nullable(2)]
	private VisionRefineTabCostItemData DataCache;

	// Token: 0x02007D6F RID: 32111
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402913D RID: 168253
		Toggle,
		// Token: 0x0402913E RID: 168254
		Text
	}
}
