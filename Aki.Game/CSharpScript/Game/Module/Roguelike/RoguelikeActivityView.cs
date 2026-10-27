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
	// Token: 0x02004E07 RID: 19975
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeActivityView : UiTickViewBase
	{
		// Token: 0x06033895 RID: 211093 RVA: 0x00C0B3DF File Offset: 0x00C095DF
		[NullableContext(1)]
		public RoguelikeActivityView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033896 RID: 211094 RVA: 0x00C0B3F4 File Offset: 0x00C095F4
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

		// Token: 0x06033897 RID: 211095 RVA: 0x00C0B6B8 File Offset: 0x00C098B8
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeActivityView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeActivityView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033898 RID: 211096 RVA: 0x00C0B6FC File Offset: 0x00C098FC
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

		// Token: 0x06033899 RID: 211097 RVA: 0x00C0B7B4 File Offset: 0x00C099B4
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

		// Token: 0x0603389A RID: 211098 RVA: 0x00C0B80D File Offset: 0x00C09A0D
		protected override void OnBeforeHide()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.RogueSkillUnlock);
			RedDotController.Instance.UnBindRedDot(ERedDotName.RoguelikeAchievement);
			RedDotController.Instance.UnBindRedDot(ERedDotName.RoguelikeShop);
		}

		// Token: 0x0603389B RID: 211099 RVA: 0x00C0B833 File Offset: 0x00C09A33
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoguelikeCurrencyUpdate, new Action(this.RefreshUi));
		}

		// Token: 0x0603389C RID: 211100 RVA: 0x00C0B851 File Offset: 0x00C09A51
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoguelikeCurrencyUpdate, new Action(this.RefreshUi));
		}

		// Token: 0x0603389D RID: 211101 RVA: 0x00C0B86F File Offset: 0x00C09A6F
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.RoguelikeArchiveSaved, new Action<int>(this.ClearTempAchieveInfo));
		}

		// Token: 0x0603389E RID: 211102 RVA: 0x00C0B88D File Offset: 0x00C09A8D
		protected override void OnTick(float delta)
		{
			this.RefreshRemainTime();
		}

		// Token: 0x0603389F RID: 211103 RVA: 0x00C0B898 File Offset: 0x00C09A98
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

		// Token: 0x060338A0 RID: 211104 RVA: 0x00C0B968 File Offset: 0x00C09B68
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

		// Token: 0x060338A1 RID: 211105 RVA: 0x00C0B9C0 File Offset: 0x00C09BC0
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

		// Token: 0x060338A2 RID: 211106 RVA: 0x00C0BA3C File Offset: 0x00C09C3C
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

		// Token: 0x060338A3 RID: 211107 RVA: 0x00C0BA98 File Offset: 0x00C09C98
		private void RefreshBossChallengeButton()
		{
			RoguelikeChallengeButtonItem bossChallengeButton = this.BossChallengeButton;
			if (bossChallengeButton == null)
			{
				return;
			}
			bossChallengeButton.SetTxtScore(this.ActivityRogueData.SeasonData.TowerTrialBestClearCount);
		}

		// Token: 0x060338A4 RID: 211108 RVA: 0x00C0BABC File Offset: 0x00C09CBC
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

		// Token: 0x060338A5 RID: 211109 RVA: 0x00C0BB4C File Offset: 0x00C09D4C
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

		// Token: 0x060338A6 RID: 211110 RVA: 0x00C0BC48 File Offset: 0x00C09E48
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

		// Token: 0x060338A7 RID: 211111 RVA: 0x00C0BCB8 File Offset: 0x00C09EB8
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

		// Token: 0x060338A8 RID: 211112 RVA: 0x00C0BD38 File Offset: 0x00C09F38
		private void ClearTempAchieveInfo(int slotId)
		{
			this.TempAchieveInfo = null;
		}

		// Token: 0x060338A9 RID: 211113 RVA: 0x00C0BD41 File Offset: 0x00C09F41
		private void ClearLastInfo()
		{
			this.LastInfo = null;
			this.RefreshLastInfo();
		}

		// Token: 0x060338AA RID: 211114 RVA: 0x00C0BD50 File Offset: 0x00C09F50
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

		// Token: 0x060338AB RID: 211115 RVA: 0x00C0BDE4 File Offset: 0x00C09FE4
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

		// Token: 0x060338AC RID: 211116 RVA: 0x00C0BEF8 File Offset: 0x00C0A0F8
		private UniTask InitRequest()
		{
			RoguelikeActivityView.<InitRequest>d__32 <InitRequest>d__;
			<InitRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRequest>d__.<>4__this = this;
			<InitRequest>d__.<>1__state = -1;
			<InitRequest>d__.<>t__builder.Start<RoguelikeActivityView.<InitRequest>d__32>(ref <InitRequest>d__);
			return <InitRequest>d__.<>t__builder.Task;
		}

		// Token: 0x060338AD RID: 211117 RVA: 0x00C0BF3C File Offset: 0x00C0A13C
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

		// Token: 0x0401B571 RID: 111985
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401B572 RID: 111986
		private ActivityRogueData ActivityRogueData;

		// Token: 0x0401B573 RID: 111987
		private RoguelikeBlackFlowerItem BlackFlowerComponent;

		// Token: 0x0401B574 RID: 111988
		private RoguelikeChallengeButtonItem BossChallengeButton;

		// Token: 0x0401B575 RID: 111989
		private RoguelikeActivityNormalInstButton NormalInstButton;

		// Token: 0x0401B576 RID: 111990
		private RoguelikeLastInfo LastInfo;

		// Token: 0x0401B577 RID: 111991
		private RogueArchiveInfo TempAchieveInfo;

		// Token: 0x0401B578 RID: 111992
		[Nullable(1)]
		private List<int> NewUnlockPhantomList = new List<int>();

		// Token: 0x0200AF97 RID: 44951
		[NullableContext(0)]
		private class ERoguelikeActivityViewDefine
		{
			// Token: 0x040354F6 RID: 218358
			public const int CaptionItem = 0;

			// Token: 0x040354F7 RID: 218359
			public const int TxtTitle = 1;

			// Token: 0x040354F8 RID: 218360
			public const int BtnSkillTree = 2;

			// Token: 0x040354F9 RID: 218361
			public const int BtnDoor = 3;

			// Token: 0x040354FA RID: 218362
			public const int BtnConfirm = 4;

			// Token: 0x040354FB RID: 218363
			public const int TexBg = 5;

			// Token: 0x040354FC RID: 218364
			public const int BtnRewardShop = 6;

			// Token: 0x040354FD RID: 218365
			public const int TxtRewardShopProgress = 7;

			// Token: 0x040354FE RID: 218366
			public const int SkillRedItem = 8;

			// Token: 0x040354FF RID: 218367
			public const int AchievementRedItem = 9;

			// Token: 0x04035500 RID: 218368
			public const int ShopRedItem = 10;

			// Token: 0x04035501 RID: 218369
			public const int TxtSubTitle = 11;

			// Token: 0x04035502 RID: 218370
			public const int ActivityTimeText = 12;

			// Token: 0x04035503 RID: 218371
			public const int ActivityEndItem = 13;

			// Token: 0x04035504 RID: 218372
			public const int BlackFlowerItem = 14;

			// Token: 0x04035505 RID: 218373
			public const int BtnBossChallenge = 15;
		}
	}
}
