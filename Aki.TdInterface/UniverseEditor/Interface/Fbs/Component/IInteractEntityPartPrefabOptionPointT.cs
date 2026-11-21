using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D9 RID: 23001
	public class IInteractEntityPartPrefabOptionPointT
	{
		// Token: 0x1700A729 RID: 42793
		// (get) Token: 0x060258DB RID: 153819 RVA: 0x00526C36 File Offset: 0x00524E36
		// (set) Token: 0x060258DC RID: 153820 RVA: 0x00526C3E File Offset: 0x00524E3E
		public string UiStyle { get; set; }

		// Token: 0x1700A72A RID: 42794
		// (get) Token: 0x060258DD RID: 153821 RVA: 0x00526C47 File Offset: 0x00524E47
		// (set) Token: 0x060258DE RID: 153822 RVA: 0x00526C4F File Offset: 0x00524E4F
		public string BindName { get; set; }

		// Token: 0x060258DF RID: 153823 RVA: 0x00526C58 File Offset: 0x00524E58
		public IInteractEntityPartPrefabOptionPointT()
		{
			this.UiStyle = null;
			this.BindName = null;
		}
	}
}
