using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B6E RID: 11118
	public class TeleportToLatestResetPoint : ActionParams
	{
		// Token: 0x0600F44F RID: 62543 RVA: 0x0023A121 File Offset: 0x00238321
		public static TeleportToLatestResetPoint Create(ITeleportToLatestResetPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TeleportToLatestResetPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A21 RID: 18977
		// (get) Token: 0x0600F450 RID: 62544 RVA: 0x0023A140 File Offset: 0x00238340
		public virtual ITeleportToLatestResetPointDirectly Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = ITeleportToLatestResetPointDirectly.Create(this.Instance.Option);
				return this._OptionCache;
			}
		}

		// Token: 0x040085F8 RID: 34296
		private ITeleportToLatestResetPoint Instance;

		// Token: 0x040085F9 RID: 34297
		[Nullable(2)]
		private ITeleportToLatestResetPointDirectly _OptionCache;

		// Token: 0x040085FA RID: 34298
		private bool _OptionInited;
	}
}
