using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007014 RID: 28692
	public class ISetJigsawItemTypeT
	{
		// Token: 0x1700D510 RID: 54544
		// (get) Token: 0x06032BFF RID: 207871 RVA: 0x006D8CE2 File Offset: 0x006D6EE2
		// (set) Token: 0x06032C00 RID: 207872 RVA: 0x006D8CEA File Offset: 0x006D6EEA
		public ESetJigsawItemType Type { get; set; }

		// Token: 0x06032C01 RID: 207873 RVA: 0x006D8CF3 File Offset: 0x006D6EF3
		public ISetJigsawItemTypeT()
		{
			this.Type = ESetJigsawItemType.MoveJigsawItem;
		}
	}
}
