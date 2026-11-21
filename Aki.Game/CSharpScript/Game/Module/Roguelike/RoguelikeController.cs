using System;
using System.Collections.Generic;
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
	// Token: 0x02003D70 RID: 15728
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class RoguelikeController : UiControllerBase
	{
		// Token: 0x06028395 RID: 164757 RVA: 0x00B43F2F File Offset: 0x00B4212F
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoading));
		}

		// Token: 0x06028396 RID: 164758 RVA: 0x00B43F4D File Offset: 0x00B4214D
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnCloseLoadingView, new Action(this.OnCloseLoading));
		}

		// Token: 0x06028397 RID: 164759 RVA: 0x00B43F6C File Offset: 0x00B4216C
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
											int num = Array.IndexOf<int>(paramConfigBySeasonId.Value.DungeonList(), RoguelikeModel.Instance.CurDungeonId.Value);
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

		// Token: 0x06028398 RID: 164760 RVA: 0x00B44078 File Offset: 0x00B42278
		[NullableContext(0)]
		public UniTask<bool> OpenRoguelikeActivityView()
		{
			RoguelikeController.<OpenRoguelikeActivityView>d__8 <OpenRoguelikeActivityView>d__;
			<OpenRoguelikeActivityView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenRoguelikeActivityView>d__.<>1__state = -1;
			<OpenRoguelikeActivityView>d__.<>t__builder.Start<RoguelikeController.<OpenRoguelikeActivityView>d__8>(ref <OpenRoguelikeActivityView>d__);
			return <OpenRoguelikeActivityView>d__.<>t__builder.Task;
		}

		// Token: 0x06028399 RID: 164761 RVA: 0x00B440B4 File Offset: 0x00B422B4
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

		// Token: 0x0602839A RID: 164762 RVA: 0x00B441E4 File Offset: 0x00B423E4
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

		// Token: 0x0602839B RID: 164763 RVA: 0x00B442E4 File Offset: 0x00B424E4
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

		// Token: 0x0602839C RID: 164764 RVA: 0x00B4435C File Offset: 0x00B4255C
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

		// Token: 0x0602839D RID: 164765 RVA: 0x00B443AE File Offset: 0x00B425AE
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

		// Token: 0x0602839E RID: 164766 RVA: 0x00B443D4 File Offset: 0x00B425D4
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

		// Token: 0x0602839F RID: 164767 RVA: 0x00B44420 File Offset: 0x00B42620
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

		// Token: 0x060283A0 RID: 164768 RVA: 0x00B4446C File Offset: 0x00B4266C
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

		// Token: 0x060283A1 RID: 164769 RVA: 0x00B44564 File Offset: 0x00B42764
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

		// Token: 0x060283A2 RID: 164770 RVA: 0x00B445FC File Offset: 0x00B427FC
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

		// Token: 0x060283A3 RID: 164771 RVA: 0x00B446D4 File Offset: 0x00B428D4
		private void OnRoguelikeEventGainNotify(IMessage msg, Net.CallbackStatus _)
		{
			RoguelikeEventGainNotify notify = (RoguelikeEventGainNotify)msg;
			this.RoguelikeEventGainNotify(notify, null);
		}

		// Token: 0x060283A4 RID: 164772 RVA: 0x00B446F0 File Offset: 0x00B428F0
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

		// Token: 0x060283A5 RID: 164773 RVA: 0x00B447FC File Offset: 0x00B429FC
		public void RoguelikeGainDataUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			RoguelikeGainDataUpdateNotify notify = (RoguelikeGainDataUpdateNotify)msg;
			if (RoguelikeModel.Instance.RogueInfo == null)
			{
				return;
			}
			RoguelikeModel.Instance.RogueInfo.Update(notify);
		}

		// Token: 0x060283A6 RID: 164774 RVA: 0x00B44830 File Offset: 0x00B42A30
		public void RoguelikeChooseDataNotify(IMessage msg, Net.CallbackStatus status)
		{
			RoguelikeChooseDataNotify roguelikeChooseDataNotify = (RoguelikeChooseDataNotify)msg;
			RoguelikeModel.Instance.SetRoguelikeChooseData(roguelikeChooseDataNotify.RoguelikeChooseDataList);
			EventSystem.Instance.Emit(EEventName.RoguelikeChooseDataNotify);
		}

		// Token: 0x060283A7 RID: 164775 RVA: 0x00B44864 File Offset: 0x00B42A64
		public void RoguelikeTalentUnlockNotify(IMessage msg, Net.CallbackStatus status)
		{
			RoguelikeTalentUnlockNotify roguelikeTalentUnlockNotify = (RoguelikeTalentUnlockNotify)msg;
			RoguelikeModel.Instance.SetRoguelikeSkillData(roguelikeTalentUnlockNotify.SkillId, 0);
		}

		// Token: 0x060283A8 RID: 164776 RVA: 0x00B4488C File Offset: 0x00B42A8C
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
					string[] array = new string[roguelikeRefreshGainResponse.ErrorParams.Count];
					roguelikeRefreshGainResponse.ErrorParams.CopyTo(array, 0);
					ErrorCodeController.Instance.OpenErrorCodeScrollingTipsView(roguelikeRefreshGainResponse.ErrorCode, array);
					return;
				}
				RoguelikeModel.Instance.SetRoguelikeChooseData(new <>z__ReadOnlySingleElementList<RoguelikeChooseData>(roguelikeRefreshGainResponse.RoguelikeChooseData));
				EventSystem.Instance.Emit<int>(EEventName.RoguelikeRefreshGain, roguelikeRefreshGainResponse.RoguelikeChooseData.Index);
			}, 0);
		}

		// Token: 0x060283A9 RID: 164777 RVA: 0x00B448E8 File Offset: 0x00B42AE8
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

		// Token: 0x060283AA RID: 164778 RVA: 0x00B44924 File Offset: 0x00B42B24
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

		// Token: 0x060283AB RID: 164779 RVA: 0x00B44998 File Offset: 0x00B42B98
		public void OpenRoguelikeInstanceView()
		{
			RoguelikeDungeonViewModel param = new RoguelikeDungeonViewModel();
			UiManager.Instance.OpenView(EUiViewName.InstanceDungeonEntranceView, param, null);
		}

		// Token: 0x060283AC RID: 164780 RVA: 0x00B449BC File Offset: 0x00B42BBC
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

		// Token: 0x060283AD RID: 164781 RVA: 0x00B44A68 File Offset: 0x00B42C68
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

		// Token: 0x060283AE RID: 164782 RVA: 0x00B44AAB File Offset: 0x00B42CAB
		public void OpenRoguelikeSelectRoleView(int instanceId)
		{
			UiManager.Instance.OpenView(EUiViewName.RoguelikeEntranceView, instanceId, null);
		}

		// Token: 0x060283AF RID: 164783 RVA: 0x00B44AC4 File Offset: 0x00B42CC4
		public void OpenRoguelikeSkillView(int seasonId)
		{
			this.RoguelikeTalentInfoRequest(seasonId).ContinueWith(delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.RoguelikeSkillView, seasonId, null);
			});
		}

		// Token: 0x060283B0 RID: 164784 RVA: 0x00B44AFC File Offset: 0x00B42CFC
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

		// Token: 0x060283B1 RID: 164785 RVA: 0x00B44CE0 File Offset: 0x00B42EE0
		public UniTask RoguelikeTalentInfoRequest(int seasonId)
		{
			RoguelikeController.<RoguelikeTalentInfoRequest>d__33 <RoguelikeTalentInfoRequest>d__;
			<RoguelikeTalentInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RoguelikeTalentInfoRequest>d__.seasonId = seasonId;
			<RoguelikeTalentInfoRequest>d__.<>1__state = -1;
			<RoguelikeTalentInfoRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeTalentInfoRequest>d__33>(ref <RoguelikeTalentInfoRequest>d__);
			return <RoguelikeTalentInfoRequest>d__.<>t__builder.Task;
		}

		// Token: 0x060283B2 RID: 164786 RVA: 0x00B44D24 File Offset: 0x00B42F24
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

		// Token: 0x060283B3 RID: 164787 RVA: 0x00B44D70 File Offset: 0x00B42F70
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

		// Token: 0x060283B4 RID: 164788 RVA: 0x00B44DBC File Offset: 0x00B42FBC
		public UniTask RoguelikeTalentLevelUpRequest(int skillId)
		{
			RoguelikeController.<RoguelikeTalentLevelUpRequest>d__36 <RoguelikeTalentLevelUpRequest>d__;
			<RoguelikeTalentLevelUpRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RoguelikeTalentLevelUpRequest>d__.skillId = skillId;
			<RoguelikeTalentLevelUpRequest>d__.<>1__state = -1;
			<RoguelikeTalentLevelUpRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeTalentLevelUpRequest>d__36>(ref <RoguelikeTalentLevelUpRequest>d__);
			return <RoguelikeTalentLevelUpRequest>d__.<>t__builder.Task;
		}

		// Token: 0x060283B5 RID: 164789 RVA: 0x00B44E00 File Offset: 0x00B43000
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

		// Token: 0x060283B6 RID: 164790 RVA: 0x00B44E5C File Offset: 0x00B4305C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeQuitResponse.ErrorCode, 18512, null, true, true);
				}
				this.IsFromRogueToNormal = new bool?(!isGuideDungeon);
				InstanceDungeonModel.Instance.ClearInstanceDungeonInfo();
			}, 0);
		}

		// Token: 0x060283B7 RID: 164791 RVA: 0x00B44EB8 File Offset: 0x00B430B8
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
						ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeResultResponse.ErrorCode, 15568, null, true, true);
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

		// Token: 0x060283B8 RID: 164792 RVA: 0x00B44F24 File Offset: 0x00B43124
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

		// Token: 0x060283B9 RID: 164793 RVA: 0x00B44F68 File Offset: 0x00B43168
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeChooseDataResultResponse.ErrorCode, 18731, roguelikeChooseDataResultResponse.ErrorParams, false, true);
					return;
				}
				if (roguelikeChooseDataResultResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(roguelikeChooseDataResultResponse.ErrorCode, 18731, roguelikeChooseDataResultResponse.ErrorParams, true, true);
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

		// Token: 0x060283BA RID: 164794 RVA: 0x00B45140 File Offset: 0x00B43340
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

		// Token: 0x060283BB RID: 164795 RVA: 0x00B45184 File Offset: 0x00B43384
		public void RoguelikeAchieveGiveUpRequest(Action<bool> callback = null)
		{
			RogueTowerTrialGiveUpTempArchiveRequest message = RogueTowerTrialGiveUpTempArchiveRequest.Create();
			Net.Instance.Call(ERequestMessageId.RogueTowerTrialGiveUpTempArchiveRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueTowerTrialGiveUpTempArchiveResponse rogueTowerTrialGiveUpTempArchiveResponse = (RogueTowerTrialGiveUpTempArchiveResponse)msg;
				if (rogueTowerTrialGiveUpTempArchiveResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueTowerTrialGiveUpTempArchiveResponse.ErrorCode, 25299, null, true, true);
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

		// Token: 0x060283BC RID: 164796 RVA: 0x00B451C4 File Offset: 0x00B433C4
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

		// Token: 0x060283BD RID: 164797 RVA: 0x00B45208 File Offset: 0x00B43408
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueTowerTrialStartResponse.ErrorCode, 23092, null, true, true);
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

		// Token: 0x060283BE RID: 164798 RVA: 0x00B45254 File Offset: 0x00B43454
		public void RoguelikeBossChallengeSelectBossRequest(int id, Action<bool> callback = null)
		{
			RogueTowerTrialSelectBossRequest rogueTowerTrialSelectBossRequest = RogueTowerTrialSelectBossRequest.Create();
			rogueTowerTrialSelectBossRequest.Id = id;
			Net.Instance.Call(ERequestMessageId.RogueTowerTrialSelectBossRequest, rogueTowerTrialSelectBossRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueTowerTrialSelectBossResponse rogueTowerTrialSelectBossResponse = (RogueTowerTrialSelectBossResponse)msg;
				if (rogueTowerTrialSelectBossResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueTowerTrialSelectBossResponse.ErrorCode, 28302, null, true, true);
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

		// Token: 0x060283BF RID: 164799 RVA: 0x00B45298 File Offset: 0x00B43498
		public void RoguelikeBossChallengeResultRequest(int instId, Action<bool> callback = null)
		{
			RogueTowerTrialResultRequest rogueTowerTrialResultRequest = RogueTowerTrialResultRequest.Create();
			rogueTowerTrialResultRequest.InstId = instId;
			Net.Instance.Call(ERequestMessageId.RogueTowerTrialResultRequest, rogueTowerTrialResultRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				RogueTowerTrialResultResponse rogueTowerTrialResultResponse = (RogueTowerTrialResultResponse)msg;
				if (rogueTowerTrialResultResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueTowerTrialResultResponse.ErrorCode, 19217, null, true, true);
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

		// Token: 0x060283C0 RID: 164800 RVA: 0x00B452F0 File Offset: 0x00B434F0
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

		// Token: 0x060283C1 RID: 164801 RVA: 0x00B45488 File Offset: 0x00B43688
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

		// Token: 0x060283C2 RID: 164802 RVA: 0x00B45568 File Offset: 0x00B43768
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

		// Token: 0x060283C3 RID: 164803 RVA: 0x00B45674 File Offset: 0x00B43874
		private void RoguelikeRoleRoomNotify(IMessage msg, Net.CallbackStatus status)
		{
			RoguelikeRoleRoomNotify roguelikeRoleRoomNotify = (RoguelikeRoleRoomNotify)msg;
			RoguelikeCharacterSelectOpenParam param = new RoguelikeCharacterSelectOpenParam
			{
				Index = roguelikeRoleRoomNotify.Index,
				RoomIdList = new List<int>(roguelikeRoleRoomNotify.RoleRoomIds)
			};
			UiManager.Instance.OpenView(EUiViewName.RogueCharacterRoomSelectView, param, null);
		}

		// Token: 0x060283C4 RID: 164804 RVA: 0x00B456BC File Offset: 0x00B438BC
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

		// Token: 0x060283C5 RID: 164805 RVA: 0x00B45751 File Offset: 0x00B43951
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

		// Token: 0x060283C6 RID: 164806 RVA: 0x00B45778 File Offset: 0x00B43978
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

		// Token: 0x060283C7 RID: 164807 RVA: 0x00B459DC File Offset: 0x00B43BDC
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

		// Token: 0x060283C8 RID: 164808 RVA: 0x00B45AAC File Offset: 0x00B43CAC
		private void OnRogueTowerTrialSelectBossNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueTowerTrialSelectBossNotify rogueTowerTrialSelectBossNotify = (RogueTowerTrialSelectBossNotify)msg;
			if (UiManager.Instance.GetViewByName(EUiViewName.RoguelikeBossChallengeView) != null)
			{
				UiManager.Instance.CloseView(EUiViewName.RoguelikeBossChallengeView, null);
			}
			UiManager.Instance.OpenView(EUiViewName.RoguelikeBossChallengeView, new List<RogueTowerTrialBossInfo>(rogueTowerTrialSelectBossNotify.BossInfos), null);
		}

		// Token: 0x060283C9 RID: 164809 RVA: 0x00B45AFC File Offset: 0x00B43CFC
		private void OnRogueTowerTrialResultNotify(IMessage msg, Net.CallbackStatus _)
		{
			RogueTowerTrialResultNotify rogueTowerTrialResultNotify = (RogueTowerTrialResultNotify)msg;
			int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
			this.OpenRoguelikeBossChallengeResultView(instanceId, rogueTowerTrialResultNotify.RogueTowerTrialResultInfo);
		}

		// Token: 0x060283CA RID: 164810 RVA: 0x00B45B28 File Offset: 0x00B43D28
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

		// Token: 0x060283CB RID: 164811 RVA: 0x00B45B80 File Offset: 0x00B43D80
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
			HashSet<string> loadSet = new HashSet<string>(notify.LoadSubLevels, StringComparer.Ordinal);
			HashSet<string> unloadSet = new HashSet<string>(notify.UnLoadSubLevels, StringComparer.Ordinal);
			return new ValueTuple<string[], string[]>(NoLinq.WhereToArray<string>(notify.UnLoadSubLevels, (string item) => !loadSet.Contains(item)), NoLinq.WhereToArray<string>(notify.LoadSubLevels, (string item) => !unloadSet.Contains(item)));
		}

		// Token: 0x060283CC RID: 164812 RVA: 0x00B45BF4 File Offset: 0x00B43DF4
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(rogueBlackFlowerResponse.ErrorCode, 19376, null, true, true);
				}
			}, 0);
		}

		// Token: 0x060283CD RID: 164813 RVA: 0x00B45C48 File Offset: 0x00B43E48
		private UniTask RoguelikeGotoNextRoomRequest()
		{
			RoguelikeController.<RoguelikeGotoNextRoomRequest>d__61 <RoguelikeGotoNextRoomRequest>d__;
			<RoguelikeGotoNextRoomRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RoguelikeGotoNextRoomRequest>d__.<>1__state = -1;
			<RoguelikeGotoNextRoomRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeGotoNextRoomRequest>d__61>(ref <RoguelikeGotoNextRoomRequest>d__);
			return <RoguelikeGotoNextRoomRequest>d__.<>t__builder.Task;
		}

		// Token: 0x060283CE RID: 164814 RVA: 0x00B45C84 File Offset: 0x00B43E84
		public UniTask RoguelikeGiveUpGainRequest(int bindId)
		{
			RoguelikeController.<RoguelikeGiveUpGainRequest>d__62 <RoguelikeGiveUpGainRequest>d__;
			<RoguelikeGiveUpGainRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RoguelikeGiveUpGainRequest>d__.bindId = bindId;
			<RoguelikeGiveUpGainRequest>d__.<>1__state = -1;
			<RoguelikeGiveUpGainRequest>d__.<>t__builder.Start<RoguelikeController.<RoguelikeGiveUpGainRequest>d__62>(ref <RoguelikeGiveUpGainRequest>d__);
			return <RoguelikeGiveUpGainRequest>d__.<>t__builder.Task;
		}

		// Token: 0x060283CF RID: 164815 RVA: 0x00B45CC8 File Offset: 0x00B43EC8
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

		// Token: 0x060283D0 RID: 164816 RVA: 0x00B45D14 File Offset: 0x00B43F14
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

		// Token: 0x060283D1 RID: 164817 RVA: 0x00B45D58 File Offset: 0x00B43F58
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

		// Token: 0x060283D2 RID: 164818 RVA: 0x00B45D9C File Offset: 0x00B43F9C
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

		// Token: 0x060283D3 RID: 164819 RVA: 0x00B45DE8 File Offset: 0x00B43FE8
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

		// Token: 0x1700524C RID: 21068
		// (get) Token: 0x060283D4 RID: 164820 RVA: 0x00B45F54 File Offset: 0x00B44154
		[Nullable(1)]
		public static RoguelikeController Instance
		{
			[NullableContext(1)]
			get
			{
				return RoguelikeController._Instance;
			}
		}

		// Token: 0x060283D5 RID: 164821 RVA: 0x00B45F5B File Offset: 0x00B4415B
		[NullableContext(1)]
		public static RoguelikeController GetOrCreateInstance()
		{
			if (RoguelikeController._Instance == null)
			{
				RoguelikeController.CreateInstance();
			}
			return RoguelikeController._Instance;
		}

		// Token: 0x060283D6 RID: 164822 RVA: 0x00B45F6F File Offset: 0x00B4416F
		public static bool CreateInstance()
		{
			if (RoguelikeController._Instance != null)
			{
				return true;
			}
			RoguelikeController._Instance = new RoguelikeController();
			return true;
		}

		// Token: 0x060283D7 RID: 164823 RVA: 0x00B45F85 File Offset: 0x00B44185
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060283D8 RID: 164824 RVA: 0x00B45F87 File Offset: 0x00B44187
		public static void ResetStaticDefaultValue()
		{
			RoguelikeController._Instance = null;
		}

		// Token: 0x060283D9 RID: 164825 RVA: 0x00B45F8F File Offset: 0x00B4418F
		static RoguelikeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoguelikeController.CreateStaticDefaultValue), new Action(RoguelikeController.ResetStaticDefaultValue));
		}

		// Token: 0x04015E2D RID: 89645
		private bool? IsFromRogueToNormal = new bool?(false);

		// Token: 0x04015E2E RID: 89646
		[Nullable(1)]
		public string CurrentFlowListName = "";

		// Token: 0x04015E2F RID: 89647
		public int CurrentFlowId;

		// Token: 0x04015E30 RID: 89648
		public int CurrentStateId;

		// Token: 0x04015E31 RID: 89649
		public int RandomEventIndex;

		// Token: 0x04015E32 RID: 89650
		private static RoguelikeController _Instance;
	}
}
