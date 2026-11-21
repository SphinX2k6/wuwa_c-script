using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF6 RID: 23286
	public class IModelIdT
	{
		// Token: 0x1700A9F0 RID: 43504
		// (get) Token: 0x06026428 RID: 156712 RVA: 0x0053E0E4 File Offset: 0x0053C2E4
		// (set) Token: 0x06026429 RID: 156713 RVA: 0x0053E0EC File Offset: 0x0053C2EC
		public EModelType Type { get; set; }

		// Token: 0x1700A9F1 RID: 43505
		// (get) Token: 0x0602642A RID: 156714 RVA: 0x0053E0F5 File Offset: 0x0053C2F5
		// (set) Token: 0x0602642B RID: 156715 RVA: 0x0053E0FD File Offset: 0x0053C2FD
		public int ModelId { get; set; }

		// Token: 0x0602642C RID: 156716 RVA: 0x0053E106 File Offset: 0x0053C306
		public IModelIdT()
		{
			this.Type = EModelType.LevelPrefab;
			this.ModelId = 0;
		}
	}
}
