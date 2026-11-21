using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200519A RID: 20890
	public class IQuestPreConditionDungeonBaseT
	{
		// Token: 0x1700959D RID: 38301
		// (get) Token: 0x06020E0B RID: 134667 RVA: 0x0048C932 File Offset: 0x0048AB32
		// (set) Token: 0x06020E0C RID: 134668 RVA: 0x0048C93A File Offset: 0x0048AB3A
		public EQuestPreConditionDungeonType Type { get; set; }

		// Token: 0x06020E0D RID: 134669 RVA: 0x0048C943 File Offset: 0x0048AB43
		public IQuestPreConditionDungeonBaseT()
		{
			this.Type = EQuestPreConditionDungeonType.DungeonId;
		}
	}
}
