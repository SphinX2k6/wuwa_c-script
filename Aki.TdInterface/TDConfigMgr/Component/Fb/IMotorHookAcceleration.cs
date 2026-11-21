using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE3 RID: 3043
	public class IMotorHookAcceleration
	{
		// Token: 0x060045D9 RID: 17881 RVA: 0x000B2261 File Offset: 0x000B0461
		public static IMotorHookAcceleration Create(IMotorHookAcceleration? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorHookAcceleration
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060045DA RID: 17882 RVA: 0x000B2280 File Offset: 0x000B0480
		public virtual int MaxSpeed
		{
			get
			{
				return this.Instance.MaxSpeed;
			}
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060045DB RID: 17883 RVA: 0x000B228D File Offset: 0x000B048D
		public virtual string SpeedSampleCurve
		{
			get
			{
				return this.Instance.SpeedSampleCurve;
			}
		}

		// Token: 0x0400272E RID: 10030
		private IMotorHookAcceleration Instance;
	}
}
