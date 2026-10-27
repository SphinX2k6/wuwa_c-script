using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061E4 RID: 25060
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookTabItem : RoadBookTabItemBase
	{
		// Token: 0x0603F42F RID: 259119 RVA: 0x00F4947E File Offset: 0x00F4767E
		public RoadBookTabItem(ActivityRoadBookData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0603F430 RID: 259120 RVA: 0x00F49488 File Offset: 0x00F47688
		public override void RefreshByData(RoadBookAreaData data, int index)
		{
			base.RefreshByData(data, index);
			Area value = AreaConfig.Instance.GetAreaInfo(data.AreaId).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Title, Array.Empty<object>());
			bool uiactive = this.ActivityBaseData.IsAreaTaskFinish(data.AreaId);
			bool areaRewardState = this.ActivityBaseData.GetAreaRewardState(data.AreaId);
			base.GetItem(2).SetUIActive(uiactive);
			base.GetItem(3).SetUIActive(!data.IsUnlock);
			base.GetItem(4).SetUIActive(areaRewardState);
		}
	}
}
