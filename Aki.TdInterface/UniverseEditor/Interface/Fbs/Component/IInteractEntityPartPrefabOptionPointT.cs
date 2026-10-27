using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005453 RID: 21587
	public class IInteractEntityPartPrefabOptionPointT
	{
		// Token: 0x17009EEF RID: 40687
		// (get) Token: 0x06023823 RID: 145443 RVA: 0x004E9BC2 File Offset: 0x004E7DC2
		// (set) Token: 0x06023824 RID: 145444 RVA: 0x004E9BCA File Offset: 0x004E7DCA
		public string UiStyle { get; set; }

		// Token: 0x17009EF0 RID: 40688
		// (get) Token: 0x06023825 RID: 145445 RVA: 0x004E9BD3 File Offset: 0x004E7DD3
		// (set) Token: 0x06023826 RID: 145446 RVA: 0x004E9BDB File Offset: 0x004E7DDB
		public string BindName { get; set; }

		// Token: 0x06023827 RID: 145447 RVA: 0x004E9BE4 File Offset: 0x004E7DE4
		public IInteractEntityPartPrefabOptionPointT()
		{
			this.UiStyle = null;
			this.BindName = null;
		}
	}
}
