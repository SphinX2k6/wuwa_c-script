using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061E5 RID: 25061
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookTabItemLock : RoadBookTabItemBase
	{
		// Token: 0x0603F431 RID: 259121 RVA: 0x00F49526 File Offset: 0x00F47726
		public RoadBookTabItemLock(ActivityRoadBookData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0603F432 RID: 259122 RVA: 0x00F4952F File Offset: 0x00F4772F
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x0603F433 RID: 259123 RVA: 0x00F49558 File Offset: 0x00F47758
		public override void RefreshByData(RoadBookAreaData data, int index)
		{
			base.RefreshByData(data, index);
			Area value = AreaConfig.Instance.GetAreaInfo(data.AreaId).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Title, Array.Empty<object>());
		}
	}
}
