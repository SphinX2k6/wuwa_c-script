using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02005ED2 RID: 24274
	[NullableContext(1)]
	[Nullable(0)]
	public class NewSoundAreaView : UiTabViewBase
	{
		// Token: 0x0603DB4C RID: 252748 RVA: 0x00EE5ED8 File Offset: 0x00EE40D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 33;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnClickLordGymBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603DB4D RID: 252749 RVA: 0x00EE6397 File Offset: 0x00EE4597
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RedDotAdventureSecondaryUpdate, new Action<int>(this.OnRedDotAdventureSecondaryUpdate));
		}

		// Token: 0x0603DB4E RID: 252750 RVA: 0x00EE63B5 File Offset: 0x00EE45B5
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RedDotAdventureSecondaryUpdate, new Action<int>(this.OnRedDotAdventureSecondaryUpdate));
		}

		// Token: 0x0603DB4F RID: 252751 RVA: 0x00EE63D4 File Offset: 0x00EE45D4
		private void OnRedDotAdventureSecondaryUpdate(int secondary)
		{
			if (this.TypeList == null)
			{
				return;
			}
			for (int i = 0; i < this.TypeList.Count; i++)
			{
				if (this.TypeList[i] == secondary)
				{
					MultiTemplateScrollView typeScroll = this.TypeScroll;
					NewSoundTypeItem newSoundTypeItem = ((typeScroll != null) ? typeScroll.GetProxyByGridIndex(i) : null) as NewSoundTypeItem;
					if (newSoundTypeItem != null)
					{
						newSoundTypeItem.RefreshRedDotState();
					}
				}
			}
		}

		// Token: 0x0603DB50 RID: 252752 RVA: 0x00EE6432 File Offset: 0x00EE4632
		private void OnRoleDevTargetRoleIdChange()
		{
			if (this.HasRoleDevTab)
			{
				MultiTemplateScrollView typeScroll = this.TypeScroll;
				if (typeScroll != null)
				{
					typeScroll.RefreshProxyDirectly(0);
				}
			}
			RoleDevelopOverviewPanel roleDevelopPanel = this.RoleDevelopPanel;
			if (roleDevelopPanel != null)
			{
				roleDevelopPanel.RefreshView(true);
			}
			if (this.CurrentType != (EDungeonType)(-1))
			{
				this.BuildDungeonList();
			}
		}

		// Token: 0x0603DB51 RID: 252753 RVA: 0x00EE6470 File Offset: 0x00EE4670
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer startLevelSequencePlayer = this.StartLevelSequencePlayer;
			if (startLevelSequencePlayer != null)
			{
				startLevelSequencePlayer.Clear();
			}
			this.StartLevelSequencePlayer = null;
			LevelSequencePlayer switchLevelSequencePlayer = this.SwitchLevelSequencePlayer;
			if (switchLevelSequencePlayer != null)
			{
				switchLevelSequencePlayer.Clear();
			}
			this.SwitchLevelSequencePlayer = null;
			CommonDropDown<int, int> suitDropDown = this.SuitDropDown;
			if (suitDropDown != null)
			{
				suitDropDown.Destroy(null);
			}
			CommonDropDown<int, int> weaponDropDown = this.WeaponDropDown;
			if (weaponDropDown != null)
			{
				weaponDropDown.Destroy(null);
			}
			CommonDropDown<TableTextArgNew, int> levelDropDown = this.LevelDropDown;
			if (levelDropDown != null)
			{
				levelDropDown.Destroy(null);
			}
			EventSystem.Instance.Remove(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
		}

		// Token: 0x0603DB52 RID: 252754 RVA: 0x00EE64FF File Offset: 0x00EE46FF
		private OneTextTitleItem CreateLevelTitleItem(UUIItem uiItem)
		{
			return new OneTextTitleItem(uiItem);
		}

		// Token: 0x0603DB53 RID: 252755 RVA: 0x00EE6507 File Offset: 0x00EE4707
		private OneTextDropDownItem CreateLevelDropDownItem(UUIItem uiItem, int data)
		{
			return new OneTextDropDownItem(uiItem);
		}

		// Token: 0x0603DB54 RID: 252756 RVA: 0x00EE650F File Offset: 0x00EE470F
		private NewSoundSuitDropDownTitle CreateSuitTitleItem(UUIItem uiItem)
		{
			return new NewSoundSuitDropDownTitle(uiItem);
		}

		// Token: 0x0603DB55 RID: 252757 RVA: 0x00EE6517 File Offset: 0x00EE4717
		private NewSoundSuitDropDownItem CreateSuitDropDownItem(UUIItem uiItem, int data)
		{
			return new NewSoundSuitDropDownItem(uiItem);
		}

		// Token: 0x0603DB56 RID: 252758 RVA: 0x00EE651F File Offset: 0x00EE471F
		private WeaponTitleItem CreateWeaponTitleItem(UUIItem uiItem)
		{
			return new WeaponTitleItem(uiItem);
		}

		// Token: 0x0603DB57 RID: 252759 RVA: 0x00EE6527 File Offset: 0x00EE4727
		private NewSoundWeaponDropDownItem CreateWeaponDropDownItem(UUIItem uiItem, int data)
		{
			return new NewSoundWeaponDropDownItem(uiItem);
		}

		// Token: 0x0603DB58 RID: 252760 RVA: 0x00EE6530 File Offset: 0x00EE4730
		protected override UniTask OnBeforeStartAsync()
		{
			NewSoundAreaView.<OnBeforeStartAsync>d__41 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NewSoundAreaView.<OnBeforeStartAsync>d__41>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603DB59 RID: 252761 RVA: 0x00EE6574 File Offset: 0x00EE4774
		protected override void OnStart()
		{
			Action<int, UUIExtendToggle> typeToggleFunc = delegate(int currentType, UUIExtendToggle toggle)
			{
				if (this.CurrentType == EDungeonType.Tutorial || this.CurrentType == EDungeonType.SkillTeach)
				{
					foreach (SoundAreaDetectionRecord soundAreaDetectionRecord in AdventureGuideModel.Instance.GetCanShowDungeonRecordsByType(this.CurrentType, null, true).Item2)
					{
						AdventureGuideModel.Instance.SetRoleTutorialNew(soundAreaDetectionRecord.Id);
					}
				}
				this.CurrentType = (EDungeonType)currentType;
				this.HasUserSelectedType = true;
				if (currentType == -1)
				{
					RegressPanel regressPanel = this.RegressPanel;
					if (regressPanel != null)
					{
						regressPanel.SetUiActive(false);
					}
					this.CurrentDropDownType = EDetectionDropDownType.None;
					this.RefreshCommonDropDown();
					UUIExtendToggle currentSelectedToggle = this.CurrentSelectedToggle;
					if (currentSelectedToggle != null)
					{
						currentSelectedToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
					}
					this.CurrentSelectedToggle = toggle;
					this.RefreshDungeonType();
					UUIItem item = base.GetItem(26);
					if (item != null)
					{
						item.SetUIActive(false);
					}
					UUIItem item2 = base.GetItem(31);
					if (item2 != null)
					{
						item2.SetUIActive(true);
					}
					RoleDevelopOverviewPanel roleDevelopPanel = this.RoleDevelopPanel;
					if (roleDevelopPanel != null)
					{
						roleDevelopPanel.RefreshView(false);
					}
					UUIItem item3 = base.GetItem(16);
					if (item3 != null)
					{
						item3.SetUIActive(false);
					}
					LevelSequencePlayer switchLevelSequencePlayer = this.SwitchLevelSequencePlayer;
					if (((switchLevelSequencePlayer != null) ? switchLevelSequencePlayer.GetCurrentSequence() : null) == null)
					{
						LevelSequencePlayer switchLevelSequencePlayer2 = this.SwitchLevelSequencePlayer;
						if (switchLevelSequencePlayer2 == null)
						{
							return;
						}
						switchLevelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
						return;
					}
					else
					{
						LevelSequencePlayer switchLevelSequencePlayer3 = this.SwitchLevelSequencePlayer;
						if (switchLevelSequencePlayer3 == null)
						{
							return;
						}
						switchLevelSequencePlayer3.ReplaySequenceByKey("Switch");
						return;
					}
				}
				else
				{
					UUIItem item4 = base.GetItem(31);
					if (item4 != null)
					{
						item4.SetUIActive(false);
					}
					List<EAdventurePreOpenPlayType> playerType = AdventureGuideController.Instance.GetPlayerType();
					bool flag;
					if (!playerType.Contains(EAdventurePreOpenPlayType.Regress) && !playerType.Contains(EAdventurePreOpenPlayType.Beginner))
					{
						RegressPanel regressPanel2 = this.RegressPanel;
						if (regressPanel2 == null || !regressPanel2.CanShowV2Activity())
						{
							flag = false;
							goto IL_1B2;
						}
					}
					flag = (this.CurrentType == EDungeonType.NoSoundArea);
					IL_1B2:
					bool uiActive = flag;
					RegressPanel regressPanel3 = this.RegressPanel;
					if (regressPanel3 != null)
					{
						regressPanel3.SetUiActive(uiActive);
					}
					SecondaryGuideData value = AdventureGuideConfig.Instance.GetSecondaryGuideDataConf(currentType).Value;
					this.CurrentDropDownType = (EDetectionDropDownType)value.DropDownTypeId;
					this.RefreshCommonDropDown();
					UUIExtendToggle currentSelectedToggle2 = this.CurrentSelectedToggle;
					if (currentSelectedToggle2 != null)
					{
						currentSelectedToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
					}
					this.CurrentSelectedToggle = toggle;
					EventSystem.Instance.Emit<int>(EEventName.AdventureHelpBtn, value.HelpGroupId);
					this.HelpId = value.HelpGroupId;
					this.RefreshDungeonType();
					if (this.CurrentDropDownType != EDetectionDropDownType.Suit && this.CurrentDropDownType != EDetectionDropDownType.Weapon)
					{
						this.BuildDungeonList();
					}
					if (this.CurrentDropDownType == EDetectionDropDownType.Level)
					{
						this.LevelDropDownCall(AdventureGuideModel.Instance.CurrentShowLevel);
					}
					else if (this.CurrentDropDownType == EDetectionDropDownType.Suit)
					{
						if (AdventureGuideModel.Instance.HandleShowNightMareParam != 0 || this.IsNavigationJumpToGrid)
						{
							AdventureGuideModel.Instance.CurrentSelectSuitIndex = 0;
							CommonDropDown<int, int> suitDropDown = this.SuitDropDown;
							if (suitDropDown != null)
							{
								suitDropDown.SetSelectedIndex(0, true);
							}
						}
						this.SuitDropDownCall(AdventureGuideModel.Instance.CurrentSelectSuitIndex);
					}
					else if (this.CurrentDropDownType == EDetectionDropDownType.Weapon)
					{
						this.WeaponDropDownCall(this.CurrentSelectWeaponIndex);
					}
					this.IsNavigationJumpToGrid = false;
					LevelSequencePlayer switchLevelSequencePlayer4 = this.SwitchLevelSequencePlayer;
					if (((switchLevelSequencePlayer4 != null) ? switchLevelSequencePlayer4.GetCurrentSequence() : null) == null)
					{
						LevelSequencePlayer switchLevelSequencePlayer5 = this.SwitchLevelSequencePlayer;
						if (switchLevelSequencePlayer5 != null)
						{
							switchLevelSequencePlayer5.PlayLevelSequenceByName("Switch", false, null, false);
						}
					}
					else
					{
						LevelSequencePlayer switchLevelSequencePlayer6 = this.SwitchLevelSequencePlayer;
						if (switchLevelSequencePlayer6 != null)
						{
							switchLevelSequencePlayer6.ReplaySequenceByKey("Switch");
						}
					}
					ActivityDoubleRewardData adventureUpActivity = ActivityDoubleRewardController.Instance.GetAdventureUpActivity(this.CurrentType);
					if (adventureUpActivity != null)
					{
						base.GetItem(16).SetUIActive(true);
						ValueTuple<string, int, int> numTxtAndParam = adventureUpActivity.GetNumTxtAndParam();
						LguiUtil.Instance.SetLocalTextNew(base.GetText(23), (numTxtAndParam.Item2 > 0) ? "Reward_doubling_tips" : "Reward_doubling_end_tips", new <>z__ReadOnlyArray<object>(new object[]
						{
							numTxtAndParam.Item2,
							numTxtAndParam.Item3
						}));
						base.GetText(17).SetUIActive(false);
						return;
					}
					ValueTuple<bool, int, int, string, string> detectionDoubleDropTuple = ActivityRegressModel.Instance.GetDetectionDoubleDropTuple(this.CurrentType);
					bool item5 = detectionDoubleDropTuple.Item1;
					int item6 = detectionDoubleDropTuple.Item2;
					int item7 = detectionDoubleDropTuple.Item3;
					string item8 = detectionDoubleDropTuple.Item4;
					string item9 = detectionDoubleDropTuple.Item5;
					if (item5)
					{
						LguiUtil.Instance.SetLocalTextNew(base.GetText(17), item8, new <>z__ReadOnlyArray<object>(new object[]
						{
							item6,
							item7
						}));
						LguiUtil.Instance.SetLocalTextNew(base.GetText(23), item9, Array.Empty<object>());
						base.GetText(17).SetUIActive(true);
					}
					base.GetItem(16).SetUIActive(item5);
					return;
				}
			};
			Func<int, bool> typeCanToggleChange = (int currentType) => this.CurrentType != (EDungeonType)currentType;
			this.TypeToggleFunc = typeToggleFunc;
			this.TypeCanToggleChange = typeCanToggleChange;
			this.TypeScroll = new MultiTemplateScrollView(base.GetMultiTemplateScrollViewComponent(1));
			this.SoundAreaScroll = new MultiTemplateScrollView(base.GetMultiTemplateScrollViewComponent(24));
			foreach (PhantomFetterGroup phantomFetterGroup in PhantomBattleConfig.Instance.GetFetterGroupArray())
			{
				this.FetterSuitFilterArray.Add(phantomFetterGroup.Id);
			}
			this.FetterSuitFilterArray.Sort((int a, int b) => a - b);
			this.FetterSuitFilterArray.Insert(0, 0);
			this.SuitDropDown.SetOnSelectCall(new Action<int, int>(this.OnSuitDropDownSelectCall));
			this.SuitDropDown.SetShowType(ECommonDropDownShowType.Down);
			this.SuitDropDown.InitScroll(this.FetterSuitFilterArray, new Func<int, int>(this.GetSuitDropDownTextId), this.FetterSuitFilterArray.IndexOf(AdventureGuideModel.Instance.CurrentSelectSuitIndex), false);
			IReadOnlyList<Mapping> weaponConfList = MappingConfig.Instance.GetWeaponConfList();
			if (weaponConfList != null)
			{
				foreach (Mapping mapping in weaponConfList)
				{
					this.WeaponFilterArray.Add(mapping.Value);
				}
			}
			this.WeaponFilterArray.Sort((int a, int b) => a - b);
			this.WeaponFilterArray.Insert(0, 0);
			this.WeaponDropDown.SetOnSelectCall(new Action<int, int>(this.OnWeaponDropDownSelectCall));
			this.WeaponDropDown.SetShowType(ECommonDropDownShowType.Down);
			this.WeaponDropDown.InitScroll(this.WeaponFilterArray, new Func<int, int>(this.GetWeaponDropDownTextId), 0, false);
			this.DefaultDropDownSelectIndex = WorldLevelModel.Instance.CurWorldLevel - 1;
			List<int> list = new List<int>();
			for (int i = 1; i <= 8; i++)
			{
				list.Add(i);
			}
			this.LevelDropDown.SetOnSelectCall(new Action<int, int>(this.OnLevelDropDownSelectCall));
			this.LevelDropDown.SetShowType(ECommonDropDownShowType.Down);
			this.LevelDropDown.InitScroll(list, new Func<int, TableTextArgNew>(this.GetLevelDropDownTextId), this.DefaultDropDownSelectIndex, false);
			AdventureGuideModel.Instance.CurrentShowLevel = WorldLevelModel.Instance.CurWorldLevel;
			this.TypeList = AdventureGuideModel.Instance.GetAllCanShowDungeonTypeList(new EUiTabViewName?((EUiTabViewName)base.GetViewName()), true);
			this.StartLevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SwitchLevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.InitNavigationParam();
			EventSystem.Instance.Add(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
		}

		// Token: 0x0603DB5A RID: 252762 RVA: 0x00EE686C File Offset: 0x00EE4A6C
		private void InitNavigationParam()
		{
			AdventureGuideViewOpenData adventureGuideViewOpenData = this.ExtraParams as AdventureGuideViewOpenData;
			bool flag = ((adventureGuideViewOpenData != null) ? adventureGuideViewOpenData.OpenTabViewName : null) == EUiTabViewName.NewSoundAreaView;
			int? num = flag ? adventureGuideViewOpenData.OpenParam : new int?(0);
			this.JumpToGridId = (flag ? adventureGuideViewOpenData.JumpToGridId : null);
			int? num2 = num;
			int num3 = 0;
			if ((num2.GetValueOrDefault() > num3 & num2 != null) || this.JumpToGridId != null)
			{
				this.IsNavigationJumpToGrid = true;
			}
		}

		// Token: 0x0603DB5B RID: 252763 RVA: 0x00EE6918 File Offset: 0x00EE4B18
		private void RefreshSoundAreaScroll(List<IMultiTemplateGridData> dataList)
		{
			int jumpGridIndex = this.GetJumpGridIndex(dataList);
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(dataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = jumpGridIndex;
			MultiTemplateScrollView soundAreaScroll = this.SoundAreaScroll;
			if (soundAreaScroll == null)
			{
				return;
			}
			soundAreaScroll.RefreshByData(multiTemplateScrollViewRefreshContext);
		}

		// Token: 0x0603DB5C RID: 252764 RVA: 0x00EE694C File Offset: 0x00EE4B4C
		private int GetJumpGridIndex(List<IMultiTemplateGridData> dataList)
		{
			if (!this.IsNavigationJumpToGrid || this.JumpToGridId == null)
			{
				return 0;
			}
			int num = dataList.FindIndex(delegate(IMultiTemplateGridData d)
			{
				NewSoundDetectTabItemData newSoundDetectTabItemData = d.Data as NewSoundDetectTabItemData;
				int? num2;
				if (newSoundDetectTabItemData == null)
				{
					num2 = null;
				}
				else
				{
					NewSoundDetectItemData dungeon = newSoundDetectTabItemData.Dungeon;
					if (dungeon == null)
					{
						num2 = null;
					}
					else
					{
						SoundAreaDetectionRecord detectRecordData = dungeon.DetectRecordData;
						num2 = ((detectRecordData != null) ? new int?(detectRecordData.Id) : null);
					}
				}
				int? num3 = num2;
				int value = this.JumpToGridId.Value;
				return num3.GetValueOrDefault() == value & num3 != null;
			});
			if (num < 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x0603DB5D RID: 252765 RVA: 0x00EE698C File Offset: 0x00EE4B8C
		private void LevelDropDownCall(int index)
		{
			AdventureGuideModel.Instance.CurrentShowLevel = index;
			EventSystem.Instance.Emit<int>(EEventName.NewSoundAreaRefreshReward, index);
			LevelSequencePlayer switchLevelSequencePlayer = this.SwitchLevelSequencePlayer;
			if (((switchLevelSequencePlayer != null) ? switchLevelSequencePlayer.GetCurrentSequence() : null) == null)
			{
				LevelSequencePlayer switchLevelSequencePlayer2 = this.SwitchLevelSequencePlayer;
				if (switchLevelSequencePlayer2 == null)
				{
					return;
				}
				switchLevelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer switchLevelSequencePlayer3 = this.SwitchLevelSequencePlayer;
				if (switchLevelSequencePlayer3 == null)
				{
					return;
				}
				switchLevelSequencePlayer3.ReplaySequenceByKey("Switch");
				return;
			}
		}

		// Token: 0x0603DB5E RID: 252766 RVA: 0x00EE6A00 File Offset: 0x00EE4C00
		private void SuitDropDownCall(int index)
		{
			AdventureGuideModel.Instance.CurrentSelectSuitIndex = index;
			this.BuildListBySuitData();
			LevelSequencePlayer switchLevelSequencePlayer = this.SwitchLevelSequencePlayer;
			if (((switchLevelSequencePlayer != null) ? switchLevelSequencePlayer.GetCurrentSequence() : null) == null)
			{
				LevelSequencePlayer switchLevelSequencePlayer2 = this.SwitchLevelSequencePlayer;
				if (switchLevelSequencePlayer2 == null)
				{
					return;
				}
				switchLevelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer switchLevelSequencePlayer3 = this.SwitchLevelSequencePlayer;
				if (switchLevelSequencePlayer3 == null)
				{
					return;
				}
				switchLevelSequencePlayer3.ReplaySequenceByKey("Switch");
				return;
			}
		}

		// Token: 0x0603DB5F RID: 252767 RVA: 0x00EE6A68 File Offset: 0x00EE4C68
		private void OnLevelDropDownSelectCall(int index, int data)
		{
			this.LevelDropDownCall(data);
		}

		// Token: 0x0603DB60 RID: 252768 RVA: 0x00EE6A71 File Offset: 0x00EE4C71
		private void OnSuitDropDownSelectCall(int index, int data)
		{
			this.SuitDropDownCall(data);
		}

		// Token: 0x0603DB61 RID: 252769 RVA: 0x00EE6A7A File Offset: 0x00EE4C7A
		private TableTextArgNew GetLevelDropDownTextId(int data)
		{
			return new TableTextArgNew((data == WorldLevelModel.Instance.CurWorldLevel) ? "Text_WorldCurrentLevelTag_Text" : "Text_WorldLevelTag_Text", new <>z__ReadOnlySingleElementList<object>(data));
		}

		// Token: 0x0603DB62 RID: 252770 RVA: 0x00EE6AA5 File Offset: 0x00EE4CA5
		private int GetSuitDropDownTextId(int data)
		{
			return data;
		}

		// Token: 0x0603DB63 RID: 252771 RVA: 0x00EE6AA8 File Offset: 0x00EE4CA8
		private void WeaponDropDownCall(int weaponId)
		{
			this.CurrentSelectWeaponIndex = weaponId;
			this.BuildListByWeaponData();
			LevelSequencePlayer switchLevelSequencePlayer = this.SwitchLevelSequencePlayer;
			if (((switchLevelSequencePlayer != null) ? switchLevelSequencePlayer.GetCurrentSequence() : null) == null)
			{
				LevelSequencePlayer switchLevelSequencePlayer2 = this.SwitchLevelSequencePlayer;
				if (switchLevelSequencePlayer2 == null)
				{
					return;
				}
				switchLevelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer switchLevelSequencePlayer3 = this.SwitchLevelSequencePlayer;
				if (switchLevelSequencePlayer3 == null)
				{
					return;
				}
				switchLevelSequencePlayer3.ReplaySequenceByKey("Switch");
				return;
			}
		}

		// Token: 0x0603DB64 RID: 252772 RVA: 0x00EE6B0C File Offset: 0x00EE4D0C
		private void OnWeaponDropDownSelectCall(int index, int data)
		{
			this.WeaponDropDownCall(data);
		}

		// Token: 0x0603DB65 RID: 252773 RVA: 0x00EE6B15 File Offset: 0x00EE4D15
		private int GetWeaponDropDownTextId(int data)
		{
			return data;
		}

		// Token: 0x0603DB66 RID: 252774 RVA: 0x00EE6B18 File Offset: 0x00EE4D18
		private void BuildDungeonList()
		{
			ValueTuple<bool, List<SoundAreaDetectionRecord>> canShowDungeonRecordsByType = AdventureGuideModel.Instance.GetCanShowDungeonRecordsByType(this.CurrentType, null, true);
			bool item = canShowDungeonRecordsByType.Item1;
			List<SoundAreaDetectionRecord> item2 = canShowDungeonRecordsByType.Item2;
			if (!item)
			{
				this.BuildDungeonNormalList(item2.ToList<SoundAreaDetectionRecord>());
			}
			else
			{
				this.BuildDungeonTabList(item2.ToList<SoundAreaDetectionRecord>());
			}
			this.CurrentData = null;
		}

		// Token: 0x0603DB67 RID: 252775 RVA: 0x00EE6B70 File Offset: 0x00EE4D70
		private void BuildDungeonNormalList(List<SoundAreaDetectionRecord> records)
		{
			NewSoundAreaView.<>c__DisplayClass56_0 CS$<>8__locals1 = new NewSoundAreaView.<>c__DisplayClass56_0();
			int count = records.Count;
			base.GetItem(26).SetUIActive(true);
			if (count != 0)
			{
				NewSoundAreaView.<>c__DisplayClass56_0 CS$<>8__locals2 = CS$<>8__locals1;
				AdventureGuideViewOpenData currentData = this.CurrentData;
				CS$<>8__locals2.currentTracingId = ((currentData != null) ? currentData.NewSoundDetectTracingIdList : null);
				List<SoundAreaDetectionRecord> list = records.OrderByDescending(delegate(SoundAreaDetectionRecord r)
				{
					int[] currentTracingId2 = CS$<>8__locals1.currentTracingId;
					return currentTracingId2 != null && currentTracingId2.Contains(r.Id);
				}).ToList<SoundAreaDetectionRecord>();
				List<IMultiTemplateGridData> list2 = new List<IMultiTemplateGridData>();
				int cycleId = WeeklyRogueModel.Instance.CycleId;
				for (int i = 0; i < count; i++)
				{
					SoundAreaDetectionRecord soundAreaDetectionRecord = list[i];
					if (soundAreaDetectionRecord == null || soundAreaDetectionRecord.Secondary != 29 || cycleId != 0)
					{
						NewSoundDetectItemData newSoundDetectItemData = new NewSoundDetectItemData();
						newSoundDetectItemData.DetectRecordData = list[i];
						NewSoundDetectItemData newSoundDetectItemData2 = newSoundDetectItemData;
						int[] currentTracingId = CS$<>8__locals1.currentTracingId;
						newSoundDetectItemData2.TracingList = ((currentTracingId != null) ? currentTracingId.ToList<int>() : null);
						newSoundDetectItemData.JumpToGridId = (this.IsNavigationJumpToGrid ? this.JumpToGridId : new int?(0));
						newSoundDetectItemData.JumpToGridSquenceStartTimeSecond = new double?(0.0);
						list2.Add(new NewSoundDetectTabItemDungeonData(new NewSoundDetectTabItemData
						{
							Dungeon = newSoundDetectItemData
						}));
					}
				}
				this.ScrollDataList = list2;
				this.RefreshSoundAreaScroll(list2);
				return;
			}
			MultiTemplateScrollViewRefreshContext context = new MultiTemplateScrollViewRefreshContext(new List<IMultiTemplateGridData>());
			MultiTemplateScrollView soundAreaScroll = this.SoundAreaScroll;
			if (soundAreaScroll == null)
			{
				return;
			}
			soundAreaScroll.RefreshByData(context);
		}

		// Token: 0x0603DB68 RID: 252776 RVA: 0x00EE6CBC File Offset: 0x00EE4EBC
		private void BuildDungeonTabList(List<SoundAreaDetectionRecord> records)
		{
			NewSoundAreaView.<>c__DisplayClass57_0 CS$<>8__locals1 = new NewSoundAreaView.<>c__DisplayClass57_0();
			base.GetItem(26).SetUIActive(true);
			Dictionary<int, IMultiTemplateGridData> dictionary = new Dictionary<int, IMultiTemplateGridData>();
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			NewSoundAreaView.<>c__DisplayClass57_0 CS$<>8__locals2 = CS$<>8__locals1;
			AdventureGuideViewOpenData currentData = this.CurrentData;
			CS$<>8__locals2.currentTracingId = ((currentData != null) ? currentData.NewSoundDetectTracingIdList : null);
			int handleShowNightMareParam = AdventureGuideModel.Instance.HandleShowNightMareParam;
			AdventureGuideModel.Instance.HandleShowNightMareParam = 0;
			List<SoundAreaDetectionRecord> list2 = records.OrderByDescending(delegate(SoundAreaDetectionRecord r)
			{
				int[] currentTracingId3 = CS$<>8__locals1.currentTracingId;
				return currentTracingId3 != null && currentTracingId3.Contains(r.Id);
			}).ToList<SoundAreaDetectionRecord>();
			List<SoundAreaDetectionRecord> list3 = new List<SoundAreaDetectionRecord>();
			List<SoundAreaDetectionRecord> list4 = new List<SoundAreaDetectionRecord>();
			foreach (SoundAreaDetectionRecord soundAreaDetectionRecord in list2)
			{
				if (AdventureGuideModel.Instance.GetIsDetectionPreOpenByData(soundAreaDetectionRecord))
				{
					list3.Add(soundAreaDetectionRecord);
				}
				else
				{
					list4.Add(soundAreaDetectionRecord);
				}
			}
			if (list3.Count > 0)
			{
				NewSoundDetectPreOpenTitleData newSoundDetectPreOpenTitleData = new NewSoundDetectPreOpenTitleData(new NewSoundDetectTabItemData
				{
					Area = -1,
					TabTextId = "AdventurePreOpenTab",
					IconPath = "",
					Sort = 9999,
					IsVisible = true
				});
				newSoundDetectPreOpenTitleData.OnClickCallBack = new Action<int, bool>(this.OnClickNewSoundDetectTabItemTitleItemCallBack);
				dictionary[-1] = newSoundDetectPreOpenTitleData;
				list.Add(newSoundDetectPreOpenTitleData);
				foreach (SoundAreaDetectionRecord soundAreaDetectionRecord2 in list3)
				{
					NewSoundDetectItemData newSoundDetectItemData = new NewSoundDetectItemData();
					newSoundDetectItemData.DetectRecordData = soundAreaDetectionRecord2;
					NewSoundDetectItemData newSoundDetectItemData2 = newSoundDetectItemData;
					int[] currentTracingId = CS$<>8__locals1.currentTracingId;
					newSoundDetectItemData2.TracingList = ((currentTracingId != null) ? currentTracingId.ToList<int>() : null);
					newSoundDetectItemData.NightMareParam = new int?(handleShowNightMareParam);
					newSoundDetectItemData.JumpToGridId = (this.IsNavigationJumpToGrid ? this.JumpToGridId : new int?(0));
					newSoundDetectItemData.JumpToGridSquenceStartTimeSecond = new double?(0.0);
					NewSoundDetectTabItemData newSoundDetectTabItemData = new NewSoundDetectTabItemData();
					newSoundDetectTabItemData.Area = -1;
					newSoundDetectTabItemData.Dungeon = newSoundDetectItemData;
					newSoundDetectTabItemData.Sort = 9999;
					newSoundDetectTabItemData.IsVisible = true;
					dictionary[soundAreaDetectionRecord2.Id] = new NewSoundDetectTabItemDungeonData(newSoundDetectTabItemData);
					list.Add(dictionary[soundAreaDetectionRecord2.Id]);
				}
			}
			foreach (SoundAreaDetectionRecord soundAreaDetectionRecord3 in list4)
			{
				int num;
				if (soundAreaDetectionRecord3.DungeonDetectionRecord == null)
				{
					SilentAreaDetectionRecord silentAreaDetectionRecord = soundAreaDetectionRecord3.SilentAreaDetectionRecord;
					num = ((silentAreaDetectionRecord != null) ? silentAreaDetectionRecord.Conf.DetectionTabType : 0);
				}
				else
				{
					num = soundAreaDetectionRecord3.DungeonDetectionRecord.Conf.DetectionTabType;
				}
				int num2 = num;
				if (num2 != 0)
				{
					if (!dictionary.ContainsKey(num2))
					{
						DetectionTabType? config = ConfigDetectionTabTypeById.GetConfig(num2, true);
						if (config == null)
						{
							continue;
						}
						NewSoundDetectTabItemTitleData newSoundDetectTabItemTitleData = new NewSoundDetectTabItemTitleData(new NewSoundDetectTabItemData
						{
							Area = num2,
							TabTextId = config.Value.Text,
							IconPath = config.Value.Icon,
							Sort = config.Value.Order,
							IsVisible = true
						});
						newSoundDetectTabItemTitleData.OnClickCallBack = new Action<int, bool>(this.OnClickNewSoundDetectTabItemTitleItemCallBack);
						dictionary[num2] = newSoundDetectTabItemTitleData;
						list.Add(newSoundDetectTabItemTitleData);
					}
					int sort = ((NewSoundDetectTabItemData)dictionary[num2].Data).Sort;
					NewSoundDetectItemData newSoundDetectItemData3 = new NewSoundDetectItemData();
					newSoundDetectItemData3.DetectRecordData = soundAreaDetectionRecord3;
					NewSoundDetectItemData newSoundDetectItemData4 = newSoundDetectItemData3;
					int[] currentTracingId2 = CS$<>8__locals1.currentTracingId;
					newSoundDetectItemData4.TracingList = ((currentTracingId2 != null) ? currentTracingId2.ToList<int>() : null);
					newSoundDetectItemData3.NightMareParam = new int?(handleShowNightMareParam);
					newSoundDetectItemData3.JumpToGridId = (this.IsNavigationJumpToGrid ? this.JumpToGridId : new int?(0));
					newSoundDetectItemData3.JumpToGridSquenceStartTimeSecond = new double?(0.0);
					NewSoundDetectTabItemDungeonData newSoundDetectTabItemDungeonData = new NewSoundDetectTabItemDungeonData(new NewSoundDetectTabItemData
					{
						Area = num2,
						Dungeon = newSoundDetectItemData3,
						Sort = sort,
						IsVisible = true
					});
					dictionary[(soundAreaDetectionRecord3.DungeonDetectionRecord != null) ? soundAreaDetectionRecord3.DungeonDetectionRecord.Conf.Id : soundAreaDetectionRecord3.SilentAreaDetectionRecord.Conf.Id] = newSoundDetectTabItemDungeonData;
					list.Add(newSoundDetectTabItemDungeonData);
				}
			}
			this.ScrollDataList = (from d in list
			orderby ((NewSoundDetectTabItemData)d.Data).Sort descending
			select d).ToList<IMultiTemplateGridData>();
			this.RefreshSoundAreaScroll(this.ScrollDataList);
		}

		// Token: 0x0603DB69 RID: 252777 RVA: 0x00EE717C File Offset: 0x00EE537C
		private void OnClickNewSoundDetectTabItemTitleItemCallBack(int area, bool isVisible)
		{
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			foreach (IMultiTemplateGridData multiTemplateGridData in this.ScrollDataList)
			{
				NewSoundDetectTabItemData newSoundDetectTabItemData = multiTemplateGridData.Data as NewSoundDetectTabItemData;
				if (newSoundDetectTabItemData.Area != area)
				{
					if (newSoundDetectTabItemData.IsVisible || newSoundDetectTabItemData.TabTextId != "")
					{
						list.Add(multiTemplateGridData);
					}
				}
				else
				{
					newSoundDetectTabItemData.IsVisible = isVisible;
					if (isVisible)
					{
						list.Add(multiTemplateGridData);
					}
					else if (newSoundDetectTabItemData.TabTextId != "")
					{
						list.Add(multiTemplateGridData);
					}
				}
			}
			MultiTemplateScrollViewRefreshContext context = new MultiTemplateScrollViewRefreshContext(list);
			MultiTemplateScrollView soundAreaScroll = this.SoundAreaScroll;
			if (soundAreaScroll == null)
			{
				return;
			}
			soundAreaScroll.RefreshByData(context);
		}

		// Token: 0x0603DB6A RID: 252778 RVA: 0x00EE7250 File Offset: 0x00EE5450
		protected override void OnBeforeShow()
		{
			if (!this.HaveRefreshTypeScroll || this.HasNavigationParam())
			{
				this.RefreshType();
				this.HaveRefreshTypeScroll = true;
			}
			LevelSequencePlayer startLevelSequencePlayer = this.StartLevelSequencePlayer;
			if (startLevelSequencePlayer != null)
			{
				startLevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
			EventSystem.Instance.Emit<int>(EEventName.AdventureHelpBtn, this.HelpId);
		}

		// Token: 0x0603DB6B RID: 252779 RVA: 0x00EE72B4 File Offset: 0x00EE54B4
		private bool HasNavigationParam()
		{
			AdventureGuideViewOpenData adventureGuideViewOpenData = this.ExtraParams as AdventureGuideViewOpenData;
			return (((adventureGuideViewOpenData != null) ? adventureGuideViewOpenData.OpenTabViewName : null) == EUiTabViewName.NewSoundAreaView || ((adventureGuideViewOpenData != null) ? adventureGuideViewOpenData.OpenTabViewName : null) == EUiTabViewName.DisposableChallengeView) && ((adventureGuideViewOpenData != null) ? adventureGuideViewOpenData.OpenParam : null).GetValueOrDefault() > 0;
		}

		// Token: 0x0603DB6C RID: 252780 RVA: 0x00EE7360 File Offset: 0x00EE5560
		private void RefreshType()
		{
			this.CurrentData = (this.ExtraParams as AdventureGuideViewOpenData);
			AdventureGuideViewOpenData currentData = this.CurrentData;
			bool flag = ((currentData != null) ? currentData.OpenTabViewName : null) == EUiTabViewName.NewSoundAreaView || ((currentData != null) ? currentData.OpenTabViewName : null) == EUiTabViewName.DisposableChallengeView;
			string viewName = base.GetViewName();
			bool flag2 = viewName == EUiTabViewName.NewSoundAreaView && FunctionModel.Instance.IsOpen(10097);
			int? num;
			if (flag)
			{
				num = ((currentData != null) ? currentData.OpenParam : null);
				if (currentData != null)
				{
					currentData.OpenParam = null;
				}
			}
			else if (this.HasUserSelectedType)
			{
				num = new int?((int)this.CurrentType);
			}
			else if (flag2)
			{
				num = new int?(-1);
			}
			else
			{
				num = new int?(4);
			}
			int dungeonIndex = 0;
			bool flag3 = num.GetValueOrDefault() == -1;
			if (!flag3 && num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					int num4 = this.TypeList.IndexOf(num.Value);
					if (num4 >= 0)
					{
						dungeonIndex = num4;
					}
				}
			}
			int count = this.TypeList.Count;
			List<INewSoundTypeItemData> list = new List<INewSoundTypeItemData>();
			for (int i = 0; i < count; i++)
			{
				int cycleId = WeeklyRogueModel.Instance.CycleId;
				if (this.TypeList[i] != 29 || cycleId != 0)
				{
					NewSoundTypeItemData item = new NewSoundTypeItemData
					{
						FromTabViewName = new EUiTabViewName?((EUiTabViewName)viewName),
						TypeId = (EDungeonType)this.TypeList[i]
					};
					list.Add(item);
				}
			}
			this.RefreshTypeScroll(list, dungeonIndex, flag3);
			if (viewName == EUiTabViewName.NewSoundAreaView)
			{
				RedDotBase redDot = RedDotModel.Instance.GetRedDot(ERedDotName.AdventureNewSoundAreaTab);
				if (redDot != null && redDot.IsRedDotActive())
				{
					AdventureGuideController.Instance.RecordAdventureNewSoundAreaTabClick();
				}
			}
		}

		// Token: 0x0603DB6D RID: 252781 RVA: 0x00EE758C File Offset: 0x00EE578C
		private void RefreshTypeScroll(List<INewSoundTypeItemData> dataList, int dungeonIndex, bool isSelectingRoleDev)
		{
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			int num = dungeonIndex;
			string viewName = base.GetViewName();
			this.HasRoleDevTab = (viewName == EUiTabViewName.NewSoundAreaView && FunctionModel.Instance.IsOpen(10097));
			if (this.HasRoleDevTab)
			{
				RoleDevelopTabItemCellData data = new RoleDevelopTabItemCellData
				{
					TypeId = -1
				};
				list.Add(new RoleDevelopTabItemData(data, this.TypeToggleFunc, this.TypeCanToggleChange));
				if (!isSelectingRoleDev)
				{
					num++;
				}
			}
			foreach (INewSoundTypeItemData data2 in dataList)
			{
				list.Add(new NewSoundTypeItemGridData(data2, this.TypeToggleFunc, this.TypeCanToggleChange));
			}
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(list);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = num;
			this.TypeScroll.RefreshByData(multiTemplateScrollViewRefreshContext);
			int selectIndex = num;
			this.SelectToggleAfterRefreshAsync(selectIndex, isSelectingRoleDev).Forget();
		}

		// Token: 0x0603DB6E RID: 252782 RVA: 0x00EE7688 File Offset: 0x00EE5888
		private UniTask SelectToggleAfterRefreshAsync(int selectIndex, bool isSelectingRoleDev)
		{
			NewSoundAreaView.<SelectToggleAfterRefreshAsync>d__64 <SelectToggleAfterRefreshAsync>d__;
			<SelectToggleAfterRefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SelectToggleAfterRefreshAsync>d__.<>4__this = this;
			<SelectToggleAfterRefreshAsync>d__.selectIndex = selectIndex;
			<SelectToggleAfterRefreshAsync>d__.isSelectingRoleDev = isSelectingRoleDev;
			<SelectToggleAfterRefreshAsync>d__.<>1__state = -1;
			<SelectToggleAfterRefreshAsync>d__.<>t__builder.Start<NewSoundAreaView.<SelectToggleAfterRefreshAsync>d__64>(ref <SelectToggleAfterRefreshAsync>d__);
			return <SelectToggleAfterRefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603DB6F RID: 252783 RVA: 0x00EE76DC File Offset: 0x00EE58DC
		protected void RefreshDungeonType()
		{
			base.GetItem(3).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(10).SetUIActive(false);
			base.GetItem(12).SetUIActive(false);
			base.GetItem(14).SetUIActive(false);
			base.GetItem(9).SetUIActive(false);
			base.GetItem(18).SetUIActive(false);
			base.GetItem(20).SetUIActive(false);
			EDungeonType currentType = this.CurrentType;
			if (currentType <= EDungeonType.ShipTower)
			{
				switch (currentType)
				{
				case EDungeonType.Mat:
					break;
				case EDungeonType.Tower:
					this.ShowTimeAndCountPart();
					this.ShowTowerPart();
					return;
				case EDungeonType.Tutorial:
					this.ShowTeachPart();
					return;
				case EDungeonType.Weekly:
					this.ShowTimeAndCountPart();
					return;
				default:
					switch (currentType)
					{
					case EDungeonType.Rouge:
						this.ShowRoguePart();
						return;
					case EDungeonType.Simulation:
					case (EDungeonType)20:
					case EDungeonType.Boss:
					case EDungeonType.NoSoundArea:
						break;
					default:
						if (currentType != EDungeonType.ShipTower)
						{
							return;
						}
						this.ShowTimeAndCountPart();
						this.ShowShipTowerPart();
						return;
					}
					break;
				}
			}
			else if (currentType != EDungeonType.WeeklyRogue)
			{
				if (currentType == EDungeonType.LordGym)
				{
					this.ShowLordGymPart();
					return;
				}
				if (currentType != EDungeonType.SkillTeach)
				{
					return;
				}
				this.ShowTeachSkillPart();
				return;
			}
			else
			{
				this.ShowTimeAndCountPart();
				this.ShowWeeklyRoguePart();
			}
		}

		// Token: 0x0603DB70 RID: 252784 RVA: 0x00EE77F8 File Offset: 0x00EE59F8
		private void ShowWeeklyRoguePart()
		{
			base.GetItem(9).SetUIActive(true);
			base.GetItem(20).SetUIActive(true);
			WeeklyRogueData activityData = WeeklyRogueModel.Instance.ActivityData;
			RogueWeeklyCycle? rogueWeeklyCycle = (activityData != null) ? activityData.GetCycleConfig() : null;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(21), rogueWeeklyCycle.Value.CycleName, Array.Empty<object>());
		}

		// Token: 0x0603DB71 RID: 252785 RVA: 0x00EE7868 File Offset: 0x00EE5A68
		private void ShowRoguePart()
		{
			base.GetItem(3).SetUIActive(true);
			RogueParam? paramConfigBySeasonId = RoguelikeModel.Instance.GetParamConfigBySeasonId(null);
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(paramConfigBySeasonId.Value.TokenItem, 0);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Roguelike_ActivityMain_Score", new <>z__ReadOnlyArray<object>(new object[]
			{
				itemCountByConfigId,
				paramConfigBySeasonId.Value.WeekTokenMaxCount
			}));
		}

		// Token: 0x0603DB72 RID: 252786 RVA: 0x00EE78F4 File Offset: 0x00EE5AF4
		private void ShowTowerPart()
		{
			base.GetItem(9).SetUIActive(true);
			base.GetItem(10).SetUIActive(true);
			int maxDifficulty = TowerModel.Instance.GetMaxDifficulty();
			string newTowerDifficultTitle = TowerClimbConfig.Instance.GetNewTowerDifficultTitle(maxDifficulty);
			UUIText text = base.GetText(11);
			if (text != null)
			{
				text.SetText(newTowerDifficultTitle, true);
			}
			this.SetTowerBg("T_DevelopmentFrame7");
		}

		// Token: 0x0603DB73 RID: 252787 RVA: 0x00EE7954 File Offset: 0x00EE5B54
		private void ShowShipTowerPart()
		{
			base.GetItem(9).SetUIActive(true);
			base.GetItem(10).SetUIActive(true);
			string currentStageSeasonName = ShipTowerModel.Instance.GetCurrentStageSeasonName2();
			UUIText text = base.GetText(11);
			if (text != null)
			{
				text.SetText(currentStageSeasonName, true);
			}
			this.SetTowerBg("T_DevelopmentTitle6");
		}

		// Token: 0x0603DB74 RID: 252788 RVA: 0x00EE79A8 File Offset: 0x00EE5BA8
		public void SetTowerBg(string res)
		{
			UUITexture texture = base.GetTexture(22);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(res);
			base.SetTextureShowUntilLoaded(resourcePath, texture, null);
		}

		// Token: 0x0603DB75 RID: 252789 RVA: 0x00EE79D3 File Offset: 0x00EE5BD3
		private void ShowLordGymPart()
		{
			base.GetItem(9).SetUIActive(true);
			base.GetItem(12).SetUIActive(true);
		}

		// Token: 0x0603DB76 RID: 252790 RVA: 0x00EE79F1 File Offset: 0x00EE5BF1
		private void ShowTeachSkillPart()
		{
			base.GetItem(9).SetUIActive(true);
			base.GetItem(18).SetUIActive(true);
		}

		// Token: 0x0603DB77 RID: 252791 RVA: 0x00EE7A0F File Offset: 0x00EE5C0F
		private void ShowTeachPart()
		{
			base.GetItem(9).SetUIActive(true);
			base.GetItem(14).SetUIActive(true);
		}

		// Token: 0x0603DB78 RID: 252792 RVA: 0x00EE7A30 File Offset: 0x00EE5C30
		private void ShowTimeAndCountPart()
		{
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIText text = base.GetText(8);
			UUIText text2 = base.GetText(7);
			if (this.CurrentType == EDungeonType.Weekly)
			{
				text2.SetUIActive(false);
				List<SoundAreaDetectionRecord> item2 = AdventureGuideModel.Instance.GetCanShowDungeonRecordsByType(this.CurrentType, null, true).Item2;
				int? num = new int?(0);
				if (item2[0].Type.GetValueOrDefault() == ESoundAreaDataType.SilentArea)
				{
					int markId = ((T2)item2[0].Conf.Value).MarkId;
					if (markId == 0)
					{
						item.SetUIActive(false);
						return;
					}
					MapMark? mapMark;
					num = ((MapConfig.Instance.GetConfigMark(markId) != null) ? new int?(mapMark.GetValueOrDefault().Reward) : null);
				}
				else
				{
					if (((T1)item2[0].Conf.Value).DungeonId == 0)
					{
						item.SetUIActive(false);
						return;
					}
					InstanceDungeon? instanceDungeon;
					num = ((InstanceDungeonConfig.Instance.GetConfig(((T1)item2[0].Conf.Value).SubDungeonId) != null) ? new int?(instanceDungeon.GetValueOrDefault().RewardId) : null);
				}
				text.SetUIActive(true);
				ExchangeReward? exchangeReward;
				int? num2 = (ExchangeRewardConfig.Instance.GetExchangeRewardConfig(new int?(num.GetValueOrDefault())) != null) ? new int?(exchangeReward.GetValueOrDefault().SharedId) : null;
				if (num2 != null)
				{
					int? num3 = num2;
					int num4 = 0;
					if (num3.GetValueOrDefault() > num4 & num3 != null)
					{
						ExchangeShared value = ExchangeRewardConfig.Instance.GetExchangeShareConfig(new int?(num2.Value)).Value;
						int exchangeRewardShareCount = ExchangeRewardModel.Instance.GetExchangeRewardShareCount(num2.Value);
						int maxCount = value.MaxCount;
						int value2 = maxCount - exchangeRewardShareCount;
						LguiUtil instance = LguiUtil.Instance;
						UUIText uiText = text;
						string textTableId = "ReceivedCount";
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
						defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
						defaultInterpolatedStringHandler.AppendLiteral("/");
						defaultInterpolatedStringHandler.AppendFormatted<int>(maxCount);
						instance.SetLocalText(uiText, textTableId, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
						return;
					}
				}
				item.SetUIActive(false);
				return;
			}
			if (this.CurrentType == EDungeonType.Tower)
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
				text2.SetUIActive(true);
				string countDownText = TowerModel.Instance.GetSeasonCountDownData().CountDownText;
				text2.SetText(countDownText, true);
				return;
			}
			if (this.CurrentType == EDungeonType.ShipTower)
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
				text2.SetUIActive(true);
				string countDownText2 = ShipTowerModel.Instance.GetSeasonCountDownData().CountDownText;
				text2.SetText(countDownText2, true);
				return;
			}
			if (this.CurrentType == EDungeonType.WeeklyRogue)
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
				text2.SetUIActive(true);
				string countDownText3 = WeeklyRogueModel.Instance.ActivityData.GetCycleCountDownData().CountDownText;
				text2.SetText(countDownText3, true);
			}
		}

		// Token: 0x0603DB79 RID: 252793 RVA: 0x00EE7D52 File Offset: 0x00EE5F52
		protected override void OnBeforeHide()
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.PowerView))
			{
				UiManager.Instance.CloseView(EUiViewName.PowerView, null);
			}
			base.SetExtraParams(null);
		}

		// Token: 0x0603DB7A RID: 252794 RVA: 0x00EE7D7C File Offset: 0x00EE5F7C
		private void OnClickLordGymBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.LordGymChallengeRecordView, null, null);
		}

		// Token: 0x0603DB7B RID: 252795 RVA: 0x00EE7D90 File Offset: 0x00EE5F90
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			int num;
			if (configParams.Length != 1 || !int.TryParse(configParams[0], out num))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.JT;
				string message = "聚焦引导extraParam项配置有误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			if (num != 0)
			{
				int num2 = this.TypeList.IndexOf(num);
				if (num2 >= 0)
				{
					MultiTemplateScrollView typeScroll = this.TypeScroll;
					NewSoundTypeItem newSoundTypeItem = ((typeScroll != null) ? typeScroll.GetProxyByGridIndex(num2) : null) as NewSoundTypeItem;
					if (newSoundTypeItem != null)
					{
						UUIItem buttonItem = newSoundTypeItem.GetButtonItem();
						if (buttonItem != null)
						{
							MultiTemplateScrollView typeScroll2 = this.TypeScroll;
							if (typeScroll2 != null)
							{
								typeScroll2.ScrollView.ScrollToGridIndex(num2, true);
							}
							return new UUIItem[]
							{
								buttonItem,
								buttonItem
							};
						}
					}
				}
				return null;
			}
			MultiTemplateScrollView soundAreaScroll = this.SoundAreaScroll;
			NewSoundDetectTabItemDungeonItem newSoundDetectTabItemDungeonItem = ((soundAreaScroll != null) ? soundAreaScroll.GetProxyByGridIndex(0) : null) as NewSoundDetectTabItemDungeonItem;
			if (newSoundDetectTabItemDungeonItem == null)
			{
				return null;
			}
			UUIItem rootItem = newSoundDetectTabItemDungeonItem.GetRootItem();
			if (rootItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				rootItem,
				rootItem
			};
		}

		// Token: 0x0603DB7C RID: 252796 RVA: 0x00EE7E80 File Offset: 0x00EE6080
		private void RefreshCommonDropDown()
		{
			if (this.CurrentDropDownType == EDetectionDropDownType.None)
			{
				base.GetItem(19).SetUIActive(false);
				return;
			}
			base.GetItem(19).SetUIActive(true);
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(this.CurrentDropDownType == EDetectionDropDownType.Level);
			}
			bool flag = this.CurrentDropDownType == EDetectionDropDownType.Suit;
			bool uiactive = this.CurrentDropDownType == EDetectionDropDownType.Weapon;
			if (flag)
			{
				this.RefreshSuitDropDownItems();
			}
			CommonDropDown<int, int> suitDropDown = this.SuitDropDown;
			if (suitDropDown != null)
			{
				suitDropDown.GetRootItem().SetUIActive(flag);
			}
			CommonDropDown<int, int> weaponDropDown = this.WeaponDropDown;
			if (weaponDropDown != null)
			{
				weaponDropDown.GetRootItem().SetUIActive(uiactive);
			}
			DetectionDropDownType? detectionDropDownType;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(28), ((AdventureGuideConfig.Instance.GetDropDownConfig((int)this.CurrentDropDownType) != null) ? detectionDropDownType.GetValueOrDefault().Text : null) ?? "", Array.Empty<object>());
		}

		// Token: 0x0603DB7D RID: 252797 RVA: 0x00EE7F68 File Offset: 0x00EE6168
		private void RefreshSuitDropDownItems()
		{
			List<SoundAreaDetectionRecord> item = AdventureGuideModel.Instance.GetCanShowDungeonRecordsByType(this.CurrentType, null, true).Item2;
			HashSet<int> hashSet = new HashSet<int>();
			foreach (SoundAreaDetectionRecord soundAreaDetectionRecord in item)
			{
				foreach (int item2 in soundAreaDetectionRecord.PhantomFetterGroup)
				{
					hashSet.Add(item2);
				}
			}
			List<int> list = new List<int>
			{
				0
			};
			foreach (int num in this.FetterSuitFilterArray)
			{
				if (num != 0 && hashSet.Contains(num))
				{
					list.Add(num);
				}
			}
			int currentSelectSuitIndex = AdventureGuideModel.Instance.CurrentSelectSuitIndex;
			if (currentSelectSuitIndex != 0 && !hashSet.Contains(currentSelectSuitIndex))
			{
				AdventureGuideModel.Instance.CurrentSelectSuitIndex = 0;
			}
			int num2 = list.IndexOf(AdventureGuideModel.Instance.CurrentSelectSuitIndex);
			this.SuitDropDown.InitScroll(list, new Func<int, int>(this.GetSuitDropDownTextId), (num2 >= 0) ? num2 : 0, false);
		}

		// Token: 0x0603DB7E RID: 252798 RVA: 0x00EE80B4 File Offset: 0x00EE62B4
		private void BuildListBySuitData()
		{
			ValueTuple<bool, List<SoundAreaDetectionRecord>> canShowDungeonRecordsByType = AdventureGuideModel.Instance.GetCanShowDungeonRecordsByType(this.CurrentType, null, true);
			bool item = canShowDungeonRecordsByType.Item1;
			List<SoundAreaDetectionRecord> item2 = canShowDungeonRecordsByType.Item2;
			List<SoundAreaDetectionRecord> list = new List<SoundAreaDetectionRecord>();
			if (AdventureGuideModel.Instance.CurrentSelectSuitIndex != 0)
			{
				using (List<SoundAreaDetectionRecord>.Enumerator enumerator = item2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						SoundAreaDetectionRecord soundAreaDetectionRecord = enumerator.Current;
						if (soundAreaDetectionRecord.PhantomFetterGroup.Contains(AdventureGuideModel.Instance.CurrentSelectSuitIndex))
						{
							list.Add(soundAreaDetectionRecord);
						}
					}
					goto IL_8C;
				}
			}
			list = item2.ToList<SoundAreaDetectionRecord>();
			IL_8C:
			if (!item)
			{
				this.BuildDungeonNormalList(list);
			}
			else
			{
				this.BuildDungeonTabList(list);
			}
			this.CurrentData = null;
		}

		// Token: 0x0603DB7F RID: 252799 RVA: 0x00EE8178 File Offset: 0x00EE6378
		private void BuildListByWeaponData()
		{
			ValueTuple<bool, List<SoundAreaDetectionRecord>> canShowDungeonRecordsByType = AdventureGuideModel.Instance.GetCanShowDungeonRecordsByType(this.CurrentType, null, true);
			bool item = canShowDungeonRecordsByType.Item1;
			List<SoundAreaDetectionRecord> item2 = canShowDungeonRecordsByType.Item2;
			List<SoundAreaDetectionRecord> list = new List<SoundAreaDetectionRecord>();
			if (this.CurrentSelectWeaponIndex != 0)
			{
				using (List<SoundAreaDetectionRecord>.Enumerator enumerator = item2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						SoundAreaDetectionRecord soundAreaDetectionRecord = enumerator.Current;
						if (soundAreaDetectionRecord.WeaponFetterGroup.Contains(this.CurrentSelectWeaponIndex))
						{
							list.Add(soundAreaDetectionRecord);
						}
					}
					goto IL_84;
				}
			}
			list = item2.ToList<SoundAreaDetectionRecord>();
			IL_84:
			if (!item)
			{
				this.BuildDungeonNormalList(list);
			}
			else
			{
				this.BuildDungeonTabList(list);
			}
			this.CurrentData = null;
		}

		// Token: 0x04020388 RID: 131976
		private const int ROLE_DEVELOP_TYPE = -1;

		// Token: 0x04020389 RID: 131977
		private const int PRE_OPEN_TAB_AREA = -1;

		// Token: 0x0402038A RID: 131978
		private const int PRE_OPEN_TAB_SORT = 9999;

		// Token: 0x0402038B RID: 131979
		[Nullable(2)]
		private AdventureGuideViewOpenData CurrentData;

		// Token: 0x0402038C RID: 131980
		[Nullable(2)]
		private MultiTemplateScrollView TypeScroll;

		// Token: 0x0402038D RID: 131981
		[Nullable(2)]
		private MultiTemplateScrollView SoundAreaScroll;

		// Token: 0x0402038E RID: 131982
		private List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0402038F RID: 131983
		private IReadOnlyList<int> TypeList = Array.Empty<int>();

		// Token: 0x04020390 RID: 131984
		private EDungeonType CurrentType = EDungeonType.Mat;

		// Token: 0x04020391 RID: 131985
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectedToggle;

		// Token: 0x04020392 RID: 131986
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private CommonDropDown<TableTextArgNew, int> LevelDropDown;

		// Token: 0x04020393 RID: 131987
		[Nullable(2)]
		private CommonDropDown<int, int> SuitDropDown;

		// Token: 0x04020394 RID: 131988
		[Nullable(2)]
		private CommonDropDown<int, int> WeaponDropDown;

		// Token: 0x04020395 RID: 131989
		private EDetectionDropDownType CurrentDropDownType;

		// Token: 0x04020396 RID: 131990
		private int CurrentSelectWeaponIndex;

		// Token: 0x04020397 RID: 131991
		private readonly List<int> WeaponFilterArray = new List<int>();

		// Token: 0x04020398 RID: 131992
		[Nullable(2)]
		private LevelSequencePlayer StartLevelSequencePlayer;

		// Token: 0x04020399 RID: 131993
		[Nullable(2)]
		private LevelSequencePlayer SwitchLevelSequencePlayer;

		// Token: 0x0402039A RID: 131994
		private int DefaultDropDownSelectIndex;

		// Token: 0x0402039B RID: 131995
		private int HelpId;

		// Token: 0x0402039C RID: 131996
		private readonly List<int> FetterSuitFilterArray = new List<int>();

		// Token: 0x0402039D RID: 131997
		private bool IsNavigationJumpToGrid;

		// Token: 0x0402039E RID: 131998
		private int? JumpToGridId;

		// Token: 0x0402039F RID: 131999
		private bool HasRoleDevTab;

		// Token: 0x040203A0 RID: 132000
		private bool HasUserSelectedType;

		// Token: 0x040203A1 RID: 132001
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<int, UUIExtendToggle> TypeToggleFunc;

		// Token: 0x040203A2 RID: 132002
		[Nullable(2)]
		private Func<int, bool> TypeCanToggleChange;

		// Token: 0x040203A3 RID: 132003
		[Nullable(2)]
		private RegressPanel RegressPanel;

		// Token: 0x040203A4 RID: 132004
		[Nullable(2)]
		private RoleDevelopOverviewPanel RoleDevelopPanel;

		// Token: 0x040203A5 RID: 132005
		private bool HaveRefreshTypeScroll;
	}
}
