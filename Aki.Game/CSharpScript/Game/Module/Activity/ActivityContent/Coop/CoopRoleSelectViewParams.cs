using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068DA RID: 26842
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopRoleSelectViewParams
	{
		// Token: 0x170097D9 RID: 38873
		// (get) Token: 0x06042F7E RID: 274302 RVA: 0x0104F28A File Offset: 0x0104D48A
		// (set) Token: 0x06042F7F RID: 274303 RVA: 0x0104F292 File Offset: 0x0104D492
		public CoopActivityData ActivityData { get; set; }

		// Token: 0x170097DA RID: 38874
		// (get) Token: 0x06042F80 RID: 274304 RVA: 0x0104F29B File Offset: 0x0104D49B
		// (set) Token: 0x06042F81 RID: 274305 RVA: 0x0104F2A3 File Offset: 0x0104D4A3
		public int Index { get; set; }

		// Token: 0x170097DB RID: 38875
		// (get) Token: 0x06042F82 RID: 274306 RVA: 0x0104F2AC File Offset: 0x0104D4AC
		// (set) Token: 0x06042F83 RID: 274307 RVA: 0x0104F2B4 File Offset: 0x0104D4B4
		public int Level { get; set; }

		// Token: 0x170097DC RID: 38876
		// (get) Token: 0x06042F84 RID: 274308 RVA: 0x0104F2BD File Offset: 0x0104D4BD
		// (set) Token: 0x06042F85 RID: 274309 RVA: 0x0104F2C5 File Offset: 0x0104D4C5
		public int LevelId { get; set; }

		// Token: 0x170097DD RID: 38877
		// (get) Token: 0x06042F86 RID: 274310 RVA: 0x0104F2CE File Offset: 0x0104D4CE
		// (set) Token: 0x06042F87 RID: 274311 RVA: 0x0104F2D6 File Offset: 0x0104D4D6
		public bool IsOpenByUpGradeView { get; set; }
	}
}
