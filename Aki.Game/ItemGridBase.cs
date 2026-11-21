using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000D6C RID: 3436
[NullableContext(1)]
[Nullable(0)]
public class ItemGridBase : UiPanelBase
{
	// Token: 0x06008D04 RID: 36100 RVA: 0x002AA79A File Offset: 0x002A899A
	[NullableContext(2)]
	public void Initialize(AActor rootActor = null)
	{
		if (rootActor != null)
		{
			base.CreateThenShowByActor(rootActor, null);
		}
	}

	// Token: 0x06008D05 RID: 36101 RVA: 0x002AA7A8 File Offset: 0x002A89A8
	protected override void OnStartImplement()
	{
		this.TopAdditionItem = this.OnSetTopAdditionItem();
		this.BottomAdditionItem = this.OnSetBottomAdditionItem();
		this.UnderTextAdditionItem = this.OnSetUnderTextAdditionItem();
		this.LongPressButton.Initialize(this.GetItemGridExtendToggle(), new Action<bool>(this.OnLongPressActivate), new Action(this.ExtendTogglePress), new Action(this.ExtendToggleRelease), null);
		this.LongPressButton.SetTickConditionDelegate(new Func<bool>(this.CanItemLongPressClick));
		this.AddEvents();
	}

	// Token: 0x06008D06 RID: 36102 RVA: 0x002AA834 File Offset: 0x002A8A34
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

	// Token: 0x06008D07 RID: 36103 RVA: 0x002AA8D4 File Offset: 0x002A8AD4
	[NullableContext(2)]
	protected virtual UUIItem OnSetUnderTextAdditionItem()
	{
		Log.Instance.Error(ELogModule.Inventory, ELogAuthor.WDX, "没有实现OnSetUnderTextAdditionItem", default(ReadOnlySpan<ValueTuple<string, object>>));
		return null;
	}

	// Token: 0x06008D08 RID: 36104 RVA: 0x002AA900 File Offset: 0x002A8B00
	[NullableContext(2)]
	protected virtual UUIItem OnSetBottomAdditionItem()
	{
		Log.Instance.Error(ELogModule.Inventory, ELogAuthor.YYZ, "没有实现OnSetBottomAdditionItem", default(ReadOnlySpan<ValueTuple<string, object>>));
		return null;
	}

	// Token: 0x06008D09 RID: 36105 RVA: 0x002AA92C File Offset: 0x002A8B2C
	[NullableContext(2)]
	protected virtual UUIItem OnSetTopAdditionItem()
	{
		Log.Instance.Error(ELogModule.Inventory, ELogAuthor.YYZ, "没有实现OnSetBottomAdditionItem", default(ReadOnlySpan<ValueTuple<string, object>>));
		return null;
	}

	// Token: 0x06008D0A RID: 36106 RVA: 0x002AA958 File Offset: 0x002A8B58
	[NullableContext(2)]
	public virtual UUIExtendToggle GetItemGridExtendToggle()
	{
		Log.Instance.Error(ELogModule.Inventory, ELogAuthor.YYZ, "没有实现GetItemGridExtendToggle", default(ReadOnlySpan<ValueTuple<string, object>>));
		return null;
	}

	// Token: 0x06008D0B RID: 36107 RVA: 0x002AA984 File Offset: 0x002A8B84
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

	// Token: 0x06008D0C RID: 36108 RVA: 0x002AAA2C File Offset: 0x002A8C2C
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

	// Token: 0x06008D0D RID: 36109 RVA: 0x002AAAC6 File Offset: 0x002A8CC6
	protected virtual void UnBindComponentEvents()
	{
	}

	// Token: 0x06008D0E RID: 36110 RVA: 0x002AAAC8 File Offset: 0x002A8CC8
	protected virtual void OnAddEvents()
	{
	}

	// Token: 0x06008D0F RID: 36111 RVA: 0x002AAACA File Offset: 0x002A8CCA
	protected virtual void OnRemoveEvents()
	{
	}

	// Token: 0x06008D10 RID: 36112 RVA: 0x002AAACC File Offset: 0x002A8CCC
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

	// Token: 0x06008D11 RID: 36113 RVA: 0x002AAB1D File Offset: 0x002A8D1D
	protected virtual void OnExtendTogglePress()
	{
	}

	// Token: 0x06008D12 RID: 36114 RVA: 0x002AAB20 File Offset: 0x002A8D20
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

