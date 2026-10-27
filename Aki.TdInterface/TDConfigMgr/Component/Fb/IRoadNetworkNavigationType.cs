using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC8 RID: 3528
	public class IRoadNetworkNavigationType
	{
		// Token: 0x0600500D RID: 20493 RVA: 0x000C5E71 File Offset: 0x000C4071
		[NullableContext(1)]
		public static IRoadNetworkNavigationType Create(IRoadNetworkNavigationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoadNetworkNavigationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x0600500E RID: 20494 RVA: 0x000C5E90 File Offset: 0x000C4090
		public virtual ERoadNetworkNavigationType Type
		{
			get
			{
				return (ERoadNetworkNavigationType)this.Instance.Type;
			}
		}

		// Token: 0x04002DE5 RID: 11749
		private IRoadNetworkNavigationType Instance;
	}
}
