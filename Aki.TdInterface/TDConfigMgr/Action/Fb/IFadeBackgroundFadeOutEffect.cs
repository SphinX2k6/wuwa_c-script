using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200294F RID: 10575
	public class IFadeBackgroundFadeOutEffect
	{
		// Token: 0x0600EACE RID: 60110 RVA: 0x0022A0BB File Offset: 0x002282BB
		public static IFadeBackgroundFadeOutEffect Create(IFadeBackgroundFadeOutEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044DE RID: 17630
		// (get) Token: 0x0600EACF RID: 60111 RVA: 0x0022A0DA File Offset: 0x002282DA
		public virtual IFadeBackgroundFadeOutEffectTypeBase FadeOutEffect
		{
			get
			{
				if (this._FadeOutEffectInited)
				{
					return this._FadeOutEffectCache;
				}
				this._FadeOutEffectInited = true;
				this._FadeOutEffectCache = ActionReadHelper.ReadIFadeBackgroundFadeOutEffect_FadeOutEffect(this.Instance);
				return this._FadeOutEffectCache;
			}
		}

		// Token: 0x0400815D RID: 33117
		private IFadeBackgroundFadeOutEffect Instance;

		// Token: 0x0400815E RID: 33118
		private IFadeBackgroundFadeOutEffectTypeBase _FadeOutEffectCache;

		// Token: 0x0400815F RID: 33119
		private bool _FadeOutEffectInited;
	}
}
