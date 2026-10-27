using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200544D RID: 21581
	public class IInteractEntityPartModelOptionPointT
	{
		// Token: 0x17009EE5 RID: 40677
		// (get) Token: 0x060237ED RID: 145389 RVA: 0x004E95B2 File Offset: 0x004E77B2
		// (set) Token: 0x060237EE RID: 145390 RVA: 0x004E95BA File Offset: 0x004E77BA
		public string UiStyle { get; set; }

		// Token: 0x17009EE6 RID: 40678
		// (get) Token: 0x060237EF RID: 145391 RVA: 0x004E95C3 File Offset: 0x004E77C3
		// (set) Token: 0x060237F0 RID: 145392 RVA: 0x004E95CB File Offset: 0x004E77CB
		public string BindName { get; set; }

		// Token: 0x060237F1 RID: 145393 RVA: 0x004E95D4 File Offset: 0x004E77D4
		public IInteractEntityPartModelOptionPointT()
		{
			this.UiStyle = null;
			this.BindName = null;
		}
	}
}
