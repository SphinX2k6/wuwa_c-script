using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E33 RID: 11827
	public class TCsvCommonBtOverrideData
	{
		// Token: 0x060100BD RID: 65725 RVA: 0x0024EC13 File Offset: 0x0024CE13
		public static TCsvCommonBtOverrideData Create(TCsvCommonBtOverrideData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TCsvCommonBtOverrideData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005105 RID: 20741
		// (get) Token: 0x060100BE RID: 65726 RVA: 0x0024EC32 File Offset: 0x0024CE32
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17005106 RID: 20742
		// (get) Token: 0x060100BF RID: 65727 RVA: 0x0024EC3F File Offset: 0x0024CE3F
		public virtual ICommonBtOverride Data
		{
			get
			{
				if (this._DataInited)
				{
					return this._DataCache;
				}
				this._DataInited = true;
				this._DataCache = ICommonBtOverride.Create(this.Instance.Data);
				return this._DataCache;
			}
		}

		// Token: 0x04008C11 RID: 35857
		private TCsvCommonBtOverrideData Instance;

		// Token: 0x04008C12 RID: 35858
		[Nullable(2)]
		private ICommonBtOverride _DataCache;

		// Token: 0x04008C13 RID: 35859
		private bool _DataInited;
	}
}
