using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EBE RID: 16062
	public class IItemTypeVariableT
	{
		// Token: 0x17006F7F RID: 28543
		// (get) Token: 0x06016B2D RID: 92973 RVA: 0x00346FCD File Offset: 0x003451CD
		// (set) Token: 0x06016B2E RID: 92974 RVA: 0x00346FD5 File Offset: 0x003451D5
		public EHandInItemType Type { get; set; }

		// Token: 0x17006F80 RID: 28544
		// (get) Token: 0x06016B2F RID: 92975 RVA: 0x00346FDE File Offset: 0x003451DE
		// (set) Token: 0x06016B30 RID: 92976 RVA: 0x00346FE6 File Offset: 0x003451E6
		public TVarRefUnion Var { get; set; }

		// Token: 0x17006F81 RID: 28545
		// (get) Token: 0x06016B31 RID: 92977 RVA: 0x00346FEF File Offset: 0x003451EF
		// (set) Token: 0x06016B32 RID: 92978 RVA: 0x00346FF7 File Offset: 0x003451F7
		public int ItemType { get; set; }

		// Token: 0x06016B33 RID: 92979 RVA: 0x00347000 File Offset: 0x00345200
		public IItemTypeVariableT()
		{
			this.Type = EHandInItemType.ItemIds;
			this.Var = null;
			this.ItemType = 0;
		}
	}
}
