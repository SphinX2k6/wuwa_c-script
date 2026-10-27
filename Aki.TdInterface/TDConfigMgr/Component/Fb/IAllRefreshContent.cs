using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ABE RID: 2750
	[NullableContext(1)]
	[Nullable(0)]
	public class IAllRefreshContent : IRefreshContent
	{
		// Token: 0x06003F5A RID: 16218 RVA: 0x000A1D7F File Offset: 0x0009FF7F
		public static IAllRefreshContent Create(IAllRefreshContent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAllRefreshContent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06003F5B RID: 16219 RVA: 0x000A1D9E File Offset: 0x0009FF9E
		public override ERefreshContent Type
		{
			get
			{
				return (ERefreshContent)this.Instance.Type;
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06003F5C RID: 16220 RVA: 0x000A1DAC File Offset: 0x0009FFAC
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

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06003F5D RID: 16221 RVA: 0x000A1E10 File Offset: 0x000A0010
		public virtual bool? EdEnableSyncCamp
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0400232D RID: 9005
		private IAllRefreshContent Instance;

		// Token: 0x0400232E RID: 9006
		private List<int> _EntityIdsCache;

		// Token: 0x0400232F RID: 9007
		private bool _EntityIdsInited;
	}
}
