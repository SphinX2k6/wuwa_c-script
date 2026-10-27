using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F43 RID: 28483
	public class ISceneItemRoadNetworkNavigationT
	{
		// Token: 0x1700D3AD RID: 54189
		// (get) Token: 0x0603252D RID: 206125 RVA: 0x006CBC98 File Offset: 0x006C9E98
		// (set) Token: 0x0603252E RID: 206126 RVA: 0x006CBCA0 File Offset: 0x006C9EA0
		public ERoadNetworkNavigationTarget Type { get; set; }

		// Token: 0x1700D3AE RID: 54190
		// (get) Token: 0x0603252F RID: 206127 RVA: 0x006CBCA9 File Offset: 0x006C9EA9
		// (set) Token: 0x06032530 RID: 206128 RVA: 0x006CBCB1 File Offset: 0x006C9EB1
		public int TargetId { get; set; }

		// Token: 0x06032531 RID: 206129 RVA: 0x006CBCBA File Offset: 0x006C9EBA
		public ISceneItemRoadNetworkNavigationT()
		{
			this.Type = ERoadNetworkNavigationTarget.SceneItem;
			this.TargetId = 0;
		}
	}
}
