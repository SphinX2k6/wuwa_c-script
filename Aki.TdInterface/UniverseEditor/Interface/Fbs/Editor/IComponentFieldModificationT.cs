using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200483C RID: 18492
	public class IComponentFieldModificationT
	{
		// Token: 0x170084B4 RID: 33972
		// (get) Token: 0x0601C96F RID: 117103 RVA: 0x0040AADA File Offset: 0x00408CDA
		// (set) Token: 0x0601C970 RID: 117104 RVA: 0x0040AAE2 File Offset: 0x00408CE2
		public bool Enable { get; set; }

		// Token: 0x170084B5 RID: 33973
		// (get) Token: 0x0601C971 RID: 117105 RVA: 0x0040AAEB File Offset: 0x00408CEB
		// (set) Token: 0x0601C972 RID: 117106 RVA: 0x0040AAF3 File Offset: 0x00408CF3
		public EComponent Type { get; set; }

		// Token: 0x170084B6 RID: 33974
		// (get) Token: 0x0601C973 RID: 117107 RVA: 0x0040AAFC File Offset: 0x00408CFC
		// (set) Token: 0x0601C974 RID: 117108 RVA: 0x0040AB04 File Offset: 0x00408D04
		public string Field { get; set; }

		// Token: 0x170084B7 RID: 33975
		// (get) Token: 0x0601C975 RID: 117109 RVA: 0x0040AB0D File Offset: 0x00408D0D
		// (set) Token: 0x0601C976 RID: 117110 RVA: 0x0040AB15 File Offset: 0x00408D15
		public string Value { get; set; }

		// Token: 0x0601C977 RID: 117111 RVA: 0x0040AB1E File Offset: 0x00408D1E
		public IComponentFieldModificationT()
		{
			this.Enable = false;
			this.Type = EComponent.AirWallSpawnerComponent;
			this.Field = null;
			this.Value = null;
		}
	}
}
