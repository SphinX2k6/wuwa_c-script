using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200610E RID: 24846
	public class IActorTurnToTalkerDataT
	{
		// Token: 0x1700B71A RID: 46874
		// (get) Token: 0x0602A73B RID: 173883 RVA: 0x005D904E File Offset: 0x005D724E
		// (set) Token: 0x0602A73C RID: 173884 RVA: 0x005D9056 File Offset: 0x005D7256
		public EActorTurnToMode Type { get; set; }

		// Token: 0x0602A73D RID: 173885 RVA: 0x005D905F File Offset: 0x005D725F
		public IActorTurnToTalkerDataT()
		{
			this.Type = EActorTurnToMode.Talker;
		}
	}
}
