using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060E1 RID: 24801
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTalentTreeNodeRowData
	{
		// Token: 0x0603EB37 RID: 256823 RVA: 0x00F2505C File Offset: 0x00F2325C
		public RoverlikeTalentTreeNodeRowData(int row, List<RoverlikeTalentNodeData> nodeList)
		{
			this.Row = row;
			this.NodeList = nodeList;
		}

		// Token: 0x04020C71 RID: 134257
		public int Row;

		// Token: 0x04020C72 RID: 134258
		public List<RoverlikeTalentNodeData> NodeList = new List<RoverlikeTalentNodeData>();
	}
}
