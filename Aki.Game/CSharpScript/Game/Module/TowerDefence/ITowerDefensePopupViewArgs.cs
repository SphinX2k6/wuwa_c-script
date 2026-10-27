using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B41 RID: 19265
	[NullableContext(1)]
	public interface ITowerDefensePopupViewArgs
	{
		// Token: 0x17007BC3 RID: 31683
		// (get) Token: 0x06031E4A RID: 204362
		// (set) Token: 0x06031E4B RID: 204363
		string TextTitle { get; set; }

		// Token: 0x17007BC4 RID: 31684
		// (get) Token: 0x06031E4C RID: 204364
		// (set) Token: 0x06031E4D RID: 204365
		string TextTips { get; set; }

		// Token: 0x17007BC5 RID: 31685
		// (get) Token: 0x06031E4E RID: 204366
		// (set) Token: 0x06031E4F RID: 204367
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<object> TextTipsArgs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17007BC6 RID: 31686
		// (get) Token: 0x06031E50 RID: 204368
		// (set) Token: 0x06031E51 RID: 204369
		string TextContent { get; set; }

		// Token: 0x17007BC7 RID: 31687
		// (get) Token: 0x06031E52 RID: 204370
		// (set) Token: 0x06031E53 RID: 204371
		[Nullable(2)]
		Action ConfirmBack { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007BC8 RID: 31688
		// (get) Token: 0x06031E54 RID: 204372
		// (set) Token: 0x06031E55 RID: 204373
		[Nullable(2)]
		Action CancelBack { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
