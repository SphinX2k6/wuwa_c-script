using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C1F RID: 11295
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseBdSumView : UiViewBase
{
	// Token: 0x06017874 RID: 96372 RVA: 0x005FBAB7 File Offset: 0x005F9CB7
	public TrapDefenseBdSumView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06017875 RID: 96373 RVA: 0x005FBAD0 File Offset: 0x005F9CD0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06017876 RID: 96374 RVA: 0x005FBCAC File Offset: 0x005F9EAC
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBdSumView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdSumView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017877 RID: 96375 RVA: 0x005FBCEF File Offset: 0x005F9EEF
	protected override void OnStart()
	{
		this.InitTab();
	}

	// Token: 0x06017878 RID: 96376 RVA: 0x005FBCF7 File Offset: 0x005F9EF7
	protected override void OnAddEventListener()
	{
	}

	// Token: 0x06017879 RID: 96377 RVA: 0x005FBCF9 File Offset: 0x005F9EF9
	protected override void OnRemoveEventListener()
	{
	}

	// Token: 0x0601787A RID: 96378 RVA: 0x005FBCFB File Offset: 0x005F9EFB
	protected override void OnBeforeShow()
	{
	}

	// Token: 0x0601787B RID: 96379 RVA: 0x005FBCFD File Offset: 0x005F9EFD
	protected override void OnBeforeDestroy()
	{
		this.ViewModel.OnViewClose();
	}

	// Token: 0x0601787C RID: 96380 RVA: 0x005FBD0A File Offset: 0x005F9F0A
	protected override void OnBeforeHide()
	{
		this.ViewModel.Model.RougeModeData.SaveCacheUnlockBdBuffs();
	}

	// Token: 0x0601787D RID: 96381 RVA: 0x005FBD24 File Offset: 0x005F9F24
	private void OnBtnHelp()
	{
		int helpIdBdSum = TrapDefenseConfig.Instance.GetHelpIdBdSum();
		HelpController.Instance.OpenHelpById(helpIdBdSum);
	}

	// Token: 0x0601787E RID: 96382 RVA: 0x005FBD47 File Offset: 0x005F9F47
	private void OnBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601787F RID: 96383 RVA: 0x005FBD50 File Offset: 0x005F9F50
	private ShipTowerTeamTabItem CreateTabItem([Nullable(2)] UUIItem item, int? index)
	{
		return new ShipTowerTeamTabItem();
	}

	// Token: 0x06017880 RID: 96384 RVA: 0x005FBD58 File Offset: 0x005F9F58
	private void OnClickTabItem(int index)
	{
		ETrapDefenseBdTabType tabType = this.TabDataList[index].TabType;
		if (tabType == ETrapDefenseBdTabType.BdProgress)
		{
			this.ShowBdProgress();
			return;
		}
		if (tabType != ETrapDefenseBdTabType.BuffSum)
		{
			return;
		}
		this.ShowBdBuffSum();
	}

	// Token: 0x06017881 RID: 96385 RVA: 0x005FBD8C File Offset: 0x005F9F8C
	public void ShowBdProgress()
	{
		this.SetTabItemContentShow(4);
		this.PanelBdBuffDesc.SetActive(false);
		this.PanelBdDesc.SetActive(true);
		List<TrapDefenseBdData> bdListForProgress = this.ViewModel.GetBdListForProgress();
		int lastSelectIndex = this.GetSelectBdProgressIndex(bdListForProgress);
		this.ScrollBd.RefreshByData(bdListForProgress, delegate
		{
			this.ScrollBd.SelectGridProxy(Math.Max(lastSelectIndex, 0), false);
		}, true);
		this.SetEmptyInfoVisible(bdListForProgress.Count <= 0);
	}

	// Token: 0x06017882 RID: 96386 RVA: 0x005FBE0C File Offset: 0x005FA00C
	public int GetSelectBdProgressIndex(List<TrapDefenseBdData> dataList)
	{
		int selectedIndex = this.ScrollBd.GetSelectedIndex();
		if (selectedIndex < 0)
		{
			int? jumpId = this.ViewModel.JumpBdId;
			if (jumpId != null && jumpId.GetValueOrDefault() != 0)
			{
				return dataList.FindIndex(delegate(TrapDefenseBdData data)
				{
					int id = data.Id;
					int? jumpId = jumpId;
					return id == jumpId.GetValueOrDefault() & jumpId != null;
				});
			}
		}
		return selectedIndex;
	}

	// Token: 0x06017883 RID: 96387 RVA: 0x005FBE70 File Offset: 0x005FA070
	public void ShowBdBuffSum()
	{
		this.SetTabItemContentShow(7);
		int lastSelectIndex = this.ScrollBdBuff.GetSelectedIndex();
		List<TrapDefenseBdData> bdListForBuffSum = this.ViewModel.GetBdListForBuffSum();
		this.ScrollBdBuff.RefreshByData(bdListForBuffSum, delegate
		{
			this.ScrollBdBuff.SelectGridProxy(Math.Max(lastSelectIndex, 0), false);
		}, true);
		this.PanelBdDesc.SetActive(false);
		this.PanelBdBuffDesc.SetActive(bdListForBuffSum.Count > 0);
		this.SetEmptyInfoVisible(bdListForBuffSum.Count <= 0);
	}

	// Token: 0x06017884 RID: 96388 RVA: 0x005FBEF9 File Offset: 0x005FA0F9
	public void SetEmptyInfoVisible(bool visible)
	{
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x06017885 RID: 96389 RVA: 0x005FBF10 File Offset: 0x005FA110
	public void SetTabItemContentShow(int childType)
	{
		foreach (int num in new List<int>
		{
			4,
			7
		})
		{
			UUIItem item = base.GetItem(num);
			if (item != null)
			{
				item.SetUIActive(num == childType);
			}
		}
	}

	// Token: 0x06017886 RID: 96390 RVA: 0x005FBF80 File Offset: 0x005FA180
	private TrapDefenseBdSumBdItem CreateItemBdScrollItem()
	{
		return new TrapDefenseBdSumBdItem
		{
			ClickCallBack = new Action<TrapDefenseBdData>(this.OnClickScrollBdItem)
		};
	}

	// Token: 0x06017887 RID: 96391 RVA: 0x005FBF99 File Offset: 0x005FA199
	private void OnClickScrollBdItem(TrapDefenseBdData data)
	{
		this.ViewModel.SetSelectBdData(data);
		this.PanelBdDesc.UpdateData(data);
	}

	// Token: 0x06017888 RID: 96392 RVA: 0x005FBFB4 File Offset: 0x005FA1B4
	private TrapDefenseBdSumBuffListItem CreateItemBdBuffScrollItem()
	{
		return new TrapDefenseBdSumBuffListItem
		{
			OnSelectBdBuffItemCallBack = new Action<TrapDefenseBdBuffData, TrapDefenseBdBuffItem>(this.OnSelectScrollBdBuffItem),
			OnIsShowBdBuffLockStateCallback = new Func<TrapDefenseBdBuffData, bool>(this.OnIsShowBdBuffLockState),
			OnIsNewTagStateCallback = new Func<TrapDefenseBdBuffData, bool>(this.IsBdBuffNewTagState),
			OnGetBdBuffConfig = new Func<TrapDefenseBdBuffData, TrapDefenseBdBuff>(this.OnGetBdBuffConfig)
		};
	}

	// Token: 0x06017889 RID: 96393 RVA: 0x005FC010 File Offset: 0x005FA210
	private void OnSelectScrollBdBuffItem(TrapDefenseBdBuffData data, TrapDefenseBdBuffItem item)
	{
		this.ViewModel.SetSelectBdBuffData(data);
		this.PanelBdBuffDesc.UpdateDataShowMode(data);
		if (this.ViewModel.IsShowBuffLockState(data))
		{
			this.PanelBdBuffDesc.UpdateBuffLockShowState();
		}
		if (this.ViewModel.Model.RougeModeData.CheckBdBuffUnlockRedDotState(data))
		{
			item.UpdateBuffInfo();
		}
	}

	// Token: 0x0601788A RID: 96394 RVA: 0x005FC06C File Offset: 0x005FA26C
	public void InitTab()
	{
		foreach (KeyValuePair<int, ShipTowerTeamTabItem> keyValuePair in this.TabComponent.GetTabItemMap())
		{
			int key = keyValuePair.Key;
			ShipTowerTeamTabItem value = keyValuePair.Value;
			value.UpdateName(this.TabDataList[key].TabNameKey);
			if (this.TabDataList[key].TabType == ETrapDefenseBdTabType.BuffSum && !this.ViewModel.IsInstance)
			{
				value.BindRedDot(ERedDotName.TrapDefenseBdBuffNewUnlock, 0);
			}
			else
			{
				value.UpdateRedDotVisible(false);
			}
		}
		this.TabComponent.SelectToggleByIndex(this.GetJumpTabIndex(), true, true);
	}

	// Token: 0x0601788B RID: 96395 RVA: 0x005FC130 File Offset: 0x005FA330
	public int GetJumpTabIndex()
	{
		ETrapDefenseBdTabType? jumpTabType = this.ViewModel.JumpTabType;
		if (jumpTabType == null)
		{
			return 0;
		}
		return this.TabDataList.FindIndex(delegate(ITrapDefenseTab<ETrapDefenseBdTabType> tab)
		{
			ETrapDefenseBdTabType tabType = tab.TabType;
			ETrapDefenseBdTabType? jumpTabType = jumpTabType;
			return tabType == jumpTabType.GetValueOrDefault() & jumpTabType != null;
		});
	}

	// Token: 0x0601788C RID: 96396 RVA: 0x005FC17A File Offset: 0x005FA37A
	private void SwitchBdBuffStrengthenShow(bool show, TrapDefenseBdBuffData data)
	{
		data.SetIsShowStrengthen(show);
		this.PanelBdBuffDesc.UpdateDataShowMode(data);
		if (this.ViewModel.IsShowBuffLockState(data))
		{
			this.PanelBdBuffDesc.UpdateBuffLockShowState();
		}
	}

	// Token: 0x0601788D RID: 96397 RVA: 0x005FC1A8 File Offset: 0x005FA3A8
	private bool OnIsShowBdBuffLockState(TrapDefenseBdBuffData data)
	{
		return !this.ViewModel.IsInstance && !data.IsUnlock;
	}

	// Token: 0x0601788E RID: 96398 RVA: 0x005FC1C2 File Offset: 0x005FA3C2
	private bool IsBdBuffNewTagState(TrapDefenseBdBuffData data)
	{
		return this.ViewModel.Model.RougeModeData.GetBdBuffNewTagState(data);
	}

	// Token: 0x0601788F RID: 96399 RVA: 0x005FC1DA File Offset: 0x005FA3DA
	private TrapDefenseBdBuff OnGetBdBuffConfig(TrapDefenseBdBuffData data)
	{
		if (this.ViewModel.IsInstance)
		{
			return data.BdBuffConfig;
		}
		return data.GetStrengthenBeforeConfig();
	}

	// Token: 0x0400AF97 RID: 44951
	public PopupCaptionItem PopupCaption;

	// Token: 0x0400AF98 RID: 44952
	public TabComponent<ShipTowerTeamTabItem> TabComponent;

	// Token: 0x0400AF99 RID: 44953
	public GenericScrollViewNew<TrapDefenseBdSumBdItem, TrapDefenseBdData> ScrollBd;

	// Token: 0x0400AF9A RID: 44954
	public GenericScrollViewNew<TrapDefenseBdSumBuffListItem, TrapDefenseBdData> ScrollBdBuff;

	// Token: 0x0400AF9B RID: 44955
	public TrapDefenseBdSumBdDescPanel PanelBdDesc;

	// Token: 0x0400AF9C RID: 44956
	public TrapDefenseBdSumBuffDescPanel PanelBdBuffDesc;

	// Token: 0x0400AF9D RID: 44957
	public TrapDefenseBdSumViewModel ViewModel = TrapDefenseModel.Instance.ViewModelBdSum;

	// Token: 0x0400AF9E RID: 44958
	public List<ITrapDefenseTab<ETrapDefenseBdTabType>> TabDataList;

	// Token: 0x0200920D RID: 37389
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402F3F0 RID: 193520
		public const int ItemBgYellowLight = 0;

		// Token: 0x0402F3F1 RID: 193521
		public const int ItemBgRedLight = 1;

		// Token: 0x0402F3F2 RID: 193522
		public const int ItemCaption = 2;

		// Token: 0x0402F3F3 RID: 193523
		public const int ItemTabComponent = 3;

		// Token: 0x0402F3F4 RID: 193524
		public const int ItemBdRoot = 4;

		// Token: 0x0402F3F5 RID: 193525
		public const int ScrollBd = 5;

		// Token: 0x0402F3F6 RID: 193526
		public const int ItemBdScrollItem = 6;

		// Token: 0x0402F3F7 RID: 193527
		public const int ItemBdBuffRoot = 7;

		// Token: 0x0402F3F8 RID: 193528
		public const int ScrollBdBuff = 8;

		// Token: 0x0402F3F9 RID: 193529
		public const int ItemBdBuffScrollItem = 9;

		// Token: 0x0402F3FA RID: 193530
		public const int ItemBdBuffDescRoot = 10;

		// Token: 0x0402F3FB RID: 193531
		public const int ItemBdDescRoot = 11;

		// Token: 0x0402F3FC RID: 193532
		public const int ItemEmptyInfo = 12;
	}
}
