using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B3B RID: 19259
	[NullableContext(1)]
	public interface ITowerDefenseTipsContentInBattle
	{
		// Token: 0x17007BAD RID: 31661
		// (get) Token: 0x06031E1B RID: 204315
		// (set) Token: 0x06031E1C RID: 204316
		string TitleTextId { get; set; }

		// Token: 0x17007BAE RID: 31662
		// (get) Token: 0x06031E1D RID: 204317
		// (set) Token: 0x06031E1E RID: 204318
		string PhantomTextId { get; set; }

		// Token: 0x17007BAF RID: 31663
		// (get) Token: 0x06031E1F RID: 204319
		// (set) Token: 0x06031E20 RID: 204320
		int Level { get; set; }

		// Token: 0x17007BB0 RID: 31664
		// (get) Token: 0x06031E21 RID: 204321
		// (set) Token: 0x06031E22 RID: 204322
		string DescTextId { get; set; }

		// Token: 0x17007BB1 RID: 31665
		// (get) Token: 0x06031E23 RID: 204323
		// (set) Token: 0x06031E24 RID: 204324
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<string> DescArgs { [return: Nullable(new byte[]
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
