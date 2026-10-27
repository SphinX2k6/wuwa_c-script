using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B42 RID: 19266
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePopupViewArgs : ITowerDefensePopupViewArgs
	{
		// Token: 0x17007BC9 RID: 31689
		// (get) Token: 0x06031E56 RID: 204374 RVA: 0x00B92A16 File Offset: 0x00B90C16
		// (set) Token: 0x06031E57 RID: 204375 RVA: 0x00B92A1E File Offset: 0x00B90C1E
		public string TextTitle { get; set; }

		// Token: 0x17007BCA RID: 31690
		// (get) Token: 0x06031E58 RID: 204376 RVA: 0x00B92A27 File Offset: 0x00B90C27
		// (set) Token: 0x06031E59 RID: 204377 RVA: 0x00B92A2F File Offset: 0x00B90C2F
		public string TextTips { get; set; }

		// Token: 0x17007BCB RID: 31691
		// (get) Token: 0x06031E5A RID: 204378 RVA: 0x00B92A38 File Offset: 0x00B90C38
		// (set) Token: 0x06031E5B RID: 204379 RVA: 0x00B92A40 File Offset: 0x00B90C40
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

		// Token: 0x17007BCC RID: 31692
		// (get) Token: 0x06031E5C RID: 204380 RVA: 0x00B92A49 File Offset: 0x00B90C49
		// (set) Token: 0x06031E5D RID: 204381 RVA: 0x00B92A51 File Offset: 0x00B90C51
		public string TextContent { get; set; }

		// Token: 0x17007BCD RID: 31693
		// (get) Token: 0x06031E5E RID: 204382 RVA: 0x00B92A5A File Offset: 0x00B90C5A
		// (set) Token: 0x06031E5F RID: 204383 RVA: 0x00B92A62 File Offset: 0x00B90C62
		[Nullable(2)]
		public Action ConfirmBack { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007BCE RID: 31694
		// (get) Token: 0x06031E60 RID: 204384 RVA: 0x00B92A6B File Offset: 0x00B90C6B
		// (set) Token: 0x06031E61 RID: 204385 RVA: 0x00B92A73 File Offset: 0x00B90C73
		[Nullable(2)]
		public Action CancelBack { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
