using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD9 RID: 3033
	public class IMotorAutoEjectNextHookConfig : IMotorAutoEjectConfigBase
	{
		// Token: 0x06004599 RID: 17817 RVA: 0x000B1922 File Offset: 0x000AFB22
		public static IMotorAutoEjectNextHookConfig Create(IMotorAutoEjectNextHookConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorAutoEjectNextHookConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x0600459A RID: 17818 RVA: 0x000B1941 File Offset: 0x000AFB41
		public override EMotorAutoEjectType Type
		{
			get
			{
				return (EMotorAutoEjectType)this.Instance.Type;
			}
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x0600459B RID: 17819 RVA: 0x000B194E File Offset: 0x000AFB4E
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04002708 RID: 9992
		private IMotorAutoEjectNextHookConfig Instance;
	}
}
