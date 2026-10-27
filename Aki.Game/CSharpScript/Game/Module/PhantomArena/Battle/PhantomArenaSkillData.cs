using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle
{
	// Token: 0x0200523B RID: 21051
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaSkillData : IPhantomArenaSkillData
	{
		// Token: 0x17008245 RID: 33349
		// (get) Token: 0x06035C75 RID: 220277 RVA: 0x00CB9F08 File Offset: 0x00CB8108
		// (set) Token: 0x06035C76 RID: 220278 RVA: 0x00CB9F10 File Offset: 0x00CB8110
		public bool IsOwn { get; set; }

		// Token: 0x17008246 RID: 33350
		// (get) Token: 0x06035C77 RID: 220279 RVA: 0x00CB9F19 File Offset: 0x00CB8119
		// (set) Token: 0x06035C78 RID: 220280 RVA: 0x00CB9F21 File Offset: 0x00CB8121
		public int SkillId { get; set; }

		// Token: 0x17008247 RID: 33351
		// (get) Token: 0x06035C79 RID: 220281 RVA: 0x00CB9F2A File Offset: 0x00CB812A
		// (set) Token: 0x06035C7A RID: 220282 RVA: 0x00CB9F32 File Offset: 0x00CB8132
		public bool IsPassive { get; set; }

		// Token: 0x17008248 RID: 33352
		// (get) Token: 0x06035C7B RID: 220283 RVA: 0x00CB9F3B File Offset: 0x00CB813B
		// (set) Token: 0x06035C7C RID: 220284 RVA: 0x00CB9F43 File Offset: 0x00CB8143
		public string Icon { get; set; }

		// Token: 0x17008249 RID: 33353
		// (get) Token: 0x06035C7D RID: 220285 RVA: 0x00CB9F4C File Offset: 0x00CB814C
		// (set) Token: 0x06035C7E RID: 220286 RVA: 0x00CB9F54 File Offset: 0x00CB8154
		public string SkillName { get; set; }

		// Token: 0x1700824A RID: 33354
		// (get) Token: 0x06035C7F RID: 220287 RVA: 0x00CB9F5D File Offset: 0x00CB815D
		// (set) Token: 0x06035C80 RID: 220288 RVA: 0x00CB9F65 File Offset: 0x00CB8165
		public string SkillDesc { get; set; }

		// Token: 0x1700824B RID: 33355
		// (get) Token: 0x06035C81 RID: 220289 RVA: 0x00CB9F6E File Offset: 0x00CB816E
		// (set) Token: 0x06035C82 RID: 220290 RVA: 0x00CB9F76 File Offset: 0x00CB8176
		public List<string> SkillDescParams { get; set; }

		// Token: 0x1700824C RID: 33356
		// (get) Token: 0x06035C83 RID: 220291 RVA: 0x00CB9F7F File Offset: 0x00CB817F
		// (set) Token: 0x06035C84 RID: 220292 RVA: 0x00CB9F87 File Offset: 0x00CB8187
		public int CostConsume { get; set; }
	}
}
