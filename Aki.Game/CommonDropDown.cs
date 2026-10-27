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

// Token: 0x0200181A RID: 6170
[NullableContext(1)]
[Nullable(0)]
public class CommonDropDown<[Nullable(2)] TData, [Nullable(2)] T> : UiPanelBase
{
	// Token: 0x0600B4F3 RID: 46323 RVA: 0x0028D8E0 File Offset: 0x0028BAE0
	public CommonDropDown(UUIItem sourceItem, Func<UUIItem, T, DropDownItemBase<TData>> createDropDownItem, Func<UUIItem, TitleItemBase<TData>> createTitleItem)
	{
		this.SourceItem = sourceItem;
		this.CreateDropDownItem = createDropDownItem;
		this.CreateTitleItem = createTitleItem;
	}

	// Token: 0x0600B4F4 RID: 46324 RVA: 0x0028D938 File Offset: 0x0028BB38
	public UniTask Init()
	{
		CommonDropDown<TData, T>.<Init>d__22 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<CommonDropDown<TData, T>.<Init>d__22>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600B4F5 RID: 46325 RVA: 0x0028D97C File Offset: 0x0028BB7C
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

	// Token: 0x0600B4F6 RID: 46326 RVA: 0x0028DA88 File Offset: 0x0028BC88
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

	// Token: 0x0600B4F7 RID: 46327 RVA: 0x0028DAF4 File Offset: 0x0028BCF4
	protected override void OnStart()
	{
		this.Layout = new GenericLayoutNew<DropDownItemBase<TData>>(base.GetLayoutBase(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<DropDownItemBase<TData>>(this.InitItem), base.GetItem(3));
		this.Layout.BindLateUpdate(new Action<float>(this.CalculateListPosition));
		base.GetItem(1).SetUIActive(false);
		this.TitleItem = this.CreateTitleItem(base.GetItem(4));
	}

	// Token: 0x0600B4F8 RID: 46328 RVA: 0x0028DB64 File Offset: 0x0028BD64
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

	// Token: 0x0600B4F9 RID: 46329 RVA: 0x0028DBDC File Offset: 0x0028BDDC
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

	// Token: 0x0600B4FA RID: 46330 RVA: 0x0028DC33 File Offset: 0x0028BE33
	private bool CanExecuteFunction(int selectedIndex)
	{
		if (this.OnChangeCall != null)
		{
			return this.OnChangeCall(this.SelectedIndex, selectedIndex);
		}
		return this.SelectedIndex != selectedIndex;
	}

	// Token: 0x0600B4FB RID: 46331 RVA: 0x0028DC5C File Offset: 0x0028BE5C
	public void SetOnCanChangeCall(Func<int, int, bool> onChangeCall)
	{
		this.OnChangeCall = onChangeCall;
	}

	// Token: 0x0600B4FC RID: 46332 RVA: 0x0028DC65 File Offset: 0x0028BE65
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

	// Token: 0x0600B4FD RID: 46333 RVA: 0x0028DC90 File Offset: 0x0028BE90
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

	// Token: 0x0600B4FE RID: 46334 RVA: 0x0028DD1C File Offset: 0x0028BF1C
	private void HideDropList()
	{
		base.GetItem(1).SetUIActive(false);
		this.HideMaskButton();
	}

	// Token: 0x0600B4FF RID: 46335 RVA: 0x0028DD31 File Offset: 0x0028BF31
	private void ShowMaskButton()
	{
		this.OriginalWorldTrans = this.RootActor.RootComponent.D_K2_GetComponentToWorld();
		this.MaskButton.SetAttachChildItem(this.RootItem);
		this.MaskButton.SetActive(true);
	}

	// Token: 0x0600B500 RID: 46336 RVA: 0x0028DD66 File Offset: 0x0028BF66
	private void HideMaskButton()
	{
		if (this.MaskButton == null)
		{
			return;
		}
		this.MaskButton.ResetItemParent();
		this.MaskButton.SetActive(false);
	}

	// Token: 0x0600B501 RID: 46337 RVA: 0x0028DD88 File Offset: 0x0028BF88
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

	// Token: 0x0600B502 RID: 46338 RVA: 0x0028DDAC File Offset: 0x0028BFAC
	private void HandleSelect()
	{
		TData data = this.GetDataFunction(this.DataList[this.SelectedIndex]);
		DropDownItemBase<TData> layoutItemByIndex = this.Layout.GetLayoutItemByIndex(this.SelectedIndex);
		this.TitleItem.ShowTemp(data, layoutItemByIndex);
		this.HideDropList();
	}

	// Token: 0x0600B503 RID: 46339 RVA: 0x0028DDFB File Offset: 0x0028BFFB
	private void SetListShowBottom()
	{
		UUIItem item = base.GetItem(1);
		item.SetAnchorVAlign(UIAnchorVerticalAlign.Bottom);
		item.SetPivot(new FVector2D(0.5f, 1f));
		item.SetAnchorOffsetX(0f);
		item.SetAnchorOffsetY(0f);
	}

	// Token: 0x0600B504 RID: 46340 RVA: 0x0028DE35 File Offset: 0x0028C035
	private void SetListShowTop()
	{
		UUIItem item = base.GetItem(1);
		item.SetAnchorVAlign(UIAnchorVerticalAlign.Top);
		item.SetPivot(new FVector2D(0.5f, 0f));
		item.SetAnchorOffsetX(0f);
		item.SetAnchorOffsetY(0f);
	}

	// Token: 0x0600B505 RID: 46341 RVA: 0x0028DE70 File Offset: 0x0028C070
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

	// Token: 0x0600B506 RID: 46342 RVA: 0x0028E020 File Offset: 0x0028C220
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

	// Token: 0x0600B507 RID: 46343 RVA: 0x0028E06D File Offset: 0x0028C26D
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

	// Token: 0x0600B508 RID: 46344 RVA: 0x0028E09D File Offset: 0x0028C29D
	public int GetSelectedIndex()
	{
		return this.SelectedIndex;
	}

	// Token: 0x0600B509 RID: 46345 RVA: 0x0028E0A5 File Offset: 0x0028C2A5
	public void SetShowType(ECommonDropDownShowType showType)
	{
		if (this.ShowType == showType)
		{
			return;
		}
		this.ShowType = showType;
		this.CalculateDirty = true;
	}

	// Token: 0x0600B50A RID: 46346 RVA: 0x0028E0BF File Offset: 0x0028C2BF
	public void SetOnSelectCall(Action<int, T> onSelectCall)
	{
		this.OnSelectCall = onSelectCall;
	}

	// Token: 0x0600B50B RID: 46347 RVA: 0x0028E0C8 File Offset: 0x0028C2C8
	public void SetOnOpenCall(Action onOpenCall)
	{
		this.OnOpenCall = onOpenCall;
	}

	// Token: 0x0600B50C RID: 46348 RVA: 0x0028E0D1 File Offset: 0x0028C2D1
	public DropDownItemBase<TData> GetDropDownItemObject(int index)
	{
		return this.Layout.GetLayoutItemByIndex(index);
	}

	// Token: 0x0600B50D RID: 46349 RVA: 0x0028E0DF File Offset: 0x0028C2DF
	public DropDownItemBase<TData>[] GetDropDownItemList()
	{
		return this.Layout.GetLayoutItemList().ToArray();
	}

	// Token: 0x0600B50E RID: 46350 RVA: 0x0028E0F4 File Offset: 0x0028C2F4
	public void RefreshAllDropDownItem()
	{
		TData data = this.GetDataFunction(this.DataList[this.SelectedIndex]);
		DropDownItemBase<TData> layoutItemByIndex = this.Layout.GetLayoutItemByIndex(this.SelectedIndex);
		this.TitleItem.ShowTemp(data, layoutItemByIndex);
		this.Layout.RebuildLayoutByDataNew<T>(this.DataList, null);
	}

	// Token: 0x040051A8 RID: 20904
	private UUIItem SourceItem;

	// Token: 0x040051A9 RID: 20905
	private Func<UUIItem, T, DropDownItemBase<TData>> CreateDropDownItem;

	// Token: 0x040051AA RID: 20906
	private Func<UUIItem, TitleItemBase<TData>> CreateTitleItem;

	// Token: 0x040051AB RID: 20907
	private GenericLayoutNew<DropDownItemBase<TData>> Layout;

	// Token: 0x040051AC RID: 20908
	private const float BOTTOM_OFFSET = 75f;

	// Token: 0x040051AD RID: 20909
	private IReadOnlyList<T> DataList;

	// Token: 0x040051AE RID: 20910
	private int SelectedIndex = -1;

	// Token: 0x040051AF RID: 20911
	private bool DoNotSelectCall;

	// Token: 0x040051B0 RID: 20912
	[Nullable(2)]
	private DynamicMaskButton MaskButton;

	// Token: 0x040051B1 RID: 20913
	private Action<int, T> OnSelectCall;

	// Token: 0x040051B2 RID: 20914
	[Nullable(2)]
	private Func<int, int, bool> OnChangeCall;

	// Token: 0x040051B3 RID: 20915
	[Nullable(2)]
	private Action OnOpenCall;

	// Token: 0x040051B4 RID: 20916
	private ECommonDropDownShowType ShowType = ECommonDropDownShowType.Auto;

	// Token: 0x040051B5 RID: 20917
	private bool CalculateDirty;

	// Token: 0x040051B6 RID: 20918
	private readonly Transform SelfToCanvasTrans = Transform.Create();

	// Token: 0x040051B7 RID: 20919
	private readonly Vector ButtonBottomToCanvasPos = Vector.Create();

	// Token: 0x040051B8 RID: 20920
	private readonly Vector ListBottomInCanvasSpace = Vector.Create();

	// Token: 0x040051B9 RID: 20921
	private Func<T, TData> GetDataFunction;

	// Token: 0x040051BA RID: 20922
	private TitleItemBase<TData> TitleItem;

	// Token: 0x040051BB RID: 20923
	private FTransformDouble OriginalWorldTrans;

	// Token: 0x02007E08 RID: 32264
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x040293F3 RID: 168947
		Button,
		// Token: 0x040293F4 RID: 168948
		ListRoot,
		// Token: 0x040293F5 RID: 168949
		Layout,
		// Token: 0x040293F6 RID: 168950
		LayoutItem,
		// Token: 0x040293F7 RID: 168951
		Title
	}
}
