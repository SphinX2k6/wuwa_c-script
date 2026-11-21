using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B81 RID: 11137
	public class ICameraDepthOfField
	{
		// Token: 0x0600F4DC RID: 62684 RVA: 0x0023B1E6 File Offset: 0x002393E6
		public static ICameraDepthOfField Create(ICameraDepthOfField? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraDepthOfField
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A88 RID: 19080
		// (get) Token: 0x0600F4DD RID: 62685 RVA: 0x0023B208 File Offset: 0x00239408
		public virtual float? Fstop
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Fstop);
			}
		}

		// Token: 0x17004A89 RID: 19081
		// (get) Token: 0x0600F4DE RID: 62686 RVA: 0x0023B240 File Offset: 0x00239440
		public virtual float? Distance
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Distance);
			}
		}

		// Token: 0x17004A8A RID: 19082
		// (get) Token: 0x0600F4DF RID: 62687 RVA: 0x0023B278 File Offset: 0x00239478
		public virtual float? BlurAmount
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.BlurAmount);
			}
		}

		// Token: 0x17004A8B RID: 19083
		// (get) Token: 0x0600F4E0 RID: 62688 RVA: 0x0023B2B0 File Offset: 0x002394B0
		public virtual float? BlurRadius
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.BlurRadius);
			}
		}

		// Token: 0x04008641 RID: 34369
		private ICameraDepthOfField Instance;
	}
}
