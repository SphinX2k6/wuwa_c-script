using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002230 RID: 8752
	[NullableContext(1)]
	[Nullable(0)]
	public class TCsvCommonBtOverrideData
	{
		// Token: 0x0600C00E RID: 49166 RVA: 0x001B94FA File Offset: 0x001B76FA
		public static TCsvCommonBtOverrideData Create([Nullable(2)] TCsvCommonBtOverrideData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TCsvCommonBtOverrideData
			{
				FbInstance = instance
			};
		}

		// Token: 0x17003A26 RID: 14886
		// (get) Token: 0x0600C00F RID: 49167 RVA: 0x001B950D File Offset: 0x001B770D
		public virtual int Id
		{
			get
			{
				return this.FbInstance.Id;
			}
		}

		// Token: 0x17003A27 RID: 14887
		// (get) Token: 0x0600C010 RID: 49168 RVA: 0x001B951A File Offset: 0x001B771A
		public virtual ICommonBtOverride Data
		{
			get
			{
				if (this._DataInited)
				{
					return this._DataCache;
				}
				this._DataInited = true;
				if (this.FbInstance != null)
				{
					this._DataCache = ICommonBtOverride.Create(this.FbInstance.Data);
				}
				return this._DataCache;
			}
		}

		// Token: 0x04007288 RID: 29320
		private TCsvCommonBtOverrideData FbInstance;

		// Token: 0x04007289 RID: 29321
		private ICommonBtOverride _DataCache;

		// Token: 0x0400728A RID: 29322
		private bool _DataInited;
	}
}
