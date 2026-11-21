using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CBF RID: 3263
	public class IAudioPointNearbyTracking : INearbyTracking
	{
		// Token: 0x06004A8E RID: 19086 RVA: 0x000BB832 File Offset: 0x000B9A32
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

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x06004A8F RID: 19087 RVA: 0x000BB851 File Offset: 0x000B9A51
		public override ENearbyTrackingType Type
		{
			get
			{
				return (ENearbyTrackingType)this.Instance.Type;
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06004A90 RID: 19088 RVA: 0x000BB85E File Offset: 0x000B9A5E
		public virtual int NearRadius
		{
			get
			{
				return this.Instance.NearRadius;
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x06004A91 RID: 19089 RVA: 0x000BB86B File Offset: 0x000B9A6B
		public virtual int MiddleRadius
		{
			get
			{
				return this.Instance.MiddleRadius;
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06004A92 RID: 19090 RVA: 0x000BB878 File Offset: 0x000B9A78
		public virtual int FarRadius
		{
			get
			{
				return this.Instance.FarRadius;
			}
		}

		// Token: 0x04002A44 RID: 10820
		private IAudioPointNearbyTracking Instance;
	}
}
