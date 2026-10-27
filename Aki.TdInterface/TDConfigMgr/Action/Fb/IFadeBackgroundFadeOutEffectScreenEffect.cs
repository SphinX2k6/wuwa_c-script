using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200268B RID: 9867
	[NullableContext(1)]
	[Nullable(0)]
	public class IFadeBackgroundFadeOutEffectScreenEffect : IFadeBackgroundFadeOutEffectTypeBase
	{
		// Token: 0x0600DCF3 RID: 56563 RVA: 0x0020D8DA File Offset: 0x0020BADA
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

		// Token: 0x1700419F RID: 16799
		// (get) Token: 0x0600DCF4 RID: 56564 RVA: 0x0020D8F9 File Offset: 0x0020BAF9
		public override EFadeBackgroundFadeOutEffectType Type
		{
			get
			{
				return (EFadeBackgroundFadeOutEffectType)this.Instance.Type;
			}
		}

		// Token: 0x170041A0 RID: 16800
		// (get) Token: 0x0600DCF5 RID: 56565 RVA: 0x0020D906 File Offset: 0x0020BB06
		public virtual string ScreenEffect
		{
			get
			{
				return this.Instance.ScreenEffect;
			}
		}

		// Token: 0x04007ABF RID: 31423
		private IFadeBackgroundFadeOutEffectScreenEffect Instance;
	}
}
