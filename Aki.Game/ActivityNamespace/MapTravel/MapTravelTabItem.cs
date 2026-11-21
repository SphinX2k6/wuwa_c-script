using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;

namespace ActivityNamespace.MapTravel
{
	// Token: 0x02002F60 RID: 12128
	public class MapTravelTabItem : MapTravelTabItemBase
	{
		// Token: 0x0601CB9B RID: 117659 RVA: 0x008C4696 File Offset: 0x008C2896
		[NullableContext(1)]
		public MapTravelTabItem(ActivityMapTravelData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0601CB9C RID: 117660 RVA: 0x008C46A0 File Offset: 0x008C28A0
		[NullableContext(1)]
		public override void RefreshByData(MapTravelAreaData data, int index)
		{
			base.RefreshByData(data, index);
			Area? areaInfo = AreaConfig.Instance.GetAreaInfo(data.AreaId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), areaInfo.Value.Title, Array.Empty<object>());
			bool uiactive = this.ActivityBaseData.IsAreaTaskFinish(data.AreaId);
			bool areaRewardState = this.ActivityBaseData.GetAreaRewardState(data.AreaId);
			base.GetItem(2).SetUIActive(uiactive);
			base.GetItem(3).SetUIActive(!data.IsUnlock);
			base.GetItem(4).SetUIActive(areaRewardState);
		}

		// Token: 0x02008BEF RID: 35823
		private new class ETabComponents
		{
			// Token: 0x0402C53D RID: 181565
			public const int Toggle = 0;

			// Token: 0x0402C53E RID: 181566
			public const int Name = 1;

			// Token: 0x0402C53F RID: 181567
			public const int SpriteDone = 2;

			// Token: 0x0402C540 RID: 181568
			public const int SpriteLock = 3;

			// Token: 0x0402C541 RID: 181569
			public const int RedDot = 4;
		}
	}
}
