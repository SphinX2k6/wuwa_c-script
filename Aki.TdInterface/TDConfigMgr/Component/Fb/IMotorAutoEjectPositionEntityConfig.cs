using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BDA RID: 3034
	public class IMotorAutoEjectPositionEntityConfig : IMotorAutoEjectConfigBase
	{
		// Token: 0x0600459D RID: 17821 RVA: 0x000B1963 File Offset: 0x000AFB63
		public static IMotorAutoEjectPositionEntityConfig Create(IMotorAutoEjectPositionEntityConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorAutoEjectPositionEntityConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x0600459E RID: 17822 RVA: 0x000B1982 File Offset: 0x000AFB82
		public override EMotorAutoEjectType Type
		{
			get
			{
				return (EMotorAutoEjectType)this.Instance.Type;
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x0600459F RID: 17823 RVA: 0x000B198F File Offset: 0x000AFB8F
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04002709 RID: 9993
		private IMotorAutoEjectPositionEntityConfig Instance;
	}
}
