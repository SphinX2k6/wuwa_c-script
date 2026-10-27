using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x020047CB RID: 18379
	[NullableContext(2)]
	[Nullable(0)]
	public class NavigateIconItemData : INavigateIconItemData
	{
		// Token: 0x170078A7 RID: 30887
		// (get) Token: 0x060302AA RID: 197290 RVA: 0x00B29A22 File Offset: 0x00B27C22
		// (set) Token: 0x060302AB RID: 197291 RVA: 0x00B29A2A File Offset: 0x00B27C2A
		public int Id { get; set; }

		// Token: 0x170078A8 RID: 30888
		// (get) Token: 0x060302AC RID: 197292 RVA: 0x00B29A33 File Offset: 0x00B27C33
		// (set) Token: 0x060302AD RID: 197293 RVA: 0x00B29A3B File Offset: 0x00B27C3B
		public string IconId { get; set; }

		// Token: 0x170078A9 RID: 30889
		// (get) Token: 0x060302AE RID: 197294 RVA: 0x00B29A44 File Offset: 0x00B27C44
		// (set) Token: 0x060302AF RID: 197295 RVA: 0x00B29A4C File Offset: 0x00B27C4C
		public string IconPath { get; set; }

		// Token: 0x170078AA RID: 30890
		// (get) Token: 0x060302B0 RID: 197296 RVA: 0x00B29A55 File Offset: 0x00B27C55
		// (set) Token: 0x060302B1 RID: 197297 RVA: 0x00B29A5D File Offset: 0x00B27C5D
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public Action<int, MarkItem> ClickCallback { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			1,
			2
		})] set; }

		// Token: 0x170078AB RID: 30891
		// (get) Token: 0x060302B2 RID: 197298 RVA: 0x00B29A66 File Offset: 0x00B27C66
		// (set) Token: 0x060302B3 RID: 197299 RVA: 0x00B29A6E File Offset: 0x00B27C6E
		public MarkItem MarkItem { get; set; }
	}
}
