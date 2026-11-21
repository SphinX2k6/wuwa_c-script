using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuestNew.Model
{
	// Token: 0x02003F60 RID: 16224
	[NullableContext(2)]
	public interface IQuestTrackSlot
	{
		// Token: 0x0602914A RID: 168266
		Quest GetTrack();

		// Token: 0x0602914B RID: 168267
		void SetTrack(Quest quest);

		// Token: 0x0602914C RID: 168268
		[NullableContext(1)]
		bool Accept(Quest quest);
	}
}
