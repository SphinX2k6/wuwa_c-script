using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001821 RID: 6177
[NullableContext(1)]
[Nullable(0)]
public class MultiSelectDropDown<[Nullable(2)] TData, [Nullable(2)] T> : UiPanelBase
{
	// Token: 0x0600B526 RID: 46374 RVA: 0x0028E3B8 File Offset: 0x0028C5B8
	public MultiSelectDropDown(UUIItem sourceItem, Func<UUIItem, T, DropDownItemBase<TData>> createDropDownItem, Func<UUIItem, MultiSelectTitleItemBase<TData>> createTitleItem)
	{
		this.SourceItem = sourceItem;
		this.CreateDropDownItem = createDropDownItem;
		this.CreateTitleItem = createTitleItem;
	}

	// Token: 0x0600B527 RID: 46375 RVA: 0x0028E414 File Offset: 0x0028C614
	public UniTask Init()
	{
		MultiSelectDropDown<TData, T>.<Init>d__22 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<MultiSelectDropDown<TData, T>.<Init>d__22>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600B528 RID: 46376 RVA: 0x0028E458 File Offset: 0x0028C658
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B529 RID: 46377 RVA: 0x0028E564 File Offset: 0x0028C764
	private void ButtonClick()
	{
		UUIItem item = base.GetItem(1);
		if (item.bIsUIActive)
		{
			this.HideDropList();
			EventSystem.Instance.Emit<bool>(EEventName.OnDropDownListVisibleChanged, false);
			return;
		}
		item.SetUIActive(true);
		this.CalculateDirty = true;
		this.ShowMaskButton();
		Action onOpenCall = this.OnOpenCall;
		if (onOpenCall != null)
		{
			onOpenCall();
		}
		EventSystem.Instance.Emit<bool>(EEventName.OnDropDownListVisibleChanged, true);
	}

	// Token: 0x0600B52A RID: 46378 RVA: 0x0028E5D0 File Offset: 0x0028C7D0
	protected override void OnStart()
	{
		this.Layout = new GenericLayoutNew<DropDownItemBase<TData>>(base.GetLayoutBase(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<DropDownItemBase<TData>>(this.InitItem), base.GetItem(3));
		this.Layout.BindLateUpdate(new Action<float>(this.CalculateListPosition));
		base.GetItem(1).SetUIActive(false);
		this.TitleItem = this.CreateTitleItem(base.GetItem(4));
	}

	// Token: 0x0600B52B RID: 46379 RVA: 0x0028E640 File Offset: 0x0028C840
	private LayoutItem<DropDownItemBase<TData>> InitItem(object data, UUIItem uiItem, int index)
	{
		DropDownItemBase<TData> dropDownItemBase = this.CreateDropDownItem(uiItem, (T)((object)data));
		TData data2 = this.GetDataFunction((T)((object)data));
		dropDownItemBase.ShowDropDownItemBase(data2, index);
		dropDownItemBase.SetToggleFunction(new Action<int>(this.OnSelectChange));
		dropDownItemBase.SetCanExecuteFunction(new Func<int, bool>(this.CanExecuteFunction));
		return new LayoutItem<DropDownItemBase<TData>>
		{
			Key = index,
			Value = dropDownItemBase
		};
	}

	// Token: 0x0600B52C RID: 46380 RVA: 0x0028E6B8 File Offset: 0x0028C8B8
	private void OnSelectChange(int selectedIndex)
	{
		if (this.SuppressCallback)
		{
			return;
		}
		if (this.SelectedIndices.Contains(selectedIndex))
		{
			this.SelectedIndices.Remove(selectedIndex);
		}
		else
		{
			this.SelectedIndices.Add(selectedIndex);
		}
		Action<int, bool> onItemToggleCall = this.OnItemToggleCall;
		if (onItemToggleCall != null)
		{
			onItemToggleCall(selectedIndex, this.SelectedIndices.Contains(selectedIndex));
		}
		this.UpdateTitle();
	}

	// Token: 0x0600B52D RID: 46381 RVA: 0x0028E71C File Offset: 0x0028C91C
	private bool CanExecuteFunction(int selectedIndex)
	{
		return true;
	}

	// Token: 0x0600B52E RID: 46382 RVA: 0x0028E71F File Offset: 0x0028C91F
	protected override void OnBeforeDestroy()
	{
		this.Layout.UnBindLateUpdate();
		DynamicMaskButton maskButton = this.MaskButton;
		if (maskButton != null)
		{
			maskButton.Destroy(null);
		}
		this.TitleItem.Destroy(null);
	}

	// Token: 0x0600B52F RID: 46383 RVA: 0x0028E74C File Offset: 0x0028C94C
	public unsafe void InitScroll(IReadOnlyList<T> dataList, Func<T, TData> getDataFunction, [Nullable(2)] List<int> defaultIndices = null)
	{
		if (defaultIndices == null)
		{
			int num = 1;
			List<int> list = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list, num);
			Span<int> span = CollectionsMarshal.AsSpan<int>(list);
			int index = 0;
			*span[index] = 0;
			defaultIndices = list;
		}
		this.DataList = dataList;
		this.GetDataFunction = getDataFunction;
		this.Layout.RebuildLayoutByDataNew<T>(dataList, null);
		this.SelectedIndices.Clear();
		this.SuppressCallback = true;
		foreach (int num2 in defaultIndices)
		{
			this.SelectedIndices.Add(num2);
			DropDownItemBase<TData> layoutItemByKey = this.Layout.GetLayoutItemByKey(num2);
			if (layoutItemByKey != null)
			{
				layoutItemByKey.SetToggle(true);
			}
		}
		this.SuppressCallback = false;
		this.UpdateTitle();
	}

	// Token: 0x0600B530 RID: 46384 RVA: 0x0028E82C File Offset: 0x0028CA2C
	public void RefreshAllDropDownItem()
	{
		if (this.DataList == null)
		{
			return;
		}
		this.Layout.RebuildLayoutByDataNew<T>(this.DataList, null);
		this.SuppressCallback = true;
		foreach (int num in this.SelectedIndices)
		{
			DropDownItemBase<TData> layoutItemByKey = this.Layout.GetLayoutItemByKey(num);
			if (layoutItemByKey != null)
			{
				layoutItemByKey.SetToggle(true);
			}
		}
		this.SuppressCallback = false;
		this.UpdateTitle();
	}

	// Token: 0x0600B531 RID: 46385 RVA: 0x0028E8CC File Offset: 0x0028CACC
	private void HideDropList()
	{
		base.GetItem(1).SetUIActive(false);
		this.HideMaskButton();
		List<int> list = this.SelectedIndices.ToList<int>();
		list.Sort((int a, int b) => a - b);
		Action<List<int>> onCloseCall = this.OnCloseCall;
		if (onCloseCall == null)
		{
			return;
		}
		onCloseCall(list);
	}

	// Token: 0x0600B532 RID: 46386 RVA: 0x0028E930 File Offset: 0x0028CB30
	private UniTask ShowMaskButton()
	{
		MultiSelectDropDown<TData, T>.<ShowMaskButton>d__33 <ShowMaskButton>d__;
		<ShowMaskButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowMaskButton>d__.<>4__this = this;
		<ShowMaskButton>d__.<>1__state = -1;
		<ShowMaskButton>d__.<>t__builder.Start<MultiSelectDropDown<TData, T>.<ShowMaskButton>d__33>(ref <ShowMaskButton>d__);
		return <ShowMaskButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600B533 RID: 46387 RVA: 0x0028E973 File Offset: 0x0028CB73
	private void HideMaskButton()
	{
		if (this.MaskButton == null)
		{
			return;
		}
		this.MaskButton.ResetItemParent();
		this.MaskButton.SetActive(false);
	}

	// Token: 0x0600B534 RID: 46388 RVA: 0x0028E998 File Offset: 0x0028CB98
	private void UpdateTitle()
	{
		List<TData> list = new List<TData>();
		foreach (int index in this.SelectedIndices)
		{
			list.Add(this.GetDataFunction(this.DataList[index]));
		}
		this.TitleItem.ShowMultiSelectTitle(list);
	}

	// Token: 0x0600B535 RID: 46389 RVA: 0x0028EA14 File Offset: 0x0028CC14
	private void SetListShowBottom()
	{
		UUIItem item = base.GetItem(1);
		item.SetAnchorVAlign(UIAnchorVerticalAlign.Bottom);
		item.SetPivot(new FVector2D(0.5f, 1f));
		item.SetAnchorOffsetX(0f);
		item.SetAnchorOffsetY(0f);
	}

	// Token: 0x0600B536 RID: 46390 RVA: 0x0028EA4E File Offset: 0x0028CC4E
	private void SetListShowTop()
	{
		UUIItem item = base.GetItem(1);
		item.SetAnchorVAlign(UIAnchorVerticalAlign.Top);
		item.SetPivot(new FVector2D(0.5f, 0f));
		item.SetAnchorOffsetX(0f);
		item.SetAnchorOffsetY(0f);
	}

	// Token: 0x0600B537 RID: 46391 RVA: 0x0028EA88 File Offset: 0x0028CC88
	private void SetBottomAutoSize(float listBottom, float screenBottom)
	{
		UUIItem item = base.GetItem(1);
		if ((item.GetOwner().GetComponentByClass(UUISizeControlByOther.StaticClass()) as UUISizeControlByOther).ControlHeight)
		{
			return;
		}
		float height = listBottom - screenBottom - 75f;
		item.SetHeight(height);
	}

	// Token: 0x0600B538 RID: 46392 RVA: 0x0028EAD0 File Offset: 0x0028CCD0
	private void CalculateListPosition(float deltaTime)
	{
		if (this.OriginalWorldTrans == null)
		{
			return;
		}
		if (!this.CalculateDirty)
		{
			return;
		}
		TWeakObjectPtr<UUIItem> rootUIComp = base.GetButton(0).RootUIComp;
		ULGUICanvas rootCanvas = rootUIComp.Get().GetRootCanvas();
		FTransformDouble ftransformDouble = UiLayer.Instance.GetLayerRootUiItem(ELayerType.Pop).D_K2_GetComponentToWorld();
		Transform target = Transform.Create(ftransformDouble.Inverse());
		Transform selfToCanvasTrans = this.SelfToCanvasTrans;
		ftransformDouble = this.OriginalWorldTrans.Value;
		selfToCanvasTrans.FromUeTransform(ftransformDouble);
		this.SelfToCanvasTrans.ComposeTransforms(target, this.SelfToCanvasTrans);
		Vector buttonBottomToCanvasPos = this.ButtonBottomToCanvasPos;
		FVector relativeLocation = rootUIComp.Get().RelativeLocation;
		FVectorDouble fvectorDouble = relativeLocation;
		buttonBottomToCanvasPos.DeepCopy(fvectorDouble);
		this.ButtonBottomToCanvasPos.Y -= (double)(rootUIComp.Get().GetHeight() / 2f);
		double y = this.ButtonBottomToCanvasPos.Y - (double)this.Layout.GetRootUiItem().GetHeight();
		this.ListBottomInCanvasSpace.Y = y;
		this.SelfToCanvasTrans.TransformPosition(this.ButtonBottomToCanvasPos, this.ButtonBottomToCanvasPos);
		this.SelfToCanvasTrans.TransformPosition(this.ListBottomInCanvasSpace, this.ListBottomInCanvasSpace);
		FVector2D clipRectMin = rootCanvas.GetClipRectMin();
		if (this.ShowType == ECommonDropDownShowType.Down)
		{
			this.SetListShowBottom();
			if (this.ListBottomInCanvasSpace.Y < (double)(clipRectMin.Y + 75f))
			{
				this.SetBottomAutoSize((float)this.ButtonBottomToCanvasPos.Y, clipRectMin.Y);
			}
			this.CalculateDirty = false;
			return;
		}
		if (this.ShowType == ECommonDropDownShowType.Up)
		{
			this.SetListShowTop();
			this.CalculateDirty = false;
			return;
		}
		if (this.ListBottomInCanvasSpace.Y < (double)clipRectMin.Y)
		{
			this.SetListShowTop();
		}
		else
		{
			this.SetListShowBottom();
		}
		this.CalculateDirty = false;
	}

	// Token: 0x0600B539 RID: 46393 RVA: 0x0028EC8E File Offset: 0x0028CE8E
	public IReadOnlySet<int> GetSelectedIndices()
	{
		return this.SelectedIndices;
	}

	// Token: 0x0600B53A RID: 46394 RVA: 0x0028EC98 File Offset: 0x0028CE98
	public void SetSelectedIndices(List<int> indices)
	{
		this.SuppressCallback = true;
		foreach (int num in this.SelectedIndices)
		{
			DropDownItemBase<TData> layoutItemByKey = this.Layout.GetLayoutItemByKey(num);
			if (layoutItemByKey != null)
			{
				layoutItemByKey.SetToggle(false);
			}
		}
		this.SelectedIndices.Clear();
		foreach (int num2 in indices)
		{
			this.SelectedIndices.Add(num2);
			DropDownItemBase<TData> layoutItemByKey2 = this.Layout.GetLayoutItemByKey(num2);
			if (layoutItemByKey2 != null)
			{
				layoutItemByKey2.SetToggle(true);
			}
		}
		this.SuppressCallback = false;
		this.UpdateTitle();
	}

	// Token: 0x0600B53B RID: 46395 RVA: 0x0028ED80 File Offset: 0x0028CF80
	public void ToggleItem(int index, bool isChecked)
	{
		this.SuppressCallback = true;
		if (isChecked)
		{
			this.SelectedIndices.Add(index);
		}
		else
		{
			this.SelectedIndices.Remove(index);
		}
		DropDownItemBase<TData> layoutItemByKey = this.Layout.GetLayoutItemByKey(index);
		if (layoutItemByKey != null)
		{
			layoutItemByKey.SetToggle(isChecked);
		}
		this.SuppressCallback = false;
		this.UpdateTitle();
	}

	// Token: 0x0600B53C RID: 46396 RVA: 0x0028EDDD File Offset: 0x0028CFDD
	public void SetShowType(ECommonDropDownShowType showType)
	{
		if (this.ShowType == showType)
		{
			return;
		}
		this.ShowType = showType;
		this.CalculateDirty = true;
	}

	// Token: 0x0600B53D RID: 46397 RVA: 0x0028EDF7 File Offset: 0x0028CFF7
	public void SetOnCloseCall(Action<List<int>> onCloseCall)
	{
		this.OnCloseCall = onCloseCall;
	}

	// Token: 0x0600B53E RID: 46398 RVA: 0x0028EE00 File Offset: 0x0028D000
	public void SetOnItemToggleCall(Action<int, bool> onItemToggleCall)
	{
		this.OnItemToggleCall = onItemToggleCall;
	}

	// Token: 0x0600B53F RID: 46399 RVA: 0x0028EE09 File Offset: 0x0028D009
	public void SetOnOpenCall(Action onOpenCall)
	{
		this.OnOpenCall = onOpenCall;
	}

	// Token: 0x0600B540 RID: 46400 RVA: 0x0028EE12 File Offset: 0x0028D012
	public DropDownItemBase<TData> GetDropDownItemObject(int index)
	{
		return this.Layout.GetLayoutItemByIndex(index);
	}

	// Token: 0x0600B541 RID: 46401 RVA: 0x0028EE20 File Offset: 0x0028D020
	public DropDownItemBase<TData>[] GetDropDownItemList()
	{
		return this.Layout.GetLayoutItemList().ToArray();
	}

	// Token: 0x040051C3 RID: 20931
	private UUIItem SourceItem;

	// Token: 0x040051C4 RID: 20932
	private Func<UUIItem, T, DropDownItemBase<TData>> CreateDropDownItem;

	// Token: 0x040051C5 RID: 20933
	private Func<UUIItem, MultiSelectTitleItemBase<TData>> CreateTitleItem;

	// Token: 0x040051C6 RID: 20934
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayoutNew<DropDownItemBase<TData>> Layout;

	// Token: 0x040051C7 RID: 20935
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IReadOnlyList<T> DataList;

	// Token: 0x040051C8 RID: 20936
	private readonly HashSet<int> SelectedIndices = new HashSet<int>();

	// Token: 0x040051C9 RID: 20937
	[Nullable(2)]
	private DynamicMaskButton MaskButton;

	// Token: 0x040051CA RID: 20938
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<List<int>> OnCloseCall;

	// Token: 0x040051CB RID: 20939
	[Nullable(2)]
	private Action<int, bool> OnItemToggleCall;

	// Token: 0x040051CC RID: 20940
	[Nullable(2)]
	private Action OnOpenCall;

	// Token: 0x040051CD RID: 20941
	private ECommonDropDownShowType ShowType = ECommonDropDownShowType.Auto;

	// Token: 0x040051CE RID: 20942
	private bool CalculateDirty;

	// Token: 0x040051CF RID: 20943
	private readonly Transform SelfToCanvasTrans = Transform.Create();

	// Token: 0x040051D0 RID: 20944
	private readonly Vector ButtonBottomToCanvasPos = Vector.Create();

	// Token: 0x040051D1 RID: 20945
	private readonly Vector ListBottomInCanvasSpace = Vector.Create();

	// Token: 0x040051D2 RID: 20946
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Func<T, TData> GetDataFunction;

	// Token: 0x040051D3 RID: 20947
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private MultiSelectTitleItemBase<TData> TitleItem;

	// Token: 0x040051D4 RID: 20948
	private FTransformDouble? OriginalWorldTrans;

	// Token: 0x040051D5 RID: 20949
	private bool SuppressCallback;

	// Token: 0x040051D6 RID: 20950
	private const float BOTTOM_OFFSET = 75f;

	// Token: 0x02007E0C RID: 32268
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x04029400 RID: 168960
		Button,
		// Token: 0x04029401 RID: 168961
		ListRoot,
		// Token: 0x04029402 RID: 168962
		Layout,
		// Token: 0x04029403 RID: 168963
		LayoutItem,
		// Token: 0x04029404 RID: 168964
		Title
	}
}
