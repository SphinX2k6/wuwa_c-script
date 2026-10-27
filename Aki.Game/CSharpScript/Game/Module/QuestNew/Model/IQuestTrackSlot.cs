using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuestNew.Model
{
	// Token: 0x02004F97 RID: 20375
	[NullableContext(2)]
	public interface IQuestTrackSlot
	{
		// Token: 0x060342DC RID: 213724
		Quest GetTrack();

		// Token: 0x060342DD RID: 213725
		void SetTrack(Quest quest);

		// Token: 0x060342DE RID: 213726
		[NullableContext(1)]
		bool Accept(Quest quest);
	}
}
