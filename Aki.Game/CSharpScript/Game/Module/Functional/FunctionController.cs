using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Infrastructure;
using CSharpScript.Game.Module.MailBind;
using CSharpScript.Game.Module.PhantomArena;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Module.Sheriff;
using CSharpScript.Game.Module.VillageInfr;
using CSharpScript.Game.Module.Weather;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x02005A18 RID: 23064
	[NullableContext(1)]
	[Nullable(0)]
	public class FunctionController : UiControllerBase
	{
		// Token: 0x0603A7C9 RID: 239561 RVA: 0x00DEB230 File Offset: 0x00DE9430
		protected override bool OnInit()
		{
			this.OpenFunctionViewMap[EFunctionType.Role] = new Action(this.OpenRoleView);
			this.OpenFunctionViewMap[EFunctionType.Bag] = new Action(this.OpenBagView);
			this.OpenFunctionViewMap[EFunctionType.Calabash] = new Action(this.OpenCalabashView);
			this.OpenFunctionViewMap[EFunctionType.Quest] = new Action(this.OpenQuestView);
			this.OpenFunctionViewMap[EFunctionType.Mail] = new Action(this.OpenMailView);
			this.OpenFunctionViewMap[EFunctionType.TimeOfDay] = new Action(this.OpenTimeOfDayView);
			this.OpenFunctionViewMap[EFunctionType.Map] = new Action(this.OpenMapView);
			this.OpenFunctionViewMap[EFunctionType.Menu] = new Action(this.OpenMenuView);
			this.OpenFunctionViewMap[EFunctionType.FormatTeam] = delegate()
			{
				FormationController.Instance.OpenFormationView(null, null);
			};
			this.OpenFunctionViewMap[EFunctionType.Friend] = new Action(this.OpenFriendView);
			this.OpenFunctionViewMap[EFunctionType.Shop] = new Action(this.OpenPayShopView);
			this.OpenFunctionViewMap[EFunctionType.Gacha] = new Action(this.OpenGachaMainView);
			this.OpenFunctionViewMap[EFunctionType.Tutorial] = new Action(TutorialController.Instance.OpenTutorialView);
			this.OpenFunctionViewMap[EFunctionType.AdventureGuide] = delegate()
			{
				AdventureGuideController.Instance.OpenGuideView(null, null, null);
			};
			this.OpenFunctionViewMap[EFunctionType.ExploreTool] = new Action(this.OpenExploreSetView);
			this.OpenFunctionViewMap[EFunctionType.InfluenceReputation] = new Action(this.OpenInfluenceReputation);
			this.OpenFunctionViewMap[EFunctionType.UserFeedback] = new Action(this.OpenUserFeedback);
			this.OpenFunctionViewMap[EFunctionType.Forging] = new Action(this.OpenForging);
			this.OpenFunctionViewMap[EFunctionType.Compose] = new Action(this.OpenCompose);
			this.OpenFunctionViewMap[EFunctionType.BattlePass] = new Action(this.OpenBattlePass);
			this.OpenFunctionViewMap[EFunctionType.RoleHandBook] = new Action(this.OpenRoleHandBook);
			this.OpenFunctionViewMap[EFunctionType.HandBookSystem] = new Action(this.OpenHandBookSystem);
			this.OpenFunctionViewMap[EFunctionType.Photograph] = new Action(this.OpenPhotograph);
			this.OpenFunctionViewMap[EFunctionType.Achievement] = new Action(this.OpenAchievement);
			this.OpenFunctionViewMap[EFunctionType.Activity] = new Action(this.OpenActivity);
			this.OpenFunctionViewMap[EFunctionType.UserFeedback] = new Action(this.OpenCustomerService);
			this.OpenFunctionViewMap[EFunctionType.KuroStreet] = new Action(this.OpenKuroStreet);
			this.OpenFunctionViewMap[EFunctionType.Online] = new Action(this.OpenOnlineGame);
			this.OpenFunctionViewMap[EFunctionType.MailBind] = new Action(this.OpenMailBind);
			this.OpenFunctionViewMap[EFunctionType.GameIntroduction] = new Action(this.OpenGameIntroduction);
			this.OpenFunctionViewMap[EFunctionType.DirectTrainPro] = new Action(this.OpenDirectTrainPro);
			this.OpenFunctionViewMap[EFunctionType.HonamiStoryBackpack] = new Action(this.OpenHonamiStoryBackpack);
			this.OpenFunctionViewMap[EFunctionType.PhoneMsg] = new Action(this.OpenPhoneMsg);
			this.OpenFunctionViewMap[EFunctionType.PermanentPhantomArea] = new Action(this.OpenPermanentPhantomArea);
			this.OpenFunctionViewMap[EFunctionType.MotorDevelop] = new Action(this.OpenMotorcycle);
			this.OpenFunctionViewMap[EFunctionType.Infrastructure] = new Action(this.OpenInfrastructure);
			this.OpenFunctionViewMap[EFunctionType.VillageInfr] = new Action(this.OpenVillageInfr);
			this.OpenFunctionViewMap[EFunctionType.WeatherCentral] = new Action(this.OpenWeatherCentral);
			this.OpenFunctionViewMap[EFunctionType.SheriffAnomaly] = new Action(this.OpenSheriffAnomaly);
			this.OpenFunctionViewMap[EFunctionType.FeedbackReward] = new Action(this.OpenFeedbackReward);
			this.OpenFunctionViewMap[EFunctionType.MoonChasingMain] = new Action(this.OpenMoonChasingMain);
			return true;
		}

		// Token: 0x0603A7CA RID: 239562 RVA: 0x00DEB6E4 File Offset: 0x00DE98E4
		protected void InitFunctionOpenViewLimit()
		{
			IReadOnlyList<FunctionOpenViewLimit> configList = ConfigFunctionOpenViewLimitAll.GetConfigList(true);
			if (configList != null)
			{
				int count = configList.Count;
				for (int i = 0; i < count; i++)
				{
					FunctionOpenViewLimit functionOpenViewLimit = configList[i];
					this.FunctionOpenViewLimitSet.Add(functionOpenViewLimit.ViewName);
				}
			}
		}

		// Token: 0x0603A7CB RID: 239563 RVA: 0x00DEB729 File Offset: 0x00DE9929
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewFinish));
		}

		// Token: 0x0603A7CC RID: 239564 RVA: 0x00DEB744 File Offset: 0x00DE9944
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewFinish));
		}

		// Token: 0x0603A7CD RID: 239565 RVA: 0x00DEB760 File Offset: 0x00DE9960
		private void OnInputDistributeTagChanged(string tagName, bool tagExist)
		{
			if (tagExist)
			{
				Log.Instance.Info(ELogModule.Functional, ELogAuthor.YYZ, "功能开启界面打开时InputTag限制解除", default(ReadOnlySpan<ValueTuple<string, object>>));
				InputDistributeModel.Instance.RemoveInputDistributeTagChangedListener("UiInputRoot", new TInputTagChangedCallback(this.OnInputDistributeTagChanged));
				this.TryOpenFunctionOpenView();
			}
		}

		// Token: 0x0603A7CE RID: 239566 RVA: 0x00DEB7B0 File Offset: 0x00DE99B0
		private void OnCharacterTagChanged(int tagId, bool tagExist)
		{
			if (!tagExist)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Functional;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "功能开启界面打开时Tag限制解除";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TagId", tagId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
				if (curRoleData != null)
				{
					BaseTagComponent gameplayTagComponent = curRoleData.GameplayTagComponent;
					if (gameplayTagComponent != null)
					{
						gameplayTagComponent.RemoveTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnCharacterTagChanged));
					}
				}
				this.TryOpenFunctionOpenView();
			}
		}

		// Token: 0x0603A7CF RID: 239567 RVA: 0x00DEB820 File Offset: 0x00DE9A20
		[NullableContext(0)]
		public UniTask<bool> TryOpenFunctionOpenView()
		{
			FunctionController.<TryOpenFunctionOpenView>d__9 <TryOpenFunctionOpenView>d__;
			<TryOpenFunctionOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryOpenFunctionOpenView>d__.<>4__this = this;
			<TryOpenFunctionOpenView>d__.<>1__state = -1;
			<TryOpenFunctionOpenView>d__.<>t__builder.Start<FunctionController.<TryOpenFunctionOpenView>d__9>(ref <TryOpenFunctionOpenView>d__);
			return <TryOpenFunctionOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A7D0 RID: 239568 RVA: 0x00DEB864 File Offset: 0x00DE9A64
		[NullableContext(0)]
		public UniTask<bool> ManualOpenFunctionOpenView([Nullable(1)] params int[] functionIdList)
		{
			FunctionController.<ManualOpenFunctionOpenView>d__10 <ManualOpenFunctionOpenView>d__;
			<ManualOpenFunctionOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ManualOpenFunctionOpenView>d__.<>4__this = this;
			<ManualOpenFunctionOpenView>d__.functionIdList = functionIdList;
			<ManualOpenFunctionOpenView>d__.<>1__state = -1;
			<ManualOpenFunctionOpenView>d__.<>t__builder.Start<FunctionController.<ManualOpenFunctionOpenView>d__10>(ref <ManualOpenFunctionOpenView>d__);
			return <ManualOpenFunctionOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A7D1 RID: 239569 RVA: 0x00DEB8B0 File Offset: 0x00DE9AB0
		[NullableContext(0)]
		private UniTask<bool> RequestFunctionShow([Nullable(1)] int[] functionIdList)
		{
			FunctionController.<RequestFunctionShow>d__11 <RequestFunctionShow>d__;
			<RequestFunctionShow>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestFunctionShow>d__.<>4__this = this;
			<RequestFunctionShow>d__.functionIdList = functionIdList;
			<RequestFunctionShow>d__.<>1__state = -1;
			<RequestFunctionShow>d__.<>t__builder.Start<FunctionController.<RequestFunctionShow>d__11>(ref <RequestFunctionShow>d__);
			return <RequestFunctionShow>d__.<>t__builder.Task;
		}

		// Token: 0x0603A7D2 RID: 239570 RVA: 0x00DEB8FC File Offset: 0x00DE9AFC
		private bool CheckFunctionOpenViewLimit()
		{
			if (!FunctionModel.Instance.IsExistNewOpenFunction())
			{
				return false;
			}
			bool flag = false;
			UiViewBase uiViewBase = UiModel.Instance.NormalStack.Peek();
			if (uiViewBase == null)
			{
				return false;
			}
			if (uiViewBase.ViewInfo.Name == UiModel.Instance.MainViewName)
			{
				flag = true;
			}
			if (!flag && this.IsInForceCanOpenView(uiViewBase.ViewInfo.Name.ToString()))
			{
				flag = true;
			}
			if (!flag)
			{
				return false;
			}
			if (!InputDistributeModel.Instance.IsAllowUiInput())
			{
				Log.Instance.Info(ELogModule.Functional, ELogAuthor.YYZ, "功能开启界面打开时UI输入存在限制,不打开", default(ReadOnlySpan<ValueTuple<string, object>>));
				InputDistributeModel.Instance.AddInputDistributeTagChangedListener("UiInputRoot", new TInputTagChangedCallback(this.OnInputDistributeTagChanged));
				return false;
			}
			bool result = true;
			int[] array = new int[]
			{
				GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大招"],
				GameplayTagDefine.EGameplayTagId["角色.Common.处决.处决中"]
			};
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			foreach (int num in array)
			{
				bool flag2;
				if (curRoleData == null)
				{
					flag2 = true;
				}
				else
				{
					BaseTagComponent gameplayTagComponent = curRoleData.GameplayTagComponent;
					flag2 = !((gameplayTagComponent != null) ? new bool?(gameplayTagComponent.HasTag(num)) : null).GetValueOrDefault();
				}
				if (!flag2)
				{
					if (curRoleData != null)
					{
						BaseTagComponent gameplayTagComponent2 = curRoleData.GameplayTagComponent;
						if (gameplayTagComponent2 != null)
						{
							gameplayTagComponent2.AddTagAddOrRemoveListener(num, new BaseTagComponent.TTagSwitchedCallback(this.OnCharacterTagChanged), null);
						}
					}
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Functional;
					ELogAuthor author = ELogAuthor.YYZ;
					string message = "功能开启界面打开时存在Tag限制";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TagId", num);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0603A7D3 RID: 239571 RVA: 0x00DEBAA5 File Offset: 0x00DE9CA5
		private bool IsInForceCanOpenView(string viewName)
		{
			if (!this.IsInitFunctionOpenViewLimitSet)
			{
				this.InitFunctionOpenViewLimit();
				this.IsInitFunctionOpenViewLimitSet = true;
			}
			return this.FunctionOpenViewLimitSet.Contains(viewName);
		}

		// Token: 0x0603A7D4 RID: 239572 RVA: 0x00DEBAC8 File Offset: 0x00DE9CC8
		private void OnCloseViewFinish(EUiViewName viewName, int viewId)
		{
			this.TryOpenFunctionOpenView();
		}

		// Token: 0x0603A7D5 RID: 239573 RVA: 0x00DEBAD4 File Offset: 0x00DE9CD4
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.FuncOpenNotify, delegate(IMessage msg, Net.CallbackStatus status)
			{
				FuncOpenNotify functionOpenInfo = (FuncOpenNotify)msg;
				FunctionModel.Instance.SetFunctionOpenInfo(functionOpenInfo);
			});
			Net.Instance.Register(ENotifyMessageId.FuncOpenUpdateNotify, delegate(IMessage msg, Net.CallbackStatus status)
			{
				FuncOpenUpdateNotify functionOpenUpdateNotify = (FuncOpenUpdateNotify)msg;
				FunctionModel.Instance.UpdateFunctionOpenInfo(functionOpenUpdateNotify);
				this.TryOpenFunctionOpenView();
			});
		}

		// Token: 0x0603A7D6 RID: 239574 RVA: 0x00DEBB2C File Offset: 0x00DE9D2C
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FuncOpenNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FuncOpenUpdateNotify);
		}

		// Token: 0x0603A7D7 RID: 239575 RVA: 0x00DEBB50 File Offset: 0x00DE9D50
		private void OpenRoleView()
		{
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, 0, null, null, null);
		}

		// Token: 0x0603A7D8 RID: 239576 RVA: 0x00DEBB74 File Offset: 0x00DE9D74
		private void OpenBagView()
		{
			UiManager.Instance.OpenView(EUiViewName.InventoryView, null, null);
		}

		// Token: 0x0603A7D9 RID: 239577 RVA: 0x00DEBB87 File Offset: 0x00DE9D87
		private void OpenCalabashView()
		{
			UiManager.Instance.OpenView(EUiViewName.CalabashRootView, null, null);
		}

		// Token: 0x0603A7DA RID: 239578 RVA: 0x00DEBB9A File Offset: 0x00DE9D9A
		private void OpenQuestView()
		{
			UiManager.Instance.OpenView(EUiViewName.QuestView, null, null);
		}

		// Token: 0x0603A7DB RID: 239579 RVA: 0x00DEBBAD File Offset: 0x00DE9DAD
		private void OpenMailView()
		{
			UiManager.Instance.OpenView(EUiViewName.MailBoxView, null, null);
		}

		// Token: 0x0603A7DC RID: 239580 RVA: 0x00DEBBC0 File Offset: 0x00DE9DC0
		private void OpenMenuView()
		{
			UiManager.Instance.OpenView(EUiViewName.MenuView, null, null);
		}

		// Token: 0x0603A7DD RID: 239581 RVA: 0x00DEBBD3 File Offset: 0x00DE9DD3
		private void OpenMapView()
		{
			WorldMapController.Instance.OpenView(EOpenMapType.Mouse, false, null, null);
		}

		// Token: 0x0603A7DE RID: 239582 RVA: 0x00DEBBE3 File Offset: 0x00DE9DE3
		private void OpenTimeOfDayView()
		{
			UiManager.Instance.OpenView(EUiViewName.TimeOfDaySecondView, null, null);
		}

		// Token: 0x0603A7DF RID: 239583 RVA: 0x00DEBBF6 File Offset: 0x00DE9DF6
		private void OpenFriendView()
		{
			this.TryOpenFriendView();
		}

		// Token: 0x0603A7E0 RID: 239584 RVA: 0x00DEBC00 File Offset: 0x00DE9E00
		private UniTask TryOpenFriendView()
		{
			FunctionController.<TryOpenFriendView>d__26 <TryOpenFriendView>d__;
			<TryOpenFriendView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryOpenFriendView>d__.<>4__this = this;
			<TryOpenFriendView>d__.<>1__state = -1;
			<TryOpenFriendView>d__.<>t__builder.Start<FunctionController.<TryOpenFriendView>d__26>(ref <TryOpenFriendView>d__);
			return <TryOpenFriendView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A7E1 RID: 239585 RVA: 0x00DEBC44 File Offset: 0x00DE9E44
		private UniTask OpenThirdPartyMessageBox(ESdkPrivilege privilege)
		{
			FunctionController.<OpenThirdPartyMessageBox>d__27 <OpenThirdPartyMessageBox>d__;
			<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenThirdPartyMessageBox>d__.privilege = privilege;
			<OpenThirdPartyMessageBox>d__.<>1__state = -1;
			<OpenThirdPartyMessageBox>d__.<>t__builder.Start<FunctionController.<OpenThirdPartyMessageBox>d__27>(ref <OpenThirdPartyMessageBox>d__);
			return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
		}

		// Token: 0x0603A7E2 RID: 239586 RVA: 0x00DEBC87 File Offset: 0x00DE9E87
		private void OpenPayShopView()
		{
			PayShopController.Instance.OpenPayShopView(null, null);
		}

		// Token: 0x0603A7E3 RID: 239587 RVA: 0x00DEBC95 File Offset: 0x00DE9E95
		private void OpenGachaMainView()
		{
			GachaController.Instance.OpenGachaMainView(true);
		}

		// Token: 0x0603A7E4 RID: 239588 RVA: 0x00DEBCA4 File Offset: 0x00DE9EA4
		private void OpenExploreSetView()
		{
			RouletteController.Instance.OpenAssemblyView(ERouletteType.Explore, null, null, null, false);
		}

		// Token: 0x0603A7E5 RID: 239589 RVA: 0x00DEBCD9 File Offset: 0x00DE9ED9
		private void OpenUserFeedback()
		{
			KuroSdkController.Instance.OpenFeedback();
		}

		// Token: 0x0603A7E6 RID: 239590 RVA: 0x00DEBCE5 File Offset: 0x00DE9EE5
		private void OpenInfluenceReputation()
		{
		}

		// Token: 0x0603A7E7 RID: 239591 RVA: 0x00DEBCE7 File Offset: 0x00DE9EE7
		private void OpenRoleHandBook()
		{
			UiManager.Instance.OpenView(EUiViewName.RoleHandBookSelectionView, null, null);
		}

		// Token: 0x0603A7E8 RID: 239592 RVA: 0x00DEBCFA File Offset: 0x00DE9EFA
		private void OpenHandBookSystem()
		{
			UiManager.Instance.OpenView(EUiViewName.HandBookEntranceView, null, null);
		}

		// Token: 0x0603A7E9 RID: 239593 RVA: 0x00DEBD0D File Offset: 0x00DE9F0D
		private void OpenPhotograph()
		{
			PhotographController.Instance.TryOpenPhotograph(ECameraCaptureType.NormalCamera);
		}

		// Token: 0x0603A7EA RID: 239594 RVA: 0x00DEBD1B File Offset: 0x00DE9F1B
		private void OpenActivity()
		{
			ActivityController.Instance.OpenActivityById(0, EActivityViewOpenType.Menu, null, null);
		}

		// Token: 0x0603A7EB RID: 239595 RVA: 0x00DEBD2C File Offset: 0x00DE9F2C
		private void OpenCustomerService()
		{
			LogController.Instance.RequestOutputDebugInfo();
			KuroSdkController.Instance.OpenCustomerService(EKuroSdkOpenCustomerServerType.Setting);
		}

		// Token: 0x0603A7EC RID: 239596 RVA: 0x00DEBD43 File Offset: 0x00DE9F43
		private void OpenKuroStreet()
		{
			if (MailBindModel.Instance.GetIsReward())
			{
				ChannelController.Instance.OpenKuroStreet();
			}
			else
			{
				UiManager.Instance.OpenView(EUiViewName.MailBindView, false, null);
			}
			MailBindController.Instance.RecordMailBindClick();
		}

		// Token: 0x0603A7ED RID: 239597 RVA: 0x00DEBD7D File Offset: 0x00DE9F7D
		private void OpenMailBind()
		{
			UiManager.Instance.OpenView(EUiViewName.MailBindView, true, null);
			MailBindController.Instance.RecordMailBindClick();
		}

		// Token: 0x0603A7EE RID: 239598 RVA: 0x00DEBD9F File Offset: 0x00DE9F9F
		private void OpenGameIntroduction()
		{
			ChannelController.Instance.OpenGameIntroduction();
			KuroSdkModel.Instance.SaveCurrentClickIntroductionVersion();
		}

		// Token: 0x0603A7EF RID: 239599 RVA: 0x00DEBDB5 File Offset: 0x00DE9FB5
		private void OpenDirectTrainPro()
		{
			ActivityDirectTrainHelper.TryOpenPro(false);
		}

		// Token: 0x0603A7F0 RID: 239600 RVA: 0x00DEBDBE File Offset: 0x00DE9FBE
		private void OpenOnlineGame()
		{
			this.TryOpenOnlineGame();
		}

		// Token: 0x0603A7F1 RID: 239601 RVA: 0x00DEBDC8 File Offset: 0x00DE9FC8
		private UniTask TryOpenOnlineGame()
		{
			FunctionController.<TryOpenOnlineGame>d__43 <TryOpenOnlineGame>d__;
			<TryOpenOnlineGame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryOpenOnlineGame>d__.<>4__this = this;
			<TryOpenOnlineGame>d__.<>1__state = -1;
			<TryOpenOnlineGame>d__.<>t__builder.Start<FunctionController.<TryOpenOnlineGame>d__43>(ref <TryOpenOnlineGame>d__);
			return <TryOpenOnlineGame>d__.<>t__builder.Task;
		}

		// Token: 0x0603A7F2 RID: 239602 RVA: 0x00DEBE0B File Offset: 0x00DEA00B
		private void OpenAchievement()
		{
			AchievementController.Instance.OpenAchievementMainView();
		}

		// Token: 0x0603A7F3 RID: 239603 RVA: 0x00DEBE18 File Offset: 0x00DEA018
		public void OpenFunctionRelateView(EFunctionType functionType)
		{
			if (!FunctionModel.Instance.IsOpen((int)functionType))
			{
				GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
				return;
			}
			Action action;
			if (this.OpenFunctionViewMap.TryGetValue(functionType, out action))
			{
				action();
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Functional;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "原因：查找不到对应按钮打开界面的实现方式 解决：在FunctionController.OpenFunctionViewMap注册打开界面方法";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("功能ID", functionType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603A7F4 RID: 239604 RVA: 0x00DEBE8A File Offset: 0x00DEA08A
		private void OpenCompose()
		{
			UiManager.Instance.OpenView(EUiViewName.ComposeCarryOnView, null, null);
		}

		// Token: 0x0603A7F5 RID: 239605 RVA: 0x00DEBE9D File Offset: 0x00DEA09D
		private void OpenForging()
		{
			UiManager.Instance.OpenView(EUiViewName.ForgingRootView, null, null);
		}

		// Token: 0x0603A7F6 RID: 239606 RVA: 0x00DEBEB0 File Offset: 0x00DEA0B0
		private void OpenBattlePass()
		{
			BattlePassController.Instance.OpenBattlePassView();
		}

		// Token: 0x0603A7F7 RID: 239607 RVA: 0x00DEBEBC File Offset: 0x00DEA0BC
		private void OpenHonamiStoryBackpack()
		{
			HonamiStoryController.Instance.OpenHonamiStoryBag().Forget<bool>();
		}

		// Token: 0x0603A7F8 RID: 239608 RVA: 0x00DEBED0 File Offset: 0x00DEA0D0
		private void OpenPhoneMsg()
		{
			PhoneMsgPanelViewData param = new PhoneMsgPanelViewData
			{
				ShortMessage = null,
				NeedShowTips = false,
				NeedForceReadAllMsg = false,
				OpenWay = EPhoneMsgOpenWay.TerminalEsc,
				ViewType = EPhoneMsgViewType.Big
			};
			UiManager.Instance.OpenView(EUiViewName.PhoneMsgPanelViewBig, param, null);
		}

		// Token: 0x0603A7F9 RID: 239609 RVA: 0x00DEBF1C File Offset: 0x00DEA11C
		private void OpenPermanentPhantomArea()
		{
			PhantomArenaBattleController.OpenPhantomArenaMapEntrance(null, null);
		}

		// Token: 0x0603A7FA RID: 239610 RVA: 0x00DEBF40 File Offset: 0x00DEA140
		private void OpenInfrastructure()
		{
			InfrastructureController.Instance.OpenInfrastructureMainView(null).Forget<int?>();
		}

		// Token: 0x0603A7FB RID: 239611 RVA: 0x00DEBF52 File Offset: 0x00DEA152
		private void OpenVillageInfr()
		{
			VillageInfrController.Instance.OpenVillageInfrMainView(null).Forget<int?>();
		}

		// Token: 0x0603A7FC RID: 239612 RVA: 0x00DEBF64 File Offset: 0x00DEA164
		private void OpenMotorcycle()
		{
			MotorcycleDevelopController.Instance.OpenRootView().Forget<bool>();
		}

		// Token: 0x0603A7FD RID: 239613 RVA: 0x00DEBF78 File Offset: 0x00DEA178
		private void OpenWeatherCentral()
		{
			WeatherController.Instance.TryOpenWeatherCentralMainView(null);
		}

		// Token: 0x0603A7FE RID: 239614 RVA: 0x00DEBF98 File Offset: 0x00DEA198
		private void OpenSheriffAnomaly()
		{
			SheriffController.Instance.OpenSheriffMap(null);
		}

		// Token: 0x0603A7FF RID: 239615 RVA: 0x00DEBFA5 File Offset: 0x00DEA1A5
		private void OpenFeedbackReward()
		{
			UiManager.Instance.OpenView(EUiViewName.FeedbackRewardMainView, null, null);
		}

		// Token: 0x0603A800 RID: 239616 RVA: 0x00DEBFB8 File Offset: 0x00DEA1B8
		private void OpenMoonChasingMain()
		{
			MoonChasingMainViewModel data = new MoonChasingMainViewModel();
			MoonChasingController.Instance.OpenMainView(data).Forget<bool>();
		}

		// Token: 0x0603A801 RID: 239617 RVA: 0x00DEBFDB File Offset: 0x00DEA1DB
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x17008BCD RID: 35789
		// (get) Token: 0x0603A802 RID: 239618 RVA: 0x00DEBFDE File Offset: 0x00DEA1DE
		public static FunctionController Instance
		{
			get
			{
				return FunctionController._Instance;
			}
		}

		// Token: 0x0603A803 RID: 239619 RVA: 0x00DEBFE5 File Offset: 0x00DEA1E5
		public static FunctionController GetOrCreateInstance()
		{
			if (FunctionController._Instance == null)
			{
				FunctionController.CreateInstance();
			}
			return FunctionController._Instance;
		}

		// Token: 0x0603A804 RID: 239620 RVA: 0x00DEBFF9 File Offset: 0x00DEA1F9
		public static bool CreateInstance()
		{
			if (FunctionController._Instance != null)
			{
				return true;
			}
			FunctionController._Instance = new FunctionController();
			return true;
		}

		// Token: 0x0603A805 RID: 239621 RVA: 0x00DEC00F File Offset: 0x00DEA20F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A806 RID: 239622 RVA: 0x00DEC011 File Offset: 0x00DEA211
		public static void ResetStaticDefaultValue()
		{
			FunctionController._Instance = null;
		}

		// Token: 0x0603A807 RID: 239623 RVA: 0x00DEC019 File Offset: 0x00DEA219
		static FunctionController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FunctionController.CreateStaticDefaultValue), new Action(FunctionController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E796 RID: 124822
		private bool IsInitFunctionOpenViewLimitSet;

		// Token: 0x0401E797 RID: 124823
		private readonly Dictionary<EFunctionType, Action> OpenFunctionViewMap = new Dictionary<EFunctionType, Action>();

		// Token: 0x0401E798 RID: 124824
		private readonly HashSet<string> FunctionOpenViewLimitSet = new HashSet<string>();

		// Token: 0x0401E799 RID: 124825
		[Nullable(2)]
		private static FunctionController _Instance;
	}
}
