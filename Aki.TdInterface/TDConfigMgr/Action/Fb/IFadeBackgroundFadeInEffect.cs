using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002688 RID: 9864
	[NullableContext(1)]
	[Nullable(0)]
	public class IFadeBackgroundFadeInEffect
	{
		// Token: 0x0600DCE7 RID: 56551 RVA: 0x0020D79F File Offset: 0x0020B99F
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

		// Token: 0x17004199 RID: 16793
		// (get) Token: 0x0600DCE8 RID: 56552 RVA: 0x0020D7BE File Offset: 0x0020B9BE
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

		// Token: 0x04007ABA RID: 31418
		private IFadeBackgroundFadeInEffect Instance;

		// Token: 0x04007ABB RID: 31419
		private IFadeBackgroundFadeInEffectTypeBase _FadeInEffectCache;

		// Token: 0x04007ABC RID: 31420
		private bool _FadeInEffectInited;
	}
}
