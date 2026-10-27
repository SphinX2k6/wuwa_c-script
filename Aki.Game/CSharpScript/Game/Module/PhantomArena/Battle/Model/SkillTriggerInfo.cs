using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02005299 RID: 21145
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillTriggerInfo : ISkillTriggerInfo
	{
		// Token: 0x1700829F RID: 33439
		// (get) Token: 0x06036153 RID: 221523 RVA: 0x00CCC042 File Offset: 0x00CCA242
		// (set) Token: 0x06036154 RID: 221524 RVA: 0x00CCC04A File Offset: 0x00CCA24A
		public EPhantomArenaBuffEffectType InteractType { get; set; }

		// Token: 0x170082A0 RID: 33440
		// (get) Token: 0x06036155 RID: 221525 RVA: 0x00CCC053 File Offset: 0x00CCA253
		// (set) Token: 0x06036156 RID: 221526 RVA: 0x00CCC05B File Offset: 0x00CCA25B
		public List<int> SelectFightIdList { get; set; }

		// Token: 0x170082A1 RID: 33441
		// (get) Token: 0x06036157 RID: 221527 RVA: 0x00CCC064 File Offset: 0x00CCA264
		// (set) Token: 0x06036158 RID: 221528 RVA: 0x00CCC06C File Offset: 0x00CCA26C
		public int SelectNum { get; set; }

		// Token: 0x170082A2 RID: 33442
		// (get) Token: 0x06036159 RID: 221529 RVA: 0x00CCC075 File Offset: 0x00CCA275
		// (set) Token: 0x0603615A RID: 221530 RVA: 0x00CCC07D File Offset: 0x00CCA27D
		public int? SkillId { get; set; }

		// Token: 0x170082A3 RID: 33443
		// (get) Token: 0x0603615B RID: 221531 RVA: 0x00CCC086 File Offset: 0x00CCA286
		// (set) Token: 0x0603615C RID: 221532 RVA: 0x00CCC08E File Offset: 0x00CCA28E
		public int? DataId { get; set; }

		// Token: 0x170082A4 RID: 33444
		// (get) Token: 0x0603615D RID: 221533 RVA: 0x00CCC097 File Offset: 0x00CCA297
		// (set) Token: 0x0603615E RID: 221534 RVA: 0x00CCC09F File Offset: 0x00CCA29F
		public bool IsRole { get; set; }

		// Token: 0x170082A5 RID: 33445
		// (get) Token: 0x0603615F RID: 221535 RVA: 0x00CCC0A8 File Offset: 0x00CCA2A8
		// (set) Token: 0x06036160 RID: 221536 RVA: 0x00CCC0B0 File Offset: 0x00CCA2B0
		public bool IsPassive { get; set; }

		// Token: 0x170082A6 RID: 33446
		// (get) Token: 0x06036161 RID: 221537 RVA: 0x00CCC0B9 File Offset: 0x00CCA2B9
		// (set) Token: 0x06036162 RID: 221538 RVA: 0x00CCC0C1 File Offset: 0x00CCA2C1
		public bool IsFight { get; set; }

		// Token: 0x170082A7 RID: 33447
		// (get) Token: 0x06036163 RID: 221539 RVA: 0x00CCC0CA File Offset: 0x00CCA2CA
		// (set) Token: 0x06036164 RID: 221540 RVA: 0x00CCC0D2 File Offset: 0x00CCA2D2
		public bool IsClickInteract { get; set; }
	}
}
