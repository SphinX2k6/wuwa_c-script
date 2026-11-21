using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;

namespace ActivityNamespace.MapTravel
{
	// Token: 0x02002F61 RID: 12129
	public class MapTravelTabItemLock : MapTravelTabItemBase
	{
		// Token: 0x0601CB9D RID: 117661 RVA: 0x008C473E File Offset: 0x008C293E
		[NullableContext(1)]
		public MapTravelTabItemLock(ActivityMapTravelData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0601CB9E RID: 117662 RVA: 0x008C4747 File Offset: 0x008C2947
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x0601CB9F RID: 117663 RVA: 0x008C4770 File Offset: 0x008C2970
		[NullableContext(1)]
		public override void RefreshByData(MapTravelAreaData data, int index)
		{
			base.RefreshByData(data, index);
			Area? areaInfo = AreaConfig.Instance.GetAreaInfo(data.AreaId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), areaInfo.Value.Title, Array.Empty<object>());
		}

		// Token: 0x02008BF0 RID: 35824
		private new class ETabComponents
		{
			// Token: 0x0402C542 RID: 181570
			public const int Toggle = 0;

			// Token: 0x0402C543 RID: 181571
			public const int Name = 1;

			// Token: 0x0402C544 RID: 181572
			public const int SpriteDone = 2;

			// Token: 0x0402C545 RID: 181573
			public const int SpriteLock = 3;

			// Token: 0x0402C546 RID: 181574
			public const int RedDot = 4;
		}
	}
}
