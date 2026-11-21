using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB3 RID: 3507
	public class IFanStateEffect
	{
		// Token: 0x06004FAF RID: 20399 RVA: 0x000C63B7 File Offset: 0x000C45B7
		public static IFanStateEffect Create(IFanStateEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFanStateEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06004FB0 RID: 20400 RVA: 0x000C63D6 File Offset: 0x000C45D6
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06004FB1 RID: 20401 RVA: 0x000C63E3 File Offset: 0x000C45E3
		public virtual IFanEffectConfig EffectConfig
		{
			get
			{
				if (this._EffectConfigInited)
				{
					return this._EffectConfigCache;
				}
				this._EffectConfigInited = true;
				this._EffectConfigCache = IFanEffectConfig.Create(this.Instance.EffectConfig);
				return this._EffectConfigCache;
			}
		}

		// Token: 0x04002D6A RID: 11626
		private IFanStateEffect Instance;

		// Token: 0x04002D6B RID: 11627
		[Nullable(2)]
		private IFanEffectConfig _EffectConfigCache;

		// Token: 0x04002D6C RID: 11628
		private bool _EffectConfigInited;
	}
}
