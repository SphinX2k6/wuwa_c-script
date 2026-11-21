using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B8F RID: 11151
	public class IMovingCameraTimeParams
	{
		// Token: 0x0600F59E RID: 62878 RVA: 0x0023CC35 File Offset: 0x0023AE35
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

		// Token: 0x17004B2E RID: 19246
		// (get) Token: 0x0600F59F RID: 62879 RVA: 0x0023CC54 File Offset: 0x0023AE54
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x17004B2F RID: 19247
		// (get) Token: 0x0600F5A0 RID: 62880 RVA: 0x0023CC61 File Offset: 0x0023AE61
		public virtual float AfterFadeInStayTime
		{
			get
			{
				return this.Instance.AfterFadeInStayTime;
			}
		}

		// Token: 0x17004B30 RID: 19248
		// (get) Token: 0x0600F5A1 RID: 62881 RVA: 0x0023CC6E File Offset: 0x0023AE6E
		public virtual float FadeOutTime
		{
			get
			{
				return this.Instance.FadeOutTime;
			}
		}

		// Token: 0x17004B31 RID: 19249
		// (get) Token: 0x0600F5A2 RID: 62882 RVA: 0x0023CC7B File Offset: 0x0023AE7B
		public virtual float BeforeFadeOutStayTime
		{
			get
			{
				return this.Instance.BeforeFadeOutStayTime;
			}
		}

		// Token: 0x040086AB RID: 34475
		private IMovingCameraTimeParams Instance;
	}
}
