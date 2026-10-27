using System;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x0200547A RID: 21626
	public class MechanismEventLevelPrefabContext : MechanismEventContext
	{
		// Token: 0x060372E1 RID: 226017 RVA: 0x00D1602A File Offset: 0x00D1422A
		public MechanismEventLevelPrefabContext(int pbDataId, int levelPrefabHandleId)
		{
		}

		// Token: 0x17008459 RID: 33881
		// (get) Token: 0x060372E2 RID: 226018 RVA: 0x00D16040 File Offset: 0x00D14240
		public override EMechanismEventContextType ContextType
		{
			get
			{
				return EMechanismEventContextType.LevelPrefab;
			}
		}

		// Token: 0x0401D1B2 RID: 119218
		public readonly int PbDataId = pbDataId;

		// Token: 0x0401D1B3 RID: 119219
		public readonly int LevelPrefabHandleId = levelPrefabHandleId;
	}
}
