using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinReward
{
	// Token: 0x02005137 RID: 20791
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityRoleSkinRewardController : ActivityControllerBase
	{
		// Token: 0x06033FCE RID: 212942 RVA: 0x00E8BB56 File Offset: 0x00E89D56
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06033FCF RID: 212943 RVA: 0x00E8BB58 File Offset: 0x00E89D58
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.SkinRewardInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSkinRewardInfoUpdateNotify));
		}

		// Token: 0x06033FD0 RID: 212944 RVA: 0x00E8BB76 File Offset: 0x00E89D76
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.SkinRewardInfoUpdateNotify);
		}

		// Token: 0x06033FD1 RID: 212945 RVA: 0x00E8BB88 File Offset: 0x00E89D88
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityRoverSkinMain";
		}

		// Token: 0x06033FD2 RID: 212946 RVA: 0x00E8BB8F File Offset: 0x00E89D8F
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityRoleSkinRewardSubView();
		}

		// Token: 0x06033FD3 RID: 212947 RVA: 0x00E8BB96 File Offset: 0x00E89D96
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityRoleSkinRewardData();
		}

		// Token: 0x06033FD4 RID: 212948 RVA: 0x00E8BBA9 File Offset: 0x00E89DA9
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06033FD5 RID: 212949 RVA: 0x00E8BBAC File Offset: 0x00E89DAC
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

		// Token: 0x06033FD6 RID: 212950 RVA: 0x00E8BBDC File Offset: 0x00E89DDC
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

		// Token: 0x17006579 RID: 25977
		// (get) Token: 0x06033FD7 RID: 212951 RVA: 0x00E8BC2F File Offset: 0x00E89E2F
		public static ActivityRoleSkinRewardController Instance
		{
			get
			{
				return ActivityRoleSkinRewardController._Instance;
			}
		}

		// Token: 0x06033FD8 RID: 212952 RVA: 0x00E8BC36 File Offset: 0x00E89E36
		public static ActivityRoleSkinRewardController GetOrCreateInstance()
		{
			if (ActivityRoleSkinRewardController._Instance == null)
			{
				ActivityRoleSkinRewardController.CreateInstance();
			}
			return ActivityRoleSkinRewardController._Instance;
		}

		// Token: 0x06033FD9 RID: 212953 RVA: 0x00E8BC4A File Offset: 0x00E89E4A
		public static bool CreateInstance()
		{
			if (ActivityRoleSkinRewardController._Instance != null)
			{
				return true;
			}
			ActivityRoleSkinRewardController._Instance = new ActivityRoleSkinRewardController();
			return true;
		}

		// Token: 0x06033FDA RID: 212954 RVA: 0x00E8BC60 File Offset: 0x00E89E60
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033FDB RID: 212955 RVA: 0x00E8BC62 File Offset: 0x00E89E62
		public static void ResetStaticDefaultValue()
		{
			ActivityRoleSkinRewardController._Instance = null;
		}

		// Token: 0x06033FDC RID: 212956 RVA: 0x00E8BC6A File Offset: 0x00E89E6A
		static ActivityRoleSkinRewardController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleSkinRewardController.CreateStaticDefaultValue), new Action(ActivityRoleSkinRewardController.ResetStaticDefaultValue));
		}

		// Token: 0x0401B81B RID: 112667
		public int ActivityId;

		// Token: 0x0401B81C RID: 112668
		[Nullable(2)]
		private static ActivityRoleSkinRewardController _Instance;
	}
}
