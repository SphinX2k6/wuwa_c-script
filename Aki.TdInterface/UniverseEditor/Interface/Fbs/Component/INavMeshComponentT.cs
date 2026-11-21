using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B86 RID: 23430
	public class INavMeshComponentT
	{
		// Token: 0x1700AB47 RID: 43847
		// (get) Token: 0x060269D8 RID: 158168 RVA: 0x00549B85 File Offset: 0x00547D85
		// (set) Token: 0x060269D9 RID: 158169 RVA: 0x00549B8D File Offset: 0x00547D8D
		public bool Disabled { get; set; }

		// Token: 0x1700AB48 RID: 43848
		// (get) Token: 0x060269DA RID: 158170 RVA: 0x00549B96 File Offset: 0x00547D96
		// (set) Token: 0x060269DB RID: 158171 RVA: 0x00549B9E File Offset: 0x00547D9E
		public INavMeshAkiEntitySourceT Source { get; set; }

		// Token: 0x1700AB49 RID: 43849
		// (get) Token: 0x060269DC RID: 158172 RVA: 0x00549BA7 File Offset: 0x00547DA7
		// (set) Token: 0x060269DD RID: 158173 RVA: 0x00549BAF File Offset: 0x00547DAF
		public byte NullMask { get; set; }

		// Token: 0x060269DE RID: 158174 RVA: 0x00549BB8 File Offset: 0x00547DB8
		public INavMeshComponentT()
		{
			this.Disabled = false;
			this.Source = null;
			this.NullMask = 0;
		}
	}
}
