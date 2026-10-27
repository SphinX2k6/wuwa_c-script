using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;

namespace ActivityNamespace.MapTravel
{
	// Token: 0x020044D3 RID: 17619
	public class MapTravelTabItem : MapTravelTabItemBase
	{
		// Token: 0x0602D65D RID: 185949 RVA: 0x00A3EA36 File Offset: 0x00A3CC36
		[NullableContext(1)]
		public MapTravelTabItem(ActivityMapTravelData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0602D65E RID: 185950 RVA: 0x00A3EA40 File Offset: 0x00A3CC40
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

		// Token: 0x0200A719 RID: 42777
		private new class ETabComponents
		{
			// Token: 0x0403276F RID: 206703
			public const int Toggle = 0;

			// Token: 0x04032770 RID: 206704
			public const int Name = 1;

			// Token: 0x04032771 RID: 206705
			public const int SpriteDone = 2;

			// Token: 0x04032772 RID: 206706
			public const int SpriteLock = 3;

			// Token: 0x04032773 RID: 206707
			public const int RedDot = 4;
		}
	}
}
