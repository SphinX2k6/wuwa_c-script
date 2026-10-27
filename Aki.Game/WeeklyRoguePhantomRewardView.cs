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

// Token: 0x02002D50 RID: 11600
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRoguePhantomRewardView : UiViewBase
{
	// Token: 0x060185FF RID: 99839 RVA: 0x00634A3A File Offset: 0x00632C3A
	public WeeklyRoguePhantomRewardView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06018600 RID: 99840 RVA: 0x00634A4C File Offset: 0x00632C4C
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

	// Token: 0x06018601 RID: 99841 RVA: 0x00634B21 File Offset: 0x00632D21
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPowerChanged, new Action(this.OnPowerChange));
	}

	// Token: 0x06018602 RID: 99842 RVA: 0x00634B3F File Offset: 0x00632D3F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPowerChanged, new Action(this.OnPowerChange));
	}

	// Token: 0x06018603 RID: 99843 RVA: 0x00634B60 File Offset: 0x00632D60
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRoguePhantomRewardView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRoguePhantomRewardView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06018604 RID: 99844 RVA: 0x00634BA4 File Offset: 0x00632DA4
	protected override void OnStart()
	{
		this.PhantomLoopScrollView = new LoopScrollView<WeeklyRoguePhantomRewardItem, WeeklyRoguePhantomRewardInfo>(base.GetLoopScrollViewComponent(1), (AUIBaseActor)base.GetItem(2).GetOwner(), new Func<WeeklyRoguePhantomRewardItem>(this.InitRewardItem), false);
		this.RefreshLayout();
		this.RefreshState();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "WeeklyRouge_BonusWindow_Title", Array.Empty<object>());
	}

	// Token: 0x06018605 RID: 99845 RVA: 0x00634C08 File Offset: 0x00632E08
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

	// Token: 0x06018606 RID: 99846 RVA: 0x00634CCD File Offset: 0x00632ECD
	protected override void OnBeforeDestroy()
	{
		Action closeCallBack = this.InfoData.CloseCallBack;
		if (closeCallBack == null)
		{
			return;
		}
		closeCallBack();
	}

	// Token: 0x06018607 RID: 99847 RVA: 0x00634CE4 File Offset: 0x00632EE4
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

	// Token: 0x06018608 RID: 99848 RVA: 0x00634D74 File Offset: 0x00632F74
	private UniTask InitCurrency()
	{
		WeeklyRoguePhantomRewardView.<InitCurrency>d__18 <InitCurrency>d__;
		<InitCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCurrency>d__.<>4__this = this;
		<InitCurrency>d__.<>1__state = -1;
		<InitCurrency>d__.<>t__builder.Start<WeeklyRoguePhantomRewardView.<InitCurrency>d__18>(ref <InitCurrency>d__);
		return <InitCurrency>d__.<>t__builder.Task;
	}

	// Token: 0x06018609 RID: 99849 RVA: 0x00634DB8 File Offset: 0x00632FB8
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

	// Token: 0x0601860A RID: 99850 RVA: 0x00634E8C File Offset: 0x0063308C
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

	// Token: 0x0601860B RID: 99851 RVA: 0x00634EDC File Offset: 0x006330DC
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

	// Token: 0x0601860C RID: 99852 RVA: 0x00634F2F File Offset: 0x0063312F
	private WeeklyRoguePhantomRewardItem InitRewardItem()
	{
		return new WeeklyRoguePhantomRewardItem
		{
			IsSelectOnCb = new Func<int, bool>(this.GetToggleStateSelected),
			OnToggleStateChangeFunction = new Action<UUIExtendToggle, UUIButtonComponent, int, bool>(this.OnToggleStateChange)
		};
	}

	// Token: 0x0601860D RID: 99853 RVA: 0x00634F5A File Offset: 0x0063315A
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

	// Token: 0x0601860E RID: 99854 RVA: 0x00634F7D File Offset: 0x0063317D
	private void OnHelpButtonClick()
	{
		HelpController.Instance.OpenHelpById(463);
	}

	// Token: 0x0601860F RID: 99855 RVA: 0x00634F8E File Offset: 0x0063318E
	private bool GetToggleStateSelected(int awardId)
	{
		return this.CurSelectedAreaId == awardId;
	}

	// Token: 0x06018610 RID: 99856 RVA: 0x00634F99 File Offset: 0x00633199
	private void OnToggleStateChange(UUIExtendToggle toggle, UUIButtonComponent reduceButton, int id, bool isSelected)
	{
		this.CurSelectedAreaId = (isSelected ? id : -1);
		this.RefreshState();
	}

	// Token: 0x0400B4DD RID: 46301
	[Nullable(2)]
	private PowerCurrencyItem PowerCurrencyItem;

	// Token: 0x0400B4DE RID: 46302
	[Nullable(2)]
	private PowerCurrencyItem OverPowerCurrencyItem;

	// Token: 0x0400B4DF RID: 46303
	protected LoopScrollView<WeeklyRoguePhantomRewardItem, WeeklyRoguePhantomRewardInfo> PhantomLoopScrollView;

	// Token: 0x0400B4E0 RID: 46304
	protected WeeklyRogueRewardPopViewData InfoData;

	// Token: 0x0400B4E1 RID: 46305
	[Nullable(2)]
	private PowerRewardButtonItem SingleButtonItem;

	// Token: 0x0400B4E2 RID: 46306
	[Nullable(2)]
	private PowerRewardButtonItem DoubleButtonItem;

	// Token: 0x0400B4E3 RID: 46307
	private int CurSelectedAreaId = -1;

	// Token: 0x0400B4E4 RID: 46308
	private const int HELP_ID = 463;

	// Token: 0x020092E3 RID: 37603
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402F7A4 RID: 194468
		TxtTitle,
		// Token: 0x0402F7A5 RID: 194469
		LoopScroll,
		// Token: 0x0402F7A6 RID: 194470
		RewardItem,
		// Token: 0x0402F7A7 RID: 194471
		TxtSelected,
		// Token: 0x0402F7A8 RID: 194472
		BtnLeft,
		// Token: 0x0402F7A9 RID: 194473
		BtnRight,
		// Token: 0x0402F7AA RID: 194474
		BtnHelpInfo
	}
}
