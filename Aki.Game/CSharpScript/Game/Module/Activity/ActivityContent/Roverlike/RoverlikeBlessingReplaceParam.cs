using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006100 RID: 24832
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeBlessingReplaceParam : IRoverlikeBlessingReplaceParam
	{
		// Token: 0x17009165 RID: 37221
		// (get) Token: 0x0603EC87 RID: 257159 RVA: 0x00F29BC5 File Offset: 0x00F27DC5
		// (set) Token: 0x0603EC88 RID: 257160 RVA: 0x00F29BCD File Offset: 0x00F27DCD
		public int CurBlessId { get; set; }

		// Token: 0x17009166 RID: 37222
		// (get) Token: 0x0603EC89 RID: 257161 RVA: 0x00F29BD6 File Offset: 0x00F27DD6
		// (set) Token: 0x0603EC8A RID: 257162 RVA: 0x00F29BDE File Offset: 0x00F27DDE
		public int NewBlessId { get; set; }

		// Token: 0x17009167 RID: 37223
		// (get) Token: 0x0603EC8B RID: 257163 RVA: 0x00F29BE7 File Offset: 0x00F27DE7
		// (set) Token: 0x0603EC8C RID: 257164 RVA: 0x00F29BEF File Offset: 0x00F27DEF
		public ERoverlikeBlessingReplaceType Type { get; set; }

		// Token: 0x17009168 RID: 37224
		// (get) Token: 0x0603EC8D RID: 257165 RVA: 0x00F29BF8 File Offset: 0x00F27DF8
		// (set) Token: 0x0603EC8E RID: 257166 RVA: 0x00F29C00 File Offset: 0x00F27E00
		public Action OnConfirm { get; set; }
	}
}
