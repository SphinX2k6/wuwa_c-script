using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo.Model.Role;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x02003699 RID: 13977
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class ArrowShootResult : IArrowShootResult
	{
		// Token: 0x17004A16 RID: 18966
		// (get) Token: 0x0602445A RID: 148570 RVA: 0x00A42222 File Offset: 0x00A40422
		// (set) Token: 0x0602445B RID: 148571 RVA: 0x00A4222A File Offset: 0x00A4042A
		public WuWaGoRole HitRole { get; set; }

		// Token: 0x17004A17 RID: 18967
		// (get) Token: 0x0602445C RID: 148572 RVA: 0x00A42233 File Offset: 0x00A40433
		// (set) Token: 0x0602445D RID: 148573 RVA: 0x00A4223B File Offset: 0x00A4043B
		[RequiredMember]
		public bool HitWall { get; set; }

		// Token: 0x17004A18 RID: 18968
		// (get) Token: 0x0602445E RID: 148574 RVA: 0x00A42244 File Offset: 0x00A40444
		// (set) Token: 0x0602445F RID: 148575 RVA: 0x00A4224C File Offset: 0x00A4044C
		[RequiredMember]
		public float TargetDistanceMeter { get; set; }

		// Token: 0x06024460 RID: 148576 RVA: 0x00A42255 File Offset: 0x00A40455
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ArrowShootResult()
		{
		}
	}
}
