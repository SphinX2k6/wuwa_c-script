using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D50 RID: 15696
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeTalentTreeNodeRowData
	{
		// Token: 0x0602834E RID: 164686 RVA: 0x00B42F27 File Offset: 0x00B41127
		public RoguelikeTalentTreeNodeRowData(int row, List<RoguelikeTalentTreeNodeData> nodeList)
		{
			this.Row = row;
			this.NodeList = nodeList;
		}

		// Token: 0x04015D80 RID: 89472
		public int Row;

		// Token: 0x04015D81 RID: 89473
		public List<RoguelikeTalentTreeNodeData> NodeList = new List<RoguelikeTalentTreeNodeData>();
	}
}
