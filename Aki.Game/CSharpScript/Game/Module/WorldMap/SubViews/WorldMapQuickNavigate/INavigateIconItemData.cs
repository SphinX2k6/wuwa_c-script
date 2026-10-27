using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x020047CA RID: 18378
	[NullableContext(2)]
	public interface INavigateIconItemData
	{
		// Token: 0x170078A2 RID: 30882
		// (get) Token: 0x060302A0 RID: 197280
		// (set) Token: 0x060302A1 RID: 197281
		int Id { get; set; }

		// Token: 0x170078A3 RID: 30883
		// (get) Token: 0x060302A2 RID: 197282
		// (set) Token: 0x060302A3 RID: 197283
		string IconId { get; set; }

		// Token: 0x170078A4 RID: 30884
		// (get) Token: 0x060302A4 RID: 197284
		// (set) Token: 0x060302A5 RID: 197285
		string IconPath { get; set; }

		// Token: 0x170078A5 RID: 30885
		// (get) Token: 0x060302A6 RID: 197286
		// (set) Token: 0x060302A7 RID: 197287
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

		// Token: 0x170078A6 RID: 30886
		// (get) Token: 0x060302A8 RID: 197288
		// (set) Token: 0x060302A9 RID: 197289
		MarkItem MarkItem { get; set; }
	}
}
