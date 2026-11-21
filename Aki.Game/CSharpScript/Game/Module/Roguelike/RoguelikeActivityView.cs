using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DD0 RID: 15824
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeActivityView : UiTickViewBase
	{
		// Token: 0x06028700 RID: 165632 RVA: 0x00B548EA File Offset: 0x00B52AEA
		[NullableContext(1)]
		public RoguelikeActivityView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028701 RID: 165633 RVA: 0x00B54900 File Offset: 0x00B52B00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnSkillTreeClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBtnDoorClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnBtnShop));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06028702 RID: 165634 RVA: 0x00B54BC4 File Offset: 0x00B52DC4
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeActivityView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeActivityView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028703 RID: 165635 RVA: 0x00B54C08 File Offset: 0x00B52E08
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(delegate
			{
				UiManager.Instance.CloseView(this.ViewInfo.Name, null);
			});
			Activity? localConfig = this.ActivityRogueData.LocalConfig;
			if (localConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), localConfig.Value.DescTheme, Array.Empty<object>());
			this.RefreshUi();
			if (this.NewUnlockPhantomList.Count > 0)
			{
				UiManager.Instance.OpenView(EUiViewName.RoguelikePhantomNewUnlockView, this.NewUnlockPhantomList, null);
			}
			EventSystem.Instance.Add<int>(EEventName.RoguelikeArchiveSaved, new Action<int>(this.ClearTempAchieveInfo));
		}

		// Token: 0x06028704 RID: 165636 RVA: 0x00B54CC0 File Offset: 0x00B52EC0
		protected override void OnBeforeShow()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RogueSkillUnlock, base.GetItem(8), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.RoguelikeAchievement, base.GetItem(9), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.RoguelikeShop, base.GetItem(10), delegate(bool newState, int _)
			{
				UUIItem item = base.GetItem(10);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(newState);
			}, 0);
		}

		// Token: 0x06028705 RID: 165637 RVA: 0x00B54D19 File Offset: 0x00B52F19
		protected override void OnBeforeHide()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.RogueSkillUnlock);
			RedDotController.Instance.UnBindRedDot(ERedDotName.RoguelikeAchievement);
			RedDotController.Instance.UnBindRedDot(ERedDotName.RoguelikeShop);
		}

		// Token: 0x06028706 RID: 165638 RVA: 0x00B54D3F File Offset: 0x00B52F3F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeCurrencyUpdate, new Action(this.RefreshUi));
		}

		// Token: 0x06028707 RID: 165639 RVA: 0x00B54D5D File Offset: 0x00B52F5D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeCurrencyUpdate, new Action(this.RefreshUi));
		}

		// Token: 0x06028708 RID: 165640 RVA: 0x00B54D7B File Offset: 0x00B52F7B
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.RoguelikeArchiveSaved, new Action<int>(this.ClearTempAchieveInfo));
		}

		// Token: 0x06028709 RID: 165641 RVA: 0x00B54D99 File Offset: 0x00B52F99
		protected override void OnTick(float delta)
		{
			this.RefreshRemainTime();
		}

		// Token: 0x0602870A RID: 165642 RVA: 0x00B54DA4 File Offset: 0x00B52FA4
		protected unsafe void OnBtnShop()
		{
			if (this.ActivityRogueData.GetRogueActivityState() == ERogueActivityState.Close)
			{
				ScrollingTipsController.Instance.ShowTipsById("Rogue_Function_End_Tip", Array.Empty<object>());
				return;
			}
			RogueSeasonData seasonData = this.ActivityRogueData.SeasonData;
			if (seasonData == null)
			{
				return;
			}
			RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(seasonData.SeasonId);
			if (rogueSeasonConfigById.Value.ShopId == 0)
			{
				return;
			}
			PayShopViewData payShopViewData = new PayShopViewData();
			PayShopViewData payShopViewData2 = payShopViewData;
			int num = 1;
			List<int> list = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list, num);
			Span<int> span = CollectionsMarshal.AsSpan<int>(list);
			int index = 0;
			*span[index] = rogueSeasonConfigById.Value.ShopId;
			payShopViewData2.ShowShopIdList = list;
			payShopViewData.PayShopId = (PayShopDefine.EPayShopTabType)rogueSeasonConfigById.Value.ShopId;
			RoguelikeModel.Instance.RecordRoguelikeShopRedDot();
			PayShopController.Instance.OpenPayShopView(payShopViewData, null);
		}

		// Token: 0x0602870B RID: 165643 RVA: 0x00B54E74 File Offset: 0x00B53074
		protected void OnBtnSkillTreeClick()
		{
			if (this.ActivityRogueData.GetRogueActivityState() == ERogueActivityState.Close)
			{
				ScrollingTipsController.Instance.ShowTipsById("Rogue_Function_End_Tip", Array.Empty<object>());
				return;
			}
			ActivityRogueData activityRogueData = this.ActivityRogueData;
			RogueSeasonData rogueSeasonData = (activityRogueData != null) ? activityRogueData.SeasonData : null;
			if (rogueSeasonData == null)
			{
				return;
			}
			RoguelikeController.Instance.OpenRoguelikeSkillView(rogueSeasonData.SeasonId);
		}

		// Token: 0x0602870C RID: 165644 RVA: 0x00B54ECC File Offset: 0x00B530CC
		protected void OnBtnDoorClick()
		{
			if (this.ActivityRogueData.GetRogueActivityState() == ERogueActivityState.Close)
			{
				ScrollingTipsController.Instance.ShowTipsById("Rogue_Function_End_Tip", Array.Empty<object>());
				return;
			}
			ActivityRogueData activityRogueData = this.ActivityRogueData;
			RogueSeasonData rogueSeasonData = (activityRogueData != null) ? activityRogueData.SeasonData : null;
			if (rogueSeasonData == null)
			{
				return;
			}
			if (RoguelikeConfig.Instance.GetRogueSeasonConfigById(rogueSeasonData.SeasonId).Value.Achievement == 0)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.RoguelikeAchievementView, null, null);
		}

		// Token: 0x0602870D RID: 165645 RVA: 0x00B54F48 File Offset: 0x00B53148
		private void RefreshLastInfo()
		{
			RoguelikeLastInfo lastInfo = this.LastInfo;
			bool processingState = lastInfo != null && lastInfo.ModeType == RogueChallengeModeType.NormalInst;
			RoguelikeLastInfo lastInfo2 = this.LastInfo;
			bool processingState2 = lastInfo2 != null && lastInfo2.ModeType == RogueChallengeModeType.TowerTrial;
			RoguelikeChallengeButtonItem bossChallengeButton = this.BossChallengeButton;
			if (bossChallengeButton != null)
			{
				bossChallengeButton.SetProcessingState(processingState2);
			}
			RoguelikeActivityNormalInstButton normalInstButton = this.NormalInstButton;
			if (normalInstButton == null)
			{
				return;
			}
			normalInstButton.SetProcessingState(processingState);
		}

		// Token: 0x0602870E RID: 165646 RVA: 0x00B54FA4 File Offset: 0x00B531A4
		private void RefreshBossChallengeButton()
		{
			RoguelikeChallengeButtonItem bossChallengeButton = this.BossChallengeButton;
			if (bossChallengeButton == null)
			{
				return;
			}
			bossChallengeButton.SetTxtScore(this.ActivityRogueData.SeasonData.TowerTrialBestClearCount);
		}

		// Token: 0x0602870F RID: 165647 RVA: 0x00B54FC8 File Offset: 0x00B531C8
		private bool CheckTempAchieveExist()
		{
			if (this.TempAchieveInfo == null)
			{
				return false;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoguelikeTempArchiveProcessConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			Action<bool> clearTempAchieveInfo = delegate(bool isSuccess)
			{
				if (!isSuccess)
				{
					return;
				}
				this.ClearTempAchieveInfo(0);
			};
			Action value = delegate()
			{
				RoguelikeController.Instance.RoguelikeAchieveGiveUpRequest(clearTempAchieveInfo);
			};
			Action value2 = delegate()
			{
				RogueArchiveInfoData rogueArchiveInfoData = new RogueArchiveInfoData();
				rogueArchiveInfoData.Update(this.TempAchieveInfo);
				RoguelikeAchieveViewInfo viewInfo = new RoguelikeAchieveViewInfo
				{
					Mode = ERoguelikeAchieveViewMode.Archive,
					TempRecordInfo = rogueArchiveInfoData
				};
				RoguelikeController.Instance.OpenRoguelikeAchieveView(viewInfo).Forget();
			};
			confirmBoxDataNew.FunctionMap[1] = value;
			confirmBoxDataNew.FunctionMap[2] = value2;
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return true;
		}

		// Token: 0x06028710 RID: 165648 RVA: 0x00B55058 File Offset: 0x00B53258
		private bool CheckLastInfoExist()
		{
			if (this.LastInfo == null || this.LastInfo.InstId == 0)
			{
				return false;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((this.LastInfo.ModeType == RogueChallengeModeType.TowerTrial) ? EConfirmBoxConfigId.RoguelikeBossChallengeLeaveArchiveConfirm : EConfirmBoxConfigId.RoguelikeNormalLeaveArchiveConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			if (this.LastInfo.ModeType == RogueChallengeModeType.NormalInst)
			{
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					this.LastInfo.CurLayer.ToString(),
					this.LastInfo.MaxLayer.ToString()
				});
			}
			Action<bool> clearLastInfo = delegate(bool isSuccess)
			{
				if (!isSuccess)
				{
					return;
				}
				this.ClearLastInfo();
				this.RefreshBossChallengeButton();
			};
			Action value = delegate()
			{
				RoguelikeLastInfo lastInfo = this.LastInfo;
				if (lastInfo != null && lastInfo.ModeType == RogueChallengeModeType.NormalInst)
				{
					RoguelikeController.Instance.RoguelikeResultRequest(this.LastInfo.InstId, clearLastInfo);
				}
				RoguelikeLastInfo lastInfo2 = this.LastInfo;
				if (lastInfo2 != null && lastInfo2.ModeType == RogueChallengeModeType.TowerTrial)
				{
					RoguelikeController.Instance.RoguelikeBossChallengeResultRequest(this.LastInfo.InstId, clearLastInfo);
				}
			};
			Action value2 = delegate()
			{
				if (RoleController.Instance.IsInRoleTrial())
				{
					GenericPromptController.Instance.ShowPromptByCode("TrialRoleDungeonsLimit", Array.Empty<object>());
					return;
				}
				RoguelikeLastInfo lastInfo = this.LastInfo;
				if (lastInfo != null && lastInfo.ModeType == RogueChallengeModeType.NormalInst)
				{
					RoguelikeController.Instance.RoguelikeStartRequest(true, this.LastInfo.InstId, new List<int>(), 0).Forget<bool>();
				}
				RoguelikeLastInfo lastInfo2 = this.LastInfo;
				if (lastInfo2 != null && lastInfo2.ModeType == RogueChallengeModeType.TowerTrial)
				{
					RoguelikeController.Instance.RoguelikeBossChallengeStartRequest(this.LastInfo.InstId, 0, null);
				}
			};
			confirmBoxDataNew.FunctionMap[1] = value;
			confirmBoxDataNew.FunctionMap[2] = value2;
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return true;
		}

		// Token: 0x06028711 RID: 165649 RVA: 0x00B55154 File Offset: 0x00B53354
		protected void OnBtnConfirmClick()
		{
			if (RoleController.Instance.IsInRoleTrial())
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleDungeonsLimit", Array.Empty<object>());
				return;
			}
			if (this.ActivityRogueData.GetRogueActivityState() == ERogueActivityState.Close)
			{
				ScrollingTipsController.Instance.ShowTipsById("Rogue_Function_End_Tip", Array.Empty<object>());
				return;
			}
			if (this.CheckTempAchieveExist())
			{
				return;
			}
			if (this.CheckLastInfoExist())
			{
				return;
			}
			RoguelikeController.Instance.EnterCurrentRogueEntrance();
		}

		// Token: 0x06028712 RID: 165650 RVA: 0x00B551C4 File Offset: 0x00B533C4
		protected void OnBtnBossChallengeClick()
		{
			if (RoleController.Instance.IsInRoleTrial())
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleDungeonsLimit", Array.Empty<object>());
				return;
			}
			if (this.ActivityRogueData.GetRogueActivityState() == ERogueActivityState.Close)
			{
				ScrollingTipsController.Instance.ShowTipsById("Rogue_Function_End_Tip", Array.Empty<object>());
				return;
			}
			if (this.CheckTempAchieveExist())
			{
				return;
			}
			if (this.CheckLastInfoExist())
			{
				return;
			}
			RoguelikeAchieveViewInfo viewInfo = new RoguelikeAchieveViewInfo
			{
				Mode = ERoguelikeAchieveViewMode.UseArchive
			};
			RoguelikeController.Instance.OpenRoguelikeAchieveView(viewInfo).Forget();
		}

		// Token: 0x06028713 RID: 165651 RVA: 0x00B55244 File Offset: 0x00B53444
		private void ClearTempAchieveInfo(int slotId)
		{
			this.TempAchieveInfo = null;
		}

		// Token: 0x06028714 RID: 165652 RVA: 0x00B5524D File Offset: 0x00B5344D
		private void ClearLastInfo()
		{
			this.LastInfo = null;
			this.RefreshLastInfo();
		}

		// Token: 0x06028715 RID: 165653 RVA: 0x00B5525C File Offset: 0x00B5345C
		protected void RefreshUi()
		{
			ActivityRogueData activityRogueData = this.ActivityRogueData;
			RogueSeasonData rogueSeasonData = (activityRogueData != null) ? activityRogueData.SeasonData : null;
			if (rogueSeasonData != null)
			{
				RogueParam? rogueParam;
				int num = (RoguelikeModel.Instance.GetParamConfigBySeasonId(null) != null) ? rogueParam.GetValueOrDefault().WeekTokenMaxCount : 1;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "Roguelike_ActivityMain_ScoreProgress", new <>z__ReadOnlyArray<object>(new object[]
				{
					rogueSeasonData.TokenItemCount,
					num
				}));
			}
			this.RefreshRemainTime();
		}

		// Token: 0x06028716 RID: 165654 RVA: 0x00B552F0 File Offset: 0x00B534F0
		protected void RefreshRemainTime()
		{
			UUIItem item = base.GetItem(13);
			UUIText text = base.GetText(12);
			ERogueActivityState rogueActivityState = this.ActivityRogueData.GetRogueActivityState();
			if (rogueActivityState == ERogueActivityState.Open)
			{
				RoguelikeActivityNormalInstButton normalInstButton = this.NormalInstButton;
				if (normalInstButton != null)
				{
					normalInstButton.SetActive(true);
				}
				RoguelikeChallengeButtonItem bossChallengeButton = this.BossChallengeButton;
				if (bossChallengeButton != null)
				{
					bossChallengeButton.SetActive(true);
				}
				item.SetUIActive(false);
				double remainTime = (double)this.ActivityRogueData.EndOpenTime - TimeUtil.Instance.GetServerTime();
				CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(remainTime);
				text.SetText(remainTimeDataFormat.CountDownText, true);
				return;
			}
			if (rogueActivityState == ERogueActivityState.ReceiveReward)
			{
				RoguelikeActivityNormalInstButton normalInstButton2 = this.NormalInstButton;
				if (normalInstButton2 != null)
				{
					normalInstButton2.SetActive(false);
				}
				RoguelikeChallengeButtonItem bossChallengeButton2 = this.BossChallengeButton;
				if (bossChallengeButton2 != null)
				{
					bossChallengeButton2.SetActive(false);
				}
				item.SetUIActive(true);
				LguiUtil.Instance.SetLocalText(text, "Rogue_Function_End_Tip", Array.Empty<object>());
				return;
			}
			RoguelikeActivityNormalInstButton normalInstButton3 = this.NormalInstButton;
			if (normalInstButton3 != null)
			{
				normalInstButton3.SetActive(false);
			}
			RoguelikeChallengeButtonItem bossChallengeButton3 = this.BossChallengeButton;
			if (bossChallengeButton3 != null)
			{
				bossChallengeButton3.SetActive(false);
			}
			item.SetUIActive(true);
			LguiUtil.Instance.SetLocalText(text, "Rogue_Function_End_Tip", Array.Empty<object>());
		}

		// Token: 0x06028717 RID: 165655 RVA: 0x00B55404 File Offset: 0x00B53604
		private UniTask InitRequest()
		{
			RoguelikeActivityView.<InitRequest>d__32 <InitRequest>d__;
			<InitRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRequest>d__.<>4__this = this;
			<InitRequest>d__.<>1__state = -1;
			<InitRequest>d__.<>t__builder.Start<RoguelikeActivityView.<InitRequest>d__32>(ref <InitRequest>d__);
			return <InitRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06028718 RID: 165656 RVA: 0x00B55448 File Offset: 0x00B53648
		[NullableContext(1)]
		private List<int> GetNewUnlockPhantomList(IReadOnlyList<int> unlockPhantomList)
		{
			List<int> list = new List<int>();
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RoguelikeNewPhantomUnlock) as ServerStorageSet;
			foreach (int num in unlockPhantomList)
			{
				RoguePokemon? roguePhantomConfig = RoguelikeConfig.Instance.GetRoguePhantomConfig(num);
				if (roguePhantomConfig != null && roguePhantomConfig.Value.UnlockInst != 0 && !serverStorageSet.Has(num))
				{
					serverStorageSet.Add(num);
					list.Add(num);
				}
			}
			return list;
		}

		// Token: 0x04015F44 RID: 89924
		protected PopupCaptionItem CaptionItem;

		// Token: 0x04015F45 RID: 89925
		private ActivityRogueData ActivityRogueData;

		// Token: 0x04015F46 RID: 89926
		private RoguelikeBlackFlowerItem BlackFlowerComponent;

		// Token: 0x04015F47 RID: 89927
		private RoguelikeChallengeButtonItem BossChallengeButton;

		// Token: 0x04015F48 RID: 89928
		private RoguelikeActivityNormalInstButton NormalInstButton;

		// Token: 0x04015F49 RID: 89929
		private RoguelikeLastInfo LastInfo;

		// Token: 0x04015F4A RID: 89930
		private RogueArchiveInfo TempAchieveInfo;

		// Token: 0x04015F4B RID: 89931
		[Nullable(1)]
		private List<int> NewUnlockPhantomList = new List<int>();

		// Token: 0x020099CC RID: 39372
		[NullableContext(0)]
		private class ERoguelikeActivityViewDefine
		{
			// Token: 0x0402FF29 RID: 196393
			public const int CaptionItem = 0;

			// Token: 0x0402FF2A RID: 196394
			public const int TxtTitle = 1;

			// Token: 0x0402FF2B RID: 196395
			public const int BtnSkillTree = 2;

			// Token: 0x0402FF2C RID: 196396
			public const int BtnDoor = 3;

			// Token: 0x0402FF2D RID: 196397
			public const int BtnConfirm = 4;

			// Token: 0x0402FF2E RID: 196398
			public const int TexBg = 5;

			// Token: 0x0402FF2F RID: 196399
			public const int BtnRewardShop = 6;

			// Token: 0x0402FF30 RID: 196400
			public const int TxtRewardShopProgress = 7;

			// Token: 0x0402FF31 RID: 196401
			public const int SkillRedItem = 8;

			// Token: 0x0402FF32 RID: 196402
			public const int AchievementRedItem = 9;

			// Token: 0x0402FF33 RID: 196403
			public const int ShopRedItem = 10;

			// Token: 0x0402FF34 RID: 196404
			public const int TxtSubTitle = 11;

			// Token: 0x0402FF35 RID: 196405
			public const int ActivityTimeText = 12;

			// Token: 0x0402FF36 RID: 196406
			public const int ActivityEndItem = 13;

			// Token: 0x0402FF37 RID: 196407
			public const int BlackFlowerItem = 14;

			// Token: 0x0402FF38 RID: 196408
			public const int BtnBossChallenge = 15;
		}
	}
}
