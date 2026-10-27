using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002899 RID: 10393
	[NullableContext(1)]
	[Nullable(0)]
	public class TeleportToLatestResetPoint : ActionParams
	{
		// Token: 0x0600E620 RID: 58912 RVA: 0x0021D1A1 File Offset: 0x0021B3A1
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

		// Token: 0x170046B0 RID: 18096
		// (get) Token: 0x0600E621 RID: 58913 RVA: 0x0021D1C0 File Offset: 0x0021B3C0
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

		// Token: 0x04007F39 RID: 32569
		private ITeleportToLatestResetPoint Instance;

		// Token: 0x04007F3A RID: 32570
		[Nullable(2)]
		private ITeleportToLatestResetPointDirectly _OptionCache;

		// Token: 0x04007F3B RID: 32571
		private bool _OptionInited;
	}
}
