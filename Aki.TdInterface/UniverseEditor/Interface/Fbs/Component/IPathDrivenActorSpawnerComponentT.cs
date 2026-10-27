using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056FC RID: 22268
	public class IPathDrivenActorSpawnerComponentT
	{
		// Token: 0x1700A5BC RID: 42428
		// (get) Token: 0x0602536F RID: 152431 RVA: 0x00522C2F File Offset: 0x00520E2F
		// (set) Token: 0x06025370 RID: 152432 RVA: 0x00522C37 File Offset: 0x00520E37
		public bool Disabled { get; set; }

		// Token: 0x1700A5BD RID: 42429
		// (get) Token: 0x06025371 RID: 152433 RVA: 0x00522C40 File Offset: 0x00520E40
		// (set) Token: 0x06025372 RID: 152434 RVA: 0x00522C48 File Offset: 0x00520E48
		public IIntervalSplineSpawnT SpawnRule { get; set; }

		// Token: 0x1700A5BE RID: 42430
		// (get) Token: 0x06025373 RID: 152435 RVA: 0x00522C51 File Offset: 0x00520E51
		// (set) Token: 0x06025374 RID: 152436 RVA: 0x00522C59 File Offset: 0x00520E59
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700A5BF RID: 42431
		// (get) Token: 0x06025375 RID: 152437 RVA: 0x00522C62 File Offset: 0x00520E62
		// (set) Token: 0x06025376 RID: 152438 RVA: 0x00522C6A File Offset: 0x00520E6A
		public byte NullMask { get; set; }

		// Token: 0x06025377 RID: 152439 RVA: 0x00522C73 File Offset: 0x00520E73
		public IPathDrivenActorSpawnerComponentT()
		{
			this.Disabled = false;
			this.SpawnRule = null;
			this.Target = null;
			this.NullMask = 0;
		}
	}
}
