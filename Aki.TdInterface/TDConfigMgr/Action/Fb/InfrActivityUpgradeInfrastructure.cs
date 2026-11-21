using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D8B RID: 11659
	public class InfrActivityUpgradeInfrastructure : ActionParams
	{
		// Token: 0x0600FE33 RID: 65075 RVA: 0x0024ADB8 File Offset: 0x00248FB8
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

		// Token: 0x17004FCB RID: 20427
		// (get) Token: 0x0600FE34 RID: 65076 RVA: 0x0024ADD7 File Offset: 0x00248FD7
		public virtual int Level
		{
			get
			{
				return this.Instance.Level;
			}
		}

		// Token: 0x04008AC5 RID: 35525
		private IInfrActivityUpgradeInfrastructure Instance;
	}
}
