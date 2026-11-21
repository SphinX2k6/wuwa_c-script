using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD8 RID: 3032
	public class IMotorAutoEjectConfigBase
	{
		// Token: 0x06004596 RID: 17814 RVA: 0x000B18EE File Offset: 0x000AFAEE
		public static IMotorAutoEjectConfigBase Create(IMotorAutoEjectConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorAutoEjectConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x000B190D File Offset: 0x000AFB0D
		public virtual EMotorAutoEjectType Type
		{
			get
			{
				return (EMotorAutoEjectType)this.Instance.Type;
			}
		}

		// Token: 0x04002707 RID: 9991
		private IMotorAutoEjectConfigBase Instance;
	}
}
