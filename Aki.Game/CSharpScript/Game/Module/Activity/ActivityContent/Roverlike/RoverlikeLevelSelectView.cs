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
	// Token: 0x020050E1 RID: 20705
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeLevelSelectView : UiViewBase
	{
		// Token: 0x17006518 RID: 25880
		// (get) Token: 0x06033CEC RID: 212204 RVA: 0x00E800B2 File Offset: 0x00E7E2B2
		private RoverlikeActivityData ActivityData
		{
			get
			{
				return RoverlikeActivityController.Instance.GetCurrentActivityData();
			}
		}

		// Token: 0x06033CED RID: 212205 RVA: 0x00E800BE File Offset: 0x00E7E2BE
		[NullableContext(1)]
		public RoverlikeLevelSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033CEE RID: 212206 RVA: 0x00E800C8 File Offset: 0x00E7E2C8
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

		// Token: 0x06033CEF RID: 212207 RVA: 0x00E803D4 File Offset: 0x00E7E5D4
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeLevelSelectView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeLevelSelectView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033CF0 RID: 212208 RVA: 0x00E80418 File Offset: 0x00E7E618
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoverlikeEquippedLootChange, new Action<int>(this.OnEquippedLootChange));
			EventSystem.Instance.Add(EEventName.RoverlikeLootInfoUpdate, new Action(this.OnLootInfoUpdate));
			EventSystem.Instance.Add(EEventName.RoverlikeLevelInfoUpdate, new Action(this.OnLevelInfoUpdate));
		}

		// Token: 0x06033CF1 RID: 212209 RVA: 0x00E8047C File Offset: 0x00E7E67C
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

		// Token: 0x06033CF2 RID: 212210 RVA: 0x00E804F5 File Offset: 0x00E7E6F5
		private void OnEquippedLootChange(int lootId)
		{
			this.RefreshDetailButtonTexts();
		}

		// Token: 0x06033CF3 RID: 212211 RVA: 0x00E804FD File Offset: 0x00E7E6FD
		private void OnLootInfoUpdate()
		{
			this.RefreshDetailButtonTexts();
		}

		// Token: 0x06033CF4 RID: 212212 RVA: 0x00E80505 File Offset: 0x00E7E705
		private void OnLevelInfoUpdate()
		{
			this.RefreshLevelList();
		}

		// Token: 0x06033CF5 RID: 212213 RVA: 0x00E80510 File Offset: 0x00E7E710
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

		// Token: 0x06033CF6 RID: 212214 RVA: 0x00E80597 File Offset: 0x00E7E797
		public void Refresh()
		{
			this.RefreshLevelList();
		}

		// Token: 0x06033CF7 RID: 212215 RVA: 0x00E805A0 File Offset: 0x00E7E7A0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoverlikeEquippedLootChange, new Action<int>(this.OnEquippedLootChange));
			EventSystem.Instance.Remove(EEventName.RoverlikeLootInfoUpdate, new Action(this.OnLootInfoUpdate));
			EventSystem.Instance.Remove(EEventName.RoverlikeLevelInfoUpdate, new Action(this.OnLevelInfoUpdate));
		}

		// Token: 0x06033CF8 RID: 212216 RVA: 0x00E80604 File Offset: 0x00E7E804
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

		// Token: 0x06033CF9 RID: 212217 RVA: 0x00E80654 File Offset: 0x00E7E854
		private void BuildLevelLayout()
		{
			UUILayoutBase layout = base.GetScrollViewWithScrollbar(1).GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase;
			this.LevelLayout = new GenericLayout<RoverlikeLevelItem, RoverlikeLevelSelectItemData>(layout, () => new RoverlikeLevelItem
			{
				OnSelectCallback = new Action<int>(this.OnSelectLevel)
			}, null, false, true);
		}

		// Token: 0x06033CFA RID: 212218 RVA: 0x00E8069D File Offset: 0x00E7E89D
		private void BuildInfoLayout()
		{
			this.InfoList = new RoverlikeLevelInfoList(base.GetScrollViewWithScrollbar(5));
		}

		// Token: 0x06033CFB RID: 212219 RVA: 0x00E806B1 File Offset: 0x00E7E8B1
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

		// Token: 0x06033CFC RID: 212220 RVA: 0x00E806E8 File Offset: 0x00E7E8E8
		private void SelectDefault(bool scrollToView = false)
		{
			RoverlikeLevelSelectData levelData = this.LevelData;
			int num = (levelData != null) ? levelData.GetDefaultSelectInstId() : 0;
			if (num > 0)
			{
				this.SelectByInstId(num, scrollToView);
			}
		}

		// Token: 0x06033CFD RID: 212221 RVA: 0x00E80714 File Offset: 0x00E7E914
		private void OnSelectLevel(int instId)
		{
			this.SelectByInstId(instId, false);
		}

		// Token: 0x06033CFE RID: 212222 RVA: 0x00E80720 File Offset: 0x00E7E920
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

		// Token: 0x06033CFF RID: 212223 RVA: 0x00E807C4 File Offset: 0x00E7E9C4
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

		// Token: 0x06033D00 RID: 212224 RVA: 0x00E80805 File Offset: 0x00E7EA05
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

		// Token: 0x06033D01 RID: 212225 RVA: 0x00E8082C File Offset: 0x00E7EA2C
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

		// Token: 0x06033D02 RID: 212226 RVA: 0x00E808EF File Offset: 0x00E7EAEF
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

		// Token: 0x06033D03 RID: 212227 RVA: 0x00E8092C File Offset: 0x00E7EB2C
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

		// Token: 0x06033D04 RID: 212228 RVA: 0x00E809EC File Offset: 0x00E7EBEC
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

		// Token: 0x06033D05 RID: 212229 RVA: 0x00E80AD7 File Offset: 0x00E7ECD7
		[NullableContext(1)]
		private string GetBlessRoleName(RoverRogueBlessRole blessRole)
		{
			return ConfigMultiTextLang.GetLocalTextNew(blessRole.BlessRoleName, null) ?? "";
		}

		// Token: 0x06033D06 RID: 212230 RVA: 0x00E80AF0 File Offset: 0x00E7ECF0
		private void RefreshInfoList(RoverRogueIns? cfg)
		{
			RoverlikeLevelInfoList infoList = this.InfoList;
			if (infoList != null)
			{
				infoList.RefreshByConfig(cfg);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(17), (cfg != null) ? cfg.GetValueOrDefault().LevelName : null, Array.Empty<object>());
		}

		// Token: 0x06033D07 RID: 212231 RVA: 0x00E80B44 File Offset: 0x00E7ED44
		[NullableContext(1)]
		private void RefreshBlessRolePanel(IReadOnlyList<RoverRogueBlessRole> blessRoleList)
		{
			this.RefreshSingleBlessRole(16, 7, (blessRoleList.Count > 0) ? new RoverRogueBlessRole?(blessRoleList[0]) : null);
			this.RefreshSingleBlessRole(12, 13, (blessRoleList.Count > 1) ? new RoverRogueBlessRole?(blessRoleList[1]) : null);
			this.RefreshSingleBlessRole(20, 21, (blessRoleList.Count > 2) ? new RoverRogueBlessRole?(blessRoleList[2]) : null);
		}

		// Token: 0x06033D08 RID: 212232 RVA: 0x00E80BD0 File Offset: 0x00E7EDD0
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

		// Token: 0x06033D09 RID: 212233 RVA: 0x00E80C4C File Offset: 0x00E7EE4C
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

		// Token: 0x06033D0A RID: 212234 RVA: 0x00E80CBC File Offset: 0x00E7EEBC
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

		// Token: 0x06033D0B RID: 212235 RVA: 0x00E80E14 File Offset: 0x00E7F014
		private void RefreshLootStars(int maxLevel)
		{
			RoverlikeSelectButton lootButton = this.LootButton;
			if (lootButton == null)
			{
				return;
			}
			lootButton.SetStars(RoverlikeController.Instance.GetEquippedLootLevel(), maxLevel);
		}

		// Token: 0x06033D0C RID: 212236 RVA: 0x00E80E31 File Offset: 0x00E7F031
		private bool IsLootFeatureUnlocked()
		{
			RoverlikeActivityData activityData = this.ActivityData;
			return activityData != null && activityData.IsLootFeatureUnlocked();
		}

		// Token: 0x06033D0D RID: 212237 RVA: 0x00E80E44 File Offset: 0x00E7F044
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

		// Token: 0x06033D0E RID: 212238 RVA: 0x00E80F18 File Offset: 0x00E7F118
		private void RefreshAttributeBubble()
		{
			UUIItem item = base.GetItem(19);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.IsLootRoleTypeMismatch());
		}

		// Token: 0x06033D0F RID: 212239 RVA: 0x00E80F40 File Offset: 0x00E7F140
		private bool IsRoleSelectLocked()
		{
			RoverRogueIns? insConfig = RoverlikeConfig.Instance.GetInsConfig(this.CurSelectInstId);
			return ((insConfig != null) ? insConfig.GetValueOrDefault().RoverListLength : 0) <= 1;
		}

		// Token: 0x06033D10 RID: 212240 RVA: 0x00E80F80 File Offset: 0x00E7F180
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

		// Token: 0x06033D11 RID: 212241 RVA: 0x00E81008 File Offset: 0x00E7F208
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

		// Token: 0x06033D12 RID: 212242 RVA: 0x00E81088 File Offset: 0x00E7F288
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

		// Token: 0x06033D13 RID: 212243 RVA: 0x00E810BC File Offset: 0x00E7F2BC
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

		// Token: 0x06033D14 RID: 212244 RVA: 0x00E81150 File Offset: 0x00E7F350
		private bool IsLootRoleTypeMismatch()
		{
			RoverlikeLevelSelectData levelData = this.LevelData;
			int num = (levelData != null) ? levelData.SelectedLootId : 0;
			RoverRogueLoot? roverRogueLoot = (num > 0) ? RoverlikeConfig.Instance.GetLootConfig(num) : null;
			int num2 = (roverRogueLoot != null) ? roverRogueLoot.GetValueOrDefault().ApplyRoleType : 0;
			return num2 != 0 && num2 != this.GetSelectedRoleTypeId();
		}

		// Token: 0x06033D15 RID: 212245 RVA: 0x00E811BC File Offset: 0x00E7F3BC
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

		// Token: 0x06033D16 RID: 212246 RVA: 0x00E8122C File Offset: 0x00E7F42C
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

		// Token: 0x06033D17 RID: 212247 RVA: 0x00E8128D File Offset: 0x00E7F48D
		private void OnRoleTypeConfirm(int roleTypeId)
		{
			RoverlikeLevelSelectData levelData = this.LevelData;
			if (levelData != null)
			{
				levelData.SetSelectedRoleTypeId(this.CurSelectInstId, roleTypeId);
			}
			this.RefreshAttributeButtonText();
		}

		// Token: 0x06033D18 RID: 212248 RVA: 0x00E812B0 File Offset: 0x00E7F4B0
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

		// Token: 0x06033D19 RID: 212249 RVA: 0x00E81315 File Offset: 0x00E7F515
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

		// Token: 0x06033D1A RID: 212250 RVA: 0x00E8132F File Offset: 0x00E7F52F
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401B72C RID: 112428
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<FColor> TierTextColors = new List<FColor>
		{
			FColor.FromHex("#469FFBFF"),
			FColor.FromHex("#856FF8FF"),
			FColor.FromHex("#F22647FF")
		};

		// Token: 0x0401B72D RID: 112429
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B72E RID: 112430
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeLevelItem, RoverlikeLevelSelectItemData> LevelLayout;

		// Token: 0x0401B72F RID: 112431
		private RoverlikeLevelInfoList InfoList;

		// Token: 0x0401B730 RID: 112432
		private RoverlikeLevelSelectData LevelData;

		// Token: 0x0401B731 RID: 112433
		private int CurSelectInstId;

		// Token: 0x0401B732 RID: 112434
		private RoverlikeSelectButton LootButton;

		// Token: 0x0401B733 RID: 112435
		private RoverlikeSelectButton AttributeButton;

		// Token: 0x0401B734 RID: 112436
		private RoverlikeCommonButton CommonButton;

		// Token: 0x0401B735 RID: 112437
		private RoverlikeRoleSelectUnlockPanel LockedPanel;

		// Token: 0x0200ADAA RID: 44458
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035A80 RID: 219776
			public const int UiItemCaption = 0;

			// Token: 0x04035A81 RID: 219777
			public const int SvTab = 1;

			// Token: 0x04035A82 RID: 219778
			public const int TogTabLevelTemplate = 2;

			// Token: 0x04035A83 RID: 219779
			public const int TxtNum1 = 3;

			// Token: 0x04035A84 RID: 219780
			public const int TxtNum2 = 4;

			// Token: 0x04035A85 RID: 219781
			public const int SvInfo = 5;

			// Token: 0x04035A86 RID: 219782
			public const int PnlInfo = 6;

			// Token: 0x04035A87 RID: 219783
			public const int TexRole1 = 7;

			// Token: 0x04035A88 RID: 219784
			public const int TxtUnlock = 8;

			// Token: 0x04035A89 RID: 219785
			public const int BtnRogueConfirm2 = 9;

			// Token: 0x04035A8A RID: 219786
			public const int BtnRogueConfirm = 10;

			// Token: 0x04035A8B RID: 219787
			public const int BtnRogueCommon = 11;

			// Token: 0x04035A8C RID: 219788
			public const int PnlRole2 = 12;

			// Token: 0x04035A8D RID: 219789
			public const int TexRole2 = 13;

			// Token: 0x04035A8E RID: 219790
			public const int PnlMaskDone = 14;

			// Token: 0x04035A8F RID: 219791
			public const int PnlAactivedB = 15;

			// Token: 0x04035A90 RID: 219792
			public const int PnlRole1 = 16;

			// Token: 0x04035A91 RID: 219793
			public const int TitleText = 17;

			// Token: 0x04035A92 RID: 219794
			public const int UnlockItem = 18;

			// Token: 0x04035A93 RID: 219795
			public const int BubbleItem = 19;

			// Token: 0x04035A94 RID: 219796
			public const int PnlRole3 = 20;

			// Token: 0x04035A95 RID: 219797
			public const int TexRole3 = 21;
		}
	}
}
