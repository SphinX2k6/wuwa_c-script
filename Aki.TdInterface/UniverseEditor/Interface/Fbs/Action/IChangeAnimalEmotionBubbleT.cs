using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062CD RID: 25293
	public class IChangeAnimalEmotionBubbleT
	{
		// Token: 0x1700BCCF RID: 48335
		// (get) Token: 0x0602BB83 RID: 179075 RVA: 0x006042D9 File Offset: 0x006024D9
		// (set) Token: 0x0602BB84 RID: 179076 RVA: 0x006042E1 File Offset: 0x006024E1
		public EExecClientBattleActionType Type { get; set; }

		// Token: 0x1700BCD0 RID: 48336
		// (get) Token: 0x0602BB85 RID: 179077 RVA: 0x006042EA File Offset: 0x006024EA
		// (set) Token: 0x0602BB86 RID: 179078 RVA: 0x006042F2 File Offset: 0x006024F2
		public List<int> AnimalEntityIds { get; set; }

		// Token: 0x1700BCD1 RID: 48337
		// (get) Token: 0x0602BB87 RID: 179079 RVA: 0x006042FB File Offset: 0x006024FB
		// (set) Token: 0x0602BB88 RID: 179080 RVA: 0x00604303 File Offset: 0x00602503
		public string MontagePath { get; set; }

		// Token: 0x1700BCD2 RID: 48338
		// (get) Token: 0x0602BB89 RID: 179081 RVA: 0x0060430C File Offset: 0x0060250C
		// (set) Token: 0x0602BB8A RID: 179082 RVA: 0x00604314 File Offset: 0x00602514
		public string EmotionName { get; set; }

		// Token: 0x0602BB8B RID: 179083 RVA: 0x0060431D File Offset: 0x0060251D
		public IChangeAnimalEmotionBubbleT()
		{
			this.Type = EExecClientBattleActionType.SendTagEventToControlCharacter;
			this.AnimalEntityIds = null;
			this.MontagePath = null;
			this.EmotionName = null;
		}
	}
}