	// Token: 0x06008D13 RID: 36115 RVA: 0x002AABB5 File Offset: 0x002A8DB5
	protected virtual void OnExtendToggleRelease()
	{
	}

	// Token: 0x06008D14 RID: 36116 RVA: 0x002AABB7 File Offset: 0x002A8DB7
	protected virtual void OnExtendToggleClicked()
	{
	}

	// Token: 0x06008D15 RID: 36117 RVA: 0x002AABBC File Offset: 0x002A8DBC
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

	// Token: 0x06008D16 RID: 36118 RVA: 0x002AAC04 File Offset: 0x002A8E04
	protected virtual void OnExtendToggleStateChanged(EToggleState state)
	{
	}

	// Token: 0x06008D17 RID: 36119 RVA: 0x002AAC06 File Offset: 0x002A8E06
	private bool CanExecuteChange()
	{
		if (this.OnCanExecuteChangeCallback != null)
		{
			return this.OnCanExecuteChangeCallback(this.Data, this.IsForceSelected, this.GetItemGridExtendToggle().GetToggleState());
		}
		return this.OnCanExecuteChange();
	}

	// Token: 0x06008D18 RID: 36120 RVA: 0x002AAC39 File Offset: 0x002A8E39
	protected virtual bool OnCanExecuteChange()
	{
		return true;
	}

	// Token: 0x06008D19 RID: 36121 RVA: 0x002AAC3C File Offset: 0x002A8E3C
	private void ExtendToggleHover()
	{
		this.IsHover = true;
	}

	// Token: 0x06008D1A RID: 36122 RVA: 0x002AAC45 File Offset: 0x002A8E45
	private void ExtendToggleUnHover()
	{
		this.IsHover = false;
	}

	// Token: 0x06008D1B RID: 36123 RVA: 0x002AAC50 File Offset: 0x002A8E50
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

	// Token: 0x06008D1C RID: 36124 RVA: 0x002AACAC File Offset: 0x002A8EAC
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

	// Token: 0x06008D1D RID: 36125 RVA: 0x002AACF0 File Offset: 0x002A8EF0
	public void BindOnExtendTogglePress(Action<MediumItemGridExtendCallback> onItemButtonPress)
	{
		this.OnExtendTogglePressCallback = onItemButtonPress;
	}

	// Token: 0x06008D1E RID: 36126 RVA: 0x002AACF9 File Offset: 0x002A8EF9
	public void UnBindOnExtendTogglePress()
	{
		this.OnExtendTogglePressCallback = null;
	}

	// Token: 0x06008D1F RID: 36127 RVA: 0x002AAD02 File Offset: 0x002A8F02
	public void BindOnExtendToggleRelease(Action<MediumItemGridExtendCallback> onItemButtonRelease)
	{
		this.OnExtendToggleReleaseCallback = onItemButtonRelease;
	}

	// Token: 0x06008D20 RID: 36128 RVA: 0x002AAD0B File Offset: 0x002A8F0B
	public void UnBindOnExtendToggleRelease()
	{
		this.OnExtendToggleReleaseCallback = null;
	}

	// Token: 0x06008D21 RID: 36129 RVA: 0x002AAD14 File Offset: 0x002A8F14
	public void BindOnExtendToggleStateChanged(Action<MediumItemGridExtendCallback> onItemButtonClicked)
	{
		this.OnExtendToggleStateChangedCallback = onItemButtonClicked;
	}

	// Token: 0x06008D22 RID: 36130 RVA: 0x002AAD1D File Offset: 0x002A8F1D
	public void UnBindOnExtendToggleStateChanged()
	{
		this.OnExtendToggleStateChangedCallback = null;
	}

	// Token: 0x06008D23 RID: 36131 RVA: 0x002AAD26 File Offset: 0x002A8F26
	public void BindOnExtendToggleClicked(Action<MediumItemGridExtendCallback> onExtendToggleClickedCallback)
	{
		this.OnExtendToggleClickedCallback = onExtendToggleClickedCallback;
	}

	// Token: 0x06008D24 RID: 36132 RVA: 0x002AAD2F File Offset: 0x002A8F2F
	public void UnBindOnExtendToggleClicked()
	{
		this.OnExtendToggleClickedCallback = null;
	}

