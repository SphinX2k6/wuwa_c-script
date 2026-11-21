using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200294B RID: 10571
	public class IFadeBackgroundFadeInEffect
	{
		// Token: 0x0600EABE RID: 60094 RVA: 0x00229F3F File Offset: 0x0022813F
		public static IFadeBackgroundFadeInEffect Create(IFadeBackgroundFadeInEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeInEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044D6 RID: 17622
		// (get) Token: 0x0600EABF RID: 60095 RVA: 0x00229F5E File Offset: 0x0022815E
		public virtual IFadeBackgroundFadeInEffectTypeBase FadeInEffect
		{
			get
			{
				if (this._FadeInEffectInited)
				{
					return this._FadeInEffectCache;
				}
				this._FadeInEffectInited = true;
				this._FadeInEffectCache = ActionReadHelper.ReadIFadeBackgroundFadeInEffect_FadeInEffect(this.Instance);
				return this._FadeInEffectCache;
			}
		}

		// Token: 0x04008157 RID: 33111
		private IFadeBackgroundFadeInEffect Instance;

		// Token: 0x04008158 RID: 33112
		private IFadeBackgroundFadeInEffectTypeBase _FadeInEffectCache;

		// Token: 0x04008159 RID: 33113
		private bool _FadeInEffectInited;
	}
}
