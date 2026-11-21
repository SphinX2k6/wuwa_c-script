using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x020036FB RID: 14075
	[NullableContext(2)]
	public interface INavigateIconItemData
	{
		// Token: 0x17004B5F RID: 19295
		// (get) Token: 0x06024A70 RID: 150128
		// (set) Token: 0x06024A71 RID: 150129
		int Id { get; set; }

		// Token: 0x17004B60 RID: 19296
		// (get) Token: 0x06024A72 RID: 150130
		// (set) Token: 0x06024A73 RID: 150131
		string IconId { get; set; }

		// Token: 0x17004B61 RID: 19297
		// (get) Token: 0x06024A74 RID: 150132
		// (set) Token: 0x06024A75 RID: 150133
		string IconPath { get; set; }

		// Token: 0x17004B62 RID: 19298
		// (get) Token: 0x06024A76 RID: 150134
		// (set) Token: 0x06024A77 RID: 150135
		[Nullable(new byte[]
		{
			1,
			2
		})]
		Action<int, MarkItem> ClickCallback { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			1,
			2
		})] set; }

		// Token: 0x17004B63 RID: 19299
		// (get) Token: 0x06024A78 RID: 150136
		// (set) Token: 0x06024A79 RID: 150137
		MarkItem MarkItem { get; set; }
	}
}
