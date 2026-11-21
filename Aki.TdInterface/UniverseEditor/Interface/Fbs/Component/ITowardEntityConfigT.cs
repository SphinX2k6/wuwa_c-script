using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060CB RID: 24779
	public class ITowardEntityConfigT
	{
		// Token: 0x1700B82F RID: 47151
		// (get) Token: 0x06029EE0 RID: 171744 RVA: 0x005B8EBF File Offset: 0x005B70BF
		// (set) Token: 0x06029EE1 RID: 171745 RVA: 0x005B8EC7 File Offset: 0x005B70C7
		public string ReferenceActorKey { get; set; }

		// Token: 0x1700B830 RID: 47152
		// (get) Token: 0x06029EE2 RID: 171746 RVA: 0x005B8ED0 File Offset: 0x005B70D0
		// (set) Token: 0x06029EE3 RID: 171747 RVA: 0x005B8ED8 File Offset: 0x005B70D8
		public int TargetEntityId { get; set; }

		// Token: 0x06029EE4 RID: 171748 RVA: 0x005B8EE1 File Offset: 0x005B70E1
		public ITowardEntityConfigT()
		{
			this.ReferenceActorKey = null;
			this.TargetEntityId = 0;
		}
	}
}
