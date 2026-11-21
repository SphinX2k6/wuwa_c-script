using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D80 RID: 11648
	public class ITrapDefensePlayerOperationConstructTrap : ITrapDefensePlayerOperationType
	{
		// Token: 0x0600FE07 RID: 65031 RVA: 0x0024A904 File Offset: 0x00248B04
		public static ITrapDefensePlayerOperationConstructTrap Create(ITrapDefensePlayerOperationConstructTrap? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationConstructTrap
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FB5 RID: 20405
		// (get) Token: 0x0600FE08 RID: 65032 RVA: 0x0024A923 File Offset: 0x00248B23
		public override ETrapDefensePlayerOperationType Type
		{
			get
			{
				return (ETrapDefensePlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008AB0 RID: 35504
		private ITrapDefensePlayerOperationConstructTrap Instance;
	}
}
