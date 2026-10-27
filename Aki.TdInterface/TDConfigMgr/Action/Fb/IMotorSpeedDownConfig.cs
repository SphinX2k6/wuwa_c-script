using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AAB RID: 10923
	public class IMotorSpeedDownConfig : IMotorParamsChangeConfig
	{
		// Token: 0x0600EFCD RID: 61389 RVA: 0x0022D8F7 File Offset: 0x0022BAF7
		[NullableContext(1)]
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

		// Token: 0x17004C39 RID: 19513
		// (get) Token: 0x0600EFCE RID: 61390 RVA: 0x0022D916 File Offset: 0x0022BB16
		public override EMotorParamsChangeType Type
		{
			get
			{
				return (EMotorParamsChangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004C3A RID: 19514
		// (get) Token: 0x0600EFCF RID: 61391 RVA: 0x0022D923 File Offset: 0x0022BB23
		public virtual EMotorSpeedDownConfig SpeedDownTagId
		{
			get
			{
				return (EMotorSpeedDownConfig)this.Instance.SpeedDownTagId;
			}
		}

		// Token: 0x040083ED RID: 33773
		private IMotorSpeedDownConfig Instance;
	}
}
