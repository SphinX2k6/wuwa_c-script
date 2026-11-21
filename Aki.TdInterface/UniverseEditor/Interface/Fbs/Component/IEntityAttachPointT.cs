using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B6 RID: 22198
	public class IEntityAttachPointT
	{
		// Token: 0x17009FC1 RID: 40897
		// (get) Token: 0x060238F4 RID: 145652 RVA: 0x004E3D87 File Offset: 0x004E1F87
		// (set) Token: 0x060238F5 RID: 145653 RVA: 0x004E3D8F File Offset: 0x004E1F8F
		public string Name { get; set; }

		// Token: 0x17009FC2 RID: 40898
		// (get) Token: 0x060238F6 RID: 145654 RVA: 0x004E3D98 File Offset: 0x004E1F98
		// (set) Token: 0x060238F7 RID: 145655 RVA: 0x004E3DA0 File Offset: 0x004E1FA0
		public IVectorInfoT AttachPoint { get; set; }

		// Token: 0x060238F8 RID: 145656 RVA: 0x004E3DA9 File Offset: 0x004E1FA9
		public IEntityAttachPointT()
		{
			this.Name = null;
			this.AttachPoint = null;
		}
	}
}
