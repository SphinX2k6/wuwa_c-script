using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FD9 RID: 24537
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisSelectGroupData : ITetrisSelectGroupData
	{
		// Token: 0x17009024 RID: 36900
		// (get) Token: 0x0603E2C0 RID: 254656 RVA: 0x00F02C21 File Offset: 0x00F00E21
		// (set) Token: 0x0603E2C1 RID: 254657 RVA: 0x00F02C29 File Offset: 0x00F00E29
		public int GroupId { get; set; }

		// Token: 0x17009025 RID: 36901
		// (get) Token: 0x0603E2C2 RID: 254658 RVA: 0x00F02C32 File Offset: 0x00F00E32
		// (set) Token: 0x0603E2C3 RID: 254659 RVA: 0x00F02C3A File Offset: 0x00F00E3A
		public List<int> ChallengeIds { get; set; }
	}
}
