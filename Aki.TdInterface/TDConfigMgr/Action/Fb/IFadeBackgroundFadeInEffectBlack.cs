using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002949 RID: 10569
	public class IFadeBackgroundFadeInEffectBlack : IFadeBackgroundFadeInEffectTypeBase
	{
		// Token: 0x0600EAB4 RID: 60084 RVA: 0x00229E4D File Offset: 0x0022804D
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

		// Token: 0x170044D0 RID: 17616
		// (get) Token: 0x0600EAB5 RID: 60085 RVA: 0x00229E6C File Offset: 0x0022806C
		public override EFadeBackgroundFadeInEffectType Type
		{
			get
			{
				return (EFadeBackgroundFadeInEffectType)this.Instance.Type;
			}
		}

		// Token: 0x170044D1 RID: 17617
		// (get) Token: 0x0600EAB6 RID: 60086 RVA: 0x00229E79 File Offset: 0x00228079
		public virtual EFadeInScreenShowType FadeColor
		{
			get
			{
				return (EFadeInScreenShowType)this.Instance.FadeColor;
			}
		}

		// Token: 0x170044D2 RID: 17618
		// (get) Token: 0x0600EAB7 RID: 60087 RVA: 0x00229E88 File Offset: 0x00228088
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

		// Token: 0x170044D3 RID: 17619
		// (get) Token: 0x0600EAB8 RID: 60088 RVA: 0x00229EC0 File Offset: 0x002280C0
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

		// Token: 0x04008155 RID: 33109
		private IFadeBackgroundFadeInEffectBlack Instance;
	}
}
