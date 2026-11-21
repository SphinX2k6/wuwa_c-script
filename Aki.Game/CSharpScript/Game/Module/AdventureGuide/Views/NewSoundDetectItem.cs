using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
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
	// Token: 0x02004EC1 RID: 20161
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class NewSoundDetectItem : GridProxyAbstract<NewSoundDetectItemData>
	{
		// Token: 0x06032B26 RID: 207654 RVA: 0x00E3A3A4 File Offset: 0x00E385A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickLockBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnMapClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(17, new Action(this.OnMapClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032B27 RID: 207655 RVA: 0x00E3A6B0 File Offset: 0x00E388B0
		protected override UniTask OnBeforeStartAsync()
		{
			NewSoundDetectItem.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NewSoundDetectItem.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032B28 RID: 207656 RVA: 0x00E3A6F4 File Offset: 0x00E388F4
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

		// Token: 0x06032B29 RID: 207657 RVA: 0x00E3A88C File Offset: 0x00E38A8C
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int>(EEventName.NewSoundAreaRefreshReward, new Action<int>(this.NewSoundAreaRefreshReward));
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Add(EEventName.UpdateNavigationListener, new Action(this.OnNavigationFocusChange));
			EventSystem.Instance.Add(EEventName.ResetNavigationListener, new Action(this.OnNavigationFocusChange));
		}

		// Token: 0x06032B2A RID: 207658 RVA: 0x00E3A909 File Offset: 0x00E38B09
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			if (this.Data == null || !base.IsUiActiveInHierarchy())
			{
				return;
			}
			this.RefreshButtonState();
		}

		// Token: 0x06032B2B RID: 207659 RVA: 0x00E3A922 File Offset: 0x00E38B22
		private void OnNavigationFocusChange()
		{
			if (this.Data == null || !base.IsUiActiveInHierarchy())
			{
				return;
			}
			this.RefreshButtonState();
		}

		// Token: 0x06032B2C RID: 207660 RVA: 0x00E3A93C File Offset: 0x00E38B3C
		private void RefreshButtonState()
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
			ButtonItem confirmButton = this.ConfirmButton;
			if (confirmButton != null)
			{
				confirmButton.SetUiActive(flag3);
			}
			ButtonItem confirmButton2 = this.ConfirmButton;
			if (confirmButton2 != null)
			{
				confirmButton2.SetLocalTextNew(this.GetConfirmButtonTextId(), Array.Empty<object>());
			}
			this.RefreshMapButtonState();
			if (this.Data.Secondary == 63 || this.Data.Secondary == 64 || this.Data.Secondary == 61)
			{
				base.GetItem(6).SetUIActive(false);
				base.GetItem(11).SetUIActive(!flag3);
				return;
			}
			base.GetItem(6).SetUIActive(!flag3);
			base.GetItem(11).SetUIActive(false);
		}

		// Token: 0x06032B2D RID: 207661 RVA: 0x00E3AA20 File Offset: 0x00E38C20
		private bool IsNavigationFocusOnSelf()
		{
			AActor rootActor = base.GetRootActor();
			if (rootActor == null || !rootActor.IsValid())
			{
				return false;
			}
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			AActor aactor = (currentNavigationFocusListener != null) ? currentNavigationFocusListener.GetOwner() : null;
			int num = 0;
			while (aactor != null && num < 16)
			{
				if (aactor == rootActor)
				{
					return true;
				}
				aactor = aactor.GetAttachParentActor();
				num++;
			}
			return false;
		}

		// Token: 0x06032B2E RID: 207662 RVA: 0x00E3AA78 File Offset: 0x00E38C78
		private void RefreshMapButtonState()
		{
			bool flag = this.ShouldShowMapButton();
			UUIButtonComponent button = base.GetButton(16);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag && !Info.Instance.IsInGamepad());
				}
			}
			UUIButtonComponent button2 = base.GetButton(17);
			if (button2 == null)
			{
				return;
			}
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 == null)
			{
				return;
			}
			uuiitem2.SetUIActive(flag && Info.Instance.IsInGamepad() && this.IsNavigationFocusOnSelf());
		}

		// Token: 0x06032B2F RID: 207663 RVA: 0x00E3AB01 File Offset: 0x00E38D01
		[NullableContext(1)]
		private NewSoundDetectRewardItem OnRewardLayoutUpdater()
		{
			return new NewSoundDetectRewardItem();
		}

		// Token: 0x06032B30 RID: 207664 RVA: 0x00E3AB08 File Offset: 0x00E38D08
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

		// Token: 0x06032B31 RID: 207665 RVA: 0x00E3AB54 File Offset: 0x00E38D54
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

		// Token: 0x06032B32 RID: 207666 RVA: 0x00E3ACC0 File Offset: 0x00E38EC0
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
			base.GetItem(7).SetUIActive(false);
			this.RefreshButtonState();
			if (secondary == EDungeonType.Tutorial || secondary == EDungeonType.SkillTeach)
			{
				bool uiactive = AdventureGuideModel.Instance.IsRoleTutorialNew(detectRecordData.Id) && !AdventureGuideModel.Instance.IsDetectionFinished(this.Data);
				base.GetItem(9).SetUIActive(uiactive);
			}
			else
			{
				bool flag2 = AdventureGuideModel.Instance.IsDetectionNewContentOpen(detectRecordData);
				bool flag3 = !isDetectionPreOpenByData && flag2;
				base.GetItem(9).SetUIActive(flag3);
				if (flag3 && secondary != EDungeonType.LordGym)
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

		// Token: 0x06032B33 RID: 207667 RVA: 0x00E3B148 File Offset: 0x00E39348
		private void OnTrackClick(int _)
		{
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
				return;
			}
			AdventureGuideModel.Instance.SendAdventureGuideBtnClickLogData((this.GetConfirmButtonTextId() == "NewSoundDetectGoTo") ? EAdventureGuideBtnClickType.GoTo : EAdventureGuideBtnClickType.DirectChallenge, this.Data.Id, this.Data.Secondary, this.GetLogComboType());
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

		// Token: 0x06032B34 RID: 207668 RVA: 0x00E3B4B8 File Offset: 0x00E396B8
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

		// Token: 0x06032B35 RID: 207669 RVA: 0x00E3B5B0 File Offset: 0x00E397B0
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

		// Token: 0x06032B36 RID: 207670 RVA: 0x00E3B604 File Offset: 0x00E39804
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

		// Token: 0x06032B37 RID: 207671 RVA: 0x00E3B738 File Offset: 0x00E39938
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

		// Token: 0x06032B38 RID: 207672 RVA: 0x00E3B7EC File Offset: 0x00E399EC
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

		// Token: 0x06032B39 RID: 207673 RVA: 0x00E3B8E0 File Offset: 0x00E39AE0
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

		// Token: 0x06032B3A RID: 207674 RVA: 0x00E3B9B0 File Offset: 0x00E39BB0
		[NullableContext(1)]
		private string GetConfirmButtonTextId()
		{
			EDetectionJumpType jumpTye = this.GetJumpTye();
			if (jumpTye == EDetectionJumpType.MapMark)
			{
				return "NewSoundDetectGoTo";
			}
			if (jumpTye == EDetectionJumpType.DirectEntrance)
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

		// Token: 0x06032B3B RID: 207675 RVA: 0x00E3BA1D File Offset: 0x00E39C1D
		private void HandlePreOpenDetectionConfirmAction()
		{
			AdventureGuideController.Instance.HandlePreOpenDetection(this.Data.Id, this.Data.Type.Value, this.Data.PreOpenId);
		}

		// Token: 0x06032B3C RID: 207676 RVA: 0x00E3BA50 File Offset: 0x00E39C50
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
			EventSystem.Instance.Remove<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Remove(EEventName.UpdateNavigationListener, new Action(this.OnNavigationFocusChange));
			EventSystem.Instance.Remove(EEventName.ResetNavigationListener, new Action(this.OnNavigationFocusChange));
		}

		// Token: 0x06032B3D RID: 207677 RVA: 0x00E3BB28 File Offset: 0x00E39D28
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

		// Token: 0x06032B3E RID: 207678 RVA: 0x00E3BC34 File Offset: 0x00E39E34
		private EDetectionJumpType GetJumpTye()
		{
			ESoundAreaDataType? type = this.Data.Type;
			ESoundAreaDataType esoundAreaDataType = ESoundAreaDataType.Dungeon;
			if (!(type.GetValueOrDefault() == esoundAreaDataType & type != null))
			{
				return (EDetectionJumpType)((T2)this.Data.Conf.Value).JumpType;
			}
			return (EDetectionJumpType)((T1)this.Data.Conf.Value).JumpType;
		}

		// Token: 0x06032B3F RID: 207679 RVA: 0x00E3BCA8 File Offset: 0x00E39EA8
		private bool ShouldShowMapButton()
		{
			bool isDetectionPreOpenByData = AdventureGuideModel.Instance.GetIsDetectionPreOpenByData(this.Data);
			if (!isDetectionPreOpenByData && this.Data.IsLock.GetValueOrDefault())
			{
				return false;
			}
			EDetectionJumpType jumpTye = this.GetJumpTye();
			if (jumpTye == EDetectionJumpType.MapMark)
			{
				return false;
			}
			if (jumpTye == EDetectionJumpType.DirectEntrance)
			{
				return true;
			}
			int? markIdForJumpType = this.GetMarkIdForJumpType();
			return (markIdForJumpType != null && MapModel.Instance.MapMarkIsCanTeleport(markIdForJumpType.Value)) || isDetectionPreOpenByData;
		}

		// Token: 0x06032B40 RID: 207680 RVA: 0x00E3BD18 File Offset: 0x00E39F18
		private EAdventureGuideBtnComboType GetLogComboType()
		{
			if (!this.ShouldShowMapButton())
			{
				return EAdventureGuideBtnComboType.OnlyGoTo;
			}
			return EAdventureGuideBtnComboType.ChallengeAndMapJump;
		}

		// Token: 0x06032B41 RID: 207681 RVA: 0x00E3BD28 File Offset: 0x00E39F28
		private unsafe void OnMapClick()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
				return;
			}
			AdventureGuideModel.Instance.SendAdventureGuideBtnClickLogData(EAdventureGuideBtnClickType.MapJump, this.Data.Id, this.Data.Secondary, this.GetLogComboType());
			int? markIdForJumpType = this.GetMarkIdForJumpType();
			if (markIdForJumpType == null || markIdForJumpType.Value == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AdventureGuide;
				ELogAuthor author = ELogAuthor.LY;
				string message = "点击地图跳转按钮但未找到对应地图标记";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id:", this.Data.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			MapConfig instance2 = MapConfig.Instance;
			MapMark? mapMark = (instance2 != null) ? instance2.GetConfigMark(markIdForJumpType.Value) : null;
			if (mapMark == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.AdventureGuide;
				ELogAuthor author2 = ELogAuthor.LY;
				string message2 = "地图标记配置不存在";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id:", this.Data.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MarkId:", markIdForJumpType.Value);
				instance3.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = new int?(mapMark.Value.MarkId),
				MarkType = (EMarkType)mapMark.Value.ObjectType,
				OpenFogId = new int?(0)
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
		}

		// Token: 0x0401AE9B RID: 110235
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<NewSoundDetectRewardItem, INewSoundDetectRewardItemData> RewardScroll;

		// Token: 0x0401AE9C RID: 110236
		private SoundAreaDetectionRecord Data;

		// Token: 0x0401AE9D RID: 110237
		private ButtonItem ConfirmButton;

		// Token: 0x0401AE9E RID: 110238
		private INewSoundItem LeftItem;

		// Token: 0x0401AE9F RID: 110239
		private NewSoundLordItem NewSoundLordItem;

		// Token: 0x0401AEA0 RID: 110240
		private NewSoundNormalItem NewSoundNormalItem;

		// Token: 0x0401AEA1 RID: 110241
		private NewSoundTeachItem NewSoundTeachItem;

		// Token: 0x0401AEA2 RID: 110242
		private NewSoundTowerItem NewSoundTowerItem;

		// Token: 0x0401AEA3 RID: 110243
		private NewSoundWeeklyRogueItem NewSoundWeeklyRogueItem;

		// Token: 0x0401AEA4 RID: 110244
		private NewSoundVisionItem NewSoundVisionItem;

		// Token: 0x0401AEA5 RID: 110245
		private NewSoundNoSoundAreaItem NewSoundNoSoundAreaItem;

		// Token: 0x0401AEA6 RID: 110246
		private LevelSequencePlayer LevelSequencePlay;

		// Token: 0x0401AEA7 RID: 110247
		private RoleDevelopItemRoleBadge ItemRoleBadge;

		// Token: 0x0401AEA8 RID: 110248
		private const int FocusSearchMaxDepth = 16;
	}
}
