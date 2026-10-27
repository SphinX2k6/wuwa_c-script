using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005169 RID: 20841
	public class IEntityBundleChildInfoT
	{
		// Token: 0x17009803 RID: 38915
		// (get) Token: 0x06021A6C RID: 137836 RVA: 0x004AB796 File Offset: 0x004A9996
		// (set) Token: 0x06021A6D RID: 137837 RVA: 0x004AB79E File Offset: 0x004A999E
		public bool IsDisable { get; set; }

		// Token: 0x17009804 RID: 38916
		// (get) Token: 0x06021A6E RID: 137838 RVA: 0x004AB7A7 File Offset: 0x004A99A7
		// (set) Token: 0x06021A6F RID: 137839 RVA: 0x004AB7AF File Offset: 0x004A99AF
		public int ChildId { get; set; }

		// Token: 0x17009805 RID: 38917
		// (get) Token: 0x06021A70 RID: 137840 RVA: 0x004AB7B8 File Offset: 0x004A99B8
		// (set) Token: 0x06021A71 RID: 137841 RVA: 0x004AB7C0 File Offset: 0x004A99C0
		public int EntityId { get; set; }

		// Token: 0x06021A72 RID: 137842 RVA: 0x004AB7C9 File Offset: 0x004A99C9
		public IEntityBundleChildInfoT()
		{
			this.IsDisable = false;
			this.ChildId = 0;
			this.EntityId = 0;
		}
	}
}
