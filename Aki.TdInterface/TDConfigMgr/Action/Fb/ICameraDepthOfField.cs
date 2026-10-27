using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028AC RID: 10412
	public class ICameraDepthOfField
	{
		// Token: 0x0600E6AD RID: 59053 RVA: 0x0021E266 File Offset: 0x0021C466
		[NullableContext(1)]
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

		// Token: 0x17004717 RID: 18199
		// (get) Token: 0x0600E6AE RID: 59054 RVA: 0x0021E288 File Offset: 0x0021C488
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

		// Token: 0x17004718 RID: 18200
		// (get) Token: 0x0600E6AF RID: 59055 RVA: 0x0021E2C0 File Offset: 0x0021C4C0
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

		// Token: 0x17004719 RID: 18201
		// (get) Token: 0x0600E6B0 RID: 59056 RVA: 0x0021E2F8 File Offset: 0x0021C4F8
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

		// Token: 0x1700471A RID: 18202
		// (get) Token: 0x0600E6B1 RID: 59057 RVA: 0x0021E330 File Offset: 0x0021C530
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

		// Token: 0x04007F82 RID: 32642
		private ICameraDepthOfField Instance;
	}
}
