using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004552 RID: 17746
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRoadWaysMgrParams
	{
		// Token: 0x170059E8 RID: 23016
		// (get) Token: 0x0602CB63 RID: 183139 RVA: 0x00C86DFD File Offset: 0x00C84FFD
		// (set) Token: 0x0602CB64 RID: 183140 RVA: 0x00C86E05 File Offset: 0x00C85005
		public int MapId { get; set; }

		// Token: 0x170059E9 RID: 23017
		// (get) Token: 0x0602CB65 RID: 183141 RVA: 0x00C86E0E File Offset: 0x00C8500E
		// (set) Token: 0x0602CB66 RID: 183142 RVA: 0x00C86E16 File Offset: 0x00C85016
		public int InstanceDungeonId { get; set; }

		// Token: 0x170059EA RID: 23018
		// (get) Token: 0x0602CB67 RID: 183143 RVA: 0x00C86E1F File Offset: 0x00C8501F
		// (set) Token: 0x0602CB68 RID: 183144 RVA: 0x00C86E27 File Offset: 0x00C85027
		public UUIItem Container { get; set; }
	}
}
