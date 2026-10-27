using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F62 RID: 3938
[NullableContext(1)]
[Nullable(0)]
public class DrinksMenuPanel : UiPanelBase
{
	// Token: 0x060064BF RID: 25791 RVA: 0x0013F4A0 File Offset: 0x0013D6A0
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

	// Token: 0x060064C0 RID: 25792 RVA: 0x0013F5A4 File Offset: 0x0013D7A4
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

	// Token: 0x060064C1 RID: 25793 RVA: 0x0013F68C File Offset: 0x0013D88C
	public void SetRaycastOnStepEnd()
	{
		UUIButtonComponent button = base.GetButton(7);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetRaycastTarget(false);
	}

	// Token: 0x060064C2 RID: 25794 RVA: 0x0013F6B8 File Offset: 0x0013D8B8
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

	// Token: 0x060064C3 RID: 25795 RVA: 0x0013F930 File Offset: 0x0013DB30
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

	// Token: 0x060064C4 RID: 25796 RVA: 0x0013FA40 File Offset: 0x0013DC40
	private DrinksMenuFlavorItem CreateDrinksItem()
	{
		return new DrinksMenuFlavorItem
		{
			IsSelectOnCb = new Func<int, bool>(this.GetToggleStateSelected),
			IsEnableCb = new Func<int, bool>(this.GetIsToggleEnable),
			OnToggleStateChangeFunction = new Action<UUIExtendToggle, UUIButtonComponent, int, bool>(this.OnToggleStateChange)
		};
	}

	// Token: 0x060064C5 RID: 25797 RVA: 0x0013FA7D File Offset: 0x0013DC7D
	private DrinksMenuOrnamentItem CreateOrnamentItem()
	{
		return new DrinksMenuOrnamentItem
		{
			IsSelectOnCb = new Func<int, bool>(this.GetToggleStateSelected),
			OnToggleStateChangeFunction = new Action<int>(this.OnOrnamentToggleStateChange)
		};
	}

	// Token: 0x060064C6 RID: 25798 RVA: 0x0013FAA8 File Offset: 0x0013DCA8
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

	// Token: 0x060064C7 RID: 25799 RVA: 0x0013FAEB File Offset: 0x0013DCEB
	private bool GetIsToggleEnable(int id)
	{
		return DrinksModel.Instance.GetCurStep() != EDrinksPlayStep.Batching || this.CurrentSelectedBatching.Count < 2 || this.CurrentSelectedBatching.Contains(id);
	}

	// Token: 0x060064C8 RID: 25800 RVA: 0x0013FB18 File Offset: 0x0013DD18
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

	// Token: 0x060064C9 RID: 25801 RVA: 0x0013FC93 File Offset: 0x0013DE93
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

	// Token: 0x060064CA RID: 25802 RVA: 0x0013FCC8 File Offset: 0x0013DEC8
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

	// Token: 0x060064CB RID: 25803 RVA: 0x0013FDBC File Offset: 0x0013DFBC
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

	// Token: 0x04002DBA RID: 11706
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollViewNew<DrinksMenuFlavorItem, int> FlavorScroll;

	// Token: 0x04002DBB RID: 11707
	protected int CurrentSelectedDrinks;

	// Token: 0x04002DBC RID: 11708
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollViewNew<DrinksMenuOrnamentItem, int> OrnamentScroll;

	// Token: 0x04002DBD RID: 11709
	protected HashSet<int> CurrentSelectedBatching = new HashSet<int>();

	// Token: 0x04002DBE RID: 11710
	protected int CurrentSelectedOrnament;

	// Token: 0x04002DBF RID: 11711
	protected List<int> OrnamentList = new List<int>();

	// Token: 0x04002DC0 RID: 11712
	protected List<int> DrinksList = new List<int>();

	// Token: 0x04002DC1 RID: 11713
	protected List<int> BatchingList = new List<int>();

	// Token: 0x04002DC2 RID: 11714
	protected string BatchingKey = "";

	// Token: 0x020075AE RID: 30126
	[NullableContext(0)]
	private static class EDefine
	{
		// Token: 0x04026E54 RID: 159316
		public const int Title = 0;

		// Token: 0x04026E55 RID: 159317
		public const int ScrollDrink = 1;

		// Token: 0x04026E56 RID: 159318
		public const int ContentDrink = 2;

		// Token: 0x04026E57 RID: 159319
		public const int ItemDrink = 3;

		// Token: 0x04026E58 RID: 159320
		public const int ScrollBatching = 4;

		// Token: 0x04026E59 RID: 159321
		public const int ContentBatching = 5;

		// Token: 0x04026E5A RID: 159322
		public const int ItemBatching = 6;

		// Token: 0x04026E5B RID: 159323
		public const int BtnConfirm = 7;

		// Token: 0x04026E5C RID: 159324
		public const int TxtConfirm = 8;
	}
}
