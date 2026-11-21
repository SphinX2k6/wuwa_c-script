using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000C31 RID: 3121
[NullableContext(1)]
[Nullable(0)]
public class VisionRefineTabCostItem : UiPanelBase, IGridProxy<VisionRefineTabCostItemData>
{
	// Token: 0x0600821D RID: 33309 RVA: 0x0027E757 File Offset: 0x0027C957
	public void Clear()
	{
		this.DataCache = null;
		this.DisplayIndex = 0;
		this.GridIndex = 0;
	}

	// Token: 0x17000E9A RID: 3738
	// (get) Token: 0x0600821E RID: 33310 RVA: 0x0027E76E File Offset: 0x0027C96E
	// (set) Token: 0x0600821F RID: 33311 RVA: 0x0027E776 File Offset: 0x0027C976
	public int DisplayIndex { get; set; }

	// Token: 0x06008220 RID: 33312 RVA: 0x0027E77F File Offset: 0x0027C97F
	[return: Nullable(2)]
	public object GetKey(VisionRefineTabCostItemData data, int gridIndex)
	{
		return data.CostType;
	}

	// Token: 0x17000E9B RID: 3739
	// (get) Token: 0x06008221 RID: 33313 RVA: 0x0027E78C File Offset: 0x0027C98C
	// (set) Token: 0x06008222 RID: 33314 RVA: 0x0027E794 File Offset: 0x0027C994
	public int GridIndex { get; set; }

	// Token: 0x06008223 RID: 33315 RVA: 0x0027E7A0 File Offset: 0x0027C9A0
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

	// Token: 0x06008224 RID: 33316 RVA: 0x0027E7D8 File Offset: 0x0027C9D8
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

	// Token: 0x17000E9C RID: 3740
	// (get) Token: 0x06008225 RID: 33317 RVA: 0x0027E80F File Offset: 0x0027CA0F
	// (set) Token: 0x06008226 RID: 33318 RVA: 0x0027E817 File Offset: 0x0027CA17
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

	// Token: 0x06008227 RID: 33319 RVA: 0x0027E820 File Offset: 0x0027CA20
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

	// Token: 0x06008228 RID: 33320 RVA: 0x0027E879 File Offset: 0x0027CA79
	public UniTask RefreshAsync(VisionRefineTabCostItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
		return UniTask.CompletedTask;
	}

	// Token: 0x06008229 RID: 33321 RVA: 0x0027E88C File Offset: 0x0027CA8C
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

	// Token: 0x0600822A RID: 33322 RVA: 0x0027E8F3 File Offset: 0x0027CAF3
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x0600822B RID: 33323 RVA: 0x0027E902 File Offset: 0x0027CB02
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

	// Token: 0x0600822C RID: 33324 RVA: 0x0027E920 File Offset: 0x0027CB20
	public bool CheckChosen(EVisionRefineCostType currentChosen)
	{
		VisionRefineTabCostItemData dataCache = this.DataCache;
		EVisionRefineCostType? evisionRefineCostType = (dataCache != null) ? new EVisionRefineCostType?(dataCache.CostType) : null;
		return currentChosen == evisionRefineCostType.GetValueOrDefault() & evisionRefineCostType != null;
	}

	// Token: 0x04004FDA RID: 20442
	[Nullable(2)]
	private VisionRefineTabCostItemData DataCache;

	// Token: 0x02006EF5 RID: 28405
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024468 RID: 148584
		Toggle,
		// Token: 0x04024469 RID: 148585
		Text
	}
}
