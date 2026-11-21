using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D7F RID: 11647
	public class ITrapDefensePlayerOperationRecycleTrap : ITrapDefensePlayerOperationType
	{
		// Token: 0x0600FE04 RID: 65028 RVA: 0x0024A8D0 File Offset: 0x00248AD0
		public static ITrapDefensePlayerOperationRecycleTrap Create(ITrapDefensePlayerOperationRecycleTrap? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationRecycleTrap
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FB4 RID: 20404
		// (get) Token: 0x0600FE05 RID: 65029 RVA: 0x0024A8EF File Offset: 0x00248AEF
		public override ETrapDefensePlayerOperationType Type
		{
			get
			{
				return (ETrapDefensePlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008AAF RID: 35503
		private ITrapDefensePlayerOperationRecycleTrap Instance;
	}
}
