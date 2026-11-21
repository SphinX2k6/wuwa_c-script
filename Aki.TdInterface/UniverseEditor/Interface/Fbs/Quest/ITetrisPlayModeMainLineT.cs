using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004620 RID: 17952
	public class ITetrisPlayModeMainLineT
	{
		// Token: 0x17007D93 RID: 32147
		// (get) Token: 0x0601A430 RID: 107568 RVA: 0x003BD1F1 File Offset: 0x003BB3F1
		// (set) Token: 0x0601A431 RID: 107569 RVA: 0x003BD1F9 File Offset: 0x003BB3F9
		public ETetrisPlayMode Type { get; set; }

		// Token: 0x17007D94 RID: 32148
		// (get) Token: 0x0601A432 RID: 107570 RVA: 0x003BD202 File Offset: 0x003BB402
		// (set) Token: 0x0601A433 RID: 107571 RVA: 0x003BD20A File Offset: 0x003BB40A
		public int EntityId { get; set; }

		// Token: 0x17007D95 RID: 32149
		// (get) Token: 0x0601A434 RID: 107572 RVA: 0x003BD213 File Offset: 0x003BB413
		// (set) Token: 0x0601A435 RID: 107573 RVA: 0x003BD21B File Offset: 0x003BB41B
		public string EntityState { get; set; }

		// Token: 0x17007D96 RID: 32150
		// (get) Token: 0x0601A436 RID: 107574 RVA: 0x003BD224 File Offset: 0x003BB424
		// (set) Token: 0x0601A437 RID: 107575 RVA: 0x003BD22C File Offset: 0x003BB42C
		public int FieldHeight { get; set; }

		// Token: 0x17007D97 RID: 32151
		// (get) Token: 0x0601A438 RID: 107576 RVA: 0x003BD235 File Offset: 0x003BB435
		// (set) Token: 0x0601A439 RID: 107577 RVA: 0x003BD23D File Offset: 0x003BB43D
		public byte NullMask { get; set; }

		// Token: 0x0601A43A RID: 107578 RVA: 0x003BD246 File Offset: 0x003BB446
		public ITetrisPlayModeMainLineT()
		{
			this.Type = ETetrisPlayMode.Normal;
			this.EntityId = 0;
			this.EntityState = null;
			this.FieldHeight = 0;
			this.NullMask = 0;
		}
	}
}
