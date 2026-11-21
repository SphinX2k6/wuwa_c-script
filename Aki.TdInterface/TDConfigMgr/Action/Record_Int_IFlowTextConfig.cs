using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002394 RID: 9108
	public class Record_Int_IFlowTextConfig
	{
		// Token: 0x0600C6C2 RID: 50882 RVA: 0x001C786A File Offset: 0x001C5A6A
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

		// Token: 0x17003C14 RID: 15380
		// (get) Token: 0x0600C6C3 RID: 50883 RVA: 0x001C787D File Offset: 0x001C5A7D
		public virtual int Key
		{
			get
			{
				return this.FbInstance.Key;
			}
		}

		// Token: 0x17003C15 RID: 15381
		// (get) Token: 0x0600C6C4 RID: 50884 RVA: 0x001C788A File Offset: 0x001C5A8A
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

		// Token: 0x04007631 RID: 30257
		private Record_Int_IFlowTextConfig FbInstance;

		// Token: 0x04007632 RID: 30258
		private IFlowTextConfig _ValueCache;

		// Token: 0x04007633 RID: 30259
		private bool _ValueInited;
	}
}
