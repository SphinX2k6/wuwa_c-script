using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AE9 RID: 15081
	[NullableContext(1)]
	public interface ITowerDefensePopupViewArgs
	{
		// Token: 0x17004F70 RID: 20336
		// (get) Token: 0x06026BDA RID: 158682
		// (set) Token: 0x06026BDB RID: 158683
		string TextTitle { get; set; }

		// Token: 0x17004F71 RID: 20337
		// (get) Token: 0x06026BDC RID: 158684
		// (set) Token: 0x06026BDD RID: 158685
		string TextTips { get; set; }

		// Token: 0x17004F72 RID: 20338
		// (get) Token: 0x06026BDE RID: 158686
		// (set) Token: 0x06026BDF RID: 158687
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

		// Token: 0x17004F73 RID: 20339
		// (get) Token: 0x06026BE0 RID: 158688
		// (set) Token: 0x06026BE1 RID: 158689
		string TextContent { get; set; }

		// Token: 0x17004F74 RID: 20340
		// (get) Token: 0x06026BE2 RID: 158690
		// (set) Token: 0x06026BE3 RID: 158691
		[Nullable(2)]
		Action ConfirmBack { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004F75 RID: 20341
		// (get) Token: 0x06026BE4 RID: 158692
		// (set) Token: 0x06026BE5 RID: 158693
		[Nullable(2)]
		Action CancelBack { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
