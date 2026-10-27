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
	// Token: 0x020056D2 RID: 22226
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class KurotatoActivityController : ActivityControllerBase
	{
		// Token: 0x0603889C RID: 231580 RVA: 0x00D6E730 File Offset: 0x00D6C930
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603889D RID: 231581 RVA: 0x00D6E732 File Offset: 0x00D6C932
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiView_ActivitySurvivorMain";
		}

		// Token: 0x0603889E RID: 231582 RVA: 0x00D6E739 File Offset: 0x00D6C939
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewKurotato();
		}

		// Token: 0x0603889F RID: 231583 RVA: 0x00D6E740 File Offset: 0x00D6C940
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData kurotatoActivityData = new CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData();
			this.ActivityData = kurotatoActivityData;
			return kurotatoActivityData;
		}

		// Token: 0x060388A0 RID: 231584 RVA: 0x00D6E75C File Offset: 0x00D6C95C
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

		// Token: 0x060388A1 RID: 231585 RVA: 0x00D6E7AC File Offset: 0x00D6C9AC
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

		// Token: 0x060388A2 RID: 231586 RVA: 0x00D6E7E8 File Offset: 0x00D6C9E8
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

		// Token: 0x060388A3 RID: 231587 RVA: 0x00D6E834 File Offset: 0x00D6CA34
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.KurotatoRoleUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoRoleUnlockNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoLevelDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoLevelDataUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoWeaponUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoWeaponUnlockNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoItemUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoItemUnlockNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoResTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoNormalRewardUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.KurotatoLimitTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnKurotatoLimitTimeRewardUpdateNotify));
		}

		// Token: 0x060388A4 RID: 231588 RVA: 0x00D6E8EC File Offset: 0x00D6CAEC
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoRoleUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoLevelDataUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoWeaponUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoItemUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoResTaskUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.KurotatoLimitTaskUpdateNotify);
		}

		// Token: 0x060388A5 RID: 231589 RVA: 0x00D6E95C File Offset: 0x00D6CB5C
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

		// Token: 0x060388A6 RID: 231590 RVA: 0x00D6E988 File Offset: 0x00D6CB88
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

		// Token: 0x060388A7 RID: 231591 RVA: 0x00D6E9B4 File Offset: 0x00D6CBB4
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

		// Token: 0x060388A8 RID: 231592 RVA: 0x00D6E9E0 File Offset: 0x00D6CBE0
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

		// Token: 0x060388A9 RID: 231593 RVA: 0x00D6EA0C File Offset: 0x00D6CC0C
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

		// Token: 0x060388AA RID: 231594 RVA: 0x00D6EA38 File Offset: 0x00D6CC38
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

		// Token: 0x060388AB RID: 231595 RVA: 0x00D6EA64 File Offset: 0x00D6CC64
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

		// Token: 0x060388AC RID: 231596 RVA: 0x00D6EABC File Offset: 0x00D6CCBC
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

		// Token: 0x060388AD RID: 231597 RVA: 0x00D6EB18 File Offset: 0x00D6CD18
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

		// Token: 0x060388AE RID: 231598 RVA: 0x00D6EB8C File Offset: 0x00D6CD8C
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			UiManager.Instance.OpenView(EUiViewName.KurotatoActivityOpenView, null, null);
		}

		// Token: 0x170087AB RID: 34731
		// (get) Token: 0x060388AF RID: 231599 RVA: 0x00D6EB9F File Offset: 0x00D6CD9F
		public static KurotatoActivityController Instance
		{
			get
			{
				return KurotatoActivityController._Instance;
			}
		}

		// Token: 0x060388B0 RID: 231600 RVA: 0x00D6EBA6 File Offset: 0x00D6CDA6
		public static KurotatoActivityController GetOrCreateInstance()
		{
			if (KurotatoActivityController._Instance == null)
			{
				KurotatoActivityController.CreateInstance();
			}
			return KurotatoActivityController._Instance;
		}

		// Token: 0x060388B1 RID: 231601 RVA: 0x00D6EBBA File Offset: 0x00D6CDBA
		public static bool CreateInstance()
		{
			if (KurotatoActivityController._Instance != null)
			{
				return true;
			}
			KurotatoActivityController._Instance = new KurotatoActivityController();
			return true;
		}

		// Token: 0x060388B2 RID: 231602 RVA: 0x00D6EBD0 File Offset: 0x00D6CDD0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060388B3 RID: 231603 RVA: 0x00D6EBD2 File Offset: 0x00D6CDD2
		public static void ResetStaticDefaultValue()
		{
			KurotatoActivityController._Instance = null;
		}

		// Token: 0x060388B4 RID: 231604 RVA: 0x00D6EBDA File Offset: 0x00D6CDDA
		static KurotatoActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(KurotatoActivityController.CreateStaticDefaultValue), new Action(KurotatoActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x0401DB20 RID: 121632
		[Nullable(2)]
		private CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData ActivityData;

		// Token: 0x0401DB21 RID: 121633
		[Nullable(2)]
		private static KurotatoActivityController _Instance;
	}
}
