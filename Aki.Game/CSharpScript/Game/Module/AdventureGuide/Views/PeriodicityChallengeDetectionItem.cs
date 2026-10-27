using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02005EE1 RID: 24289
	[NullableContext(1)]
	[Nullable(0)]
	public class PeriodicityChallengeDetectionItem : UiPanelBase
	{
		// Token: 0x0603DBBF RID: 252863 RVA: 0x00EEAAEC File Offset: 0x00EE8CEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 21;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickTrackBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(17, new Action(this.OnClickLockBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603DBC0 RID: 252864 RVA: 0x00EEAE38 File Offset: 0x00EE9038
		protected override UniTask OnBeforeStartAsync()
		{
			PeriodicityChallengeDetectionItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PeriodicityChallengeDetectionItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603DBC1 RID: 252865 RVA: 0x00EEAE7C File Offset: 0x00EE907C
		protected override void OnStart()
		{
			base.GetItem(4).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			base.GetSprite(2).SetUIActive(false);
			this.TowerLayout = new GenericLayout<TowerItem, int>(base.GetVerticalLayout(7), new Func<TowerItem>(this.OnTowerLayoutUpdater), null, false, true);
			this.ShipTowerLayout = new GenericScrollViewNew<ShipTowerItem, int>(base.GetScrollViewWithScrollbar(13), new Func<ShipTowerItem>(this.OnShipTowerLayoutUpdater), null, false, null);
		}

		// Token: 0x0603DBC2 RID: 252866 RVA: 0x00EEAEF3 File Offset: 0x00EE90F3
		public void RefreshItem(SoundAreaDetectionRecord data)
		{
			this.Data = data;
			this.Type = (EPeriodicityChallengeType)this.Data.PeriodicityChallengeType;
			this.RefreshTitle();
			this.RefreshTraceBtn();
			this.RefreshSubItem();
		}

		// Token: 0x0603DBC3 RID: 252867 RVA: 0x00EEAF20 File Offset: 0x00EE9120
		private void RefreshTitle()
		{
			SoundAreaDetectionRecord data = this.Data;
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(data.LeftBgTexture);
			base.SetTextureByPath(resourcePath, base.GetTexture(19), null, null);
			this.SetSpriteByPath(data.LeftBgSprite, base.GetSprite(0), false, null, null);
			this.SetSpriteByPath(data.RightBgSprite, base.GetSprite(1), false, null, null);
			if (AdventureGuideModel.Instance.IsWeeklyRogueType(this.Type))
			{
				WeeklyRogueData activityData = WeeklyRogueModel.Instance.ActivityData;
				RogueWeeklyCycle? rogueWeeklyCycle;
				string textStringId = ((activityData != null) ? ((activityData.GetCycleConfig() != null) ? rogueWeeklyCycle.GetValueOrDefault().CycleName : null) : null) ?? "";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), data.Name, Array.Empty<object>());
		}

		// Token: 0x0603DBC4 RID: 252868 RVA: 0x00EEB020 File Offset: 0x00EE9220
		private void RefreshTraceBtn()
		{
			bool flag2;
			if (!AdventureGuideModel.Instance.GetIsDetectionPreOpenByData(this.Data))
			{
				bool? isLock = this.Data.IsLock;
				bool flag = false;
				flag2 = (isLock.GetValueOrDefault() == flag & isLock != null);
			}
			else
			{
				flag2 = true;
			}
			bool flag3 = flag2;
			base.GetButton(5).RootUIComp.Get().SetUIActive(flag3);
			base.GetItem(6).SetUIActive(!flag3);
		}

		// Token: 0x0603DBC5 RID: 252869 RVA: 0x00EEB090 File Offset: 0x00EE9290
		private void RefreshSubItem()
		{
			bool flag = AdventureGuideModel.Instance.IsTowerType(this.Type);
			bool flag2 = AdventureGuideModel.Instance.IsShipTowerType(this.Type);
			bool flag3 = AdventureGuideModel.Instance.IsWeeklyRogueType(this.Type);
			bool flag4 = AdventureGuideModel.Instance.IsWheelTowerType(this.Type);
			base.GetVerticalLayout(7).RootUIComp.Get().SetUIActive(flag);
			base.GetScrollViewWithScrollbar(13).RootUIComp.Get().SetUIActive(flag2);
			this.ShipTowerLastItem.SetUiActive(flag2);
			base.GetItem(9).SetUIActive(flag3);
			WheelTowerInfoPanel wheelTowerInfoPanel = this.WheelTowerInfoPanel;
			if (wheelTowerInfoPanel != null)
			{
				wheelTowerInfoPanel.SetUiActive(flag4);
			}
			if (flag)
			{
				int num = AdventureDefine.periodicityChallengeTypeToTarget[this.Type];
				int[] difficultyAllAreaFirstFloor = TowerModel.Instance.GetDifficultyAllAreaFirstFloor(num, false);
				this.TowerLayout.RefreshByData(difficultyAllAreaFirstFloor.ToList<int>(), null, false);
				int maxDifficulty = TowerModel.Instance.GetMaxDifficulty();
				base.GetItem(4).SetUIActive(maxDifficulty == num);
				return;
			}
			if (flag2)
			{
				List<int> list = AdventureGuideModel.Instance.GetShipTowerStateListByType(this.Type).ToList<int>();
				if (this.Type == EPeriodicityChallengeType.ShipTowerNormal)
				{
					this.ShipTowerLastItem.SetUiActive(false);
				}
				else
				{
					int data = (list.Count > 0) ? list[list.Count - 1] : 1;
					list.RemoveAt(list.Count - 1);
					this.ShipTowerLastItem.SetUiActive(true);
					this.ShipTowerLastItem.Refresh(data, false, list.Count - 1);
				}
				GenericScrollViewNew<ShipTowerItem, int> shipTowerLayout = this.ShipTowerLayout;
				if (shipTowerLayout != null)
				{
					shipTowerLayout.RefreshByData(list, delegate
					{
						List<ShipTowerItem> scrollItemList = this.ShipTowerLayout.GetScrollItemList();
						for (int i = scrollItemList.Count - 1; i >= 0; i--)
						{
							scrollItemList[i].GetRootItem().SetHierarchyIndex(0);
						}
						if (this.Type == EPeriodicityChallengeType.ShipTowerNormal)
						{
							scrollItemList[scrollItemList.Count - 1].SetNextItemClose();
						}
					}, false);
				}
				ShipTowerStageData currentStage = ShipTowerModel.Instance.GetCurrentStage();
				if (currentStage != null && currentStage.BelongToSeason == 0)
				{
					base.GetItem(4).SetUIActive(this.Type == EPeriodicityChallengeType.ShipTowerNormal);
					return;
				}
				base.GetItem(4).SetUIActive(this.Type == EPeriodicityChallengeType.ShipTowerPeriodicity);
				return;
			}
			else
			{
				if (flag3)
				{
					RogueWeeklyCycle? cycleConfig = WeeklyRogueModel.Instance.ActivityData.GetCycleConfig();
					int score = WeeklyRogueModel.Instance.ActivityData.Score;
					UUIText text = base.GetText(12);
					if (text != null)
					{
						text.SetText(score.ToString(), true);
					}
					LguiUtil.Instance.SetLocalTextNew(base.GetText(20), "PeriodicityChallengeItem_MaxScoreText", new <>z__ReadOnlySingleElementList<object>(cycleConfig.Value.MaxScore.ToString()));
					base.GetItem(10).SetUIActive(score < cycleConfig.Value.MaxScore);
					base.GetItem(11).SetUIActive(score >= cycleConfig.Value.MaxScore);
					base.GetItem(4).SetUIActive(false);
					return;
				}
				if (flag4)
				{
					bool flag5 = this.Type == EPeriodicityChallengeType.WheelTowerEndless;
					WheelTowerInfoPanel wheelTowerInfoPanel2 = this.WheelTowerInfoPanel;
					if (wheelTowerInfoPanel2 != null)
					{
						wheelTowerInfoPanel2.Refresh(flag5);
					}
					bool flag6 = WheelTowerModel.Instance.ActivityData.IsLevelUnlocked(true);
					base.GetItem(4).SetUIActive((!flag5 && !flag6) || (flag5 && flag6));
				}
				return;
			}
		}

		// Token: 0x0603DBC6 RID: 252870 RVA: 0x00EEB3A3 File Offset: 0x00EE95A3
		private TowerItem OnTowerLayoutUpdater()
		{
			return new TowerItem();
		}

		// Token: 0x0603DBC7 RID: 252871 RVA: 0x00EEB3AA File Offset: 0x00EE95AA
		private ShipTowerItem OnShipTowerLayoutUpdater()
		{
			return new ShipTowerItem();
		}

		// Token: 0x0603DBC8 RID: 252872 RVA: 0x00EEB3B4 File Offset: 0x00EE95B4
		private void OnClickTrackBtn()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
				return;
			}
			if (this.Type == EPeriodicityChallengeType.WeeklyRogue)
			{
				if (OnlineModel.Instance.GetIsTeamModel())
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_600064_Text", Array.Empty<object>());
					return;
				}
				WeeklyRogueData activityData = WeeklyRogueModel.Instance.ActivityData;
				if (activityData == null)
				{
					Log.Instance.Error(ELogModule.WeeklyRogue, ELogAuthor.LJQ, "点击周常肉鸽追踪 活动数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				if (!activityData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = activityData.GetUnFinishPreGuideQuestId();
					if (unFinishPreGuideQuestId > 0)
					{
						UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					}
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.WeeklyRogueActivityView, EWeeklyRogueOpenWay.UI, null);
				return;
			}
			else if (AdventureGuideModel.Instance.IsWheelTowerType(this.Type))
			{
				if (OnlineModel.Instance.GetIsTeamModel())
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_600064_Text", Array.Empty<object>());
					return;
				}
				bool endlessMode = this.Type == EPeriodicityChallengeType.WheelTowerEndless;
				WheelTowerModel.Instance.SetEndlessMode(endlessMode);
				UiManager.Instance.OpenView(EUiViewName.WheelTowerModeDetailView, null, null);
				return;
			}
			else if (AdventureGuideModel.Instance.IsTowerType(this.Type))
			{
				if (OnlineModel.Instance.GetIsTeamModel())
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_600064_Text", Array.Empty<object>());
					return;
				}
				if (this.Type == EPeriodicityChallengeType.TowerVariation)
				{
					UiManager.Instance.OpenView(EUiViewName.TowerVariationView, null, delegate(bool isSuccess, int _)
					{
						if (isSuccess)
						{
							TowerModel.Instance.OpenReviewView();
						}
					});
					return;
				}
				int num = AdventureDefine.periodicityChallengeTypeToTarget[this.Type];
				UiManager.Instance.OpenView(EUiViewName.TowerNormalView, num, delegate(bool isSuccess, int _)
				{
					if (isSuccess)
					{
						TowerModel.Instance.OpenReviewView();
					}
				});
				return;
			}
			else
			{
				if (AdventureGuideModel.Instance.IsShipTowerType(this.Type))
				{
					int[] shipTowerStateListByType = AdventureGuideModel.Instance.GetShipTowerStateListByType(this.Type);
					if (shipTowerStateListByType.Length != 0)
					{
						ShipTowerModel.Instance.OpenViewMain(new ShipTowerViewParams
						{
							StageId = new int?(shipTowerStateListByType[0])
						});
						return;
					}
				}
				ESoundAreaDataType? type = this.Data.Type;
				ESoundAreaDataType esoundAreaDataType = ESoundAreaDataType.Dungeon;
				if (type.GetValueOrDefault() == esoundAreaDataType & type != null)
				{
					this.HandleDungeonDetection();
					return;
				}
				this.HandleSilentAreaDetection();
				return;
			}
		}

		// Token: 0x0603DBC9 RID: 252873 RVA: 0x00EEB60C File Offset: 0x00EE980C
		private void HandleDungeonDetection()
		{
			DungeonDetectionRecord soundAreaDetectData = AdventureGuideModel.Instance.GetSoundAreaDetectData(this.Data.Id);
			InstanceDungeonEntrance? config = InstanceDungeonEntranceConfig.Instance.GetConfig(soundAreaDetectData.Conf.DungeonId);
			if (!AdventureGuideController.Instance.IsMarkUnlock(config.Value.MarkId))
			{
				return;
			}
			AdventureGuideModel.Instance.SetFromManualDetect(true);
			AdventureGuideController.Instance.RequestForDetection(DetectionType.Dungeon, new int[]
			{
				soundAreaDetectData.Conf.DungeonId
			}, this.Data.Id);
		}

		// Token: 0x0603DBCA RID: 252874 RVA: 0x00EEB69C File Offset: 0x00EE989C
		private void HandleSilentAreaDetection()
		{
			SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(this.Data.Id);
			if (!AdventureGuideController.Instance.IsMarkUnlock(silentAreaDetectData.Conf.MarkId))
			{
				return;
			}
			AdventureGuideModel.Instance.SetFromManualDetect(true);
			AdventureGuideController.Instance.RequestForDetection(DetectionType.SilentArea, silentAreaDetectData.Conf.LevelPlayList(), this.Data.Id);
		}

		// Token: 0x0603DBCB RID: 252875 RVA: 0x00EEB70C File Offset: 0x00EE990C
		private void OnClickLockBtn()
		{
			List<IActivityConditionData> list = new List<IActivityConditionData>();
			foreach (int conditionId in ConditionConfig.Instance.GetGroupConditionIds(this.Data.LockCon))
			{
				Condition? conditionConfig = ConditionConfig.Instance.GetConditionConfig(conditionId);
				int accessType = -1;
				if (!StringUtils.IsEmpty(conditionConfig.Value.Description))
				{
					if (conditionConfig.Value.AccessId != 0)
					{
						accessType = GetWayConfig.Instance.GetConfigById(conditionConfig.Value.AccessId).Value.SkipName;
					}
					ActivityConditionData item = new ActivityConditionData
					{
						ConditionId = conditionId,
						ConditionTextId = conditionConfig.Value.Description,
						IsFinished = false,
						AccessId = conditionConfig.Value.AccessId,
						AccessType = accessType
					};
					list.Add(item);
				}
			}
			ConditionGroupData param = new ConditionGroupData(this.Data.LockCon, list, null, false);
			UiManager.Instance.OpenView(EUiViewName.CommonConditionView, param, null);
		}

		// Token: 0x04020408 RID: 132104
		[Nullable(2)]
		private SoundAreaDetectionRecord Data;

		// Token: 0x04020409 RID: 132105
		private EPeriodicityChallengeType Type;

		// Token: 0x0402040A RID: 132106
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TowerItem, int> TowerLayout;

		// Token: 0x0402040B RID: 132107
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<ShipTowerItem, int> ShipTowerLayout;

		// Token: 0x0402040C RID: 132108
		[Nullable(2)]
		private ShipTowerItem ShipTowerLastItem;

		// Token: 0x0402040D RID: 132109
		[Nullable(2)]
		private WheelTowerInfoPanel WheelTowerInfoPanel;
	}
}
