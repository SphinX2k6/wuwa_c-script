using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CommonH5
{
	// Token: 0x020068F4 RID: 26868
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class CommonH5Model : ModelBase
	{
		// Token: 0x06043035 RID: 274485 RVA: 0x0105293C File Offset: 0x01050B3C
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

		// Token: 0x06043036 RID: 274486 RVA: 0x01052970 File Offset: 0x01050B70
		public void OnActivityDataNotify(H5ViewActivityDataNotify data)
		{
			CommonH5Data activityData = this.GetActivityData();
			if (activityData != null)
			{
				activityData.ChangeServerRedDotState(data.ActivityData.RedDot);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
			}
		}

		// Token: 0x06043037 RID: 274487 RVA: 0x010529B0 File Offset: 0x01050BB0
		public bool GetRedDotState()
		{
			CommonH5Data activityData = this.GetActivityData();
			return activityData != null && activityData.RedPointShowState;
		}

		// Token: 0x06043038 RID: 274488 RVA: 0x010529D0 File Offset: 0x01050BD0
		public void SaveClickRedDotState()
		{
			CommonH5Data activityData = this.GetActivityData();
			if (activityData != null)
			{
				activityData.SaveClickRedDotState();
			}
		}

		// Token: 0x170097E6 RID: 38886
		// (get) Token: 0x06043039 RID: 274489 RVA: 0x010529ED File Offset: 0x01050BED
		public static CommonH5Model Instance
		{
			get
			{
				return CommonH5Model._Instance;
			}
		}

		// Token: 0x0604303A RID: 274490 RVA: 0x010529F4 File Offset: 0x01050BF4
		public static CommonH5Model GetOrCreateInstance()
		{
			if (CommonH5Model._Instance == null)
			{
				CommonH5Model.CreateInstance();
			}
			return CommonH5Model._Instance;
		}

		// Token: 0x0604303B RID: 274491 RVA: 0x01052A08 File Offset: 0x01050C08
		public static bool CreateInstance()
		{
			if (CommonH5Model._Instance != null)
			{
				return true;
			}
			CommonH5Model._Instance = new CommonH5Model();
			return true;
		}

		// Token: 0x0604303C RID: 274492 RVA: 0x01052A1E File Offset: 0x01050C1E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604303D RID: 274493 RVA: 0x01052A20 File Offset: 0x01050C20
		public static void ResetStaticDefaultValue()
		{
			CommonH5Model._Instance = null;
		}

		// Token: 0x0604303E RID: 274494 RVA: 0x01052A28 File Offset: 0x01050C28
		static CommonH5Model()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CommonH5Model.CreateStaticDefaultValue), new Action(CommonH5Model.ResetStaticDefaultValue));
		}

		// Token: 0x04022E31 RID: 142897
		[Nullable(2)]
		private static CommonH5Model _Instance;
	}
}
