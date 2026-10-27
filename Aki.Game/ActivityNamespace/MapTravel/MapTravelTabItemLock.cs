using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;

namespace ActivityNamespace.MapTravel
{
	// Token: 0x020044D4 RID: 17620
	public class MapTravelTabItemLock : MapTravelTabItemBase
	{
		// Token: 0x0602D65F RID: 185951 RVA: 0x00A3EADE File Offset: 0x00A3CCDE
		[NullableContext(1)]
		public MapTravelTabItemLock(ActivityMapTravelData activityBaseData) : base(activityBaseData)
		{
		}

		// Token: 0x0602D660 RID: 185952 RVA: 0x00A3EAE7 File Offset: 0x00A3CCE7
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			base.GetItem(4).SetUIActive(false);
		}

		// Token: 0x0602D661 RID: 185953 RVA: 0x00A3EB10 File Offset: 0x00A3CD10
		[NullableContext(1)]
		public override void RefreshByData(MapTravelAreaData data, int index)
		{
			base.RefreshByData(data, index);
			Area? areaInfo = AreaConfig.Instance.GetAreaInfo(data.AreaId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), areaInfo.Value.Title, Array.Empty<object>());
		}

		// Token: 0x0200A71A RID: 42778
		private new class ETabComponents
		{
			// Token: 0x04032774 RID: 206708
			public const int Toggle = 0;

			// Token: 0x04032775 RID: 206709
			public const int Name = 1;

			// Token: 0x04032776 RID: 206710
			public const int SpriteDone = 2;

			// Token: 0x04032777 RID: 206711
			public const int SpriteLock = 3;

			// Token: 0x04032778 RID: 206712
			public const int RedDot = 4;
		}
	}
}
