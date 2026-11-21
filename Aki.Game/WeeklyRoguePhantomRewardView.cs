using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022AA RID: 8874
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRoguePhantomRewardView : UiViewBase
{
	// Token: 0x06015EA1 RID: 89761 RVA: 0x0065AA4A File Offset: 0x00658C4A
	public WeeklyRoguePhantomRewardView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06015EA2 RID: 89762 RVA: 0x0065AA5C File Offset: 0x00658C5C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OnHelpButtonClick))
		};
	}

	// Token: 0x06015EA3 RID: 89763 RVA: 0x0065AB31 File Offset: 0x00658D31
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPowerChanged, new Action(this.OnPowerChange));
	}

	// Token: 0x06015EA4 RID: 89764 RVA: 0x0065AB4F File Offset: 0x00658D4F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPowerChanged, new Action(this.OnPowerChange));
	}

	// Token: 0x06015EA5 RID: 89765 RVA: 0x0065AB70 File Offset: 0x00658D70
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRoguePhantomRewardView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRoguePhantomRewardView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015EA6 RID: 89766 RVA: 0x0065ABB4 File Offset: 0x00658DB4
	protected override void OnStart()
	{
		this.PhantomLoopScrollView = new LoopScrollView<WeeklyRoguePhantomRewardItem, WeeklyRoguePhantomRewardInfo>(base.GetLoopScrollViewComponent(1), (AUIBaseActor)base.GetItem(2).GetOwner(), new Func<WeeklyRoguePhantomRewardItem>(this.InitRewardItem), false);
		this.RefreshLayout();
		this.RefreshState();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "WeeklyRouge_BonusWindow_Title", Array.Empty<object>());
	}

	// Token: 0x06015EA7 RID: 89767 RVA: 0x0065AC18 File Offset: 0x00658E18
	protected override void OnBeforeShow()
	{
		PowerCurrencyItem overPowerCurrencyItem = this.OverPowerCurrencyItem;
		if (overPowerCurrencyItem != null)
		{
			UUIItem originalItem = overPowerCurrencyItem.GetOriginalItem();
			if (originalItem != null)
			{
				IUiPopFrameInterface childPopView = this.ChildPopView;
				UUIItem inParent;
				if (childPopView == null)
				{
					inParent = null;
				}
				else
				{
					CommonPopViewBase popItem = childPopView.PopItem;
					inParent = ((popItem != null) ? popItem.GetCostParent() : null);
				}
				originalItem.SetUIParent(inParent, false);
			}
		}
		PowerCurrencyItem powerCurrencyItem = this.PowerCurrencyItem;
		if (powerCurrencyItem != null)
		{
			UUIItem originalItem2 = powerCurrencyItem.GetOriginalItem();
			if (originalItem2 != null)
			{
				IUiPopFrameInterface childPopView2 = this.ChildPopView;
				UUIItem inParent2;
				if (childPopView2 == null)
				{
					inParent2 = null;
				}
				else
				{
					CommonPopViewBase popItem2 = childPopView2.PopItem;
					inParent2 = ((popItem2 != null) ? popItem2.GetCostParent() : null);
				}
				originalItem2.SetUIParent(inParent2, false);
			}
		}
		this.PowerCurrencyItem.ShowWithoutText(5);
		PowerCurrencyItem powerCurrencyItem2 = this.PowerCurrencyItem;
		if (powerCurrencyItem2 != null)
		{
			powerCurrencyItem2.SetButtonFunction(delegate(int _)
			{
				PowerController.Instance.OpenPowerView(EPowerMenuType.Supply, 0);
			});
		}
		this.RefreshState();
	}

	// Token: 0x06015EA8 RID: 89768 RVA: 0x0065ACDD File Offset: 0x00658EDD
	protected override void OnBeforeDestroy()
	{
		Action closeCallBack = this.InfoData.CloseCallBack;
		if (closeCallBack == null)
		{
			return;
		}
		closeCallBack();
	}

	// Token: 0x06015EA9 RID: 89769 RVA: 0x0065ACF4 File Offset: 0x00658EF4
	private bool RewardByCount(int count)
	{
		if (this.CurSelectedAreaId == -1)
		{
			return false;
		}
		int value = count * this.InfoData.SinglePowerCost;
		if (!PowerModel.Instance.IsPowerEnough(new int?(value)))
		{
			string textById = TextConfig.Instance.GetTextById("ReceiveLevelPlayPowerNotEnough");
			ScrollingTipsController.Instance.ShowTipsByText(textById);
			PowerController.Instance.OpenPowerView(EPowerMenuType.Supply, PowerModel.Instance.GetCurrentNeedPower(new int?(value)));
			return false;
		}
		this.InfoData.RewardCallBack(count, this.CurSelectedAreaId);
		base.CloseMe(null);
		return true;
	}

	// Token: 0x06015EAA RID: 89770 RVA: 0x0065AD84 File Offset: 0x00658F84
	private UniTask InitCurrency()
	{
		WeeklyRoguePhantomRewardView.<InitCurrency>d__18 <InitCurrency>d__;
		<InitCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCurrency>d__.<>4__this = this;
		<InitCurrency>d__.<>1__state = -1;
		<InitCurrency>d__.<>t__builder.Start<WeeklyRoguePhantomRewardView.<InitCurrency>d__18>(ref <InitCurrency>d__);
		return <InitCurrency>d__.<>t__builder.Task;
	}

	// Token: 0x06015EAB RID: 89771 RVA: 0x0065ADC8 File Offset: 0x00658FC8
	protected void RefreshLayout()
	{
		List<int> availableSilentArea = this.InfoData.AvailableSilentArea;
		IEnumerable<RogueWeeklyBF> blackFlowerConfigAll = WeeklyRogueConfig.Instance.GetBlackFlowerConfigAll();
		List<WeeklyRoguePhantomRewardInfo> list = new List<WeeklyRoguePhantomRewardInfo>();
		foreach (RogueWeeklyBF rogueWeeklyBF in blackFlowerConfigAll)
		{
			WeeklyRoguePhantomRewardInfo item = new WeeklyRoguePhantomRewardInfo
			{
				IsActive = availableSilentArea.Contains(rogueWeeklyBF.Id),
				AreaAwardId = rogueWeeklyBF.Id,
				SortId = rogueWeeklyBF.SortId
			};
			list.Add(item);
		}
		list.Sort(delegate(WeeklyRoguePhantomRewardInfo a, WeeklyRoguePhantomRewardInfo b)
		{
			if (a.IsActive == b.IsActive)
			{
				return b.SortId - a.SortId;
			}
			if (!a.IsActive)
			{
				return 1;
			}
			return -1;
		});
		this.PhantomLoopScrollView.RefreshByData(list, false, null, false);
	}

	// Token: 0x06015EAC RID: 89772 RVA: 0x0065AE9C File Offset: 0x0065909C
	protected void RefreshState()
	{
		this.RefreshStateTxt();
		bool isEnable = this.CurSelectedAreaId != -1;
		PowerRewardButtonItem singleButtonItem = this.SingleButtonItem;
		if (singleButtonItem != null)
		{
			singleButtonItem.SetIsEnable(isEnable);
		}
		PowerRewardButtonItem doubleButtonItem = this.DoubleButtonItem;
		if (doubleButtonItem != null)
		{
			doubleButtonItem.SetIsEnable(isEnable);
		}
		this.PhantomLoopScrollView.RefreshAllGridProxies();
	}

	// Token: 0x06015EAD RID: 89773 RVA: 0x0065AEEC File Offset: 0x006590EC
	protected void RefreshStateTxt()
	{
		string textStringId = "Text_SelectRewardFromPool_Text";
		object[] args = new object[]
		{
			1,
			(this.CurSelectedAreaId != -1) ? 1 : 0,
			1
		};
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, args);
	}

	// Token: 0x06015EAE RID: 89774 RVA: 0x0065AF3F File Offset: 0x0065913F
	private WeeklyRoguePhantomRewardItem InitRewardItem()
	{
		return new WeeklyRoguePhantomRewardItem
		{
			IsSelectOnCb = new Func<int, bool>(this.GetToggleStateSelected),
			OnToggleStateChangeFunction = new Action<UUIExtendToggle, UUIButtonComponent, int, bool>(this.OnToggleStateChange)
		};
	}

	// Token: 0x06015EAF RID: 89775 RVA: 0x0065AF6A File Offset: 0x0065916A
	private void OnPowerChange()
	{
		PowerRewardButtonItem singleButtonItem = this.SingleButtonItem;
		if (singleButtonItem != null)
		{
			singleButtonItem.RefreshPowerState();
		}
		PowerRewardButtonItem doubleButtonItem = this.DoubleButtonItem;
		if (doubleButtonItem == null)
		{
			return;
		}
		doubleButtonItem.RefreshPowerState();
	}

	// Token: 0x06015EB0 RID: 89776 RVA: 0x0065AF8D File Offset: 0x0065918D
	private void OnHelpButtonClick()
	{
		HelpController.Instance.OpenHelpById(463);
	}

	// Token: 0x06015EB1 RID: 89777 RVA: 0x0065AF9E File Offset: 0x0065919E
	private bool GetToggleStateSelected(int awardId)
	{
		return this.CurSelectedAreaId == awardId;
	}

	// Token: 0x06015EB2 RID: 89778 RVA: 0x0065AFA9 File Offset: 0x006591A9
	private void OnToggleStateChange(UUIExtendToggle toggle, UUIButtonComponent reduceButton, int id, bool isSelected)
	{
		this.CurSelectedAreaId = (isSelected ? id : -1);
		this.RefreshState();
	}

	// Token: 0x0400B852 RID: 47186
	[Nullable(2)]
	private PowerCurrencyItem PowerCurrencyItem;

	// Token: 0x0400B853 RID: 47187
	[Nullable(2)]
	private PowerCurrencyItem OverPowerCurrencyItem;

	// Token: 0x0400B854 RID: 47188
	protected LoopScrollView<WeeklyRoguePhantomRewardItem, WeeklyRoguePhantomRewardInfo> PhantomLoopScrollView;

	// Token: 0x0400B855 RID: 47189
	protected WeeklyRogueRewardPopViewData InfoData;

	// Token: 0x0400B856 RID: 47190
	[Nullable(2)]
	private PowerRewardButtonItem SingleButtonItem;

	// Token: 0x0400B857 RID: 47191
	[Nullable(2)]
	private PowerRewardButtonItem DoubleButtonItem;

	// Token: 0x0400B858 RID: 47192
	private int CurSelectedAreaId = -1;

	// Token: 0x0400B859 RID: 47193
	private const int HELP_ID = 463;

	// Token: 0x0200850A RID: 34058
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402AE2C RID: 175660
		TxtTitle,
		// Token: 0x0402AE2D RID: 175661
		LoopScroll,
		// Token: 0x0402AE2E RID: 175662
		RewardItem,
		// Token: 0x0402AE2F RID: 175663
		TxtSelected,
		// Token: 0x0402AE30 RID: 175664
		BtnLeft,
		// Token: 0x0402AE31 RID: 175665
		BtnRight,
		// Token: 0x0402AE32 RID: 175666
		BtnHelpInfo
	}
}
