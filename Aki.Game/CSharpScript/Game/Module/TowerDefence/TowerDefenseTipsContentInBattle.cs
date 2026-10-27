using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B3C RID: 19260
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseTipsContentInBattle : ITowerDefenseTipsContentInBattle
	{
		// Token: 0x17007BB2 RID: 31666
		// (get) Token: 0x06031E25 RID: 204325 RVA: 0x00B92943 File Offset: 0x00B90B43
		// (set) Token: 0x06031E26 RID: 204326 RVA: 0x00B9294B File Offset: 0x00B90B4B
		public string TitleTextId { get; set; }

		// Token: 0x17007BB3 RID: 31667
		// (get) Token: 0x06031E27 RID: 204327 RVA: 0x00B92954 File Offset: 0x00B90B54
		// (set) Token: 0x06031E28 RID: 204328 RVA: 0x00B9295C File Offset: 0x00B90B5C
		public string PhantomTextId { get; set; }

		// Token: 0x17007BB4 RID: 31668
		// (get) Token: 0x06031E29 RID: 204329 RVA: 0x00B92965 File Offset: 0x00B90B65
		// (set) Token: 0x06031E2A RID: 204330 RVA: 0x00B9296D File Offset: 0x00B90B6D
		public int Level { get; set; }

		// Token: 0x17007BB5 RID: 31669
		// (get) Token: 0x06031E2B RID: 204331 RVA: 0x00B92976 File Offset: 0x00B90B76
		// (set) Token: 0x06031E2C RID: 204332 RVA: 0x00B9297E File Offset: 0x00B90B7E
		public string DescTextId { get; set; }

		// Token: 0x17007BB6 RID: 31670
		// (get) Token: 0x06031E2D RID: 204333 RVA: 0x00B92987 File Offset: 0x00B90B87
		// (set) Token: 0x06031E2E RID: 204334 RVA: 0x00B9298F File Offset: 0x00B90B8F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> DescArgs { [return: Nullable(new byte[]
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
