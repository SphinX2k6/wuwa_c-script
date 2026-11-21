using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x02002F92 RID: 12178
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ChairSummonResult : IChairSummonResult
	{
		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x0601CE10 RID: 118288 RVA: 0x008D29F7 File Offset: 0x008D0BF7
		// (set) Token: 0x0601CE11 RID: 118289 RVA: 0x008D29FF File Offset: 0x008D0BFF
		public bool Success { get; set; }

		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x0601CE12 RID: 118290 RVA: 0x008D2A08 File Offset: 0x008D0C08
		// (set) Token: 0x0601CE13 RID: 118291 RVA: 0x008D2A10 File Offset: 0x008D0C10
		public string FailReason { get; set; } = "";

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x0601CE14 RID: 118292 RVA: 0x008D2A19 File Offset: 0x008D0C19
		// (set) Token: 0x0601CE15 RID: 118293 RVA: 0x008D2A21 File Offset: 0x008D0C21
		[RequiredMember]
		public Vector FinalLocation { get; set; }

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x0601CE16 RID: 118294 RVA: 0x008D2A2A File Offset: 0x008D0C2A
		// (set) Token: 0x0601CE17 RID: 118295 RVA: 0x008D2A32 File Offset: 0x008D0C32
		public float Yaw { get; set; }

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x0601CE18 RID: 118296 RVA: 0x008D2A3B File Offset: 0x008D0C3B
		// (set) Token: 0x0601CE19 RID: 118297 RVA: 0x008D2A43 File Offset: 0x008D0C43
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public List<ValueTuple<Vector, Vector>> DownRayLines { [return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] set; } = new List<ValueTuple<Vector, Vector>>();

		// Token: 0x0601CE1A RID: 118298 RVA: 0x008D2A4C File Offset: 0x008D0C4C
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ChairSummonResult()
		{
		}
	}
}
