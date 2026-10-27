using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006163 RID: 24931
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeLevelSelectView : UiViewBase
	{
		// Token: 0x170091B6 RID: 37302
		// (get) Token: 0x0603F02C RID: 258092 RVA: 0x00F391DE File Offset: 0x00F373DE
		private RoverlikeActivityData ActivityData
		{
			get
			{
				return RoverlikeActivityController.Instance.GetCurrentActivityData();
			}
		}

		// Token: 0x0603F02D RID: 258093 RVA: 0x00F391EA File Offset: 0x00F373EA
		[NullableContext(1)]
		public RoverlikeLevelSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603F02E RID: 258094 RVA: 0x00F391F4 File Offset: 0x00F373F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 22;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
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
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F02F RID: 258095 RVA: 0x00F39500 File Offset: 0x00F37700
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeLevelSelectView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeLevelSelectView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F030 RID: 258096 RVA: 0x00F39544 File Offset: 0x00F37744
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoverlikeEquippedLootChange, new Action<int>(this.OnEquippedLootChange));
			EventSystem.Instance.Add(EEventName.RoverlikeLootInfoUpdate, new Action(this.OnLootInfoUpdate));
			EventSystem.Instance.Add(EEventName.RoverlikeLevelInfoUpdate, new Action(this.OnLevelInfoUpdate));
		}

		// Token: 0x0603F031 RID: 258097 RVA: 0x00F395A8 File Offset: 0x00F377A8
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseBtnClick));
			RoverlikeActivityData activityData = this.ActivityData;
			this.LevelData = ((activityData != null) ? activityData.LevelSelectData : null);
			if (this.LevelData == null)
			{
				return;
			}
			if (activityData != null)
			{
				activityData.MarkLevelUnlockRedDotRead();
			}
			this.BuildDetailButtons();
			this.BuildLevelLayout();
			this.BuildInfoLayout();
			this.RefreshLevelList();
		}

		// Token: 0x0603F032 RID: 258098 RVA: 0x00F39621 File Offset: 0x00F37821
		private void OnEquippedLootChange(int lootId)
		{
			this.RefreshDetailButtonTexts();
		}

		// Token: 0x0603F033 RID: 258099 RVA: 0x00F39629 File Offset: 0x00F37829
		private void OnLootInfoUpdate()
		{
			this.RefreshDetailButtonTexts();
		}

		// Token: 0x0603F034 RID: 258100 RVA: 0x00F39631 File Offset: 0x00F37831
		private void OnLevelInfoUpdate()
		{
			this.RefreshLevelList();
		}

		// Token: 0x0603F035 RID: 258101 RVA: 0x00F3963C File Offset: 0x00F3783C
		private void BuildDetailButtons()
		{
			RoverlikeSelectButton lootButton = this.LootButton;
			if (lootButton != null)
			{
				lootButton.SetClickCallback(new Action(this.OnClickLoot));
			}
			RoverlikeSelectButton attributeButton = this.AttributeButton;
			if (attributeButton != null)
			{
				attributeButton.SetClickCallback(new Action(this.OnClickAttribute));
			}
			RoverlikeCommonButton commonButton = this.CommonButton;
			if (commonButton != null)
			{
				commonButton.SetClickCallback(new Action(this.OnClickGo));
			}
			RoverlikeSelectButton lootButton2 = this.LootButton;
			if (lootButton2 != null)
			{
				lootButton2.SetStarListActive(true);
			}
			RoverlikeSelectButton attributeButton2 = this.AttributeButton;
			if (attributeButton2 == null)
			{
				return;
			}
			attributeButton2.SetStarListActive(false);
		}

		// Token: 0x0603F036 RID: 258102 RVA: 0x00F396C3 File Offset: 0x00F378C3
		public void Refresh()
		{
			this.RefreshLevelList();
		}

		// Token: 0x0603F037 RID: 258103 RVA: 0x00F396CC File Offset: 0x00F378CC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoverlikeEquippedLootChange, new Action<int>(this.OnEquippedLootChange));
			EventSystem.Instance.Remove(EEventName.RoverlikeLootInfoUpdate, new Action(this.OnLootInfoUpdate));
			EventSystem.Instance.Remove(EEventName.RoverlikeLevelInfoUpdate, new Action(this.OnLevelInfoUpdate));
		}

		// Token: 0x0603F038 RID: 258104 RVA: 0x00F39730 File Offset: 0x00F37930
		protected override void OnBeforeDestroy()
		{
			if (this.LevelData != null)
			{
				this.LevelData.LastSelectedInstId = this.CurSelectInstId;
			}
			this.LevelLayout = null;
			this.InfoList = null;
			this.LootButton = null;
			this.AttributeButton = null;
			this.CommonButton = null;
			this.LockedPanel = null;
		}

		// Token: 0x0603F039 RID: 258105 RVA: 0x00F39780 File Offset: 0x00F37980
		private void BuildLevelLayout()
		{
			UUILayoutBase layout = base.GetScrollViewWithScrollbar(1).GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase;
			this.LevelLayout = new GenericLayout<RoverlikeLevelItem, RoverlikeLevelSelectItemData>(layout, () => new RoverlikeLevelItem
			{
				OnSelectCallback = new Action<int>(this.OnSelectLevel)
			}, null, false, true);
		}

		// Token: 0x0603F03A RID: 258106 RVA: 0x00F397C9 File Offset: 0x00F379C9
		private void BuildInfoLayout()
		{
			this.InfoList = new RoverlikeLevelInfoList(base.GetScrollViewWithScrollbar(5));
		}

		// Token: 0x0603F03B RID: 258107 RVA: 0x00F397DD File Offset: 0x00F379DD
		private void RefreshLevelList()
		{
			if (this.LevelLayout == null || this.LevelData == null)
			{
				return;
			}
			this.LevelLayout.RefreshByData(this.LevelData.GetItemDataList(), delegate
			{
				if (this.CurSelectInstId <= 0)
				{
					this.SelectDefault(true);
					return;
				}
				this.SelectByInstId(this.CurSelectInstId, true);
			}, false);
		}

		// Token: 0x0603F03C RID: 258108 RVA: 0x00F39814 File Offset: 0x00F37A14
		private void SelectDefault(bool scrollToView = false)
		{
			RoverlikeLevelSelectData levelData = this.LevelData;
			int num = (levelData != null) ? levelData.GetDefaultSelectInstId() : 0;
			if (num > 0)
			{
				this.SelectByInstId(num, scrollToView);
			}
		}

		// Token: 0x0603F03D RID: 258109 RVA: 0x00F39840 File Offset: 0x00F37A40
		private void OnSelectLevel(int instId)
		{
			this.SelectByInstId(instId, false);
		}

		// Token: 0x0603F03E RID: 258110 RVA: 0x00F3984C File Offset: 0x00F37A4C
		private void SelectByInstId(int instId, bool scrollToView = false)
		{
			if (instId <= 0 || this.LevelLayout == null || this.LevelData == null)
			{
				return;
			}
			RoverlikeLevelSelectItemData itemData = this.LevelData.GetItemData(instId);
			if (itemData == null)
			{
				return;
			}
			bool flag = this.CurSelectInstId > 0 && this.CurSelectInstId != instId;
			int? gridIndexByKey = this.LevelLayout.GetGridIndexByKey<int>(instId);
			if (gridIndexByKey != null)
			{
				this.LevelLayout.SelectGridProxy(gridIndexByKey.Value, false);
			}
			this.CurSelectInstId = instId;
			if (scrollToView)
			{
				this.ScrollToSelectedLevel(instId);
			}
			this.RefreshDetailPanel(itemData);
			if (flag)
			{
				base.PlayOrReplaySequence("Switch", false, null);
			}
		}

		// Token: 0x0603F03F RID: 258111 RVA: 0x00F398F0 File Offset: 0x00F37AF0
		private void ScrollToSelectedLevel(int instId)
		{
			if (this.LevelLayout == null)
			{
				return;
			}
			TTimerAction <>9__1;
			this.LevelLayout.BindLateUpdate(delegate(float _)
			{
				TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
				TTimerAction action;
				if ((action = <>9__1) == null)
				{
					action = (<>9__1 = delegate(float __)
					{
						GenericLayout<RoverlikeLevelItem, RoverlikeLevelSelectItemData> levelLayout2 = this.LevelLayout;
						UUIItem uuiitem = (levelLayout2 != null) ? levelLayout2.GetItemByKey(instId) : null;
						if (uuiitem != null)
						{
							UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = this.GetScrollViewWithScrollbar(1);
							if (scrollViewWithScrollbar == null)
							{
								return;
							}
							scrollViewWithScrollbar.ScrollTo(uuiitem, true);
						}
					});
				}
				gameplayTimeInstance.Next(action, null, null);
				GenericLayout<RoverlikeLevelItem, RoverlikeLevelSelectItemData> levelLayout = this.LevelLayout;
				if (levelLayout == null)
				{
					return;
				}
				levelLayout.UnBindLateUpdate();
			});
		}

		// Token: 0x0603F040 RID: 258112 RVA: 0x00F39931 File Offset: 0x00F37B31
		private RoverlikeLevelSelectItemData GetCurrentItemData()
		{
			if (this.CurSelectInstId <= 0)
			{
				return null;
			}
			RoverlikeLevelSelectData levelData = this.LevelData;
			if (levelData == null)
			{
				return null;
			}
			return levelData.GetItemData(this.CurSelectInstId);
		}

		// Token: 0x0603F041 RID: 258113 RVA: 0x00F39958 File Offset: 0x00F37B58
		private void RefreshDetailPanel(RoverlikeLevelSelectItemData itemData)
		{
			if (itemData == null)
			{
				return;
			}
			RoverRogueIns? insConfig = RoverlikeConfig.Instance.GetInsConfig(itemData.InstId);
			IReadOnlyList<RoverRogueBlessRole> blessRoleConfigListByUnlockInsId = RoverlikeConfig.Instance.GetBlessRoleConfigListByUnlockInsId(itemData.InstId);
			this.RefreshNumTexts(itemData, insConfig);
			this.RefreshUnlockText(itemData, blessRoleConfigListByUnlockInsId);
			this.RefreshInfoList(insConfig);
			this.RefreshBlessRolePanel(blessRoleConfigListByUnlockInsId);
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(itemData.Passed);
			}
			UUIItem item2 = base.GetItem(18);
			if (item2 != null)
			{
				item2.SetUIActive(blessRoleConfigListByUnlockInsId.Count > 0);
			}
			UUIText text = base.GetText(8);
			if (text != null)
			{
				UUIItem uuiitem = text;
				bool passed = itemData.Passed;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(passed, fcolor);
			}
			this.RefreshLockedPanel(itemData.Unlocked);
			this.RefreshDetailButtons(itemData.Unlocked);
		}

		// Token: 0x0603F042 RID: 258114 RVA: 0x00F39A1B File Offset: 0x00F37C1B
		private void RefreshLockedPanel(bool isUnlocked)
		{
			RoverlikeRoleSelectUnlockPanel lockedPanel = this.LockedPanel;
			if (lockedPanel != null)
			{
				UUIItem rootItem = lockedPanel.GetRootItem();
				if (rootItem != null)
				{
					rootItem.SetUIActive(!isUnlocked);
				}
			}
			if (!isUnlocked)
			{
				RoverlikeRoleSelectUnlockPanel lockedPanel2 = this.LockedPanel;
				if (lockedPanel2 == null)
				{
					return;
				}
				lockedPanel2.RefreshUnlockDesc("RoverRogue_StageLockedHint");
			}
		}

		// Token: 0x0603F043 RID: 258115 RVA: 0x00F39A58 File Offset: 0x00F37C58
		[NullableContext(1)]
		private void RefreshNumTexts(RoverlikeLevelSelectItemData itemData, RoverRogueIns? cfg)
		{
			int index = Math.Min(Math.Max(((cfg != null) ? cfg.GetValueOrDefault().Difficulty : 1) - 1, 0), 2);
			FColor color = RoverlikeLevelSelectView.TierTextColors[index];
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetText(this.FormatLevelNum((cfg != null) ? cfg.GetValueOrDefault().SortId : 0), true);
			}
			UUIText text2 = base.GetText(4);
			if (text2 != null)
			{
				text2.SetColor(color);
			}
			UUIText text3 = base.GetText(3);
			if (text3 == null)
			{
				return;
			}
			string str = "/";
			RoverlikeLevelSelectData levelData = this.LevelData;
			text3.SetText(str + this.FormatLevelNum((levelData != null) ? levelData.GetMaxLevelSortId() : 0), true);
		}

		// Token: 0x0603F044 RID: 258116 RVA: 0x00F39B18 File Offset: 0x00F37D18
		[NullableContext(1)]
		private void RefreshUnlockText(RoverlikeLevelSelectItemData itemData, IReadOnlyList<RoverRogueBlessRole> blessRoleList)
		{
			UUIText text = base.GetText(8);
			if (text == null)
			{
				return;
			}
			if (blessRoleList.Count >= 3)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RoverRogue_GodUnlock_Triple", new <>z__ReadOnlyArray<object>(new object[]
				{
					this.GetBlessRoleName(blessRoleList[0]),
					this.GetBlessRoleName(blessRoleList[1]),
					this.GetBlessRoleName(blessRoleList[2])
				}));
				return;
			}
			if (blessRoleList.Count == 2)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RoverRogue_GodUnlock_Double", new <>z__ReadOnlyArray<object>(new object[]
				{
					this.GetBlessRoleName(blessRoleList[0]),
					this.GetBlessRoleName(blessRoleList[1])
				}));
				return;
			}
			if (blessRoleList.Count == 1)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "RoverRogue_GodUnlock_Single", new <>z__ReadOnlySingleElementList<object>(this.GetBlessRoleName(blessRoleList[0])));
				return;
			}
			text.SetText("", true);
		}

		// Token: 0x0603F045 RID: 258117 RVA: 0x00F39C03 File Offset: 0x00F37E03
		[NullableContext(1)]
		private string GetBlessRoleName(RoverRogueBlessRole blessRole)
		{
			return ConfigMultiTextLang.GetLocalTextNew(blessRole.BlessRoleName, null) ?? "";
		}

		// Token: 0x0603F046 RID: 258118 RVA: 0x00F39C1C File Offset: 0x00F37E1C
		private void RefreshInfoList(RoverRogueIns? cfg)
		{
			RoverlikeLevelInfoList infoList = this.InfoList;
			if (infoList != null)
			{
				infoList.RefreshByConfig(cfg);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(17), (cfg != null) ? cfg.GetValueOrDefault().LevelName : null, Array.Empty<object>());
		}

		// Token: 0x0603F047 RID: 258119 RVA: 0x00F39C70 File Offset: 0x00F37E70
		[NullableContext(1)]
		private void RefreshBlessRolePanel(IReadOnlyList<RoverRogueBlessRole> blessRoleList)
		{
			this.RefreshSingleBlessRole(16, 7, (blessRoleList.Count > 0) ? new RoverRogueBlessRole?(blessRoleList[0]) : null);
			this.RefreshSingleBlessRole(12, 13, (blessRoleList.Count > 1) ? new RoverRogueBlessRole?(blessRoleList[1]) : null);
			this.RefreshSingleBlessRole(20, 21, (blessRoleList.Count > 2) ? new RoverRogueBlessRole?(blessRoleList[2]) : null);
		}

		// Token: 0x0603F048 RID: 258120 RVA: 0x00F39CFC File Offset: 0x00F37EFC
		private void RefreshSingleBlessRole(int pnlComp, int texComp, RoverRogueBlessRole? blessRole)
		{
			UUIItem item = base.GetItem(pnlComp);
			if (blessRole != null && !string.IsNullOrEmpty(blessRole.Value.RoleIcon))
			{
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUITexture texture = base.GetTexture(texComp);
				if (texture != null)
				{
					texture.SetUIActive(true);
					base.SetTextureByPath(blessRole.Value.RoleIcon, texture, null, null);
					return;
				}
			}
			else if (item != null)
			{
				item.SetUIActive(false);
			}
		}

		// Token: 0x0603F049 RID: 258121 RVA: 0x00F39D78 File Offset: 0x00F37F78
		private void RefreshDetailButtons(bool isUnlocked)
		{
			RoverlikeCommonButton commonButton = this.CommonButton;
			if (commonButton != null)
			{
				UUIItem rootItem = commonButton.GetRootItem();
				if (rootItem != null)
				{
					rootItem.SetUIActive(isUnlocked);
				}
			}
			if (isUnlocked)
			{
				RoverRogueIns? insConfig = RoverlikeConfig.Instance.GetInsConfig(this.CurSelectInstId);
				RoverlikeCommonButton commonButton2 = this.CommonButton;
				if (commonButton2 != null)
				{
					commonButton2.RefreshByDifficulty((insConfig != null) ? insConfig.GetValueOrDefault().Difficulty : 1);
				}
			}
			this.RefreshDetailButtonTexts();
		}

		// Token: 0x0603F04A RID: 258122 RVA: 0x00F39DE8 File Offset: 0x00F37FE8
		private void RefreshDetailButtonTexts()
		{
			bool flag = !this.IsLootFeatureUnlocked();
			RoverlikeSelectButton lootButton = this.LootButton;
			if (lootButton != null)
			{
				lootButton.SetLock(flag, true);
			}
			if (flag)
			{
				RoverlikeSelectButton lootButton2 = this.LootButton;
				if (lootButton2 != null)
				{
					lootButton2.SetLocalTextNew("RoverRogue_LootUnlockHint", Array.Empty<object>());
				}
				RoverlikeSelectButton lootButton3 = this.LootButton;
				if (lootButton3 != null)
				{
					lootButton3.SetImage("");
				}
				RoverlikeSelectButton lootButton4 = this.LootButton;
				if (lootButton4 != null)
				{
					lootButton4.SetStars(0, 0);
				}
				this.RefreshAttributeButtonText();
				return;
			}
			RoverlikeLevelSelectData levelData = this.LevelData;
			int num = (levelData != null) ? levelData.SelectedLootId : 0;
			RoverRogueLoot? roverRogueLoot = (num > 0) ? RoverlikeConfig.Instance.GetLootConfig(num) : null;
			if (roverRogueLoot != null)
			{
				RoverlikeSelectButton lootButton5 = this.LootButton;
				if (lootButton5 != null)
				{
					lootButton5.SetLocalTextNew(roverRogueLoot.Value.Name, Array.Empty<object>());
				}
				RoverlikeSelectButton lootButton6 = this.LootButton;
				if (lootButton6 != null)
				{
					lootButton6.SetImage(roverRogueLoot.Value.Icon);
				}
				this.RefreshLootStars(roverRogueLoot.Value.MaxLevel);
			}
			else
			{
				RoverlikeSelectButton lootButton7 = this.LootButton;
				if (lootButton7 != null)
				{
					lootButton7.SetLocalTextNew("RoverRogue_DefaultLoot", Array.Empty<object>());
				}
				RoverlikeSelectButton lootButton8 = this.LootButton;
				if (lootButton8 != null)
				{
					lootButton8.SetImage("");
				}
				RoverlikeSelectButton lootButton9 = this.LootButton;
				if (lootButton9 != null)
				{
					lootButton9.SetStars(0, 0);
				}
			}
			this.RefreshAttributeButtonText();
		}

		// Token: 0x0603F04B RID: 258123 RVA: 0x00F39F40 File Offset: 0x00F38140
		private void RefreshLootStars(int maxLevel)
		{
			RoverlikeSelectButton lootButton = this.LootButton;
			if (lootButton == null)
			{
				return;
			}
			lootButton.SetStars(RoverlikeController.Instance.GetEquippedLootLevel(), maxLevel);
		}

		// Token: 0x0603F04C RID: 258124 RVA: 0x00F39F5D File Offset: 0x00F3815D
		private bool IsLootFeatureUnlocked()
		{
			RoverlikeActivityData activityData = this.ActivityData;
			return activityData != null && activityData.IsLootFeatureUnlocked();
		}

		// Token: 0x0603F04D RID: 258125 RVA: 0x00F39F70 File Offset: 0x00F38170
		private void RefreshAttributeButtonText()
		{
			RoverlikeSelectButton attributeButton = this.AttributeButton;
			if (attributeButton != null)
			{
				attributeButton.SetLock(false, true);
			}
			RoverRogueRoleType? roleTypeConfig = RoverlikeConfig.Instance.GetRoleTypeConfig(this.GetSelectedRoleTypeId());
			if (!string.IsNullOrEmpty((roleTypeConfig != null) ? roleTypeConfig.GetValueOrDefault().Element : null))
			{
				RoverlikeSelectButton attributeButton2 = this.AttributeButton;
				if (attributeButton2 != null)
				{
					attributeButton2.SetLocalTextNew(roleTypeConfig.Value.Element, Array.Empty<object>());
				}
				RoverlikeSelectButton attributeButton3 = this.AttributeButton;
				if (attributeButton3 != null)
				{
					attributeButton3.SetImage(roleTypeConfig.Value.ElementIcon);
				}
			}
			else
			{
				RoverlikeSelectButton attributeButton4 = this.AttributeButton;
				if (attributeButton4 != null)
				{
					attributeButton4.SetLocalTextNew("RoverRogue_DefaultElement", Array.Empty<object>());
				}
				RoverlikeSelectButton attributeButton5 = this.AttributeButton;
				if (attributeButton5 != null)
				{
					attributeButton5.SetImage("");
				}
			}
			this.RefreshAttributeBubble();
		}

		// Token: 0x0603F04E RID: 258126 RVA: 0x00F3A044 File Offset: 0x00F38244
		private void RefreshAttributeBubble()
		{
			UUIItem item = base.GetItem(19);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.IsLootRoleTypeMismatch());
		}

		// Token: 0x0603F04F RID: 258127 RVA: 0x00F3A06C File Offset: 0x00F3826C
		private bool IsRoleSelectLocked()
		{
			RoverRogueIns? insConfig = RoverlikeConfig.Instance.GetInsConfig(this.CurSelectInstId);
			return ((insConfig != null) ? insConfig.GetValueOrDefault().RoverListLength : 0) <= 1;
		}

		// Token: 0x0603F050 RID: 258128 RVA: 0x00F3A0AC File Offset: 0x00F382AC
		private int GetSelectedRoleTypeId()
		{
			if (this.IsRoleSelectLocked())
			{
				return this.GetUniqueAllowedRoleTypeId();
			}
			RoverlikeLevelSelectData levelData = this.LevelData;
			int num = (levelData != null) ? levelData.GetSelectedRoleTypeId(this.CurSelectInstId) : 0;
			if (num > 0)
			{
				return num;
			}
			int lastPassRoleTypeId = RoverlikeModel.Instance.GetLastPassRoleTypeId();
			if (lastPassRoleTypeId > 0 && RoverlikeConfig.Instance.GetRoleTypeConfig(lastPassRoleTypeId) != null)
			{
				return lastPassRoleTypeId;
			}
			IReadOnlyList<RoverRogueRoleType> roleTypeConfigList = RoverlikeConfig.Instance.GetRoleTypeConfigList();
			if (roleTypeConfigList.Count <= 0)
			{
				return 0;
			}
			return roleTypeConfigList[0].Id;
		}

		// Token: 0x0603F051 RID: 258129 RVA: 0x00F3A134 File Offset: 0x00F38334
		private int GetUniqueAllowedRoleTypeId()
		{
			IReadOnlyList<RoverRogueRoleType> roleTypeConfigList = RoverlikeConfig.Instance.GetRoleTypeConfigList();
			int result = (roleTypeConfigList.Count > 0) ? roleTypeConfigList[0].Id : 0;
			RoverRogueIns? insConfig = RoverlikeConfig.Instance.GetInsConfig(this.CurSelectInstId);
			int num = (insConfig != null && insConfig.Value.RoverListLength > 0) ? insConfig.Value.RoverList(0) : 0;
			if (num <= 0)
			{
				return result;
			}
			return num;
		}

		// Token: 0x0603F052 RID: 258130 RVA: 0x00F3A1B4 File Offset: 0x00F383B4
		[NullableContext(1)]
		private string FormatLevelNum(int level)
		{
			int num = (level > 0) ? level : 0;
			if (num >= 10)
			{
				return num.ToString();
			}
			return "0" + num.ToString();
		}

		// Token: 0x0603F053 RID: 258131 RVA: 0x00F3A1E8 File Offset: 0x00F383E8
		private void OnClickGo()
		{
			RoverlikeLevelSelectItemData itemData = this.GetCurrentItemData();
			if (itemData == null || !itemData.Unlocked)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RoverRogue_LevelSelect_LockedTip", Array.Empty<object>());
				return;
			}
			if (this.IsLootRoleTypeMismatch())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoverRogueLootNotMatchConfirm);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					this.EnterLevel(itemData);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.EnterLevel(itemData);
		}

		// Token: 0x0603F054 RID: 258132 RVA: 0x00F3A27C File Offset: 0x00F3847C
		private bool IsLootRoleTypeMismatch()
		{
			RoverlikeLevelSelectData levelData = this.LevelData;
			int num = (levelData != null) ? levelData.SelectedLootId : 0;
			RoverRogueLoot? roverRogueLoot = (num > 0) ? RoverlikeConfig.Instance.GetLootConfig(num) : null;
			int num2 = (roverRogueLoot != null) ? roverRogueLoot.GetValueOrDefault().ApplyRoleType : 0;
			return num2 != 0 && num2 != this.GetSelectedRoleTypeId();
		}

		// Token: 0x0603F055 RID: 258133 RVA: 0x00F3A2E8 File Offset: 0x00F384E8
		[NullableContext(1)]
		private void EnterLevel(RoverlikeLevelSelectItemData itemData)
		{
			int mainRoleId = RoverlikeModel.Instance.GetMainRoleId();
			int roleType = this.GetSelectedRoleTypeId();
			bool continueLastProgress = false;
			RoverlikeLevelSelectData levelData = this.LevelData;
			int lootId = (levelData != null) ? levelData.SelectedLootId : 0;
			RoverlikeController.Instance.RoverRogueStartRequest(itemData.InstId, mainRoleId, roleType, continueLastProgress, lootId, delegate(bool success)
			{
				if (!success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Activity;
					ELogAuthor author = ELogAuthor.SWC;
					string message = "RoverlikeLevelSelectView 前往失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InstId", itemData.InstId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				RoverlikeModel.Instance.SetCurrentRunRoleTypeId(roleType);
			});
		}

		// Token: 0x0603F056 RID: 258134 RVA: 0x00F3A358 File Offset: 0x00F38558
		private void OnClickAttribute()
		{
			RoverlikeLevelSelectItemData currentItemData = this.GetCurrentItemData();
			if (currentItemData == null || !currentItemData.Unlocked)
			{
				return;
			}
			RoverlikeRoleSelectViewOpenParam param = new RoverlikeRoleSelectViewOpenParam
			{
				DefaultRoleTypeId = this.GetSelectedRoleTypeId(),
				InstId = this.CurSelectInstId,
				OnConfirm = new Action<int>(this.OnRoleTypeConfirm)
			};
			UiManager.Instance.OpenView(EUiViewName.RoverlikeRoleSelectView, param, null);
		}

		// Token: 0x0603F057 RID: 258135 RVA: 0x00F3A3B9 File Offset: 0x00F385B9
		private void OnRoleTypeConfirm(int roleTypeId)
		{
			RoverlikeLevelSelectData levelData = this.LevelData;
			if (levelData != null)
			{
				levelData.SetSelectedRoleTypeId(this.CurSelectInstId, roleTypeId);
			}
			this.RefreshAttributeButtonText();
		}

		// Token: 0x0603F058 RID: 258136 RVA: 0x00F3A3DC File Offset: 0x00F385DC
		private void OnClickLoot()
		{
			RoverlikeLevelSelectItemData currentItemData = this.GetCurrentItemData();
			if (currentItemData == null || !currentItemData.Unlocked)
			{
				return;
			}
			if (!this.IsLootFeatureUnlocked())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RoverRogue_LootUnlockHint", Array.Empty<object>());
				return;
			}
			RoverlikeController instance = RoverlikeController.Instance;
			RoverlikeLevelSelectData levelData = this.LevelData;
			instance.OpenRoverRogueLootSelectView((levelData != null) ? levelData.SelectedLootId : 0, new Action<int, int>(this.OnLootConfirm));
		}

		// Token: 0x0603F059 RID: 258137 RVA: 0x00F3A441 File Offset: 0x00F38641
		private void OnLootConfirm(int lootId, int lootLv)
		{
			RoverlikeController.Instance.RoverRogueOutGameLootChangeRequest(lootId, lootLv, delegate(bool success)
			{
				if (!success)
				{
					return;
				}
				this.RefreshDetailButtonTexts();
			});
		}

		// Token: 0x0603F05A RID: 258138 RVA: 0x00F3A45B File Offset: 0x00F3865B
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04020DFF RID: 134655
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<FColor> TierTextColors = new List<FColor>
		{
			FColor.FromHex("#469FFBFF"),
			FColor.FromHex("#856FF8FF"),
			FColor.FromHex("#F22647FF")
		};

		// Token: 0x04020E00 RID: 134656
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020E01 RID: 134657
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeLevelItem, RoverlikeLevelSelectItemData> LevelLayout;

		// Token: 0x04020E02 RID: 134658
		private RoverlikeLevelInfoList InfoList;

		// Token: 0x04020E03 RID: 134659
		private RoverlikeLevelSelectData LevelData;

		// Token: 0x04020E04 RID: 134660
		private int CurSelectInstId;

		// Token: 0x04020E05 RID: 134661
		private RoverlikeSelectButton LootButton;

		// Token: 0x04020E06 RID: 134662
		private RoverlikeSelectButton AttributeButton;

		// Token: 0x04020E07 RID: 134663
		private RoverlikeCommonButton CommonButton;

		// Token: 0x04020E08 RID: 134664
		private RoverlikeRoleSelectUnlockPanel LockedPanel;

		// Token: 0x0200C3C3 RID: 50115
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B11F RID: 241951
			public const int UiItemCaption = 0;

			// Token: 0x0403B120 RID: 241952
			public const int SvTab = 1;

			// Token: 0x0403B121 RID: 241953
			public const int TogTabLevelTemplate = 2;

			// Token: 0x0403B122 RID: 241954
			public const int TxtNum1 = 3;

			// Token: 0x0403B123 RID: 241955
			public const int TxtNum2 = 4;

			// Token: 0x0403B124 RID: 241956
			public const int SvInfo = 5;

			// Token: 0x0403B125 RID: 241957
			public const int PnlInfo = 6;

			// Token: 0x0403B126 RID: 241958
			public const int TexRole1 = 7;

			// Token: 0x0403B127 RID: 241959
			public const int TxtUnlock = 8;

			// Token: 0x0403B128 RID: 241960
			public const int BtnRogueConfirm2 = 9;

			// Token: 0x0403B129 RID: 241961
			public const int BtnRogueConfirm = 10;

			// Token: 0x0403B12A RID: 241962
			public const int BtnRogueCommon = 11;

			// Token: 0x0403B12B RID: 241963
			public const int PnlRole2 = 12;

			// Token: 0x0403B12C RID: 241964
			public const int TexRole2 = 13;

			// Token: 0x0403B12D RID: 241965
			public const int PnlMaskDone = 14;

			// Token: 0x0403B12E RID: 241966
			public const int PnlAactivedB = 15;

			// Token: 0x0403B12F RID: 241967
			public const int PnlRole1 = 16;

			// Token: 0x0403B130 RID: 241968
			public const int TitleText = 17;

			// Token: 0x0403B131 RID: 241969
			public const int UnlockItem = 18;

			// Token: 0x0403B132 RID: 241970
			public const int BubbleItem = 19;

			// Token: 0x0403B133 RID: 241971
			public const int PnlRole3 = 20;

			// Token: 0x0403B134 RID: 241972
			public const int TexRole3 = 21;
		}
	}
}
