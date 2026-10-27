using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A21 RID: 10785
	public class IBvbPlayerOperationType
	{
		// Token: 0x0600EDB3 RID: 60851 RVA: 0x0022A34A File Offset: 0x0022854A
		[NullableContext(1)]
		public static IBvbPlayerOperationType Create(IBvbPlayerOperationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbPlayerOperationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B33 RID: 19251
		// (get) Token: 0x0600EDB4 RID: 60852 RVA: 0x0022A369 File Offset: 0x00228569
		public virtual EBvbPlayerOperationType Type
		{
			get
			{
				return (EBvbPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x040082D7 RID: 33495
		private IBvbPlayerOperationType Instance;
	}
}
