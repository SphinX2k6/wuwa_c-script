using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B15 RID: 2837
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorHookAcceleration
	{
		// Token: 0x06004183 RID: 16771 RVA: 0x000A8235 File Offset: 0x000A6435
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

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06004184 RID: 16772 RVA: 0x000A8254 File Offset: 0x000A6454
		public virtual int MaxSpeed
		{
			get
			{
				return this.Instance.MaxSpeed;
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06004185 RID: 16773 RVA: 0x000A8261 File Offset: 0x000A6461
		public virtual string SpeedSampleCurve
		{
			get
			{
				return this.Instance.SpeedSampleCurve;
			}
		}

		// Token: 0x040024EA RID: 9450
		private IMotorHookAcceleration Instance;
	}
}
