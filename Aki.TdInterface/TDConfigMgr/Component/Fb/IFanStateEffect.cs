using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CCF RID: 3279
	[NullableContext(1)]
	[Nullable(0)]
	public class IFanStateEffect
	{
		// Token: 0x06004AF4 RID: 19188 RVA: 0x000BB77F File Offset: 0x000B997F
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

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x06004AF5 RID: 19189 RVA: 0x000BB79E File Offset: 0x000B999E
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x000BB7AB File Offset: 0x000B99AB
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

		// Token: 0x04002AE4 RID: 10980
		private IFanStateEffect Instance;

		// Token: 0x04002AE5 RID: 10981
		[Nullable(2)]
		private IFanEffectConfig _EffectConfigCache;

		// Token: 0x04002AE6 RID: 10982
		private bool _EffectConfigInited;
	}
}
