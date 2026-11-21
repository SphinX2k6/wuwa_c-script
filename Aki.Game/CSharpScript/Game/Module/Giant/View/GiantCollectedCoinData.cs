using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02004953 RID: 18771
	[RequiredMember]
	public class GiantCollectedCoinData : IGiantCollectedCoinData
	{
		// Token: 0x17005F0C RID: 24332
		// (get) Token: 0x0602F150 RID: 192848 RVA: 0x00D222B3 File Offset: 0x00D204B3
		// (set) Token: 0x0602F151 RID: 192849 RVA: 0x00D222BB File Offset: 0x00D204BB
		[RequiredMember]
		public int ItemId { get; set; }

		// Token: 0x17005F0D RID: 24333
		// (get) Token: 0x0602F152 RID: 192850 RVA: 0x00D222C4 File Offset: 0x00D204C4
		// (set) Token: 0x0602F153 RID: 192851 RVA: 0x00D222CC File Offset: 0x00D204CC
		[RequiredMember]
		public int Count { get; set; }

		// Token: 0x0602F154 RID: 192852 RVA: 0x00D222D5 File Offset: 0x00D204D5
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantCollectedCoinData()
		{
		}
	}
}
