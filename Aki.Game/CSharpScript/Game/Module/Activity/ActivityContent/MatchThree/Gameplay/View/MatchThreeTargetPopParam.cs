using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x02005464 RID: 21604
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class MatchThreeTargetPopParam
	{
		// Token: 0x06035A36 RID: 219702 RVA: 0x00EFBF5E File Offset: 0x00EFA15E
		public MatchThreeTargetPopParam(IReadOnlyList<LevelGoal> goals, Action onClosed)
		{
		}

		// Token: 0x17006840 RID: 26688
		// (get) Token: 0x06035A37 RID: 219703 RVA: 0x00EFBF74 File Offset: 0x00EFA174
		public IReadOnlyList<LevelGoal> Goals { get; } = goals;

		// Token: 0x17006841 RID: 26689
		// (get) Token: 0x06035A38 RID: 219704 RVA: 0x00EFBF7C File Offset: 0x00EFA17C
		public Action OnClosed { get; } = onClosed;
	}
}
