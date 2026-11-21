using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D81 RID: 11649
	public class ITrapDefensePlayerOperationSpawnMonster : ITrapDefensePlayerOperationType
	{
		// Token: 0x0600FE0A RID: 65034 RVA: 0x0024A938 File Offset: 0x00248B38
		public static ITrapDefensePlayerOperationSpawnMonster Create(ITrapDefensePlayerOperationSpawnMonster? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefensePlayerOperationSpawnMonster
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FB6 RID: 20406
		// (get) Token: 0x0600FE0B RID: 65035 RVA: 0x0024A957 File Offset: 0x00248B57
		public override ETrapDefensePlayerOperationType Type
		{
			get
			{
				return (ETrapDefensePlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008AB1 RID: 35505
		private ITrapDefensePlayerOperationSpawnMonster Instance;
	}
}
