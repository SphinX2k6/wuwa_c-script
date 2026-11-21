using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.InputView.View
{
	// Token: 0x02004B5C RID: 19292
	[NullableContext(1)]
	[Nullable(0)]
	public class TextInputData : ITextInputData
	{
		// Token: 0x1700608A RID: 24714
		// (get) Token: 0x06030363 RID: 197475 RVA: 0x00D7071F File Offset: 0x00D6E91F
		// (set) Token: 0x06030364 RID: 197476 RVA: 0x00D70727 File Offset: 0x00D6E927
		public TConfirm ConfirmFunc { get; set; }

		// Token: 0x1700608B RID: 24715
		// (get) Token: 0x06030365 RID: 197477 RVA: 0x00D70730 File Offset: 0x00D6E930
		// (set) Token: 0x06030366 RID: 197478 RVA: 0x00D70738 File Offset: 0x00D6E938
		public TResult ResultFunc { get; set; }

		// Token: 0x1700608C RID: 24716
		// (get) Token: 0x06030367 RID: 197479 RVA: 0x00D70741 File Offset: 0x00D6E941
		// (set) Token: 0x06030368 RID: 197480 RVA: 0x00D70749 File Offset: 0x00D6E949
		public string InputText { get; set; }

		// Token: 0x1700608D RID: 24717
		// (get) Token: 0x06030369 RID: 197481 RVA: 0x00D70752 File Offset: 0x00D6E952
		// (set) Token: 0x0603036A RID: 197482 RVA: 0x00D7075A File Offset: 0x00D6E95A
		[Nullable(2)]
		public string DefaultText { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700608E RID: 24718
		// (get) Token: 0x0603036B RID: 197483 RVA: 0x00D70763 File Offset: 0x00D6E963
		// (set) Token: 0x0603036C RID: 197484 RVA: 0x00D7076B File Offset: 0x00D6E96B
		public bool IsCheckNone { get; set; }
	}
}
