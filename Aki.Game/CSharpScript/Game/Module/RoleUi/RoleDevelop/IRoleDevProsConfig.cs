using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D02 RID: 19714
	[NullableContext(1)]
	public interface IRoleDevProsConfig
	{
		// Token: 0x17007DCF RID: 32207
		// (get) Token: 0x06032F9B RID: 208795
		// (set) Token: 0x06032F9C RID: 208796
		int Id { get; set; }

		// Token: 0x17007DD0 RID: 32208
		// (get) Token: 0x06032F9D RID: 208797
		// (set) Token: 0x06032F9E RID: 208798
		long ProspectBeginTime { get; set; }

		// Token: 0x17007DD1 RID: 32209
		// (get) Token: 0x06032F9F RID: 208799
		// (set) Token: 0x06032FA0 RID: 208800
		long ProspectEndTime { get; set; }

		// Token: 0x17007DD2 RID: 32210
		// (get) Token: 0x06032FA1 RID: 208801
		// (set) Token: 0x06032FA2 RID: 208802
		int TypeId { get; set; }

		// Token: 0x17007DD3 RID: 32211
		// (get) Token: 0x06032FA3 RID: 208803
		// (set) Token: 0x06032FA4 RID: 208804
		int GachaId { get; set; }

		// Token: 0x17007DD4 RID: 32212
		// (get) Token: 0x06032FA5 RID: 208805
		// (set) Token: 0x06032FA6 RID: 208806
		List<IRoleDevProsSpecialGachaConfig> SpecialGachaId { get; set; }

		// Token: 0x17007DD5 RID: 32213
		// (get) Token: 0x06032FA7 RID: 208807
		// (set) Token: 0x06032FA8 RID: 208808
		int SortId { get; set; }
	}
}
