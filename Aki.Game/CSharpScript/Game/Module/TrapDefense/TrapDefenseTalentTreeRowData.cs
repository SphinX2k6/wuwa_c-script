using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A1D RID: 18973
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeRowData
	{
		// Token: 0x06031413 RID: 201747 RVA: 0x00B6C77F File Offset: 0x00B6A97F
		public static TrapDefenseTalentTreeRowData Create(int row, List<TrapDefenseTalentTreeNodeData> nodeList)
		{
			return new TrapDefenseTalentTreeRowData
			{
				Row = row,
				NodeList = nodeList
			};
		}

		// Token: 0x0401A55A RID: 107866
		public int Row;

		// Token: 0x0401A55B RID: 107867
		public List<TrapDefenseTalentTreeNodeData> NodeList = new List<TrapDefenseTalentTreeNodeData>();
	}
}
