using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200268C RID: 9868
	[NullableContext(1)]
	[Nullable(0)]
	public class IFadeBackgroundFadeOutEffect
	{
		// Token: 0x0600DCF7 RID: 56567 RVA: 0x0020D91B File Offset: 0x0020BB1B
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

		// Token: 0x170041A1 RID: 16801
		// (get) Token: 0x0600DCF8 RID: 56568 RVA: 0x0020D93A File Offset: 0x0020BB3A
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

		// Token: 0x04007AC0 RID: 31424
		private IFadeBackgroundFadeOutEffect Instance;

		// Token: 0x04007AC1 RID: 31425
		private IFadeBackgroundFadeOutEffectTypeBase _FadeOutEffectCache;

		// Token: 0x04007AC2 RID: 31426
		private bool _FadeOutEffectInited;
	}
}
