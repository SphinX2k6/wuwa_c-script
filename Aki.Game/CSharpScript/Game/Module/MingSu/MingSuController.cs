using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020053CD RID: 21453
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class MingSuController : UiControllerBase
	{
		// Token: 0x06036D36 RID: 224566 RVA: 0x00CFC350 File Offset: 0x00CFA550
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06036D37 RID: 224567 RVA: 0x00CFC354 File Offset: 0x00CFA554
		protected override void OnAddEvents()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnAntiqueShopUpgradeSequenceFinished;
			Action handle;
			if ((handle = MingSuController.<>O.<0>__OnAntiqueShopUpgradeSequenceFinished) == null)
			{
				handle = (MingSuController.<>O.<0>__OnAntiqueShopUpgradeSequenceFinished = new Action(MingSuController.OnAntiqueShopUpgradeSequenceFinished));
			}
			instance.Add(name, handle);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.OnAntiqueShopLevelMaxSequenceFinished;
			Action handle2;
			if ((handle2 = MingSuController.<>O.<1>__OnAntiqueShopLevelMaxSequenceFinished) == null)
			{
				handle2 = (MingSuController.<>O.<1>__OnAntiqueShopLevelMaxSequenceFinished = new Action(MingSuController.OnAntiqueShopLevelMaxSequenceFinished));
			}
			instance2.Add(name2, handle2);
		}

		// Token: 0x06036D38 RID: 224568 RVA: 0x00CFC3B8 File Offset: 0x00CFA5B8
		protected override void OnRemoveEvents()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnAntiqueShopUpgradeSequenceFinished;
			Action handle;
			if ((handle = MingSuController.<>O.<0>__OnAntiqueShopUpgradeSequenceFinished) == null)
			{
				handle = (MingSuController.<>O.<0>__OnAntiqueShopUpgradeSequenceFinished = new Action(MingSuController.OnAntiqueShopUpgradeSequenceFinished));
			}
			instance.Remove(name, handle);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.OnAntiqueShopLevelMaxSequenceFinished;
			Action handle2;
			if ((handle2 = MingSuController.<>O.<1>__OnAntiqueShopLevelMaxSequenceFinished) == null)
			{
				handle2 = (MingSuController.<>O.<1>__OnAntiqueShopLevelMaxSequenceFinished = new Action(MingSuController.OnAntiqueShopLevelMaxSequenceFinished));
			}
			instance2.Remove(name2, handle2);
		}

		// Token: 0x06036D39 RID: 224569 RVA: 0x00CFC41C File Offset: 0x00CFA61C
		private static void OnAntiqueShopUpgradeSequenceFinished()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MingSuTi;
			ELogAuthor author = ELogAuthor.BB;
			string message = "[CollectionItemDisplay]当提交物品等级提升时,开始打开结算界面";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CurrentDragonPoolId", MingSuModel.Instance.GetCurrentDragonPoolId());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			switch (MingSuModel.Instance.GetCurrentDragonPoolId())
			{
			case 1:
				ItemRewardController.Instance.OpenCompositeRewardView(2006, true, null, null);
				return;
			case 2:
				ItemRewardController.Instance.OpenCompositeRewardView(2007, true, null, null);
				return;
			case 3:
				break;
			case 4:
			case 5:
				ItemRewardController.Instance.OpenCompositeRewardView(2008, true, null, null);
				return;
			case 6:
				ItemRewardController.Instance.OpenCompositeRewardView(2009, true, null, null);
				return;
			case 7:
				ItemRewardController.Instance.OpenCompositeRewardView(2010, true, null, null);
				return;
			case 8:
				ItemRewardController.Instance.OpenCompositeRewardView(2011, true, null, null);
				break;
			default:
				return;
			}
		}

		// Token: 0x06036D3A RID: 224570 RVA: 0x00CFC504 File Offset: 0x00CFA704
		private static void OnAntiqueShopLevelMaxSequenceFinished()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MingSuTi;
			ELogAuthor author = ELogAuthor.BB;
			string message = "[CollectionItemDisplay]当提交物品等级升至满级时,开始打开结算界面";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CurrentDragonPoolId", MingSuModel.Instance.GetCurrentDragonPoolId());
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			switch (MingSuModel.Instance.GetCurrentDragonPoolId())
			{
			case 1:
				ItemRewardController.Instance.OpenCompositeRewardView(2006, true, null, null);
				return;
			case 2:
				ItemRewardController.Instance.OpenCompositeRewardView(2007, true, null, null);
				return;
			case 3:
				break;
			case 4:
			case 5:
				ItemRewardController.Instance.OpenCompositeRewardView(2008, true, null, null);
				return;
			case 6:
				ItemRewardController.Instance.OpenCompositeRewardView(2009, true, null, null);
				return;
			case 7:
				ItemRewardController.Instance.OpenCompositeRewardView(2010, true, null, null);
				return;
			case 8:
				ItemRewardController.Instance.OpenCompositeRewardView(2011, true, null, null);
				break;
			default:
				return;
			}
		}

		// Token: 0x06036D3B RID: 224571 RVA: 0x00CFC5EC File Offset: 0x00CFA7EC
		public static bool OpenView(int dragonPoolId, TOpenViewCallBack finishCallback = null)
		{
			DragonPool? dragonPoolConfigById = CollectItemConfig.Instance.GetDragonPoolConfigById(dragonPoolId);
			if (dragonPoolConfigById == null)
			{
				return false;
			}
			MingSuModel mingSuModel = MingSuModel.Instance;
			mingSuModel.SetCurrentDragonPoolId(dragonPoolId);
			mingSuModel.SetCollectItemConfigId(dragonPoolConfigById.Value.CoreId);
			if (dragonPoolId == 3)
			{
				MingSuController.SendOpenDarkCoastDeliveryRequest(dragonPoolId, delegate
				{
					UiManager.Instance.OpenView(EUiViewName.DarkCoastDeliveryMainView, mingSuModel.GetDragonPoolInstanceById(dragonPoolId), finishCallback);
				});
			}
			else
			{
				MingSuController.SendOpenDragonPoolRequest(dragonPoolId, delegate
				{
					switch (dragonPoolId)
					{
					case 1:
						UiManager.Instance.OpenView(EUiViewName.MingSuView, null, finishCallback);
						return;
					case 2:
						UiManager.Instance.OpenView(EUiViewName.CollectItemView, null, finishCallback);
						return;
					case 3:
						break;
					case 4:
						UiManager.Instance.OpenView(EUiViewName.PupuVillageItemView, null, finishCallback);
						return;
					case 5:
						UiManager.Instance.OpenView(EUiViewName.PupuVillageItemViewQIQIU, null, finishCallback);
						return;
					case 6:
						UiManager.Instance.OpenView(EUiViewName.LaHaiLuoCollectView, null, finishCallback);
						return;
					case 7:
						UiManager.Instance.OpenView(EUiViewName.RiLingCollectView, null, finishCallback);
						return;
					case 8:
						UiManager.Instance.OpenView(EUiViewName.MengZhouCollectView, null, finishCallback);
						break;
					default:
						return;
					}
				});
			}
			return true;
		}

		// Token: 0x06036D3C RID: 224572 RVA: 0x00CFC69C File Offset: 0x00CFA89C
		public static void SendOpenDragonPoolRequest(int dragonPoolId, Action onResponse = null)
		{
			DragonPoolConfRequest dragonPoolConfRequest = DragonPoolConfRequest.Create();
			dragonPoolConfRequest.DragonPoolId = dragonPoolId;
			Net.Instance.Call(ERequestMessageId.DragonPoolConfRequest, dragonPoolConfRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DragonPoolConfResponse dragonPoolConfResponse = (DragonPoolConfResponse)msg;
				if (dragonPoolConfResponse == null)
				{
					return;
				}
				if (dragonPoolConfResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(dragonPoolConfResponse.ErrorCode, 24543, null, true, true);
					return;
				}
				MingSuModel.Instance.RefreshDragonPoolDropItems(dragonPoolConfResponse.DragonPoolConf);
				Action onResponse2 = onResponse;
				if (onResponse2 == null)
				{
					return;
				}
				onResponse2();
			}, 0);
		}

		// Token: 0x06036D3D RID: 224573 RVA: 0x00CFC6E0 File Offset: 0x00CFA8E0
		public static void SendOpenDarkCoastDeliveryRequest(int dragonPoolId, Action onResponse = null)
		{
			DarkCoastInfoRequest darkCoastInfoRequest = DarkCoastInfoRequest.Create();
			darkCoastInfoRequest.DragonPoolId = dragonPoolId;
			Net.Instance.Call(ERequestMessageId.DarkCoastInfoRequest, darkCoastInfoRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DarkCoastInfoResponse darkCoastInfoResponse = (DarkCoastInfoResponse)msg;
				if (darkCoastInfoResponse == null)
				{
					return;
				}
				if (darkCoastInfoResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(darkCoastInfoResponse.ErrorCode, 20782, null, true, true);
					return;
				}
				MingSuModel.Instance.RefreshDragonPoolDropItems(darkCoastInfoResponse.DragonPoolConf);
				MingSuModel.Instance.RefreshDarkCoastGuardInfo(dragonPoolId, darkCoastInfoResponse.GuardIds.ToArray<int>(), darkCoastInfoResponse.TreasureBoxDone.ToArray<int>());
				MingSuModel.Instance.RefreshDragonPoolLevelGains(dragonPoolId, darkCoastInfoResponse.LevelGains);
				Action onResponse2 = onResponse;
				if (onResponse2 == null)
				{
					return;
				}
				onResponse2();
			}, 0);
		}

		// Token: 0x06036D3E RID: 224574 RVA: 0x00CFC730 File Offset: 0x00CFA930
		[NullableContext(0)]
		public static UniTask<bool> SendDarkCoastDeliveryRequestAsync()
		{
			MingSuController.<SendDarkCoastDeliveryRequestAsync>d__8 <SendDarkCoastDeliveryRequestAsync>d__;
			<SendDarkCoastDeliveryRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SendDarkCoastDeliveryRequestAsync>d__.<>1__state = -1;
			<SendDarkCoastDeliveryRequestAsync>d__.<>t__builder.Start<MingSuController.<SendDarkCoastDeliveryRequestAsync>d__8>(ref <SendDarkCoastDeliveryRequestAsync>d__);
			return <SendDarkCoastDeliveryRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036D3F RID: 224575 RVA: 0x00CFC76C File Offset: 0x00CFA96C
		public unsafe static void SendHandInMingSuRequest(int dragonPoolId)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MingSuTi;
			ELogAuthor author = ELogAuthor.BB;
			string message = "HandInMingSuRequest";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dragonPoolId", dragonPoolId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			HandInMingSuRequest handInMingSuRequest = HandInMingSuRequest.Create();
			handInMingSuRequest.DragonPoolId = dragonPoolId;
			handInMingSuRequest.InteractEntityId = MingSuModel.Instance.CurrentInteractCreatureDataLongId.Value;
			Net.Instance.Call(ERequestMessageId.HandInMingSuRequest, handInMingSuRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HandInMingSuResponse handInMingSuResponse = (HandInMingSuResponse)msg;
				if (handInMingSuResponse == null)
				{
					return;
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.MingSuTi;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[CollectionItemDisplay]HandInMingSuResponse";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dragonPoolId", dragonPoolId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("提交数量", handInMingSuResponse.InjectedCoreItemCount);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("提交后的等级", handInMingSuResponse.Level);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("提交后已领取的等级", handInMingSuResponse.LevelGains);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				if (handInMingSuResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
				{
					MingSuInstance dragonPoolInstanceById = MingSuModel.Instance.GetDragonPoolInstanceById(handInMingSuResponse.DragonPoolId);
					if (dragonPoolInstanceById != null)
					{
						int level = handInMingSuResponse.Level;
						int dragonPoolLevel = dragonPoolInstanceById.GetDragonPoolLevel();
						int dragonPoolMaxLevel = dragonPoolInstanceById.GetDragonPoolMaxLevel();
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.MingSuTi;
						ELogAuthor author3 = ELogAuthor.BB;
						string message3 = "[CollectionItemDisplay]广播等级提升事件";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("dragonPoolId", dragonPoolId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("currentLevel", dragonPoolLevel);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("newLevel", level);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("maxLevel", dragonPoolMaxLevel);
						instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
						if (level >= dragonPoolMaxLevel)
						{
							EventSystem.Instance.Emit(EEventName.OnSubmitItemLevelMax);
						}
						else if (dragonPoolLevel < level)
						{
							EventSystem.Instance.Emit(EEventName.OnSubmitItemLevelUp);
						}
						else
						{
							EventSystem.Instance.Emit(EEventName.OnSubmitItemSuccess);
						}
					}
					MingSuModel.Instance.RefreshDragonPoolActiveStatus(handInMingSuResponse.DragonPoolId, handInMingSuResponse.LevelGains);
					MingSuModel.Instance.RefreshDragonPoolLevel(handInMingSuResponse.DragonPoolId, handInMingSuResponse.Level);
					MingSuModel.Instance.RefreshDragonPoolHadCoreCount(handInMingSuResponse.DragonPoolId, handInMingSuResponse.InjectedCoreItemCount);
					EventSystem.Instance.Emit(EEventName.UpdateDragonPoolView);
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(handInMingSuResponse.ErrorCode, 23593, null, true, true);
				ItemRewardController.Instance.Close(null);
			}, 0);
		}

		// Token: 0x06036D40 RID: 224576 RVA: 0x00CFC7FC File Offset: 0x00CFA9FC
		public static void SendMingSuHandRewardRequest(int dragonPoolId)
		{
			MingSuHandRewardRequest mingSuHandRewardRequest = MingSuHandRewardRequest.Create();
			mingSuHandRewardRequest.DragonPoolId = dragonPoolId;
			mingSuHandRewardRequest.InteractEntityId = MingSuModel.Instance.CurrentInteractCreatureDataLongId.Value;
			Net.Instance.Call(ERequestMessageId.MingSuHandRewardRequest, mingSuHandRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MingSuHandRewardResponse mingSuHandRewardResponse = (MingSuHandRewardResponse)msg;
				if (mingSuHandRewardResponse == null)
				{
					return;
				}
				if (mingSuHandRewardResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
				{
					MingSuModel.Instance.RefreshDragonPoolLevelGains(dragonPoolId, mingSuHandRewardResponse.LevelGains);
					IActivityRewardViewData activityRewardViewData = (MingSuModel.Instance.GetDragonPoolInstanceById(dragonPoolId) as DarkCoastDeliveryData).GetActivityRewardViewData();
					EventSystem.Instance.Emit<IActivityRewardViewData>(EEventName.RefreshCommonActivityRewardPopUpView, activityRewardViewData);
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(mingSuHandRewardResponse.ErrorCode, 16113, null, true, true);
			}, 0);
		}

		// Token: 0x170083C1 RID: 33729
		// (get) Token: 0x06036D41 RID: 224577 RVA: 0x00CFC85A File Offset: 0x00CFAA5A
		[Nullable(1)]
		public static MingSuController Instance
		{
			[NullableContext(1)]
			get
			{
				return MingSuController._Instance;
			}
		}

		// Token: 0x06036D42 RID: 224578 RVA: 0x00CFC861 File Offset: 0x00CFAA61
		[NullableContext(1)]
		public static MingSuController GetOrCreateInstance()
		{
			if (MingSuController._Instance == null)
			{
				MingSuController.CreateInstance();
			}
			return MingSuController._Instance;
		}

		// Token: 0x06036D43 RID: 224579 RVA: 0x00CFC875 File Offset: 0x00CFAA75
		public static bool CreateInstance()
		{
			if (MingSuController._Instance != null)
			{
				return true;
			}
			MingSuController._Instance = new MingSuController();
			return true;
		}

		// Token: 0x06036D44 RID: 224580 RVA: 0x00CFC88B File Offset: 0x00CFAA8B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036D45 RID: 224581 RVA: 0x00CFC88D File Offset: 0x00CFAA8D
		public static void ResetStaticDefaultValue()
		{
			MingSuController._Instance = null;
		}

		// Token: 0x06036D46 RID: 224582 RVA: 0x00CFC895 File Offset: 0x00CFAA95
		static MingSuController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MingSuController.CreateStaticDefaultValue), new Action(MingSuController.ResetStaticDefaultValue));
		}

		// Token: 0x0401CF0D RID: 118541
		private static MingSuController _Instance;

		// Token: 0x0200B670 RID: 46704
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04037445 RID: 226373
			[Nullable(0)]
			public static Action <0>__OnAntiqueShopUpgradeSequenceFinished;

			// Token: 0x04037446 RID: 226374
			[Nullable(0)]
			public static Action <1>__OnAntiqueShopLevelMaxSequenceFinished;
		}
	}
}
