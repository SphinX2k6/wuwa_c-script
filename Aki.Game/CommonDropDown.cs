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

// Token: 0x02000CD3 RID: 3283
[NullableContext(1)]
[Nullable(0)]
public class CommonDropDown<[Nullable(2)] TData, [Nullable(2)] T> : UiPanelBase
{
	// Token: 0x060088DE RID: 35038 RVA: 0x00298000 File Offset: 0x00296200
	public CommonDropDown(UUIItem sourceItem, Func<UUIItem, T, DropDownItemBase<TData>> createDropDownItem, Func<UUIItem, TitleItemBase<TData>> createTitleItem)
	{
		this.SourceItem = sourceItem;
		this.CreateDropDownItem = createDropDownItem;
		this.CreateTitleItem = createTitleItem;
	}

	// Token: 0x060088DF RID: 35039 RVA: 0x00298058 File Offset: 0x00296258
	public UniTask Init()
	{
		CommonDropDown<TData, T>.<Init>d__22 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<CommonDropDown<TData, T>.<Init>d__22>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060088E0 RID: 35040 RVA: 0x0029809C File Offset: 0x0029629C
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

	// Token: 0x060088E1 RID: 35041 RVA: 0x002981A8 File Offset: 0x002963A8
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

	// Token: 0x060088E2 RID: 35042 RVA: 0x00298214 File Offset: 0x00296414
	protected override void OnStart()
	{
		this.Layout = new GenericLayoutNew<DropDownItemBase<TData>>(base.GetLayoutBase(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<DropDownItemBase<TData>>(this.InitItem), base.GetItem(3));
		this.Layout.BindLateUpdate(new Action<float>(this.CalculateListPosition));
		base.GetItem(1).SetUIActive(false);
		this.TitleItem = this.CreateTitleItem(base.GetItem(4));
	}

	// Token: 0x060088E3 RID: 35043 RVA: 0x00298284 File Offset: 0x00296484
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

	// Token: 0x060088E4 RID: 35044 RVA: 0x002982FC File Offset: 0x002964FC
	private void OnSelectChange(int selectedIndex)
	{
		int selectedIndex2 = this.SelectedIndex;
		this.SelectedIndex = selectedIndex;
		this.CancelLastSelect(selectedIndex2);
		this.HandleSelect();
		if (!this.DoNotSelectCall)
		{
			Action<int, T> onSelectCall = this.OnSelectCall;
			if (onSelectCall == null)
			{
				return;
			}
			onSelectCall(this.SelectedIndex, this.DataList[this.SelectedIndex]);
		}
	}

	// Token: 0x060088E5 RID: 35045 RVA: 0x00298353 File Offset: 0x00296553
	private bool CanExecuteFunction(int selectedIndex)
	{
		if (this.OnChangeCall != null)
		{
			return this.OnChangeCall(this.SelectedIndex, selectedIndex);
		}
		return this.SelectedIndex != selectedIndex;
	}

	// Token: 0x060088E6 RID: 35046 RVA: 0x0029837C File Offset: 0x0029657C
	public void SetOnCanChangeCall(Func<int, int, bool> onChangeCall)
	{
		this.OnChangeCall = onChangeCall;
	}

	// Token: 0x060088E7 RID: 35047 RVA: 0x00298385 File Offset: 0x00296585
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

	// Token: 0x060088E8 RID: 35048 RVA: 0x002983B0 File Offset: 0x002965B0
	public void InitScroll(IReadOnlyList<T> dataList, Func<T, TData> getDataFunction, int defaultIndex = 0, bool triggerSelectCall = true)
	{
		this.DataList = dataList;
		this.GetDataFunction = getDataFunction;
		foreach (DropDownItemBase<TData> dropDownItemBase in this.Layout.GetLayoutItemList())
		{
			dropDownItemBase.SetToggleForce(false);
		}
		this.SelectedIndex = -1;
		this.Layout.RebuildLayoutByDataNew<T>(dataList, null);
		this.SetSelectedIndex(defaultIndex, triggerSelectCall);
	}

	// Token: 0x060088E9 RID: 35049 RVA: 0x0029843C File Offset: 0x0029663C
	private void HideDropList()
	{
		base.GetItem(1).SetUIActive(false);
		this.HideMaskButton();
	}

	// Token: 0x060088EA RID: 35050 RVA: 0x00298451 File Offset: 0x00296651
	private void ShowMaskButton()
	{
		this.OriginalWorldTrans = this.RootActor.RootComponent.D_K2_GetComponentToWorld();
		this.MaskButton.SetAttachChildItem(this.RootItem);
		this.MaskButton.SetActive(true);
	}

	// Token: 0x060088EB RID: 35051 RVA: 0x00298486 File Offset: 0x00296686
	private void HideMaskButton()
	{
		if (this.MaskButton == null)
		{
			return;
		}
		this.MaskButton.ResetItemParent();
		this.MaskButton.SetActive(false);
	}

	// Token: 0x060088EC RID: 35052 RVA: 0x002984A8 File Offset: 0x002966A8
	private void CancelLastSelect(int lastSelect)
	{
		if (lastSelect != -1)
		{
			DropDownItemBase<TData> layoutItemByKey = this.Layout.GetLayoutItemByKey(lastSelect);
			if (layoutItemByKey == null)
			{
				return;
			}
			layoutItemByKey.SetToggle(false);
		}
	}

	// Token: 0x060088ED RID: 35053 RVA: 0x002984CC File Offset: 0x002966CC
	private void HandleSelect()
	{
		TData data = this.GetDataFunction(this.DataList[this.SelectedIndex]);
		DropDownItemBase<TData> layoutItemByIndex = this.Layout.GetLayoutItemByIndex(this.SelectedIndex);
		this.TitleItem.ShowTemp(data, layoutItemByIndex);
		this.HideDropList();
	}

	// Token: 0x060088EE RID: 35054 RVA: 0x0029851B File Offset: 0x0029671B
	private void SetListShowBottom()
	{
		UUIItem item = base.GetItem(1);
		item.SetAnchorVAlign(UIAnchorVerticalAlign.Bottom);
		item.SetPivot(new FVector2D(0.5f, 1f));
		item.SetAnchorOffsetX(0f);
		item.SetAnchorOffsetY(0f);
	}

	// Token: 0x060088EF RID: 35055 RVA: 0x00298555 File Offset: 0x00296755
	private void SetListShowTop()
	{
		UUIItem item = base.GetItem(1);
		item.SetAnchorVAlign(UIAnchorVerticalAlign.Top);
		item.SetPivot(new FVector2D(0.5f, 0f));
		item.SetAnchorOffsetX(0f);
		item.SetAnchorOffsetY(0f);
	}

	// Token: 0x060088F0 RID: 35056 RVA: 0x00298590 File Offset: 0x00296790
	private void CalculateListPosition(float deltaTime)
	{
		FTransformDouble originalWorldTrans = this.OriginalWorldTrans;
		if (!this.CalculateDirty)
		{
			return;
		}
		TWeakObjectPtr<UUIItem> rootUIComp = base.GetButton(0).RootUIComp;
		ULGUICanvas rootCanvas = rootUIComp.Get().GetRootCanvas();
		Transform target = Transform.Create(UiLayer.Instance.GetLayerRootUiItem(ELayerType.Pop).D_K2_GetComponentToWorld().Inverse());
		this.SelfToCanvasTrans.FromUeTransform(this.OriginalWorldTrans);
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

	// Token: 0x060088F1 RID: 35057 RVA: 0x00298740 File Offset: 0x00296940
	private void SetBottomAutoSize(float listBottom, float screenBottom)
	{
		UUIItem item = base.GetItem(1);
		UUISizeControlByOther uuisizeControlByOther = item.GetOwner().GetComponentByClass(UUISizeControlByOther.StaticClass()) as UUISizeControlByOther;
		if (uuisizeControlByOther != null && uuisizeControlByOther.ControlHeight)
		{
			return;
		}
		float height = listBottom - screenBottom - 75f;
		item.SetHeight(height);
	}

	// Token: 0x060088F2 RID: 35058 RVA: 0x0029878D File Offset: 0x0029698D
	public void SetSelectedIndex(int index, bool triggerSelectCall = true)
	{
		this.DoNotSelectCall = !triggerSelectCall;
		DropDownItemBase<TData> layoutItemByKey = this.Layout.GetLayoutItemByKey(index);
		if (layoutItemByKey != null)
		{
			layoutItemByKey.SetToggle(true);
		}
		this.DoNotSelectCall = false;
	}

	// Token: 0x060088F3 RID: 35059 RVA: 0x002987BD File Offset: 0x002969BD
	public int GetSelectedIndex()
	{
		return this.SelectedIndex;
	}

	// Token: 0x060088F4 RID: 35060 RVA: 0x002987C5 File Offset: 0x002969C5
	public void SetShowType(ECommonDropDownShowType showType)
	{
		if (this.ShowType == showType)
		{
			return;
		}
		this.ShowType = showType;
		this.CalculateDirty = true;
	}

	// Token: 0x060088F5 RID: 35061 RVA: 0x002987DF File Offset: 0x002969DF
	public void SetOnSelectCall(Action<int, T> onSelectCall)
	{
		this.OnSelectCall = onSelectCall;
	}

	// Token: 0x060088F6 RID: 35062 RVA: 0x002987E8 File Offset: 0x002969E8
	public void SetOnOpenCall(Action onOpenCall)
	{
		this.OnOpenCall = onOpenCall;
	}

	// Token: 0x060088F7 RID: 35063 RVA: 0x002987F1 File Offset: 0x002969F1
	public DropDownItemBase<TData> GetDropDownItemObject(int index)
	{
		return this.Layout.GetLayoutItemByIndex(index);
	}

	// Token: 0x060088F8 RID: 35064 RVA: 0x002987FF File Offset: 0x002969FF
	public DropDownItemBase<TData>[] GetDropDownItemList()
	{
		return this.Layout.GetLayoutItemList().ToArray();
	}

	// Token: 0x060088F9 RID: 35065 RVA: 0x00298814 File Offset: 0x00296A14
	public void RefreshAllDropDownItem()
	{
		TData data = this.GetDataFunction(this.DataList[this.SelectedIndex]);
		DropDownItemBase<TData> layoutItemByIndex = this.Layout.GetLayoutItemByIndex(this.SelectedIndex);
		this.TitleItem.ShowTemp(data, layoutItemByIndex);
		this.Layout.RebuildLayoutByDataNew<T>(this.DataList, null);
	}

	// Token: 0x04005253 RID: 21075
	private UUIItem SourceItem;

	// Token: 0x04005254 RID: 21076
	private Func<UUIItem, T, DropDownItemBase<TData>> CreateDropDownItem;

	// Token: 0x04005255 RID: 21077
	private Func<UUIItem, TitleItemBase<TData>> CreateTitleItem;

	// Token: 0x04005256 RID: 21078
	private GenericLayoutNew<DropDownItemBase<TData>> Layout;

	// Token: 0x04005257 RID: 21079
	private const float BOTTOM_OFFSET = 75f;

	// Token: 0x04005258 RID: 21080
	private IReadOnlyList<T> DataList;

	// Token: 0x04005259 RID: 21081
	private int SelectedIndex = -1;

	// Token: 0x0400525A RID: 21082
	private bool DoNotSelectCall;

	// Token: 0x0400525B RID: 21083
	[Nullable(2)]
	private DynamicMaskButton MaskButton;

	// Token: 0x0400525C RID: 21084
	private Action<int, T> OnSelectCall;

	// Token: 0x0400525D RID: 21085
	[Nullable(2)]
	private Func<int, int, bool> OnChangeCall;

	// Token: 0x0400525E RID: 21086
	[Nullable(2)]
	private Action OnOpenCall;

	// Token: 0x0400525F RID: 21087
	private ECommonDropDownShowType ShowType = ECommonDropDownShowType.Auto;

	// Token: 0x04005260 RID: 21088
	private bool CalculateDirty;

	// Token: 0x04005261 RID: 21089
	private readonly Transform SelfToCanvasTrans = Transform.Create();

	// Token: 0x04005262 RID: 21090
	private readonly Vector ButtonBottomToCanvasPos = Vector.Create();

	// Token: 0x04005263 RID: 21091
	private readonly Vector ListBottomInCanvasSpace = Vector.Create();

	// Token: 0x04005264 RID: 21092
	private Func<T, TData> GetDataFunction;

	// Token: 0x04005265 RID: 21093
	private TitleItemBase<TData> TitleItem;

	// Token: 0x04005266 RID: 21094
	private FTransformDouble OriginalWorldTrans;

	// Token: 0x02006F8E RID: 28558
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x0402471E RID: 149278
		Button,
		// Token: 0x0402471F RID: 149279
		ListRoot,
		// Token: 0x04024720 RID: 149280
		Layout,
		// Token: 0x04024721 RID: 149281
		LayoutItem,
		// Token: 0x04024722 RID: 149282
		Title
	}
}
