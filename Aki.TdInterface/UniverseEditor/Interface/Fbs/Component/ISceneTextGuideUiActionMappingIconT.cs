using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E0 RID: 22752
	public class ISceneTextGuideUiActionMappingIconT
	{
		// Token: 0x1700AA6C RID: 43628
		// (get) Token: 0x060266AC RID: 157356 RVA: 0x0054B513 File Offset: 0x00549713
		// (set) Token: 0x060266AD RID: 157357 RVA: 0x0054B51B File Offset: 0x0054971B
		public int Id { get; set; }

		// Token: 0x1700AA6D RID: 43629
		// (get) Token: 0x060266AE RID: 157358 RVA: 0x0054B524 File Offset: 0x00549724
		// (set) Token: 0x060266AF RID: 157359 RVA: 0x0054B52C File Offset: 0x0054972C
		public string ActionName { get; set; }

		// Token: 0x060266B0 RID: 157360 RVA: 0x0054B535 File Offset: 0x00549735
		public ISceneTextGuideUiActionMappingIconT()
		{
			this.Id = 0;
			this.ActionName = null;
		}
	}
}
