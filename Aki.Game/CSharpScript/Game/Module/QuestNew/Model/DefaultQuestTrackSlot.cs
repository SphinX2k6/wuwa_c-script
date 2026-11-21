using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuestNew.Model
{
	// Token: 0x02003F61 RID: 16225
	[NullableContext(2)]
	[Nullable(0)]
	public class DefaultQuestTrackSlot : IQuestTrackSlot
	{
		// Token: 0x0602914D RID: 168269 RVA: 0x00B89D02 File Offset: 0x00B87F02
		public Quest GetTrack()
		{
			return this.CurTrackQuest;
		}

		// Token: 0x0602914E RID: 168270 RVA: 0x00B89D0A File Offset: 0x00B87F0A
		public void SetTrack(Quest quest)
		{
			this.CurTrackQuest = quest;
		}

		// Token: 0x0602914F RID: 168271 RVA: 0x00B89D13 File Offset: 0x00B87F13
		[NullableContext(1)]
		public bool Accept(Quest quest)
		{
			return true;
		}

		// Token: 0x040165AE RID: 91566
		private Quest CurTrackQuest;
	}
}
