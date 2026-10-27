using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AAA RID: 10922
	public class IMotorSpeedUpConfig : IMotorParamsChangeConfig
	{
		// Token: 0x0600EFC9 RID: 61385 RVA: 0x0022D8B6 File Offset: 0x0022BAB6
		[NullableContext(1)]
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

		// Token: 0x17004C37 RID: 19511
		// (get) Token: 0x0600EFCA RID: 61386 RVA: 0x0022D8D5 File Offset: 0x0022BAD5
		public override EMotorParamsChangeType Type
		{
			get
			{
				return (EMotorParamsChangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004C38 RID: 19512
		// (get) Token: 0x0600EFCB RID: 61387 RVA: 0x0022D8E2 File Offset: 0x0022BAE2
		public virtual EMotorSpeedUpConfigTag SpeedUpTagId
		{
			get
			{
				return (EMotorSpeedUpConfigTag)this.Instance.SpeedUpTagId;
			}
		}

		// Token: 0x040083EC RID: 33772
		private IMotorSpeedUpConfig Instance;
	}
}
