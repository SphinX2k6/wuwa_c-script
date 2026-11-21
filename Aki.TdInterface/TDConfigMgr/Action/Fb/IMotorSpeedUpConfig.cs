using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D9E RID: 11678
	public class IMotorSpeedUpConfig : IMotorParamsChangeConfig
	{
		// Token: 0x0600FE7F RID: 65151 RVA: 0x0024B5C2 File Offset: 0x002497C2
		public static IMotorSpeedUpConfig Create(IMotorSpeedUpConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSpeedUpConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FF1 RID: 20465
		// (get) Token: 0x0600FE80 RID: 65152 RVA: 0x0024B5E1 File Offset: 0x002497E1
		public override EMotorParamsChangeType Type
		{
			get
			{
				return (EMotorParamsChangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004FF2 RID: 20466
		// (get) Token: 0x0600FE81 RID: 65153 RVA: 0x0024B5EE File Offset: 0x002497EE
		public virtual EMotorSpeedUpConfigTag SpeedUpTagId
		{
			get
			{
				return (EMotorSpeedUpConfigTag)this.Instance.SpeedUpTagId;
			}
		}

		// Token: 0x04008AF0 RID: 35568
		private IMotorSpeedUpConfig Instance;
	}
}
