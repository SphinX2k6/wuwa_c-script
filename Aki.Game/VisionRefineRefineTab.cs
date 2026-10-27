using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200176F RID: 5999
[NullableContext(1)]
[Nullable(0)]
public class VisionRefineRefineTab : UiPanelBase, IGridProxy<VisionRefineRefineTabData>
{
	// Token: 0x17000E71 RID: 3697
	// (get) Token: 0x0600ADF1 RID: 44529 RVA: 0x0027332D File Offset: 0x0027152D
	// (set) Token: 0x0600ADF2 RID: 44530 RVA: 0x00273335 File Offset: 0x00271535
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

	// Token: 0x17000E72 RID: 3698
	// (get) Token: 0x0600ADF3 RID: 44531 RVA: 0x0027333E File Offset: 0x0027153E
	// (set) Token: 0x0600ADF4 RID: 44532 RVA: 0x00273346 File Offset: 0x00271546
	public int GridIndex { get; set; }

	// Token: 0x17000E73 RID: 3699
	// (get) Token: 0x0600ADF5 RID: 44533 RVA: 0x0027334F File Offset: 0x0027154F
	// (set) Token: 0x0600ADF6 RID: 44534 RVA: 0x00273357 File Offset: 0x00271557
	public int DisplayIndex { get; set; }

	// Token: 0x0600ADF7 RID: 44535 RVA: 0x00273360 File Offset: 0x00271560
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

	// Token: 0x0600ADF8 RID: 44536 RVA: 0x002733DC File Offset: 0x002715DC
	public UniTask RefreshAsync(VisionRefineRefineTabData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data, isSelected, gridIndex);
		return UniTask.CompletedTask;
	}

	// Token: 0x0600ADF9 RID: 44537 RVA: 0x002733EC File Offset: 0x002715EC
	public void Clear()
	{
		this.DataCache = null;
		this.DisplayIndex = 0;
		this.GridIndex = 0;
	}

	// Token: 0x0600ADFA RID: 44538 RVA: 0x00273404 File Offset: 0x00271604
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

	// Token: 0x0600ADFB RID: 44539 RVA: 0x0027343C File Offset: 0x0027163C
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

	// Token: 0x0600ADFC RID: 44540 RVA: 0x00273472 File Offset: 0x00271672
	[return: Nullable(2)]
	public object GetKey(VisionRefineRefineTabData data, int gridIndex)
	{
		return data;
	}

	// Token: 0x0600ADFD RID: 44541 RVA: 0x00273478 File Offset: 0x00271678
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

	// Token: 0x0600ADFE RID: 44542 RVA: 0x002734DF File Offset: 0x002716DF
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

	// Token: 0x0600ADFF RID: 44543 RVA: 0x002734FB File Offset: 0x002716FB
	private bool OnCanChangeExecute()
	{
		VisionRefineRefineTabData dataCache = this.DataCache;
		return ((dataCache != null) ? dataCache.CanChangeExecute : null) == null || this.DataCache.CanChangeExecute(this.DataCache.RefineType);
	}

	// Token: 0x0600AE00 RID: 44544 RVA: 0x00273530 File Offset: 0x00271730
	public bool CheckChosen(EVisionRefineRefineType currentChosen)
	{
		VisionRefineRefineTabData dataCache = this.DataCache;
		EVisionRefineRefineType? evisionRefineRefineType = (dataCache != null) ? new EVisionRefineRefineType?(dataCache.RefineType) : null;
		return currentChosen == evisionRefineRefineType.GetValueOrDefault() & evisionRefineRefineType != null;
	}

	// Token: 0x04004F09 RID: 20233
	[Nullable(2)]
	private VisionRefineRefineTabData DataCache;

	// Token: 0x02007D63 RID: 32099
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040290F0 RID: 168176
		Toggle,
		// Token: 0x040290F1 RID: 168177
		Text
	}
}
