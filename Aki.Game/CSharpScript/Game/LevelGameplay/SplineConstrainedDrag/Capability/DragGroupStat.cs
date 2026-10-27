using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGameplay.SplineConstrainedDrag.Capability
{
	// Token: 0x0200694D RID: 26957
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class DragGroupStat : IDragGroupStat
	{
		// Token: 0x17009802 RID: 38914
		// (get) Token: 0x060432B1 RID: 275121 RVA: 0x0106027A File Offset: 0x0105E47A
		// (set) Token: 0x060432B2 RID: 275122 RVA: 0x01060282 File Offset: 0x0105E482
		public int Total { get; set; }

		// Token: 0x17009803 RID: 38915
		// (get) Token: 0x060432B3 RID: 275123 RVA: 0x0106028B File Offset: 0x0105E48B
		// (set) Token: 0x060432B4 RID: 275124 RVA: 0x01060293 File Offset: 0x0105E493
		[RequiredMember]
		public int[] StateCounts { get; set; }

		// Token: 0x17009804 RID: 38916
		// (get) Token: 0x060432B5 RID: 275125 RVA: 0x0106029C File Offset: 0x0105E49C
		// (set) Token: 0x060432B6 RID: 275126 RVA: 0x010602A4 File Offset: 0x0105E4A4
		public int ConditionOkCount { get; set; }

		// Token: 0x17009805 RID: 38917
		// (get) Token: 0x060432B7 RID: 275127 RVA: 0x010602AD File Offset: 0x0105E4AD
		// (set) Token: 0x060432B8 RID: 275128 RVA: 0x010602B5 File Offset: 0x0105E4B5
		public bool HasActive { get; set; }

		// Token: 0x060432B9 RID: 275129 RVA: 0x010602BE File Offset: 0x0105E4BE
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DragGroupStat()
		{
		}
	}
}
