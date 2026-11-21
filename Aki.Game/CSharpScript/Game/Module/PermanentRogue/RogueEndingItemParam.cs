using System;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042C8 RID: 17096
	public class RogueEndingItemParam : IRogueEndingItemParam
	{
		// Token: 0x170056DF RID: 22239
		// (get) Token: 0x0602B4BD RID: 177341 RVA: 0x00C2A129 File Offset: 0x00C28329
		// (set) Token: 0x0602B4BE RID: 177342 RVA: 0x00C2A131 File Offset: 0x00C28331
		public int ConfigId { get; set; }

		// Token: 0x170056E0 RID: 22240
		// (get) Token: 0x0602B4BF RID: 177343 RVA: 0x00C2A13A File Offset: 0x00C2833A
		// (set) Token: 0x0602B4C0 RID: 177344 RVA: 0x00C2A142 File Offset: 0x00C28342
		public int Index { get; set; }

		// Token: 0x170056E1 RID: 22241
		// (get) Token: 0x0602B4C1 RID: 177345 RVA: 0x00C2A14B File Offset: 0x00C2834B
		// (set) Token: 0x0602B4C2 RID: 177346 RVA: 0x00C2A153 File Offset: 0x00C28353
		public float? Rotation { get; set; }

		// Token: 0x170056E2 RID: 22242
		// (get) Token: 0x0602B4C3 RID: 177347 RVA: 0x00C2A15C File Offset: 0x00C2835C
		// (set) Token: 0x0602B4C4 RID: 177348 RVA: 0x00C2A164 File Offset: 0x00C28364
		public bool IsSubView { get; set; }

		// Token: 0x170056E3 RID: 22243
		// (get) Token: 0x0602B4C5 RID: 177349 RVA: 0x00C2A16D File Offset: 0x00C2836D
		// (set) Token: 0x0602B4C6 RID: 177350 RVA: 0x00C2A175 File Offset: 0x00C28375
		public bool IsUnlock { get; set; }
	}
}
