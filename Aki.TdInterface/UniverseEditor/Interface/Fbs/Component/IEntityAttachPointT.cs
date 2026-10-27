using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005151 RID: 20817
	public class IEntityAttachPointT
	{
		// Token: 0x170097D4 RID: 38868
		// (get) Token: 0x060219A0 RID: 137632 RVA: 0x004A9DFB File Offset: 0x004A7FFB
		// (set) Token: 0x060219A1 RID: 137633 RVA: 0x004A9E03 File Offset: 0x004A8003
		public string Name { get; set; }

		// Token: 0x170097D5 RID: 38869
		// (get) Token: 0x060219A2 RID: 137634 RVA: 0x004A9E0C File Offset: 0x004A800C
		// (set) Token: 0x060219A3 RID: 137635 RVA: 0x004A9E14 File Offset: 0x004A8014
		public IVectorInfoT AttachPoint { get; set; }

		// Token: 0x060219A4 RID: 137636 RVA: 0x004A9E1D File Offset: 0x004A801D
		public IEntityAttachPointT()
		{
			this.Name = null;
			this.AttachPoint = null;
		}
	}
}
