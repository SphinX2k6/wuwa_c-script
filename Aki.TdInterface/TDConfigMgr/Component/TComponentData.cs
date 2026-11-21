using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200095C RID: 2396
	public class TComponentData
	{
		// Token: 0x0600356B RID: 13675 RVA: 0x00087FD4 File Offset: 0x000861D4
		public static TComponentData Create([Nullable(2)] TComponentData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TComponentData
			{
				FbInstance = instance
			};
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x00087FE7 File Offset: 0x000861E7
		public virtual string Key
		{
			get
			{
				return this.FbInstance.Key;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x0600356D RID: 13677 RVA: 0x00087FF4 File Offset: 0x000861F4
		public virtual IComponentBase Value
		{
			get
			{
				return this.FbInstance.Value;
			}
		}

		// Token: 0x040022F7 RID: 8951
		private TComponentData FbInstance;
	}
}
