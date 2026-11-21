using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BF8 RID: 11256
	public class IMp4GamepadShakeFadeOutConfig
	{
		// Token: 0x0600F7E6 RID: 63462 RVA: 0x00240F9A File Offset: 0x0023F19A
		public static IMp4GamepadShakeFadeOutConfig Create(IMp4GamepadShakeFadeOutConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4GamepadShakeFadeOutConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CA4 RID: 19620
		// (get) Token: 0x0600F7E7 RID: 63463 RVA: 0x00240FBC File Offset: 0x0023F1BC
		public virtual float? FadeOutTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.FadeOutTime);
			}
		}

		// Token: 0x17004CA5 RID: 19621
		// (get) Token: 0x0600F7E8 RID: 63464 RVA: 0x00240FF4 File Offset: 0x0023F1F4
		public virtual EMp4GamepadShakeCurve? FadeOutCurve
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EMp4GamepadShakeCurve?((EMp4GamepadShakeCurve)this.Instance.FadeOutCurve);
			}
		}

		// Token: 0x040087B0 RID: 34736
		private IMp4GamepadShakeFadeOutConfig Instance;
	}
}
