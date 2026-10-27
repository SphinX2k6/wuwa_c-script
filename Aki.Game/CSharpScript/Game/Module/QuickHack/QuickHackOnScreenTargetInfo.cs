using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F82 RID: 20354
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class QuickHackOnScreenTargetInfo : IQuickHackOnScreenTargetInfo
	{
		// Token: 0x17007F5F RID: 32607
		// (get) Token: 0x060341EC RID: 213484 RVA: 0x00C3B49F File Offset: 0x00C3969F
		// (set) Token: 0x060341ED RID: 213485 RVA: 0x00C3B4A7 File Offset: 0x00C396A7
		[RequiredMember]
		public Dictionary<int, int> TargetIdToIndexMap { get; set; }

		// Token: 0x17007F60 RID: 32608
		// (get) Token: 0x060341EE RID: 213486 RVA: 0x00C3B4B0 File Offset: 0x00C396B0
		// (set) Token: 0x060341EF RID: 213487 RVA: 0x00C3B4B8 File Offset: 0x00C396B8
		[RequiredMember]
		public List<EntityHandle> Targets { get; set; }

		// Token: 0x17007F61 RID: 32609
		// (get) Token: 0x060341F0 RID: 213488 RVA: 0x00C3B4C1 File Offset: 0x00C396C1
		// (set) Token: 0x060341F1 RID: 213489 RVA: 0x00C3B4C9 File Offset: 0x00C396C9
		[RequiredMember]
		public List<double> SignedScreenDistSquaredList { get; set; }

		// Token: 0x17007F62 RID: 32610
		// (get) Token: 0x060341F2 RID: 213490 RVA: 0x00C3B4D2 File Offset: 0x00C396D2
		// (set) Token: 0x060341F3 RID: 213491 RVA: 0x00C3B4DA File Offset: 0x00C396DA
		[RequiredMember]
		public List<double> DistSquaredList { get; set; }

		// Token: 0x060341F4 RID: 213492 RVA: 0x00C3B4E3 File Offset: 0x00C396E3
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public QuickHackOnScreenTargetInfo()
		{
		}
	}
}
