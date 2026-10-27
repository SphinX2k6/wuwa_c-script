using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056EA RID: 22250
	public class IPathDrivenActorInitialSpawnConfigT
	{
		// Token: 0x1700A5A5 RID: 42405
		// (get) Token: 0x060252FA RID: 152314 RVA: 0x00521F5D File Offset: 0x0052015D
		// (set) Token: 0x060252FB RID: 152315 RVA: 0x00521F65 File Offset: 0x00520165
		public bool EnableInitialSpawn { get; set; }

		// Token: 0x1700A5A6 RID: 42406
		// (get) Token: 0x060252FC RID: 152316 RVA: 0x00521F6E File Offset: 0x0052016E
		// (set) Token: 0x060252FD RID: 152317 RVA: 0x00521F76 File Offset: 0x00520176
		public List<IPathDrivenActorInitialSpawnHandleT> InitialSpawnHandles { get; set; }

		// Token: 0x1700A5A7 RID: 42407
		// (get) Token: 0x060252FE RID: 152318 RVA: 0x00521F7F File Offset: 0x0052017F
		// (set) Token: 0x060252FF RID: 152319 RVA: 0x00521F87 File Offset: 0x00520187
		public byte NullMask { get; set; }

		// Token: 0x06025300 RID: 152320 RVA: 0x00521F90 File Offset: 0x00520190
		public IPathDrivenActorInitialSpawnConfigT()
		{
			this.EnableInitialSpawn = false;
			this.InitialSpawnHandles = null;
			this.NullMask = 0;
		}
	}
}
