using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback
{
	// Token: 0x020057B2 RID: 22450
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleActionGroup : IBattleActionGroup
	{
		// Token: 0x17006AC7 RID: 27335
		// (get) Token: 0x060376EF RID: 227055 RVA: 0x00F7C0E2 File Offset: 0x00F7A2E2
		// (set) Token: 0x060376F0 RID: 227056 RVA: 0x00F7C0EA File Offset: 0x00F7A2EA
		public int GroupUid { get; set; }

		// Token: 0x17006AC8 RID: 27336
		// (get) Token: 0x060376F1 RID: 227057 RVA: 0x00F7C0F3 File Offset: 0x00F7A2F3
		// (set) Token: 0x060376F2 RID: 227058 RVA: 0x00F7C0FB File Offset: 0x00F7A2FB
		public int TriggerMs { get; set; }

		// Token: 0x17006AC9 RID: 27337
		// (get) Token: 0x060376F3 RID: 227059 RVA: 0x00F7C104 File Offset: 0x00F7A304
		// (set) Token: 0x060376F4 RID: 227060 RVA: 0x00F7C10C File Offset: 0x00F7A30C
		public List<IDangoBrawlBattleAction> Actions { get; set; }
	}
}
