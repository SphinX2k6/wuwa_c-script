using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AA9 RID: 15017
	public class IOtherVarRefT
	{
		// Token: 0x170066FA RID: 26362
		// (get) Token: 0x06014676 RID: 83574 RVA: 0x002F9A29 File Offset: 0x002F7C29
		// (set) Token: 0x06014677 RID: 83575 RVA: 0x002F9A31 File Offset: 0x002F7C31
		public EVar Type { get; set; }

		// Token: 0x170066FB RID: 26363
		// (get) Token: 0x06014678 RID: 83576 RVA: 0x002F9A3A File Offset: 0x002F7C3A
		// (set) Token: 0x06014679 RID: 83577 RVA: 0x002F9A42 File Offset: 0x002F7C42
		public EVarRefSource Source { get; set; }

		// Token: 0x170066FC RID: 26364
		// (get) Token: 0x0601467A RID: 83578 RVA: 0x002F9A4B File Offset: 0x002F7C4B
		// (set) Token: 0x0601467B RID: 83579 RVA: 0x002F9A53 File Offset: 0x002F7C53
		public ERefType RefType { get; set; }

		// Token: 0x170066FD RID: 26365
		// (get) Token: 0x0601467C RID: 83580 RVA: 0x002F9A5C File Offset: 0x002F7C5C
		// (set) Token: 0x0601467D RID: 83581 RVA: 0x002F9A64 File Offset: 0x002F7C64
		public int RefId { get; set; }

		// Token: 0x170066FE RID: 26366
		// (get) Token: 0x0601467E RID: 83582 RVA: 0x002F9A6D File Offset: 0x002F7C6D
		// (set) Token: 0x0601467F RID: 83583 RVA: 0x002F9A75 File Offset: 0x002F7C75
		public string Name { get; set; }

		// Token: 0x06014680 RID: 83584 RVA: 0x002F9A7E File Offset: 0x002F7C7E
		public IOtherVarRefT()
		{
			this.Type = EVar.Boolean;
			this.Source = EVarRefSource.Constant;
			this.RefType = ERefType.Entity;
			this.RefId = 0;
			this.Name = null;
		}
	}
}
