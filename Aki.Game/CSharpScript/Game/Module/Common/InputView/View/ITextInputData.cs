using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02004B5B RID: 19291
	[NullableContext(1)]
	public interface ITextInputData
	{
		// Token: 0x17006085 RID: 24709
		// (get) Token: 0x06030359 RID: 197465
		// (set) Token: 0x0603035A RID: 197466
		TConfirm ConfirmFunc { get; set; }

		// Token: 0x17006086 RID: 24710
		// (get) Token: 0x0603035B RID: 197467
		// (set) Token: 0x0603035C RID: 197468
		TResult ResultFunc { get; set; }

		// Token: 0x17006087 RID: 24711
		// (get) Token: 0x0603035D RID: 197469
		// (set) Token: 0x0603035E RID: 197470
		string InputText { get; set; }

		// Token: 0x17006088 RID: 24712
		// (get) Token: 0x0603035F RID: 197471
		// (set) Token: 0x06030360 RID: 197472
		[Nullable(2)]
		string DefaultText { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006089 RID: 24713
		// (get) Token: 0x06030361 RID: 197473
		// (set) Token: 0x06030362 RID: 197474
		bool IsCheckNone { get; set; }
	}
}
