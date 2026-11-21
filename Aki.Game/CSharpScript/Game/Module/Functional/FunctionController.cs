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
	// Token: 0x020049F4 RID: 18932
	[NullableContext(1)]
	[Nullable(0)]
	public class FunctionController : UiControllerBase
	{
		// Token: 0x0602F712 RID: 194322 RVA: 0x00D3B7C8 File Offset: 0x00D399C8
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
				AdventureGuideController.Instance.OpenGuideView(null, null, null, null);
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

		// Token: 0x0602F713 RID: 194323 RVA: 0x00D3BC7C File Offset: 0x00D39E7C
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

		// Token: 0x0602F714 RID: 194324 RVA: 0x00D3BCC1 File Offset: 0x00D39EC1
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewFinish));
		}

		// Token: 0x0602F715 RID: 194325 RVA: 0x00D3BCDC File Offset: 0x00D39EDC
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewFinish));
		}

		// Token: 0x0602F716 RID: 194326 RVA: 0x00D3BCF8 File Offset: 0x00D39EF8
		private void OnInputDistributeTagChanged(string tagName, bool tagExist)
		{
			if (tagExist)
			{
				Log.Instance.Info(ELogModule.Functional, ELogAuthor.YYZ, "功能开启界面打开时InputTag限制解除", default(ReadOnlySpan<ValueTuple<string, object>>));
				InputDistributeModel.Instance.RemoveInputDistributeTagChangedListener("UiInputRoot", new TInputTagChangedCallback(this.OnInputDistributeTagChanged));
				this.TryOpenFunctionOpenView();
			}
		}

		// Token: 0x0602F717 RID: 194327 RVA: 0x00D3BD48 File Offset: 0x00D39F48
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

		// Token: 0x0602F718 RID: 194328 RVA: 0x00D3BDB8 File Offset: 0x00D39FB8
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

		// Token: 0x0602F719 RID: 194329 RVA: 0x00D3BDFC File Offset: 0x00D39FFC
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

		// Token: 0x0602F71A RID: 194330 RVA: 0x00D3BE48 File Offset: 0x00D3A048
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

		// Token: 0x0602F71B RID: 194331 RVA: 0x00D3BE94 File Offset: 0x00D3A094
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

		// Token: 0x0602F71C RID: 194332 RVA: 0x00D3C03D File Offset: 0x00D3A23D
		private bool IsInForceCanOpenView(string viewName)
		{
			if (!this.IsInitFunctionOpenViewLimitSet)
			{
				this.InitFunctionOpenViewLimit();
				this.IsInitFunctionOpenViewLimitSet = true;
			}
			return this.FunctionOpenViewLimitSet.Contains(viewName);
		}

		// Token: 0x0602F71D RID: 194333 RVA: 0x00D3C060 File Offset: 0x00D3A260
		private void OnCloseViewFinish(EUiViewName viewName, int viewId)
		{
			this.TryOpenFunctionOpenView();
		}

		// Token: 0x0602F71E RID: 194334 RVA: 0x00D3C06C File Offset: 0x00D3A26C
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

		// Token: 0x0602F71F RID: 194335 RVA: 0x00D3C0C4 File Offset: 0x00D3A2C4
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FuncOpenNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FuncOpenUpdateNotify);
		}

		// Token: 0x0602F720 RID: 194336 RVA: 0x00D3C0E6 File Offset: 0x00D3A2E6
		private void OpenRoleView()
		{
			RoleController.Instance.OpenRoleMainViewByParam(new OpenRoleMainViewData
			{
				AgentType = ERoleAgentType.Normal,
				UseMainViewSort = true
			});
		}

		// Token: 0x0602F721 RID: 194337 RVA: 0x00D3C105 File Offset: 0x00D3A305
		private void OpenBagView()
		{
			UiManager.Instance.OpenView(EUiViewName.InventoryView, null, null);
		}

		// Token: 0x0602F722 RID: 194338 RVA: 0x00D3C118 File Offset: 0x00D3A318
		private void OpenCalabashView()
		{
			UiManager.Instance.OpenView(EUiViewName.CalabashRootView, null, null);
		}

		// Token: 0x0602F723 RID: 194339 RVA: 0x00D3C12B File Offset: 0x00D3A32B
		private void OpenQuestView()
		{
			UiManager.Instance.OpenView(EUiViewName.QuestView, null, null);
		}

		// Token: 0x0602F724 RID: 194340 RVA: 0x00D3C13E File Offset: 0x00D3A33E
		private void OpenMailView()
		{
			UiManager.Instance.OpenView(EUiViewName.MailBoxView, null, null);
		}

		// Token: 0x0602F725 RID: 194341 RVA: 0x00D3C151 File Offset: 0x00D3A351
		private void OpenMenuView()
		{
			UiManager.Instance.OpenView(EUiViewName.MenuView, null, null);
		}

		// Token: 0x0602F726 RID: 194342 RVA: 0x00D3C164 File Offset: 0x00D3A364
		private void OpenMapView()
		{
			WorldMapController.Instance.OpenView(EOpenMapType.Mouse, false, null, null);
		}

		// Token: 0x0602F727 RID: 194343 RVA: 0x00D3C174 File Offset: 0x00D3A374
		private void OpenTimeOfDayView()
		{
			UiManager.Instance.OpenView(EUiViewName.TimeOfDaySecondView, null, null);
		}

		// Token: 0x0602F728 RID: 194344 RVA: 0x00D3C187 File Offset: 0x00D3A387
		private void OpenFriendView()
		{
			this.TryOpenFriendView();
		}

		// Token: 0x0602F729 RID: 194345 RVA: 0x00D3C190 File Offset: 0x00D3A390
		private UniTask TryOpenFriendView()
		{
			FunctionController.<TryOpenFriendView>d__26 <TryOpenFriendView>d__;
			<TryOpenFriendView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryOpenFriendView>d__.<>4__this = this;
			<TryOpenFriendView>d__.<>1__state = -1;
			<TryOpenFriendView>d__.<>t__builder.Start<FunctionController.<TryOpenFriendView>d__26>(ref <TryOpenFriendView>d__);
			return <TryOpenFriendView>d__.<>t__builder.Task;
		}

		// Token: 0x0602F72A RID: 194346 RVA: 0x00D3C1D4 File Offset: 0x00D3A3D4
		private UniTask OpenThirdPartyMessageBox(ESdkPrivilege privilege)
		{
			FunctionController.<OpenThirdPartyMessageBox>d__27 <OpenThirdPartyMessageBox>d__;
			<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenThirdPartyMessageBox>d__.privilege = privilege;
			<OpenThirdPartyMessageBox>d__.<>1__state = -1;
			<OpenThirdPartyMessageBox>d__.<>t__builder.Start<FunctionController.<OpenThirdPartyMessageBox>d__27>(ref <OpenThirdPartyMessageBox>d__);
			return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
		}

		// Token: 0x0602F72B RID: 194347 RVA: 0x00D3C217 File Offset: 0x00D3A417
		private void OpenPayShopView()
		{
			PayShopController.Instance.OpenPayShopView(null, null);
		}

		// Token: 0x0602F72C RID: 194348 RVA: 0x00D3C225 File Offset: 0x00D3A425
		private void OpenGachaMainView()
		{
			GachaController.Instance.OpenGachaMainView(true);
		}

		// Token: 0x0602F72D RID: 194349 RVA: 0x00D3C234 File Offset: 0x00D3A434
		private void OpenExploreSetView()
		{
			RouletteController.Instance.OpenAssemblyView(ERouletteType.Explore, null, null, null, false);
		}

		// Token: 0x0602F72E RID: 194350 RVA: 0x00D3C269 File Offset: 0x00D3A469
		private void OpenUserFeedback()
		{
			KuroSdkController.Instance.OpenFeedback();
		}

		// Token: 0x0602F72F RID: 194351 RVA: 0x00D3C275 File Offset: 0x00D3A475
		private void OpenInfluenceReputation()
		{
		}

		// Token: 0x0602F730 RID: 194352 RVA: 0x00D3C277 File Offset: 0x00D3A477
		private void OpenRoleHandBook()
		{
			UiManager.Instance.OpenView(EUiViewName.RoleHandBookSelectionView, null, null);
		}

		// Token: 0x0602F731 RID: 194353 RVA: 0x00D3C28A File Offset: 0x00D3A48A
		private void OpenHandBookSystem()
		{
			UiManager.Instance.OpenView(EUiViewName.HandBookEntranceView, null, null);
		}

		// Token: 0x0602F732 RID: 194354 RVA: 0x00D3C29D File Offset: 0x00D3A49D
		private void OpenPhotograph()
		{
			PhotographController.Instance.TryOpenPhotograph(ECameraCaptureType.NormalCamera);
		}

		// Token: 0x0602F733 RID: 194355 RVA: 0x00D3C2AB File Offset: 0x00D3A4AB
		private void OpenActivity()
		{
			ActivityController.Instance.OpenActivityById(0, EActivityViewOpenType.Menu, null, null);
		}

		// Token: 0x0602F734 RID: 194356 RVA: 0x00D3C2BC File Offset: 0x00D3A4BC
		private void OpenCustomerService()
		{
			LogController.Instance.RequestOutputDebugInfo();
			KuroSdkController.Instance.OpenCustomerService(EKuroSdkOpenCustomerServerType.Setting);
		}

		// Token: 0x0602F735 RID: 194357 RVA: 0x00D3C2D3 File Offset: 0x00D3A4D3
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

		// Token: 0x0602F736 RID: 194358 RVA: 0x00D3C30D File Offset: 0x00D3A50D
		private void OpenMailBind()
		{
			UiManager.Instance.OpenView(EUiViewName.MailBindView, true, null);
			MailBindController.Instance.RecordMailBindClick();
		}

		// Token: 0x0602F737 RID: 194359 RVA: 0x00D3C32F File Offset: 0x00D3A52F
		private void OpenGameIntroduction()
		{
			ChannelController.Instance.OpenGameIntroduction();
			KuroSdkModel.Instance.SaveCurrentClickIntroductionVersion();
		}

		// Token: 0x0602F738 RID: 194360 RVA: 0x00D3C345 File Offset: 0x00D3A545
		private void OpenDirectTrainPro()
		{
			ActivityDirectTrainHelper.TryOpenPro(false);
		}

		// Token: 0x0602F739 RID: 194361 RVA: 0x00D3C34E File Offset: 0x00D3A54E
		private void OpenOnlineGame()
		{
			this.TryOpenOnlineGame();
		}

		// Token: 0x0602F73A RID: 194362 RVA: 0x00D3C358 File Offset: 0x00D3A558
		private UniTask TryOpenOnlineGame()
		{
			FunctionController.<TryOpenOnlineGame>d__43 <TryOpenOnlineGame>d__;
			<TryOpenOnlineGame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TryOpenOnlineGame>d__.<>4__this = this;
			<TryOpenOnlineGame>d__.<>1__state = -1;
			<TryOpenOnlineGame>d__.<>t__builder.Start<FunctionController.<TryOpenOnlineGame>d__43>(ref <TryOpenOnlineGame>d__);
			return <TryOpenOnlineGame>d__.<>t__builder.Task;
		}

		// Token: 0x0602F73B RID: 194363 RVA: 0x00D3C39B File Offset: 0x00D3A59B
		private void OpenAchievement()
		{
			AchievementController.Instance.OpenAchievementMainView();
		}

		// Token: 0x0602F73C RID: 194364 RVA: 0x00D3C3A8 File Offset: 0x00D3A5A8
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

		// Token: 0x0602F73D RID: 194365 RVA: 0x00D3C41A File Offset: 0x00D3A61A
		private void OpenCompose()
		{
			UiManager.Instance.OpenView(EUiViewName.ComposeCarryOnView, null, null);
		}

		// Token: 0x0602F73E RID: 194366 RVA: 0x00D3C42D File Offset: 0x00D3A62D
		private void OpenForging()
		{
			UiManager.Instance.OpenView(EUiViewName.ForgingRootView, null, null);
		}

		// Token: 0x0602F73F RID: 194367 RVA: 0x00D3C440 File Offset: 0x00D3A640
		private void OpenBattlePass()
		{
			BattlePassController.Instance.OpenBattlePassView();
		}

		// Token: 0x0602F740 RID: 194368 RVA: 0x00D3C44C File Offset: 0x00D3A64C
		private void OpenHonamiStoryBackpack()
		{
			HonamiStoryController.Instance.OpenHonamiStoryBag().Forget<bool>();
		}

		// Token: 0x0602F741 RID: 194369 RVA: 0x00D3C460 File Offset: 0x00D3A660
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

		// Token: 0x0602F742 RID: 194370 RVA: 0x00D3C4AC File Offset: 0x00D3A6AC
		private void OpenPermanentPhantomArea()
		{
			PhantomArenaBattleController.OpenPhantomArenaMapEntrance(null, null);
		}

		// Token: 0x0602F743 RID: 194371 RVA: 0x00D3C4D0 File Offset: 0x00D3A6D0
		private void OpenInfrastructure()
		{
			InfrastructureController.Instance.OpenInfrastructureMainView(null).Forget<int?>();
		}

		// Token: 0x0602F744 RID: 194372 RVA: 0x00D3C4E2 File Offset: 0x00D3A6E2
		private void OpenVillageInfr()
		{
			VillageInfrController.Instance.OpenVillageInfrMainView(null).Forget<int?>();
		}

		// Token: 0x0602F745 RID: 194373 RVA: 0x00D3C4F4 File Offset: 0x00D3A6F4
		private void OpenMotorcycle()
		{
			MotorcycleDevelopController.Instance.OpenRootView().Forget<bool>();
		}

		// Token: 0x0602F746 RID: 194374 RVA: 0x00D3C508 File Offset: 0x00D3A708
		private void OpenWeatherCentral()
		{
			WeatherController.Instance.TryOpenWeatherCentralMainView(null);
		}

		// Token: 0x0602F747 RID: 194375 RVA: 0x00D3C528 File Offset: 0x00D3A728
		private void OpenSheriffAnomaly()
		{
			SheriffController.Instance.OpenSheriffMap(null);
		}

		// Token: 0x0602F748 RID: 194376 RVA: 0x00D3C535 File Offset: 0x00D3A735
		private void OpenFeedbackReward()
		{
			UiManager.Instance.OpenView(EUiViewName.FeedbackRewardMainView, null, null);
		}

		// Token: 0x0602F749 RID: 194377 RVA: 0x00D3C548 File Offset: 0x00D3A748
		private void OpenMoonChasingMain()
		{
			MoonChasingMainViewModel data = new MoonChasingMainViewModel();
			MoonChasingController.Instance.OpenMainView(data).Forget<bool>();
		}

		// Token: 0x0602F74A RID: 194378 RVA: 0x00D3C56B File Offset: 0x00D3A76B
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x17005F9B RID: 24475
		// (get) Token: 0x0602F74B RID: 194379 RVA: 0x00D3C56E File Offset: 0x00D3A76E
		public static FunctionController Instance
		{
			get
			{
				return FunctionController._Instance;
			}
		}

		// Token: 0x0602F74C RID: 194380 RVA: 0x00D3C575 File Offset: 0x00D3A775
		public static FunctionController GetOrCreateInstance()
		{
			if (FunctionController._Instance == null)
			{
				FunctionController.CreateInstance();
			}
			return FunctionController._Instance;
		}

		// Token: 0x0602F74D RID: 194381 RVA: 0x00D3C589 File Offset: 0x00D3A789
		public static bool CreateInstance()
		{
			if (FunctionController._Instance != null)
			{
				return true;
			}
			FunctionController._Instance = new FunctionController();
			return true;
		}

		// Token: 0x0602F74E RID: 194382 RVA: 0x00D3C59F File Offset: 0x00D3A79F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F74F RID: 194383 RVA: 0x00D3C5A1 File Offset: 0x00D3A7A1
		public static void ResetStaticDefaultValue()
		{
			FunctionController._Instance = null;
		}

		// Token: 0x0602F750 RID: 194384 RVA: 0x00D3C5A9 File Offset: 0x00D3A7A9
		static FunctionController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FunctionController.CreateStaticDefaultValue), new Action(FunctionController.ResetStaticDefaultValue));
		}

		// Token: 0x0401923D RID: 102973
		private bool IsInitFunctionOpenViewLimitSet;

		// Token: 0x0401923E RID: 102974
		private readonly Dictionary<EFunctionType, Action> OpenFunctionViewMap = new Dictionary<EFunctionType, Action>();

		// Token: 0x0401923F RID: 102975
		private readonly HashSet<string> FunctionOpenViewLimitSet = new HashSet<string>();

		// Token: 0x04019240 RID: 102976
		[Nullable(2)]
		private static FunctionController _Instance;
	}
}
