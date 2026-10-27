using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200400E RID: 16398
	public class IQuestRecallDataT
	{
		// Token: 0x1700733A RID: 29498
		// (get) Token: 0x06017AB0 RID: 96944 RVA: 0x00369F39 File Offset: 0x00368139
		// (set) Token: 0x06017AB1 RID: 96945 RVA: 0x00369F41 File Offset: 0x00368141
		public ERecallDataType Type { get; set; }

		// Token: 0x1700733B RID: 29499
		// (get) Token: 0x06017AB2 RID: 96946 RVA: 0x00369F4A File Offset: 0x0036814A
		// (set) Token: 0x06017AB3 RID: 96947 RVA: 0x00369F52 File Offset: 0x00368152
		public int Id { get; set; }

		// Token: 0x1700733C RID: 29500
		// (get) Token: 0x06017AB4 RID: 96948 RVA: 0x00369F5B File Offset: 0x0036815B
		// (set) Token: 0x06017AB5 RID: 96949 RVA: 0x00369F63 File Offset: 0x00368163
		public IQuestRecallConfigT RecallConfig { get; set; }

		// Token: 0x06017AB6 RID: 96950 RVA: 0x00369F6C File Offset: 0x0036816C
		public IQuestRecallDataT()
		{
			this.Type = ERecallDataType.LevelPlay;
			this.Id = 0;
			this.RecallConfig = null;
		}
	}
}
