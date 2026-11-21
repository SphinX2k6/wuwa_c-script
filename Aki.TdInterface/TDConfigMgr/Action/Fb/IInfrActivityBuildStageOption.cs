using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002917 RID: 10519
	public class IInfrActivityBuildStageOption
	{
		// Token: 0x0600E9DB RID: 59867 RVA: 0x00228789 File Offset: 0x00226989
		public static IInfrActivityBuildStageOption Create(IInfrActivityBuildStageOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrActivityBuildStageOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700445B RID: 17499
		// (get) Token: 0x0600E9DC RID: 59868 RVA: 0x002287A8 File Offset: 0x002269A8
		public virtual EInfrActivityBuildStageType Type
		{
			get
			{
				return (EInfrActivityBuildStageType)this.Instance.Type;
			}
		}

		// Token: 0x040080F1 RID: 33009
		private IInfrActivityBuildStageOption Instance;
	}
}
