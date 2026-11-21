using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC6 RID: 3526
	public class IPasserbyNpcExitTimingBase
	{
		// Token: 0x0600500F RID: 20495 RVA: 0x000C6EFE File Offset: 0x000C50FE
		public static IPasserbyNpcExitTimingBase Create(IPasserbyNpcExitTimingBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcExitTimingBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x06005010 RID: 20496 RVA: 0x000C6F1D File Offset: 0x000C511D
		public virtual EPasserbyNpcExitTimingType Type
		{
			get
			{
				return (EPasserbyNpcExitTimingType)this.Instance.Type;
			}
		}

		// Token: 0x04002D9D RID: 11677
		private IPasserbyNpcExitTimingBase Instance;
	}
}
