using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EB8 RID: 16056
	public class IItemIdVariableT
	{
		// Token: 0x17006F71 RID: 28529
		// (get) Token: 0x06016AEA RID: 92906 RVA: 0x003466F5 File Offset: 0x003448F5
		// (set) Token: 0x06016AEB RID: 92907 RVA: 0x003466FD File Offset: 0x003448FD
		public EHandInItemType Type { get; set; }

		// Token: 0x17006F72 RID: 28530
		// (get) Token: 0x06016AEC RID: 92908 RVA: 0x00346706 File Offset: 0x00344906
		// (set) Token: 0x06016AED RID: 92909 RVA: 0x0034670E File Offset: 0x0034490E
		public TVarRefUnion Var { get; set; }

		// Token: 0x17006F73 RID: 28531
		// (get) Token: 0x06016AEE RID: 92910 RVA: 0x00346717 File Offset: 0x00344917
		// (set) Token: 0x06016AEF RID: 92911 RVA: 0x0034671F File Offset: 0x0034491F
		public int ItemId { get; set; }

		// Token: 0x06016AF0 RID: 92912 RVA: 0x00346728 File Offset: 0x00344928
		public IItemIdVariableT()
		{
			this.Type = EHandInItemType.ItemIds;
			this.Var = null;
			this.ItemId = 0;
		}
	}
}
