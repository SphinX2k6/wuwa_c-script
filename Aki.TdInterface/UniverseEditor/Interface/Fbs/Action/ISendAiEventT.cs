using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007721 RID: 30497
	public class ISendAiEventT
	{
		// Token: 0x1700DF9E RID: 57246
		// (get) Token: 0x0603581F RID: 219167 RVA: 0x0072C512 File Offset: 0x0072A712
		// (set) Token: 0x06035820 RID: 219168 RVA: 0x0072C51A File Offset: 0x0072A71A
		public int EntityId { get; set; }

		// Token: 0x1700DF9F RID: 57247
		// (get) Token: 0x06035821 RID: 219169 RVA: 0x0072C523 File Offset: 0x0072A723
		// (set) Token: 0x06035822 RID: 219170 RVA: 0x0072C52B File Offset: 0x0072A72B
		public EAiEventType EventType { get; set; }

		// Token: 0x1700DFA0 RID: 57248
		// (get) Token: 0x06035823 RID: 219171 RVA: 0x0072C534 File Offset: 0x0072A734
		// (set) Token: 0x06035824 RID: 219172 RVA: 0x0072C53C File Offset: 0x0072A73C
		public byte NullMask { get; set; }

		// Token: 0x06035825 RID: 219173 RVA: 0x0072C545 File Offset: 0x0072A745
		public ISendAiEventT()
		{
			this.EntityId = 0;
			this.EventType = EAiEventType.CatAndDogPlayFlow;
			this.NullMask = 0;
		}
	}
}
