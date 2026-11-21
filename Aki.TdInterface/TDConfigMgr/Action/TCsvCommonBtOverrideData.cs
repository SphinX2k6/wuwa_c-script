using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200249B RID: 9371
	public class TCsvCommonBtOverrideData
	{
		// Token: 0x0600CBCC RID: 52172 RVA: 0x001D0BC6 File Offset: 0x001CEDC6
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

		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x0600CBCD RID: 52173 RVA: 0x001D0BD9 File Offset: 0x001CEDD9
		public virtual int Id
		{
			get
			{
				return this.FbInstance.Id;
			}
		}

		// Token: 0x17003D1D RID: 15645
		// (get) Token: 0x0600CBCE RID: 52174 RVA: 0x001D0BE6 File Offset: 0x001CEDE6
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

		// Token: 0x040078D2 RID: 30930
		private TCsvCommonBtOverrideData FbInstance;

		// Token: 0x040078D3 RID: 30931
		private ICommonBtOverride _DataCache;

		// Token: 0x040078D4 RID: 30932
		private bool _DataInited;
	}
}
