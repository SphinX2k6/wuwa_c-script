using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x0200547F RID: 21631
	[NullableContext(1)]
	public interface ISolvedSequencesConsumer
	{
		// Token: 0x06035B48 RID: 219976
		void OnSequencesSolved(SolvedData solved);
	}
}
