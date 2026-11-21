using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E20 RID: 11808
	public class ILiveStopInteractDanmakuConfig : ILiveDanmakuOperation
	{
		// Token: 0x06010078 RID: 65656 RVA: 0x0024E581 File Offset: 0x0024C781
		public static ILiveStopInteractDanmakuConfig Create(ILiveStopInteractDanmakuConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveStopInteractDanmakuConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050E6 RID: 20710
		// (get) Token: 0x06010079 RID: 65657 RVA: 0x0024E5A0 File Offset: 0x0024C7A0
		public override ELiveDanmakuOperationType Type
		{
			get
			{
				return (ELiveDanmakuOperationType)this.Instance.Type;
			}
		}

		// Token: 0x170050E7 RID: 20711
		// (get) Token: 0x0601007A RID: 65658 RVA: 0x0024E5AD File Offset: 0x0024C7AD
		public virtual ELiveDanmakuClearType ClearType
		{
			get
			{
				return (ELiveDanmakuClearType)this.Instance.ClearType;
			}
		}

		// Token: 0x04008BEC RID: 35820
		private ILiveStopInteractDanmakuConfig Instance;
	}
}
