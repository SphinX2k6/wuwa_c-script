using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02005B7C RID: 23420
	[NullableContext(1)]
	[Nullable(0)]
	public class TextInputData : ITextInputData
	{
		// Token: 0x17008CB8 RID: 36024
		// (get) Token: 0x0603B416 RID: 242710 RVA: 0x00E201AB File Offset: 0x00E1E3AB
		// (set) Token: 0x0603B417 RID: 242711 RVA: 0x00E201B3 File Offset: 0x00E1E3B3
		public TConfirm ConfirmFunc { get; set; }

		// Token: 0x17008CB9 RID: 36025
		// (get) Token: 0x0603B418 RID: 242712 RVA: 0x00E201BC File Offset: 0x00E1E3BC
		// (set) Token: 0x0603B419 RID: 242713 RVA: 0x00E201C4 File Offset: 0x00E1E3C4
		public TResult ResultFunc { get; set; }

		// Token: 0x17008CBA RID: 36026
		// (get) Token: 0x0603B41A RID: 242714 RVA: 0x00E201CD File Offset: 0x00E1E3CD
		// (set) Token: 0x0603B41B RID: 242715 RVA: 0x00E201D5 File Offset: 0x00E1E3D5
		public string InputText { get; set; }

		// Token: 0x17008CBB RID: 36027
		// (get) Token: 0x0603B41C RID: 242716 RVA: 0x00E201DE File Offset: 0x00E1E3DE
		// (set) Token: 0x0603B41D RID: 242717 RVA: 0x00E201E6 File Offset: 0x00E1E3E6
		[Nullable(2)]
		public string DefaultText { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008CBC RID: 36028
		// (get) Token: 0x0603B41E RID: 242718 RVA: 0x00E201EF File Offset: 0x00E1E3EF
		// (set) Token: 0x0603B41F RID: 242719 RVA: 0x00E201F7 File Offset: 0x00E1E3F7
		public bool IsCheckNone { get; set; }
	}
}
