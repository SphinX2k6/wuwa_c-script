using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028BA RID: 10426
	public class IMovingCameraTimeParams
	{
		// Token: 0x0600E76F RID: 59247 RVA: 0x0021FCB5 File Offset: 0x0021DEB5
		[NullableContext(1)]
		public static IMovingCameraTimeParams Create(IMovingCameraTimeParams? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovingCameraTimeParams
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047BD RID: 18365
		// (get) Token: 0x0600E770 RID: 59248 RVA: 0x0021FCD4 File Offset: 0x0021DED4
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x170047BE RID: 18366
		// (get) Token: 0x0600E771 RID: 59249 RVA: 0x0021FCE1 File Offset: 0x0021DEE1
		public virtual float AfterFadeInStayTime
		{
			get
			{
				return this.Instance.AfterFadeInStayTime;
			}
		}

		// Token: 0x170047BF RID: 18367
		// (get) Token: 0x0600E772 RID: 59250 RVA: 0x0021FCEE File Offset: 0x0021DEEE
		public virtual float FadeOutTime
		{
			get
			{
				return this.Instance.FadeOutTime;
			}
		}

		// Token: 0x170047C0 RID: 18368
		// (get) Token: 0x0600E773 RID: 59251 RVA: 0x0021FCFB File Offset: 0x0021DEFB
		public virtual float BeforeFadeOutStayTime
		{
			get
			{
				return this.Instance.BeforeFadeOutStayTime;
			}
		}

		// Token: 0x04007FEC RID: 32748
		private IMovingCameraTimeParams Instance;
	}
}
