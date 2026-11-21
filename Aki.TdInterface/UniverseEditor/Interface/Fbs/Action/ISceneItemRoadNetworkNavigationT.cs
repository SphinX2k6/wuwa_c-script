using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076CA RID: 30410
	public class ISceneItemRoadNetworkNavigationT
	{
		// Token: 0x1700DF09 RID: 57097
		// (get) Token: 0x06035585 RID: 218501 RVA: 0x00727C00 File Offset: 0x00725E00
		// (set) Token: 0x06035586 RID: 218502 RVA: 0x00727C08 File Offset: 0x00725E08
		public ERoadNetworkNavigationTarget Type { get; set; }

		// Token: 0x1700DF0A RID: 57098
		// (get) Token: 0x06035587 RID: 218503 RVA: 0x00727C11 File Offset: 0x00725E11
		// (set) Token: 0x06035588 RID: 218504 RVA: 0x00727C19 File Offset: 0x00725E19
		public int TargetId { get; set; }

		// Token: 0x06035589 RID: 218505 RVA: 0x00727C22 File Offset: 0x00725E22
		public ISceneItemRoadNetworkNavigationT()
		{
			this.Type = ERoadNetworkNavigationTarget.SceneItem;
			this.TargetId = 0;
		}
	}
}
