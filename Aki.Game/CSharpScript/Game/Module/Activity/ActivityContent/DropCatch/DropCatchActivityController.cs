using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x0200667C RID: 26236
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchActivityController : ActivityControllerBase
	{
		// Token: 0x06041BDF RID: 269279 RVA: 0x00FF277A File Offset: 0x00FF097A
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.DropCatchLevelRewardUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnDropCatchLevelRewardResponse));
		}

		// Token: 0x06041BE0 RID: 269280 RVA: 0x00FF2798 File Offset: 0x00FF0998
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.DropCatchLevelRewardUpdateNotify);
		}

		// Token: 0x06041BE1 RID: 269281 RVA: 0x00FF27AA File Offset: 0x00FF09AA
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06041BE2 RID: 269282 RVA: 0x00FF27AC File Offset: 0x00FF09AC
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityMainGoldCatch";
		}

		// Token: 0x06041BE3 RID: 269283 RVA: 0x00FF27B3 File Offset: 0x00FF09B3
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new DropCatchSubView();
		}

		// Token: 0x06041BE4 RID: 269284 RVA: 0x00FF27BA File Offset: 0x00FF09BA
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new DropCatchActivityData();
		}

		// Token: 0x06041BE5 RID: 269285 RVA: 0x00FF27CD File Offset: 0x00FF09CD
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06041BE6 RID: 269286 RVA: 0x00FF27D0 File Offset: 0x00FF09D0
		[NullableContext(2)]
		private void OnDropCatchLevelRewardResponse(IMessage msg, Net.CallbackStatus status)
		{
			DropCatchLevelRewardUpdateNotify dropCatchLevelRewardUpdateNotify = (DropCatchLevelRewardUpdateNotify)msg;
			if (dropCatchLevelRewardUpdateNotify == null || dropCatchLevelRewardUpdateNotify.DropCatchLevelInfos == null)
			{
				return;
			}
			DropCatchActivityData dropCatchActivityData = ActivityModel.Instance.GetActivityById(this.ActivityId) as DropCatchActivityData;
			if (dropCatchActivityData == null)
			{
				return;
			}
			dropCatchActivityData.OnLevelRewardUpdateNotify(dropCatchLevelRewardUpdateNotify.DropCatchLevelInfos);
			EventSystem.Instance.Emit(EEventName.DropCatchActivityRewardUpdate);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}

		// Token: 0x06041BE7 RID: 269287 RVA: 0x00FF283C File Offset: 0x00FF0A3C
		public void RequestLevelReward(int configId)
		{
			DropCatchActivityData dropCatchActivityData = ActivityModel.Instance.GetActivityById(this.ActivityId) as DropCatchActivityData;
			if (dropCatchActivityData == null)
			{
				return;
			}
			DropCatchLevelRewardRequest dropCatchLevelRewardRequest = DropCatchLevelRewardRequest.Create();
			dropCatchLevelRewardRequest.DropCatchId = configId;
			DropCatchLevelData levelData = dropCatchActivityData.GetLevelData(configId);
			if (levelData == null)
			{
				return;
			}
			List<int> list = new List<int>();
			for (int i = 0; i < levelData.RewardStates.Count; i++)
			{
				if (levelData.RewardStates[i] == EDropCatchLevelState.Unlock)
				{
					list.Add(i);
				}
			}
			dropCatchLevelRewardRequest.RewardIdxs.AddRange(list);
			Net.Instance.Call(ERequestMessageId.DropCatchLevelRewardRequest, dropCatchLevelRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				DropCatchLevelRewardResponse dropCatchLevelRewardResponse = (DropCatchLevelRewardResponse)msg;
				if (dropCatchLevelRewardResponse == null)
				{
					return;
				}
				if (dropCatchLevelRewardResponse.Error != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(dropCatchLevelRewardResponse.Error, 19373, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06041BE8 RID: 269288 RVA: 0x00FF28F0 File Offset: 0x00FF0AF0
		public bool IsNewRoleClicked(int configId)
		{
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.DropCatchRoleClickDetail) as ServerStorageSet;
			return serverStorageSet == null || !serverStorageSet.Has(configId);
		}

		// Token: 0x06041BE9 RID: 269289 RVA: 0x00FF2914 File Offset: 0x00FF0B14
		public void SetNewRoleClicked(int roleId)
		{
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.DropCatchRoleClickDetail) as ServerStorageSet;
			if (serverStorageSet == null || !serverStorageSet.Has(roleId))
			{
				if (serverStorageSet != null)
				{
					serverStorageSet.Add(roleId);
				}
				EventSystem.Instance.Emit(EEventName.DropCatchActivityRewardUpdate);
			}
		}

		// Token: 0x06041BEA RID: 269290 RVA: 0x00FF2960 File Offset: 0x00FF0B60
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			DropCatchActivityController.<OnOpenSubView>d__12 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<DropCatchActivityController.<OnOpenSubView>d__12>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x06041BEB RID: 269291 RVA: 0x00FF29A4 File Offset: 0x00FF0BA4
		public bool CheckLevelCompleted(int levelId)
		{
			DropCatchActivityData dropCatchActivityData = ActivityModel.Instance.GetActivityById(this.ActivityId) as DropCatchActivityData;
			if (dropCatchActivityData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				string message = "找不到对应活动信息";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", this.ActivityId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			return dropCatchActivityData.CheckLevelCompleted(levelId);
		}

		// Token: 0x06041BEC RID: 269292 RVA: 0x00FF2A08 File Offset: 0x00FF0C08
		public bool CheckLevelUnlock(int levelId)
		{
			DropCatchActivityData dropCatchActivityData = ActivityModel.Instance.GetActivityById(this.ActivityId) as DropCatchActivityData;
			if (dropCatchActivityData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				string message = "找不到对应活动信息";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", this.ActivityId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			DropCatchLevelData levelData = dropCatchActivityData.GetLevelData(levelId);
			return levelData != null && levelData.IsUnlock;
		}

		// Token: 0x06041BED RID: 269293 RVA: 0x00FF2A78 File Offset: 0x00FF0C78
		public void SetPreferredOpenLevel(int levelId)
		{
			DropCatchActivityData dropCatchActivityData = ActivityModel.Instance.GetActivityById(this.ActivityId) as DropCatchActivityData;
			if (dropCatchActivityData == null)
			{
				return;
			}
			dropCatchActivityData.SetPreferredOpenLevel(levelId);
		}

		// Token: 0x06041BEE RID: 269294 RVA: 0x00FF2AA8 File Offset: 0x00FF0CA8
		public bool CheckIfActivityClose(bool isShowTips)
		{
			DropCatchActivityData dropCatchActivityData = ActivityModel.Instance.GetActivityById(this.ActivityId) as DropCatchActivityData;
			if (dropCatchActivityData == null)
			{
				if (isShowTips)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_ErrCoinCatchNotOpen", Array.Empty<object>());
				}
				return true;
			}
			bool flag = dropCatchActivityData.CheckIfClose();
			if (flag && isShowTips)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_ErrCoinCatchNotOpen", Array.Empty<object>());
			}
			return flag;
		}

		// Token: 0x1700963B RID: 38459
		// (get) Token: 0x06041BEF RID: 269295 RVA: 0x00FF2B06 File Offset: 0x00FF0D06
		public static DropCatchActivityController Instance
		{
			get
			{
				return DropCatchActivityController._Instance;
			}
		}

		// Token: 0x06041BF0 RID: 269296 RVA: 0x00FF2B0D File Offset: 0x00FF0D0D
		public static DropCatchActivityController GetOrCreateInstance()
		{
			if (DropCatchActivityController._Instance == null)
			{
				DropCatchActivityController.CreateInstance();
			}
			return DropCatchActivityController._Instance;
		}

		// Token: 0x06041BF1 RID: 269297 RVA: 0x00FF2B21 File Offset: 0x00FF0D21
		public static bool CreateInstance()
		{
			if (DropCatchActivityController._Instance != null)
			{
				return true;
			}
			DropCatchActivityController._Instance = new DropCatchActivityController();
			return true;
		}

		// Token: 0x06041BF2 RID: 269298 RVA: 0x00FF2B37 File Offset: 0x00FF0D37
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041BF3 RID: 269299 RVA: 0x00FF2B39 File Offset: 0x00FF0D39
		public static void ResetStaticDefaultValue()
		{
			DropCatchActivityController._Instance = null;
		}

		// Token: 0x06041BF4 RID: 269300 RVA: 0x00FF2B41 File Offset: 0x00FF0D41
		static DropCatchActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DropCatchActivityController.CreateStaticDefaultValue), new Action(DropCatchActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x04022363 RID: 140131
		public int ActivityId;

		// Token: 0x04022364 RID: 140132
		[Nullable(2)]
		private static DropCatchActivityController _Instance;
	}
}
