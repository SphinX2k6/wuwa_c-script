using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BF0 RID: 3056
	public class IAudioPointNearbyTracking : INearbyTracking
	{
		// Token: 0x06004630 RID: 17968 RVA: 0x000B16B6 File Offset: 0x000AF8B6
		[NullableContext(1)]
		public static IAudioPointNearbyTracking Create(IAudioPointNearbyTracking? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioPointNearbyTracking
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x06004631 RID: 17969 RVA: 0x000B16D5 File Offset: 0x000AF8D5
		public override ENearbyTrackingType Type
		{
			get
			{
				return (ENearbyTrackingType)this.Instance.Type;
			}
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x06004632 RID: 17970 RVA: 0x000B16E2 File Offset: 0x000AF8E2
		public virtual int NearRadius
		{
			get
			{
				return this.Instance.NearRadius;
			}
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x06004633 RID: 17971 RVA: 0x000B16EF File Offset: 0x000AF8EF
		public virtual int MiddleRadius
		{
			get
			{
				return this.Instance.MiddleRadius;
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06004634 RID: 17972 RVA: 0x000B16FC File Offset: 0x000AF8FC
		public virtual int FarRadius
		{
			get
			{
				return this.Instance.FarRadius;
			}
		}

		// Token: 0x040027F9 RID: 10233
		private IAudioPointNearbyTracking Instance;
	}
}
