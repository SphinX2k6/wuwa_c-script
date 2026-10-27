using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002231 RID: 8753
	[NullableContext(1)]
	[Nullable(0)]
	public class TCsvTeleportTransitionData
	{
		// Token: 0x0600C012 RID: 49170 RVA: 0x001B955E File Offset: 0x001B775E
		public static TCsvTeleportTransitionData Create([Nullable(2)] TCsvTeleportTransitionData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TCsvTeleportTransitionData
			{
				FbInstance = instance
			};
		}

		// Token: 0x17003A28 RID: 14888
		// (get) Token: 0x0600C013 RID: 49171 RVA: 0x001B9571 File Offset: 0x001B7771
		public virtual int Id
		{
			get
			{
				return this.FbInstance.Id;
			}
		}

		// Token: 0x17003A29 RID: 14889
		// (get) Token: 0x0600C014 RID: 49172 RVA: 0x001B957E File Offset: 0x001B777E
		public virtual ITeleportTransitionType Data
		{
			get
			{
				return this.FbInstance.Data;
			}
		}

		// Token: 0x0400728B RID: 29323
		private TCsvTeleportTransitionData FbInstance;
	}
}
