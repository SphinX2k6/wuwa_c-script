using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200640E RID: 25614
	public class IGiantStableValueT
	{
		// Token: 0x1700BD33 RID: 48435
		// (get) Token: 0x0602B84A RID: 178250 RVA: 0x005ED3D8 File Offset: 0x005EB5D8
		// (set) Token: 0x0602B84B RID: 178251 RVA: 0x005ED3E0 File Offset: 0x005EB5E0
		public EGiantStableValueBoundary Boundary { get; set; }

		// Token: 0x1700BD34 RID: 48436
		// (get) Token: 0x0602B84C RID: 178252 RVA: 0x005ED3E9 File Offset: 0x005EB5E9
		// (set) Token: 0x0602B84D RID: 178253 RVA: 0x005ED3F1 File Offset: 0x005EB5F1
		public int Value { get; set; }

		// Token: 0x0602B84E RID: 178254 RVA: 0x005ED3FA File Offset: 0x005EB5FA
		public IGiantStableValueT()
		{
			this.Boundary = EGiantStableValueBoundary.Open;
			this.Value = 0;
		}
	}
}
