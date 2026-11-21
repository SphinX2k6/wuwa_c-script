using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000417 RID: 1047
[NullableContext(1)]
[Nullable(0)]
public class DrinksMenuPanel : UiPanelBase
{
	// Token: 0x06003857 RID: 14423 RVA: 0x00147D3C File Offset: 0x00145F3C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.OnClickedConfirm))
		};
	}

	// Token: 0x06003858 RID: 14424 RVA: 0x00147E40 File Offset: 0x00146040
	protected override void OnStart()
	{
		this.FlavorScroll = new GenericScrollViewNew<DrinksMenuFlavorItem, int>(base.GetScrollViewWithScrollbar(1), new Func<DrinksMenuFlavorItem>(this.CreateDrinksItem), null, false, null);
		this.OrnamentScroll = new GenericScrollViewNew<DrinksMenuOrnamentItem, int>(base.GetScrollViewWithScrollbar(4), new Func<DrinksMenuOrnamentItem>(this.CreateOrnamentItem), null, false, null);
		this.OrnamentList.Clear();
		foreach (DrinksOrnament drinksOrnament in DrinksConfig.Instance.GetAllOrnament())
		{
			this.OrnamentList.Add(drinksOrnament.Id);
		}
		this.OrnamentList.Sort((int a, int b) => a - b);
		this.OrnamentScroll.RefreshByData(this.OrnamentList, null, false);
	}

	// Token: 0x06003859 RID: 14425 RVA: 0x00147F28 File Offset: 0x00146128
	public void SetRaycastOnStepEnd()
	{
		UUIButtonComponent button = base.GetButton(7);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetRaycastTarget(false);
	}

	// Token: 0x0600385A RID: 14426 RVA: 0x00147F54 File Offset: 0x00146154
	public void UpdateOnStepStart()
	{
		UUIButtonComponent button = base.GetButton(7);
		if (button != null)
		{
			button.RootUIComp.Get().SetRaycastTarget(true);
		}
		EDrinksPlayStep curStep = DrinksModel.Instance.GetCurStep();
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.RootUIComp.Get().SetUIActive(curStep != EDrinksPlayStep.Ornament);
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar2 = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar2 != null)
		{
			scrollViewWithScrollbar2.RootUIComp.Get().SetUIActive(curStep == EDrinksPlayStep.Ornament);
		}
		DrinksStepConfig? stepConfig = DrinksConfig.Instance.GetStepConfig(curStep);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), stepConfig.Value.MenuButtonTxt, Array.Empty<object>());
		if (curStep == EDrinksPlayStep.Ornament)
		{
			this.CurrentSelectedOrnament = 0;
			GenericScrollViewNew<DrinksMenuOrnamentItem, int> ornamentScroll = this.OrnamentScroll;
			if (ornamentScroll != null)
			{
				ornamentScroll.RefreshByData(this.OrnamentList, delegate
				{
					GenericScrollViewNew<DrinksMenuOrnamentItem, int> ornamentScroll2 = this.OrnamentScroll;
					if (ornamentScroll2 == null)
					{
						return;
					}
					ornamentScroll2.ScrollToTop(0);
				}, true);
			}
		}
		else if (curStep == EDrinksPlayStep.Batching)
		{
			DrinksResultInfo currentPlayData = DrinksModel.Instance.GetCurrentPlayData();
			this.CurrentSelectedBatching.Clear();
			if (currentPlayData.Batching != null)
			{
				foreach (int item in currentPlayData.Batching)
				{
					this.CurrentSelectedBatching.Add(item);
				}
			}
			this.RefreshFlavor(curStep);
		}
		else
		{
			DrinksResultInfo currentPlayData2 = DrinksModel.Instance.GetCurrentPlayData();
			this.CurrentSelectedDrinks = ((curStep == EDrinksPlayStep.Drink1) ? currentPlayData2.DrinkBase[0] : currentPlayData2.DrinkBase[1]);
			this.RefreshFlavor(curStep);
		}
		if (curStep == EDrinksPlayStep.Batching)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), stepConfig.Value.MenuTitle, new <>z__ReadOnlySingleElementList<object>(this.CurrentSelectedBatching.Count));
			this.BatchingKey = stepConfig.Value.MenuTitle;
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), stepConfig.Value.MenuTitle, Array.Empty<object>());
		}
		bool flag = curStep == EDrinksPlayStep.Ornament || curStep == EDrinksPlayStep.Batching;
		bool flag2 = !flag && this.CurrentSelectedDrinks != 0;
		UUIButtonComponent button2 = base.GetButton(7);
		if (button2 != null)
		{
			button2.SetSelfInteractive(flag || flag2);
		}
		if (curStep == EDrinksPlayStep.Batching)
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "MakeDrinkBatchingShow");
		}
		if (curStep == EDrinksPlayStep.Ornament)
		{
			EventSystem.Instance.Emit(EEventName.NotifyGuideBreakFocus);
		}
	}

	// Token: 0x0600385B RID: 14427 RVA: 0x001481CC File Offset: 0x001463CC
	public void RefreshFlavor(EDrinksPlayStep step)
	{
		if (step == EDrinksPlayStep.Batching)
		{
			if (this.BatchingList.Count == 0)
			{
				foreach (DrinksBatching drinksBatching in DrinksConfig.Instance.GetAllBatching())
				{
					this.BatchingList.Add(drinksBatching.Id);
				}
			}
			this.FlavorScroll.RefreshByData(this.BatchingList, delegate
			{
				if (this.CurrentSelectedBatching.Count > 0)
				{
					int num = 0;
					using (HashSet<int>.Enumerator enumerator3 = this.CurrentSelectedBatching.GetEnumerator())
					{
						if (enumerator3.MoveNext())
						{
							num = enumerator3.Current;
						}
					}
					using (List<DrinksMenuFlavorItem>.Enumerator enumerator4 = this.FlavorScroll.GetScrollItemList().GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							DrinksMenuFlavorItem drinksMenuFlavorItem = enumerator4.Current;
							if (drinksMenuFlavorItem.Id == num)
							{
								GenericScrollViewNew<DrinksMenuFlavorItem, int> flavorScroll = this.FlavorScroll;
								if (flavorScroll == null)
								{
									break;
								}
								flavorScroll.ScrollTo(drinksMenuFlavorItem.GetRootItem(), false);
								break;
							}
						}
						goto IL_B2;
					}
				}
				GenericScrollViewNew<DrinksMenuFlavorItem, int> flavorScroll2 = this.FlavorScroll;
				if (flavorScroll2 != null)
				{
					flavorScroll2.ScrollToTop(0);
				}
				IL_B2:
				UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
			}, true);
			return;
		}
		IReadOnlyList<DrinksDrinkBase> allDrinkBase = DrinksConfig.Instance.GetAllDrinkBase();
		if (this.DrinksList.Count == 0)
		{
			foreach (DrinksDrinkBase drinksDrinkBase in allDrinkBase)
			{
				if (drinksDrinkBase.QTENum == 1)
				{
					this.DrinksList.Add(drinksDrinkBase.Id);
				}
			}
		}
		this.FlavorScroll.RefreshByData(this.DrinksList, delegate
		{
			if (this.CurrentSelectedDrinks != 0)
			{
				using (List<DrinksMenuFlavorItem>.Enumerator enumerator3 = this.FlavorScroll.GetScrollItemList().GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						DrinksMenuFlavorItem drinksMenuFlavorItem = enumerator3.Current;
						if (drinksMenuFlavorItem.Id == this.CurrentSelectedDrinks)
						{
							GenericScrollViewNew<DrinksMenuFlavorItem, int> flavorScroll = this.FlavorScroll;
							if (flavorScroll == null)
							{
								break;
							}
							flavorScroll.ScrollTo(drinksMenuFlavorItem.GetRootItem(), false);
							break;
						}
					}
					goto IL_7B;
				}
			}
			GenericScrollViewNew<DrinksMenuFlavorItem, int> flavorScroll2 = this.FlavorScroll;
			if (flavorScroll2 != null)
			{
				flavorScroll2.ScrollToTop(0);
			}
			IL_7B:
			UiNavigationNewController.Instance.MarkViewHandleRefreshNavigationDirty();
		}, true);
	}

	// Token: 0x0600385C RID: 14428 RVA: 0x001482DC File Offset: 0x001464DC
	private DrinksMenuFlavorItem CreateDrinksItem()
	{
		return new DrinksMenuFlavorItem
		{
			IsSelectOnCb = new Func<int, bool>(this.GetToggleStateSelected),
			IsEnableCb = new Func<int, bool>(this.GetIsToggleEnable),
			OnToggleStateChangeFunction = new Action<UUIExtendToggle, UUIButtonComponent, int, bool>(this.OnToggleStateChange)
		};
	}

	// Token: 0x0600385D RID: 14429 RVA: 0x00148319 File Offset: 0x00146519
	private DrinksMenuOrnamentItem CreateOrnamentItem()
	{
		return new DrinksMenuOrnamentItem
		{
			IsSelectOnCb = new Func<int, bool>(this.GetToggleStateSelected),
			OnToggleStateChangeFunction = new Action<int>(this.OnOrnamentToggleStateChange)
		};
	}

	// Token: 0x0600385E RID: 14430 RVA: 0x00148344 File Offset: 0x00146544
	private bool GetToggleStateSelected(int id)
	{
		EDrinksPlayStep curStep = DrinksModel.Instance.GetCurStep();
		if (curStep == EDrinksPlayStep.Drink1 || curStep == EDrinksPlayStep.Drink2)
		{
			return this.CurrentSelectedDrinks == id;
		}
		if (curStep == EDrinksPlayStep.Ornament)
		{
			return this.CurrentSelectedOrnament == id;
		}
		return this.CurrentSelectedBatching.Contains(id);
	}

	// Token: 0x0600385F RID: 14431 RVA: 0x00148387 File Offset: 0x00146587
	private bool GetIsToggleEnable(int id)
	{
		return DrinksModel.Instance.GetCurStep() != EDrinksPlayStep.Batching || this.CurrentSelectedBatching.Count < 2 || this.CurrentSelectedBatching.Contains(id);
	}

	// Token: 0x06003860 RID: 14432 RVA: 0x001483B4 File Offset: 0x001465B4
	private void OnToggleStateChange(UUIExtendToggle toggle, UUIButtonComponent reduceButton, int id, bool isSelected)
	{
		EDrinksPlayStep curStep = DrinksModel.Instance.GetCurStep();
		if (curStep == EDrinksPlayStep.Drink1 || curStep == EDrinksPlayStep.Drink2)
		{
			this.CurrentSelectedDrinks = (isSelected ? id : 0);
			UUIButtonComponent button = base.GetButton(7);
			if (button != null)
			{
				button.SetSelfInteractive(this.CurrentSelectedDrinks != 0);
			}
			DrinksModel.Instance.UpdateDrinkBase(this.CurrentSelectedDrinks, false);
			this.FlavorScroll.RefreshByData(this.DrinksList, null, false);
			return;
		}
		if (isSelected && this.CurrentSelectedBatching.Count >= 2)
		{
			toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			reduceButton.RootUIComp.Get().SetUIActive(false);
			return;
		}
		if (isSelected)
		{
			if (this.CurrentSelectedBatching.Count >= 2)
			{
				Log.Instance.Error(ELogModule.Drinks, ELogAuthor.WHJ, "CurrentSelectedBatching Size Error", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.CurrentSelectedBatching.Add(id);
		}
		else
		{
			if (!this.CurrentSelectedBatching.Contains(id))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Drinks;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "CurrentSelectedBatching includes Error";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.CurrentSelectedBatching.Remove(id);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.BatchingKey, new <>z__ReadOnlySingleElementList<object>(this.CurrentSelectedBatching.Count));
		this.FlavorScroll.RefreshByData(this.BatchingList, null, false);
		DrinksModel.Instance.UpdateBatching(this.CurrentSelectedBatching, false);
	}

	// Token: 0x06003861 RID: 14433 RVA: 0x0014852F File Offset: 0x0014672F
	private void OnOrnamentToggleStateChange(int id)
	{
		this.CurrentSelectedOrnament = id;
		GenericScrollViewNew<DrinksMenuOrnamentItem, int> ornamentScroll = this.OrnamentScroll;
		if (ornamentScroll != null)
		{
			ornamentScroll.RefreshByData(this.OrnamentList, null, false);
		}
		DrinksModel.Instance.UpdateOrnament(this.CurrentSelectedOrnament, false);
	}

	// Token: 0x06003862 RID: 14434 RVA: 0x00148564 File Offset: 0x00146764
	private void OnClickedConfirm()
	{
		DrinksModel instance = DrinksModel.Instance;
		EDrinksPlayStep? edrinksPlayStep = (instance != null) ? new EDrinksPlayStep?(instance.GetCurStep()) : null;
		if (edrinksPlayStep.GetValueOrDefault() == EDrinksPlayStep.Ornament)
		{
			DrinksModel.Instance.UpdateOrnament(this.CurrentSelectedOrnament, true);
			return;
		}
		if (edrinksPlayStep.GetValueOrDefault() == EDrinksPlayStep.Batching)
		{
			if (this.CurrentSelectedBatching.Count > 2)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.Drinks;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "Batching Select Size Error";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("set", this.CurrentSelectedBatching);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.CurrentSelectedBatching.Count > 0)
			{
				UiLayer.Instance.SetShowMaskLayer(EUiViewName.DrinksGameplayView, true);
			}
			DrinksModel.Instance.UpdateBatching(this.CurrentSelectedBatching, true);
			return;
		}
		else
		{
			if (this.CurrentSelectedDrinks == 0)
			{
				return;
			}
			UiLayer.Instance.SetShowMaskLayer(EUiViewName.DrinksGameplayView, true);
			DrinksModel.Instance.UpdateDrinkBase(this.CurrentSelectedDrinks, true);
			return;
		}
	}

	// Token: 0x06003863 RID: 14435 RVA: 0x00148658 File Offset: 0x00146858
	[NullableContext(2)]
	public UUIItem GuideGetOrnamentItem(int id)
	{
		int index = this.OrnamentList.IndexOf(id);
		GenericScrollViewNew<DrinksMenuOrnamentItem, int> ornamentScroll = this.OrnamentScroll;
		UUIItem uuiitem = (ornamentScroll != null) ? ornamentScroll.GetItemByIndex(index) : null;
		if (uuiitem == null)
		{
			return null;
		}
		GenericScrollViewNew<DrinksMenuOrnamentItem, int> ornamentScroll2 = this.OrnamentScroll;
		if (ornamentScroll2 != null)
		{
			ornamentScroll2.LateScrollTo(uuiitem, null, false);
		}
		return uuiitem;
	}

	// Token: 0x04002E53 RID: 11859
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollViewNew<DrinksMenuFlavorItem, int> FlavorScroll;

	// Token: 0x04002E54 RID: 11860
	protected int CurrentSelectedDrinks;

	// Token: 0x04002E55 RID: 11861
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollViewNew<DrinksMenuOrnamentItem, int> OrnamentScroll;

	// Token: 0x04002E56 RID: 11862
	protected HashSet<int> CurrentSelectedBatching = new HashSet<int>();

	// Token: 0x04002E57 RID: 11863
	protected int CurrentSelectedOrnament;

	// Token: 0x04002E58 RID: 11864
	protected List<int> OrnamentList = new List<int>();

	// Token: 0x04002E59 RID: 11865
	protected List<int> DrinksList = new List<int>();

	// Token: 0x04002E5A RID: 11866
	protected List<int> BatchingList = new List<int>();

	// Token: 0x04002E5B RID: 11867
	protected string BatchingKey = "";

	// Token: 0x02006742 RID: 26434
	[NullableContext(0)]
	private static class EDefine
	{
		// Token: 0x0402219F RID: 139679
		public const int Title = 0;

		// Token: 0x040221A0 RID: 139680
		public const int ScrollDrink = 1;

		// Token: 0x040221A1 RID: 139681
		public const int ContentDrink = 2;

		// Token: 0x040221A2 RID: 139682
		public const int ItemDrink = 3;

		// Token: 0x040221A3 RID: 139683
		public const int ScrollBatching = 4;

		// Token: 0x040221A4 RID: 139684
		public const int ContentBatching = 5;

		// Token: 0x040221A5 RID: 139685
		public const int ItemBatching = 6;

		// Token: 0x040221A6 RID: 139686
		public const int BtnConfirm = 7;

		// Token: 0x040221A7 RID: 139687
		public const int TxtConfirm = 8;
	}
}
