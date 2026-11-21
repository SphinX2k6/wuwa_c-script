using System;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x0200445D RID: 17501
	public class MechanismEventLevelPrefabContext : MechanismEventContext
	{
		// Token: 0x0602C22A RID: 180778 RVA: 0x00C65482 File Offset: 0x00C63682
		public MechanismEventLevelPrefabContext(int pbDataId, int levelPrefabHandleId)
		{
		}

		// Token: 0x17005825 RID: 22565
		// (get) Token: 0x0602C22B RID: 180779 RVA: 0x00C65498 File Offset: 0x00C63698
		public override EMechanismEventContextType ContextType
		{
			get
			{
				return EMechanismEventContextType.LevelPrefab;
			}
		}

		// Token: 0x04017C4B RID: 97355
		public readonly int PbDataId = pbDataId;

		// Token: 0x04017C4C RID: 97356
		public readonly int LevelPrefabHandleId = levelPrefabHandleId;
	}
}
