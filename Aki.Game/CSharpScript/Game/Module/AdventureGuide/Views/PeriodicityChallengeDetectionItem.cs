using System;
using System.Collections.Generic;
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
	// Token: 0x02004EC8 RID: 20168
	[NullableContext(1)]
	[Nullable(0)]
	public class PeriodicityChallengeDetectionItem : UiPanelBase
	{
		// Token: 0x06032B5A RID: 207706 RVA: 0x00E3C7A0 File Offset: 0x00E3A9A0
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

		// Token: 0x06032B5B RID: 207707 RVA: 0x00E3CAEC File Offset: 0x00E3ACEC
		protected override UniTask OnBeforeStartAsync()
		{
			PeriodicityChallengeDetectionItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PeriodicityChallengeDetectionItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032B5C RID: 207708 RVA: 0x00E3CB30 File Offset: 0x00E3AD30
		protected override void OnStart()
		{
			base.GetItem(4).SetUIActive(false);
			base.GetItem(8).SetUIActive(false);
			base.GetSprite(2).SetUIActive(false);
			this.TowerLayout = new GenericLayout<TowerItem, int>(base.GetVerticalLayout(7), new Func<TowerItem>(this.OnTowerLayoutUpdater), null, false, true);
			this.ShipTowerLayout = new GenericScrollViewNew<ShipTowerItem, int>(base.GetScrollViewWithScrollbar(13), new Func<ShipTowerItem>(this.OnShipTowerLayoutUpdater), null, false, null);
		}

		// Token: 0x06032B5D RID: 207709 RVA: 0x00E3CBA7 File Offset: 0x00E3ADA7
		public void RefreshItem(SoundAreaDetectionRecord data)
		{
			this.Data = data;
			this.Type = (EPeriodicityChallengeType)this.Data.PeriodicityChallengeType;
			this.RefreshTitle();
			this.RefreshTraceBtn();
			this.RefreshSubItem();
		}

		// Token: 0x06032B5E RID: 207710 RVA: 0x00E3CBD4 File Offset: 0x00E3ADD4
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

		// Token: 0x06032B5F RID: 207711 RVA: 0x00E3CCD4 File Offset: 0x00E3AED4
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

		// Token: 0x06032B60 RID: 207712 RVA: 0x00E3CD44 File Offset: 0x00E3AF44
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
				this.TowerLayout.RefreshByData(difficultyAllAreaFirstFloor, null, false);
				int maxDifficulty = TowerModel.Instance.GetMaxDifficulty();
				base.GetItem(4).SetUIActive(maxDifficulty == num);
				return;
			}
			if (flag2)
			{
				List<int> list = new List<int>(AdventureGuideModel.Instance.GetShipTowerStateListByType(this.Type));
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

		// Token: 0x06032B61 RID: 207713 RVA: 0x00E3D052 File Offset: 0x00E3B252
		private TowerItem OnTowerLayoutUpdater()
		{
			return new TowerItem();
		}

		// Token: 0x06032B62 RID: 207714 RVA: 0x00E3D059 File Offset: 0x00E3B259
		private ShipTowerItem OnShipTowerLayoutUpdater()
		{
			return new ShipTowerItem();
		}

		// Token: 0x06032B63 RID: 207715 RVA: 0x00E3D060 File Offset: 0x00E3B260
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

		// Token: 0x06032B64 RID: 207716 RVA: 0x00E3D2B8 File Offset: 0x00E3B4B8
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

		// Token: 0x06032B65 RID: 207717 RVA: 0x00E3D348 File Offset: 0x00E3B548
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

		// Token: 0x06032B66 RID: 207718 RVA: 0x00E3D3B8 File Offset: 0x00E3B5B8
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

		// Token: 0x0401AEDA RID: 110298
		[Nullable(2)]
		private SoundAreaDetectionRecord Data;

		// Token: 0x0401AEDB RID: 110299
		private EPeriodicityChallengeType Type;

		// Token: 0x0401AEDC RID: 110300
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TowerItem, int> TowerLayout;

		// Token: 0x0401AEDD RID: 110301
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<ShipTowerItem, int> ShipTowerLayout;

		// Token: 0x0401AEDE RID: 110302
		[Nullable(2)]
		private ShipTowerItem ShipTowerLastItem;

		// Token: 0x0401AEDF RID: 110303
		[Nullable(2)]
		private WheelTowerInfoPanel WheelTowerInfoPanel;
	}
}
