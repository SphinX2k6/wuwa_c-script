using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200291B RID: 10523
	public class IMp4GamepadShakeFadeInConfig
	{
		// Token: 0x0600E990 RID: 59792 RVA: 0x00223BAA File Offset: 0x00221DAA
		[NullableContext(1)]
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

		// Token: 0x1700491C RID: 18716
		// (get) Token: 0x0600E991 RID: 59793 RVA: 0x00223BCC File Offset: 0x00221DCC
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

		// Token: 0x1700491D RID: 18717
		// (get) Token: 0x0600E992 RID: 59794 RVA: 0x00223C04 File Offset: 0x00221E04
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

		// Token: 0x040080E1 RID: 32993
		private IMp4GamepadShakeFadeInConfig Instance;
	}
}
