using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200695C RID: 26972
	public class IChangeEntityStateT
	{
		// Token: 0x1700C681 RID: 50817
		// (get) Token: 0x0602E3B6 RID: 189366 RVA: 0x006505E4 File Offset: 0x0064E7E4
		// (set) Token: 0x0602E3B7 RID: 189367 RVA: 0x006505EC File Offset: 0x0064E7EC
		public EChangeEntityState Type { get; set; }

		// Token: 0x1700C682 RID: 50818
		// (get) Token: 0x0602E3B8 RID: 189368 RVA: 0x006505F5 File Offset: 0x0064E7F5
		// (set) Token: 0x0602E3B9 RID: 189369 RVA: 0x006505FD File Offset: 0x0064E7FD
		public int EntityId { get; set; }

		// Token: 0x0602E3BA RID: 189370 RVA: 0x00650606 File Offset: 0x0064E806
		public IChangeEntityStateT()
		{
			this.Type = EChangeEntityState.Directly;
			this.EntityId = 0;
		}
	}
}
