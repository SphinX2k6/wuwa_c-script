using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000CDA RID: 3290
[NullableContext(1)]
[Nullable(0)]
public class MultiSelectDropDown<[Nullable(2)] TData, [Nullable(2)] T> : UiPanelBase
{
	// Token: 0x06008911 RID: 35089 RVA: 0x00298AD8 File Offset: 0x00296CD8
	public MultiSelectDropDown(UUIItem sourceItem, Func<UUIItem, T, DropDownItemBase<TData>> createDropDownItem, Func<UUIItem, MultiSelectTitleItemBase<TData>> createTitleItem)
	{
		this.SourceItem = sourceItem;
		this.CreateDropDownItem = createDropDownItem;
		this.CreateTitleItem = createTitleItem;
	}

	// Token: 0x06008912 RID: 35090 RVA: 0x00298B34 File Offset: 0x00296D34
	public UniTask Init()
	{
		MultiSelectDropDown<TData, T>.<Init>d__22 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<MultiSelectDropDown<TData, T>.<Init>d__22>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06008913 RID: 35091 RVA: 0x00298B78 File Offset: 0x00296D78
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

	// Token: 0x06008914 RID: 35092 RVA: 0x00298C84 File Offset: 0x00296E84
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

	// Token: 0x06008915 RID: 35093 RVA: 0x00298CF0 File Offset: 0x00296EF0
	protected override void OnStart()
	{
		this.Layout = new GenericLayoutNew<DropDownItemBase<TData>>(base.GetLayoutBase(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<DropDownItemBase<TData>>(this.InitItem), base.GetItem(3));
		this.Layout.BindLateUpdate(new Action<float>(this.CalculateListPosition));
		base.GetItem(1).SetUIActive(false);
		this.TitleItem = this.CreateTitleItem(base.GetItem(4));
	}

	// Token: 0x06008916 RID: 35094 RVA: 0x00298D60 File Offset: 0x00296F60
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

	// Token: 0x06008917 RID: 35095 RVA: 0x00298DD8 File Offset: 0x00296FD8
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

	// Token: 0x06008918 RID: 35096 RVA: 0x00298E3C File Offset: 0x0029703C
	private bool CanExecuteFunction(int selectedIndex)
	{
		return true;
	}

	// Token: 0x06008919 RID: 35097 RVA: 0x00298E3F File Offset: 0x0029703F
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

	// Token: 0x0600891A RID: 35098 RVA: 0x00298E6C File Offset: 0x0029706C
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

	// Token: 0x0600891B RID: 35099 RVA: 0x00298F4C File Offset: 0x0029714C
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

	// Token: 0x0600891C RID: 35100 RVA: 0x00298FEC File Offset: 0x002971EC
	private void HideDropList()
	{
		base.GetItem(1).SetUIActive(false);
		this.HideMaskButton();
		List<int> list = new List<int>(this.SelectedIndices);
		list.Sort((int a, int b) => a - b);
		Action<List<int>> onCloseCall = this.OnCloseCall;
		if (onCloseCall == null)
		{
			return;
		}
		onCloseCall(list);
	}

	// Token: 0x0600891D RID: 35101 RVA: 0x00299050 File Offset: 0x00297250
	private UniTask ShowMaskButton()
	{
		MultiSelectDropDown<TData, T>.<ShowMaskButton>d__33 <ShowMaskButton>d__;
		<ShowMaskButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowMaskButton>d__.<>4__this = this;
		<ShowMaskButton>d__.<>1__state = -1;
		<ShowMaskButton>d__.<>t__builder.Start<MultiSelectDropDown<TData, T>.<ShowMaskButton>d__33>(ref <ShowMaskButton>d__);
		return <ShowMaskButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600891E RID: 35102 RVA: 0x00299093 File Offset: 0x00297293
	private void HideMaskButton()
	{
		if (this.MaskButton == null)
		{
			return;
		}
		this.MaskButton.ResetItemParent();
		this.MaskButton.SetActive(false);
	}

	// Token: 0x0600891F RID: 35103 RVA: 0x002990B8 File Offset: 0x002972B8
	private void UpdateTitle()
	{
		List<TData> list = new List<TData>();
		foreach (int index in this.SelectedIndices)
		{
			list.Add(this.GetDataFunction(this.DataList[index]));
		}
		this.TitleItem.ShowMultiSelectTitle(list);
	}

	// Token: 0x06008920 RID: 35104 RVA: 0x00299134 File Offset: 0x00297334
	private void SetListShowBottom()
	{
		UUIItem item = base.GetItem(1);
		item.SetAnchorVAlign(UIAnchorVerticalAlign.Bottom);
		item.SetPivot(new FVector2D(0.5f, 1f));
		item.SetAnchorOffsetX(0f);
		item.SetAnchorOffsetY(0f);
	}

	// Token: 0x06008921 RID: 35105 RVA: 0x0029916E File Offset: 0x0029736E
	private void SetListShowTop()
	{
		UUIItem item = base.GetItem(1);
		item.SetAnchorVAlign(UIAnchorVerticalAlign.Top);
		item.SetPivot(new FVector2D(0.5f, 0f));
		item.SetAnchorOffsetX(0f);
		item.SetAnchorOffsetY(0f);
	}

	// Token: 0x06008922 RID: 35106 RVA: 0x002991A8 File Offset: 0x002973A8
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

	// Token: 0x06008923 RID: 35107 RVA: 0x002991F0 File Offset: 0x002973F0
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

	// Token: 0x06008924 RID: 35108 RVA: 0x002993AE File Offset: 0x002975AE
	public IReadOnlySet<int> GetSelectedIndices()
	{
		return this.SelectedIndices;
	}

	// Token: 0x06008925 RID: 35109 RVA: 0x002993B8 File Offset: 0x002975B8
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

	// Token: 0x06008926 RID: 35110 RVA: 0x002994A0 File Offset: 0x002976A0
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

	// Token: 0x06008927 RID: 35111 RVA: 0x002994FD File Offset: 0x002976FD
	public void SetShowType(ECommonDropDownShowType showType)
	{
		if (this.ShowType == showType)
		{
			return;
		}
		this.ShowType = showType;
		this.CalculateDirty = true;
	}

	// Token: 0x06008928 RID: 35112 RVA: 0x00299517 File Offset: 0x00297717
	public void SetOnCloseCall(Action<List<int>> onCloseCall)
	{
		this.OnCloseCall = onCloseCall;
	}

	// Token: 0x06008929 RID: 35113 RVA: 0x00299520 File Offset: 0x00297720
	public void SetOnItemToggleCall(Action<int, bool> onItemToggleCall)
	{
		this.OnItemToggleCall = onItemToggleCall;
	}

	// Token: 0x0600892A RID: 35114 RVA: 0x00299529 File Offset: 0x00297729
	public void SetOnOpenCall(Action onOpenCall)
	{
		this.OnOpenCall = onOpenCall;
	}

	// Token: 0x0600892B RID: 35115 RVA: 0x00299532 File Offset: 0x00297732
	public DropDownItemBase<TData> GetDropDownItemObject(int index)
	{
		return this.Layout.GetLayoutItemByIndex(index);
	}

	// Token: 0x0600892C RID: 35116 RVA: 0x00299540 File Offset: 0x00297740
	public DropDownItemBase<TData>[] GetDropDownItemList()
	{
		return this.Layout.GetLayoutItemList().ToArray();
	}

	// Token: 0x0400526E RID: 21102
	private UUIItem SourceItem;

	// Token: 0x0400526F RID: 21103
	private Func<UUIItem, T, DropDownItemBase<TData>> CreateDropDownItem;

	// Token: 0x04005270 RID: 21104
	private Func<UUIItem, MultiSelectTitleItemBase<TData>> CreateTitleItem;

	// Token: 0x04005271 RID: 21105
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayoutNew<DropDownItemBase<TData>> Layout;

	// Token: 0x04005272 RID: 21106
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IReadOnlyList<T> DataList;

	// Token: 0x04005273 RID: 21107
	private readonly HashSet<int> SelectedIndices = new HashSet<int>();

	// Token: 0x04005274 RID: 21108
	[Nullable(2)]
	private DynamicMaskButton MaskButton;

	// Token: 0x04005275 RID: 21109
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<List<int>> OnCloseCall;

	// Token: 0x04005276 RID: 21110
	[Nullable(2)]
	private Action<int, bool> OnItemToggleCall;

	// Token: 0x04005277 RID: 21111
	[Nullable(2)]
	private Action OnOpenCall;

	// Token: 0x04005278 RID: 21112
	private ECommonDropDownShowType ShowType = ECommonDropDownShowType.Auto;

	// Token: 0x04005279 RID: 21113
	private bool CalculateDirty;

	// Token: 0x0400527A RID: 21114
	private readonly Transform SelfToCanvasTrans = Transform.Create();

	// Token: 0x0400527B RID: 21115
	private readonly Vector ButtonBottomToCanvasPos = Vector.Create();

	// Token: 0x0400527C RID: 21116
	private readonly Vector ListBottomInCanvasSpace = Vector.Create();

	// Token: 0x0400527D RID: 21117
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Func<T, TData> GetDataFunction;

	// Token: 0x0400527E RID: 21118
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private MultiSelectTitleItemBase<TData> TitleItem;

	// Token: 0x0400527F RID: 21119
	private FTransformDouble? OriginalWorldTrans;

	// Token: 0x04005280 RID: 21120
	private bool SuppressCallback;

	// Token: 0x04005281 RID: 21121
	private const float BOTTOM_OFFSET = 75f;

	// Token: 0x02006F92 RID: 28562
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x0402472B RID: 149291
		Button,
		// Token: 0x0402472C RID: 149292
		ListRoot,
		// Token: 0x0402472D RID: 149293
		Layout,
		// Token: 0x0402472E RID: 149294
		LayoutItem,
		// Token: 0x0402472F RID: 149295
		Title
	}
}
