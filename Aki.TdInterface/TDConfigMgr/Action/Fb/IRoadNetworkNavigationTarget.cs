using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD4 RID: 10964
	public class IRoadNetworkNavigationTarget
	{
		// Token: 0x0600F077 RID: 61559 RVA: 0x0022EAB5 File Offset: 0x0022CCB5
		[NullableContext(1)]
		public static IRoadNetworkNavigationTarget Create(IRoadNetworkNavigationTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoadNetworkNavigationTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C91 RID: 19601
		// (get) Token: 0x0600F078 RID: 61560 RVA: 0x0022EAD4 File Offset: 0x0022CCD4
		public virtual ERoadNetworkNavigationTarget Type
		{
			get
			{
				return (ERoadNetworkNavigationTarget)this.Instance.Type;
			}
		}

		// Token: 0x04008446 RID: 33862
		private IRoadNetworkNavigationTarget Instance;
	}
}
