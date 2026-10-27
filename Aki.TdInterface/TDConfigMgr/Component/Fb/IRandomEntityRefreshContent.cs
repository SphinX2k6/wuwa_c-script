using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ABF RID: 2751
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomEntityRefreshContent : IRefreshContent
	{
		// Token: 0x06003F5F RID: 16223 RVA: 0x000A1E2E File Offset: 0x000A002E
		public static IRandomEntityRefreshContent Create(IRandomEntityRefreshContent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomEntityRefreshContent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06003F60 RID: 16224 RVA: 0x000A1E4D File Offset: 0x000A004D
		public override ERefreshContent Type
		{
			get
			{
				return (ERefreshContent)this.Instance.Type;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06003F61 RID: 16225 RVA: 0x000A1E5C File Offset: 0x000A005C
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06003F62 RID: 16226 RVA: 0x000A1EC0 File Offset: 0x000A00C0
		public virtual bool? EdEnableSyncCamp
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04002330 RID: 9008
		private IRandomEntityRefreshContent Instance;

		// Token: 0x04002331 RID: 9009
		private List<int> _EntityIdsCache;

		// Token: 0x04002332 RID: 9010
		private bool _EntityIdsInited;
	}
}
