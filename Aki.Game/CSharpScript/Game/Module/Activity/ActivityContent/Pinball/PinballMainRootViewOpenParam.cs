using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball
{
	// Token: 0x020062CB RID: 25291
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMainRootViewOpenParam : IPinballMainRootViewOpenParam
	{
		// Token: 0x1700928C RID: 37516
		// (get) Token: 0x0603FA4A RID: 260682 RVA: 0x00F65AC1 File Offset: 0x00F63CC1
		// (set) Token: 0x0603FA4B RID: 260683 RVA: 0x00F65AC9 File Offset: 0x00F63CC9
		public string ChildView { get; set; }

		// Token: 0x1700928D RID: 37517
		// (get) Token: 0x0603FA4C RID: 260684 RVA: 0x00F65AD2 File Offset: 0x00F63CD2
		// (set) Token: 0x0603FA4D RID: 260685 RVA: 0x00F65ADA File Offset: 0x00F63CDA
		public int? LevelId { get; set; }

		// Token: 0x1700928E RID: 37518
		// (get) Token: 0x0603FA4E RID: 260686 RVA: 0x00F65AE3 File Offset: 0x00F63CE3
		// (set) Token: 0x0603FA4F RID: 260687 RVA: 0x00F65AEB File Offset: 0x00F63CEB
		public bool? IsFromInstanceDungeon { get; set; }
	}
}
