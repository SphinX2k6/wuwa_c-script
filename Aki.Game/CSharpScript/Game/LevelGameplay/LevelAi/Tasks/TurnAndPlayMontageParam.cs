using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02006DC5 RID: 28101
	[NullableContext(1)]
	[Nullable(0)]
	internal class TurnAndPlayMontageParam : ActionParams
	{
		// Token: 0x170099BC RID: 39356
		// (get) Token: 0x060448DA RID: 280794 RVA: 0x010E86B9 File Offset: 0x010E68B9
		// (set) Token: 0x060448DB RID: 280795 RVA: 0x010E86C1 File Offset: 0x010E68C1
		public int EntityId { get; set; }

		// Token: 0x170099BD RID: 39357
		// (get) Token: 0x060448DC RID: 280796 RVA: 0x010E86CA File Offset: 0x010E68CA
		// (set) Token: 0x060448DD RID: 280797 RVA: 0x010E86D2 File Offset: 0x010E68D2
		public IVector Pos { get; set; }

		// Token: 0x170099BE RID: 39358
		// (get) Token: 0x060448DE RID: 280798 RVA: 0x010E86DB File Offset: 0x010E68DB
		// (set) Token: 0x060448DF RID: 280799 RVA: 0x010E86E3 File Offset: 0x010E68E3
		public int MontageId { get; set; }

		// Token: 0x170099BF RID: 39359
		// (get) Token: 0x060448E0 RID: 280800 RVA: 0x010E86EC File Offset: 0x010E68EC
		// (set) Token: 0x060448E1 RID: 280801 RVA: 0x010E86F4 File Offset: 0x010E68F4
		public bool? IsAbpMontage { get; set; }

		// Token: 0x170099C0 RID: 39360
		// (get) Token: 0x060448E2 RID: 280802 RVA: 0x010E86FD File Offset: 0x010E68FD
		// (set) Token: 0x060448E3 RID: 280803 RVA: 0x010E8705 File Offset: 0x010E6905
		public float LoopDuration { get; set; }

		// Token: 0x170099C1 RID: 39361
		// (get) Token: 0x060448E4 RID: 280804 RVA: 0x010E870E File Offset: 0x010E690E
		// (set) Token: 0x060448E5 RID: 280805 RVA: 0x010E8716 File Offset: 0x010E6916
		public int RepeatTimes { get; set; }
	}
}
