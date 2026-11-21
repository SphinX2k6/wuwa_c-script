using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E24 RID: 11812
	public class ILiveDanmakuIntervalParam : ILiveParamConfig
	{
		// Token: 0x06010087 RID: 65671 RVA: 0x0024E69A File Offset: 0x0024C89A
		public static ILiveDanmakuIntervalParam Create(ILiveDanmakuIntervalParam? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveDanmakuIntervalParam
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050ED RID: 20717
		// (get) Token: 0x06010088 RID: 65672 RVA: 0x0024E6B9 File Offset: 0x0024C8B9
		public override ELiveParamType Type
		{
			get
			{
				return (ELiveParamType)this.Instance.Type;
			}
		}

		// Token: 0x170050EE RID: 20718
		// (get) Token: 0x06010089 RID: 65673 RVA: 0x0024E6C6 File Offset: 0x0024C8C6
		public virtual float SendInterval
		{
			get
			{
				return this.Instance.SendInterval;
			}
		}

		// Token: 0x04008BF2 RID: 35826
		private ILiveDanmakuIntervalParam Instance;
	}
}
