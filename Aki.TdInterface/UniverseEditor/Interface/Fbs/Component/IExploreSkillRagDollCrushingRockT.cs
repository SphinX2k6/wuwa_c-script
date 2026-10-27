using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005202 RID: 20994
	public class IExploreSkillRagDollCrushingRockT
	{
		// Token: 0x170099CD RID: 39373
		// (get) Token: 0x060221D0 RID: 139728 RVA: 0x004BBF5A File Offset: 0x004BA15A
		// (set) Token: 0x060221D1 RID: 139729 RVA: 0x004BBF62 File Offset: 0x004BA162
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x060221D2 RID: 139730 RVA: 0x004BBF6B File Offset: 0x004BA16B
		public IExploreSkillRagDollCrushingRockT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
		}
	}
}
