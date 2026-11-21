using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003433 RID: 13363
	[NullableContext(1)]
	[Nullable(0)]
	public class Node : INode
	{
		// Token: 0x170046A3 RID: 18083
		// (get) Token: 0x06021EE4 RID: 138980 RVA: 0x00970D0B File Offset: 0x0096EF0B
		// (set) Token: 0x06021EE5 RID: 138981 RVA: 0x00970D13 File Offset: 0x0096EF13
		public ENodeType NodeType { get; set; }

		// Token: 0x170046A4 RID: 18084
		// (get) Token: 0x06021EE6 RID: 138982 RVA: 0x00970D1C File Offset: 0x0096EF1C
		// (set) Token: 0x06021EE7 RID: 138983 RVA: 0x00970D24 File Offset: 0x0096EF24
		public string Name { get; set; } = string.Empty;

		// Token: 0x170046A5 RID: 18085
		// (get) Token: 0x06021EE8 RID: 138984 RVA: 0x00970D2D File Offset: 0x0096EF2D
		// (set) Token: 0x06021EE9 RID: 138985 RVA: 0x00970D35 File Offset: 0x0096EF35
		public TFormulaValue Value { get; set; }

		// Token: 0x170046A6 RID: 18086
		// (get) Token: 0x06021EEA RID: 138986 RVA: 0x00970D3E File Offset: 0x0096EF3E
		// (set) Token: 0x06021EEB RID: 138987 RVA: 0x00970D46 File Offset: 0x0096EF46
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<INode> Children { [return: Nullable(new byte[]
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
