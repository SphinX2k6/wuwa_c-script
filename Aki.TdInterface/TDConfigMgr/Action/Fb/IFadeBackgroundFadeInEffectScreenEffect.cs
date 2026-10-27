using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002687 RID: 9863
	[NullableContext(1)]
	[Nullable(0)]
	public class IFadeBackgroundFadeInEffectScreenEffect : IFadeBackgroundFadeInEffectTypeBase
	{
		// Token: 0x0600DCE3 RID: 56547 RVA: 0x0020D75E File Offset: 0x0020B95E
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

		// Token: 0x17004197 RID: 16791
		// (get) Token: 0x0600DCE4 RID: 56548 RVA: 0x0020D77D File Offset: 0x0020B97D
		public override EFadeBackgroundFadeInEffectType Type
		{
			get
			{
				return (EFadeBackgroundFadeInEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004198 RID: 16792
		// (get) Token: 0x0600DCE5 RID: 56549 RVA: 0x0020D78A File Offset: 0x0020B98A
		public virtual string ScreenEffect
		{
			get
			{
				return this.Instance.ScreenEffect;
			}
		}

		// Token: 0x04007AB9 RID: 31417
		private IFadeBackgroundFadeInEffectScreenEffect Instance;
	}
}
