using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x02003827 RID: 14375
	[RequiredMember]
	public class MoveCheckResultAndDistance : IMoveCheckResultAndDistance
	{
		// Token: 0x17004CD2 RID: 19666
		// (get) Token: 0x06025556 RID: 152918 RVA: 0x00A8555F File Offset: 0x00A8375F
		// (set) Token: 0x06025557 RID: 152919 RVA: 0x00A85567 File Offset: 0x00A83767
		[RequiredMember]
		public EMoveCheckResult Result { get; set; }

		// Token: 0x17004CD3 RID: 19667
		// (get) Token: 0x06025558 RID: 152920 RVA: 0x00A85570 File Offset: 0x00A83770
		// (set) Token: 0x06025559 RID: 152921 RVA: 0x00A85578 File Offset: 0x00A83778
		[RequiredMember]
		public float AfterAdjustDistance { get; set; }

		// Token: 0x0602555A RID: 152922 RVA: 0x00A85581 File Offset: 0x00A83781
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MoveCheckResultAndDistance()
		{
		}
	}
}
