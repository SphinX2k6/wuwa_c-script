using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02004269 RID: 17001
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillTriggerInfo : ISkillTriggerInfo
	{
		// Token: 0x1700565F RID: 22111
		// (get) Token: 0x0602B04E RID: 176206 RVA: 0x00C1977A File Offset: 0x00C1797A
		// (set) Token: 0x0602B04F RID: 176207 RVA: 0x00C19782 File Offset: 0x00C17982
		public EPhantomArenaBuffEffectType InteractType { get; set; }

		// Token: 0x17005660 RID: 22112
		// (get) Token: 0x0602B050 RID: 176208 RVA: 0x00C1978B File Offset: 0x00C1798B
		// (set) Token: 0x0602B051 RID: 176209 RVA: 0x00C19793 File Offset: 0x00C17993
		public List<int> SelectFightIdList { get; set; }

		// Token: 0x17005661 RID: 22113
		// (get) Token: 0x0602B052 RID: 176210 RVA: 0x00C1979C File Offset: 0x00C1799C
		// (set) Token: 0x0602B053 RID: 176211 RVA: 0x00C197A4 File Offset: 0x00C179A4
		public int SelectNum { get; set; }

		// Token: 0x17005662 RID: 22114
		// (get) Token: 0x0602B054 RID: 176212 RVA: 0x00C197AD File Offset: 0x00C179AD
		// (set) Token: 0x0602B055 RID: 176213 RVA: 0x00C197B5 File Offset: 0x00C179B5
		public int? SkillId { get; set; }

		// Token: 0x17005663 RID: 22115
		// (get) Token: 0x0602B056 RID: 176214 RVA: 0x00C197BE File Offset: 0x00C179BE
		// (set) Token: 0x0602B057 RID: 176215 RVA: 0x00C197C6 File Offset: 0x00C179C6
		public int? DataId { get; set; }

		// Token: 0x17005664 RID: 22116
		// (get) Token: 0x0602B058 RID: 176216 RVA: 0x00C197CF File Offset: 0x00C179CF
		// (set) Token: 0x0602B059 RID: 176217 RVA: 0x00C197D7 File Offset: 0x00C179D7
		public bool IsRole { get; set; }

		// Token: 0x17005665 RID: 22117
		// (get) Token: 0x0602B05A RID: 176218 RVA: 0x00C197E0 File Offset: 0x00C179E0
		// (set) Token: 0x0602B05B RID: 176219 RVA: 0x00C197E8 File Offset: 0x00C179E8
		public bool IsPassive { get; set; }

		// Token: 0x17005666 RID: 22118
		// (get) Token: 0x0602B05C RID: 176220 RVA: 0x00C197F1 File Offset: 0x00C179F1
		// (set) Token: 0x0602B05D RID: 176221 RVA: 0x00C197F9 File Offset: 0x00C179F9
		public bool IsFight { get; set; }

		// Token: 0x17005667 RID: 22119
		// (get) Token: 0x0602B05E RID: 176222 RVA: 0x00C19802 File Offset: 0x00C17A02
		// (set) Token: 0x0602B05F RID: 176223 RVA: 0x00C1980A File Offset: 0x00C17A0A
		public bool IsClickInteract { get; set; }
	}
}
