using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200693E RID: 26942
	public class IChangeAnimalEmotionBubbleT
	{
		// Token: 0x1700C659 RID: 50777
		// (get) Token: 0x0602E2EC RID: 189164 RVA: 0x0064F2E5 File Offset: 0x0064D4E5
		// (set) Token: 0x0602E2ED RID: 189165 RVA: 0x0064F2ED File Offset: 0x0064D4ED
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700C65A RID: 50778
		// (get) Token: 0x0602E2EE RID: 189166 RVA: 0x0064F2F6 File Offset: 0x0064D4F6
		// (set) Token: 0x0602E2EF RID: 189167 RVA: 0x0064F2FE File Offset: 0x0064D4FE
		public List<int> AnimalEntityIds { get; set; }

		// Token: 0x1700C65B RID: 50779
		// (get) Token: 0x0602E2F0 RID: 189168 RVA: 0x0064F307 File Offset: 0x0064D507
		// (set) Token: 0x0602E2F1 RID: 189169 RVA: 0x0064F30F File Offset: 0x0064D50F
		public string MontagePath { get; set; }

		// Token: 0x1700C65C RID: 50780
		// (get) Token: 0x0602E2F2 RID: 189170 RVA: 0x0064F318 File Offset: 0x0064D518
		// (set) Token: 0x0602E2F3 RID: 189171 RVA: 0x0064F320 File Offset: 0x0064D520
		public string EmotionName { get; set; }

		// Token: 0x0602E2F4 RID: 189172 RVA: 0x0064F329 File Offset: 0x0064D529
		public IChangeAnimalEmotionBubbleT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.AnimalEntityIds = null;
			this.MontagePath = null;
			this.EmotionName = null;
		}
	}
}
