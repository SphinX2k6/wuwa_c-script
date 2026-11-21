using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E68 RID: 3688
	public class IRenderStateRadiusConfig
	{
		// Token: 0x0600535C RID: 21340 RVA: 0x000CDACE File Offset: 0x000CBCCE
		public static IRenderStateRadiusConfig Create(IRenderStateRadiusConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderStateRadiusConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x0600535D RID: 21341 RVA: 0x000CDAED File Offset: 0x000CBCED
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x0600535E RID: 21342 RVA: 0x000CDAFA File Offset: 0x000CBCFA
		public virtual float Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x04002FA1 RID: 12193
		private IRenderStateRadiusConfig Instance;
	}
}
