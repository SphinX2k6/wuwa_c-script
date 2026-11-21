using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AEA RID: 15082
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePopupViewArgs : ITowerDefensePopupViewArgs
	{
		// Token: 0x17004F76 RID: 20342
		// (get) Token: 0x06026BE6 RID: 158694 RVA: 0x00AD6A7A File Offset: 0x00AD4C7A
		// (set) Token: 0x06026BE7 RID: 158695 RVA: 0x00AD6A82 File Offset: 0x00AD4C82
		public string TextTitle { get; set; }

		// Token: 0x17004F77 RID: 20343
		// (get) Token: 0x06026BE8 RID: 158696 RVA: 0x00AD6A8B File Offset: 0x00AD4C8B
		// (set) Token: 0x06026BE9 RID: 158697 RVA: 0x00AD6A93 File Offset: 0x00AD4C93
		public string TextTips { get; set; }

		// Token: 0x17004F78 RID: 20344
		// (get) Token: 0x06026BEA RID: 158698 RVA: 0x00AD6A9C File Offset: 0x00AD4C9C
		// (set) Token: 0x06026BEB RID: 158699 RVA: 0x00AD6AA4 File Offset: 0x00AD4CA4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<object> TextTipsArgs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17004F79 RID: 20345
		// (get) Token: 0x06026BEC RID: 158700 RVA: 0x00AD6AAD File Offset: 0x00AD4CAD
		// (set) Token: 0x06026BED RID: 158701 RVA: 0x00AD6AB5 File Offset: 0x00AD4CB5
		public string TextContent { get; set; }

		// Token: 0x17004F7A RID: 20346
		// (get) Token: 0x06026BEE RID: 158702 RVA: 0x00AD6ABE File Offset: 0x00AD4CBE
		// (set) Token: 0x06026BEF RID: 158703 RVA: 0x00AD6AC6 File Offset: 0x00AD4CC6
		[Nullable(2)]
		public Action ConfirmBack { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004F7B RID: 20347
		// (get) Token: 0x06026BF0 RID: 158704 RVA: 0x00AD6ACF File Offset: 0x00AD4CCF
		// (set) Token: 0x06026BF1 RID: 158705 RVA: 0x00AD6AD7 File Offset: 0x00AD4CD7
		[Nullable(2)]
		public Action CancelBack { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
