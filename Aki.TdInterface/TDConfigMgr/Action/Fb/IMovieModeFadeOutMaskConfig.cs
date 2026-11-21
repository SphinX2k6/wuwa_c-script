using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DC2 RID: 11714
	public class IMovieModeFadeOutMaskConfig
	{
		// Token: 0x0600FF13 RID: 65299 RVA: 0x0024C48E File Offset: 0x0024A68E
		public static IMovieModeFadeOutMaskConfig Create(IMovieModeFadeOutMaskConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovieModeFadeOutMaskConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700503D RID: 20541
		// (get) Token: 0x0600FF14 RID: 65300 RVA: 0x0024C4B0 File Offset: 0x0024A6B0
		public virtual bool? IsEnableMask
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsEnableMask);
			}
		}

		// Token: 0x1700503E RID: 20542
		// (get) Token: 0x0600FF15 RID: 65301 RVA: 0x0024C4E8 File Offset: 0x0024A6E8
		public virtual float? TransitionTime
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.TransitionTime);
			}
		}

		// Token: 0x04008B3A RID: 35642
		private IMovieModeFadeOutMaskConfig Instance;
	}
}
