using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E96 RID: 20118
	public class IAllKillConditionT
	{
		// Token: 0x17009047 RID: 36935
		// (get) Token: 0x0601FA8C RID: 129676 RVA: 0x00468A86 File Offset: 0x00466C86
		// (set) Token: 0x0601FA8D RID: 129677 RVA: 0x00468A8E File Offset: 0x00466C8E
		public ESpawnMonsterCompleteCondition Type { get; set; }

		// Token: 0x0601FA8E RID: 129678 RVA: 0x00468A97 File Offset: 0x00466C97
		public IAllKillConditionT()
		{
			this.Type = ESpawnMonsterCompleteCondition.AllKill;
		}
	}
}
