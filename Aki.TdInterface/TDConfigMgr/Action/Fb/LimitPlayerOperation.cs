using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C8 RID: 10184
	[NullableContext(1)]
	[Nullable(0)]
	public class LimitPlayerOperation : ActionParams
	{
		// Token: 0x0600E278 RID: 57976 RVA: 0x002171FA File Offset: 0x002153FA
		public static LimitPlayerOperation Create(ILimitPlayerOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LimitPlayerOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044AA RID: 17578
		// (get) Token: 0x0600E279 RID: 57977 RVA: 0x00217219 File Offset: 0x00215419
		public virtual ILimitPlayerOption Type
		{
			get
			{
				if (this._TypeInited)
				{
					return this._TypeCache;
				}
				this._TypeInited = true;
				this._TypeCache = ActionReadHelper.ReadLimitPlayerOperation_Type(this.Instance);
				return this._TypeCache;
			}
		}

		// Token: 0x04007D98 RID: 32152
		private ILimitPlayerOperation Instance;

		// Token: 0x04007D99 RID: 32153
		private ILimitPlayerOption _TypeCache;

		// Token: 0x04007D9A RID: 32154
		private bool _TypeInited;
	}
}
