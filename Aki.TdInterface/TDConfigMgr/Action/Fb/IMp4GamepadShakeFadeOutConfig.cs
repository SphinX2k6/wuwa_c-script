using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200291C RID: 10524
	public class IMp4GamepadShakeFadeOutConfig
	{
		// Token: 0x0600E994 RID: 59796 RVA: 0x00223C42 File Offset: 0x00221E42
		[NullableContext(1)]
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

		// Token: 0x1700491E RID: 18718
		// (get) Token: 0x0600E995 RID: 59797 RVA: 0x00223C64 File Offset: 0x00221E64
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

		// Token: 0x1700491F RID: 18719
		// (get) Token: 0x0600E996 RID: 59798 RVA: 0x00223C9C File Offset: 0x00221E9C
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

		// Token: 0x040080E2 RID: 32994
		private IMp4GamepadShakeFadeOutConfig Instance;
	}
}
