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

// Token: 0x0200219A RID: 8602
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseBdSumView : UiViewBase
{
	// Token: 0x060152A6 RID: 86694 RVA: 0x006284DB File Offset: 0x006266DB
	public TrapDefenseBdSumView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060152A7 RID: 86695 RVA: 0x006284F4 File Offset: 0x006266F4
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

	// Token: 0x060152A8 RID: 86696 RVA: 0x006286D0 File Offset: 0x006268D0
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBdSumView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdSumView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060152A9 RID: 86697 RVA: 0x00628713 File Offset: 0x00626913
	protected override void OnStart()
	{
		this.InitTab();
	}

	// Token: 0x060152AA RID: 86698 RVA: 0x0062871B File Offset: 0x0062691B
	protected override void OnAddEventListener()
	{
	}

	// Token: 0x060152AB RID: 86699 RVA: 0x0062871D File Offset: 0x0062691D
	protected override void OnRemoveEventListener()
	{
	}

	// Token: 0x060152AC RID: 86700 RVA: 0x0062871F File Offset: 0x0062691F
	protected override void OnBeforeShow()
	{
	}

	// Token: 0x060152AD RID: 86701 RVA: 0x00628721 File Offset: 0x00626921
	protected override void OnBeforeDestroy()
	{
		this.ViewModel.OnViewClose();
	}

	// Token: 0x060152AE RID: 86702 RVA: 0x0062872E File Offset: 0x0062692E
	protected override void OnBeforeHide()
	{
		this.ViewModel.Model.RougeModeData.SaveCacheUnlockBdBuffs();
	}

	// Token: 0x060152AF RID: 86703 RVA: 0x00628748 File Offset: 0x00626948
	private void OnBtnHelp()
	{
		int helpIdBdSum = TrapDefenseConfig.Instance.GetHelpIdBdSum();
		HelpController.Instance.OpenHelpById(helpIdBdSum);
	}

	// Token: 0x060152B0 RID: 86704 RVA: 0x0062876B File Offset: 0x0062696B
	private void OnBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x060152B1 RID: 86705 RVA: 0x00628774 File Offset: 0x00626974
	private ShipTowerTeamTabItem CreateTabItem([Nullable(2)] UUIItem item, int? index)
	{
		return new ShipTowerTeamTabItem();
	}

	// Token: 0x060152B2 RID: 86706 RVA: 0x0062877C File Offset: 0x0062697C
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

	// Token: 0x060152B3 RID: 86707 RVA: 0x006287B0 File Offset: 0x006269B0
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

	// Token: 0x060152B4 RID: 86708 RVA: 0x00628830 File Offset: 0x00626A30
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

	// Token: 0x060152B5 RID: 86709 RVA: 0x00628894 File Offset: 0x00626A94
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

	// Token: 0x060152B6 RID: 86710 RVA: 0x0062891D File Offset: 0x00626B1D
	public void SetEmptyInfoVisible(bool visible)
	{
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x060152B7 RID: 86711 RVA: 0x00628934 File Offset: 0x00626B34
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

	// Token: 0x060152B8 RID: 86712 RVA: 0x006289A4 File Offset: 0x00626BA4
	private TrapDefenseBdSumBdItem CreateItemBdScrollItem()
	{
		return new TrapDefenseBdSumBdItem
		{
			ClickCallBack = new Action<TrapDefenseBdData>(this.OnClickScrollBdItem)
		};
	}

	// Token: 0x060152B9 RID: 86713 RVA: 0x006289BD File Offset: 0x00626BBD
	private void OnClickScrollBdItem(TrapDefenseBdData data)
	{
		this.ViewModel.SetSelectBdData(data);
		this.PanelBdDesc.UpdateData(data);
	}

	// Token: 0x060152BA RID: 86714 RVA: 0x006289D8 File Offset: 0x00626BD8
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

	// Token: 0x060152BB RID: 86715 RVA: 0x00628A34 File Offset: 0x00626C34
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

	// Token: 0x060152BC RID: 86716 RVA: 0x00628A90 File Offset: 0x00626C90
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

	// Token: 0x060152BD RID: 86717 RVA: 0x00628B54 File Offset: 0x00626D54
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

	// Token: 0x060152BE RID: 86718 RVA: 0x00628B9E File Offset: 0x00626D9E
	private void SwitchBdBuffStrengthenShow(bool show, TrapDefenseBdBuffData data)
	{
		data.SetIsShowStrengthen(show);
		this.PanelBdBuffDesc.UpdateDataShowMode(data);
		if (this.ViewModel.IsShowBuffLockState(data))
		{
			this.PanelBdBuffDesc.UpdateBuffLockShowState();
		}
	}

	// Token: 0x060152BF RID: 86719 RVA: 0x00628BCC File Offset: 0x00626DCC
	private bool OnIsShowBdBuffLockState(TrapDefenseBdBuffData data)
	{
		return !this.ViewModel.IsInstance && !data.IsUnlock;
	}

	// Token: 0x060152C0 RID: 86720 RVA: 0x00628BE6 File Offset: 0x00626DE6
	private bool IsBdBuffNewTagState(TrapDefenseBdBuffData data)
	{
		return this.ViewModel.Model.RougeModeData.GetBdBuffNewTagState(data);
	}

	// Token: 0x060152C1 RID: 86721 RVA: 0x00628BFE File Offset: 0x00626DFE
	private TrapDefenseBdBuff OnGetBdBuffConfig(TrapDefenseBdBuffData data)
	{
		if (this.ViewModel.IsInstance)
		{
			return data.BdBuffConfig;
		}
		return data.GetStrengthenBeforeConfig();
	}

	// Token: 0x0400B39C RID: 45980
	public PopupCaptionItem PopupCaption;

	// Token: 0x0400B39D RID: 45981
	public TabComponent<ShipTowerTeamTabItem> TabComponent;

	// Token: 0x0400B39E RID: 45982
	public GenericScrollViewNew<TrapDefenseBdSumBdItem, TrapDefenseBdData> ScrollBd;

	// Token: 0x0400B39F RID: 45983
	public GenericScrollViewNew<TrapDefenseBdSumBuffListItem, TrapDefenseBdData> ScrollBdBuff;

	// Token: 0x0400B3A0 RID: 45984
	public TrapDefenseBdSumBdDescPanel PanelBdDesc;

	// Token: 0x0400B3A1 RID: 45985
	public TrapDefenseBdSumBuffDescPanel PanelBdBuffDesc;

	// Token: 0x0400B3A2 RID: 45986
	public TrapDefenseBdSumViewModel ViewModel = TrapDefenseModel.Instance.ViewModelBdSum;

	// Token: 0x0400B3A3 RID: 45987
	public List<ITrapDefenseTab<ETrapDefenseBdTabType>> TabDataList;

	// Token: 0x02008450 RID: 33872
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402AAF1 RID: 174833
		public const int ItemBgYellowLight = 0;

		// Token: 0x0402AAF2 RID: 174834
		public const int ItemBgRedLight = 1;

		// Token: 0x0402AAF3 RID: 174835
		public const int ItemCaption = 2;

		// Token: 0x0402AAF4 RID: 174836
		public const int ItemTabComponent = 3;

		// Token: 0x0402AAF5 RID: 174837
		public const int ItemBdRoot = 4;

		// Token: 0x0402AAF6 RID: 174838
		public const int ScrollBd = 5;

		// Token: 0x0402AAF7 RID: 174839
		public const int ItemBdScrollItem = 6;

		// Token: 0x0402AAF8 RID: 174840
		public const int ItemBdBuffRoot = 7;

		// Token: 0x0402AAF9 RID: 174841
		public const int ScrollBdBuff = 8;

		// Token: 0x0402AAFA RID: 174842
		public const int ItemBdBuffScrollItem = 9;

		// Token: 0x0402AAFB RID: 174843
		public const int ItemBdBuffDescRoot = 10;

		// Token: 0x0402AAFC RID: 174844
		public const int ItemBdDescRoot = 11;

		// Token: 0x0402AAFD RID: 174845
		public const int ItemEmptyInfo = 12;
	}
}
