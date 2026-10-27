using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008B9 RID: 2233
	[NullableContext(1)]
	[Nullable(0)]
	public class TComponentData
	{
		// Token: 0x0600322F RID: 12847 RVA: 0x00080AEC File Offset: 0x0007ECEC
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

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06003230 RID: 12848 RVA: 0x00080AFF File Offset: 0x0007ECFF
		public virtual string Key
		{
			get
			{
				return this.FbInstance.Key;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06003231 RID: 12849 RVA: 0x00080B0C File Offset: 0x0007ED0C
		public virtual IComponentBase Value
		{
			get
			{
				return this.FbInstance.Value;
			}
		}

		// Token: 0x040020E5 RID: 8421
		private TComponentData FbInstance;
	}
}
