using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E25 RID: 11813
	public class ILiveDanmakuTrackCountParam : ILiveParamConfig
	{
		// Token: 0x0601008B RID: 65675 RVA: 0x0024E6DB File Offset: 0x0024C8DB
		public static ILiveDanmakuTrackCountParam Create(ILiveDanmakuTrackCountParam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveDanmakuTrackCountParam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050EF RID: 20719
		// (get) Token: 0x0601008C RID: 65676 RVA: 0x0024E6FA File Offset: 0x0024C8FA
		public override ELiveParamType Type
		{
			get
			{
				return (ELiveParamType)this.Instance.Type;
			}
		}

		// Token: 0x170050F0 RID: 20720
		// (get) Token: 0x0601008D RID: 65677 RVA: 0x0024E707 File Offset: 0x0024C907
		public virtual int TrackCount
		{
			get
			{
				return this.Instance.TrackCount;
			}
		}

		// Token: 0x04008BF3 RID: 35827
		private ILiveDanmakuTrackCountParam Instance;
	}
}
