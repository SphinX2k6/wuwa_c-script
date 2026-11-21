using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BCD RID: 11213
	public class IPetalFlyConfig : ISportConfig
	{
		// Token: 0x0600F727 RID: 63271 RVA: 0x0023FC5F File Offset: 0x0023DE5F
		public static IPetalFlyConfig Create(IPetalFlyConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalFlyConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C3B RID: 19515
		// (get) Token: 0x0600F728 RID: 63272 RVA: 0x0023FC7E File Offset: 0x0023DE7E
		public override ESportStateType Type
		{
			get
			{
				return (ESportStateType)this.Instance.Type;
			}
		}

		// Token: 0x04008755 RID: 34645
		private IPetalFlyConfig Instance;
	}
}
