using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B8D RID: 23437
	public class IWoodenOxenAndFlowingHorsesPerformT
	{
		// Token: 0x1700B11F RID: 45343
		// (get) Token: 0x060281FB RID: 164347 RVA: 0x00583DF3 File Offset: 0x00581FF3
		// (set) Token: 0x060281FC RID: 164348 RVA: 0x00583DFB File Offset: 0x00581FFB
		public EVehicleType Type { get; set; }

		// Token: 0x1700B120 RID: 45344
		// (get) Token: 0x060281FD RID: 164349 RVA: 0x00583E04 File Offset: 0x00582004
		// (set) Token: 0x060281FE RID: 164350 RVA: 0x00583E0C File Offset: 0x0058200C
		public string Montage { get; set; }

		// Token: 0x1700B121 RID: 45345
		// (get) Token: 0x060281FF RID: 164351 RVA: 0x00583E15 File Offset: 0x00582015
		// (set) Token: 0x06028200 RID: 164352 RVA: 0x00583E1D File Offset: 0x0058201D
		public IWoodenOxenAndFlowingHorsesPerformConfigT MountPerformLeft { get; set; }

		// Token: 0x1700B122 RID: 45346
		// (get) Token: 0x06028201 RID: 164353 RVA: 0x00583E26 File Offset: 0x00582026
		// (set) Token: 0x06028202 RID: 164354 RVA: 0x00583E2E File Offset: 0x0058202E
		public IWoodenOxenAndFlowingHorsesPerformConfigT MountPerformRight { get; set; }

		// Token: 0x1700B123 RID: 45347
		// (get) Token: 0x06028203 RID: 164355 RVA: 0x00583E37 File Offset: 0x00582037
		// (set) Token: 0x06028204 RID: 164356 RVA: 0x00583E3F File Offset: 0x0058203F
		public IWoodenOxenAndFlowingHorsesPerformConfigT DismountPerformLeft { get; set; }

		// Token: 0x1700B124 RID: 45348
		// (get) Token: 0x06028205 RID: 164357 RVA: 0x00583E48 File Offset: 0x00582048
		// (set) Token: 0x06028206 RID: 164358 RVA: 0x00583E50 File Offset: 0x00582050
		public IWoodenOxenAndFlowingHorsesPerformConfigT DismountPerformRight { get; set; }

		// Token: 0x06028207 RID: 164359 RVA: 0x00583E59 File Offset: 0x00582059
		public IWoodenOxenAndFlowingHorsesPerformT()
		{
			this.Type = EVehicleType.Gongduola;
			this.Montage = null;
			this.MountPerformLeft = null;
			this.MountPerformRight = null;
			this.DismountPerformLeft = null;
			this.DismountPerformRight = null;
		}
	}
}
