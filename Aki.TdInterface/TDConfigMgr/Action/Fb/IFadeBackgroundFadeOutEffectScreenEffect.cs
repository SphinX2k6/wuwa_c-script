using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200294E RID: 10574
	public class IFadeBackgroundFadeOutEffectScreenEffect : IFadeBackgroundFadeOutEffectTypeBase
	{
		// Token: 0x0600EACA RID: 60106 RVA: 0x0022A07A File Offset: 0x0022827A
		public static IFadeBackgroundFadeOutEffectScreenEffect Create(IFadeBackgroundFadeOutEffectScreenEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffectScreenEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044DC RID: 17628
		// (get) Token: 0x0600EACB RID: 60107 RVA: 0x0022A099 File Offset: 0x00228299
		public override EFadeBackgroundFadeOutEffectType Type
		{
			get
			{
				return (EFadeBackgroundFadeOutEffectType)this.Instance.Type;
			}
		}

		// Token: 0x170044DD RID: 17629
		// (get) Token: 0x0600EACC RID: 60108 RVA: 0x0022A0A6 File Offset: 0x002282A6
		public virtual string ScreenEffect
		{
			get
			{
				return this.Instance.ScreenEffect;
			}
		}

		// Token: 0x0400815C RID: 33116
		private IFadeBackgroundFadeOutEffectScreenEffect Instance;
	}
}
