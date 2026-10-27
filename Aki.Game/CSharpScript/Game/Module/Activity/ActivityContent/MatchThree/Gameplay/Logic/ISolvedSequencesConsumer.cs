using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x02006501 RID: 25857
	[NullableContext(1)]
	public interface ISolvedSequencesConsumer
	{
		// Token: 0x06040E84 RID: 265860
		void OnSequencesSolved(SolvedData solved);
	}
}
