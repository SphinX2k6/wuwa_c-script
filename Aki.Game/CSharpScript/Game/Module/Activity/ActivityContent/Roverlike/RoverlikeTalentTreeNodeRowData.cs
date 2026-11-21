using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200505F RID: 20575
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTalentTreeNodeRowData
	{
		// Token: 0x060337F9 RID: 210937 RVA: 0x00E6BEB4 File Offset: 0x00E6A0B4
		public RoverlikeTalentTreeNodeRowData(int row, List<RoverlikeTalentNodeData> nodeList)
		{
			this.Row = row;
			this.NodeList = nodeList;
		}

		// Token: 0x0401B59E RID: 112030
		public int Row;

		// Token: 0x0401B59F RID: 112031
		public List<RoverlikeTalentNodeData> NodeList = new List<RoverlikeTalentNodeData>();
	}
}
