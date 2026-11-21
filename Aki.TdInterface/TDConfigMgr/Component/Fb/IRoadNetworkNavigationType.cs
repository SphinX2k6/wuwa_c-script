using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EC4 RID: 3780
	public class IRoadNetworkNavigationType
	{
		// Token: 0x06005532 RID: 21810 RVA: 0x000D16C1 File Offset: 0x000CF8C1
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

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06005533 RID: 21811 RVA: 0x000D16E0 File Offset: 0x000CF8E0
		public virtual ERoadNetworkNavigationType Type
		{
			get
			{
				return (ERoadNetworkNavigationType)this.Instance.Type;
			}
		}

		// Token: 0x040030AB RID: 12459
		private IRoadNetworkNavigationType Instance;
	}
}
