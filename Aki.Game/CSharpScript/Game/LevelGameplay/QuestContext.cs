using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AF7 RID: 23287
	public class QuestContext : GeneralContext
	{
		// Token: 0x06039477 RID: 234615 RVA: 0x01009FEC File Offset: 0x010081EC
		public QuestContext()
		{
			this.Type = new EGeneralContextType?(EGeneralContextType.Quest);
		}

		// Token: 0x06039478 RID: 234616 RVA: 0x0100A000 File Offset: 0x01008200
		public override void Reset()
		{
			this.QuestId = 0;
		}

		// Token: 0x06039479 RID: 234617 RVA: 0x0100A009 File Offset: 0x01008209
		[NullableContext(1)]
		public static QuestContext Create(int questId = 0, GameCtxType? subType = null)
		{
			QuestContext questContext = GeneralContext.GetObj(EGeneralContextType.Quest, subType, () => new QuestContext()) as QuestContext;
			questContext.QuestId = questId;
			return questContext;
		}

		// Token: 0x0401E291 RID: 123537
		public int QuestId;
	}
}
