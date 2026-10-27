using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ACE RID: 10958
	public class IMovieModeFadeOutMaskConfig
	{
		// Token: 0x0600F05D RID: 61533 RVA: 0x0022E782 File Offset: 0x0022C982
		[NullableContext(1)]
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

		// Token: 0x17004C83 RID: 19587
		// (get) Token: 0x0600F05E RID: 61534 RVA: 0x0022E7A4 File Offset: 0x0022C9A4
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

		// Token: 0x17004C84 RID: 19588
		// (get) Token: 0x0600F05F RID: 61535 RVA: 0x0022E7DC File Offset: 0x0022C9DC
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

		// Token: 0x04008436 RID: 33846
		private IMovieModeFadeOutMaskConfig Instance;
	}
}
