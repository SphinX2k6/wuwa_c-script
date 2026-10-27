using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02005298 RID: 21144
	[NullableContext(1)]
	public interface ISkillTriggerInfo
	{
		// Token: 0x17008296 RID: 33430
		// (get) Token: 0x06036141 RID: 221505
		// (set) Token: 0x06036142 RID: 221506
		EPhantomArenaBuffEffectType InteractType { get; set; }

		// Token: 0x17008297 RID: 33431
		// (get) Token: 0x06036143 RID: 221507
		// (set) Token: 0x06036144 RID: 221508
		List<int> SelectFightIdList { get; set; }

		// Token: 0x17008298 RID: 33432
		// (get) Token: 0x06036145 RID: 221509
		// (set) Token: 0x06036146 RID: 221510
		int SelectNum { get; set; }

		// Token: 0x17008299 RID: 33433
		// (get) Token: 0x06036147 RID: 221511
		// (set) Token: 0x06036148 RID: 221512
		int? SkillId { get; set; }

		// Token: 0x1700829A RID: 33434
		// (get) Token: 0x06036149 RID: 221513
		// (set) Token: 0x0603614A RID: 221514
		int? DataId { get; set; }

		// Token: 0x1700829B RID: 33435
		// (get) Token: 0x0603614B RID: 221515
		// (set) Token: 0x0603614C RID: 221516
		bool IsRole { get; set; }

		// Token: 0x1700829C RID: 33436
		// (get) Token: 0x0603614D RID: 221517
		// (set) Token: 0x0603614E RID: 221518
		bool IsPassive { get; set; }

		// Token: 0x1700829D RID: 33437
		// (get) Token: 0x0603614F RID: 221519
		// (set) Token: 0x06036150 RID: 221520
		bool IsFight { get; set; }

		// Token: 0x1700829E RID: 33438
		// (get) Token: 0x06036151 RID: 221521
		// (set) Token: 0x06036152 RID: 221522
		bool IsClickInteract { get; set; }
	}
}
