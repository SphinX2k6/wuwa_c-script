using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FD8 RID: 24536
	[NullableContext(1)]
	public interface ITetrisSelectGroupData
	{
		// Token: 0x17009022 RID: 36898
		// (get) Token: 0x0603E2BC RID: 254652
		// (set) Token: 0x0603E2BD RID: 254653
		int GroupId { get; set; }

		// Token: 0x17009023 RID: 36899
		// (get) Token: 0x0603E2BE RID: 254654
		// (set) Token: 0x0603E2BF RID: 254655
		List<int> ChallengeIds { get; set; }
	}
}
