using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E0 RID: 26848
	public class IHealthBarDisplayClientFunctionT
	{
		// Token: 0x1700C72D RID: 50989
		// (get) Token: 0x0602ED3C RID: 191804 RVA: 0x00663922 File Offset: 0x00661B22
		// (set) Token: 0x0602ED3D RID: 191805 RVA: 0x0066392A File Offset: 0x00661B2A
		public EEnableClientFunctionType Type { get; set; }

		// Token: 0x1700C72E RID: 50990
		// (get) Token: 0x0602ED3E RID: 191806 RVA: 0x00663933 File Offset: 0x00661B33
		// (set) Token: 0x0602ED3F RID: 191807 RVA: 0x0066393B File Offset: 0x00661B3B
		public int EntityId { get; set; }

		// Token: 0x1700C72F RID: 50991
		// (get) Token: 0x0602ED40 RID: 191808 RVA: 0x00663944 File Offset: 0x00661B44
		// (set) Token: 0x0602ED41 RID: 191809 RVA: 0x0066394C File Offset: 0x00661B4C
		public bool IsVisible { get; set; }

		// Token: 0x0602ED42 RID: 191810 RVA: 0x00663955 File Offset: 0x00661B55
		public IHealthBarDisplayClientFunctionT()
		{
			this.Type = EEnableClientFunctionType.HealthBarDisplay;
			this.EntityId = 0;
			this.IsVisible = false;
		}
	}
}
