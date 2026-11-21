using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200507D RID: 20605
	[NullableContext(2)]
	public interface IRoverlikeBlessingReplaceParam
	{
		// Token: 0x170064C3 RID: 25795
		// (get) Token: 0x06033941 RID: 211265
		// (set) Token: 0x06033942 RID: 211266
		int CurBlessId { get; set; }

		// Token: 0x170064C4 RID: 25796
		// (get) Token: 0x06033943 RID: 211267
		// (set) Token: 0x06033944 RID: 211268
		int NewBlessId { get; set; }

		// Token: 0x170064C5 RID: 25797
		// (get) Token: 0x06033945 RID: 211269
		// (set) Token: 0x06033946 RID: 211270
		ERoverlikeBlessingReplaceType Type { get; set; }

		// Token: 0x170064C6 RID: 25798
		// (get) Token: 0x06033947 RID: 211271
		// (set) Token: 0x06033948 RID: 211272
		Action OnConfirm { get; set; }
	}
}
