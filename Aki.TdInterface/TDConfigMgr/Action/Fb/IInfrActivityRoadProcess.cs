using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002919 RID: 10521
	public class IInfrActivityRoadProcess : IInfrActivityBuildStageOption
	{
		// Token: 0x0600E9E2 RID: 59874 RVA: 0x002287FE File Offset: 0x002269FE
		public static IInfrActivityRoadProcess Create(IInfrActivityRoadProcess? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrActivityRoadProcess
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700445E RID: 17502
		// (get) Token: 0x0600E9E3 RID: 59875 RVA: 0x0022881D File Offset: 0x00226A1D
		public override EInfrActivityBuildStageType Type
		{
			get
			{
				return (EInfrActivityBuildStageType)this.Instance.Type;
			}
		}

		// Token: 0x1700445F RID: 17503
		// (get) Token: 0x0600E9E4 RID: 59876 RVA: 0x0022882A File Offset: 0x00226A2A
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040080F3 RID: 33011
		private IInfrActivityRoadProcess Instance;
	}
}
