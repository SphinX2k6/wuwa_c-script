using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.View;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02004EB9 RID: 20153
	[NullableContext(1)]
	[Nullable(0)]
	public class NewSoundAreaView : UiTabViewBase
	{
		// Token: 0x06032ADC RID: 207580 RVA: 0x00E37424 File Offset: 0x00E35624
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

		// Token: 0x06032ADD RID: 207581 RVA: 0x00E378E3 File Offset: 0x00E35AE3
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RedDotAdventureSecondaryUpdate, new Action<int>(this.OnRedDotAdventureSecondaryUpdate));
		}

		// Token: 0x06032ADE RID: 207582 RVA: 0x00E37901 File Offset: 0x00E35B01
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RedDotAdventureSecondaryUpdate, new Action<int>(this.OnRedDotAdventureSecondaryUpdate));
		}

		// Token: 0x06032ADF RID: 207583 RVA: 0x00E37920 File Offset: 0x00E35B20
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

		// Token: 0x06032AE0 RID: 207584 RVA: 0x00E3797E File Offset: 0x00E35B7E
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

		// Token: 0x06032AE1 RID: 207585 RVA: 0x00E379BC File Offset: 0x00E35BBC
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

		// Token: 0x06032AE2 RID: 207586 RVA: 0x00E37A4B File Offset: 0x00E35C4B
		private OneTextTitleItem CreateLevelTitleItem(UUIItem uiItem)
		{
			return new OneTextTitleItem(uiItem);
		}

		// Token: 0x06032AE3 RID: 207587 RVA: 0x00E37A53 File Offset: 0x00E35C53
		private OneTextDropDownItem CreateLevelDropDownItem(UUIItem uiItem, int data)
		{
			return new OneTextDropDownItem(uiItem);
		}

		// Token: 0x06032AE4 RID: 207588 RVA: 0x00E37A5B File Offset: 0x00E35C5B
		private NewSoundSuitDropDownTitle CreateSuitTitleItem(UUIItem uiItem)
		{
			return new NewSoundSuitDropDownTitle(uiItem);
		}

		// Token: 0x06032AE5 RID: 207589 RVA: 0x00E37A63 File Offset: 0x00E35C63
		private NewSoundSuitDropDownItem CreateSuitDropDownItem(UUIItem uiItem, int data)
		{
			return new NewSoundSuitDropDownItem(uiItem);
		}

		// Token: 0x06032AE6 RID: 207590 RVA: 0x00E37A6B File Offset: 0x00E35C6B
		private WeaponTitleItem CreateWeaponTitleItem(UUIItem uiItem)
		{
			return new WeaponTitleItem(uiItem);
		}

		// Token: 0x06032AE7 RID: 207591 RVA: 0x00E37A73 File Offset: 0x00E35C73
		private NewSoundWeaponDropDownItem CreateWeaponDropDownItem(UUIItem uiItem, int data)
		{
			return new NewSoundWeaponDropDownItem(uiItem);
		}

		// Token: 0x06032AE8 RID: 207592 RVA: 0x00E37A7C File Offset: 0x00E35C7C
		protected override UniTask OnBeforeStartAsync()
		{
			NewSoundAreaView.<OnBeforeStartAsync>d__41 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NewSoundAreaView.<OnBeforeStartAsync>d__41>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032AE9 RID: 207593 RVA: 0x00E37AC0 File Offset: 0x00E35CC0
		protected override void OnStart()
		{
			Action<int, UUIExtendToggle> typeToggleFunc = delegate(int currentType, UUIExtendToggle toggle)
			{
				if (this.CurrentType == EDungeonType.Tutorial || this.CurrentType == EDungeonType.SkillTeach)
				{
					using (List<SoundAreaDetectionRecord>.Enumerator enumerator3 = AdventureGuideModel.Instance.GetCanShowDungeonRecordsByType(this.CurrentType, null, true).Item2.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							SoundAreaDetectionRecord soundAreaDetectionRecord = enumerator3.Current;
							AdventureGuideModel.Instance.SetRoleTutorialNew(soundAreaDetectionRecord.Id);
						}
						goto IL_F4;
					}
				}
				if (this.CurrentType == EDungeonType.LordGym)
				{
					foreach (SoundAreaDetectionRecord soundAreaDetectionRecord2 in AdventureGuideModel.Instance.GetCanShowDungeonRecordsByType(this.CurrentType, null, true).Item2)
					{
						if (!AdventureGuideModel.Instance.GetIsDetectionPreOpenByData(soundAreaDetectionRecord2) && AdventureGuideModel.Instance.IsDetectionNewContentOpen(soundAreaDetectionRecord2))
						{
							AdventureGuideModel.Instance.SetAdventureItemNew(soundAreaDetectionRecord2.Id);
						}
					}
				}
				IL_F4:
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
							goto IL_237;
						}
					}
					flag = (this.CurrentType == EDungeonType.NoSoundArea);
					IL_237:
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

		// Token: 0x06032AEA RID: 207594 RVA: 0x00E37DB8 File Offset: 0x00E35FB8
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

		// Token: 0x06032AEB RID: 207595 RVA: 0x00E37E64 File Offset: 0x00E36064
		private void RefreshSoundAreaScroll(List<IMultiTemplateGridData> dataList)
		{
			int num = this.FindJumpGridIndex(dataList);
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(dataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = ((num >= 0) ? num : 0);
			MultiTemplateScrollView soundAreaScroll = this.SoundAreaScroll;
			if (soundAreaScroll != null)
			{
				soundAreaScroll.RefreshByData(multiTemplateScrollViewRefreshContext);
			}
			if (num >= 0 && Info.Instance.IsInGamepad())
			{
				this.FocusJumpGridAsync(num).Forget();
			}
		}

		// Token: 0x06032AEC RID: 207596 RVA: 0x00E37EBC File Offset: 0x00E360BC
		private int FindJumpGridIndex(List<IMultiTemplateGridData> dataList)
		{
			if (!this.IsNavigationJumpToGrid || this.JumpToGridId == null)
			{
				return -1;
			}
			return dataList.FindIndex(delegate(IMultiTemplateGridData d)
			{
				NewSoundDetectTabItemData newSoundDetectTabItemData = d.Data as NewSoundDetectTabItemData;
				int? num;
				if (newSoundDetectTabItemData == null)
				{
					num = null;
				}
				else
				{
					NewSoundDetectItemData dungeon = newSoundDetectTabItemData.Dungeon;
					if (dungeon == null)
					{
						num = null;
					}
					else
					{
						SoundAreaDetectionRecord detectRecordData = dungeon.DetectRecordData;
						num = ((detectRecordData != null) ? new int?(detectRecordData.Id) : null);
					}
				}
				int? num2 = num;
				int value = this.JumpToGridId.Value;
				return num2.GetValueOrDefault() == value & num2 != null;
			});
		}

		// Token: 0x06032AED RID: 207597 RVA: 0x00E37EE8 File Offset: 0x00E360E8
		private UniTask FocusJumpGridAsync(int gridIndex)
		{
			NewSoundAreaView.<FocusJumpGridAsync>d__46 <FocusJumpGridAsync>d__;
			<FocusJumpGridAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FocusJumpGridAsync>d__.<>4__this = this;
			<FocusJumpGridAsync>d__.gridIndex = gridIndex;
			<FocusJumpGridAsync>d__.<>1__state = -1;
			<FocusJumpGridAsync>d__.<>t__builder.Start<NewSoundAreaView.<FocusJumpGridAsync>d__46>(ref <FocusJumpGridAsync>d__);
			return <FocusJumpGridAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032AEE RID: 207598 RVA: 0x00E37F34 File Offset: 0x00E36134
		[NullableContext(2)]
		private static UUIItem GetNavigationItemInChildren(UUIItem rootItem)
		{
			if (rootItem == null || !rootItem.IsValid())
			{
				return null;
			}
			TArray<UActorComponent> componentsInChildren = ULGUIBPLibrary.GetComponentsInChildren(rootItem.GetOwner(), TsUiNavigationBehaviorListener.StaticClass(), true);
			if (componentsInChildren == null)
			{
				return null;
			}
			int i = 0;
			int num = componentsInChildren.Num();
			while (i < num)
			{
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = componentsInChildren.Get(i) as TsUiNavigationBehaviorListener;
				if (tsUiNavigationBehaviorListener != null && !StringUtils.IsBlank(tsUiNavigationBehaviorListener.GroupName))
				{
					NavigationGroup navigationGroup = tsUiNavigationBehaviorListener.GetNavigationGroup();
					if (navigationGroup != null && navigationGroup.GroupType != 2)
					{
						return tsUiNavigationBehaviorListener.RootUIComp.Get();
					}
				}
				i++;
			}
			return null;
		}

		// Token: 0x06032AEF RID: 207599 RVA: 0x00E37FC4 File Offset: 0x00E361C4
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

		// Token: 0x06032AF0 RID: 207600 RVA: 0x00E38038 File Offset: 0x00E36238
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

		// Token: 0x06032AF1 RID: 207601 RVA: 0x00E380A0 File Offset: 0x00E362A0
		private void OnLevelDropDownSelectCall(int index, int data)
		{
			this.LevelDropDownCall(data);
		}

		// Token: 0x06032AF2 RID: 207602 RVA: 0x00E380A9 File Offset: 0x00E362A9
		private void OnSuitDropDownSelectCall(int index, int data)
		{
			this.SuitDropDownCall(data);
		}

		// Token: 0x06032AF3 RID: 207603 RVA: 0x00E380B2 File Offset: 0x00E362B2
		private TableTextArgNew GetLevelDropDownTextId(int data)
		{
			return new TableTextArgNew((data == WorldLevelModel.Instance.CurWorldLevel) ? "Text_WorldCurrentLevelTag_Text" : "Text_WorldLevelTag_Text", new <>z__ReadOnlySingleElementList<object>(data));
		}

		// Token: 0x06032AF4 RID: 207604 RVA: 0x00E380DD File Offset: 0x00E362DD
		private int GetSuitDropDownTextId(int data)
		{
			return data;
		}

		// Token: 0x06032AF5 RID: 207605 RVA: 0x00E380E0 File Offset: 0x00E362E0
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

		// Token: 0x06032AF6 RID: 207606 RVA: 0x00E38144 File Offset: 0x00E36344
		private void OnWeaponDropDownSelectCall(int index, int data)
		{
			this.WeaponDropDownCall(data);
		}

		// Token: 0x06032AF7 RID: 207607 RVA: 0x00E3814D File Offset: 0x00E3634D
		private int GetWeaponDropDownTextId(int data)
		{
			return data;
		}

		// Token: 0x06032AF8 RID: 207608 RVA: 0x00E38150 File Offset: 0x00E36350
		private void BuildDungeonList()
		{
			ValueTuple<bool, List<SoundAreaDetectionRecord>> canShowDungeonRecordsByType = AdventureGuideModel.Instance.GetCanShowDungeonRecordsByType(this.CurrentType, null, true);
			bool item = canShowDungeonRecordsByType.Item1;
			List<SoundAreaDetectionRecord> item2 = canShowDungeonRecordsByType.Item2;
			if (!item)
			{
				this.BuildDungeonNormalList(new List<SoundAreaDetectionRecord>(item2));
			}
			else
			{
				this.BuildDungeonTabList(new List<SoundAreaDetectionRecord>(item2));
			}
			this.CurrentData = null;
		}

		// Token: 0x06032AF9 RID: 207609 RVA: 0x00E381A8 File Offset: 0x00E363A8
		private void BuildDungeonNormalList(List<SoundAreaDetectionRecord> records)
		{
			int count = records.Count;
			base.GetItem(26).SetUIActive(true);
			if (count != 0)
			{
				AdventureGuideViewOpenData currentData = this.CurrentData;
				int[] array = (currentData != null) ? currentData.NewSoundDetectTracingIdList : null;
				List<SoundAreaDetectionRecord> list = new List<SoundAreaDetectionRecord>(records.Count);
				for (int i = 0; i < records.Count; i++)
				{
					if (array != null && Array.IndexOf<int>(array, records[i].Id) >= 0)
					{
						list.Add(records[i]);
					}
				}
				for (int j = 0; j < records.Count; j++)
				{
					if (array == null || Array.IndexOf<int>(array, records[j].Id) < 0)
					{
						list.Add(records[j]);
					}
				}
				List<IMultiTemplateGridData> list2 = new List<IMultiTemplateGridData>();
				int cycleId = WeeklyRogueModel.Instance.CycleId;
				for (int k = 0; k < count; k++)
				{
					SoundAreaDetectionRecord soundAreaDetectionRecord = list[k];
					if (soundAreaDetectionRecord == null || soundAreaDetectionRecord.Secondary != 29 || cycleId != 0)
					{
						NewSoundDetectItemData newSoundDetectItemData = new NewSoundDetectItemData();
						newSoundDetectItemData.DetectRecordData = list[k];
						newSoundDetectItemData.TracingList = ((array == null) ? null : new List<int>(array));
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

		// Token: 0x06032AFA RID: 207610 RVA: 0x00E38350 File Offset: 0x00E36550
		private void BuildDungeonTabList(List<SoundAreaDetectionRecord> records)
		{
			base.GetItem(26).SetUIActive(true);
			Dictionary<int, IMultiTemplateGridData> dictionary = new Dictionary<int, IMultiTemplateGridData>();
			List<IMultiTemplateGridData> list = new List<IMultiTemplateGridData>();
			AdventureGuideViewOpenData currentData = this.CurrentData;
			int[] array = (currentData != null) ? currentData.NewSoundDetectTracingIdList : null;
			int handleShowNightMareParam = AdventureGuideModel.Instance.HandleShowNightMareParam;
			AdventureGuideModel.Instance.HandleShowNightMareParam = 0;
			List<SoundAreaDetectionRecord> list2 = new List<SoundAreaDetectionRecord>(records.Count);
			for (int i = 0; i < records.Count; i++)
			{
				if (array != null && Array.IndexOf<int>(array, records[i].Id) >= 0)
				{
					list2.Add(records[i]);
				}
			}
			for (int j = 0; j < records.Count; j++)
			{
				if (array == null || Array.IndexOf<int>(array, records[j].Id) < 0)
				{
					list2.Add(records[j]);
				}
			}
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
					newSoundDetectItemData.TracingList = ((array == null) ? null : new List<int>(array));
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
					NewSoundDetectItemData newSoundDetectItemData2 = new NewSoundDetectItemData();
					newSoundDetectItemData2.DetectRecordData = soundAreaDetectionRecord3;
					newSoundDetectItemData2.TracingList = ((array == null) ? null : new List<int>(array));
					newSoundDetectItemData2.NightMareParam = new int?(handleShowNightMareParam);
					newSoundDetectItemData2.JumpToGridId = (this.IsNavigationJumpToGrid ? this.JumpToGridId : new int?(0));
					newSoundDetectItemData2.JumpToGridSquenceStartTimeSecond = new double?(0.0);
					NewSoundDetectTabItemDungeonData newSoundDetectTabItemDungeonData = new NewSoundDetectTabItemDungeonData(new NewSoundDetectTabItemData
					{
						Area = num2,
						Dungeon = newSoundDetectItemData2,
						Sort = sort,
						IsVisible = true
					});
					dictionary[(soundAreaDetectionRecord3.DungeonDetectionRecord != null) ? soundAreaDetectionRecord3.DungeonDetectionRecord.Conf.Id : soundAreaDetectionRecord3.SilentAreaDetectionRecord.Conf.Id] = newSoundDetectTabItemDungeonData;
					list.Add(newSoundDetectTabItemDungeonData);
				}
			}
			List<IMultiTemplateGridData> list5 = new List<IMultiTemplateGridData>(list.Count);
			for (int k = 0; k < list.Count; k++)
			{
				IMultiTemplateGridData multiTemplateGridData = list[k];
				int sort2 = ((NewSoundDetectTabItemData)multiTemplateGridData.Data).Sort;
				int num3 = list5.Count;
				while (num3 > 0 && ((NewSoundDetectTabItemData)list5[num3 - 1].Data).Sort < sort2)
				{
					num3--;
				}
				list5.Insert(num3, multiTemplateGridData);
			}
			this.ScrollDataList = list5;
			this.RefreshSoundAreaScroll(this.ScrollDataList);
		}

		// Token: 0x06032AFB RID: 207611 RVA: 0x00E388C0 File Offset: 0x00E36AC0
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

		// Token: 0x06032AFC RID: 207612 RVA: 0x00E38994 File Offset: 0x00E36B94
		protected override void OnBeforeShow()
		{
			if (!this.HaveRefreshTypeScroll || this.HasNavigationParam())
			{
				this.InitNavigationParam();
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

		// Token: 0x06032AFD RID: 207613 RVA: 0x00E389FC File Offset: 0x00E36BFC
		private bool HasNavigationParam()
		{
			AdventureGuideViewOpenData adventureGuideViewOpenData = this.ExtraParams as AdventureGuideViewOpenData;
			return (((adventureGuideViewOpenData != null) ? adventureGuideViewOpenData.OpenTabViewName : null) == EUiTabViewName.NewSoundAreaView || ((adventureGuideViewOpenData != null) ? adventureGuideViewOpenData.OpenTabViewName : null) == EUiTabViewName.DisposableChallengeView) && ((adventureGuideViewOpenData != null) ? adventureGuideViewOpenData.OpenParam : null).GetValueOrDefault() > 0;
		}

		// Token: 0x06032AFE RID: 207614 RVA: 0x00E38AA8 File Offset: 0x00E36CA8
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

		// Token: 0x06032AFF RID: 207615 RVA: 0x00E38CD4 File Offset: 0x00E36ED4
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

		// Token: 0x06032B00 RID: 207616 RVA: 0x00E38DD0 File Offset: 0x00E36FD0
		private UniTask SelectToggleAfterRefreshAsync(int selectIndex, bool isSelectingRoleDev)
		{
			NewSoundAreaView.<SelectToggleAfterRefreshAsync>d__66 <SelectToggleAfterRefreshAsync>d__;
			<SelectToggleAfterRefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SelectToggleAfterRefreshAsync>d__.<>4__this = this;
			<SelectToggleAfterRefreshAsync>d__.selectIndex = selectIndex;
			<SelectToggleAfterRefreshAsync>d__.isSelectingRoleDev = isSelectingRoleDev;
			<SelectToggleAfterRefreshAsync>d__.<>1__state = -1;
			<SelectToggleAfterRefreshAsync>d__.<>t__builder.Start<NewSoundAreaView.<SelectToggleAfterRefreshAsync>d__66>(ref <SelectToggleAfterRefreshAsync>d__);
			return <SelectToggleAfterRefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032B01 RID: 207617 RVA: 0x00E38E24 File Offset: 0x00E37024
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

		// Token: 0x06032B02 RID: 207618 RVA: 0x00E38F40 File Offset: 0x00E37140
		private void ShowWeeklyRoguePart()
		{
			base.GetItem(9).SetUIActive(true);
			base.GetItem(20).SetUIActive(true);
			WeeklyRogueData activityData = WeeklyRogueModel.Instance.ActivityData;
			RogueWeeklyCycle? rogueWeeklyCycle = (activityData != null) ? activityData.GetCycleConfig() : null;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(21), rogueWeeklyCycle.Value.CycleName, Array.Empty<object>());
		}

		// Token: 0x06032B03 RID: 207619 RVA: 0x00E38FB0 File Offset: 0x00E371B0
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

		// Token: 0x06032B04 RID: 207620 RVA: 0x00E3903C File Offset: 0x00E3723C
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

		// Token: 0x06032B05 RID: 207621 RVA: 0x00E3909C File Offset: 0x00E3729C
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

		// Token: 0x06032B06 RID: 207622 RVA: 0x00E390F0 File Offset: 0x00E372F0
		public void SetTowerBg(string res)
		{
			UUITexture texture = base.GetTexture(22);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(res);
			base.SetTextureShowUntilLoaded(resourcePath, texture, null);
		}

		// Token: 0x06032B07 RID: 207623 RVA: 0x00E3911B File Offset: 0x00E3731B
		private void ShowLordGymPart()
		{
			base.GetItem(9).SetUIActive(true);
			base.GetItem(12).SetUIActive(true);
		}

		// Token: 0x06032B08 RID: 207624 RVA: 0x00E39139 File Offset: 0x00E37339
		private void ShowTeachSkillPart()
		{
			base.GetItem(9).SetUIActive(true);
			base.GetItem(18).SetUIActive(true);
		}

		// Token: 0x06032B09 RID: 207625 RVA: 0x00E39157 File Offset: 0x00E37357
		private void ShowTeachPart()
		{
			base.GetItem(9).SetUIActive(true);
			base.GetItem(14).SetUIActive(true);
		}

		// Token: 0x06032B0A RID: 207626 RVA: 0x00E39178 File Offset: 0x00E37378
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

		// Token: 0x06032B0B RID: 207627 RVA: 0x00E3949A File Offset: 0x00E3769A
		protected override void OnBeforeHide()
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.PowerView))
			{
				UiManager.Instance.CloseView(EUiViewName.PowerView, null);
			}
			base.SetExtraParams(null);
		}

		// Token: 0x06032B0C RID: 207628 RVA: 0x00E394C4 File Offset: 0x00E376C4
		private void OnClickLordGymBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.LordGymChallengeRecordView, null, null);
		}

		// Token: 0x06032B0D RID: 207629 RVA: 0x00E394D8 File Offset: 0x00E376D8
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

		// Token: 0x06032B0E RID: 207630 RVA: 0x00E395C8 File Offset: 0x00E377C8
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

		// Token: 0x06032B0F RID: 207631 RVA: 0x00E396B0 File Offset: 0x00E378B0
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

		// Token: 0x06032B10 RID: 207632 RVA: 0x00E397FC File Offset: 0x00E379FC
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
						if (Array.IndexOf<int>(soundAreaDetectionRecord.PhantomFetterGroup, AdventureGuideModel.Instance.CurrentSelectSuitIndex) >= 0)
						{
							list.Add(soundAreaDetectionRecord);
						}
					}
					goto IL_8D;
				}
			}
			list = new List<SoundAreaDetectionRecord>(item2);
			IL_8D:
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

		// Token: 0x06032B11 RID: 207633 RVA: 0x00E398C0 File Offset: 0x00E37AC0
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
						if (Array.IndexOf<int>(soundAreaDetectionRecord.WeaponFetterGroup, this.CurrentSelectWeaponIndex) >= 0)
						{
							list.Add(soundAreaDetectionRecord);
						}
					}
					goto IL_85;
				}
			}
			list = new List<SoundAreaDetectionRecord>(item2);
			IL_85:
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

		// Token: 0x0401AE57 RID: 110167
		private const int ROLE_DEVELOP_TYPE = -1;

		// Token: 0x0401AE58 RID: 110168
		private const int PRE_OPEN_TAB_AREA = -1;

		// Token: 0x0401AE59 RID: 110169
		private const int PRE_OPEN_TAB_SORT = 9999;

		// Token: 0x0401AE5A RID: 110170
		[Nullable(2)]
		private AdventureGuideViewOpenData CurrentData;

		// Token: 0x0401AE5B RID: 110171
		[Nullable(2)]
		private MultiTemplateScrollView TypeScroll;

		// Token: 0x0401AE5C RID: 110172
		[Nullable(2)]
		private MultiTemplateScrollView SoundAreaScroll;

		// Token: 0x0401AE5D RID: 110173
		private List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401AE5E RID: 110174
		private IReadOnlyList<int> TypeList = Array.Empty<int>();

		// Token: 0x0401AE5F RID: 110175
		private EDungeonType CurrentType = EDungeonType.Mat;

		// Token: 0x0401AE60 RID: 110176
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectedToggle;

		// Token: 0x0401AE61 RID: 110177
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private CommonDropDown<TableTextArgNew, int> LevelDropDown;

		// Token: 0x0401AE62 RID: 110178
		[Nullable(2)]
		private CommonDropDown<int, int> SuitDropDown;

		// Token: 0x0401AE63 RID: 110179
		[Nullable(2)]
		private CommonDropDown<int, int> WeaponDropDown;

		// Token: 0x0401AE64 RID: 110180
		private EDetectionDropDownType CurrentDropDownType;

		// Token: 0x0401AE65 RID: 110181
		private int CurrentSelectWeaponIndex;

		// Token: 0x0401AE66 RID: 110182
		private readonly List<int> WeaponFilterArray = new List<int>();

		// Token: 0x0401AE67 RID: 110183
		[Nullable(2)]
		private LevelSequencePlayer StartLevelSequencePlayer;

		// Token: 0x0401AE68 RID: 110184
		[Nullable(2)]
		private LevelSequencePlayer SwitchLevelSequencePlayer;

		// Token: 0x0401AE69 RID: 110185
		private int DefaultDropDownSelectIndex;

		// Token: 0x0401AE6A RID: 110186
		private int HelpId;

		// Token: 0x0401AE6B RID: 110187
		private readonly List<int> FetterSuitFilterArray = new List<int>();

		// Token: 0x0401AE6C RID: 110188
		private bool IsNavigationJumpToGrid;

		// Token: 0x0401AE6D RID: 110189
		private int? JumpToGridId;

		// Token: 0x0401AE6E RID: 110190
		private bool HasRoleDevTab;

		// Token: 0x0401AE6F RID: 110191
		private bool HasUserSelectedType;

		// Token: 0x0401AE70 RID: 110192
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<int, UUIExtendToggle> TypeToggleFunc;

		// Token: 0x0401AE71 RID: 110193
		[Nullable(2)]
		private Func<int, bool> TypeCanToggleChange;

		// Token: 0x0401AE72 RID: 110194
		[Nullable(2)]
		private RegressPanel RegressPanel;

		// Token: 0x0401AE73 RID: 110195
		[Nullable(2)]
		private RoleDevelopOverviewPanel RoleDevelopPanel;

		// Token: 0x0401AE74 RID: 110196
		private bool HaveRefreshTypeScroll;
	}
}
