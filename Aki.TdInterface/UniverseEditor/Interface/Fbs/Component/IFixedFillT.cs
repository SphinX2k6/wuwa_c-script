using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D9 RID: 22489
	public class IFixedFillT
	{
		// Token: 0x1700A29E RID: 41630
		// (get) Token: 0x0602451F RID: 148767 RVA: 0x004FD801 File Offset: 0x004FBA01
		// (set) Token: 0x06024520 RID: 148768 RVA: 0x004FD809 File Offset: 0x004FBA09
		public EFillType Type { get; set; }

		// Token: 0x1700A29F RID: 41631
		// (get) Token: 0x06024521 RID: 148769 RVA: 0x004FD812 File Offset: 0x004FBA12
		// (set) Token: 0x06024522 RID: 148770 RVA: 0x004FD81A File Offset: 0x004FBA1A
		public int ModelId { get; set; }

		// Token: 0x1700A2A0 RID: 41632
		// (get) Token: 0x06024523 RID: 148771 RVA: 0x004FD823 File Offset: 0x004FBA23
		// (set) Token: 0x06024524 RID: 148772 RVA: 0x004FD82B File Offset: 0x004FBA2B
		public IPieceIndexT Centre { get; set; }

		// Token: 0x1700A2A1 RID: 41633
		// (get) Token: 0x06024525 RID: 148773 RVA: 0x004FD834 File Offset: 0x004FBA34
		// (set) Token: 0x06024526 RID: 148774 RVA: 0x004FD83C File Offset: 0x004FBA3C
		public IJigsawConfigT Config { get; set; }

		// Token: 0x1700A2A2 RID: 41634
		// (get) Token: 0x06024527 RID: 148775 RVA: 0x004FD845 File Offset: 0x004FBA45
		// (set) Token: 0x06024528 RID: 148776 RVA: 0x004FD84D File Offset: 0x004FBA4D
		public byte NullMask { get; set; }

		// Token: 0x06024529 RID: 148777 RVA: 0x004FD856 File Offset: 0x004FBA56
		public IFixedFillT()
		{
			this.Type = EFillType.Fixed;
			this.ModelId = 0;
			this.Centre = null;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
