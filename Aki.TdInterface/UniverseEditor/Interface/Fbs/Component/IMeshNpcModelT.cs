using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200554F RID: 21839
	public class IMeshNpcModelT
	{
		// Token: 0x1700A14C RID: 41292
		// (get) Token: 0x060241B9 RID: 147897 RVA: 0x004FD043 File Offset: 0x004FB243
		// (set) Token: 0x060241BA RID: 147898 RVA: 0x004FD04B File Offset: 0x004FB24B
		public ENpcModelType Type { get; set; }

		// Token: 0x1700A14D RID: 41293
		// (get) Token: 0x060241BB RID: 147899 RVA: 0x004FD054 File Offset: 0x004FB254
		// (set) Token: 0x060241BC RID: 147900 RVA: 0x004FD05C File Offset: 0x004FB25C
		public string Mesh { get; set; }

		// Token: 0x060241BD RID: 147901 RVA: 0x004FD065 File Offset: 0x004FB265
		public IMeshNpcModelT()
		{
			this.Type = ENpcModelType.Mesh;
			this.Mesh = null;
		}
	}
}
