using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200554C RID: 21836
	public class IMeshAnimalModelT
	{
		// Token: 0x1700A147 RID: 41287
		// (get) Token: 0x060241A1 RID: 147873 RVA: 0x004FCE0F File Offset: 0x004FB00F
		// (set) Token: 0x060241A2 RID: 147874 RVA: 0x004FCE17 File Offset: 0x004FB017
		public EAnimalModelType Type { get; set; }

		// Token: 0x1700A148 RID: 41288
		// (get) Token: 0x060241A3 RID: 147875 RVA: 0x004FCE20 File Offset: 0x004FB020
		// (set) Token: 0x060241A4 RID: 147876 RVA: 0x004FCE28 File Offset: 0x004FB028
		public string Mesh { get; set; }

		// Token: 0x060241A5 RID: 147877 RVA: 0x004FCE31 File Offset: 0x004FB031
		public IMeshAnimalModelT()
		{
			this.Type = EAnimalModelType.Mesh;
			this.Mesh = null;
		}
	}
}
