using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B89 RID: 11145
	public class IAxisLockScreenConfig : ActionParams
	{
		// Token: 0x0600F558 RID: 62808 RVA: 0x0023C2BA File Offset: 0x0023A4BA
		public static IAxisLockScreenConfig Create(IAxisLockScreenConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAxisLockScreenConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AF4 RID: 19188
		// (get) Token: 0x0600F559 RID: 62809 RVA: 0x0023C2D9 File Offset: 0x0023A4D9
		public virtual float TriggerAngle
		{
			get
			{
				return this.Instance.TriggerAngle;
			}
		}

		// Token: 0x17004AF5 RID: 19189
		// (get) Token: 0x0600F55A RID: 62810 RVA: 0x0023C2E6 File Offset: 0x0023A4E6
		public virtual float FadeInTime
		{
			get
			{
				return this.Instance.FadeInTime;
			}
		}

		// Token: 0x17004AF6 RID: 19190
		// (get) Token: 0x0600F55B RID: 62811 RVA: 0x0023C2F3 File Offset: 0x0023A4F3
		public virtual float FadeOutTime
		{
			get
			{
				return this.Instance.FadeOutTime;
			}
		}

		// Token: 0x04008683 RID: 34435
		private IAxisLockScreenConfig Instance;
	}
}
