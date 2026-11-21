using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000C28 RID: 3112
[NullableContext(1)]
[Nullable(0)]
public class VisionRefineRefineTab : UiPanelBase, IGridProxy<VisionRefineRefineTabData>
{
	// Token: 0x17000E94 RID: 3732
	// (get) Token: 0x060081D8 RID: 33240 RVA: 0x0027D7F1 File Offset: 0x0027B9F1
	// (set) Token: 0x060081D9 RID: 33241 RVA: 0x0027D7F9 File Offset: 0x0027B9F9
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<VisionRefineRefineTabData>, VisionRefineRefineTabData> ScrollViewDelegate { [return: Nullable(new byte[]
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

	// Token: 0x17000E95 RID: 3733
	// (get) Token: 0x060081DA RID: 33242 RVA: 0x0027D802 File Offset: 0x0027BA02
	// (set) Token: 0x060081DB RID: 33243 RVA: 0x0027D80A File Offset: 0x0027BA0A
	public int GridIndex { get; set; }

	// Token: 0x17000E96 RID: 3734
	// (get) Token: 0x060081DC RID: 33244 RVA: 0x0027D813 File Offset: 0x0027BA13
	// (set) Token: 0x060081DD RID: 33245 RVA: 0x0027D81B File Offset: 0x0027BA1B
	public int DisplayIndex { get; set; }

	// Token: 0x060081DE RID: 33246 RVA: 0x0027D824 File Offset: 0x0027BA24
	public void Refresh(VisionRefineRefineTabData data, bool isSelected, int gridIndex)
	{
		this.DataCache = data;
		if (data.TabTextId != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TabTextId, Array.Empty<object>());
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			if (!extendToggle.CanExecuteChange.IsBound())
			{
				extendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanChangeExecute));
			}
			extendToggle.SetToggleStateForce(data.IsChosen ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x060081DF RID: 33247 RVA: 0x0027D8A0 File Offset: 0x0027BAA0
	public UniTask RefreshAsync(VisionRefineRefineTabData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
		return UniTask.CompletedTask;
	}

	// Token: 0x060081E0 RID: 33248 RVA: 0x0027D8B0 File Offset: 0x0027BAB0
	public void Clear()
	{
		this.DataCache = null;
		this.DisplayIndex = 0;
		this.GridIndex = 0;
	}

	// Token: 0x060081E1 RID: 33249 RVA: 0x0027D8C8 File Offset: 0x0027BAC8
	public void OnSelected(bool fireEvent)
	{
		if (this.DataCache != null)
		{
			this.DataCache.IsChosen = true;
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, fireEvent, false, false);
		}
	}

	// Token: 0x060081E2 RID: 33250 RVA: 0x0027D900 File Offset: 0x0027BB00
	public void OnDeselected(bool fireEvent)
	{
		if (this.DataCache != null)
		{
			this.DataCache.IsChosen = false;
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}
	}

	// Token: 0x060081E3 RID: 33251 RVA: 0x0027D936 File Offset: 0x0027BB36
	[return: Nullable(2)]
	public object GetKey(VisionRefineRefineTabData data, int gridIndex)
	{
		return data;
	}

	// Token: 0x060081E4 RID: 33252 RVA: 0x0027D93C File Offset: 0x0027BB3C
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

	// Token: 0x060081E5 RID: 33253 RVA: 0x0027D9A3 File Offset: 0x0027BBA3
	private void OnClick(EToggleState toggleState)
	{
		VisionRefineRefineTabData dataCache = this.DataCache;
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

	// Token: 0x060081E6 RID: 33254 RVA: 0x0027D9BF File Offset: 0x0027BBBF
	private bool OnCanChangeExecute()
	{
		VisionRefineRefineTabData dataCache = this.DataCache;
		return ((dataCache != null) ? dataCache.CanChangeExecute : null) == null || this.DataCache.CanChangeExecute(this.DataCache.RefineType);
	}

	// Token: 0x060081E7 RID: 33255 RVA: 0x0027D9F4 File Offset: 0x0027BBF4
	public bool CheckChosen(EVisionRefineRefineType currentChosen)
	{
		VisionRefineRefineTabData dataCache = this.DataCache;
		EVisionRefineRefineType? evisionRefineRefineType = (dataCache != null) ? new EVisionRefineRefineType?(dataCache.RefineType) : null;
		return currentChosen == evisionRefineRefineType.GetValueOrDefault() & evisionRefineRefineType != null;
	}

	// Token: 0x04004FB3 RID: 20403
	[Nullable(2)]
	private VisionRefineRefineTabData DataCache;

	// Token: 0x02006EE9 RID: 28393
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402441B RID: 148507
		Toggle,
		// Token: 0x0402441C RID: 148508
		Text
	}
}
