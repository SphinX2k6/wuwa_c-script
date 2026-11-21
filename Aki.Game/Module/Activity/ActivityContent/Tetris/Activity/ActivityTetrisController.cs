using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Activity
{
	// Token: 0x02002FF7 RID: 12279
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityTetrisController : ActivityControllerBase
	{
		// Token: 0x0601D255 RID: 119381 RVA: 0x008E7BDF File Offset: 0x008E5DDF
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0601D256 RID: 119382 RVA: 0x008E7BE1 File Offset: 0x008E5DE1
		protected override void OnRegisterNetEvent()
		{
		}

		// Token: 0x0601D257 RID: 119383 RVA: 0x008E7BE3 File Offset: 0x008E5DE3
		protected override void OnUnRegisterNetEvent()
		{
		}

		// Token: 0x0601D258 RID: 119384 RVA: 0x008E7BE5 File Offset: 0x008E5DE5
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityCube";
		}

		// Token: 0x0601D259 RID: 119385 RVA: 0x008E7BEC File Offset: 0x008E5DEC
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityTetrisSubView();
		}

		// Token: 0x0601D25A RID: 119386 RVA: 0x008E7BF3 File Offset: 0x008E5DF3
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityTetrisData();
		}

		// Token: 0x0601D25B RID: 119387 RVA: 0x008E7C08 File Offset: 0x008E5E08
		public void SendCompleteRequest(TetrisUpdateRequest request, [Nullable(2)] ActivityTetrisController.Delegate_OnTetrisUpdateFinished callback)
		{
			Net.Instance.Call(ERequestMessageId.TetrisUpdateRequest, request, delegate(IMessage response, Net.CallbackStatus _)
			{
				TetrisUpdateResponse tetrisUpdateResponse = response as TetrisUpdateResponse;
				if (tetrisUpdateResponse != null)
				{
					if (tetrisUpdateResponse.ErrCode != ErrorCode.Success)
					{
						ErrorCodeController.Instance.OpenErrorCodeTipView(tetrisUpdateResponse.ErrCode, 21709, null, true, true);
					}
					List<RewardItemData> list = new List<RewardItemData>(tetrisUpdateResponse.Items.Count);
					foreach (KeyValuePair<int, int> keyValuePair in tetrisUpdateResponse.Items)
					{
						list.Add(new RewardItemData(keyValuePair.Key, keyValuePair.Value, null, EDropItemType.Normal));
					}
					ActivityTetrisController.Delegate_OnTetrisUpdateFinished callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(list);
				}
			}, 0);
		}

		// Token: 0x0601D25C RID: 119388 RVA: 0x008E7C40 File Offset: 0x008E5E40
		public bool GetRedPointShow()
		{
			int activityId = this.ActivityId;
			List<TetrisSelectGroupData> allGroupByActivityId = ActivityTetrisConfig.Instance.GetAllGroupByActivityId(activityId);
			if (allGroupByActivityId.Count == 0)
			{
				return false;
			}
			ActivityTetrisData tetrisData = this.GetTetrisData();
			if (tetrisData == null)
			{
				return false;
			}
			foreach (TetrisSelectGroupData tetrisSelectGroupData in allGroupByActivityId)
			{
				if (tetrisData.CheckGroupRedPointShow(tetrisSelectGroupData.ChallengeIds))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0601D25D RID: 119389 RVA: 0x008E7CCC File Offset: 0x008E5ECC
		[NullableContext(2)]
		public ActivityTetrisData GetTetrisData()
		{
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.TetrisActivity);
			ActivityTetrisData result = null;
			if (currentActivitiesByType.Count > 0)
			{
				result = (currentActivitiesByType[0] as ActivityTetrisData);
			}
			return result;
		}

		// Token: 0x0601D25E RID: 119390 RVA: 0x008E7CFF File Offset: 0x008E5EFF
		public List<TetrisSelectGroupData> GetAllLevelSelectData()
		{
			return ActivityTetrisConfig.Instance.GetAllGroupByActivityId(this.ActivityId);
		}

		// Token: 0x0601D25F RID: 119391 RVA: 0x008E7D11 File Offset: 0x008E5F11
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0601D260 RID: 119392 RVA: 0x008E7D14 File Offset: 0x008E5F14
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			ActivityTetrisController.<OnOpenSubView>d__13 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<ActivityTetrisController.<OnOpenSubView>d__13>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x0601D261 RID: 119393 RVA: 0x008E7D57 File Offset: 0x008E5F57
		public static ActivityTetrisController Instance
		{
			get
			{
				return ActivityTetrisController._Instance;
			}
		}

		// Token: 0x0601D262 RID: 119394 RVA: 0x008E7D5E File Offset: 0x008E5F5E
		public static ActivityTetrisController GetOrCreateInstance()
		{
			if (ActivityTetrisController._Instance == null)
			{
				ActivityTetrisController.CreateInstance();
			}
			return ActivityTetrisController._Instance;
		}

		// Token: 0x0601D263 RID: 119395 RVA: 0x008E7D72 File Offset: 0x008E5F72
		public static bool CreateInstance()
		{
			if (ActivityTetrisController._Instance != null)
			{
				return true;
			}
			ActivityTetrisController._Instance = new ActivityTetrisController();
			return true;
		}

		// Token: 0x0601D264 RID: 119396 RVA: 0x008E7D88 File Offset: 0x008E5F88
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0601D265 RID: 119397 RVA: 0x008E7D8A File Offset: 0x008E5F8A
		public static void ResetStaticDefaultValue()
		{
			ActivityTetrisController._Instance = null;
		}

		// Token: 0x0601D266 RID: 119398 RVA: 0x008E7D92 File Offset: 0x008E5F92
		static ActivityTetrisController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityTetrisController.CreateStaticDefaultValue), new Action(ActivityTetrisController.ResetStaticDefaultValue));
		}

		// Token: 0x0400F58C RID: 62860
		public int ActivityId;

		// Token: 0x0400F58D RID: 62861
		[Nullable(2)]
		private static ActivityTetrisController _Instance;

		// Token: 0x02008C65 RID: 35941
		// (Invoke) Token: 0x06042D01 RID: 273665
		[NullableContext(0)]
		public delegate void Delegate_OnTetrisUpdateFinished(List<RewardItemData> rewards);
	}
}
