using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039C5 RID: 14789
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeRowData
	{
		// Token: 0x060261A3 RID: 156067 RVA: 0x00AB077B File Offset: 0x00AAE97B
		public static TrapDefenseTalentTreeRowData Create(int row, List<TrapDefenseTalentTreeNodeData> nodeList)
		{
			return new TrapDefenseTalentTreeRowData
			{
				Row = row,
				NodeList = nodeList
			};
		}

		// Token: 0x04014EB1 RID: 85681
		public int Row;

		// Token: 0x04014EB2 RID: 85682
		public List<TrapDefenseTalentTreeNodeData> NodeList = new List<TrapDefenseTalentTreeNodeData>();
	}
}