	// Token: 0x06008D25 RID: 36133 RVA: 0x002AAD38 File Offset: 0x002A8F38
	public void BindOnCanExecuteChange([Nullable(new byte[]
	{
		1,
		2
	})] Func<object, bool, EToggleState, bool> onCanExecuteChange)
	{
		this.OnCanExecuteChangeCallback = onCanExecuteChange;
	}

	// Token: 0x06008D26 RID: 36134 RVA: 0x002AAD41 File Offset: 0x002A8F41
	public void UnBindOnCanExecuteChange()
	{
		this.OnCanExecuteChangeCallback = null;
	}

	// Token: 0x06008D27 RID: 36135 RVA: 0x002AAD4A File Offset: 0x002A8F4A
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

	// Token: 0x06008D28 RID: 36136 RVA: 0x002AAD71 File Offset: 0x002A8F71
	public void UnBindLongPress()
	{
		this.OnLongPressActiveCallback = null;
		this.CanItemLongPressCallback = null;
	}

	// Token: 0x06008D29 RID: 36137 RVA: 0x002AAD81 File Offset: 0x002A8F81
	protected void OnLongPressActivate(bool isShortPress)
	{
		if (this.OnLongPressActiveCallback != null)
		{
			this.OnLongPressActiveCallback(isShortPress, this, this.Data);
		}
	}

	// Token: 0x06008D2A RID: 36138 RVA: 0x002AAD9E File Offset: 0x002A8F9E
	protected bool CanItemLongPressClick()
	{
		return this.CanItemLongPressCallback == null || this.CanItemLongPressCallback(this, this.Data);
	}

	// Token: 0x06008D2B RID: 36139 RVA: 0x002AADBC File Offset: 0x002A8FBC
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

	// Token: 0x06008D2C RID: 36140 RVA: 0x002AAE2D File Offset: 0x002A902D
	private void HandleVisibleComponents(ItemGridComponent component)
	{
		if (component.IsShowOrShowing)
		{
			this.VisibleComponents.Add(component);
			return;
		}
		this.VisibleComponents.Remove(component);
	}

	// Token: 0x06008D2D RID: 36141 RVA: 0x002AAE52 File Offset: 0x002A9052
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

	// Token: 0x06008D2E RID: 36142 RVA: 0x002AAE80 File Offset: 0x002A9080
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

	// Token: 0x06008D2F RID: 36143 RVA: 0x002AAF58 File Offset: 0x002A9158
	private void OnComponentVisibleChanged(ItemGridComponent component, bool bVisible)
	{
		if (bVisible)
		{
			this.VisibleComponents.Add(component);
			return;
		}
		this.VisibleComponents.Remove(component);
	}

	// Token: 0x06008D30 RID: 36144 RVA: 0x002AAF78 File Offset: 0x002A9178
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

	// Token: 0x06008D31 RID: 36145 RVA: 0x002AAFD4 File Offset: 0x002A91D4
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

	// Token: 0x06008D32 RID: 36146 RVA: 0x002AB04C File Offset: 0x002A924C
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

	// Token: 0x06008D33 RID: 36147 RVA: 0x002AB0C8 File Offset: 0x002A92C8
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

	// Token: 0x06008D34 RID: 36148 RVA: 0x002AB115 File Offset: 0x002A9315
	protected void ClearComponentList()
	{
		this.UnderTextComponentList.Clear();
		this.BottomComponentList.Clear();
		this.TopComponentList.Clear();
	}

	// Token: 0x06008D35 RID: 36149 RVA: 0x002AB138 File Offset: 0x002A9338
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

	// Token: 0x06008D36 RID: 36150 RVA: 0x002AB1C8 File Offset: 0x002A93C8
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

	// Token: 0x06008D37 RID: 36151 RVA: 0x002AB1FC File Offset: 0x002A93FC
	[return: Nullable(2)]
	protected ItemGridComponent GetItemGridComponent(Type ctor)
	{
		ItemGridComponent result;
		this.ComponentMap.TryGetValue(ctor, out result);
		return result;
	}

	// Token: 0x06008D38 RID: 36152 RVA: 0x002AB21C File Offset: 0x002A941C
	protected void HiddenAllItemGridComponents()
	{
		foreach (ItemGridComponent itemGridComponent in this.ComponentMap.Values)
		{
			itemGridComponent.SetActive(false);
		}
	}

