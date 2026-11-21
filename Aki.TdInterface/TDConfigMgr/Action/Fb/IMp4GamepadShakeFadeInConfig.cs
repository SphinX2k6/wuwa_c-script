using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BF7 RID: 11255
	public class IMp4GamepadShakeFadeInConfig
	{
		// Token: 0x0600F7E2 RID: 63458 RVA: 0x00240F02 File Offset: 0x0023F102
		public static IMp4GamepadShakeFadeInConfig Create(IMp4GamepadShakeFadeInConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4GamepadShakeFadeInConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CA2 RID: 19618
		// (get) Token: 0x0600F7E3 RID: 63459 RVA: 0x00240F24 File Offset: 0x0023F124
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

		// Token: 0x17004CA3 RID: 19619
		// (get) Token: 0x0600F7E4 RID: 63460 RVA: 0x00240F5C File Offset: 0x0023F15C
		public virtual EMp4GamepadShakeCurve? FadeInCurve
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EMp4GamepadShakeCurve?((EMp4GamepadShakeCurve)this.Instance.FadeInCurve);
			}
		}

		// Token: 0x040087AF RID: 34735
		private IMp4GamepadShakeFadeInConfig Instance;
	}
}
