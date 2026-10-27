using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D3 RID: 26323
	public class IEnterSpecMovieCameraT
	{
		// Token: 0x1700C38E RID: 50062
		// (get) Token: 0x0602DC29 RID: 187433 RVA: 0x00642573 File Offset: 0x00640773
		// (set) Token: 0x0602DC2A RID: 187434 RVA: 0x0064257B File Offset: 0x0064077B
		public EMovieCameraType Type { get; set; }

		// Token: 0x1700C38F RID: 50063
		// (get) Token: 0x0602DC2B RID: 187435 RVA: 0x00642584 File Offset: 0x00640784
		// (set) Token: 0x0602DC2C RID: 187436 RVA: 0x0064258C File Offset: 0x0064078C
		public string RowName { get; set; }

		// Token: 0x0602DC2D RID: 187437 RVA: 0x00642595 File Offset: 0x00640795
		public IEnterSpecMovieCameraT()
		{
			this.Type = EMovieCameraType.Common;
			this.RowName = null;
		}
	}
}
