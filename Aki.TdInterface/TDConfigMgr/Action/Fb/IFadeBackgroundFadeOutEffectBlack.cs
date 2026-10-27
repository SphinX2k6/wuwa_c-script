using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200268A RID: 9866
	public class IFadeBackgroundFadeOutEffectBlack : IFadeBackgroundFadeOutEffectTypeBase
	{
		// Token: 0x0600DCED RID: 56557 RVA: 0x0020D829 File Offset: 0x0020BA29
		[NullableContext(1)]
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

		// Token: 0x1700419B RID: 16795
		// (get) Token: 0x0600DCEE RID: 56558 RVA: 0x0020D848 File Offset: 0x0020BA48
		public override EFadeBackgroundFadeOutEffectType Type
		{
			get
			{
				return (EFadeBackgroundFadeOutEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700419C RID: 16796
		// (get) Token: 0x0600DCEF RID: 56559 RVA: 0x0020D855 File Offset: 0x0020BA55
		public virtual EFadeInScreenShowType FadeColor
		{
			get
			{
				return (EFadeInScreenShowType)this.Instance.FadeColor;
			}
		}

		// Token: 0x1700419D RID: 16797
		// (get) Token: 0x0600DCF0 RID: 56560 RVA: 0x0020D864 File Offset: 0x0020BA64
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

		// Token: 0x1700419E RID: 16798
		// (get) Token: 0x0600DCF1 RID: 56561 RVA: 0x0020D89C File Offset: 0x0020BA9C
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

		// Token: 0x04007ABE RID: 31422
		private IFadeBackgroundFadeOutEffectBlack Instance;
	}
}
