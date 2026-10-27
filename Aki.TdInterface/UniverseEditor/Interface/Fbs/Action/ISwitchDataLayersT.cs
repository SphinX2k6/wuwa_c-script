using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200724E RID: 29262
	public class ISwitchDataLayersT
	{
		// Token: 0x1700D921 RID: 55585
		// (get) Token: 0x06033E88 RID: 212616 RVA: 0x006FB897 File Offset: 0x006F9A97
		// (set) Token: 0x06033E89 RID: 212617 RVA: 0x006FB89F File Offset: 0x006F9A9F
		public List<int> LoadDataLayers { get; set; }

		// Token: 0x1700D922 RID: 55586
		// (get) Token: 0x06033E8A RID: 212618 RVA: 0x006FB8A8 File Offset: 0x006F9AA8
		// (set) Token: 0x06033E8B RID: 212619 RVA: 0x006FB8B0 File Offset: 0x006F9AB0
		public List<int> UnloadDataLayers { get; set; }

		// Token: 0x1700D923 RID: 55587
		// (get) Token: 0x06033E8C RID: 212620 RVA: 0x006FB8B9 File Offset: 0x006F9AB9
		// (set) Token: 0x06033E8D RID: 212621 RVA: 0x006FB8C1 File Offset: 0x006F9AC1
		public ISwitchDataLayersTransitionWithSequenceT TransitionOption { get; set; }

		// Token: 0x1700D924 RID: 55588
		// (get) Token: 0x06033E8E RID: 212622 RVA: 0x006FB8CA File Offset: 0x006F9ACA
		// (set) Token: 0x06033E8F RID: 212623 RVA: 0x006FB8D2 File Offset: 0x006F9AD2
		public string MaterialDataForLoadedLayers { get; set; }

		// Token: 0x1700D925 RID: 55589
		// (get) Token: 0x06033E90 RID: 212624 RVA: 0x006FB8DB File Offset: 0x006F9ADB
		// (set) Token: 0x06033E91 RID: 212625 RVA: 0x006FB8E3 File Offset: 0x006F9AE3
		public string MaterialDataForUnloadLayers { get; set; }

		// Token: 0x06033E92 RID: 212626 RVA: 0x006FB8EC File Offset: 0x006F9AEC
		public ISwitchDataLayersT()
		{
			this.LoadDataLayers = null;
			this.UnloadDataLayers = null;
			this.TransitionOption = null;
			this.MaterialDataForLoadedLayers = null;
			this.MaterialDataForUnloadLayers = null;
		}
	}
}
