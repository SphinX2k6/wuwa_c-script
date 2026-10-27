using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020018B3 RID: 6323
[NullableContext(1)]
[Nullable(0)]
public class ItemGridBase : UiPanelBase
{
	// Token: 0x0600B91B RID: 47387 RVA: 0x002A0044 File Offset: 0x0029E244
	[NullableContext(2)]
	public void Initialize(AActor rootActor = null)
	{
		if (rootActor != null)
		{
			base.CreateThenShowByActor(rootActor, null);
		}
	}

	// Token: 0x0600B91C RID: 47388 RVA: 0x002A0054 File Offset: 0x0029E254
	protected override void OnStartImplement()
	{
		this.TopAdditionItem = this.OnSetTopAdditionItem();
		this.BottomAdditionItem = this.OnSetBottomAdditionItem();
		this.UnderTextAdditionItem = this.OnSetUnderTextAdditionItem();
		this.LongPressButton.Initialize(this.GetItemGridExtendToggle(), new Action<bool>(this.OnLongPressActivate), new Action(this.ExtendTogglePress), new Action(this.ExtendToggleRelease), null);
		this.LongPressButton.SetTickConditionDelegate(new Func<bool>(this.CanItemLongPressClick));
		this.AddEvents();
	}

	// Token: 0x0600B91D RID: 47389 RVA: 0x002A00E0 File Offset: 0x0029E2E0
	protected override void OnBeforeDestroyImplement()
	{
		this.TopAdditionItem = null;
		this.BottomAdditionItem = null;
		this.UnderTextAdditionItem = null;
		this.UnderTextComponentList.Clear();
		this.BottomComponentList.Clear();
		this.TopComponentList.Clear();
		LongPressButtonItem longPressButton = this.LongPressButton;
		if (longPressButton != null)
		{
			longPressButton.Clear();
		}
		this.LongPressButton = null;
		this.IsAnyComponentLoading = false;
		this.UnBindOnExtendTogglePress();
		this.UnBindOnExtendToggleRelease();
		this.UnBindOnExtendToggleStateChanged();
		this.UnBindOnExtendToggleClicked();
		this.UnBindOnCanExecuteChange();
		this.UnBindLongPress();
		this.UnBindComponentEvents();
		this.ClearVisibleComponent();
		this.ClearItemGridComponents();
		this.RemoveEvents();
	}

	// Token: 0x0600B91E RID: 47390 RVA: 0x002A0180 File Offset: 0x0029E380
	[NullableContext(2)]
	protected virtual UUIItem OnSetUnderTextAdditionItem()
	{
		Log.Instance.Error(ELogModule.Inventory, ELogAuthor.WDX, "没有实现OnSetUnderTextAdditionItem", default(ReadOnlySpan<ValueTuple<string, object>>));
		return null;
	}

	// Token: 0x0600B91F RID: 47391 RVA: 0x002A01AC File Offset: 0x0029E3AC
	[NullableContext(2)]
	protected virtual UUIItem OnSetBottomAdditionItem()
	{
		Log.Instance.Error(ELogModule.Inventory, ELogAuthor.YYZ, "没有实现OnSetBottomAdditionItem", default(ReadOnlySpan<ValueTuple<string, object>>));
		return null;
	}

	// Token: 0x0600B920 RID: 47392 RVA: 0x002A01D8 File Offset: 0x0029E3D8
	[NullableContext(2)]
	protected virtual UUIItem OnSetTopAdditionItem()
	{
		Log.Instance.Error(ELogModule.Inventory, ELogAuthor.YYZ, "没有实现OnSetBottomAdditionItem", default(ReadOnlySpan<ValueTuple<string, object>>));
		return null;
	}

	// Token: 0x0600B921 RID: 47393 RVA: 0x002A0204 File Offset: 0x0029E404
	[NullableContext(2)]
	public virtual UUIExtendToggle GetItemGridExtendToggle()
	{
		Log.Instance.Error(ELogModule.Inventory, ELogAuthor.YYZ, "没有实现GetItemGridExtendToggle", default(ReadOnlySpan<ValueTuple<string, object>>));
		return null;
	}

