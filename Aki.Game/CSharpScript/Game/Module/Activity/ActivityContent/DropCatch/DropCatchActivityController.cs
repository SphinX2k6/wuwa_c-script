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
	// Token: 0x020055CC RID: 21964
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchActivityController : ActivityControllerBase
	{
		// Token: 0x0603672B RID: 223019 RVA: 0x00F33B7F File Offset: 0x00F31D7F
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.DropCatchLevelRewardUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnDropCatchLevelRewardResponse));
		}

		// Token: 0x0603672C RID: 223020 RVA: 0x00F33B9D File Offset: 0x00F31D9D
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.DropCatchLevelRewardUpdateNotify);
		}

		// Token: 0x0603672D RID: 223021 RVA: 0x00F33BAF File Offset: 0x00F31DAF
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603672E RID: 223022 RVA: 0x00F33BB1 File Offset: 0x00F31DB1
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityMainGoldCatch";
		}

		// Token: 0x0603672F RID: 223023 RVA: 0x00F33BB8 File Offset: 0x00F31DB8
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new DropCatchSubView();
		}

		// Token: 0x06036730 RID: 223024 RVA: 0x00F33BBF File Offset: 0x00F31DBF
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new DropCatchActivityData();
		}

		// Token: 0x06036731 RID: 223025 RVA: 0x00F33BD2 File Offset: 0x00F31DD2
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06036732 RID: 223026 RVA: 0x00F33BD8 File Offset: 0x00F31DD8
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

		// Token: 0x06036733 RID: 223027 RVA: 0x00F33C44 File Offset: 0x00F31E44
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(dropCatchLevelRewardResponse.Error, 27201, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06036734 RID: 223028 RVA: 0x00F33CF8 File Offset: 0x00F31EF8
		public bool IsNewRoleClicked(int configId)
		{
			ServerStorageSet serverStorageSet = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.DropCatchRoleClickDetail) as ServerStorageSet;
			return serverStorageSet == null || !serverStorageSet.Has(configId);
		}

		// Token: 0x06036735 RID: 223029 RVA: 0x00F33D1C File Offset: 0x00F31F1C
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

		// Token: 0x06036736 RID: 223030 RVA: 0x00F33D68 File Offset: 0x00F31F68
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

		// Token: 0x06036737 RID: 223031 RVA: 0x00F33DAC File Offset: 0x00F31FAC
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

		// Token: 0x06036738 RID: 223032 RVA: 0x00F33E10 File Offset: 0x00F32010
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

		// Token: 0x06036739 RID: 223033 RVA: 0x00F33E80 File Offset: 0x00F32080
		public void SetPreferredOpenLevel(int levelId)
		{
			DropCatchActivityData dropCatchActivityData = ActivityModel.Instance.GetActivityById(this.ActivityId) as DropCatchActivityData;
			if (dropCatchActivityData == null)
			{
				return;
			}
			dropCatchActivityData.SetPreferredOpenLevel(levelId);
		}

		// Token: 0x0603673A RID: 223034 RVA: 0x00F33EB0 File Offset: 0x00F320B0
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

		// Token: 0x1700697A RID: 27002
		// (get) Token: 0x0603673B RID: 223035 RVA: 0x00F33F0E File Offset: 0x00F3210E
		public static DropCatchActivityController Instance
		{
			get
			{
				return DropCatchActivityController._Instance;
			}
		}

		// Token: 0x0603673C RID: 223036 RVA: 0x00F33F15 File Offset: 0x00F32115
		public static DropCatchActivityController GetOrCreateInstance()
		{
			if (DropCatchActivityController._Instance == null)
			{
				DropCatchActivityController.CreateInstance();
			}
			return DropCatchActivityController._Instance;
		}

		// Token: 0x0603673D RID: 223037 RVA: 0x00F33F29 File Offset: 0x00F32129
		public static bool CreateInstance()
		{
			if (DropCatchActivityController._Instance != null)
			{
				return true;
			}
			DropCatchActivityController._Instance = new DropCatchActivityController();
			return true;
		}

		// Token: 0x0603673E RID: 223038 RVA: 0x00F33F3F File Offset: 0x00F3213F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603673F RID: 223039 RVA: 0x00F33F41 File Offset: 0x00F32141
		public static void ResetStaticDefaultValue()
		{
			DropCatchActivityController._Instance = null;
		}

		// Token: 0x06036740 RID: 223040 RVA: 0x00F33F49 File Offset: 0x00F32149
		static DropCatchActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DropCatchActivityController.CreateStaticDefaultValue), new Action(DropCatchActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x0401CBBC RID: 117692
		public int ActivityId;

		// Token: 0x0401CBBD RID: 117693
		[Nullable(2)]
		private static DropCatchActivityController _Instance;
	}
}
