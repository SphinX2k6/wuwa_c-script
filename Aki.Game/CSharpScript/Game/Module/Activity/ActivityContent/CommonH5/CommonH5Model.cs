using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CommonH5
{
	// Token: 0x02005844 RID: 22596
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class CommonH5Model : ModelBase
	{
		// Token: 0x06037B8D RID: 228237 RVA: 0x00F93F64 File Offset: 0x00F92164
		[NullableContext(2)]
		public CommonH5Data GetActivityData()
		{
			List<ActivityBaseData> activitiesByType = ActivityModel.Instance.GetActivitiesByType(84);
			if (activitiesByType.Count > 0)
			{
				return activitiesByType[0] as CommonH5Data;
			}
			return null;
		}

		// Token: 0x06037B8E RID: 228238 RVA: 0x00F93F98 File Offset: 0x00F92198
		public void OnActivityDataNotify(H5ViewActivityDataNotify data)
		{
			CommonH5Data activityData = this.GetActivityData();
			if (activityData != null)
			{
				activityData.ChangeServerRedDotState(data.ActivityData.RedDot);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
			}
		}

		// Token: 0x06037B8F RID: 228239 RVA: 0x00F93FD8 File Offset: 0x00F921D8
		public bool GetRedDotState()
		{
			CommonH5Data activityData = this.GetActivityData();
			return activityData != null && activityData.RedPointShowState;
		}

		// Token: 0x06037B90 RID: 228240 RVA: 0x00F93FF8 File Offset: 0x00F921F8
		public void SaveClickRedDotState()
		{
			CommonH5Data activityData = this.GetActivityData();
			if (activityData != null)
			{
				activityData.SaveClickRedDotState();
			}
		}

		// Token: 0x17006B26 RID: 27430
		// (get) Token: 0x06037B91 RID: 228241 RVA: 0x00F94015 File Offset: 0x00F92215
		public static CommonH5Model Instance
		{
			get
			{
				return CommonH5Model._Instance;
			}
		}

		// Token: 0x06037B92 RID: 228242 RVA: 0x00F9401C File Offset: 0x00F9221C
		public static CommonH5Model GetOrCreateInstance()
		{
			if (CommonH5Model._Instance == null)
			{
				CommonH5Model.CreateInstance();
			}
			return CommonH5Model._Instance;
		}

		// Token: 0x06037B93 RID: 228243 RVA: 0x00F94030 File Offset: 0x00F92230
		public static bool CreateInstance()
		{
			if (CommonH5Model._Instance != null)
			{
				return true;
			}
			CommonH5Model._Instance = new CommonH5Model();
			return true;
		}

		// Token: 0x06037B94 RID: 228244 RVA: 0x00F94046 File Offset: 0x00F92246
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037B95 RID: 228245 RVA: 0x00F94048 File Offset: 0x00F92248
		public static void ResetStaticDefaultValue()
		{
			CommonH5Model._Instance = null;
		}

		// Token: 0x06037B96 RID: 228246 RVA: 0x00F94050 File Offset: 0x00F92250
		static CommonH5Model()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonH5Model.CreateStaticDefaultValue), new Action(CommonH5Model.ResetStaticDefaultValue));
		}

		// Token: 0x0401D68D RID: 120461
		[Nullable(2)]
		private static CommonH5Model _Instance;
	}
}
