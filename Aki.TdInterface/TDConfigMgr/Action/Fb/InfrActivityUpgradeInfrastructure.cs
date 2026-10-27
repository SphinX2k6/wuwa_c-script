using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A97 RID: 10903
	public class InfrActivityUpgradeInfrastructure : ActionParams
	{
		// Token: 0x0600EF7D RID: 61309 RVA: 0x0022D0AC File Offset: 0x0022B2AC
		[NullableContext(1)]
		public static InfrActivityUpgradeInfrastructure Create(IInfrActivityUpgradeInfrastructure? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new InfrActivityUpgradeInfrastructure
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C11 RID: 19473
		// (get) Token: 0x0600EF7E RID: 61310 RVA: 0x0022D0CB File Offset: 0x0022B2CB
		public virtual int Level
		{
			get
			{
				return this.Instance.Level;
			}
		}

		// Token: 0x040083C1 RID: 33729
		private IInfrActivityUpgradeInfrastructure Instance;
	}
}
