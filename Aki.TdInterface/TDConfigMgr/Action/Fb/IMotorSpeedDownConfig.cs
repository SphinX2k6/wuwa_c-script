using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D9F RID: 11679
	public class IMotorSpeedDownConfig : IMotorParamsChangeConfig
	{
		// Token: 0x0600FE83 RID: 65155 RVA: 0x0024B603 File Offset: 0x00249803
		public static IMotorSpeedDownConfig Create(IMotorSpeedDownConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSpeedDownConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FF3 RID: 20467
		// (get) Token: 0x0600FE84 RID: 65156 RVA: 0x0024B622 File Offset: 0x00249822
		public override EMotorParamsChangeType Type
		{
			get
			{
				return (EMotorParamsChangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004FF4 RID: 20468
		// (get) Token: 0x0600FE85 RID: 65157 RVA: 0x0024B62F File Offset: 0x0024982F
		public virtual EMotorSpeedDownConfig SpeedDownTagId
		{
			get
			{
				return (EMotorSpeedDownConfig)this.Instance.SpeedDownTagId;
			}
		}

		// Token: 0x04008AF1 RID: 35569
		private IMotorSpeedDownConfig Instance;
	}
}
