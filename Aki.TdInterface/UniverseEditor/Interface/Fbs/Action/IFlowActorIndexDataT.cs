using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F0 RID: 26608
	public class IFlowActorIndexDataT
	{
		// Token: 0x1700C57D RID: 50557
		// (get) Token: 0x0602E53D RID: 189757 RVA: 0x006530A3 File Offset: 0x006512A3
		// (set) Token: 0x0602E53E RID: 189758 RVA: 0x006530AB File Offset: 0x006512AB
		public int Index { get; set; }

		// Token: 0x1700C57E RID: 50558
		// (get) Token: 0x0602E53F RID: 189759 RVA: 0x006530B4 File Offset: 0x006512B4
		// (set) Token: 0x0602E540 RID: 189760 RVA: 0x006530BC File Offset: 0x006512BC
		public IPosAndRotT Offset { get; set; }

		// Token: 0x1700C57F RID: 50559
		// (get) Token: 0x0602E541 RID: 189761 RVA: 0x006530C5 File Offset: 0x006512C5
		// (set) Token: 0x0602E542 RID: 189762 RVA: 0x006530CD File Offset: 0x006512CD
		public bool IsUseFixedPosition { get; set; }

		// Token: 0x1700C580 RID: 50560
		// (get) Token: 0x0602E543 RID: 189763 RVA: 0x006530D6 File Offset: 0x006512D6
		// (set) Token: 0x0602E544 RID: 189764 RVA: 0x006530DE File Offset: 0x006512DE
		public byte NullMask { get; set; }

		// Token: 0x0602E545 RID: 189765 RVA: 0x006530E7 File Offset: 0x006512E7
		public IFlowActorIndexDataT()
		{
			this.Index = 0;
			this.Offset = null;
			this.IsUseFixedPosition = false;
			this.NullMask = 0;
		}
	}
}
