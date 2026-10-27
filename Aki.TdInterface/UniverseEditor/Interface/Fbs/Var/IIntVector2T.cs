using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AA0 RID: 15008
	public class IIntVector2T
	{
		// Token: 0x170066D3 RID: 26323
		// (get) Token: 0x060145FA RID: 83450 RVA: 0x002F8B4E File Offset: 0x002F6D4E
		// (set) Token: 0x060145FB RID: 83451 RVA: 0x002F8B56 File Offset: 0x002F6D56
		public int X { get; set; }

		// Token: 0x170066D4 RID: 26324
		// (get) Token: 0x060145FC RID: 83452 RVA: 0x002F8B5F File Offset: 0x002F6D5F
		// (set) Token: 0x060145FD RID: 83453 RVA: 0x002F8B67 File Offset: 0x002F6D67
		public int Y { get; set; }

		// Token: 0x170066D5 RID: 26325
		// (get) Token: 0x060145FE RID: 83454 RVA: 0x002F8B70 File Offset: 0x002F6D70
		// (set) Token: 0x060145FF RID: 83455 RVA: 0x002F8B78 File Offset: 0x002F6D78
		public byte NullMask { get; set; }

		// Token: 0x06014600 RID: 83456 RVA: 0x002F8B81 File Offset: 0x002F6D81
		public IIntVector2T()
		{
			this.X = 0;
			this.Y = 0;
			this.NullMask = 0;
		}
	}
}
