using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D91 RID: 11665
	public class OverrideAbpAnimScheme : ActionParams
	{
		// Token: 0x0600FE4E RID: 65102 RVA: 0x0024B039 File Offset: 0x00249239
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

		// Token: 0x17004FDA RID: 20442
		// (get) Token: 0x0600FE4F RID: 65103 RVA: 0x0024B058 File Offset: 0x00249258
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

		// Token: 0x04008ACD RID: 35533
		private IOverrideAbpAnimScheme Instance;

		// Token: 0x04008ACE RID: 35534
		private List<IOverrideAbpAnimSchemeConfig> _OverrideConfigsCache;

		// Token: 0x04008ACF RID: 35535
		private bool _OverrideConfigsInited;
	}
}
