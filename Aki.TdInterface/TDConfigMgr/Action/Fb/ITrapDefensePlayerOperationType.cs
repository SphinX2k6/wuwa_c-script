using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D7E RID: 11646
	public class ITrapDefensePlayerOperationType
	{
		// Token: 0x0600FE01 RID: 65025 RVA: 0x0024A89C File Offset: 0x00248A9C
		public static ITrapDefensePlayerOperationType Create(ITrapDefensePlayerOperationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FB3 RID: 20403
		// (get) Token: 0x0600FE02 RID: 65026 RVA: 0x0024A8BB File Offset: 0x00248ABB
		public virtual ETrapDefensePlayerOperationType Type
		{
			get
			{
				return (ETrapDefensePlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008AAE RID: 35502
		private ITrapDefensePlayerOperationType Instance;
	}
}
