using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043DE RID: 17374
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeKeyModeRow : IChangeKeyModeRow
	{
		// Token: 0x170057DF RID: 22495
		// (get) Token: 0x0602BE6D RID: 179821 RVA: 0x00C54295 File Offset: 0x00C52495
		// (set) Token: 0x0602BE6E RID: 179822 RVA: 0x00C5429D File Offset: 0x00C5249D
		public string RowSpriteResourceId { get; set; } = "";

		// Token: 0x170057E0 RID: 22496
		// (get) Token: 0x0602BE6F RID: 179823 RVA: 0x00C542A6 File Offset: 0x00C524A6
		// (set) Token: 0x0602BE70 RID: 179824 RVA: 0x00C542AE File Offset: 0x00C524AE
		public string DescriptionA { get; set; } = "";

		// Token: 0x170057E1 RID: 22497
		// (get) Token: 0x0602BE71 RID: 179825 RVA: 0x00C542B7 File Offset: 0x00C524B7
		// (set) Token: 0x0602BE72 RID: 179826 RVA: 0x00C542BF File Offset: 0x00C524BF
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] DescriptionParametersA { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170057E2 RID: 22498
		// (get) Token: 0x0602BE73 RID: 179827 RVA: 0x00C542C8 File Offset: 0x00C524C8
		// (set) Token: 0x0602BE74 RID: 179828 RVA: 0x00C542D0 File Offset: 0x00C524D0
		public string DescriptionB { get; set; } = "";

		// Token: 0x170057E3 RID: 22499
		// (get) Token: 0x0602BE75 RID: 179829 RVA: 0x00C542D9 File Offset: 0x00C524D9
		// (set) Token: 0x0602BE76 RID: 179830 RVA: 0x00C542E1 File Offset: 0x00C524E1
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] DescriptionParametersB { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
