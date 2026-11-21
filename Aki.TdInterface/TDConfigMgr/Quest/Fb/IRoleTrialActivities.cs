using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014EF RID: 5359
	public class IRoleTrialActivities : IShowUi
	{
		// Token: 0x06007972 RID: 31090 RVA: 0x0012238D File Offset: 0x0012058D
		public static IRoleTrialActivities Create(IRoleTrialActivities? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTrialActivities
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x06007973 RID: 31091 RVA: 0x001223AC File Offset: 0x001205AC
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x040045DD RID: 17885
		private IRoleTrialActivities Instance;
	}
}
