using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200294A RID: 10570
	public class IFadeBackgroundFadeInEffectScreenEffect : IFadeBackgroundFadeInEffectTypeBase
	{
		// Token: 0x0600EABA RID: 60090 RVA: 0x00229EFE File Offset: 0x002280FE
		public static IFadeBackgroundFadeInEffectScreenEffect Create(IFadeBackgroundFadeInEffectScreenEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeInEffectScreenEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044D4 RID: 17620
		// (get) Token: 0x0600EABB RID: 60091 RVA: 0x00229F1D File Offset: 0x0022811D
		public override EFadeBackgroundFadeInEffectType Type
		{
			get
			{
				return (EFadeBackgroundFadeInEffectType)this.Instance.Type;
			}
		}

		// Token: 0x170044D5 RID: 17621
		// (get) Token: 0x0600EABC RID: 60092 RVA: 0x00229F2A File Offset: 0x0022812A
		public virtual string ScreenEffect
		{
			get
			{
				return this.Instance.ScreenEffect;
			}
		}

		// Token: 0x04008156 RID: 33110
		private IFadeBackgroundFadeInEffectScreenEffect Instance;
	}
}
