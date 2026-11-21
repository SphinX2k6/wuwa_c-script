using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200507E RID: 20606
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeBlessingReplaceParam : IRoverlikeBlessingReplaceParam
	{
		// Token: 0x170064C7 RID: 25799
		// (get) Token: 0x06033949 RID: 211273 RVA: 0x00E709D9 File Offset: 0x00E6EBD9
		// (set) Token: 0x0603394A RID: 211274 RVA: 0x00E709E1 File Offset: 0x00E6EBE1
		public int CurBlessId { get; set; }

		// Token: 0x170064C8 RID: 25800
		// (get) Token: 0x0603394B RID: 211275 RVA: 0x00E709EA File Offset: 0x00E6EBEA
		// (set) Token: 0x0603394C RID: 211276 RVA: 0x00E709F2 File Offset: 0x00E6EBF2
		public int NewBlessId { get; set; }

		// Token: 0x170064C9 RID: 25801
		// (get) Token: 0x0603394D RID: 211277 RVA: 0x00E709FB File Offset: 0x00E6EBFB
		// (set) Token: 0x0603394E RID: 211278 RVA: 0x00E70A03 File Offset: 0x00E6EC03
		public ERoverlikeBlessingReplaceType Type { get; set; }

		// Token: 0x170064CA RID: 25802
		// (get) Token: 0x0603394F RID: 211279 RVA: 0x00E70A0C File Offset: 0x00E6EC0C
		// (set) Token: 0x06033950 RID: 211280 RVA: 0x00E70A14 File Offset: 0x00E6EC14
		public Action OnConfirm { get; set; }
	}
}
