using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200249C RID: 9372
	public class TCsvTeleportTransitionData
	{
		// Token: 0x0600CBD0 RID: 52176 RVA: 0x001D0C2A File Offset: 0x001CEE2A
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

		// Token: 0x17003D1E RID: 15646
		// (get) Token: 0x0600CBD1 RID: 52177 RVA: 0x001D0C3D File Offset: 0x001CEE3D
		public virtual int Id
		{
			get
			{
				return this.FbInstance.Id;
			}
		}

		// Token: 0x17003D1F RID: 15647
		// (get) Token: 0x0600CBD2 RID: 52178 RVA: 0x001D0C4A File Offset: 0x001CEE4A
		public virtual ITeleportTransitionType Data
		{
			get
			{
				return this.FbInstance.Data;
			}
		}

		// Token: 0x040078D5 RID: 30933
		private TCsvTeleportTransitionData FbInstance;
	}
}
