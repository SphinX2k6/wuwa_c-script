using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FC7 RID: 24519
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityTetrisController : ActivityControllerBase
	{
		// Token: 0x0603E243 RID: 254531 RVA: 0x00F02321 File Offset: 0x00F00521
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603E244 RID: 254532 RVA: 0x00F02323 File Offset: 0x00F00523
		protected override void OnRegisterNetEvent()
		{
		}

		// Token: 0x0603E245 RID: 254533 RVA: 0x00F02325 File Offset: 0x00F00525
		protected override void OnUnRegisterNetEvent()
		{
		}

		// Token: 0x0603E246 RID: 254534 RVA: 0x00F02327 File Offset: 0x00F00527
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityCube";
		}

		// Token: 0x0603E247 RID: 254535 RVA: 0x00F0232E File Offset: 0x00F0052E
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityTetrisSubView();
		}

		// Token: 0x0603E248 RID: 254536 RVA: 0x00F02335 File Offset: 0x00F00535
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityTetrisData();
		}

		// Token: 0x0603E249 RID: 254537 RVA: 0x00F02348 File Offset: 0x00F00548
		public void SendCompleteRequest(TetrisUpdateRequest request, Action callback)
		{
			Net.Instance.Call(ERequestMessageId.TetrisUpdateRequest, request, delegate(IMessage msg, Net.CallbackStatus _)
			{
				TetrisUpdateResponse tetrisUpdateResponse = (TetrisUpdateResponse)msg;
				if (tetrisUpdateResponse == null)
				{
					return;
				}
				if (tetrisUpdateResponse.ErrCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(tetrisUpdateResponse.ErrCode, 25865, null, true, true);
				}
				if (callback != null)
				{
					callback();
				}
			}, 0);
		}

		// Token: 0x0603E24A RID: 254538 RVA: 0x00F02380 File Offset: 0x00F00580
		public bool GetRedPointShow()
		{
			int activityId = this.ActivityId;
			List<ITetrisSelectGroupData> allGroupByActivityId = ActivityTetrisConfig.Instance.GetAllGroupByActivityId(activityId);
			if (allGroupByActivityId == null)
			{
				return false;
			}
			ActivityTetrisData tetrisData = this.GetTetrisData();
			if (tetrisData == null)
			{
				return false;
			}
			foreach (ITetrisSelectGroupData tetrisSelectGroupData in allGroupByActivityId)
			{
				if (tetrisData.CheckGroupRedPointShow(tetrisSelectGroupData.ChallengeIds))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603E24B RID: 254539 RVA: 0x00F02404 File Offset: 0x00F00604
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

		// Token: 0x0603E24C RID: 254540 RVA: 0x00F02437 File Offset: 0x00F00637
		public List<ITetrisSelectGroupData> GetAllLevelSelectData()
		{
			return ActivityTetrisConfig.Instance.GetAllGroupByActivityId(this.ActivityId);
		}

		// Token: 0x0603E24D RID: 254541 RVA: 0x00F02449 File Offset: 0x00F00649
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603E24E RID: 254542 RVA: 0x00F0244C File Offset: 0x00F0064C
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			ActivityTetrisController.<OnOpenSubView>d__12 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<ActivityTetrisController.<OnOpenSubView>d__12>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x17008FFD RID: 36861
		// (get) Token: 0x0603E24F RID: 254543 RVA: 0x00F0248F File Offset: 0x00F0068F
		public static ActivityTetrisController Instance
		{
			get
			{
				return ActivityTetrisController._Instance;
			}
		}

		// Token: 0x0603E250 RID: 254544 RVA: 0x00F02496 File Offset: 0x00F00696
		public static ActivityTetrisController GetOrCreateInstance()
		{
			if (ActivityTetrisController._Instance == null)
			{
				ActivityTetrisController.CreateInstance();
			}
			return ActivityTetrisController._Instance;
		}

		// Token: 0x0603E251 RID: 254545 RVA: 0x00F024AA File Offset: 0x00F006AA
		public static bool CreateInstance()
		{
			if (ActivityTetrisController._Instance != null)
			{
				return true;
			}
			ActivityTetrisController._Instance = new ActivityTetrisController();
			return true;
		}

		// Token: 0x0603E252 RID: 254546 RVA: 0x00F024C0 File Offset: 0x00F006C0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E253 RID: 254547 RVA: 0x00F024C2 File Offset: 0x00F006C2
		public static void ResetStaticDefaultValue()
		{
			ActivityTetrisController._Instance = null;
		}

		// Token: 0x0603E254 RID: 254548 RVA: 0x00F024CA File Offset: 0x00F006CA
		static ActivityTetrisController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityTetrisController.CreateStaticDefaultValue), new Action(ActivityTetrisController.ResetStaticDefaultValue));
		}

		// Token: 0x04020766 RID: 132966
		public int ActivityId;

		// Token: 0x04020767 RID: 132967
		[Nullable(2)]
		private static ActivityTetrisController _Instance;
	}
}
