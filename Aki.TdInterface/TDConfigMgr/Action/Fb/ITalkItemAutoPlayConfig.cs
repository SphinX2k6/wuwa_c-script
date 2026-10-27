using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200252D RID: 9517
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemAutoPlayConfig
	{
		// Token: 0x0600D42B RID: 54315 RVA: 0x001F6A82 File Offset: 0x001F4C82
		[NullableContext(1)]
		public static ITalkItemAutoPlayConfig Create(ITalkItemAutoPlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemAutoPlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B93 RID: 15251
		// (get) Token: 0x0600D42C RID: 54316 RVA: 0x001F6AA1 File Offset: 0x001F4CA1
		public virtual ITalkItemDisableAutoSelectOptionGroup DisableAutoSelectOptionGroup
		{
			get
			{
				if (this._DisableAutoSelectOptionGroupInited)
				{
					return this._DisableAutoSelectOptionGroupCache;
				}
				this._DisableAutoSelectOptionGroupInited = true;
				this._DisableAutoSelectOptionGroupCache = ITalkItemDisableAutoSelectOptionGroup.Create(this.Instance.DisableAutoSelectOptionGroup);
				return this._DisableAutoSelectOptionGroupCache;
			}
		}

		// Token: 0x04007437 RID: 29751
		private ITalkItemAutoPlayConfig Instance;

		// Token: 0x04007438 RID: 29752
		private ITalkItemDisableAutoSelectOptionGroup _DisableAutoSelectOptionGroupCache;

		// Token: 0x04007439 RID: 29753
		private bool _DisableAutoSelectOptionGroupInited;
	}
}