	// Token: 0x06008D39 RID: 36153 RVA: 0x002AB274 File Offset: 0x002A9474
	protected void SetItemGridComponentVisible(Type ctor, bool bVisible)
	{
		ItemGridComponent itemGridComponent;
		if (this.ComponentMap.TryGetValue(ctor, out itemGridComponent))
		{
			itemGridComponent.SetActive(bVisible);
		}
	}

	// Token: 0x06008D3A RID: 36154 RVA: 0x002AB298 File Offset: 0x002A9498
	protected void ClearItemGridComponents()
	{
		this.ComponentMap.Clear();
		this.LoadingComponentSet.Clear();
		this.ClearComponentList();
	}

	// Token: 0x06008D3B RID: 36155 RVA: 0x002AB2B6 File Offset: 0x002A94B6
	public void SetToggleInteractive(bool state)
	{
		this.GetItemGridExtendToggle().SetSelfInteractive(state);
	}

	// Token: 0x06008D3C RID: 36156 RVA: 0x002AB2C4 File Offset: 0x002A94C4
	public void SetUseFixedAsync(bool bUseFixedAsync)
	{
		this.UseFixedAsync = bUseFixedAsync;
	}

	// Token: 0x040054A8 RID: 21672
	[Nullable(2)]
	protected object Data;

	// Token: 0x040054A9 RID: 21673
	private readonly Dictionary<Type, ItemGridComponent> ComponentMap = new Dictionary<Type, ItemGridComponent>();

	// Token: 0x040054AA RID: 21674
	private readonly HashSet<ItemGridComponent> LoadingComponentSet = new HashSet<ItemGridComponent>();

	// Token: 0x040054AB RID: 21675
	private readonly HashSet<ItemGridComponent> VisibleComponents = new HashSet<ItemGridComponent>();

	// Token: 0x040054AC RID: 21676
	private readonly List<ItemGridComponent> UnderTextComponentList = new List<ItemGridComponent>();

	// Token: 0x040054AD RID: 21677
	private readonly List<ItemGridComponent> BottomComponentList = new List<ItemGridComponent>();

	// Token: 0x040054AE RID: 21678
	private readonly List<ItemGridComponent> TopComponentList = new List<ItemGridComponent>();

	// Token: 0x040054AF RID: 21679
	[Nullable(2)]
	private UUIItem TopAdditionItem;

	// Token: 0x040054B0 RID: 21680
	[Nullable(2)]
	private UUIItem BottomAdditionItem;

	// Token: 0x040054B1 RID: 21681
	[Nullable(2)]
	private UUIItem UnderTextAdditionItem;

	// Token: 0x040054B2 RID: 21682
	protected LongPressButtonItem LongPressButton = new LongPressButtonItem(null, null, null);

	// Token: 0x040054B3 RID: 21683
	public bool IsHover;

	// Token: 0x040054B4 RID: 21684
	protected bool IsSelected;

	// Token: 0x040054B5 RID: 21685
	protected bool IsForceSelected;

	// Token: 0x040054B6 RID: 21686
	private bool IsExtendToggleEnable = true;

	// Token: 0x040054B7 RID: 21687
	protected bool IsAnyComponentLoading;

	// Token: 0x040054B8 RID: 21688
	protected bool UseFixedAsync;

	// Token: 0x040054B9 RID: 21689
	[Nullable(2)]
	public Action AllComponentLoadedCallback;

	// Token: 0x040054BA RID: 21690
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MediumItemGridExtendCallback> OnExtendToggleStateChangedCallback;

	// Token: 0x040054BB RID: 21691
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MediumItemGridExtendCallback> OnExtendTogglePressCallback;

	// Token: 0x040054BC RID: 21692
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MediumItemGridExtendCallback> OnExtendToggleReleaseCallback;

	// Token: 0x040054BD RID: 21693
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<MediumItemGridExtendCallback> OnExtendToggleClickedCallback;

	// Token: 0x040054BE RID: 21694
	[Nullable(2)]
	private Func<object, bool, EToggleState, bool> OnCanExecuteChangeCallback;

	// Token: 0x040054BF RID: 21695
	[Nullable(new byte[]
	{
		2,
		1,
		2
	})]
	private Action<bool, ItemGridBase, object> OnLongPressActiveCallback;

	// Token: 0x040054C0 RID: 21696
	[Nullable(new byte[]
	{
		2,
		1,
		2
	})]
	private Func<ItemGridBase, object, bool> CanItemLongPressCallback;
}
