using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model.Role;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x02004768 RID: 18280
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class ArrowShootResult : IArrowShootResult
	{
		// Token: 0x1700775A RID: 30554
		// (get) Token: 0x0602FC90 RID: 195728 RVA: 0x00B12262 File Offset: 0x00B10462
		// (set) Token: 0x0602FC91 RID: 195729 RVA: 0x00B1226A File Offset: 0x00B1046A
		public WuWaGoRole HitRole { get; set; }

		// Token: 0x1700775B RID: 30555
		// (get) Token: 0x0602FC92 RID: 195730 RVA: 0x00B12273 File Offset: 0x00B10473
		// (set) Token: 0x0602FC93 RID: 195731 RVA: 0x00B1227B File Offset: 0x00B1047B
		[RequiredMember]
		public bool HitWall { get; set; }

		// Token: 0x1700775C RID: 30556
		// (get) Token: 0x0602FC94 RID: 195732 RVA: 0x00B12284 File Offset: 0x00B10484
		// (set) Token: 0x0602FC95 RID: 195733 RVA: 0x00B1228C File Offset: 0x00B1048C
		[RequiredMember]
		public float TargetDistanceMeter { get; set; }

		// Token: 0x0602FC96 RID: 195734 RVA: 0x00B12295 File Offset: 0x00B10495
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ArrowShootResult()
		{
		}
	}
}
