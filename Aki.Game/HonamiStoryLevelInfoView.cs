using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001387 RID: 4999
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryLevelInfoView : UiViewBase
{
	// Token: 0x17001315 RID: 4885
	// (get) Token: 0x0600C65A RID: 50778 RVA: 0x003B0F86 File Offset: 0x003AF186
	public ETarget? GetCurTarget
	{
		get
		{
			return this.CurTarget;
		}
	}

	// Token: 0x17001316 RID: 4886
	// (get) Token: 0x0600C65B RID: 50779 RVA: 0x003B0F8E File Offset: 0x003AF18E
	public int GetCurDangerLv
	{
		get
		{
			return this.CurDangerLv;
		}
	}

	// Token: 0x17001317 RID: 4887
	// (get) Token: 0x0600C65C RID: 50780 RVA: 0x003B0F96 File Offset: 0x003AF196
	public bool GetIsBuySafe
	{
		get
		{
			return this.IsBuySafe;
		}
	}

	// Token: 0x0600C65D RID: 50781 RVA: 0x003B0FA0 File Offset: 0x003AF1A0
	[NullableContext(1)]
	public HonamiStoryLevelInfoView(UiViewInfo viewInfo)
	{
		Dictionary<int, EHonamiStoryOutDialogType> dictionary = new Dictionary<int, EHonamiStoryOutDialogType>();
		dictionary[1] = EHonamiStoryOutDialogType.LevelInfoFirst;
		dictionary[2] = EHonamiStoryOutDialogType.LevelInfoFirst;
		dictionary[3] = EHonamiStoryOutDialogType.LevelInfoSecond;
		dictionary[4] = EHonamiStoryOutDialogType.LevelInfoSecond;
		dictionary[5] = EHonamiStoryOutDialogType.LevelInfoSecond;
		this.BoZaiTalkMap = dictionary;
		this.CurDangerLv = 1;
		this.CurHonamiDangerLv = 1;
		this.CurTowerDangerLv = 1;
		this.TargetBgPath = string.Empty;
		base..ctor(viewInfo);
	}

	// Token: 0x0600C65E RID: 50782 RVA: 0x003B100C File Offset: 0x003AF20C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 25;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnClickBtnReduce));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickBtnAdd));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(16, new Action<EToggleState>(this.OnBuySafeTogClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C65F RID: 50783 RVA: 0x003B1404 File Offset: 0x003AF604
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryLevelInfoView.<OnBeforeStartAsync>d__36 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryLevelInfoView.<OnBeforeStartAsync>d__36>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C660 RID: 50784 RVA: 0x003B1448 File Offset: 0x003AF648
	protected override void OnBeforeShow()
	{
		this.PnlTeam.RefreshView();
		HonamiStoryQuestPanel questPanel = this.QuestPanel;
		ETarget? curTarget = this.CurTarget;
		ETarget etarget = ETarget.HonamiCity;
		questPanel.Refresh(curTarget.GetValueOrDefault() == etarget & curTarget != null);
		this.PnlEnterProfit.RefreshNormal(true);
		this.CheckHonamiTogRedDot();
		this.CheckTowerFirstUnLockRedDot();
		this.BtnGo.RefreshView();
	}

	// Token: 0x0600C661 RID: 50785 RVA: 0x003B14AC File Offset: 0x003AF6AC
	protected override void OnAfterShow()
	{
		this.TryShowAreaUnLockTips();
		this.TryShowHonamiTowerUnLockTips();
		EHonamiStoryOutDialogType dialogType = EHonamiStoryOutDialogType.LevelInfoFree;
		if (!this.IsOpenFreeSelect && this.BoZaiTalkMap.ContainsKey(this.CurDangerLv))
		{
			dialogType = this.BoZaiTalkMap[this.CurDangerLv];
		}
		HonamiStoryOutDialog? randomDialogData = HonamiStoryModel.Instance.GetRandomDialogData((int)dialogType);
		this.TalkPanel.SetTalkInfoTextAndPlayAudio(randomDialogData);
	}

	// Token: 0x0600C662 RID: 50786 RVA: 0x003B150D File Offset: 0x003AF70D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600C663 RID: 50787 RVA: 0x003B152B File Offset: 0x003AF72B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600C664 RID: 50788 RVA: 0x003B1549 File Offset: 0x003AF749
	protected override void OnBeforeHide()
	{
		this.ActData.CurTarget = (int)this.CurTarget.Value;
		this.ActData.CurHonamiLv = this.CurHonamiDangerLv;
		this.ActData.CurTowerLv = this.CurTowerDangerLv;
	}

	// Token: 0x0600C665 RID: 50789 RVA: 0x003B1584 File Offset: 0x003AF784
	public int GetCurSafeLeavePrice()
	{
		if (this.IsOpenBuySafe)
		{
			ETarget? curTarget = this.CurTarget;
			ETarget etarget = ETarget.HonamiCity;
			if ((curTarget.GetValueOrDefault() == etarget & curTarget != null) && this.IsBuySafe)
			{
				return HonamiStoryConfig.Instance.GetDangerLevelConfig(this.CurDangerLv).Value.SafeLeavePrice;
			}
		}
		return 0;
	}

	// Token: 0x0600C666 RID: 50790 RVA: 0x003B15E0 File Offset: 0x003AF7E0
	private void TryShowAreaUnLockTips()
	{
		Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.HonamiStorySelectLvAreaUnLockTips, null);
		if (player == null)
		{
			return;
		}
		List<int> list = new List<int>(player.Keys);
		list.Sort((int a, int b) => a.CompareTo(b));
		foreach (int num in list)
		{
			bool flag;
			if (player.TryGetValue(num, out flag) && flag)
			{
				HonamiStoryArea? honamiStoryAreaConfig = HonamiStoryConfig.Instance.GetHonamiStoryAreaConfig(num);
				if (honamiStoryAreaConfig != null && !string.IsNullOrEmpty(honamiStoryAreaConfig.Value.UnLockTips))
				{
					DifficultUnlockTipsData difficultUnlockTipsData = new DifficultUnlockTipsData();
					difficultUnlockTipsData.Text = honamiStoryAreaConfig.Value.UnLockTips;
					UiManager.Instance.OpenView(EUiViewName.DifficultUnlockTipView, difficultUnlockTipsData, null);
					player[num] = false;
					LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.HonamiStorySelectLvAreaUnLockTips, player);
					break;
				}
			}
		}
	}

	// Token: 0x0600C667 RID: 50791 RVA: 0x003B16EC File Offset: 0x003AF8EC
	private void TryShowHonamiTowerUnLockTips()
	{
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySelectLvTowerUnLockTips, true);
		if (this.IsOpenTower && player)
		{
			DifficultUnlockTipsData difficultUnlockTipsData = new DifficultUnlockTipsData();
			difficultUnlockTipsData.Text = "HonamiStory_LevelUnlocked_6";
			UiManager.Instance.OpenView(EUiViewName.DifficultUnlockTipView, difficultUnlockTipsData, null);
			this.TowerTog.SetRedDotShow(true);
			this.BtnGo.SetRedDotShow(true);
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySelectLvTowerUnLockTogRedDot, true);
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySelectLvTowerUnLockBtnGoRedDot, true);
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySelectLvTowerUnLockTips, false);
		}
	}

	// Token: 0x0600C668 RID: 50792 RVA: 0x003B1770 File Offset: 0x003AF970
	private void CheckHonamiTogRedDot()
	{
		if (!this.IsOpenFreeSelect)
		{
			List<HonamiStoryAreaData> honamiStoryAreaDataList = this.ActData.GetHonamiStoryAreaDataList();
			if (this.CurDangerLv <= honamiStoryAreaDataList.Count)
			{
				HonamiStoryAreaData honamiStoryAreaData = this.ActData.GetHonamiStoryAreaData(this.CurDangerLv);
				if (honamiStoryAreaData != null && honamiStoryAreaData.IsAreaCanEnter)
				{
					this.HonamiCityTog.SetRedDotShow(true);
					this.BtnGo.SetRedDotShow(true);
				}
			}
		}
	}

	// Token: 0x0600C669 RID: 50793 RVA: 0x003B17D4 File Offset: 0x003AF9D4
	private void CheckTowerFirstUnLockRedDot()
	{
		if (LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySelectLvTowerUnLockTogRedDot, false))
		{
			this.TowerTog.SetRedDotShow(true);
		}
		if (LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySelectLvTowerUnLockBtnGoRedDot, false))
		{
			this.BtnGo.SetRedDotShow(true);
		}
	}

	// Token: 0x0600C66A RID: 50794 RVA: 0x003B1808 File Offset: 0x003AFA08
	private void OnClickHelpBtn()
	{
		HelpController.Instance.OpenHelpById(437);
	}

	// Token: 0x0600C66B RID: 50795 RVA: 0x003B1819 File Offset: 0x003AFA19
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C66C RID: 50796 RVA: 0x003B1824 File Offset: 0x003AFA24
	private void OnClickLeftToggle()
	{
		ETarget? curTarget = this.CurTarget;
		ETarget etarget = ETarget.HonamiCity;
		if (!(curTarget.GetValueOrDefault() == etarget & curTarget != null))
		{
			this.SwitchTarget(ETarget.HonamiCity);
		}
	}

	// Token: 0x0600C66D RID: 50797 RVA: 0x003B1858 File Offset: 0x003AFA58
	private void OnClickRightToggle()
	{
		if (!this.IsOpenTower)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_TowerUnlockedPrompt", Array.Empty<object>());
			this.TowerTog.GetTog.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
		if (this.CurTarget.GetValueOrDefault() != ETarget.Tower)
		{
			if (LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySelectLvTowerUnLockTogRedDot, false))
			{
				this.TowerTog.SetRedDotShow(false);
				LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySelectLvTowerUnLockTogRedDot, false);
			}
			this.SwitchTarget(ETarget.Tower);
		}
	}

	// Token: 0x0600C66E RID: 50798 RVA: 0x003B18D1 File Offset: 0x003AFAD1
	private bool CanToggleChange(ETarget target)
	{
		return target != this.CurTarget.Value;
	}

	// Token: 0x0600C66F RID: 50799 RVA: 0x003B18E4 File Offset: 0x003AFAE4
	private void SwitchTarget(ETarget target)
	{
		if (target != ETarget.HonamiCity)
		{
			if (target == ETarget.Tower)
			{
				this.CurTarget = new ETarget?(ETarget.Tower);
				this.CurDangerLv = this.CurTowerDangerLv;
				this.HonamiCityTog.GetTog.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				this.TowerTog.GetTog.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				this.TargetBgPath = UiResourceConfig.Instance.GetResourcePath("HonamiSelectLvBg2");
			}
		}
		else
		{
			this.CurTarget = new ETarget?(ETarget.HonamiCity);
			this.CurDangerLv = this.CurHonamiDangerLv;
			this.HonamiCityTog.GetTog.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			this.TowerTog.GetTog.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			this.TargetBgPath = UiResourceConfig.Instance.GetResourcePath("HonamiSelectLvBg1");
		}
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.StopSequenceByKey("Switch", false, false);
		}
		LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
		if (seqPlayer2 != null)
		{
			seqPlayer2.PlayLevelSequenceByName("Switch", false, null, false);
		}
		HonamiStoryDangerLevel value = HonamiStoryConfig.Instance.GetDangerLevelConfig(this.CurDangerLv).Value;
		this.CurEnumDangerLv = new EDangerLv?((EDangerLv)value.DangerLv);
		this.RefreshLevelInfo();
		this.RefreshCurDangerLvInfo();
		ETarget? curTarget = this.CurTarget;
		ETarget etarget = ETarget.HonamiCity;
		bool flag = curTarget.GetValueOrDefault() == etarget & curTarget != null;
		this.QuestPanel.Refresh(flag);
		base.GetText(24).SetUIActive(flag);
		base.GetText(6).SetUIActive(flag);
		this.CheckBuySafeOrTowerLogShow();
		this.BtnGo.SetCostData(value.ConsumeItems());
	}

	// Token: 0x0600C670 RID: 50800 RVA: 0x003B1A7C File Offset: 0x003AFC7C
	[NullableContext(1)]
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Enter04" && !string.IsNullOrEmpty(this.TargetBgPath))
		{
			base.SetTextureByPath(this.TargetBgPath, base.GetTexture(0), null, null);
		}
	}

	// Token: 0x0600C671 RID: 50801 RVA: 0x003B1AC0 File Offset: 0x003AFCC0
	private void OnClickBtnReduce()
	{
		ETarget value = this.CurTarget.Value;
		if (value != ETarget.HonamiCity)
		{
			if (value == ETarget.Tower)
			{
				if (this.CurDangerLv <= this.MinTowerLv)
				{
					return;
				}
				this.CurDangerLv--;
				this.CurTowerDangerLv = this.CurDangerLv;
			}
		}
		else
		{
			if (this.CurDangerLv <= this.MinHonamiLv)
			{
				return;
			}
			this.CurDangerLv--;
			this.CurHonamiDangerLv = this.CurDangerLv;
		}
		HonamiStoryDangerLevel value2 = HonamiStoryConfig.Instance.GetDangerLevelConfig(this.CurDangerLv).Value;
		this.CurEnumDangerLv = new EDangerLv?((EDangerLv)value2.DangerLv);
		this.RefreshLevelInfo();
		this.RefreshCurDangerLvInfo();
		this.CheckBuySafeOrTowerLogShow();
		this.BtnGo.SetCostData(value2.ConsumeItems());
	}

	// Token: 0x0600C672 RID: 50802 RVA: 0x003B1B88 File Offset: 0x003AFD88
	private void OnClickBtnAdd()
	{
		ETarget value = this.CurTarget.Value;
		if (value != ETarget.HonamiCity)
		{
			if (value == ETarget.Tower)
			{
				if (this.CurDangerLv >= this.MaxTowerLv)
				{
					return;
				}
				this.CurDangerLv++;
				this.CurTowerDangerLv = this.CurDangerLv;
			}
		}
		else
		{
			if (this.CurDangerLv >= this.MaxHonamiLv)
			{
				return;
			}
			this.CurDangerLv++;
			this.CurHonamiDangerLv = this.CurDangerLv;
		}
		HonamiStoryDangerLevel value2 = HonamiStoryConfig.Instance.GetDangerLevelConfig(this.CurDangerLv).Value;
		this.CurEnumDangerLv = new EDangerLv?((EDangerLv)value2.DangerLv);
		this.RefreshLevelInfo();
		this.RefreshCurDangerLvInfo();
		this.CheckBuySafeOrTowerLogShow();
		this.BtnGo.SetCostData(value2.ConsumeItems());
	}

	// Token: 0x0600C673 RID: 50803 RVA: 0x003B1C4F File Offset: 0x003AFE4F
	private void OnBuySafeTogClick(EToggleState toggleState)
	{
		this.IsBuySafe = (base.GetExtendToggle(16).GetToggleState() == EToggleState.ETT_Checked);
		this.BtnGo.RefreshView();
	}

	// Token: 0x0600C674 RID: 50804 RVA: 0x003B1C74 File Offset: 0x003AFE74
	private void RefreshLevelInfo()
	{
		HonamiStoryDangerLevel? dangerLevelConfig = HonamiStoryConfig.Instance.GetDangerLevelConfig(this.CurDangerLv);
		ETarget? curTarget = this.CurTarget;
		ETarget etarget = ETarget.HonamiCity;
		if (curTarget.GetValueOrDefault() == etarget & curTarget != null)
		{
			if (FunctionModel.Instance.IsOpen(10121))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(21), "HonamiStory_FreeRegionName", Array.Empty<object>());
			}
			else
			{
				string lvSelectName = this.ActData.GetHonamiStoryAreaData(this.CurDangerLv).Config.Value.LvSelectName;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(21), lvSelectName, Array.Empty<object>());
			}
		}
		else
		{
			string towerName = this.ActData.TowerName;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(21), towerName, Array.Empty<object>());
		}
		base.GetText(5).SetText(dangerLevelConfig.Value.LvShow, true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), dangerLevelConfig.Value.FallQuaId, Array.Empty<object>());
	}

	// Token: 0x0600C675 RID: 50805 RVA: 0x003B1D8C File Offset: 0x003AFF8C
	private void CheckBuySafeOrTowerLogShow()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(16);
		UUIText text = base.GetText(17);
		UUITexture texture = base.GetTexture(18);
		UUIText text2 = base.GetText(19);
		ETarget? curTarget = this.CurTarget;
		ETarget etarget = ETarget.HonamiCity;
		if (!(curTarget.GetValueOrDefault() == etarget & curTarget != null))
		{
			extendToggle.RootUIComp.Get().SetUIActive(false);
			text.SetUIActive(true);
			texture.SetUIActive(false);
			text2.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(17), "HonamiStory_PassFloors", Array.Empty<object>());
			int maxFloorByDangerLv = this.ActData.GetMaxFloorByDangerLv(this.CurDangerLv);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(19), "HonamiStory_PassFloorsNumbers", new <>z__ReadOnlySingleElementList<object>(maxFloorByDangerLv));
			return;
		}
		if (this.IsOpenBuySafe)
		{
			extendToggle.RootUIComp.Get().SetUIActive(true);
			text.SetUIActive(true);
			texture.SetUIActive(true);
			text2.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(17), "HonamiStory_ExtractionChargeBuy", Array.Empty<object>());
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.ActData.OutCoinItemId);
			if (itemConfigData != null)
			{
				base.SetTextureByPath(itemConfigData.Icon, base.GetTexture(18), null, null);
			}
			HonamiStoryDangerLevel? dangerLevelConfig = HonamiStoryConfig.Instance.GetDangerLevelConfig(this.CurDangerLv);
			base.GetText(19).SetText(dangerLevelConfig.Value.SafeLeavePrice.ToString(), true);
			return;
		}
		extendToggle.RootUIComp.Get().SetUIActive(false);
		text.SetUIActive(true);
		texture.SetUIActive(false);
		text2.SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(17), "HonamiStory_DepartAnytime", Array.Empty<object>());
	}

	// Token: 0x0600C676 RID: 50806 RVA: 0x003B1F6C File Offset: 0x003B016C
	private void RefreshCurDangerLvInfo()
	{
		UUIButtonComponent button = base.GetButton(13);
		UUIButtonComponent button2 = base.GetButton(14);
		UUISprite sprite = base.GetSprite(12);
		UUISprite sprite2 = base.GetSprite(15);
		UUIText text = base.GetText(9);
		UUITexture texture = base.GetTexture(10);
		UUITexture texture2 = base.GetTexture(8);
		button.RootUIComp.Get().SetUIActive(this.IsOpenFreeSelect);
		button2.RootUIComp.Get().SetUIActive(this.IsOpenFreeSelect);
		sprite.SetUIActive(this.IsOpenFreeSelect);
		sprite2.SetUIActive(!this.IsOpenFreeSelect);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
		defaultInterpolatedStringHandler.AppendLiteral("RomanNum");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurDangerLv);
		string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
		if (!this.IsOpenFreeSelect)
		{
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(resourceId), sprite2, false, null, null);
		}
		else
		{
			int num = 0;
			int num2 = 0;
			ETarget value = this.CurTarget.Value;
			if (value != ETarget.HonamiCity)
			{
				if (value == ETarget.Tower)
				{
					num = this.MinTowerLv;
					num2 = this.MaxTowerLv;
				}
			}
			else
			{
				num = this.MinHonamiLv;
				num2 = this.MaxHonamiLv;
			}
			button.SetSelfInteractive(this.CurDangerLv != num);
			button2.SetSelfInteractive(this.CurDangerLv != num2);
			this.SetSpriteByPath(UiResourceConfig.Instance.GetResourcePath(resourceId), sprite, false, null, null);
		}
		string path;
		switch (this.CurEnumDangerLv.Value)
		{
		case EDangerLv.Safe:
			LguiUtil.Instance.SetLocalTextNew(text, "HonamiStory_easy", Array.Empty<object>());
			text.SetColor(HonamiStoryLevelInfoView.safeColor);
			texture.SetColor(HonamiStoryLevelInfoView.safeColor);
			path = UiResourceConfig.Instance.GetResourcePath("DangerLvBg1");
			break;
		case EDangerLv.Average:
			LguiUtil.Instance.SetLocalTextNew(text, "HonamiStory_medium", Array.Empty<object>());
			text.SetColor(HonamiStoryLevelInfoView.averageColor);
			texture.SetColor(HonamiStoryLevelInfoView.averageColor);
			path = UiResourceConfig.Instance.GetResourcePath("DangerLvBg2");
			break;
		case EDangerLv.Hard:
			LguiUtil.Instance.SetLocalTextNew(text, "HonamiStory_hard", Array.Empty<object>());
			text.SetColor(HonamiStoryLevelInfoView.hardColor);
			texture.SetColor(HonamiStoryLevelInfoView.hardColor);
			path = UiResourceConfig.Instance.GetResourcePath("DangerLvBg3");
			break;
		default:
			path = string.Empty;
			break;
		}
		base.SetTextureByPath(path, texture2, null, null);
	}

	// Token: 0x0600C677 RID: 50807 RVA: 0x003B21EE File Offset: 0x003B03EE
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		this.SeqPlayer = null;
	}

	// Token: 0x040070F6 RID: 28918
	[StaticVariableRuleIgnore]
	private static readonly FColor safeColor = FColor.FromHex("#59859C");

	// Token: 0x040070F7 RID: 28919
	[StaticVariableRuleIgnore]
	private static readonly FColor averageColor = FColor.FromHex("#6982D1");

	// Token: 0x040070F8 RID: 28920
	[StaticVariableRuleIgnore]
	private static readonly FColor hardColor = FColor.FromHex("#A04661");

	// Token: 0x040070F9 RID: 28921
	private int MinHonamiLv;

	// Token: 0x040070FA RID: 28922
	private int MaxHonamiLv;

	// Token: 0x040070FB RID: 28923
	private int MinTowerLv;

	// Token: 0x040070FC RID: 28924
	private int MaxTowerLv;

	// Token: 0x040070FD RID: 28925
	private PopupCaptionItem CaptionItem;

	// Token: 0x040070FE RID: 28926
	private HonamiStoryQuestPanel QuestPanel;

	// Token: 0x040070FF RID: 28927
	private TargetTog HonamiCityTog;

	// Token: 0x04007100 RID: 28928
	private TargetTog TowerTog;

	// Token: 0x04007101 RID: 28929
	private BtnGo BtnGo;

	// Token: 0x04007102 RID: 28930
	private PnlTeam PnlTeam;

	// Token: 0x04007103 RID: 28931
	[Nullable(1)]
	private HonamiStoryBozaiTalkPanel TalkPanel;

	// Token: 0x04007104 RID: 28932
	[Nullable(1)]
	private HonamiStoryProfitPanel PnlEnterProfit;

	// Token: 0x04007105 RID: 28933
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04007106 RID: 28934
	[Nullable(1)]
	private readonly Dictionary<int, EHonamiStoryOutDialogType> BoZaiTalkMap;

	// Token: 0x04007107 RID: 28935
	private HonamiStoryActivityData ActData;

	// Token: 0x04007108 RID: 28936
	private ETarget? CurTarget;

	// Token: 0x04007109 RID: 28937
	private int CurDangerLv;

	// Token: 0x0400710A RID: 28938
	private int CurHonamiDangerLv;

	// Token: 0x0400710B RID: 28939
	private int CurTowerDangerLv;

	// Token: 0x0400710C RID: 28940
	private bool IsBuySafe;

	// Token: 0x0400710D RID: 28941
	private EDangerLv? CurEnumDangerLv;

	// Token: 0x0400710E RID: 28942
	private bool IsOpenFreeSelect;

	// Token: 0x0400710F RID: 28943
	private bool IsOpenBuySafe;

	// Token: 0x04007110 RID: 28944
	private bool IsOpenTower;

	// Token: 0x04007111 RID: 28945
	[Nullable(1)]
	private string TargetBgPath;
}
