using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064E6 RID: 25830
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class MatchThreeTargetPopParam
	{
		// Token: 0x06040D72 RID: 265586 RVA: 0x00FB4F2E File Offset: 0x00FB312E
		public MatchThreeTargetPopParam(IReadOnlyList<LevelGoal> goals, Action onClosed)
		{
		}

		// Token: 0x170094DE RID: 38110
		// (get) Token: 0x06040D73 RID: 265587 RVA: 0x00FB4F44 File Offset: 0x00FB3144
		public IReadOnlyList<LevelGoal> Goals { get; } = goals;

		// Token: 0x170094DF RID: 38111
		// (get) Token: 0x06040D74 RID: 265588 RVA: 0x00FB4F4C File Offset: 0x00FB314C
		public Action OnClosed { get; } = onClosed;
	}
}
