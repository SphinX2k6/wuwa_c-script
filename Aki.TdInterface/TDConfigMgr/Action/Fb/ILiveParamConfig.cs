using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E22 RID: 11810
	public class ILiveParamConfig
	{
		// Token: 0x0601007F RID: 65663 RVA: 0x0024E618 File Offset: 0x0024C818
		public static ILiveParamConfig Create(ILiveParamConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveParamConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050E9 RID: 20713
		// (get) Token: 0x06010080 RID: 65664 RVA: 0x0024E637 File Offset: 0x0024C837
		public virtual ELiveParamType Type
		{
			get
			{
				return (ELiveParamType)this.Instance.Type;
			}
		}

		// Token: 0x04008BF0 RID: 35824
		private ILiveParamConfig Instance;
	}
}
