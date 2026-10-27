using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006102 RID: 24834
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeEventOpenParam : IRoverlikeEventOpenParam
	{
		// Token: 0x1700916B RID: 37227
		// (get) Token: 0x0603EC94 RID: 257172 RVA: 0x00F29C11 File Offset: 0x00F27E11
		// (set) Token: 0x0603EC95 RID: 257173 RVA: 0x00F29C19 File Offset: 0x00F27E19
		public int EventIncId { get; set; }

		// Token: 0x1700916C RID: 37228
		// (get) Token: 0x0603EC96 RID: 257174 RVA: 0x00F29C22 File Offset: 0x00F27E22
		// (set) Token: 0x0603EC97 RID: 257175 RVA: 0x00F29C2A File Offset: 0x00F27E2A
		public List<int> ChoiceList { get; set; } = new List<int>();
	}
}
