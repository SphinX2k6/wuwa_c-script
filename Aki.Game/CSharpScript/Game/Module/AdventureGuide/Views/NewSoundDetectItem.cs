using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.RoleDevelop;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02005EDA RID: 24282
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NewSoundDetectItem : GridProxyAbstract<NewSoundDetectItemData>
	{
		// Token: 0x0603DB94 RID: 252820 RVA: 0x00EE8BCC File Offset: 0x00EE6DCC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickLockBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603DB95 RID: 252821 RVA: 0x00EE8E4C File Offset: 0x00EE704C
		protected override UniTask OnBeforeStartAsync()
		{
			NewSoundDetectItem.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NewSoundDetectItem.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603DB96 RID: 252822 RVA: 0x00EE8E90 File Offset: 0x00EE7090
		public void SyncStart()
		{
			this.ConfirmButton = new ButtonItem(null);
			this.ConfirmButton.CreateThenShowByActor(base.GetItem(1).GetOwner(), null);
			this.ConfirmButton.SetFunction(new Action<int>(this.OnTrackClick));
			this.LevelSequencePlay = new LevelSequencePlayer(this.RootItem);
			this.RewardScroll = new GenericScrollViewNew<NewSoundDetectRewardItem, INewSoundDetectRewardItemData>(base.GetScrollViewWithScrollbar(0), new Func<NewSoundDetectRewardItem>(this.OnRewardLayoutUpdater), null, false, null);
			this.NewSoundLordItem = new NewSoundLordItem();
			this.NewSoundNormalItem = new NewSoundNormalItem();
			this.NewSoundTeachItem = new NewSoundTeachItem();
			this.NewSoundTowerItem = new NewSoundTowerItem();
			this.NewSoundWeeklyRogueItem = new NewSoundWeeklyRogueItem();
			this.NewSoundVisionItem = new NewSoundVisionItem();
			this.NewSoundNoSoundAreaItem = new NewSoundNoSoundAreaItem();
			this.ItemRoleBadge = new RoleDevelopItemRoleBadge();
			this.NewSoundLordItem.CreateByActor(base.GetItem(2).GetOwner(), null);
			this.NewSoundNormalItem.CreateByActor(base.GetItem(5).GetOwner(), null);
			this.NewSoundTeachItem.CreateByActor(base.GetItem(4).GetOwner(), null);
			this.NewSoundTowerItem.CreateByActor(base.GetItem(3).GetOwner(), null);
			this.NewSoundWeeklyRogueItem.CreateByActor(base.GetItem(10).GetOwner(), null);
			this.NewSoundVisionItem.CreateByActor(base.GetItem(13).GetOwner(), null);
			this.NewSoundNoSoundAreaItem.CreateByActor(base.GetItem(14).GetOwner(), null);
			this.ItemRoleBadge.CreateByActor(base.GetItem(15).GetOwner(), null);
		}

		// Token: 0x0603DB97 RID: 252823 RVA: 0x00EE9026 File Offset: 0x00EE7226
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int>(EEventName.NewSoundAreaRefreshReward, new Action<int>(this.NewSoundAreaRefreshReward));
		}

		// Token: 0x0603DB98 RID: 252824 RVA: 0x00EE9044 File Offset: 0x00EE7244
		[NullableContext(1)]
		private NewSoundDetectRewardItem OnRewardLayoutUpdater()
		{
			return new NewSoundDetectRewardItem();
		}

		// Token: 0x0603DB99 RID: 252825 RVA: 0x00EE904C File Offset: 0x00EE724C
		[NullableContext(1)]
		private void TryPlayTrackSequence(NewSoundDetectItemData data)
		{
			List<int> tracingList = data.TracingList;
			if (tracingList != null && tracingList.Contains(data.DetectRecordData.Id))
			{
				LevelSequencePlayer levelSequencePlay = this.LevelSequencePlay;
				if (levelSequencePlay == null)
				{
					return;
				}
				levelSequencePlay.PlayLevelSequenceByName("Track", false, null, false);
			}
		}

		// Token: 0x0603DB9A RID: 252826 RVA: 0x00EE9098 File Offset: 0x00EE7298
		[NullableContext(1)]
		public void TryPlayJumpToGridSquence(NewSoundDetectItemData data)
		{
			int id = data.DetectRecordData.Id;
			int? jumpToGridId = data.JumpToGridId;
			if (!(id == jumpToGridId.GetValueOrDefault() & jumpToGridId != null))
			{
				this.LevelSequencePlay.StopSequenceByKey("Position", false, true);
				return;
			}
			this.LevelSequencePlay.PlayOrReplaySequenceByName("Position", false, null);
			UUIItem rootItem = this.RootItem;
			AUIBaseActor auibaseActor = ((rootItem != null) ? rootItem.GetOwner() : null) as AUIBaseActor;
			ULevelSequencePlayer ulevelSequencePlayer;
			if (auibaseActor == null)
			{
				ulevelSequencePlayer = null;
			}
			else
			{
				ALevelSequenceActor sequencePlayerByKey = auibaseActor.GetSequencePlayerByKey("Position");
				ulevelSequencePlayer = ((sequencePlayerByKey != null) ? sequencePlayerByKey.SequencePlayer : null);
			}
			ULevelSequencePlayer ulevelSequencePlayer2 = ulevelSequencePlayer;
			if (ulevelSequencePlayer2 == null)
			{
				return;
			}
			if (data.JumpToGridSquenceStartTimeSecond == null || data.JumpToGridSquenceStartTimeSecond.Value == 0.0)
			{
				data.JumpToGridSquenceStartTimeSecond = new double?(Time.Instance.SystemNowSeconds);
			}
			double value = data.JumpToGridSquenceStartTimeSecond.Value;
			double num = Time.Instance.SystemNowSeconds - value;
			FQualifiedFrameTime duration = ulevelSequencePlayer2.GetDuration();
			float num2 = (float)duration.Time.FrameNumber.Value + duration.Time.SubFrame;
			if (num2 < 1f)
			{
				return;
			}
			float num3 = (float)duration.Rate.Denominator / (float)duration.Rate.Numerator;
			float num4 = num2 * num3;
			if (num > (double)num4)
			{
				this.LevelSequencePlay.StopSequenceByKey("Position", false, true);
				data.JumpToGridId = new int?(0);
				return;
			}
			ulevelSequencePlayer2.JumpToSeconds((float)num);
		}

		// Token: 0x0603DB9B RID: 252827 RVA: 0x00EE9204 File Offset: 0x00EE7404
		[NullableContext(1)]
		public override void Refresh(NewSoundDetectItemData sourceData, bool isSelected, int gridIndex)
		{
			SoundAreaDetectionRecord detectRecordData = sourceData.DetectRecordData;
			this.Data = detectRecordData;
			UiPanelBase uiPanelBase = this.LeftItem as UiPanelBase;
			if (uiPanelBase != null)
			{
				uiPanelBase.SetUiActive(false);
			}
			EDungeonType secondary = (EDungeonType)detectRecordData.Secondary;
			if (secondary <= EDungeonType.NoSoundArea)
			{
				switch (secondary)
				{
				case EDungeonType.Tower:
					goto IL_8F;
				case EDungeonType.Tutorial:
				{
					NewSoundTeachItem newSoundTeachItem = this.NewSoundTeachItem;
					if (newSoundTeachItem != null)
					{
						newSoundTeachItem.SetUiActive(true);
					}
					this.LeftItem = this.NewSoundTeachItem;
					goto IL_150;
				}
				case EDungeonType.Weekly:
					break;
				default:
					if (secondary != EDungeonType.Boss)
					{
						if (secondary != EDungeonType.NoSoundArea)
						{
							goto IL_132;
						}
						NewSoundNoSoundAreaItem newSoundNoSoundAreaItem = this.NewSoundNoSoundAreaItem;
						if (newSoundNoSoundAreaItem != null)
						{
							newSoundNoSoundAreaItem.SetUiActive(true);
						}
						this.LeftItem = this.NewSoundNoSoundAreaItem;
						goto IL_150;
					}
					break;
				}
				NewSoundVisionItem newSoundVisionItem = this.NewSoundVisionItem;
				if (newSoundVisionItem != null)
				{
					newSoundVisionItem.SetUiActive(true);
				}
				this.LeftItem = this.NewSoundVisionItem;
				goto IL_150;
			}
			if (secondary != EDungeonType.ShipTower)
			{
				if (secondary == EDungeonType.WeeklyRogue)
				{
					NewSoundWeeklyRogueItem newSoundWeeklyRogueItem = this.NewSoundWeeklyRogueItem;
					if (newSoundWeeklyRogueItem != null)
					{
						newSoundWeeklyRogueItem.SetUiActive(true);
					}
					this.LeftItem = this.NewSoundWeeklyRogueItem;
					goto IL_150;
				}
				if (secondary == EDungeonType.LordGym)
				{
					NewSoundLordItem newSoundLordItem = this.NewSoundLordItem;
					if (newSoundLordItem != null)
					{
						newSoundLordItem.SetUiActive(true);
					}
					this.LeftItem = this.NewSoundLordItem;
					goto IL_150;
				}
				goto IL_132;
			}
			IL_8F:
			NewSoundTowerItem newSoundTowerItem = this.NewSoundTowerItem;
			if (newSoundTowerItem != null)
			{
				newSoundTowerItem.SetUiActive(true);
			}
			this.LeftItem = this.NewSoundTowerItem;
			goto IL_150;
			IL_132:
			NewSoundNormalItem newSoundNormalItem = this.NewSoundNormalItem;
			if (newSoundNormalItem != null)
			{
				newSoundNormalItem.SetUiActive(true);
			}
			this.LeftItem = this.NewSoundNormalItem;
			IL_150:
			INewSoundItem leftItem = this.LeftItem;
			if (leftItem != null)
			{
				leftItem.Update(sourceData);
			}
			RoleDevelopModel instance = RoleDevelopModel.Instance;
			bool flag = this.ItemRoleBadge != null && instance != null && instance.DevTargetRoleId != 0 && instance.GetDevelopRoleDeficitDetectionIdSet().Contains(detectRecordData.Id);
			RoleDevelopItemRoleBadge itemRoleBadge = this.ItemRoleBadge;
			if (itemRoleBadge != null)
			{
				itemRoleBadge.SetUiActive(flag);
			}
			if (flag)
			{
				this.ItemRoleBadge.SetRoleHeadIconPath(instance.GetDevelopRoleSmallIconPath());
			}
			bool isDetectionPreOpenByData = AdventureGuideModel.Instance.GetIsDetectionPreOpenByData(detectRecordData);
			bool flag3;
			if (!isDetectionPreOpenByData)
			{
				bool? isLock = detectRecordData.IsLock;
				bool flag2 = false;
				flag3 = (isLock.GetValueOrDefault() == flag2 & isLock != null);
			}
			else
			{
				flag3 = true;
			}
			bool flag4 = flag3;
			base.GetItem(7).SetUIActive(false);
			ButtonItem confirmButton = this.ConfirmButton;
			if (confirmButton != null)
			{
				confirmButton.SetUiActive(flag4);
			}
			ButtonItem confirmButton2 = this.ConfirmButton;
			if (confirmButton2 != null)
			{
				confirmButton2.SetLocalTextNew(this.GetConfirmButtonTextId(), Array.Empty<object>());
			}
			if (this.Data.Secondary == 63 || this.Data.Secondary == 64 || this.Data.Secondary == 61)
			{
				base.GetItem(6).SetUIActive(false);
				base.GetItem(11).SetUIActive(!flag4);
			}
			else
			{
				base.GetItem(6).SetUIActive(!flag4);
				base.GetItem(11).SetUIActive(false);
			}
			if (secondary == EDungeonType.Tutorial || secondary == EDungeonType.SkillTeach)
			{
				bool uiactive = AdventureGuideModel.Instance.IsRoleTutorialNew(detectRecordData.Id) && !AdventureGuideModel.Instance.IsDetectionFinished(this.Data);
				base.GetItem(9).SetUIActive(uiactive);
			}
			else
			{
				bool flag5 = AdventureGuideModel.Instance.IsDetectionNewContentOpen(detectRecordData);
				bool flag6 = !isDetectionPreOpenByData && flag5;
				base.GetItem(9).SetUIActive(flag6);
				if (flag6)
				{
					AdventureGuideModel.Instance.SetAdventureItemNew(detectRecordData.Id);
				}
			}
			InstanceDungeon? instanceDungeon = null;
			int num = 0;
			ESoundAreaDataType? type = detectRecordData.Type;
			ESoundAreaDataType esoundAreaDataType = ESoundAreaDataType.Dungeon;
			if (type.GetValueOrDefault() == esoundAreaDataType & type != null)
			{
				DungeonDetection dungeonDetection = (T1)detectRecordData.Conf.Value;
				if (dungeonDetection.SubDungeonId != 0 && InstanceDungeonConfig.Instance.GetConfig(dungeonDetection.SubDungeonId) == null && detectRecordData.Secondary == 6)
				{
					return;
				}
			}
			else
			{
				SilentAreaDetection silentAreaDetection = (T2)detectRecordData.Conf.Value;
				if (detectRecordData.Secondary == 61)
				{
					num = silentAreaDetection.AdditionalId;
				}
			}
			int num2 = 0;
			if (num != 0)
			{
				num2 = LordGymModel.Instance.GetHasFinishLord(num) + 1;
			}
			num2 = ((num2 != 0) ? num2 : AdventureGuideModel.Instance.CurrentShowLevel);
			Dictionary<int, int> dictionary = (this.Data.Secondary == 63 || this.Data.Secondary == 64) ? AdventureGuideConfig.Instance.GetNightMareShowReward(this.Data.ShowRewardMapCalabash) : AdventureGuideConfig.Instance.GetShowReward(detectRecordData.ShowRewardMap, new int?(num2));
			if (dictionary == null)
			{
				return;
			}
			bool haveFinish = AdventureGuideModel.Instance.IsDetectionFinished(this.Data);
			List<INewSoundDetectRewardItemData> list = new List<INewSoundDetectRewardItemData>();
			foreach (int num3 in dictionary.Keys)
			{
				TItem itemData = new TItem(new InventoryDefine.GetItemData(num3, 0), dictionary[num3]);
				NewSoundDetectRewardItemData item = new NewSoundDetectRewardItemData
				{
					ItemData = itemData,
					HaveFinish = haveFinish
				};
				list.Add(item);
			}
			this.RewardScroll.RefreshByData(list, new Action(this.RewardScrollRefreshCallBack), false);
			this.TryPlayTrackSequence(sourceData);
			this.TryPlayJumpToGridSquence(sourceData);
			int? nightMareParam = sourceData.NightMareParam;
			int id = sourceData.DetectRecordData.Id;
			if (nightMareParam.GetValueOrDefault() == id & nightMareParam != null)
			{
				SoundAreaDetectionRecord detectRecordData2 = sourceData.DetectRecordData;
				if (detectRecordData2 != null && detectRecordData2.IsLock.GetValueOrDefault())
				{
					this.OnClickLockBtn();
				}
			}
		}

		// Token: 0x0603DB9C RID: 252828 RVA: 0x00EE9744 File Offset: 0x00EE7944
		private void OnTrackClick(int _)
		{
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
				return;
			}
			if (this.Data.Secondary == 6 || this.Data.Secondary == 62)
			{
				int dungeonId = ((T1)this.Data.Conf.Value).SubDungeonId;
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleTeachTip);
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(((T1)this.Data.Conf.Value).Name, null);
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					localTextNew
				});
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					int fightFormationId = InstanceDungeonConfig.Instance.GetConfig(dungeonId).Value.FightFormationId;
					Aki.Config.FightFormation? fightFormation;
					int[] array2 = (FormationConfig.Instance.GetFightFormationConfig(fightFormationId) != null) ? fightFormation.GetValueOrDefault().AutoRole() : null;
					if (((array2 != null) ? array2.Length : 0) <= 0)
					{
						Log.Instance.Error(ELogModule.Role, ELogAuthor.LJQ, "未配置出战人物", default(ReadOnlySpan<ValueTuple<string, object>>));
						return;
					}
					List<int> list = new List<int>();
					foreach (int id in array2)
					{
						list.Add(RoleConfig.Instance.GetTrialRoleIdConfigByGroupId(id));
					}
					AdventureGuideCtx adventureGuideCtx = AdventureGuideCtx.Create();
					adventureGuideCtx.DungeonDetectionId = this.Data.Id;
					InstanceDungeonModel.Instance.InstanceEnterContentText.AdventureGuideCtx = adventureGuideCtx;
					InstanceDungeonController.Instance.PrewarTeamFightRequest(dungeonId, list, 0, 0, null, null);
					if (this.Data.Secondary == 6 || this.Data.Secondary == 62)
					{
						AdventureGuideModel.Instance.SetRoleTutorialNew(this.Data.Id);
						return;
					}
					AdventureGuideModel.Instance.SetAdventureItemNew(this.Data.Id);
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			if (this.Data.Secondary == 29)
			{
				WeeklyRogueData activityData = WeeklyRogueModel.Instance.ActivityData;
				if (activityData == null)
				{
					Log.Instance.Error(ELogModule.WeeklyRogue, ELogAuthor.LPH, "点击周常肉鸽追踪 活动数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				RogueWeeklyCycle? cycleConfig = activityData.GetCycleConfig();
				WorldMapViewOpenParams param = new WorldMapViewOpenParams
				{
					MarkId = new int?(cycleConfig.Value.MapMark),
					MarkType = EMarkType.SmallTeleport
				};
				UiManager.Instance.OpenView(EUiViewName.WorldMapView, param, null);
				return;
			}
			else
			{
				if (this.Data.Secondary == 61)
				{
					if (OnlineModel.Instance.GetIsTeamModel())
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_600064_Text", Array.Empty<object>());
						return;
					}
					if (GameModeController.Instance.IsInInstance())
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_200172_Text", Array.Empty<object>());
						return;
					}
					int additionalId = ((T2)this.Data.Conf.Value).AdditionalId;
					LordGymEntrance? lordGymEntranceConfig = LordGymConfig.Instance.GetLordGymEntranceConfig(additionalId);
					if (lordGymEntranceConfig == null)
					{
						return;
					}
					LordGymModel.Instance.EntranceEntityId = additionalId;
					LordGymModel.Instance.EntryChallengeId = additionalId;
					int[] array = lordGymEntranceConfig.Value.LordGymList();
					if (array.Length == 0)
					{
						return;
					}
					LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(array[0]);
					if (lordGymConfig == null)
					{
						return;
					}
					if (lordGymConfig.Value.Version == 3)
					{
						LordGymModel.Instance.SkipBossSelectInFlow = true;
						InstanceDungeonEntranceController.Instance.EnterEntrance(3924, 0, null);
						return;
					}
					if (lordGymConfig.Value.Version == 1)
					{
						LordGymModel.Instance.SkipBossSelectInFlow = true;
						LordGymController.Instance.OpenLordGymViaGuide(ELordGymVersion.First, additionalId);
						return;
					}
					if (lordGymConfig.Value.Version == 2)
					{
						LordGymModel.Instance.SkipBossSelectInFlow = true;
						LordGymController.Instance.OpenLordGymViaGuide(ELordGymVersion.Second, additionalId);
						return;
					}
					if (lordGymConfig.Value.Version == 4)
					{
						LordGymModel.Instance.SkipBossSelectInFlow = true;
						InstanceDungeonEntranceController.Instance.EnterEntrance(3925, 0, null);
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

		// Token: 0x0603DB9D RID: 252829 RVA: 0x00EE9A78 File Offset: 0x00EE7C78
		private void NewSoundAreaRefreshReward(int worldLevel)
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.Secondary == 63 || this.Data.Secondary == 64)
			{
				return;
			}
			Dictionary<int, int> showReward = AdventureGuideConfig.Instance.GetShowReward(this.Data.ShowRewardMap, new int?(worldLevel));
			bool haveFinish = AdventureGuideModel.Instance.IsDetectionFinished(this.Data);
			List<INewSoundDetectRewardItemData> list = new List<INewSoundDetectRewardItemData>();
			foreach (int num in showReward.Keys)
			{
				TItem itemData = new TItem(new InventoryDefine.GetItemData(num, 0), showReward[num]);
				NewSoundDetectRewardItemData item = new NewSoundDetectRewardItemData
				{
					ItemData = itemData,
					HaveFinish = haveFinish
				};
				list.Add(item);
			}
			this.RewardScroll.RefreshByData(list, new Action(this.RewardScrollRefreshCallBack), false);
		}

		// Token: 0x0603DB9E RID: 252830 RVA: 0x00EE9B70 File Offset: 0x00EE7D70
		private void RewardScrollRefreshCallBack()
		{
			GenericScrollViewNew<NewSoundDetectRewardItem, INewSoundDetectRewardItemData> rewardScroll = this.RewardScroll;
			TWeakObjectPtr<UUIItem>? tweakObjectPtr;
			if (((rewardScroll != null) ? ((rewardScroll.ContentItem != null) ? tweakObjectPtr.GetValueOrDefault().Get() : null) : null) != null)
			{
				GenericScrollViewNew<NewSoundDetectRewardItem, INewSoundDetectRewardItemData> rewardScroll2 = this.RewardScroll;
				if (rewardScroll2 == null)
				{
					return;
				}
				rewardScroll2.ScrollToLeft(0);
			}
		}

		// Token: 0x0603DB9F RID: 252831 RVA: 0x00EE9BC4 File Offset: 0x00EE7DC4
		private void HandleDungeonDetection()
		{
			if (AdventureGuideModel.Instance.GetIsDetectionPreOpenByData(this.Data))
			{
				this.HandlePreOpenDetection();
				return;
			}
			if (AdventureGuideModel.Instance.TryAdventureJumpByDungeon(this.Data.DungeonDetectionRecord))
			{
				return;
			}
			DungeonDetectionRecord soundAreaDetectData = AdventureGuideModel.Instance.GetSoundAreaDetectData(this.Data.Id);
			int jumpType = ((T1)this.Data.Conf.Value).JumpType;
			int dungeonId = soundAreaDetectData.Conf.DungeonId;
			if (jumpType == 2)
			{
				AdventureGuideModel.Instance.SetFromManualDetect(true);
				AdventureGuideController.Instance.RequestForDetection((soundAreaDetectData.Conf.Secondary != 2) ? DetectionType.Dungeon : DetectionType.SilentArea, new int[]
				{
					dungeonId
				}, this.Data.Id);
				return;
			}
			InstanceDungeonEntrance? config = InstanceDungeonEntranceConfig.Instance.GetConfig(dungeonId);
			if (!AdventureGuideController.Instance.IsMarkUnlock(config.Value.MarkId))
			{
				return;
			}
			AdventureGuideModel.Instance.SetFromManualDetect(true);
			AdventureGuideController.Instance.RequestForDetection((soundAreaDetectData.Conf.Secondary != 2) ? DetectionType.Dungeon : DetectionType.SilentArea, new int[]
			{
				dungeonId
			}, this.Data.Id);
		}

		// Token: 0x0603DBA0 RID: 252832 RVA: 0x00EE9CF8 File Offset: 0x00EE7EF8
		private void HandlePreOpenDetection()
		{
			if (OnlineModel.Instance.GetIsTeamModel())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("CantUseInMultiplayerMode", Array.Empty<object>());
				return;
			}
			bool flag = false;
			PreOpenDetection? preOpenDetectionConf = AdventureGuideModel.Instance.GetPreOpenDetectionConf(this.Data.Id, this.Data.Type.Value, this.Data.PreOpenId);
			if (preOpenDetectionConf != null)
			{
				flag = preOpenDetectionConf.Value.Spoiler;
			}
			if (flag)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PreOpenSpoilConfirmBox);
				confirmBoxDataNew.FunctionMap.Add(2, new Action(this.HandlePreOpenDetectionConfirmAction));
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.HandlePreOpenDetectionConfirmAction();
		}

		// Token: 0x0603DBA1 RID: 252833 RVA: 0x00EE9DAC File Offset: 0x00EE7FAC
		private void HandleSilentAreaDetection()
		{
			if (AdventureGuideModel.Instance.GetIsDetectionPreOpenByData(this.Data))
			{
				this.HandlePreOpenDetection();
				return;
			}
			if (AdventureGuideModel.Instance.TryAdventureJumpBySilent(this.Data.SilentAreaDetectionRecord))
			{
				return;
			}
			SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(this.Data.Id);
			if (((T2)this.Data.Conf.Value).JumpType == 2)
			{
				AdventureGuideModel.Instance.SetFromManualDetect(true);
				AdventureGuideController.Instance.RequestForDetection(DetectionType.SilentArea, silentAreaDetectData.Conf.LevelPlayList(), this.Data.Id);
				return;
			}
			if (!AdventureGuideController.Instance.IsMarkUnlock(silentAreaDetectData.Conf.MarkId))
			{
				return;
			}
			AdventureGuideModel.Instance.SetFromManualDetect(true);
			AdventureGuideController.Instance.RequestForDetection(DetectionType.SilentArea, silentAreaDetectData.Conf.LevelPlayList(), this.Data.Id);
		}

		// Token: 0x0603DBA2 RID: 252834 RVA: 0x00EE9EA0 File Offset: 0x00EE80A0
		private int? GetMarkIdForJumpType()
		{
			ESoundAreaDataType? type = this.Data.Type;
			ESoundAreaDataType esoundAreaDataType = ESoundAreaDataType.Dungeon;
			if (type.GetValueOrDefault() == esoundAreaDataType & type != null)
			{
				DungeonDetectionRecord soundAreaDetectData = AdventureGuideModel.Instance.GetSoundAreaDetectData(this.Data.Id);
				if (soundAreaDetectData == null)
				{
					return null;
				}
				InstanceDungeonEntrance? config = InstanceDungeonEntranceConfig.Instance.GetConfig(soundAreaDetectData.Conf.DungeonId);
				if (config == null)
				{
					return null;
				}
				return new int?(config.Value.MarkId);
			}
			else
			{
				SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(this.Data.Id);
				if (silentAreaDetectData == null)
				{
					return null;
				}
				return new int?(silentAreaDetectData.Conf.MarkId);
			}
		}

		// Token: 0x0603DBA3 RID: 252835 RVA: 0x00EE9F70 File Offset: 0x00EE8170
		[NullableContext(1)]
		private string GetConfirmButtonTextId()
		{
			ESoundAreaDataType? type = this.Data.Type;
			ESoundAreaDataType esoundAreaDataType = ESoundAreaDataType.Dungeon;
			int jumpType;
			if (type.GetValueOrDefault() == esoundAreaDataType & type != null)
			{
				jumpType = ((T1)this.Data.Conf.Value).JumpType;
			}
			else
			{
				jumpType = ((T2)this.Data.Conf.Value).JumpType;
			}
			EDetectionJumpType edetectionJumpType = (EDetectionJumpType)jumpType;
			if (edetectionJumpType == EDetectionJumpType.MapMark)
			{
				return "NewSoundDetectGoTo";
			}
			if (edetectionJumpType == EDetectionJumpType.DirectEntrance)
			{
				return "NewSoundDetectDirectChallenge";
			}
			int? markIdForJumpType = this.GetMarkIdForJumpType();
			if (markIdForJumpType != null && MapModel.Instance.MapMarkIsCanTeleport(markIdForJumpType.Value))
			{
				return "NewSoundDetectDirectChallenge";
			}
			if (!AdventureGuideModel.Instance.GetIsDetectionPreOpenByData(this.Data))
			{
				return "NewSoundDetectGoTo";
			}
			return "NewSoundDetectDirectChallenge";
		}

		// Token: 0x0603DBA4 RID: 252836 RVA: 0x00EEA044 File Offset: 0x00EE8244
		private void HandlePreOpenDetectionConfirmAction()
		{
			AdventureGuideController.Instance.HandlePreOpenDetection(this.Data.Id, this.Data.Type.Value, this.Data.PreOpenId);
		}

		// Token: 0x0603DBA5 RID: 252837 RVA: 0x00EEA078 File Offset: 0x00EE8278
		protected override void OnBeforeDestroy()
		{
			NewSoundLordItem newSoundLordItem = this.NewSoundLordItem;
			if (newSoundLordItem != null)
			{
				newSoundLordItem.Destroy(null);
			}
			NewSoundNormalItem newSoundNormalItem = this.NewSoundNormalItem;
			if (newSoundNormalItem != null)
			{
				newSoundNormalItem.Destroy(null);
			}
			NewSoundTeachItem newSoundTeachItem = this.NewSoundTeachItem;
			if (newSoundTeachItem != null)
			{
				newSoundTeachItem.Destroy(null);
			}
			NewSoundTowerItem newSoundTowerItem = this.NewSoundTowerItem;
			if (newSoundTowerItem != null)
			{
				newSoundTowerItem.Destroy(null);
			}
			NewSoundWeeklyRogueItem newSoundWeeklyRogueItem = this.NewSoundWeeklyRogueItem;
			if (newSoundWeeklyRogueItem != null)
			{
				newSoundWeeklyRogueItem.Destroy(null);
			}
			EventSystem.Instance.Remove(EEventName.NewSoundAreaRefreshReward, new Action<int>(this.NewSoundAreaRefreshReward));
		}

		// Token: 0x0603DBA6 RID: 252838 RVA: 0x00EEA0FC File Offset: 0x00EE82FC
		private void OnClickLockBtn()
		{
			List<IActivityConditionData> list = new List<IActivityConditionData>();
			foreach (int conditionId in ConditionConfig.Instance.GetGroupConditionIds(this.Data.LockCon))
			{
				Condition? conditionConfig = ConditionConfig.Instance.GetConditionConfig(conditionId);
				int accessType = -1;
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
			ConditionGroupData param = new ConditionGroupData(this.Data.LockCon, list, null, false);
			UiManager.Instance.OpenView(EUiViewName.CommonConditionView, param, null);
		}

		// Token: 0x040203CA RID: 132042
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<NewSoundDetectRewardItem, INewSoundDetectRewardItemData> RewardScroll;

		// Token: 0x040203CB RID: 132043
		private SoundAreaDetectionRecord Data;

		// Token: 0x040203CC RID: 132044
		private ButtonItem ConfirmButton;

		// Token: 0x040203CD RID: 132045
		private INewSoundItem LeftItem;

		// Token: 0x040203CE RID: 132046
		private NewSoundLordItem NewSoundLordItem;

		// Token: 0x040203CF RID: 132047
		private NewSoundNormalItem NewSoundNormalItem;

		// Token: 0x040203D0 RID: 132048
		private NewSoundTeachItem NewSoundTeachItem;

		// Token: 0x040203D1 RID: 132049
		private NewSoundTowerItem NewSoundTowerItem;

		// Token: 0x040203D2 RID: 132050
		private NewSoundWeeklyRogueItem NewSoundWeeklyRogueItem;

		// Token: 0x040203D3 RID: 132051
		private NewSoundVisionItem NewSoundVisionItem;

		// Token: 0x040203D4 RID: 132052
		private NewSoundNoSoundAreaItem NewSoundNoSoundAreaItem;

		// Token: 0x040203D5 RID: 132053
		private LevelSequencePlayer LevelSequencePlay;

		// Token: 0x040203D6 RID: 132054
		private RoleDevelopItemRoleBadge ItemRoleBadge;
	}
}
