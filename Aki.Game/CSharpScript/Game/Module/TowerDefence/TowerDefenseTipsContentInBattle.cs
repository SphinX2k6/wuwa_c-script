using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AE4 RID: 15076
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseTipsContentInBattle : ITowerDefenseTipsContentInBattle
	{
		// Token: 0x17004F5F RID: 20319
		// (get) Token: 0x06026BB5 RID: 158645 RVA: 0x00AD69A7 File Offset: 0x00AD4BA7
		// (set) Token: 0x06026BB6 RID: 158646 RVA: 0x00AD69AF File Offset: 0x00AD4BAF
		public string TitleTextId { get; set; }

		// Token: 0x17004F60 RID: 20320
		// (get) Token: 0x06026BB7 RID: 158647 RVA: 0x00AD69B8 File Offset: 0x00AD4BB8
		// (set) Token: 0x06026BB8 RID: 158648 RVA: 0x00AD69C0 File Offset: 0x00AD4BC0
		public string PhantomTextId { get; set; }

		// Token: 0x17004F61 RID: 20321
		// (get) Token: 0x06026BB9 RID: 158649 RVA: 0x00AD69C9 File Offset: 0x00AD4BC9
		// (set) Token: 0x06026BBA RID: 158650 RVA: 0x00AD69D1 File Offset: 0x00AD4BD1
		public int Level { get; set; }

		// Token: 0x17004F62 RID: 20322
		// (get) Token: 0x06026BBB RID: 158651 RVA: 0x00AD69DA File Offset: 0x00AD4BDA
		// (set) Token: 0x06026BBC RID: 158652 RVA: 0x00AD69E2 File Offset: 0x00AD4BE2
		public string DescTextId { get; set; }

		// Token: 0x17004F63 RID: 20323
		// (get) Token: 0x06026BBD RID: 158653 RVA: 0x00AD69EB File Offset: 0x00AD4BEB
		// (set) Token: 0x06026BBE RID: 158654 RVA: 0x00AD69F3 File Offset: 0x00AD4BF3
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
