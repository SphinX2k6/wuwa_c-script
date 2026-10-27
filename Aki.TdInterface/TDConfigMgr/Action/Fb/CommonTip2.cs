using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002763 RID: 10083
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonTip2 : ActionParams
	{
		// Token: 0x0600E0A0 RID: 57504 RVA: 0x0021339B File Offset: 0x0021159B
		public static CommonTip2 Create(ICommonTip2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CommonTip2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700439C RID: 17308
		// (get) Token: 0x0600E0A1 RID: 57505 RVA: 0x002133BA File Offset: 0x002115BA
		public virtual ICommonTip2PrepareCountdown TipOption
		{
			get
			{
				if (this._TipOptionInited)
				{
					return this._TipOptionCache;
				}
				this._TipOptionInited = true;
				this._TipOptionCache = ICommonTip2PrepareCountdown.Create(this.Instance.TipOption);
				return this._TipOptionCache;
			}
		}

		// Token: 0x04007C65 RID: 31845
		private ICommonTip2 Instance;

		// Token: 0x04007C66 RID: 31846
		[Nullable(2)]
		private ICommonTip2PrepareCountdown _TipOptionCache;

		// Token: 0x04007C67 RID: 31847
		private bool _TipOptionInited;
	}
}
