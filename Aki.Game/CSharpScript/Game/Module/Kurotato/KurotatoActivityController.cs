using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Kurotato.View.Activity;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046A9 RID: 18089
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class KurotatoActivityController : ActivityControllerBase
	{
		// Token: 0x0602D7AC RID: 186284 RVA: 0x00CBCCF4 File Offset: 0x00CBAEF4
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0602D7AD RID: 186285 RVA: 0x00CBCCF6 File Offset: 0x00CBAEF6
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiView_ActivitySurvivorMain";
		}

		// Token: 0x0602D7AE RID: 186286 RVA: 0x00CBCCFD File Offset: 0x00CBAEFD
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewKurotato();
		}

		// Token: 0x0602D7AF RID: 186287 RVA: 0x00CBCD04 File Offset: 0x00CBAF04
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData kurotatoActivityData = new CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData();
			this.ActivityData = kurotatoActivityData;
			return kurotatoActivityData;
		}

		// Token: 0x0602D7B0 RID: 186288 RVA: 0x00CBCD20 File Offset: 0x00CBAF20
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			EUiViewName[] array = new EUiViewName[]
			{
				EUiViewName.KurotatoMainView,
				EUiViewName.KurotatoLimitedTimeRewardView
			};
			for (int i = 0; i < array.Length; i++)
			{
				if (UiManager.Instance.IsViewOpen(array[i]))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602D7B1 RID: 186289 RVA: 0x00CBCD70 File Offset: 0x00CBAF70
		[NullableContext(2)]
		public CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData GetActivityData()
		{
			if (this.ActivityData == null)
			{
				Log.Instance.Error(ELogModule.Kurotato, ELogAuthor.CXJ, "Kurotato活动数据不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return this.ActivityData;
		}

		// Token: 0x0602D7B2 RID: 186290 RVA: 0x00CBCDAC File Offset: 0x00CBAFAC
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			KurotatoActivityController.<OnOpenSubView>d__7 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.<>4__this = this;
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<KurotatoActivityController.<OnOpenSubView>d__7>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x0602D7B3 RID: 186291 RVA: 0x00CBCDF8 File Offset: 0x00CBAFF8
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.KurotatoRoleUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoRoleUnlockNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoLevelDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoLevelDataUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoWeaponUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoWeaponUnlockNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoItemUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoItemUnlockNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoResTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoNormalRewardUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoLimitTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoLimitTimeRewardUpdateNotify));
		}

		// Token: 0x0602D7B4 RID: 186292 RVA: 0x00CBCEB0 File Offset: 0x00CBB0B0
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoRoleUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoLevelDataUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoWeaponUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoItemUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoResTaskUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoLimitTaskUpdateNotify);
		}

		// Token: 0x0602D7B5 RID: 186293 RVA: 0x00CBCF20 File Offset: 0x00CBB120
		[NullableContext(2)]
		private void OnKurotatoRoleUnlockNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoRoleUnlockNotify kurotatoRoleUnlockNotify = (KurotatoRoleUnlockNotify)msg;
			CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData activityData = this.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			activityData.UpdateRoleData(kurotatoRoleUnlockNotify.KurotatoRoleInfos, true);
		}

		// Token: 0x0602D7B6 RID: 186294 RVA: 0x00CBCF4C File Offset: 0x00CBB14C
		[NullableContext(2)]
		private void OnKurotatoLevelDataUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoLevelDataUpdateNotify kurotatoLevelDataUpdateNotify = (KurotatoLevelDataUpdateNotify)msg;
			CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData activityData = this.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			activityData.UpdateLevelData(kurotatoLevelDataUpdateNotify.KurotatoLevelInfos, true);
		}

		// Token: 0x0602D7B7 RID: 186295 RVA: 0x00CBCF78 File Offset: 0x00CBB178
		[NullableContext(2)]
		private void OnKurotatoWeaponUnlockNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoWeaponUnlockNotify kurotatoWeaponUnlockNotify = (KurotatoWeaponUnlockNotify)msg;
			CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData activityData = this.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			activityData.UpdateKurotatoWeaponDataList(kurotatoWeaponUnlockNotify.UnlockWeapons, true);
		}

		// Token: 0x0602D7B8 RID: 186296 RVA: 0x00CBCFA4 File Offset: 0x00CBB1A4
		[NullableContext(2)]
		private void OnKurotatoItemUnlockNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoItemUnlockNotify kurotatoItemUnlockNotify = (KurotatoItemUnlockNotify)msg;
			CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData activityData = this.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			activityData.UpdateKurotatoItemDataList(kurotatoItemUnlockNotify.UnlockItems, true);
		}

		// Token: 0x0602D7B9 RID: 186297 RVA: 0x00CBCFD0 File Offset: 0x00CBB1D0
		[NullableContext(2)]
		private void OnKurotatoNormalRewardUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoResTaskUpdateNotify kurotatoResTaskUpdateNotify = (KurotatoResTaskUpdateNotify)msg;
			CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData activityData = this.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			activityData.UpdateNormalRewardData(kurotatoResTaskUpdateNotify.ResTasks);
		}

		// Token: 0x0602D7BA RID: 186298 RVA: 0x00CBCFFC File Offset: 0x00CBB1FC
		[NullableContext(2)]
		private void OnKurotatoLimitTimeRewardUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			KurotatoLimitTaskUpdateNotify kurotatoLimitTaskUpdateNotify = (KurotatoLimitTaskUpdateNotify)msg;
			CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData activityData = this.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			activityData.UpdateLimitTimeRewardData(kurotatoLimitTaskUpdateNotify.LimitTasks);
		}

		// Token: 0x0602D7BB RID: 186299 RVA: 0x00CBD028 File Offset: 0x00CBB228
		public void RequestNormalReward(List<int> taskIds)
		{
			KurotatoResTaskReceiveRequest kurotatoResTaskReceiveRequest = KurotatoResTaskReceiveRequest.Create();
			kurotatoResTaskReceiveRequest.TaskIds.AddRange(taskIds);
			Net.Instance.Call(ERequestMessageId.KurotatoResTaskReceiveRequest, kurotatoResTaskReceiveRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				KurotatoResTaskReceiveResponse kurotatoResTaskReceiveResponse = (KurotatoResTaskReceiveResponse)msg;
				if (kurotatoResTaskReceiveResponse == null)
				{
					return;
				}
				if (kurotatoResTaskReceiveResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(kurotatoResTaskReceiveResponse.ErrorCode, EResponseMessageId.KurotatoResTaskReceiveResponse, null, true, true);
					return;
				}
				CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData activityData = this.GetActivityData();
				if (activityData == null)
				{
					return;
				}
				activityData.SetNormalRewardReceived(taskIds);
			}, 0);
		}

		// Token: 0x0602D7BC RID: 186300 RVA: 0x00CBD080 File Offset: 0x00CBB280
		public void RequestLimitTimeReward(List<int> taskIds, [Nullable(2)] Action finishCallback)
		{
			KurotatoLimitTaskReceiveRequest kurotatoLimitTaskReceiveRequest = KurotatoLimitTaskReceiveRequest.Create();
			kurotatoLimitTaskReceiveRequest.TaskIds.AddRange(taskIds);
			Net.Instance.Call(ERequestMessageId.KurotatoLimitTaskReceiveRequest, kurotatoLimitTaskReceiveRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				KurotatoLimitTaskReceiveResponse kurotatoLimitTaskReceiveResponse = (KurotatoLimitTaskReceiveResponse)msg;
				if (kurotatoLimitTaskReceiveResponse == null)
				{
					return;
				}
				if (kurotatoLimitTaskReceiveResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(kurotatoLimitTaskReceiveResponse.ErrorCode, EResponseMessageId.KurotatoLimitTaskReceiveResponse, null, true, true);
				}
				CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData activityData = this.GetActivityData();
				if (activityData == null)
				{
					return;
				}
				activityData.SetLimitTimeRewardReceived(taskIds);
				Action finishCallback2 = finishCallback;
				if (finishCallback2 == null)
				{
					return;
				}
				finishCallback2();
			}, 0);
		}

		// Token: 0x0602D7BD RID: 186301 RVA: 0x00CBD0DC File Offset: 0x00CBB2DC
		[NullableContext(2)]
		public void RequestScoreRewardReceive(Action finishCallback)
		{
			KurotatoScoreTaskReceiveRequest kurotatoScoreTaskReceiveRequest = KurotatoScoreTaskReceiveRequest.Create();
			CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData activityData = this.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			List<int> canClaimedScoreIdList = activityData.GetCanClaimedScoreRewardList();
			kurotatoScoreTaskReceiveRequest.TaskIds.AddRange(canClaimedScoreIdList);
			Net.Instance.Call(ERequestMessageId.KurotatoScoreTaskReceiveRequest, kurotatoScoreTaskReceiveRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				KurotatoScoreTaskReceiveResponse kurotatoScoreTaskReceiveResponse = (KurotatoScoreTaskReceiveResponse)msg;
				if (kurotatoScoreTaskReceiveResponse == null)
				{
					return;
				}
				if (kurotatoScoreTaskReceiveResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(kurotatoScoreTaskReceiveResponse.ErrorCode, EResponseMessageId.KurotatoScoreTaskReceiveResponse, null, true, true);
					return;
				}
				activityData.SetScoreRewardReceived(canClaimedScoreIdList);
				Action finishCallback2 = finishCallback;
				if (finishCallback2 == null)
				{
					return;
				}
				finishCallback2();
			}, 0);
		}

		// Token: 0x0602D7BE RID: 186302 RVA: 0x00CBD150 File Offset: 0x00CBB350
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoActivityOpenView, null, null);
		}

		// Token: 0x17005B73 RID: 23411
		// (get) Token: 0x0602D7BF RID: 186303 RVA: 0x00CBD163 File Offset: 0x00CBB363
		public static KurotatoActivityController Instance
		{
			get
			{
				return KurotatoActivityController._Instance;
			}
		}

		// Token: 0x0602D7C0 RID: 186304 RVA: 0x00CBD16A File Offset: 0x00CBB36A
		public static KurotatoActivityController GetOrCreateInstance()
		{
			if (KurotatoActivityController._Instance == null)
			{
				KurotatoActivityController.CreateInstance();
			}
			return KurotatoActivityController._Instance;
		}

		// Token: 0x0602D7C1 RID: 186305 RVA: 0x00CBD17E File Offset: 0x00CBB37E
		public static bool CreateInstance()
		{
			if (KurotatoActivityController._Instance != null)
			{
				return true;
			}
			KurotatoActivityController._Instance = new KurotatoActivityController();
			return true;
		}

		// Token: 0x0602D7C2 RID: 186306 RVA: 0x00CBD194 File Offset: 0x00CBB394
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D7C3 RID: 186307 RVA: 0x00CBD196 File Offset: 0x00CBB396
		public static void ResetStaticDefaultValue()
		{
			KurotatoActivityController._Instance = null;
		}

		// Token: 0x0602D7C4 RID: 186308 RVA: 0x00CBD19E File Offset: 0x00CBB39E
		static KurotatoActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(KurotatoActivityController.CreateStaticDefaultValue), new Action(KurotatoActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x040185B6 RID: 99766
		[Nullable(2)]
		private CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData ActivityData;

		// Token: 0x040185B7 RID: 99767
		[Nullable(2)]
		private static KurotatoActivityController _Instance;
	}
}
