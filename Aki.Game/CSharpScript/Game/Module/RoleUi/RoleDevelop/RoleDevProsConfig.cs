using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CB5 RID: 15541
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevProsConfig : IRoleDevProsConfig
	{
		// Token: 0x17005180 RID: 20864
		// (get) Token: 0x06027D84 RID: 163204 RVA: 0x00B272C2 File Offset: 0x00B254C2
		// (set) Token: 0x06027D85 RID: 163205 RVA: 0x00B272CA File Offset: 0x00B254CA
		public int Id { get; set; }

		// Token: 0x17005181 RID: 20865
		// (get) Token: 0x06027D86 RID: 163206 RVA: 0x00B272D3 File Offset: 0x00B254D3
		// (set) Token: 0x06027D87 RID: 163207 RVA: 0x00B272DB File Offset: 0x00B254DB
		public long ProspectBeginTime { get; set; }

		// Token: 0x17005182 RID: 20866
		// (get) Token: 0x06027D88 RID: 163208 RVA: 0x00B272E4 File Offset: 0x00B254E4
		// (set) Token: 0x06027D89 RID: 163209 RVA: 0x00B272EC File Offset: 0x00B254EC
		public long ProspectEndTime { get; set; }

		// Token: 0x17005183 RID: 20867
		// (get) Token: 0x06027D8A RID: 163210 RVA: 0x00B272F5 File Offset: 0x00B254F5
		// (set) Token: 0x06027D8B RID: 163211 RVA: 0x00B272FD File Offset: 0x00B254FD
		public int TypeId { get; set; }

		// Token: 0x17005184 RID: 20868
		// (get) Token: 0x06027D8C RID: 163212 RVA: 0x00B27306 File Offset: 0x00B25506
		// (set) Token: 0x06027D8D RID: 163213 RVA: 0x00B2730E File Offset: 0x00B2550E
		public int GachaId { get; set; }

		// Token: 0x17005185 RID: 20869
		// (get) Token: 0x06027D8E RID: 163214 RVA: 0x00B27317 File Offset: 0x00B25517
		// (set) Token: 0x06027D8F RID: 163215 RVA: 0x00B2731F File Offset: 0x00B2551F
		public List<IRoleDevProsSpecialGachaConfig> SpecialGachaId { get; set; } = new List<IRoleDevProsSpecialGachaConfig>();

		// Token: 0x17005186 RID: 20870
		// (get) Token: 0x06027D90 RID: 163216 RVA: 0x00B27328 File Offset: 0x00B25528
		// (set) Token: 0x06027D91 RID: 163217 RVA: 0x00B27330 File Offset: 0x00B25530
		public int SortId { get; set; }
	}
}
