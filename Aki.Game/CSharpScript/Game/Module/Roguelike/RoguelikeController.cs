using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Weather;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DA7 RID: 19879
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class RoguelikeController : UiControllerBase
	{
		// Token: 0x06033528 RID: 210216 RVA: 0x00BFA933 File Offset: 0x00BF8B33
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoading));
		}

		// Token: 0x06033529 RID: 210217 RVA: 0x00BFA951 File Offset: 0x00BF8B51
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoading));
		}

		// Token: 0x0603352A RID: 210218 RVA: 0x00BFA970 File Offset: 0x00BF8B70
		public void OnCloseLoading()
		{
			if (RoguelikeModel.Instance.ShowRewardList != null && RoguelikeModel.Instance.ShowRewardList.Count > 0)
			{
				this.IsFromRogueToNormal = new bool?(false);
				List<RewardItemData> showRewardList = RoguelikeModel.Instance.ShowRewardList;
				RoguelikeModel.Instance.ShowRewardList = null;
				List<IRewardExploreConfirmButton> list = new List<IRewardExploreConfirmButton>();
				RewardExploreConfirmButtonData item = new RewardExploreConfirmButtonData
				{
					ButtonTextId = "ConfirmBox_45_ButtonText_1",
					DescriptionTextId = null,
					DescriptionArgs = null,
					IsTimeDownCloseView = false,
					IsClickedCloseView = false,
					OnClickedCallback = delegate(int index)
					{
						if (UiManager.Instance.IsViewShow(EUiViewName.ExploreRewardView))
						{
							UiManager.Instance.CloseView(EUiViewName.ExploreRewardView, delegate(bool success)
							{
								if (success)
								{
									this.OpenRoguelikeActivityView().ContinueWith(delegate(bool task)
									{
										RogueParam? paramConfigBySeasonId = RoguelikeModel.Instance.GetParamConfigBySeasonId(null);
										if (paramConfigBySeasonId != null && paramConfigBySeasonId.Value.DungeonList() != null && RoguelikeModel.Instance != null && RoguelikeModel.Instance.CurDungeonId != null)
										{
											int num = paramConfigBySeasonId.Value.DungeonList().ToList<int>().FindIndex((int value) => value == RoguelikeModel.Instance.CurDungeonId.Value);
											int num2 = num + 1;
											if (num != -1 && num2 < paramConfigBySeasonId.Value.DungeonListLength)
											{
												InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(paramConfigBySeasonId.Value.DungeonList()[num2]);
												if (config != null && InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(config.Value.Id))
												{
													string localTextNew = ConfigMultiTextLang.GetLocalTextNew(config.Value.MapName, null);
													UiManager.Instance.OpenView(EUiViewName.RoguelikeUnlockTips, localTextNew, null);
												}
											}
											RoguelikeModel.Instance.CurDungeonId = null;
										}
									});
								}
							});
						}
					}
				};
				list.Add(item);
				ItemRewardController.Instance.OpenExploreRewardView(3010, true, showRewardList, null, null, list, null, null, null, null, null, null, null, null, null, null, null);
			}
			else if (this.IsFromRogueToNormal.GetValueOrDefault())
			{
				this.IsFromRogueToNormal = new bool?(false);
				this.OpenRoguelikeActivityView();
			}
			this.CurrentFlowId = 0;
			this.CurrentFlowListName = "";
			this.CurrentStateId = 0;
		}

		// Token: 0x0603352B RID: 210219 RVA: 0x00BFAA7C File Offset: 0x00BF8C7C
		[NullableContext(0)]
		public UniTask<bool> OpenRoguelikeActivityView()
		{
			RoguelikeController.<OpenRoguelikeActivityView>d__8 <OpenRoguelikeActivityView>d__;
			<OpenRoguelikeActivityView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenRoguelikeActivityView>d__.<>1__state = -1;
			<OpenRoguelikeActivityView>d__.<>t__builder.Start<RoguelikeController.<OpenRoguelikeActivityView>d__8>(ref <OpenRoguelikeActivityView>d__);
			return <OpenRoguelikeActivityView>d__.<>t__builder.Task;
		}

		// Token: 0x0603352C RID: 210220 RVA: 0x00BFAAB8 File Offset: 0x00BF8CB8
		protected override void OnAddOpenViewCheckFunction()
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoguelikeActivityView, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "RoguelikeController.CheckCanOpen");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoguelikeInstanceView, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "RoguelikeController.CheckCanOpen");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoguelikeMemoryPlaceView, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "RoguelikeController.CheckCanOpen");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoguelikeSelectRoleView, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "RoguelikeController.CheckCanOpen");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoguelikeTokenOverView, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "RoguelikeController.CheckCanOpen");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoguelikeSkillView, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "RoguelikeController.CheckCanOpen");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoguelikeExitTips, new Func<EUiViewName, object, bool>(this.CheckCanOpenExitTips), "RoguelikeController.CheckCanOpenExitTips");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoguelikeEntranceView, new Func<EUiViewName, object, bool>(this.CheckCanOpen), "RoguelikeController.CheckCanOpen");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoguelikeAchieveView, new Func<EUiViewName, object, bool>(this.CheckCanOpenAchieve), "RoguelikeController.CheckCanOpen");
		}

		// Token: 0x0603352D RID: 210221 RVA: 0x00BFABE8 File Offset: 0x00BF8DE8
		protected override void OnRemoveOpenViewCheckFunction()
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoguelikeActivityView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoguelikeInstanceView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoguelikeMemoryPlaceView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoguelikeSelectRoleView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoguelikeTokenOverView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RogueInfoView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoguelikeSkillView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoguelikeEntranceView, new Func<EUiViewName, object, bool>(this.CheckCanOpen));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoguelikeAchieveView, new Func<EUiViewName, object, bool>(this.CheckCanOpenAchieve));
		}

		// Token: 0x0603352E RID: 210222 RVA: 0x00BFACE8 File Offset: 0x00BF8EE8
		[NullableContext(1)]
		public bool CheckCanOpen(EUiViewName viewName, object openParam)
		{
			if (!RoguelikeModel.Instance.CheckRogueIsOpen())
			{
				ScrollingTipsController.Instance.ShowTipsById("Rogue_Function_Not_Open_Tip", Array.Empty<object>());
				return false;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsById("Rogue_Multi_Tip", Array.Empty<object>());
				return false;
			}
			if (this.IsFromRogueToNormal.GetValueOrDefault())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Rogue_Function_Instance_End_Tip", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x0603352F RID: 210223 RVA: 0x00BFAD60 File Offset: 0x00BF8F60
		[NullableContext(1)]
		private bool CheckCanOpenAchieve(EUiViewName viewName, object openParam)
		{
			if (!RoguelikeModel.Instance.CheckRogueIsOpen())
			{
				ScrollingTipsController.Instance.ShowTipsById("Rogue_Function_Not_Open_Tip", Array.Empty<object>());
				return false;
			}
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsById("Rogue_Multi_Tip", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x06033530 RID: 210224 RVA: 0x00BFADB2 File Offset: 0x00BF8FB2
		[NullableContext(1)]
		public bool CheckCanOpenExitTips(EUiViewName viewName, object openParam)
		{
			if (this.IsFromRogueToNormal.GetValueOrDefault())
			{
				ScrollingTipsController.Instance.ShowTipsById("Rogue_Function_Instance_End_Tip", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x06033531 RID: 210225 RVA: 0x00BFADD8 File Offset: 0x00BF8FD8
		public UniTask OpenBuffSelectViewByIdAsync(int index)
		{
			RoguelikeController.<OpenBuffSelectViewByIdAsync>d__14 <OpenBuffSelectViewByIdAsync>d__;
			<OpenBuffSelectViewByIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenBuffSelectViewByIdAsync>d__.<>4__this = this;
			<OpenBuffSelectViewByIdAsync>d__.index = index;
			<OpenBuffSelectViewByIdAsync>d__.<>1__state = -1;
			<OpenBuffSelectViewByIdAsync>d__.<>t__builder.Start<RoguelikeController.<OpenBuffSelectViewByIdAsync>d__14>(ref <OpenBuffSelectViewByIdAsync>d__);
			return <OpenBuffSelectViewByIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033532 RID: 210226 RVA: 0x00BFAE24 File Offset: 0x00BF9024
		[NullableContext(0)]
		public UniTask<bool> OpenBuffSelectViewById(int index)
		{
			RoguelikeController.<OpenBuffSelectViewById>d__15 <OpenBuffSelectViewById>d__;
			<OpenBuffSelectViewById>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenBuffSelectViewById>d__.<>4__this = this;
			<OpenBuffSelectViewById>d__.index = index;
			<OpenBuffSelectViewById>d__.<>1__state = -1;
			<OpenBuffSelectViewById>d__.<>t__builder.Start<RoguelikeController.<OpenBuffSelectViewById>d__15>(ref <OpenBuffSelectViewById>d__);
			return <OpenBuffSelectViewById>d__.<>t__builder.Task;
		}

		// Token: 0x06033533 RID: 210227 RVA: 0x00BFAE70 File Offset: 0x00BF9070
		public EUiViewName? GetViewNameByGainType(RoguelikeGainDataType type)
		{
			switch (type)
			{
			case RoguelikeGainDataType.Phantom:
				if (RoguelikeConfig.Instance.GetRoguePhantomConfig(RoguelikeModel.Instance.RogueInfo.PhantomEntry.ConfigId) == null)
				{
					return new EUiViewName?(EUiViewName.RoguePhantomSelectView);
				}
				return new EUiViewName?(EUiViewName.RoguePhantomReplaceView);
			case RoguelikeGainDataType.Shop:
				return new EUiViewName?(EUiViewName.RogueShopView);
			case RoguelikeGainDataType.Role:
				return new EUiViewName?(EUiViewName.RoleReplaceView);
			case RoguelikeGainDataType.CommonBuff:
				return new EUiViewName?(EUiViewName.CommonSelectView);
			case RoguelikeGainDataType.RoleBuff:
				return new EUiViewName?(EUiViewName.RoleBuffSelectView);
			case RoguelikeGainDataType.Event:
				return new EUiViewName?(EUiViewName.RoguelikeRandomEventView);
			case RoguelikeGainDataType.Miraclecreation:
				return new EUiViewName?(EUiViewName.RoguelikeSelectSpecialView);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Roguelike;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "当前增益类型没有对应的界面数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type.ToString());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x06033534 RID: 210228 RVA: 0x00BFAF68 File Offset: 0x00BF9168
		public void RoguelikeCurrencyNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoguelikeCurrencyNotify roguelikeCurrencyNotify = (RoguelikeCurrencyNotify)msg;
			RoguelikeModel.Instance.RoguelikeCurrencyDictMap.Clear();
			foreach (int num in roguelikeCurrencyNotify.CurrencyDict.Keys)
			{
				RoguelikeModel.Instance.SetRoguelikeCurrency(num, roguelikeCurrencyNotify.CurrencyDict[num]);
			}
			EventSystem.Instance.Emit(EEventName.RoguelikeCurrencyUpdate);
			EventSystem.Instance.Emit(EEventName.PayShopGoodsBuy);
		}

		// Token: 0x06033535 RID: 210229 RVA: 0x00BFB000 File Offset: 0x00BF9200
		public void RoguelikeCurrencyUpdateNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoguelikeCurrencyUpdateNotify roguelikeCurrencyUpdateNotify = (RoguelikeCurrencyUpdateNotify)msg;
			RogueParam? paramConfigBySeasonId = RoguelikeModel.Instance.GetParamConfigBySeasonId(null);
			if (paramConfigBySeasonId == null)
			{
				return;
			}
			foreach (int num in roguelikeCurrencyUpdateNotify.CurrencyUpdateDict.Keys)
			{
				int num2 = num;
				int num3 = roguelikeCurrencyUpdateNotify.CurrencyUpdateDict[num];
				RoguelikeModel.Instance.UpdateRoguelikeCurrency(num2, num3);
				if (num2 == paramConfigBySeasonId.Value.InsideCurrency && num3 > 0)
				{
					ItemHintController.Instance.AddRoguelikeItemList(paramConfigBySeasonId.Value.InsideCurrency, num3);
				}
			}
			EventSystem.Instance.Emit(EEventName.RoguelikeCurrencyUpdate);
		}

		// Token: 0x06033536 RID: 210230 RVA: 0x00BFB0D8 File Offset: 0x00BF92D8
		private void OnRoguelikeEventGainNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoguelikeEventGainNotify notify = (RoguelikeEventGainNotify)msg;
			this.RoguelikeEventGainNotify(notify, null);
		}

		// Token: 0x06033537 RID: 210231 RVA: 0x00BFB0F4 File Offset: 0x00BF92F4
		[NullableContext(1)]
		public void RoguelikeEventGainNotify(RoguelikeEventGainNotify notify, [Nullable(2)] Action<bool?> callback = null)
		{
			List<RogueGainEntry> list = new List<RogueGainEntry>();
			if (notify.RogueGainEntryList.Count > 0)
			{
				foreach (RogueGainEntry rogueGainEntry in notify.RogueGainEntryList)
				{
					list.Add(new RogueGainEntry(rogueGainEntry, null));
				}
				UiManager.Instance.OpenView(EUiViewName.RogueEventResultViewOneByOne, new EventResult(list, callback), null);
				return;
			}
			if (notify.RogueGainEntryList2.Count > 0)
			{
				foreach (RogueGainEntry rogueGainEntry2 in notify.RogueGainEntryList2)
				{
					list.Add(new RogueGainEntry(rogueGainEntry2, null));
				}
				UiManager.Instance.OpenView(EUiViewName.RogueEventResultViewAll, new EventResult(list, callback), null);
				return;
			}
			if (callback != null)
			{
				callback(null);
			}
		}

		// Token: 0x06033538 RID: 210232 RVA: 0x00BFB200 File Offset: 0x00BF9400
		public void RoguelikeGainDataUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RoguelikeGainDataUpdateNotify notify = (RoguelikeGainDataUpdateNotify)msg;
			if (RoguelikeModel.Instance.RogueInfo == null)
			{
				return;
			}
			RoguelikeModel.Instance.RogueInfo.Update(notify);
		}

		// Token: 0x06033539 RID: 210233 RVA: 0x00BFB234 File Offset: 0x00BF9434
		public void RoguelikeChooseDataNotify(IMessage msg, Net.CallbackStatus status)
		{
			RoguelikeChooseDataNotify roguelikeChooseDataNotify = (RoguelikeChooseDataNotify)msg;
			RoguelikeModel.Instance.SetRoguelikeChooseData(roguelikeChooseDataNotify.RoguelikeChooseDataList);
			EventSystem.Instance.Emit(EEventName.RoguelikeChooseDataNotify);
		}

		// Token: 0x0603353A RID: 210234 RVA: 0x00BFB268 File Offset: 0x00BF9468
		public void RoguelikeTalentUnlockNotify(IMessage msg, Net.CallbackStatus status)
		{
			RoguelikeTalentUnlockNotify roguelikeTalentUnlockNotify = (RoguelikeTalentUnlockNotify)msg;
			RoguelikeModel.Instance.SetRoguelikeSkillData(roguelikeTalentUnlockNotify.SkillId, 0);
		}

		// Token: 0x0603353B RID: 210235 RVA: 0x00BFB290 File Offset: 0x00BF9490
		public void RoguelikeRefreshGainRequest(int bindId)
		{
			RoguelikeRefreshGainRequest roguelikeRefreshGainRequest = Aki.Protocol.RoguelikeRefreshGainRequest.Create();
			roguelikeRefreshGainRequest.BindId = bindId;
			roguelikeRefreshGainRequest.Layer = RoguelikeModel.Instance.CurRoomCount;
			Net.Instance.Call(ERequestMessageId.RoguelikeRefreshGainRequest, roguelikeRefreshGainRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoguelikeRefreshGainResponse roguelikeRefreshGainResponse = (RoguelikeRefreshGainResponse)msg;
				if (roguelikeRefreshGainResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeScrollingTipsView(roguelikeRefreshGainResponse.ErrorCode, roguelikeRefreshGainResponse.ErrorParams.ToArray<string>());
					return;
				}
				RoguelikeModel.Instance.SetRoguelikeChooseData(new <>z__ReadOnlySingleElementList<RoguelikeChooseData>(roguelikeRefreshGainResponse.RoguelikeChooseData));
				EventSystem.Instance.Emit<int>(EEventName.RoguelikeRefreshGain, roguelikeRefreshGainResponse.RoguelikeChooseData.Index);
			}, 0);
		}

		// Token: 0x0603353C RID: 210236 RVA: 0x00BFB2EC File Offset: 0x00BF94EC
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<RoguelikeLastInfoResponse> RoguelikeLastInfoRequestAsync()
		{
			RoguelikeController.<RoguelikeLastInfoRequestAsync>d__25 <RoguelikeLastInfoRequestAsync>d__;
			<RoguelikeLastInfoRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<RoguelikeLastInfoResponse>.Create();
			<RoguelikeLastInfoRequestAsync>d__.<>1__state = -1;
			<RoguelikeLastInfoRequestAsync>d__.<>t__builder.Start<RoguelikeController.<RoguelikeLastInfoRequestAsync>d__25>(ref <RoguelikeLastInfoRequestAsync>d__);
			return <RoguelikeLastInfoRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603353D RID: 210237 RVA: 0x00BFB328 File Offset: 0x00BF9528
		public void EnterCurrentRogueEntrance()
		{
			RogueSeasonData seasonData = ActivityRogueController.Instance.GetCurrentActivityData().SeasonData;
			if (seasonData == null)
			{
				Log.Instance.Error(ELogModule.Roguelike, ELogAuthor.LPH, "打开副本选择界面时肉鸽赛季数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(seasonData.SeasonId);
			InstanceDungeonEntranceController.Instance.EnterEntrance(rogueSeasonConfigById.Value.InstanceDungeonEntrance, 0, null).Forget<bool>();
		}

		// Token: 0x0603353E RID: 210238 RVA: 0x00BFB39C File Offset: 0x00BF959C
		public void OpenRoguelikeInstanceView()
		{
			RoguelikeDungeonViewModel param = new RoguelikeDungeonViewModel();
			UiManager.Instance.OpenView(EUiViewName.InstanceDungeonEntranceView, param, null);
		}

		// Token: 0x0603353F RID: 210239 RVA: 0x00BFB3C0 File Offset: 0x00BF95C0
		public void OpenRogueInfoView(RoguelikeInfo rogueInfo = null, bool checkLimit = true, bool showCurrency = true, ERogueInfoViewPage defaultPage = ERogueInfoViewPage.Overview)
		{
			if (checkLimit)
			{
				if (!RoguelikeModel.Instance.CheckRogueIsOpen())
				{
					ScrollingTipsController.Instance.ShowTipsById("Rogue_Function_Not_Open_Tip", Array.Empty<object>());
					return;
				}
				if (GameModeModel.Instance.IsMulti)
				{
					ScrollingTipsController.Instance.ShowTipsById("Rogue_Multi_Tip", Array.Empty<object>());
					return;
				}
				if (this.IsFromRogueToNormal.GetValueOrDefault())
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Rogue_Function_Instance_End_Tip", Array.Empty<object>());
					return;
				}
			}
			RogueInfoViewModel rogueInfoViewModel = new RogueInfoViewModel(rogueInfo ?? RoguelikeModel.Instance.RogueInfo);
			rogueInfoViewModel.ShowCurrency = showCurrency;
			rogueInfoViewModel.DefaultPage = defaultPage;
			UiManager.Instance.OpenView(EUiViewName.RogueInfoView, rogueInfoViewModel, null);
		}

		// Token: 0x06033540 RID: 210240 RVA: 0x00BFB46C File Offset: 0x00BF966C
		[NullableContext(1)]
		public UniTask OpenRoguelikeAchieveView(IRoguelikeAchieveViewInfo viewInfo)
		{
			RoguelikeController.<OpenRoguelikeAchieveView>d__29 <OpenRoguelikeAchieveView>d__;
			<OpenRoguelikeAchieveView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenRoguelikeAchieveView>d__.viewInfo = viewInfo;
			<OpenRoguelikeAchieveView>d__.<>1__state = -1;
			<OpenRoguelikeAchieveView>d__.<>t__builder.Start<RoguelikeController.<OpenRoguelikeAchieveView>d__29>(ref <OpenRoguelikeAchieveView>d__);
			return <OpenRoguelikeAchieveView>d__.<>t__builder.Task;
		}

		// Token: 0x06033541 RID: 210241 RVA: 0x00BFB4AF File Offset: 0x00BF96AF
		public void OpenRoguelikeSelectRoleView(int instanceId)
		{
			UiManager.Instance.OpenView(EUiViewName.RoguelikeEntranceView, instanceId, null);
		}

		// Token: 0x06033542 RID: 210242 RVA: 0x00BFB4C8 File Offset: 0x00BF96C8
		public void OpenRoguelikeSkillView(int seasonId)
		{
			this.RoguelikeTalentInfoRequest(seasonId).ContinueWith(delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.RoguelikeSkillView, seasonId, null);
			});
		}

		// Token: 0x06033543 RID: 210243 RVA: 0x00BFB500 File Offset: 0x00BF9700
		[NullableContext(1)]
		private unsafe void OpenRoguelikeBossChallengeResultView(int instId, RogueTowerTrialResultInfo resultInfo)
		{
			ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
			RogueSeasonData rogueSeasonData = (currentActivityData != null) ? currentActivityData.SeasonData : null;
			RogueTowerTrialResultInfo resultInfo2 = resultInfo;
			bool flag;
			if (resultInfo2 == null)
			{
				flag = false;
			}
			else
			{
				int historyMaxKills = resultInfo2.HistoryMaxKills;
				flag = true;
			}
			if (flag && rogueSeasonData != null)
			{
				int historyMaxKills2 = resultInfo.HistoryMaxKills;
				rogueSeasonData.TowerTrialBestClearCount = historyMaxKills2;
			}
			if (resultInfo == null)
			{
				if (RoguelikeModel.Instance.CheckInRoguelike())
				{
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
				}
				return;
			}
			IRewardExploreConfirmButton rewardExploreConfirmButton = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "Rogue_TowerResult_Exit",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true,
				OnClickedCallback = delegate(int _)
				{
					this.IsFromRogueToNormal = new bool?(RoguelikeModel.Instance.CheckInRoguelike());
					InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
				}
			};
			IRewardExploreConfirmButton rewardExploreConfirmButton2 = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "Rogue_TowerResult_Retry",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true,
				OnClickedCallback = delegate(int _)
				{
					this.RoguelikeBossChallengeStartRequest(instId, resultInfo.SlotId, null);
				}
			};
			ExploreRewardViewData exploreRewardViewData = new ExploreRewardViewData();
			exploreRewardViewData.ConfigId = 3032;
			exploreRewardViewData.IsSuccess = true;
			int num = 2;
			List<IRewardExploreConfirmButton> list = new List<IRewardExploreConfirmButton>(num);
			CollectionsMarshal.SetCount<IRewardExploreConfirmButton>(list, num);
			Span<IRewardExploreConfirmButton> span = CollectionsMarshal.AsSpan<IRewardExploreConfirmButton>(list);
			int num2 = 0;
			*span[num2] = rewardExploreConfirmButton;
			num2++;
			*span[num2] = rewardExploreConfirmButton2;
			exploreRewardViewData.ButtonInfoList = list;
			exploreRewardViewData.IsBagFull = new bool?(false);
			ExploreRewardViewData exploreRewardViewData2 = exploreRewardViewData;
			IRoguelikeBossChallengeData roguelikeBossChallengeData = new RoguelikeBossChallengeData
			{
				IsNewRecord = resultInfo.IsNewRecord,
				PassTime = resultInfo.TotalCostTime,
				InstId = instId,
				BossTotalCount = resultInfo.MaxCount,
				FinishedBossIdList = resultInfo.Ids,
				CurrentBossId = new int?(resultInfo.ChallengingBossId)
			};
			exploreRewardViewData2.RoguelikeBossChallengeData = roguelikeBossChallengeData;
			ItemRewardController.Instance.OpenExploreRewardViewNew(exploreRewardViewData2);
		}

		// Token: 0x06033544 RID: 210244 RVA: 0x00BFB6E4 File Offset: 0x00BF98E4
		public UniTask RoguelikeTalentInfoRequest(int seasonId)
		{
			RoguelikeController.<RoguelikeTalentInfoRequest>d__33 <RoguelikeTalentInfoRequest>d__;
			<RoguelikeTalentInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RoguelikeTalentInfoRequest>d__.seasonId = seasonId;
			<RoguelikeTalentInfoRequest>d__.<>1__state = -1;
			<RoguelikeTalentInfoRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeTalentInfoRequest>d__33>(ref <RoguelikeTalentInfoRequest>d__);
			return <RoguelikeTalentInfoRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033545 RID: 210245 RVA: 0x00BFB728 File Offset: 0x00BF9928
		[NullableContext(0)]
		public UniTask<bool> RoguelikeRoleRoomSelectRequest(int roomId, int index)
		{
			RoguelikeController.<RoguelikeRoleRoomSelectRequest>d__34 <RoguelikeRoleRoomSelectRequest>d__;
			<RoguelikeRoleRoomSelectRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RoguelikeRoleRoomSelectRequest>d__.roomId = roomId;
			<RoguelikeRoleRoomSelectRequest>d__.index = index;
			<RoguelikeRoleRoomSelectRequest>d__.<>1__state = -1;
			<RoguelikeRoleRoomSelectRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeRoleRoomSelectRequest>d__34>(ref <RoguelikeRoleRoomSelectRequest>d__);
			return <RoguelikeRoleRoomSelectRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033546 RID: 210246 RVA: 0x00BFB774 File Offset: 0x00BF9974
		[NullableContext(0)]
		public UniTask<bool> RoguelikeSeasonRewardReceiveRequest([Nullable(1)] List<int> indexList, int? seasonId = null)
		{
			RoguelikeController.<RoguelikeSeasonRewardReceiveRequest>d__35 <RoguelikeSeasonRewardReceiveRequest>d__;
			<RoguelikeSeasonRewardReceiveRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RoguelikeSeasonRewardReceiveRequest>d__.indexList = indexList;
			<RoguelikeSeasonRewardReceiveRequest>d__.seasonId = seasonId;
			<RoguelikeSeasonRewardReceiveRequest>d__.<>1__state = -1;
			<RoguelikeSeasonRewardReceiveRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeSeasonRewardReceiveRequest>d__35>(ref <RoguelikeSeasonRewardReceiveRequest>d__);
			return <RoguelikeSeasonRewardReceiveRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033547 RID: 210247 RVA: 0x00BFB7C0 File Offset: 0x00BF99C0
		public UniTask RoguelikeTalentLevelUpRequest(int skillId)
		{
			RoguelikeController.<RoguelikeTalentLevelUpRequest>d__36 <RoguelikeTalentLevelUpRequest>d__;
			<RoguelikeTalentLevelUpRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RoguelikeTalentLevelUpRequest>d__.skillId = skillId;
			<RoguelikeTalentLevelUpRequest>d__.<>1__state = -1;
			<RoguelikeTalentLevelUpRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeTalentLevelUpRequest>d__36>(ref <RoguelikeTalentLevelUpRequest>d__);
			return <RoguelikeTalentLevelUpRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033548 RID: 210248 RVA: 0x00BFB804 File Offset: 0x00BF9A04
		[NullableContext(0)]
		public UniTask<bool> RoguelikeStartRequest(bool isContinue, int instanceId, [Nullable(1)] List<int> roleIds, int hotEntryGroupId)
		{
			RoguelikeController.<RoguelikeStartRequest>d__37 <RoguelikeStartRequest>d__;
			<RoguelikeStartRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RoguelikeStartRequest>d__.isContinue = isContinue;
			<RoguelikeStartRequest>d__.instanceId = instanceId;
			<RoguelikeStartRequest>d__.roleIds = roleIds;
			<RoguelikeStartRequest>d__.hotEntryGroupId = hotEntryGroupId;
			<RoguelikeStartRequest>d__.<>1__state = -1;
			<RoguelikeStartRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeStartRequest>d__37>(ref <RoguelikeStartRequest>d__);
			return <RoguelikeStartRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033549 RID: 210249 RVA: 0x00BFB860 File Offset: 0x00BF9A60
		public void RoguelikeQuitRequest()
		{
			if (this.IsFromRogueToNormal.GetValueOrDefault())
			{
				return;
			}
			bool isGuideDungeon = RoguelikeModel.Instance.CheckIsGuideDungeon();
			RoguelikeQuitRequest message = Aki.Protocol.RoguelikeQuitRequest.Create();
			Net.Instance.Call(ERequestMessageId.RoguelikeQuitRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoguelikeQuitResponse roguelikeQuitResponse = (RoguelikeQuitResponse)msg;
				if (roguelikeQuitResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeQuitResponse.ErrorCode, 15309, null, true, true);
				}
				this.IsFromRogueToNormal = new bool?(!isGuideDungeon);
				InstanceDungeonModel.Instance.ClearInstanceDungeonInfo();
			}, 0);
		}

		// Token: 0x0603354A RID: 210250 RVA: 0x00BFB8BC File Offset: 0x00BF9ABC
		public void RoguelikeResultRequest(int instId, Action<bool> callback = null)
		{
			if (!this.IsFromRogueToNormal.GetValueOrDefault())
			{
				RoguelikeResultRequest roguelikeResultRequest = Aki.Protocol.RoguelikeResultRequest.Create();
				roguelikeResultRequest.InstId = instId;
				Net.Instance.Call(ERequestMessageId.RoguelikeResultRequest, roguelikeResultRequest, delegate(IMessage msg, Net.CallbackStatus _)
				{
					RoguelikeResultResponse roguelikeResultResponse = (RoguelikeResultResponse)msg;
					if (roguelikeResultResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
					{
						ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeResultResponse.ErrorCode, 28757, null, true, true);
						Action<bool> callback3 = callback;
						if (callback3 == null)
						{
							return;
						}
						callback3(false);
						return;
					}
					else
					{
						RoguelikeResultInfo roguelikeResultInfo = roguelikeResultResponse.RoguelikeResultInfo;
						if (this.TryExitRoguelikeWithoutSettleView(roguelikeResultInfo))
						{
							Action<bool> callback4 = callback;
							if (callback4 == null)
							{
								return;
							}
							callback4(false);
							return;
						}
						else
						{
							this.IsFromRogueToNormal = new bool?(RoguelikeModel.Instance.CheckInRoguelike());
							UiManager.Instance.OpenView(EUiViewName.RoguelikeSettleView, roguelikeResultInfo, null);
							Action<bool> callback5 = callback;
							if (callback5 == null)
							{
								return;
							}
							callback5(true);
							return;
						}
					}
				}, 0);
				return;
			}
			Action<bool> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(false);
		}

		// Token: 0x0603354B RID: 210251 RVA: 0x00BFB928 File Offset: 0x00BF9B28
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<RogueInstExtraInfoResponse> RoguelikeInstExtraInfoRequest(int? seasonId = null)
		{
			RoguelikeController.<RoguelikeInstExtraInfoRequest>d__40 <RoguelikeInstExtraInfoRequest>d__;
			<RoguelikeInstExtraInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<RogueInstExtraInfoResponse>.Create();
			<RoguelikeInstExtraInfoRequest>d__.seasonId = seasonId;
			<RoguelikeInstExtraInfoRequest>d__.<>1__state = -1;
			<RoguelikeInstExtraInfoRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeInstExtraInfoRequest>d__40>(ref <RoguelikeInstExtraInfoRequest>d__);
			return <RoguelikeInstExtraInfoRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603354C RID: 210252 RVA: 0x00BFB96C File Offset: 0x00BF9B6C
		public void RogueChooseDataResultRequest(EPerkType perkType)
		{
			RogueGainEntry selectRogueGainEntry = RoguelikeModel.Instance.CurrentRogueGainEntry;
			RogueGainEntry oldRogueGainEntry = null;
			if (perkType == EPerkType.Phantom)
			{
				oldRogueGainEntry = RoguelikeModel.Instance.RogueInfo.PhantomEntry;
			}
			else if (perkType == EPerkType.Role)
			{
				oldRogueGainEntry = RoguelikeModel.Instance.RogueInfo.RoleEntry;
			}
			else if (perkType == EPerkType.Shop)
			{
				oldRogueGainEntry = RoguelikeModel.Instance.RogueInfo.PhantomEntry;
				int shopItemCoinId = selectRogueGainEntry.ShopItemCoinId;
				int roguelikeCurrency = RoguelikeModel.Instance.GetRoguelikeCurrency(shopItemCoinId);
				int? currentPrice = selectRogueGainEntry.CurrentPrice;
				int num = 0;
				if (roguelikeCurrency < ((currentPrice.GetValueOrDefault() == num & currentPrice != null) ? new int?(selectRogueGainEntry.OriginalPrice) : selectRogueGainEntry.CurrentPrice).Value)
				{
					ScrollingTipsController.Instance.ShowTipsById("RoguelikeShopNotEnoughCurrency", Array.Empty<object>());
					return;
				}
			}
			else
			{
				oldRogueGainEntry = RoguelikeModel.Instance.RogueInfo.PhantomEntry;
			}
			RoguelikeChooseDataResultRequest request = RoguelikeChooseDataResultRequest.Create();
			RoguelikeChooseDataResultRequest request3 = request;
			RogueGainEntry selectRogueGainEntry3 = selectRogueGainEntry;
			request3.Index = ((selectRogueGainEntry3 != null) ? selectRogueGainEntry3.Index : null).GetValueOrDefault();
			RoguelikeChooseDataResultRequest request2 = request;
			RogueGainEntry selectRogueGainEntry2 = selectRogueGainEntry;
			request2.BindId = ((selectRogueGainEntry2 != null) ? selectRogueGainEntry2.BindId : null).GetValueOrDefault();
			request.Layer = RoguelikeModel.Instance.CurRoomCount;
			if (perkType == EPerkType.Event)
			{
				request.BindId = -2;
			}
			Net.Instance.Call(ERequestMessageId.RoguelikeChooseDataResultRequest, request, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RoguelikeChooseDataResultResponse roguelikeChooseDataResultResponse = (RoguelikeChooseDataResultResponse)msg;
				if (roguelikeChooseDataResultResponse.ErrorCode == Aki.Protocol.ErrorCode.RogueGainIsSelect)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeChooseDataResultResponse.ErrorCode, 26274, roguelikeChooseDataResultResponse.ErrorParams, false, true);
					return;
				}
				if (roguelikeChooseDataResultResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeChooseDataResultResponse.ErrorCode, 26274, roguelikeChooseDataResultResponse.ErrorParams, true, true);
					return;
				}
				RoguelikeChooseData roguelikeChooseDataById = RoguelikeModel.Instance.GetRoguelikeChooseDataById(request.BindId);
				roguelikeChooseDataById.IsSelect = new bool?(roguelikeChooseDataResultResponse.IsSelect);
				RogueGainEntry p = null;
				if (perkType == EPerkType.Phantom)
				{
					p = RoguelikeModel.Instance.RogueInfo.PhantomEntry;
				}
				else if (perkType == EPerkType.Role)
				{
					p = RoguelikeModel.Instance.RogueInfo.RoleEntry;
				}
				else if (perkType == EPerkType.Shop)
				{
					selectRogueGainEntry.IsSell = new bool?(true);
					p = selectRogueGainEntry;
				}
				else
				{
					if (perkType == EPerkType.Event)
					{
						if (roguelikeChooseDataResultResponse.RoguelikeChooseDataNotify.RoguelikeChooseDataList.Count <= 0)
						{
							roguelikeChooseDataById.RogueGainEntryList = new List<RogueGainEntry>();
							goto IL_159;
						}
						using (IEnumerator<RoguelikeChooseData> enumerator = roguelikeChooseDataResultResponse.RoguelikeChooseDataNotify.RoguelikeChooseDataList.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								RoguelikeChooseData item = enumerator.Current;
								RoguelikeModel.Instance.SetRoguelikeChooseData(new <>z__ReadOnlySingleElementList<RoguelikeChooseData>(item));
							}
							goto IL_159;
						}
					}
					if (perkType == EPerkType.Special)
					{
						p = selectRogueGainEntry;
					}
				}
				IL_159:
				EventSystem.Instance.Emit<RogueGainEntry, RogueGainEntry, bool, int, RoguelikeChooseDataResultResponse>(EEventName.RoguelikeChooseDataResult, p, oldRogueGainEntry, true, request.BindId, roguelikeChooseDataResultResponse);
			}, 0);
		}

		// Token: 0x0603354D RID: 210253 RVA: 0x00BFBB44 File Offset: 0x00BF9D44
		[NullableContext(0)]
		public UniTask<bool> RoguelikeAchieveSaveRecordRequest(int slotId)
		{
			RoguelikeController.<RoguelikeAchieveSaveRecordRequest>d__42 <RoguelikeAchieveSaveRecordRequest>d__;
			<RoguelikeAchieveSaveRecordRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RoguelikeAchieveSaveRecordRequest>d__.slotId = slotId;
			<RoguelikeAchieveSaveRecordRequest>d__.<>1__state = -1;
			<RoguelikeAchieveSaveRecordRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeAchieveSaveRecordRequest>d__42>(ref <RoguelikeAchieveSaveRecordRequest>d__);
			return <RoguelikeAchieveSaveRecordRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0603354E RID: 210254 RVA: 0x00BFBB88 File Offset: 0x00BF9D88
		public void RoguelikeAchieveGiveUpRequest(Action<bool> callback = null)
		{
			RogueTowerTrialGiveUpTempArchiveRequest message = RogueTowerTrialGiveUpTempArchiveRequest.Create();
			Net.Instance.Call(ERequestMessageId.RogueTowerTrialGiveUpTempArchiveRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueTowerTrialGiveUpTempArchiveResponse rogueTowerTrialGiveUpTempArchiveResponse = (RogueTowerTrialGiveUpTempArchiveResponse)msg;
				if (rogueTowerTrialGiveUpTempArchiveResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueTowerTrialGiveUpTempArchiveResponse.ErrorCode, 29294, null, true, true);
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 0);
		}

		// Token: 0x0603354F RID: 210255 RVA: 0x00BFBBC8 File Offset: 0x00BF9DC8
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public UniTask<List<RogueArchiveInfoData>> RogueArchiveListRequest(int seasonId)
		{
			RoguelikeController.<RogueArchiveListRequest>d__44 <RogueArchiveListRequest>d__;
			<RogueArchiveListRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<List<RogueArchiveInfoData>>.Create();
			<RogueArchiveListRequest>d__.seasonId = seasonId;
			<RogueArchiveListRequest>d__.<>1__state = -1;
			<RogueArchiveListRequest>d__.<>t__builder.Start<RoguelikeController.<RogueArchiveListRequest>d__44>(ref <RogueArchiveListRequest>d__);
			return <RogueArchiveListRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033550 RID: 210256 RVA: 0x00BFBC0C File Offset: 0x00BF9E0C
		public void RoguelikeBossChallengeStartRequest(int instId, int slotId, Action<bool> callback = null)
		{
			RogueTowerTrialStartRequest rogueTowerTrialStartRequest = RogueTowerTrialStartRequest.Create();
			rogueTowerTrialStartRequest.InstId = instId;
			rogueTowerTrialStartRequest.SlotId = slotId;
			Net.Instance.Call(ERequestMessageId.RogueTowerTrialStartRequest, rogueTowerTrialStartRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueTowerTrialStartResponse rogueTowerTrialStartResponse = (RogueTowerTrialStartResponse)msg;
				if (rogueTowerTrialStartResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueTowerTrialStartResponse.ErrorCode, 24439, null, true, true);
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 0);
		}

		// Token: 0x06033551 RID: 210257 RVA: 0x00BFBC58 File Offset: 0x00BF9E58
		public void RoguelikeBossChallengeSelectBossRequest(int id, Action<bool> callback = null)
		{
			RogueTowerTrialSelectBossRequest rogueTowerTrialSelectBossRequest = RogueTowerTrialSelectBossRequest.Create();
			rogueTowerTrialSelectBossRequest.Id = id;
			Net.Instance.Call(ERequestMessageId.RogueTowerTrialSelectBossRequest, rogueTowerTrialSelectBossRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueTowerTrialSelectBossResponse rogueTowerTrialSelectBossResponse = (RogueTowerTrialSelectBossResponse)msg;
				if (rogueTowerTrialSelectBossResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueTowerTrialSelectBossResponse.ErrorCode, 22338, null, true, true);
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 0);
		}

		// Token: 0x06033552 RID: 210258 RVA: 0x00BFBC9C File Offset: 0x00BF9E9C
		public void RoguelikeBossChallengeResultRequest(int instId, Action<bool> callback = null)
		{
			RogueTowerTrialResultRequest rogueTowerTrialResultRequest = RogueTowerTrialResultRequest.Create();
			rogueTowerTrialResultRequest.InstId = instId;
			Net.Instance.Call(ERequestMessageId.RogueTowerTrialResultRequest, rogueTowerTrialResultRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueTowerTrialResultResponse rogueTowerTrialResultResponse = (RogueTowerTrialResultResponse)msg;
				if (rogueTowerTrialResultResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueTowerTrialResultResponse.ErrorCode, 15310, null, true, true);
					this.OpenRoguelikeBossChallengeResultView(instId, null);
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					this.OpenRoguelikeBossChallengeResultView(instId, rogueTowerTrialResultResponse.RogueTowerTrialResultInfo);
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 0);
		}

		// Token: 0x06033553 RID: 210259 RVA: 0x00BFBCF4 File Offset: 0x00BF9EF4
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.RoguelikeSubLevelNotify, new Action<IMessage, Net.CallbackStatus>(this.RoguelikeSubLevelNotify));
			Net.Instance.Register(ENotifyMessageId.RoguelikeInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueInfoNotify));
			Net.Instance.Register(ENotifyMessageId.RoguelikeChooseDataNotify, new Action<IMessage, Net.CallbackStatus>(this.RoguelikeChooseDataNotify));
			Net.Instance.Register(ENotifyMessageId.RoguelikeRoomInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.RoguelikeRoomInfoNotify));
			Net.Instance.Register(ENotifyMessageId.RoguelikeResultNotify, new Action<IMessage, Net.CallbackStatus>(this.RoguelikeResultNotify));
			Net.Instance.Register(ENotifyMessageId.RoguelikeTalentUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.RoguelikeTalentUnlockNotify));
			Net.Instance.Register(ENotifyMessageId.RoguelikeCurrencyNotify, new Action<IMessage, Net.CallbackStatus>(this.RoguelikeCurrencyNotify));
			Net.Instance.Register(ENotifyMessageId.RoguelikeCurrencyUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.RoguelikeCurrencyUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RoguelikeEventGainNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoguelikeEventGainNotify));
			Net.Instance.Register(ENotifyMessageId.RoguelikeGainDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.RoguelikeGainDataUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.RoguelikeRoleRoomNotify, new Action<IMessage, Net.CallbackStatus>(this.RoguelikeRoleRoomNotify));
			Net.Instance.Register(ENotifyMessageId.RogueBlackFlowerNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueBlackFlowerNotify));
			Net.Instance.Register(ENotifyMessageId.RogueTowerTrialSelectBossNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueTowerTrialSelectBossNotify));
			Net.Instance.Register(ENotifyMessageId.RogueTowerTrialResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRogueTowerTrialResultNotify));
		}

		// Token: 0x06033554 RID: 210260 RVA: 0x00BFBE8C File Offset: 0x00BFA08C
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.RoguelikeSubLevelNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoguelikeInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoguelikeChooseDataNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoguelikeRoomInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoguelikeResultNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoguelikeTalentUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoguelikeCurrencyNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoguelikeCurrencyUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoguelikeEventGainNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoguelikeRoleRoomNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RoguelikeGainDataUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueTowerTrialSelectBossNotify);
			Net.Instance.UnRegister(ENotifyMessageId.RogueTowerTrialResultNotify);
		}

		// Token: 0x06033555 RID: 210261 RVA: 0x00BFBF6C File Offset: 0x00BFA16C
		private void OnRogueBlackFlowerNotify(IMessage msg, Net.CallbackStatus status)
		{
			RogueBlackFlowerNotify notify = (RogueBlackFlowerNotify)msg;
			ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
			RogueSeasonData rogueSeasonData = (currentActivityData != null) ? currentActivityData.SeasonData : null;
			if (rogueSeasonData == null)
			{
				Log.Instance.Error(ELogModule.Roguelike, ELogAuthor.LPH, "领取黒石花奖励失败，赛季数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int num = rogueSeasonData.BlackFlowerMaxCount - rogueSeasonData.BlackFlowerUseCount;
			if (num <= 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RogueBlackFlowerRewardNoCount", Array.Empty<object>());
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RogueBlackFlower);
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				this.RogueBlackFlowerRequest(notify.EntityConfigId, false);
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.RogueBlackFlowerRequest(notify.EntityConfigId, true);
			};
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("RogueBlackFlowerRewardTip", null);
			confirmBoxDataNew.Tip = StringUtils.Format(localTextNew, new string[]
			{
				num.ToString(),
				rogueSeasonData.BlackFlowerMaxCount.ToString()
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06033556 RID: 210262 RVA: 0x00BFC078 File Offset: 0x00BFA278
		private void RoguelikeRoleRoomNotify(IMessage msg, Net.CallbackStatus status)
		{
			RoguelikeRoleRoomNotify roguelikeRoleRoomNotify = (RoguelikeRoleRoomNotify)msg;
			RoguelikeCharacterSelectOpenParam param = new RoguelikeCharacterSelectOpenParam
			{
				Index = roguelikeRoleRoomNotify.Index,
				RoomIdList = roguelikeRoleRoomNotify.RoleRoomIds.ToList<int>()
			};
			UiManager.Instance.OpenView(EUiViewName.RogueCharacterRoomSelectView, param, null);
		}

		// Token: 0x06033557 RID: 210263 RVA: 0x00BFC0C0 File Offset: 0x00BFA2C0
		private void RoguelikeResultNotify(IMessage msg, Net.CallbackStatus status)
		{
			RoguelikeResultNotify roguelikeResultNotify = (RoguelikeResultNotify)msg;
			RoguelikeResultInfo resultInfo = roguelikeResultNotify.RoguelikeResultInfo;
			if (this.TryExitRoguelikeWithoutSettleView(resultInfo))
			{
				return;
			}
			this.IsFromRogueToNormal = new bool?(!RoguelikeModel.Instance.CheckIsGuideDungeon());
			if (resultInfo.IsDeadTrigger)
			{
				TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					UiManager.Instance.OpenView(EUiViewName.RoguelikeSettleView, resultInfo, null);
				}, 2000f, null, null, true, 1f);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.RoguelikeSettleView, resultInfo, null);
		}

		// Token: 0x06033558 RID: 210264 RVA: 0x00BFC155 File Offset: 0x00BFA355
		[NullableContext(1)]
		private bool TryExitRoguelikeWithoutSettleView(RoguelikeResultInfo resultInfo)
		{
			if (resultInfo.InstId != 0)
			{
				return false;
			}
			if (RoguelikeModel.Instance.CheckInRoguelike())
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon();
			}
			return true;
		}

		// Token: 0x06033559 RID: 210265 RVA: 0x00BFC17C File Offset: 0x00BFA37C
		private unsafe void RoguelikeRoomInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			RoguelikeRoomInfoNotify roguelikeRoomInfoNotify = (RoguelikeRoomInfoNotify)msg;
			RoguelikeModel.Instance.CurRoomCount = roguelikeRoomInfoNotify.CurLayer;
			RoguelikeModel.Instance.TotalRoomCount = roguelikeRoomInfoNotify.MaxLayer;
			RoguelikeModel.Instance.CurRoomId = new int?(roguelikeRoomInfoNotify.RoguelikeRoomId);
			RogueRoomPool? roguelikeRoomPoolConfig = RoguelikeConfig.Instance.GetRoguelikeRoomPoolConfig(roguelikeRoomInfoNotify.RoguelikeRoomId);
			RogueRoomType? roguelikeRoomTypeConfigById = RoguelikeConfig.Instance.GetRoguelikeRoomTypeConfigById(roguelikeRoomInfoNotify.RoguelikeRoomTypeId);
			RoguelikeModel.Instance.CurRoomTypeId = ((roguelikeRoomTypeConfigById != null) ? roguelikeRoomTypeConfigById.GetValueOrDefault().RoomType : null);
			RoguelikeModel instance = RoguelikeModel.Instance;
			int? num = (roguelikeRoomTypeConfigById != null) ? new int?(roguelikeRoomTypeConfigById.GetValueOrDefault().RoomTipsType) : null;
			instance.CurRoomType = ((num != null) ? new RoguelikeRoomType?((RoguelikeRoomType)num.GetValueOrDefault()) : null);
			if (!StringUtils.IsEmpty((roguelikeRoomPoolConfig != null) ? roguelikeRoomPoolConfig.GetValueOrDefault().RoomsMusicState : null))
			{
				RoguelikeModel.Instance.CurRoomMusicState = ((roguelikeRoomPoolConfig != null) ? roguelikeRoomPoolConfig.GetValueOrDefault().RoomsMusicState : null);
			}
			else
			{
				RoguelikeModel.Instance.CurRoomMusicState = ((roguelikeRoomTypeConfigById != null) ? roguelikeRoomTypeConfigById.GetValueOrDefault().RoomsMusicState : null);
			}
			if (roguelikeRoomInfoNotify.SkyBoxId != 0)
			{
				WeatherModel.Instance.GetWorldWeatherActor().ChangeWeather(roguelikeRoomInfoNotify.SkyBoxId, 0f);
			}
			else
			{
				WeatherController.Instance.StopWeather();
			}
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Roguelike;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[经典肉鸽] 房间信息变更";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RoomId", roguelikeRoomInfoNotify.RoguelikeRoomId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RoomTypeId", roguelikeRoomInfoNotify.RoguelikeRoomTypeId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("RoomType", (roguelikeRoomTypeConfigById != null) ? roguelikeRoomTypeConfigById.GetValueOrDefault().RoomType : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Progress", roguelikeRoomInfoNotify.CurLayer.ToString() + "/" + roguelikeRoomInfoNotify.MaxLayer.ToString());
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x0603355A RID: 210266 RVA: 0x00BFC3E0 File Offset: 0x00BFA5E0
		private unsafe void OnRogueInfoNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoguelikeInfoNotify roguelikeInfoNotify = (RoguelikeInfoNotify)msg;
			if (roguelikeInfoNotify.RoguelikeInstInfo == null)
			{
				return;
			}
			RoguelikeModel.Instance.RogueModeType = new RogueChallengeModeType?(roguelikeInfoNotify.ModeType);
			RoguelikeModel.Instance.RogueInfo = new RoguelikeInfo(roguelikeInfoNotify.RoguelikeInstInfo);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Roguelike;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[经典肉鸽] 进入玩法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Mode", roguelikeInfoNotify.ModeType);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "Role";
			RogueGainEntry roleEntry = roguelikeInfoNotify.RoguelikeInstInfo.RoleEntry;
			ptr = new ValueTuple<string, object>(item, (roleEntry != null) ? new int?(roleEntry.ConfigId) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0603355B RID: 210267 RVA: 0x00BFC4B0 File Offset: 0x00BFA6B0
		private void OnRogueTowerTrialSelectBossNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueTowerTrialSelectBossNotify rogueTowerTrialSelectBossNotify = (RogueTowerTrialSelectBossNotify)msg;
			if (UiManager.Instance.GetViewByName(EUiViewName.RoguelikeBossChallengeView) != null)
			{
				UiManager.Instance.CloseView(EUiViewName.RoguelikeBossChallengeView, null);
			}
			UiManager.Instance.OpenView(EUiViewName.RoguelikeBossChallengeView, rogueTowerTrialSelectBossNotify.BossInfos.ToList<RogueTowerTrialBossInfo>(), null);
		}

		// Token: 0x0603355C RID: 210268 RVA: 0x00BFC500 File Offset: 0x00BFA700
		private void OnRogueTowerTrialResultNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueTowerTrialResultNotify rogueTowerTrialResultNotify = (RogueTowerTrialResultNotify)msg;
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			this.OpenRoguelikeBossChallengeResultView(instanceId, rogueTowerTrialResultNotify.RogueTowerTrialResultInfo);
		}

		// Token: 0x0603355D RID: 210269 RVA: 0x00BFC52C File Offset: 0x00BFA72C
		private void RoguelikeSubLevelNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoguelikeController.<>c__DisplayClass58_0 CS$<>8__locals1 = new RoguelikeController.<>c__DisplayClass58_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.notify = (RoguelikeSubLevelNotify)msg;
			AsyncTask task = new AsyncTask("RoguelikeSubLevelChangeTask", delegate()
			{
				RoguelikeController.<>c__DisplayClass58_0.<<RoguelikeSubLevelNotify>b__0>d <<RoguelikeSubLevelNotify>b__0>d;
				<<RoguelikeSubLevelNotify>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
				<<RoguelikeSubLevelNotify>b__0>d.<>4__this = CS$<>8__locals1;
				<<RoguelikeSubLevelNotify>b__0>d.<>1__state = -1;
				<<RoguelikeSubLevelNotify>b__0>d.<>t__builder.Start<RoguelikeController.<>c__DisplayClass58_0.<<RoguelikeSubLevelNotify>b__0>d>(ref <<RoguelikeSubLevelNotify>b__0>d);
				return <<RoguelikeSubLevelNotify>b__0>d.<>t__builder.Task;
			}, null, null, null);
			TaskSystem.Instance.AddTask(task);
			TaskSystem.Instance.Run();
		}

		// Token: 0x0603355E RID: 210270 RVA: 0x00BFC584 File Offset: 0x00BFA784
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1
		})]
		private ValueTuple<string[], string[]> FilterSameSubLevel(RoguelikeSubLevelNotify notify)
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			foreach (string text in notify.UnLoadSubLevels)
			{
				bool flag = false;
				foreach (string b in notify.LoadSubLevels)
				{
					if (text == b)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list.Add(text);
				}
			}
			foreach (string text2 in notify.LoadSubLevels)
			{
				bool flag2 = false;
				foreach (string b2 in notify.UnLoadSubLevels)
				{
					if (text2 == b2)
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					list2.Add(text2);
				}
			}
			return new ValueTuple<string[], string[]>(list.ToArray(), list2.ToArray());
		}

		// Token: 0x0603355F RID: 210271 RVA: 0x00BFC6D0 File Offset: 0x00BFA8D0
		private void RogueBlackFlowerRequest(int entityId, bool isReceive)
		{
			RogueBlackFlowerRequest rogueBlackFlowerRequest = Aki.Protocol.RogueBlackFlowerRequest.Create();
			rogueBlackFlowerRequest.EntityConfigId = entityId;
			rogueBlackFlowerRequest.Ret = isReceive;
			Net.Instance.Call(ERequestMessageId.RogueBlackFlowerRequest, rogueBlackFlowerRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueBlackFlowerResponse rogueBlackFlowerResponse = (RogueBlackFlowerResponse)msg;
				if (rogueBlackFlowerResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueBlackFlowerResponse.ErrorCode, 18239, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06033560 RID: 210272 RVA: 0x00BFC724 File Offset: 0x00BFA924
		private UniTask RoguelikeGotoNextRoomRequest()
		{
			RoguelikeController.<RoguelikeGotoNextRoomRequest>d__61 <RoguelikeGotoNextRoomRequest>d__;
			<RoguelikeGotoNextRoomRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RoguelikeGotoNextRoomRequest>d__.<>1__state = -1;
			<RoguelikeGotoNextRoomRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeGotoNextRoomRequest>d__61>(ref <RoguelikeGotoNextRoomRequest>d__);
			return <RoguelikeGotoNextRoomRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033561 RID: 210273 RVA: 0x00BFC760 File Offset: 0x00BFA960
		public UniTask RoguelikeGiveUpGainRequest(int bindId)
		{
			RoguelikeController.<RoguelikeGiveUpGainRequest>d__62 <RoguelikeGiveUpGainRequest>d__;
			<RoguelikeGiveUpGainRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RoguelikeGiveUpGainRequest>d__.bindId = bindId;
			<RoguelikeGiveUpGainRequest>d__.<>1__state = -1;
			<RoguelikeGiveUpGainRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeGiveUpGainRequest>d__62>(ref <RoguelikeGiveUpGainRequest>d__);
			return <RoguelikeGiveUpGainRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033562 RID: 210274 RVA: 0x00BFC7A4 File Offset: 0x00BFA9A4
		[NullableContext(0)]
		public UniTask<bool> RoguelikeTokenReceiveRequest(int seasonId, int id)
		{
			RoguelikeController.<RoguelikeTokenReceiveRequest>d__63 <RoguelikeTokenReceiveRequest>d__;
			<RoguelikeTokenReceiveRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RoguelikeTokenReceiveRequest>d__.seasonId = seasonId;
			<RoguelikeTokenReceiveRequest>d__.id = id;
			<RoguelikeTokenReceiveRequest>d__.<>1__state = -1;
			<RoguelikeTokenReceiveRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeTokenReceiveRequest>d__63>(ref <RoguelikeTokenReceiveRequest>d__);
			return <RoguelikeTokenReceiveRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033563 RID: 210275 RVA: 0x00BFC7F0 File Offset: 0x00BFA9F0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<RoguelikePopularEntriesInfoResponse> RoguelikePopularEntriesInfoRequest(int instanceId)
		{
			RoguelikeController.<RoguelikePopularEntriesInfoRequest>d__64 <RoguelikePopularEntriesInfoRequest>d__;
			<RoguelikePopularEntriesInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<RoguelikePopularEntriesInfoResponse>.Create();
			<RoguelikePopularEntriesInfoRequest>d__.instanceId = instanceId;
			<RoguelikePopularEntriesInfoRequest>d__.<>1__state = -1;
			<RoguelikePopularEntriesInfoRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikePopularEntriesInfoRequest>d__64>(ref <RoguelikePopularEntriesInfoRequest>d__);
			return <RoguelikePopularEntriesInfoRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033564 RID: 210276 RVA: 0x00BFC834 File Offset: 0x00BFAA34
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public UniTask<RoguelikeTrialRoleInfoResponse> RoguelikeTrialRoleInfoRequest(List<int> instanceIdList)
		{
			RoguelikeController.<RoguelikeTrialRoleInfoRequest>d__65 <RoguelikeTrialRoleInfoRequest>d__;
			<RoguelikeTrialRoleInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<RoguelikeTrialRoleInfoResponse>.Create();
			<RoguelikeTrialRoleInfoRequest>d__.instanceIdList = instanceIdList;
			<RoguelikeTrialRoleInfoRequest>d__.<>1__state = -1;
			<RoguelikeTrialRoleInfoRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeTrialRoleInfoRequest>d__65>(ref <RoguelikeTrialRoleInfoRequest>d__);
			return <RoguelikeTrialRoleInfoRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033565 RID: 210277 RVA: 0x00BFC878 File Offset: 0x00BFAA78
		[NullableContext(1)]
		public UniTask RoguelikePopularEntriesChangeRequest(int instanceId, List<int> entries)
		{
			RoguelikeController.<RoguelikePopularEntriesChangeRequest>d__66 <RoguelikePopularEntriesChangeRequest>d__;
			<RoguelikePopularEntriesChangeRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RoguelikePopularEntriesChangeRequest>d__.instanceId = instanceId;
			<RoguelikePopularEntriesChangeRequest>d__.entries = entries;
			<RoguelikePopularEntriesChangeRequest>d__.<>1__state = -1;
			<RoguelikePopularEntriesChangeRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikePopularEntriesChangeRequest>d__66>(ref <RoguelikePopularEntriesChangeRequest>d__);
			return <RoguelikePopularEntriesChangeRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06033566 RID: 210278 RVA: 0x00BFC8C4 File Offset: 0x00BFAAC4
		public unsafe Action<bool?> CreateCloseViewCallBack([Nullable(1)] RoguelikeChooseDataResultResponse notify, Action<bool?> finishCallback = null)
		{
			RogueViewPackage rogueViewPackage = notify.RogueViewPackage;
			RepeatedField<RogueViewGroup> repeatedField = (rogueViewPackage != null) ? rogueViewPackage.RogueViewGroups : null;
			if (repeatedField == null || repeatedField.Count <= 0)
			{
				Action<bool?> finishCallback2 = finishCallback;
				if (finishCallback2 != null)
				{
					finishCallback2(null);
				}
				return null;
			}
			List<RogueViewUnit> rogueUnits = new List<RogueViewUnit>();
			foreach (RogueViewGroup rogueViewGroup in repeatedField)
			{
				if (rogueViewGroup.RogueViewUnit != null)
				{
					rogueUnits.Add(rogueViewGroup.RogueViewUnit);
				}
				if (rogueViewGroup.ChildRogueViewUnits.Count <= 0)
				{
					foreach (RogueViewUnit item in rogueViewGroup.ChildRogueViewUnits)
					{
						rogueUnits.Add(item);
					}
				}
			}
			if (rogueUnits.Count <= 0)
			{
				Action<bool?> finishCallback3 = finishCallback;
				if (finishCallback3 != null)
				{
					finishCallback3(null);
				}
				return null;
			}
			int index = 0;
			Action<bool?> callback = null;
			callback = delegate(bool? result)
			{
				bool? flag = result;
				bool flag2 = false;
				int index;
				if (flag.GetValueOrDefault() == flag2 & flag != null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Roguelike;
					ELogAuthor author = ELogAuthor.ZJC;
					string message = "CreateCloseViewCallBack err";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("index", index);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("notify", notify);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				List<RogueViewUnit> rogueUnits;
				if (index >= rogueUnits.Count)
				{
					Action<bool?> finishCallback4 = finishCallback;
					if (finishCallback4 == null)
					{
						return;
					}
					finishCallback4(null);
					return;
				}
				else
				{
					rogueUnits = rogueUnits;
					index = index;
					index++;
					RogueViewUnit rogueViewUnit = rogueUnits[index];
					RogueViewUnit.DataOneofCase dataCase = rogueViewUnit.DataCase;
					if (dataCase == RogueViewUnit.DataOneofCase.RoguelikeEventGainNotify)
					{
						this.RoguelikeEventGainNotify(rogueViewUnit.RoguelikeEventGainNotify, callback);
						return;
					}
					if (dataCase != RogueViewUnit.DataOneofCase.ItemObtainNotify)
					{
						return;
					}
					ItemRewardController.Instance.OnItemObtainNotify(rogueViewUnit.ItemObtainNotify, callback);
					return;
				}
			};
			return callback;
		}

		// Token: 0x17007E9C RID: 32412
		// (get) Token: 0x06033567 RID: 210279 RVA: 0x00BFCA30 File Offset: 0x00BFAC30
		[Nullable(1)]
		public static RoguelikeController Instance
		{
			[NullableContext(1)]
			get
			{
				return RoguelikeController._Instance;
			}
		}

		// Token: 0x06033568 RID: 210280 RVA: 0x00BFCA37 File Offset: 0x00BFAC37
		[NullableContext(1)]
		public static RoguelikeController GetOrCreateInstance()
		{
			if (RoguelikeController._Instance == null)
			{
				RoguelikeController.CreateInstance();
			}
			return RoguelikeController._Instance;
		}

		// Token: 0x06033569 RID: 210281 RVA: 0x00BFCA4B File Offset: 0x00BFAC4B
		public static bool CreateInstance()
		{
			if (RoguelikeController._Instance != null)
			{
				return true;
			}
			RoguelikeController._Instance = new RoguelikeController();
			return true;
		}

		// Token: 0x0603356A RID: 210282 RVA: 0x00BFCA61 File Offset: 0x00BFAC61
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603356B RID: 210283 RVA: 0x00BFCA63 File Offset: 0x00BFAC63
		public static void ResetStaticDefaultValue()
		{
			RoguelikeController._Instance = null;
		}

		// Token: 0x0603356C RID: 210284 RVA: 0x00BFCA6B File Offset: 0x00BFAC6B
		static RoguelikeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoguelikeController.CreateStaticDefaultValue), new Action(RoguelikeController.ResetStaticDefaultValue));
		}

		// Token: 0x0401B45A RID: 111706
		private bool? IsFromRogueToNormal = new bool?(false);

		// Token: 0x0401B45B RID: 111707
		[Nullable(1)]
		public string CurrentFlowListName = "";

		// Token: 0x0401B45C RID: 111708
		public int CurrentFlowId;

		// Token: 0x0401B45D RID: 111709
		public int CurrentStateId;

		// Token: 0x0401B45E RID: 111710
		public int RandomEventIndex;

		// Token: 0x0401B45F RID: 111711
		private static RoguelikeController _Instance;
	}
}
