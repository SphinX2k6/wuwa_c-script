using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B5F RID: 11103
	public class IMontageRegistered : IMontageConfig
	{
		// Token: 0x0600F416 RID: 62486 RVA: 0x00239AC4 File Offset: 0x00237CC4
		public static IMontageRegistered Create(IMontageRegistered? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageRegistered
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A06 RID: 18950
		// (get) Token: 0x0600F417 RID: 62487 RVA: 0x00239AE3 File Offset: 0x00237CE3
		public override EMontageConfigType Type
		{
			get
			{
				return (EMontageConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004A07 RID: 18951
		// (get) Token: 0x0600F418 RID: 62488 RVA: 0x00239AF0 File Offset: 0x00237CF0
		public virtual IMontageId MontageId
		{
			get
			{
				if (this._MontageIdInited)
				{
					return this._MontageIdCache;
				}
				this._MontageIdInited = true;
				this._MontageIdCache = IMontageId.Create(this.Instance.MontageId);
				return this._MontageIdCache;
			}
		}

		// Token: 0x040085D9 RID: 34265
		private IMontageRegistered Instance;

		// Token: 0x040085DA RID: 34266
		[Nullable(2)]
		private IMontageId _MontageIdCache;

		// Token: 0x040085DB RID: 34267
		private bool _MontageIdInited;
	}
}
