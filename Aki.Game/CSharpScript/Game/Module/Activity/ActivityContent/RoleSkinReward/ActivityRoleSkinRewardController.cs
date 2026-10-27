using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinReward
{
	// Token: 0x020061B9 RID: 25017
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityRoleSkinRewardController : ActivityControllerBase
	{
		// Token: 0x0603F30D RID: 258829 RVA: 0x00F44BFE File Offset: 0x00F42DFE
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603F30E RID: 258830 RVA: 0x00F44C00 File Offset: 0x00F42E00
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.SkinRewardInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSkinRewardInfoUpdateNotify));
		}

		// Token: 0x0603F30F RID: 258831 RVA: 0x00F44C1E File Offset: 0x00F42E1E
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.SkinRewardInfoUpdateNotify);
		}

		// Token: 0x0603F310 RID: 258832 RVA: 0x00F44C30 File Offset: 0x00F42E30
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityRoverSkinMain";
		}

		// Token: 0x0603F311 RID: 258833 RVA: 0x00F44C37 File Offset: 0x00F42E37
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityRoleSkinRewardSubView();
		}

		// Token: 0x0603F312 RID: 258834 RVA: 0x00F44C3E File Offset: 0x00F42E3E
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityRoleSkinRewardData();
		}

		// Token: 0x0603F313 RID: 258835 RVA: 0x00F44C51 File Offset: 0x00F42E51
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603F314 RID: 258836 RVA: 0x00F44C54 File Offset: 0x00F42E54
		[NullableContext(2)]
		public ActivityRoleSkinRewardData GetSkinRewardData()
		{
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.SkinRewardActivity);
			ActivityRoleSkinRewardData result = null;
			if (currentActivitiesByType != null)
			{
				result = (currentActivitiesByType[0] as ActivityRoleSkinRewardData);
			}
			return result;
		}

		// Token: 0x0603F315 RID: 258837 RVA: 0x00F44C84 File Offset: 0x00F42E84
		[NullableContext(2)]
		private void OnSkinRewardInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			SkinRewardInfoUpdateNotify skinRewardInfoUpdateNotify = (SkinRewardInfoUpdateNotify)msg;
			if (skinRewardInfoUpdateNotify.RewardInfo != null)
			{
				this.GetSkinRewardData().UpdateSkinRewardState(skinRewardInfoUpdateNotify.RewardInfo.ConfigId, skinRewardInfoUpdateNotify.RewardInfo.State);
				EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, this.ActivityId);
			}
		}

		// Token: 0x17009217 RID: 37399
		// (get) Token: 0x0603F316 RID: 258838 RVA: 0x00F44CD7 File Offset: 0x00F42ED7
		public static ActivityRoleSkinRewardController Instance
		{
			get
			{
				return ActivityRoleSkinRewardController._Instance;
			}
		}

		// Token: 0x0603F317 RID: 258839 RVA: 0x00F44CDE File Offset: 0x00F42EDE
		public static ActivityRoleSkinRewardController GetOrCreateInstance()
		{
			if (ActivityRoleSkinRewardController._Instance == null)
			{
				ActivityRoleSkinRewardController.CreateInstance();
			}
			return ActivityRoleSkinRewardController._Instance;
		}

		// Token: 0x0603F318 RID: 258840 RVA: 0x00F44CF2 File Offset: 0x00F42EF2
		public static bool CreateInstance()
		{
			if (ActivityRoleSkinRewardController._Instance != null)
			{
				return true;
			}
			ActivityRoleSkinRewardController._Instance = new ActivityRoleSkinRewardController();
			return true;
		}

		// Token: 0x0603F319 RID: 258841 RVA: 0x00F44D08 File Offset: 0x00F42F08
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603F31A RID: 258842 RVA: 0x00F44D0A File Offset: 0x00F42F0A
		public static void ResetStaticDefaultValue()
		{
			ActivityRoleSkinRewardController._Instance = null;
		}

		// Token: 0x0603F31B RID: 258843 RVA: 0x00F44D12 File Offset: 0x00F42F12
		static ActivityRoleSkinRewardController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleSkinRewardController.CreateStaticDefaultValue), new Action(ActivityRoleSkinRewardController.ResetStaticDefaultValue));
		}

		// Token: 0x04020EEC RID: 134892
		public int ActivityId;

		// Token: 0x04020EED RID: 134893
		[Nullable(2)]
		private static ActivityRoleSkinRewardController _Instance;
	}
}
