using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002686 RID: 9862
	public class IFadeBackgroundFadeInEffectBlack : IFadeBackgroundFadeInEffectTypeBase
	{
		// Token: 0x0600DCDD RID: 56541 RVA: 0x0020D6AD File Offset: 0x0020B8AD
		[NullableContext(1)]
		public static IFadeBackgroundFadeInEffectBlack Create(IFadeBackgroundFadeInEffectBlack? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeInEffectBlack
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004193 RID: 16787
		// (get) Token: 0x0600DCDE RID: 56542 RVA: 0x0020D6CC File Offset: 0x0020B8CC
		public override EFadeBackgroundFadeInEffectType Type
		{
			get
			{
				return (EFadeBackgroundFadeInEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004194 RID: 16788
		// (get) Token: 0x0600DCDF RID: 56543 RVA: 0x0020D6D9 File Offset: 0x0020B8D9
		public virtual EFadeInScreenShowType FadeColor
		{
			get
			{
				return (EFadeInScreenShowType)this.Instance.FadeColor;
			}
		}

		// Token: 0x17004195 RID: 16789
		// (get) Token: 0x0600DCE0 RID: 56544 RVA: 0x0020D6E8 File Offset: 0x0020B8E8
		public virtual float? FadeInTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.FadeInTime);
			}
		}

		// Token: 0x17004196 RID: 16790
		// (get) Token: 0x0600DCE1 RID: 56545 RVA: 0x0020D720 File Offset: 0x0020B920
		public virtual float? FadeOutTime
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.FadeOutTime);
			}
		}

		// Token: 0x04007AB8 RID: 31416
		private IFadeBackgroundFadeInEffectBlack Instance;
	}
}
