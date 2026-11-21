using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A35 RID: 10805
	public class CommonTip2 : ActionParams
	{
		// Token: 0x0600EEBE RID: 61118 RVA: 0x0023012F File Offset: 0x0022E32F
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

		// Token: 0x17004702 RID: 18178
		// (get) Token: 0x0600EEBF RID: 61119 RVA: 0x0023014E File Offset: 0x0022E34E
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

		// Token: 0x0400831B RID: 33563
		private ICommonTip2 Instance;

		// Token: 0x0400831C RID: 33564
		[Nullable(2)]
		private ICommonTip2PrepareCountdown _TipOptionCache;

		// Token: 0x0400831D RID: 33565
		private bool _TipOptionInited;
	}
}
