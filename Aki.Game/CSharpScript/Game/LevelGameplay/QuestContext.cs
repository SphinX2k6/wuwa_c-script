using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x0200699B RID: 27035
	public class QuestContext : GeneralContext
	{
		// Token: 0x0604343F RID: 275519 RVA: 0x01065D84 File Offset: 0x01063F84
		public QuestContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Quest);
		}

		// Token: 0x06043440 RID: 275520 RVA: 0x01065D98 File Offset: 0x01063F98
		public override void Reset()
		{
			this.QuestId = 0;
		}

		// Token: 0x06043441 RID: 275521 RVA: 0x01065DA1 File Offset: 0x01063FA1
		[NullableContext(1)]
		public static QuestContext Create(int questId = 0, GameCtxType? subType = null)
		{
			QuestContext questContext = GeneralContext.GetObj(EGeneralContextType.Quest, subType, () => new QuestContext()) as QuestContext;
			questContext.QuestId = questId;
			return questContext;
		}

		// Token: 0x040230A7 RID: 143527
		public int QuestId;
	}
}
