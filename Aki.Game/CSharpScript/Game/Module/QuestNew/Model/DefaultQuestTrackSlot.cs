using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuestNew.Model
{
	// Token: 0x02004F98 RID: 20376
	[NullableContext(2)]
	[Nullable(0)]
	public class DefaultQuestTrackSlot : IQuestTrackSlot
	{
		// Token: 0x060342DF RID: 213727 RVA: 0x00C40556 File Offset: 0x00C3E756
		public Quest GetTrack()
		{
			return this.CurTrackQuest;
		}

		// Token: 0x060342E0 RID: 213728 RVA: 0x00C4055E File Offset: 0x00C3E75E
		public void SetTrack(Quest quest)
		{
			this.CurTrackQuest = quest;
		}

		// Token: 0x060342E1 RID: 213729 RVA: 0x00C40567 File Offset: 0x00C3E767
		[NullableContext(1)]
		public bool Accept(Quest quest)
		{
			return true;
		}

		// Token: 0x0401BBD9 RID: 113625
		private Quest CurTrackQuest;
	}
}