	// Token: 0x0600B922 RID: 47394 RVA: 0x002A0230 File Offset: 0x0029E430
	protected void AddEvents()
	{
		UUIExtendToggle itemGridExtendToggle = this.GetItemGridExtendToggle();
		if (itemGridExtendToggle == null)
		{
			Log.Instance.Error(ELogModule.Inventory, ELogAuthor.LRX, base.GetType().Name + "::GetItemGridExtendToggle return empty UUIExtendToggle!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		itemGridExtendToggle.OnStateChange.Add(new Action<EToggleState>(this.ExtendToggleStateChanged));
		itemGridExtendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		itemGridExtendToggle.OnHover.Add(new Action(this.ExtendToggleHover));
		itemGridExtendToggle.OnUnHover.Add(new Action(this.ExtendToggleUnHover));
		this.OnAddEvents();
	}

	// Token: 0x0600B923 RID: 47395 RVA: 0x002A02D8 File Offset: 0x0029E4D8
	protected void RemoveEvents()
	{
		UUIExtendToggle itemGridExtendToggle = this.GetItemGridExtendToggle();
		if (itemGridExtendToggle == null)
		{
			Log.Instance.Error(ELogModule.Inventory, ELogAuthor.LRX, base.GetType().Name + "::GetItemGridExtendToggle return empty UUIExtendToggle!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		itemGridExtendToggle.OnStateChange.Remove(new Action<EToggleState>(this.ExtendToggleStateChanged));
		itemGridExtendToggle.CanExecuteChange.Unbind();
		itemGridExtendToggle.OnHover.Remove(new Action(this.ExtendToggleHover));
		itemGridExtendToggle.OnUnHover.Remove(new Action(this.ExtendToggleUnHover));
		this.OnRemoveEvents();
	}

	// Token: 0x0600B924 RID: 47396 RVA: 0x002A0372 File Offset: 0x0029E572
	protected virtual void UnBindComponentEvents()
	{
	}

	// Token: 0x0600B925 RID: 47397 RVA: 0x002A0374 File Offset: 0x0029E574
	protected virtual void OnAddEvents()
	{
	}

	// Token: 0x0600B926 RID: 47398 RVA: 0x002A0376 File Offset: 0x0029E576
	protected virtual void OnRemoveEvents()
	{
	}

	// Token: 0x0600B927 RID: 47399 RVA: 0x002A0378 File Offset: 0x0029E578
	private void ExtendTogglePress()
	{
		this.OnExtendTogglePress();
		if (this.OnExtendTogglePressCallback != null)
		{
			MediumItemGridExtendCallback obj = new MediumItemGridExtendCallback
			{
				MediumItemGrid = this,
				State = this.GetItemGridExtendToggle().GetToggleState(),
				Data = this.Data
			};
			this.OnExtendTogglePressCallback(obj);
		}
	}

	// Token: 0x0600B928 RID: 47400 RVA: 0x002A03C9 File Offset: 0x0029E5C9
	protected virtual void OnExtendTogglePress()
	{
	}

	// Token: 0x0600B929 RID: 47401 RVA: 0x002A03CC File Offset: 0x0029E5CC
	private void ExtendToggleRelease()
	{
		this.OnExtendToggleRelease();
		if (this.OnExtendToggleReleaseCallback != null)
		{
			MediumItemGridExtendCallback obj = new MediumItemGridExtendCallback
			{
				MediumItemGrid = this,
				State = this.GetItemGridExtendToggle().GetToggleState(),
				Data = this.Data
			};
			this.OnExtendToggleReleaseCallback(obj);
		}
		this.OnExtendToggleClicked();
		if (this.OnExtendToggleClickedCallback != null)
		{
			MediumItemGridExtendCallback obj2 = new MediumItemGridExtendCallback
			{
				MediumItemGrid = this,
				State = this.GetItemGridExtendToggle().GetToggleState(),
				Data = this.Data
			};
			this.OnExtendToggleClickedCallback(obj2);
		}
	}

	// Token: 0x0600B92A RID: 47402 RVA: 0x002A0461 File Offset: 0x0029E661
	protected virtual void OnExtendToggleRelease()
	{
	}

	// Token: 0x0600B92B RID: 47403 RVA: 0x002A0463 File Offset: 0x0029E663
	protected virtual void OnExtendToggleClicked()
	{
	}

	// Token: 0x0600B92C RID: 47404 RVA: 0x002A0468 File Offset: 0x0029E668
	private void ExtendToggleStateChanged(EToggleState state)
	{
		this.OnExtendToggleStateChanged(state);
		if (this.OnExtendToggleStateChangedCallback != null)
		{
			MediumItemGridExtendCallback obj = new MediumItemGridExtendCallback
			{
				MediumItemGrid = this,
				State = state,
				Data = this.Data
			};
			this.OnExtendToggleStateChangedCallback(obj);
		}
	}

	// Token: 0x0600B92D RID: 47405 RVA: 0x002A04B0 File Offset: 0x0029E6B0
	protected virtual void OnExtendToggleStateChanged(EToggleState state)
	{
	}

	// Token: 0x0600B92E RID: 47406 RVA: 0x002A04B2 File Offset: 0x0029E6B2
	private bool CanExecuteChange()
	{
		if (this.OnCanExecuteChangeCallback != null)
		{
			return this.OnCanExecuteChangeCallback(this.Data, this.IsForceSelected, this.GetItemGridExtendToggle().GetToggleState());
		}
		return this.OnCanExecuteChange();
	}

	// Token: 0x0600B92F RID: 47407 RVA: 0x002A04E5 File Offset: 0x0029E6E5
	protected virtual bool OnCanExecuteChange()
	{
		return true;
	}

	// Token: 0x0600B930 RID: 47408 RVA: 0x002A04E8 File Offset: 0x0029E6E8
	private void ExtendToggleHover()
	{
		this.IsHover = true;
	}

	// Token: 0x0600B931 RID: 47409 RVA: 0x002A04F1 File Offset: 0x0029E6F1
	private void ExtendToggleUnHover()
	{
		this.IsHover = false;
	}

	// Token: 0x0600B932 RID: 47410 RVA: 0x002A04FC File Offset: 0x0029E6FC
	public virtual void SetSelected(bool bSelected, bool bForce = false)
	{
		UUIExtendToggle itemGridExtendToggle = this.GetItemGridExtendToggle();
		if (bSelected)
		{
			if (bForce)
			{
				itemGridExtendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
			}
			else
			{
				itemGridExtendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
		}
		else if (bForce)
		{
			itemGridExtendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		else
		{
			itemGridExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.IsSelected = bSelected;
		this.IsForceSelected = bForce;
	}

	// Token: 0x0600B933 RID: 47411 RVA: 0x002A0558 File Offset: 0x0029E758
	public void SetExtendToggleEnable(bool bEnable, bool bForce = false)
	{
		if (this.IsExtendToggleEnable == bEnable && !bForce)
		{
			return;
		}
		this.IsExtendToggleEnable = bEnable;
		UUIExtendToggle itemGridExtendToggle = this.GetItemGridExtendToggle();
		if (bEnable)
		{
			this.SetSelected(this.IsSelected, bForce);
			return;
		}
		itemGridExtendToggle.SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
	}

	// Token: 0x0600B934 RID: 47412 RVA: 0x002A059C File Offset: 0x0029E79C
	public void BindOnExtendTogglePress(Action<MediumItemGridExtendCallback> onItemButtonPress)
	{
		this.OnExtendTogglePressCallback = onItemButtonPress;
	}

	// Token: 0x0600B935 RID: 47413 RVA: 0x002A05A5 File Offset: 0x0029E7A5
	public void UnBindOnExtendTogglePress()
	{
		this.OnExtendTogglePressCallback = null;
	}

	// Token: 0x0600B936 RID: 47414 RVA: 0x002A05AE File Offset: 0x0029E7AE
	public void BindOnExtendToggleRelease(Action<MediumItemGridExtendCallback> onItemButtonRelease)
	{
		this.OnExtendToggleReleaseCallback = onItemButtonRelease;
	}

	// Token: 0x0600B937 RID: 47415 RVA: 0x002A05B7 File Offset: 0x0029E7B7
	public void UnBindOnExtendToggleRelease()
	{
		this.OnExtendToggleReleaseCallback = null;
	}

	// Token: 0x0600B938 RID: 47416 RVA: 0x002A05C0 File Offset: 0x0029E7C0
	public void BindOnExtendToggleStateChanged(Action<MediumItemGridExtendCallback> onItemButtonClicked)
	{
		this.OnExtendToggleStateChangedCallback = onItemButtonClicked;
	}

	// Token: 0x0600B939 RID: 47417 RVA: 0x002A05C9 File Offset: 0x0029E7C9
	public void UnBindOnExtendToggleStateChanged()
	{
		this.OnExtendToggleStateChangedCallback = null;
	}

	// Token: 0x0600B93A RID: 47418 RVA: 0x002A05D2 File Offset: 0x0029E7D2
	public void BindOnExtendToggleClicked(Action<MediumItemGridExtendCallback> onExtendToggleClickedCallback)
	{
		this.OnExtendToggleClickedCallback = onExtendToggleClickedCallback;
	}

	// Token: 0x0600B93B RID: 47419 RVA: 0x002A05DB File Offset: 0x0029E7DB
	public void UnBindOnExtendToggleClicked()
	{
		this.OnExtendToggleClickedCallback = null;
	}

	// Token: 0x0600B93C RID: 47420 RVA: 0x002A05E4 File Offset: 0x0029E7E4
	public void BindOnCanExecuteChange([Nullable(new byte[]
	{
		1,
		2
	})] Func<object, bool, EToggleState, bool> onCanExecuteChange)
	{
		this.OnCanExecuteChangeCallback = onCanExecuteChange;
	}

	// Token: 0x0600B93D RID: 47421 RVA: 0x002A05ED File Offset: 0x0029E7ED
	public void UnBindOnCanExecuteChange()
	{
		this.OnCanExecuteChangeCallback = null;
	}

	// Token: 0x0600B93E RID: 47422 RVA: 0x002A05F6 File Offset: 0x0029E7F6
	public void BindLongPress(LongPressButtonItem.ELongPressConfigId longPressConfigId, [Nullable(new byte[]
	{
		1,
		1,
		2
	})] Action<bool, ItemGridBase, object> callback, [Nullable(new byte[]
	{
		2,
		1,
		2
	})] Func<ItemGridBase, object, bool> canLongPressCallBack = null)
	{
		this.LongPressButton.Deactivate();
		this.LongPressButton.Activate(longPressConfigId);
		this.OnLongPressActiveCallback = callback;
		this.CanItemLongPressCallback = canLongPressCallBack;
	}

	// Token: 0x0600B93F RID: 47423 RVA: 0x002A061D File Offset: 0x0029E81D
	public void UnBindLongPress()
	{
		this.OnLongPressActiveCallback = null;
		this.CanItemLongPressCallback = null;
	}

	// Token: 0x0600B940 RID: 47424 RVA: 0x002A062D File Offset: 0x0029E82D
	protected void OnLongPressActivate(bool isShortPress)
	{
		if (this.OnLongPressActiveCallback != null)
		{
			this.OnLongPressActiveCallback(isShortPress, this, this.Data);
		}
	}

	// Token: 0x0600B941 RID: 47425 RVA: 0x002A064A File Offset: 0x0029E84A
	protected bool CanItemLongPressClick()
	{
		return this.CanItemLongPressCallback == null || this.CanItemLongPressCallback(this, this.Data);
	}

	// Token: 0x0600B942 RID: 47426 RVA: 0x002A0668 File Offset: 0x0029E868
	[NullableContext(2)]
	protected ItemGridComponent RefreshComponent([Nullable(1)] Type gridClass, bool? bNewIfNull, object @params = null)
	{
		ItemGridComponent itemGridComponent = this.GetItemGridComponent(gridClass);
		if (@params == null)
		{
			if (itemGridComponent != null)
			{
				itemGridComponent.SetActive(false);
			}
			if (itemGridComponent != null)
			{
				this.VisibleComponents.Remove(itemGridComponent);
			}
			return itemGridComponent;
		}
		if (itemGridComponent == null && bNewIfNull.GetValueOrDefault())
		{
			itemGridComponent = this.AddItemGridComponent(gridClass);
		}
		if (itemGridComponent != null)
		{
			itemGridComponent.Refresh(@params);
			this.AddToComponentList(itemGridComponent);
			if (!this.UseFixedAsync && !itemGridComponent.IsCreating)
			{
				this.HandleVisibleComponents(itemGridComponent);
			}
		}
		return itemGridComponent;
	}

	// Token: 0x0600B943 RID: 47427 RVA: 0x002A06D9 File Offset: 0x0029E8D9
	private void HandleVisibleComponents(ItemGridComponent component)
	{
		if (component.IsShowOrShowing)
		{
			this.VisibleComponents.Add(component);
			return;
		}
		this.VisibleComponents.Remove(component);
	}

	// Token: 0x0600B944 RID: 47428 RVA: 0x002A06FE File Offset: 0x0029E8FE
	protected void SetComponentVisible(ItemGridComponent component, bool bVisible)
	{
		if (component == null)
		{
			return;
		}
		if (bVisible)
		{
			this.VisibleComponents.Add(component);
		}
		else
		{
			this.VisibleComponents.Remove(component);
		}
		component.SetActive(bVisible);
	}

	// Token: 0x0600B945 RID: 47429 RVA: 0x002A072C File Offset: 0x0029E92C
	private ItemGridComponent AddItemGridComponent(Type gridClass)
	{
		ItemGridComponent itemGridComponent;
		if (this.ComponentMap.TryGetValue(gridClass, out itemGridComponent))
		{
			return itemGridComponent;
		}
		itemGridComponent = (ItemGridComponent)Activator.CreateInstance(gridClass);
		switch (itemGridComponent.GetLayoutLevel())
		{
		case EItemGridComponentLayoutLevel.Top:
			itemGridComponent.Initialize(this.TopAdditionItem, this.UseFixedAsync);
			break;
		case EItemGridComponentLayoutLevel.Bottom:
			itemGridComponent.Initialize(this.BottomAdditionItem, this.UseFixedAsync);
			break;
		case EItemGridComponentLayoutLevel.UnderText:
			itemGridComponent.Initialize(this.UnderTextAdditionItem, this.UseFixedAsync);
			break;
		}
		if (this.UseFixedAsync)
		{
			itemGridComponent.OnComponentVisibleChanged = new Action<ItemGridComponent, bool>(this.OnComponentVisibleChanged);
		}
		this.ComponentMap[gridClass] = itemGridComponent;
		this.LoadingComponentSet.Add(itemGridComponent);
		this.IsAnyComponentLoading = true;
		itemGridComponent.Load().ContinueWith(new Action<ItemGridComponent>(this.OnLoadComponentCompleted)).Forget();
		return itemGridComponent;
	}

	// Token: 0x0600B946 RID: 47430 RVA: 0x002A0804 File Offset: 0x0029EA04
	private void OnComponentVisibleChanged(ItemGridComponent component, bool bVisible)
	{
		if (bVisible)
		{
			this.VisibleComponents.Add(component);
			return;
		}
		this.VisibleComponents.Remove(component);
	}

	// Token: 0x0600B947 RID: 47431 RVA: 0x002A0824 File Offset: 0x0029EA24
	[NullableContext(2)]
	private void OnLoadComponentCompleted(ItemGridComponent component)
	{
		if (!this.UseFixedAsync)
		{
			this.HandleVisibleComponents(component);
		}
		this.LoadingComponentSet.Remove(component);
		if (this.LoadingComponentSet.Count > 0)
		{
			return;
		}
		this.IsAnyComponentLoading = false;
		this.RefreshComponentVisible();
		this.RefreshComponentHierarchyIndex();
		Action allComponentLoadedCallback = this.AllComponentLoadedCallback;
		if (allComponentLoadedCallback == null)
		{
			return;
		}
		allComponentLoadedCallback();
	}

	// Token: 0x0600B948 RID: 47432 RVA: 0x002A0880 File Offset: 0x0029EA80
	protected void RefreshComponentVisible()
	{
		if (this.UseFixedAsync && this.IsAnyComponentLoading)
		{
			return;
		}
		foreach (ItemGridComponent itemGridComponent in this.ComponentMap.Values)
		{
			if (!this.VisibleComponents.Contains(itemGridComponent))
			{
				itemGridComponent.SetActive(false);
			}
		}
	}

	// Token: 0x0600B949 RID: 47433 RVA: 0x002A08F8 File Offset: 0x0029EAF8
	protected void ClearVisibleComponent()
	{
		if (this.UseFixedAsync && this.IsAnyComponentLoading)
		{
			foreach (ItemGridComponent itemGridComponent in this.ComponentMap.Values)
			{
				if (itemGridComponent.InAsyncLoading())
				{
					itemGridComponent.Refresh(null);
				}
			}
		}
		this.VisibleComponents.Clear();
	}

	// Token: 0x0600B94A RID: 47434 RVA: 0x002A0974 File Offset: 0x0029EB74
	private void AddToComponentList(ItemGridComponent component)
	{
		switch (component.GetLayoutLevel())
		{
		case EItemGridComponentLayoutLevel.Top:
			this.TopComponentList.Add(component);
			return;
		case EItemGridComponentLayoutLevel.Bottom:
			this.BottomComponentList.Add(component);
			return;
		case EItemGridComponentLayoutLevel.UnderText:
			this.UnderTextComponentList.Add(component);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600B94B RID: 47435 RVA: 0x002A09C1 File Offset: 0x0029EBC1
	protected void ClearComponentList()
	{
		this.UnderTextComponentList.Clear();
		this.BottomComponentList.Clear();
		this.TopComponentList.Clear();
	}

	// Token: 0x0600B94C RID: 47436 RVA: 0x002A09E4 File Offset: 0x0029EBE4
	protected void RefreshComponentHierarchyIndex()
	{
		if (this.IsAnyComponentLoading)
		{
			return;
		}
		for (int i = 0; i < this.TopComponentList.Count; i++)
		{
			this.TopComponentList[i].SetHierarchyIndex(i);
		}
		for (int j = 0; j < this.BottomComponentList.Count; j++)
		{
			this.BottomComponentList[j].SetHierarchyIndex(j);
		}
		for (int k = 0; k < this.UnderTextComponentList.Count; k++)
		{
			this.UnderTextComponentList[k].SetHierarchyIndex(k);
		}
	}

	// Token: 0x0600B94D RID: 47437 RVA: 0x002A0A74 File Offset: 0x0029EC74
	[return: Nullable(2)]
	protected T GetItemGridComponent<[Nullable(0)] T>(Type ctor) where T : ItemGridComponent
	{
		ItemGridComponent itemGridComponent;
		if (this.ComponentMap.TryGetValue(ctor, out itemGridComponent))
		{
			return itemGridComponent as T;
		}
		return default(T);
	}

	// Token: 0x0600B94E RID: 47438 RVA: 0x002A0AA8 File Offset: 0x0029ECA8
	[return: Nullable(2)]
	protected ItemGridComponent GetItemGridComponent(Type ctor)
	{
		ItemGridComponent result;
		this.ComponentMap.TryGetValue(ctor, out result);
		return result;
	}

	// Token: 0x0600B94F RID: 47439 RVA: 0x002A0AC8 File Offset: 0x0029ECC8
	protected void HiddenAllItemGridComponents()
	{
		foreach (ItemGridComponent itemGridComponent in this.ComponentMap.Values)
		{
			itemGridComponent.SetActive(false);
		}
	}

	// Token: 0x0600B950 RID: 47440 RVA: 0x002A0B20 File Offset: 0x0029ED20
	protected void SetItemGridComponentVisible(Type ctor, bool bVisible)
	{
		ItemGridComponent itemGridComponent;
		if (this.ComponentMap.TryGetValue(ctor, out itemGridComponent))
		{
			itemGridComponent.SetActive(bVisible);
		}
	}

	// Token: 0x0600B951 RID: 47441 RVA: 0x002A0B44 File Offset: 0x0029ED44
	protected void ClearItemGridComponents()
	{
		this.ComponentMap.Clear();
		this.LoadingComponentSet.Clear();
		this.ClearComponentList();
	}

	// Token: 0x0600B952 RID: 47442 RVA: 0x002A0B62 File Offset: 0x0029ED62
	public void SetToggleInteractive(bool state)
	{
		this.GetItemGridExtendToggle().SetSelfInteractive(state);
	}

	// Token: 0x0600B953 RID: 47443 RVA: 0x002A0B70 File Offset: 0x0029ED70
	public void SetUseFixedAsync(bool bUseFixedAsync)
	{
		this.UseFixedAsync = bUseFixedAsync;
	}

	// Token: 0x040053FD RID: 21501
	[Nullable(2)]
	protected object Data;

	// Token: 0x040053FE RID: 21502
	private readonly Dictionary<Type, ItemGridComponent> ComponentMap = new Dictionary<Type, ItemGridComponent>();

	// Token: 0x040053FF RID: 21503
	private readonly HashSet<ItemGridComponent> LoadingComponentSet = new HashSet<ItemGridComponent>();

	// Token: 0x04005400 RID: 21504
	private readonly HashSet<ItemGridComponent> VisibleComponents = new HashSet<ItemGridComponent>();

	// Token: 0x04005401 RID: 21505
	private readonly List<ItemGridComponent> UnderTextComponentList = new List<ItemGridComponent>();

	// Token: 0x04005402 RID: 21506
	private readonly List<ItemGridComponent> BottomComponentList = new List<ItemGridComponent>();

	// Token: 0x04005403 RID: 21507
	private readonly List<ItemGridComponent> TopComponentList = new List<ItemGridComponent>();

	// Token: 0x04005404 RID: 21508
	[Nullable(2)]
	private UUIItem TopAdditionItem;

	// Token: 0x04005405 RID: 21509
	[Nullable(2)]
	private UUIItem BottomAdditionItem;

	// Token: 0x04005406 RID: 21510
	[Nullable(2)]
	private UUIItem UnderTextAdditionItem;

	// Token: 0x04005407 RID: 21511
	protected LongPressButtonItem LongPressButton = new LongPressButtonItem(null, null, null);

	// Token: 0x04005408 RID: 21512
	public bool IsHover;

	// Token: 0x04005409 RID: 21513
	protected bool IsSelected;

	// Token: 0x0400540A RID: 21514
	protected bool IsForceSelected;

	// Token: 0x0400540B RID: 21515
	private bool IsExtendToggleEnable = true;

	// Token: 0x0400540C RID: 21516
	protected bool IsAnyComponentLoading;

	// Token: 0x0400540D RID: 21517
	protected bool UseFixedAsync;

	// Token: 0x0400540E RID: 21518
	[Nullable(2)]
	public Action AllComponentLoadedCallback;

	// Token: 0x0400540F RID: 21519
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MediumItemGridExtendCallback> OnExtendToggleStateChangedCallback;

	// Token: 0x04005410 RID: 21520
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MediumItemGridExtendCallback> OnExtendTogglePressCallback;

	// Token: 0x04005411 RID: 21521
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MediumItemGridExtendCallback> OnExtendToggleReleaseCallback;

	// Token: 0x04005412 RID: 21522
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MediumItemGridExtendCallback> OnExtendToggleClickedCallback;

	// Token: 0x04005413 RID: 21523
	[Nullable(2)]
	private Func<object, bool, EToggleState, bool> OnCanExecuteChangeCallback;

	// Token: 0x04005414 RID: 21524
	[Nullable(new byte[]
	{
		2,
		1,
		2
	})]
	private Action<bool, ItemGridBase, object> OnLongPressActiveCallback;

	// Token: 0x04005415 RID: 21525
	[Nullable(new byte[]
	{
		2,
		1,
		2
	})]
	private Func<ItemGridBase, object, bool> CanItemLongPressCallback;
}
