using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005163 RID: 20835
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookTabItemLock : RoadBookTabItemBase
	{
		// Token: 0x060340F2 RID: 213234 RVA: 0x00E9047E File Offset: 0x00E8E67E
		public RoadBookTabItemLock(ActivityRoadBookData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x060340F3 RID: 213235 RVA: 0x00E90487 File Offset: 0x00E8E687
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x060340F4 RID: 213236 RVA: 0x00E904B0 File Offset: 0x00E8E6B0
		public override void RefreshByData(RoadBookAreaData data, int index)
		{
			base.RefreshByData(data, index);
			Area value = AreaConfig.Instance.GetAreaInfo(data.AreaId).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Title, Array.Empty<object>());
		}
	}
}
