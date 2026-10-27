using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AEE RID: 19182
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseResultView : UiViewBase
	{
		// Token: 0x06031AF6 RID: 203510 RVA: 0x00B88DF1 File Offset: 0x00B86FF1
		public TrapDefenseResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031AF7 RID: 203511 RVA: 0x00B88DFC File Offset: 0x00B86FFC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 23;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnClickLeave));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnClickShared));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031AF8 RID: 203512 RVA: 0x00B8918C File Offset: 0x00B8738C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnStartStar));
			EventSystem.Instance.Add(EEventName.TrapDefenseOnSystemInfoNotify, new Action(this.OnSystemNotify));
			EventSystem.Instance.Add(EEventName.TrapDefenseBdBuffAllUpdate, new Action(this.OnSystemNotify));
		}

		// Token: 0x06031AF9 RID: 203513 RVA: 0x00B891F0 File Offset: 0x00B873F0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnStartStar));
			EventSystem.Instance.Remove(EEventName.TrapDefenseOnSystemInfoNotify, new Action(this.OnSystemNotify));
			EventSystem.Instance.Remove(EEventName.TrapDefenseBdBuffAllUpdate, new Action(this.OnSystemNotify));
		}

		// Token: 0x06031AFA RID: 203514 RVA: 0x00B89254 File Offset: 0x00B87454
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseResultView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseResultView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031AFB RID: 203515 RVA: 0x00B89298 File Offset: 0x00B87498
		protected override void OnStart()
		{
			this.BattleResultInfo = new GenericLayout<TrapDefenseResultInfoItem, ITrapDefensePauseInfo>(base.GetHorizontalLayout(7), new Func<TrapDefenseResultInfoItem>(this.CreateItem), base.GetItem(8).GetOwner() as AUIBaseActor, false, true);
			this.ExpLayout = new GenericLayout<TrapDefenseResultResultItem, ITrapDefenseResultInfo>(base.GetVerticalLayout(9), new Func<TrapDefenseResultResultItem>(this.CreateExpItem), null, false, true);
			this.UnlockLayout = new GenericLayout<TrapDefenseResultUnlockTab, ITrapDefenseResultUnlockTab>(base.GetVerticalLayout(11), new Func<TrapDefenseResultUnlockTab>(this.CreateAwardTab), null, false, true);
		}

		// Token: 0x06031AFC RID: 203516 RVA: 0x00B8931C File Offset: 0x00B8751C
		protected override void OnBeforeShow()
		{
			this.BindRedDot();
			TrapDefenseLevelData curInstToLevelData = TrapDefenseModel.Instance.GetCurInstToLevelData();
			string textStringId;
			switch (curInstToLevelData.Config.ModeType)
			{
			case 1:
				textStringId = "TowerDefense_Ending_MainTypeTitle_Text";
				break;
			case 2:
				textStringId = "TowerDefense_Ending_RougeTypeTitle_Text";
				break;
			case 3:
				textStringId = "TowerDefense_Ending_RougeTypeTitle_Text";
				break;
			default:
				textStringId = "TowerDefense_Ending_RougeTypeTitle_Text";
				break;
			}
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(curInstToLevelData.Config.Name, curInstToLevelData.Config.Name);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textStringId, new <>z__ReadOnlySingleElementList<object>(multiTextByKey));
			this.OnSuccessResult(this.ResultData.Success || curInstToLevelData.Config.ModeType == 3);
			this.RefreshExpLayout();
			this.InitUnlockLayout();
			this.BtnContinue.SetUiActive(true);
			TrapDefenseLevelData nextLevelData = TrapDefenseModel.Instance.GetNextLevelData(curInstToLevelData);
			if (nextLevelData != null && nextLevelData.IsUnlock && this.ResultData.Success)
			{
				this.BtnContinue.ShowText("TrapDefense_Result_Continue");
			}
			else
			{
				this.BtnContinue.ShowText("TrapDefense_Result_Retry");
			}
			List<ITrapDefensePauseInfo> list = new List<ITrapDefensePauseInfo>();
			list.Add(new TrapDefensePauseInfo
			{
				Type = ETrapDefensePauseInfoType.Health,
				Value = new int?(this.ResultData.Health)
			});
			list.Add(new TrapDefensePauseInfo
			{
				Type = ETrapDefensePauseInfoType.BatchPassed,
				Value = new int?(this.ResultData.Wave),
				MaxBatch = new int?(this.ResultData.MaxWave)
			});
			this.BattleResultInfo.RefreshByData(list, null, true);
		}

		// Token: 0x06031AFD RID: 203517 RVA: 0x00B894B8 File Offset: 0x00B876B8
		protected override void OnBeforeHide()
		{
			foreach (TrapDefenseResultResultItem trapDefenseResultResultItem in this.ExpLayout.GetLayoutItemList())
			{
				trapDefenseResultResultItem.EndStarAnim();
			}
			this.UnbindRedDot();
		}

		// Token: 0x06031AFE RID: 203518 RVA: 0x00B89514 File Offset: 0x00B87714
		protected override void OnBeforeDestroy()
		{
			this.BtnSkill = null;
			this.BtnOrgan = null;
			this.BtnGain = null;
			this.BattleResultInfo = null;
			this.ExpLayout = null;
			this.UnlockLayout = null;
			this.ShareItem = null;
			this.ResultData = null;
		}

		// Token: 0x06031AFF RID: 203519 RVA: 0x00B89550 File Offset: 0x00B87750
		protected void BindRedDot()
		{
			this.BtnSkill.BindRedDot(ERedDotName.TrapDefenseTalentTree, null);
		}

		// Token: 0x06031B00 RID: 203520 RVA: 0x00B89576 File Offset: 0x00B87776
		protected void UnbindRedDot()
		{
			this.BtnSkill.UnBindRedDot();
		}

		// Token: 0x06031B01 RID: 203521 RVA: 0x00B89584 File Offset: 0x00B87784
		protected void OnSuccessResult(bool isSuccess)
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(isSuccess);
			}
			if (isSuccess)
			{
				string textStringId = (TrapDefenseModel.Instance.GetCurInstToLevelData().Config.ModeType == 3) ? "TrapDefenseChallengeSuccess_Endless" : "TrapDefenseChallengeSuccess_Normal";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(22), textStringId, Array.Empty<object>());
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(!isSuccess);
			}
			string resourceId = isSuccess ? "TrapDefenseResultSuccess1" : "TrapDefenseResultFail1";
			string resourceId2 = isSuccess ? "TrapDefenseResultSuccess2" : "TrapDefenseResultFail2";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(resourceId2);
			base.SetTextureByPath(resourcePath, base.GetTexture(19), null, null);
			base.SetTextureByPath(resourcePath2, base.GetTexture(20), null, null);
			bool flag = ChannelController.Instance.CouldShare();
			UUIButtonComponent button = base.GetButton(16);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(isSuccess && flag);
			}
			bool flag2 = ChannelModel.Instance.CouldGetShareReward(EShareActionId.TrapDefense);
			UUIItem item3 = base.GetItem(18);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(flag2 && isSuccess);
		}

		// Token: 0x06031B02 RID: 203522 RVA: 0x00B896BC File Offset: 0x00B878BC
		private UniTask OpenShareView()
		{
			TrapDefenseResultView.<OpenShareView>d__24 <OpenShareView>d__;
			<OpenShareView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenShareView>d__.<>4__this = this;
			<OpenShareView>d__.<>1__state = -1;
			<OpenShareView>d__.<>t__builder.Start<TrapDefenseResultView.<OpenShareView>d__24>(ref <OpenShareView>d__);
			return <OpenShareView>d__.<>t__builder.Task;
		}

		// Token: 0x06031B03 RID: 203523 RVA: 0x00B89700 File Offset: 0x00B87900
		private UniTask WaitFrame()
		{
			TrapDefenseResultView.<WaitFrame>d__25 <WaitFrame>d__;
			<WaitFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitFrame>d__.<>1__state = -1;
			<WaitFrame>d__.<>t__builder.Start<TrapDefenseResultView.<WaitFrame>d__25>(ref <WaitFrame>d__);
			return <WaitFrame>d__.<>t__builder.Task;
		}

		// Token: 0x06031B04 RID: 203524 RVA: 0x00B8973C File Offset: 0x00B8793C
		private void SetShareState(bool state)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(state);
			}
			UUIItem item2 = base.GetItem(13);
			if (item2 != null)
			{
				item2.SetUIActive(state);
			}
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(9);
			if (verticalLayout != null)
			{
				verticalLayout.RootUIComp.Get().SetUIActive(state);
			}
			UUIItem item3 = base.GetItem(18);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			this.RefreshUnlockLayout(state);
		}

		// Token: 0x06031B05 RID: 203525 RVA: 0x00B897AC File Offset: 0x00B879AC
		private void RefreshExpLayout()
		{
			List<ITrapDefenseResultInfo> list = new List<ITrapDefenseResultInfo>();
			int starRatingConditionsLength = TrapDefenseModel.Instance.GetCurInstToLevelData().Config.StarRatingConditionsLength;
			int value = this.NeedShowViewAnim ? this.ResultData.FinalTarget.Count : this.ResultData.PreTarget.Count;
			TrapDefenseResultInfo item = new TrapDefenseResultInfo
			{
				Type = ETrapDefenseResultType.Star,
				Value = starRatingConditionsLength,
				History = new int?(value),
				Total = new int?(this.ResultData.FinalTarget.Count)
			};
			list.Add(item);
			if (this.ResultData.RewardLevelUpPoint > 0)
			{
				TrapDefenseResultInfo item2 = new TrapDefenseResultInfo
				{
					Type = ETrapDefenseResultType.Coin,
					Value = this.ResultData.RewardLevelUpPoint
				};
				list.Add(item2);
			}
			GenericLayout<TrapDefenseResultResultItem, ITrapDefenseResultInfo> expLayout = this.ExpLayout;
			if (expLayout == null)
			{
				return;
			}
			expLayout.RefreshByData(list, null, true);
		}

		// Token: 0x06031B06 RID: 203526 RVA: 0x00B8988C File Offset: 0x00B87A8C
		private void InitUnlockLayout()
		{
			List<ITrapDefenseResultUnlockTab> unlockList = this.GetUnlockList();
			List<ITrapDefenseResultUnlockTab> sharedList = this.GetSharedList();
			List<ITrapDefenseResultUnlockTab> list = new List<ITrapDefenseResultUnlockTab>();
			list.AddRange(unlockList);
			list.AddRange(sharedList);
			GenericLayout<TrapDefenseResultUnlockTab, ITrapDefenseResultUnlockTab> unlockLayout = this.UnlockLayout;
			if (unlockLayout == null)
			{
				return;
			}
			unlockLayout.RefreshByData(list, delegate
			{
				this.RefreshUnlockLayout(true);
			}, true);
		}

		// Token: 0x06031B07 RID: 203527 RVA: 0x00B898DC File Offset: 0x00B87ADC
		private List<ITrapDefenseResultUnlockTab> GetUnlockList()
		{
			List<ITrapDefenseResultUnlockTab> list = new List<ITrapDefenseResultUnlockTab>();
			List<ITrapDefenseResultUnlockInfo> list2 = new List<ITrapDefenseResultUnlockInfo>();
			List<ITrapDefenseResultUnlockInfo> list3 = new List<ITrapDefenseResultUnlockInfo>();
			bool? isNewUnlock = this.NeedShowViewAnim ? null : new bool?(true);
			foreach (int dataType in this.ResultData.UnlockAuxiliary)
			{
				ITrapDefenseMachineIdInfo info = new ITrapDefenseMachineIdInfo
				{
					MachineType = ETrapDefenseMachineType.Auxiliary,
					DataType = dataType,
					Level = 1,
					Branch = 0
				};
				TrapDefenseResultUnlockInfo item = new TrapDefenseResultUnlockInfo
				{
					Type = ETrapDefenseResultUnlockType.Organ,
					Id = TrapDefenseModel.Instance.ComposeMachineId(info),
					IsNewUnlock = isNewUnlock
				};
				list2.Add(item);
			}
			foreach (int dataType2 in this.ResultData.UnlockBuilding)
			{
				ITrapDefenseMachineIdInfo info2 = new ITrapDefenseMachineIdInfo
				{
					MachineType = ETrapDefenseMachineType.Building,
					DataType = dataType2,
					Level = 1,
					Branch = 0
				};
				TrapDefenseResultUnlockInfo item2 = new TrapDefenseResultUnlockInfo
				{
					Type = ETrapDefenseResultUnlockType.Organ,
					Id = TrapDefenseModel.Instance.ComposeMachineId(info2),
					IsNewUnlock = isNewUnlock
				};
				list2.Add(item2);
			}
			if (list2.Count > 0)
			{
				ITrapDefenseResultUnlockTab item3 = new ITrapDefenseResultUnlockTab
				{
					Type = ETrapDefenseResultUnlockType.Organ,
					DataList = list2
				};
				list.Add(item3);
			}
			foreach (int id in this.ResultData.UnlockBds)
			{
				TrapDefenseResultUnlockInfo item4 = new TrapDefenseResultUnlockInfo
				{
					Type = ETrapDefenseResultUnlockType.Bd,
					Id = id,
					IsNewUnlock = isNewUnlock
				};
				list3.Add(item4);
			}
			if (list3.Count > 0)
			{
				ITrapDefenseResultUnlockTab item5 = new ITrapDefenseResultUnlockTab
				{
					Type = ETrapDefenseResultUnlockType.Bd,
					DataList = list3
				};
				list.Add(item5);
			}
			return list;
		}

		// Token: 0x06031B08 RID: 203528 RVA: 0x00B89AF4 File Offset: 0x00B87CF4
		private List<ITrapDefenseResultUnlockTab> GetSharedList()
		{
			List<ITrapDefenseResultUnlockTab> list = new List<ITrapDefenseResultUnlockTab>();
			List<ITrapDefenseResultUnlockInfo> list2 = new List<ITrapDefenseResultUnlockInfo>();
			List<ITrapDefenseResultUnlockInfo> list3 = new List<ITrapDefenseResultUnlockInfo>();
			foreach (TrapDefenseBuildingSlotData trapDefenseBuildingSlotData in TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetSlotData())
			{
				TrapDefenseBuildingDevelopItemData slotData = trapDefenseBuildingSlotData.GetSlotData();
				if (slotData != null)
				{
					ITrapDefenseMachineIdInfo info = new ITrapDefenseMachineIdInfo
					{
						MachineType = (slotData.IsBuilding ? ETrapDefenseMachineType.Building : ETrapDefenseMachineType.Auxiliary),
						DataType = slotData.GetDataType(),
						Level = slotData.GetLevel(),
						Branch = slotData.GetBranch()
					};
					TrapDefenseResultUnlockInfo item = new TrapDefenseResultUnlockInfo
					{
						Type = ETrapDefenseResultUnlockType.OrganShare,
						Id = TrapDefenseModel.Instance.ComposeMachineId(info)
					};
					list2.Add(item);
				}
			}
			if (list2.Count > 0)
			{
				ITrapDefenseResultUnlockTab item2 = new ITrapDefenseResultUnlockTab
				{
					Type = ETrapDefenseResultUnlockType.OrganShare,
					DataList = list2
				};
				list.Add(item2);
			}
			foreach (KeyValuePair<int, TrapDefenseBdData> keyValuePair in TrapDefenseModel.Instance.RougeModeData.BdDataMap)
			{
				int num;
				TrapDefenseBdData trapDefenseBdData;
				keyValuePair.Deconstruct(out num, out trapDefenseBdData);
				int id = num;
				TrapDefenseBdData trapDefenseBdData2 = trapDefenseBdData;
				if (trapDefenseBdData2.GetCurrentActiveProgressNum() != 0 && !trapDefenseBdData2.IsZeroBdType())
				{
					TrapDefenseResultUnlockInfo item3 = new TrapDefenseResultUnlockInfo
					{
						Type = ETrapDefenseResultUnlockType.BdShare,
						Id = id,
						NeedUnlockBar = new bool?(false),
						ForShare = new bool?(true)
					};
					list3.Add(item3);
					if (list3.Count >= 4)
					{
						break;
					}
				}
			}
			if (list3.Count > 0)
			{
				ITrapDefenseResultUnlockTab item4 = new ITrapDefenseResultUnlockTab
				{
					Type = ETrapDefenseResultUnlockType.BdShare,
					DataList = list3
				};
				list.Add(item4);
			}
			return list;
		}

		// Token: 0x06031B09 RID: 203529 RVA: 0x00B89CCC File Offset: 0x00B87ECC
		private void RefreshUnlockLayout(bool isUnlock)
		{
			foreach (TrapDefenseResultUnlockTab trapDefenseResultUnlockTab in this.UnlockLayout.GetLayoutItemList())
			{
				trapDefenseResultUnlockTab.SetUiActive(trapDefenseResultUnlockTab.IsShared != isUnlock);
			}
		}

		// Token: 0x06031B0A RID: 203530 RVA: 0x00B89D30 File Offset: 0x00B87F30
		private void OnClickSkill()
		{
			TrapDefenseModel.Instance.OpenViewTalentTree(null);
		}

		// Token: 0x06031B0B RID: 203531 RVA: 0x00B89D3D File Offset: 0x00B87F3D
		private void OnClickOrgan()
		{
			TrapDefenseController.Instance.OpenOrganDevelop(false, this, 0, null);
		}

		// Token: 0x06031B0C RID: 203532 RVA: 0x00B89D50 File Offset: 0x00B87F50
		private void OnClickGain()
		{
			TrapDefenseModel.Instance.OpenViewBdSum(null, null, null);
		}

		// Token: 0x06031B0D RID: 203533 RVA: 0x00B89D84 File Offset: 0x00B87F84
		private void OnClickContinue()
		{
			TrapDefenseResultView.<>c__DisplayClass35_0 CS$<>8__locals1 = new TrapDefenseResultView.<>c__DisplayClass35_0();
			AudioSystem.Instance.ExecuteAction("play_2_6_tower_defence_music_ingame", EAudioActionType.Stop, null);
			CS$<>8__locals1.levelData = TrapDefenseModel.Instance.GetCurInstToLevelData();
			if (CS$<>8__locals1.levelData == null)
			{
				return;
			}
			TrapDefenseLevelData nextLevelData = TrapDefenseModel.Instance.GetNextLevelData(CS$<>8__locals1.levelData);
			if (!this.ResultData.Success || nextLevelData == null || !nextLevelData.IsUnlock)
			{
				if (!TrapDefenseModel.Instance.CheckNextLevelThreshold(CS$<>8__locals1.levelData, new Action(CS$<>8__locals1.<OnClickContinue>g__cb|0), this))
				{
					TrapDefenseController.Instance.RequestChallenge(CS$<>8__locals1.levelData, false).Forget<bool>();
				}
				return;
			}
			if (nextLevelData.Config.ModeType == 1)
			{
				TrapDefenseModel.Instance.OpenViewMainLevelMode(new int?(nextLevelData.Id), new ETrapDefenseDifficultyLevel?((ETrapDefenseDifficultyLevel)nextLevelData.Config.Difficulty), new bool?(false));
				return;
			}
			TrapDefenseModel.Instance.OpenViewRougeLevelMode(new int?(nextLevelData.Id), new bool?(false));
		}

		// Token: 0x06031B0E RID: 203534 RVA: 0x00B89E80 File Offset: 0x00B88080
		private void OnClickLeave()
		{
			AudioSystem.Instance.ExecuteAction("play_2_6_tower_defence_music_ingame", EAudioActionType.Stop, null);
			TrapDefenseModel.Instance.NeedOpenMainView = true;
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default).Forget<bool>();
		}

		// Token: 0x06031B0F RID: 203535 RVA: 0x00B89EC1 File Offset: 0x00B880C1
		private void OnClickShared()
		{
			this.OpenShareView().Forget();
		}

		// Token: 0x06031B10 RID: 203536 RVA: 0x00B89ECE File Offset: 0x00B880CE
		private TrapDefenseResultInfoItem CreateItem()
		{
			return new TrapDefenseResultInfoItem();
		}

		// Token: 0x06031B11 RID: 203537 RVA: 0x00B89ED5 File Offset: 0x00B880D5
		private TrapDefenseResultResultItem CreateExpItem()
		{
			return new TrapDefenseResultResultItem();
		}

		// Token: 0x06031B12 RID: 203538 RVA: 0x00B89EDC File Offset: 0x00B880DC
		private TrapDefenseResultUnlockTab CreateAwardTab()
		{
			return new TrapDefenseResultUnlockTab();
		}

		// Token: 0x06031B13 RID: 203539 RVA: 0x00B89EE4 File Offset: 0x00B880E4
		private void OnStartStar(string name)
		{
			if (name != "Start")
			{
				return;
			}
			foreach (TrapDefenseResultResultItem trapDefenseResultResultItem in this.ExpLayout.GetLayoutItemList())
			{
				trapDefenseResultResultItem.PlayStarIn();
			}
			TimerSystem.Instance.Delay(delegate(float _)
			{
				foreach (TrapDefenseResultUnlockTab trapDefenseResultUnlockTab in this.UnlockLayout.GetLayoutItemList())
				{
					trapDefenseResultUnlockTab.PlayUnlockAnim();
				}
			}, 500f, null, null, true, 1f);
		}

		// Token: 0x06031B14 RID: 203540 RVA: 0x00B89F6C File Offset: 0x00B8816C
		private void OnSystemNotify()
		{
			this.InitUnlockLayout();
		}

		// Token: 0x06031B15 RID: 203541 RVA: 0x00B89F74 File Offset: 0x00B88174
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "HighestRecord"))
			{
				return null;
			}
			GenericLayout<TrapDefenseResultResultItem, ITrapDefenseResultInfo> expLayout = this.ExpLayout;
			UUIItem uuiitem = (expLayout != null) ? expLayout.GetItemByIndex(0) : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0401A88A RID: 108682
		protected TrapDefenseResultButton BtnSkill;

		// Token: 0x0401A88B RID: 108683
		protected TrapDefenseResultButton BtnOrgan;

		// Token: 0x0401A88C RID: 108684
		protected TrapDefenseResultButton BtnGain;

		// Token: 0x0401A88D RID: 108685
		protected TrapDefenseResultContinueButton BtnContinue;

		// Token: 0x0401A88E RID: 108686
		protected GenericLayout<TrapDefenseResultInfoItem, ITrapDefensePauseInfo> BattleResultInfo;

		// Token: 0x0401A88F RID: 108687
		protected TrapDefenseShareTips ShareItem;

		// Token: 0x0401A890 RID: 108688
		protected GenericLayout<TrapDefenseResultResultItem, ITrapDefenseResultInfo> ExpLayout;

		// Token: 0x0401A891 RID: 108689
		protected GenericLayout<TrapDefenseResultUnlockTab, ITrapDefenseResultUnlockTab> UnlockLayout;

		// Token: 0x0401A892 RID: 108690
		protected string PassTime;

		// Token: 0x0401A893 RID: 108691
		protected TrapDefenseResultInfo ResultData;

		// Token: 0x0401A894 RID: 108692
		protected bool NeedShowViewAnim;

		// Token: 0x0200AC81 RID: 44161
		[NullableContext(0)]
		private class EMainDefine
		{
			// Token: 0x040346C6 RID: 214726
			public const int GainItemLayout = 0;

			// Token: 0x040346C7 RID: 214727
			public const int BtnSkill = 1;

			// Token: 0x040346C8 RID: 214728
			public const int BtnOrgan = 2;

			// Token: 0x040346C9 RID: 214729
			public const int BtnGain = 3;

			// Token: 0x040346CA RID: 214730
			public const int PanelSuccess = 4;

			// Token: 0x040346CB RID: 214731
			public const int PanelFail = 5;

			// Token: 0x040346CC RID: 214732
			public const int TxtSubTitle = 6;

			// Token: 0x040346CD RID: 214733
			public const int BaseInfoLayout = 7;

			// Token: 0x040346CE RID: 214734
			public const int BaseInfoItem = 8;

			// Token: 0x040346CF RID: 214735
			public const int PanelExpResult = 9;

			// Token: 0x040346D0 RID: 214736
			public const int ExpResultItem = 10;

			// Token: 0x040346D1 RID: 214737
			public const int PanelBuffItemLayout = 11;

			// Token: 0x040346D2 RID: 214738
			public const int BuffItemGroup = 12;

			// Token: 0x040346D3 RID: 214739
			public const int PanelBottomBtn = 13;

			// Token: 0x040346D4 RID: 214740
			public const int BtnConfirmContinue = 14;

			// Token: 0x040346D5 RID: 214741
			public const int BtnConfirmLeave = 15;

			// Token: 0x040346D6 RID: 214742
			public const int BtnShare = 16;

			// Token: 0x040346D7 RID: 214743
			public const int ShareItemContent = 17;

			// Token: 0x040346D8 RID: 214744
			public const int PanelShareTips = 18;

			// Token: 0x040346D9 RID: 214745
			public const int BgTexture1 = 19;

			// Token: 0x040346DA RID: 214746
			public const int BgTexture2 = 20;

			// Token: 0x040346DB RID: 214747
			public const int BgLevel = 21;

			// Token: 0x040346DC RID: 214748
			public const int TxtSuccess = 22;
		}
	}
}
