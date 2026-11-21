using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002918 RID: 10520
	public class IInfrActivityInfrastructureStage : IInfrActivityBuildStageOption
	{
		// Token: 0x0600E9DE RID: 59870 RVA: 0x002287BD File Offset: 0x002269BD
		public static IInfrActivityInfrastructureStage Create(IInfrActivityInfrastructureStage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrActivityInfrastructureStage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700445C RID: 17500
		// (get) Token: 0x0600E9DF RID: 59871 RVA: 0x002287DC File Offset: 0x002269DC
		public override EInfrActivityBuildStageType Type
		{
			get
			{
				return (EInfrActivityBuildStageType)this.Instance.Type;
			}
		}

		// Token: 0x1700445D RID: 17501
		// (get) Token: 0x0600E9E0 RID: 59872 RVA: 0x002287E9 File Offset: 0x002269E9
		public virtual int Stage
		{
			get
			{
				return this.Instance.Stage;
			}
		}

		// Token: 0x040080F2 RID: 33010
		private IInfrActivityInfrastructureStage Instance;
	}
}
