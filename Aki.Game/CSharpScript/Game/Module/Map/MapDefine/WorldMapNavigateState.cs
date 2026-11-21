using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004545 RID: 17733
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapNavigateState : IWorldMapNavigateState
	{
		// Token: 0x170059CB RID: 22987
		// (get) Token: 0x0602CB14 RID: 183060 RVA: 0x00C86B05 File Offset: 0x00C84D05
		// (set) Token: 0x0602CB15 RID: 183061 RVA: 0x00C86B0D File Offset: 0x00C84D0D
		public int StateId { get; set; }

		// Token: 0x170059CC RID: 22988
		// (get) Token: 0x0602CB16 RID: 183062 RVA: 0x00C86B16 File Offset: 0x00C84D16
		// (set) Token: 0x0602CB17 RID: 183063 RVA: 0x00C86B1E File Offset: 0x00C84D1E
		public int SortIndex { get; set; }

		// Token: 0x170059CD RID: 22989
		// (get) Token: 0x0602CB18 RID: 183064 RVA: 0x00C86B27 File Offset: 0x00C84D27
		// (set) Token: 0x0602CB19 RID: 183065 RVA: 0x00C86B2F File Offset: 0x00C84D2F
		public List<IWorldMapNavigate> AreaNavigateList { get; set; } = new List<IWorldMapNavigate>();
	}
}
