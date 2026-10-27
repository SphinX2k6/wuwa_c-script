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

// Token: 0x02001EC5 RID: 7877
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryLevelInfoView : UiViewBase
{
	// Token: 0x170012EB RID: 4843
	// (get) Token: 0x0600F23B RID: 62011 RVA: 0x003A5486 File Offset: 0x003A3686
	public ETarget? GetCurTarget
	{
		get
		{
			return this.CurTarget;
		}
	}

	// Token: 0x170012EC RID: 4844
	// (get) Token: 0x0600F23C RID: 62012 RVA: 0x003A548E File Offset: 0x003A368E
	public int GetCurDangerLv
	{
		get
		{
			return this.CurDangerLv;
		}
	}

	// Token: 0x170012ED RID: 4845
	// (get) Token: 0x0600F23D RID: 62013 RVA: 0x003A5496 File Offset: 0x003A3696
	public bool GetIsBuySafe
	{
		get
		{
			return this.IsBuySafe;
		}
	}

	// Token: 0x0600F23E RID: 62014 RVA: 0x003A54A0 File Offset: 0x003A36A0
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

	// Token: 0x0600F23F RID: 62015 RVA: 0x003A550C File Offset: 0x003A370C
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

	// Token: 0x0600F240 RID: 62016 RVA: 0x003A5904 File Offset: 0x003A3B04
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryLevelInfoView.<OnBeforeStartAsync>d__36 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryLevelInfoView.<OnBeforeStartAsync>d__36>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F241 RID: 62017 RVA: 0x003A5948 File Offset: 0x003A3B48
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

	// Token: 0x0600F242 RID: 62018 RVA: 0x003A59AC File Offset: 0x003A3BAC
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

	// Token: 0x0600F243 RID: 62019 RVA: 0x003A5A0D File Offset: 0x003A3C0D
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600F244 RID: 62020 RVA: 0x003A5A2B File Offset: 0x003A3C2B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600F245 RID: 62021 RVA: 0x003A5A49 File Offset: 0x003A3C49
	protected override void OnBeforeHide()
	{
		this.ActData.CurTarget = (int)this.CurTarget.Value;
		this.ActData.CurHonamiLv = this.CurHonamiDangerLv;
		this.ActData.CurTowerLv = this.CurTowerDangerLv;
	}

	// Token: 0x0600F246 RID: 62022 RVA: 0x003A5A84 File Offset: 0x003A3C84
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

	// Token: 0x0600F247 RID: 62023 RVA: 0x003A5AE0 File Offset: 0x003A3CE0
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

	// Token: 0x0600F248 RID: 62024 RVA: 0x003A5BEC File Offset: 0x003A3DEC
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

	// Token: 0x0600F249 RID: 62025 RVA: 0x003A5C70 File Offset: 0x003A3E70
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

	// Token: 0x0600F24A RID: 62026 RVA: 0x003A5CD4 File Offset: 0x003A3ED4
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

	// Token: 0x0600F24B RID: 62027 RVA: 0x003A5D08 File Offset: 0x003A3F08
	private void OnClickHelpBtn()
	{
		HelpController.Instance.OpenHelpById(437);
	}

	// Token: 0x0600F24C RID: 62028 RVA: 0x003A5D19 File Offset: 0x003A3F19
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F24D RID: 62029 RVA: 0x003A5D24 File Offset: 0x003A3F24
	private void OnClickLeftToggle()
	{
		ETarget? curTarget = this.CurTarget;
		ETarget etarget = ETarget.HonamiCity;
		if (!(curTarget.GetValueOrDefault() == etarget & curTarget != null))
		{
			this.SwitchTarget(ETarget.HonamiCity);
		}
	}

	// Token: 0x0600F24E RID: 62030 RVA: 0x003A5D58 File Offset: 0x003A3F58
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

	// Token: 0x0600F24F RID: 62031 RVA: 0x003A5DD1 File Offset: 0x003A3FD1
	private bool CanToggleChange(ETarget target)
	{
		return target != this.CurTarget.Value;
	}

	// Token: 0x0600F250 RID: 62032 RVA: 0x003A5DE4 File Offset: 0x003A3FE4
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

	// Token: 0x0600F251 RID: 62033 RVA: 0x003A5F7C File Offset: 0x003A417C
	[NullableContext(1)]
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (param == "Enter04" && !string.IsNullOrEmpty(this.TargetBgPath))
		{
			base.SetTextureByPath(this.TargetBgPath, base.GetTexture(0), null, null);
		}
	}

	// Token: 0x0600F252 RID: 62034 RVA: 0x003A5FC0 File Offset: 0x003A41C0
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

	// Token: 0x0600F253 RID: 62035 RVA: 0x003A6088 File Offset: 0x003A4288
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

	// Token: 0x0600F254 RID: 62036 RVA: 0x003A614F File Offset: 0x003A434F
	private void OnBuySafeTogClick(EToggleState toggleState)
	{
		this.IsBuySafe = (base.GetExtendToggle(16).GetToggleState() == EToggleState.ETT_Checked);
		this.BtnGo.RefreshView();
	}

	// Token: 0x0600F255 RID: 62037 RVA: 0x003A6174 File Offset: 0x003A4374
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

	// Token: 0x0600F256 RID: 62038 RVA: 0x003A628C File Offset: 0x003A448C
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

	// Token: 0x0600F257 RID: 62039 RVA: 0x003A646C File Offset: 0x003A466C
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

	// Token: 0x0600F258 RID: 62040 RVA: 0x003A66EE File Offset: 0x003A48EE
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		this.SeqPlayer = null;
	}

	// Token: 0x04007015 RID: 28693
	[StaticVariableRuleIgnore]
	private static readonly FColor safeColor = FColor.FromHex("#59859C");

	// Token: 0x04007016 RID: 28694
	[StaticVariableRuleIgnore]
	private static readonly FColor averageColor = FColor.FromHex("#6982D1");

	// Token: 0x04007017 RID: 28695
	[StaticVariableRuleIgnore]
	private static readonly FColor hardColor = FColor.FromHex("#A04661");

	// Token: 0x04007018 RID: 28696
	private int MinHonamiLv;

	// Token: 0x04007019 RID: 28697
	private int MaxHonamiLv;

	// Token: 0x0400701A RID: 28698
	private int MinTowerLv;

	// Token: 0x0400701B RID: 28699
	private int MaxTowerLv;

	// Token: 0x0400701C RID: 28700
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400701D RID: 28701
	private HonamiStoryQuestPanel QuestPanel;

	// Token: 0x0400701E RID: 28702
	private TargetTog HonamiCityTog;

	// Token: 0x0400701F RID: 28703
	private TargetTog TowerTog;

	// Token: 0x04007020 RID: 28704
	private BtnGo BtnGo;

	// Token: 0x04007021 RID: 28705
	private PnlTeam PnlTeam;

	// Token: 0x04007022 RID: 28706
	[Nullable(1)]
	private HonamiStoryBozaiTalkPanel TalkPanel;

	// Token: 0x04007023 RID: 28707
	[Nullable(1)]
	private HonamiStoryProfitPanel PnlEnterProfit;

	// Token: 0x04007024 RID: 28708
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04007025 RID: 28709
	[Nullable(1)]
	private readonly Dictionary<int, EHonamiStoryOutDialogType> BoZaiTalkMap;

	// Token: 0x04007026 RID: 28710
	private HonamiStoryActivityData ActData;

	// Token: 0x04007027 RID: 28711
	private ETarget? CurTarget;

	// Token: 0x04007028 RID: 28712
	private int CurDangerLv;

	// Token: 0x04007029 RID: 28713
	private int CurHonamiDangerLv;

	// Token: 0x0400702A RID: 28714
	private int CurTowerDangerLv;

	// Token: 0x0400702B RID: 28715
	private bool IsBuySafe;

	// Token: 0x0400702C RID: 28716
	private EDangerLv? CurEnumDangerLv;

	// Token: 0x0400702D RID: 28717
	private bool IsOpenFreeSelect;

	// Token: 0x0400702E RID: 28718
	private bool IsOpenBuySafe;

	// Token: 0x0400702F RID: 28719
	private bool IsOpenTower;

	// Token: 0x04007030 RID: 28720
	[Nullable(1)]
	private string TargetBgPath;
}
