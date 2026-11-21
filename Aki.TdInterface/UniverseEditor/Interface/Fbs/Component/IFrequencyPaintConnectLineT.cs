using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200584B RID: 22603
	public class IFrequencyPaintConnectLineT
	{
		// Token: 0x1700A3BD RID: 41917
		// (get) Token: 0x060249F7 RID: 150007 RVA: 0x00508441 File Offset: 0x00506641
		// (set) Token: 0x060249F8 RID: 150008 RVA: 0x00508449 File Offset: 0x00506649
		public EFrequencyPaintLineType Type { get; set; }

		// Token: 0x1700A3BE RID: 41918
		// (get) Token: 0x060249F9 RID: 150009 RVA: 0x00508452 File Offset: 0x00506652
		// (set) Token: 0x060249FA RID: 150010 RVA: 0x0050845A File Offset: 0x0050665A
		public int EntityTarget { get; set; }

		// Token: 0x1700A3BF RID: 41919
		// (get) Token: 0x060249FB RID: 150011 RVA: 0x00508463 File Offset: 0x00506663
		// (set) Token: 0x060249FC RID: 150012 RVA: 0x0050846B File Offset: 0x0050666B
		public string EntityState { get; set; }

		// Token: 0x060249FD RID: 150013 RVA: 0x00508474 File Offset: 0x00506674
		public IFrequencyPaintConnectLineT()
		{
			this.Type = EFrequencyPaintLineType.Straight;
			this.EntityTarget = 0;
			this.EntityState = null;
		}
	}
}
