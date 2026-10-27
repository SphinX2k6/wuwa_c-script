using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002133 RID: 8499
	[NullableContext(1)]
	[Nullable(0)]
	public class Record_Int_IFlowTextConfig
	{
		// Token: 0x0600BB34 RID: 47924 RVA: 0x001B06B6 File Offset: 0x001AE8B6
		public static Record_Int_IFlowTextConfig Create([Nullable(2)] Record_Int_IFlowTextConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Record_Int_IFlowTextConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x0600BB35 RID: 47925 RVA: 0x001B06C9 File Offset: 0x001AE8C9
		public virtual int Key
		{
			get
			{
				return this.FbInstance.Key;
			}
		}

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x0600BB36 RID: 47926 RVA: 0x001B06D6 File Offset: 0x001AE8D6
		public virtual IFlowTextConfig Value
		{
			get
			{
				if (this._ValueInited)
				{
					return this._ValueCache;
				}
				this._ValueInited = true;
				if (this.FbInstance != null)
				{
					this._ValueCache = IFlowTextConfig.Create(this.FbInstance.Value);
				}
				return this._ValueCache;
			}
		}

		// Token: 0x04006FFC RID: 28668
		private Record_Int_IFlowTextConfig FbInstance;

		// Token: 0x04006FFD RID: 28669
		private IFlowTextConfig _ValueCache;

		// Token: 0x04006FFE RID: 28670
		private bool _ValueInited;
	}
}
