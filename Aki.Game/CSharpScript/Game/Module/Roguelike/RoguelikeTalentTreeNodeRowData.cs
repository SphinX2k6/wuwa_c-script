using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D87 RID: 19847
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeTalentTreeNodeRowData
	{
		// Token: 0x060334E1 RID: 210145 RVA: 0x00BF992B File Offset: 0x00BF7B2B
		public RoguelikeTalentTreeNodeRowData(int row, List<RoguelikeTalentTreeNodeData> nodeList)
		{
			this.Row = row;
			this.NodeList = nodeList;
		}

		// Token: 0x0401B3AD RID: 111533
		public int Row;

		// Token: 0x0401B3AE RID: 111534
		public List<RoguelikeTalentTreeNodeData> NodeList = new List<RoguelikeTalentTreeNodeData>();
	}
}
