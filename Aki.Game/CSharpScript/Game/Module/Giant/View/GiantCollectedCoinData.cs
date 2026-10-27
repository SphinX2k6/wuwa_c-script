using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x0200597A RID: 22906
	[RequiredMember]
	public class GiantCollectedCoinData : IGiantCollectedCoinData
	{
		// Token: 0x17008B3F RID: 35647
		// (get) Token: 0x0603A22A RID: 238122 RVA: 0x00DD2E23 File Offset: 0x00DD1023
		// (set) Token: 0x0603A22B RID: 238123 RVA: 0x00DD2E2B File Offset: 0x00DD102B
		[RequiredMember]
		public int ItemId { get; set; }

		// Token: 0x17008B40 RID: 35648
		// (get) Token: 0x0603A22C RID: 238124 RVA: 0x00DD2E34 File Offset: 0x00DD1034
		// (set) Token: 0x0603A22D RID: 238125 RVA: 0x00DD2E3C File Offset: 0x00DD103C
		[RequiredMember]
		public int Count { get; set; }

		// Token: 0x0603A22E RID: 238126 RVA: 0x00DD2E45 File Offset: 0x00DD1045
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantCollectedCoinData()
		{
		}
	}
}
