using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A9D RID: 10909
	[NullableContext(1)]
	[Nullable(0)]
	public class OverrideAbpAnimScheme : ActionParams
	{
		// Token: 0x0600EF98 RID: 61336 RVA: 0x0022D32D File Offset: 0x0022B52D
		public static OverrideAbpAnimScheme Create(IOverrideAbpAnimScheme? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new OverrideAbpAnimScheme
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C20 RID: 19488
		// (get) Token: 0x0600EF99 RID: 61337 RVA: 0x0022D34C File Offset: 0x0022B54C
		public virtual List<IOverrideAbpAnimSchemeConfig> OverrideConfigs
		{
			get
			{
				if (this._OverrideConfigsInited)
				{
					return this._OverrideConfigsCache;
				}
				this._OverrideConfigsInited = true;
				int overrideConfigsLength = this.Instance.OverrideConfigsLength;
				this._OverrideConfigsCache = new List<IOverrideAbpAnimSchemeConfig>(overrideConfigsLength);
				for (int i = 0; i < overrideConfigsLength; i++)
				{
					this._OverrideConfigsCache.Add(IOverrideAbpAnimSchemeConfig.Create(this.Instance.OverrideConfigs(i)));
				}
				return this._OverrideConfigsCache;
			}
		}

		// Token: 0x040083C9 RID: 33737
		private IOverrideAbpAnimScheme Instance;

		// Token: 0x040083CA RID: 33738
		private List<IOverrideAbpAnimSchemeConfig> _OverrideConfigsCache;

		// Token: 0x040083CB RID: 33739
		private bool _OverrideConfigsInited;
	}
}
