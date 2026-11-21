using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200294D RID: 10573
	public class IFadeBackgroundFadeOutEffectBlack : IFadeBackgroundFadeOutEffectTypeBase
	{
		// Token: 0x0600EAC4 RID: 60100 RVA: 0x00229FC9 File Offset: 0x002281C9
		public static IFadeBackgroundFadeOutEffectBlack Create(IFadeBackgroundFadeOutEffectBlack? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundFadeOutEffectBlack
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044D8 RID: 17624
		// (get) Token: 0x0600EAC5 RID: 60101 RVA: 0x00229FE8 File Offset: 0x002281E8
		public override EFadeBackgroundFadeOutEffectType Type
		{
			get
			{
				return (EFadeBackgroundFadeOutEffectType)this.Instance.Type;
			}
		}

		// Token: 0x170044D9 RID: 17625
		// (get) Token: 0x0600EAC6 RID: 60102 RVA: 0x00229FF5 File Offset: 0x002281F5
		public virtual EFadeInScreenShowType FadeColor
		{
			get
			{
				return (EFadeInScreenShowType)this.Instance.FadeColor;
			}
		}

		// Token: 0x170044DA RID: 17626
		// (get) Token: 0x0600EAC7 RID: 60103 RVA: 0x0022A004 File Offset: 0x00228204
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

		// Token: 0x170044DB RID: 17627
		// (get) Token: 0x0600EAC8 RID: 60104 RVA: 0x0022A03C File Offset: 0x0022823C
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

		// Token: 0x0400815B RID: 33115
		private IFadeBackgroundFadeOutEffectBlack Instance;
	}
}
