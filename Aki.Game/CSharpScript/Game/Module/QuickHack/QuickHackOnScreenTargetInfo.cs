using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F4B RID: 16203
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class QuickHackOnScreenTargetInfo : IQuickHackOnScreenTargetInfo
	{
		// Token: 0x1700530F RID: 21263
		// (get) Token: 0x0602905A RID: 168026 RVA: 0x00B84C4B File Offset: 0x00B82E4B
		// (set) Token: 0x0602905B RID: 168027 RVA: 0x00B84C53 File Offset: 0x00B82E53
		[RequiredMember]
		public Dictionary<int, int> TargetIdToIndexMap { get; set; }

		// Token: 0x17005310 RID: 21264
		// (get) Token: 0x0602905C RID: 168028 RVA: 0x00B84C5C File Offset: 0x00B82E5C
		// (set) Token: 0x0602905D RID: 168029 RVA: 0x00B84C64 File Offset: 0x00B82E64
		[RequiredMember]
		public List<EntityHandle> Targets { get; set; }

		// Token: 0x17005311 RID: 21265
		// (get) Token: 0x0602905E RID: 168030 RVA: 0x00B84C6D File Offset: 0x00B82E6D
		// (set) Token: 0x0602905F RID: 168031 RVA: 0x00B84C75 File Offset: 0x00B82E75
		[RequiredMember]
		public List<double> SignedScreenDistSquaredList { get; set; }

		// Token: 0x17005312 RID: 21266
		// (get) Token: 0x06029060 RID: 168032 RVA: 0x00B84C7E File Offset: 0x00B82E7E
		// (set) Token: 0x06029061 RID: 168033 RVA: 0x00B84C86 File Offset: 0x00B82E86
		[RequiredMember]
		public List<double> DistSquaredList { get; set; }

		// Token: 0x06029062 RID: 168034 RVA: 0x00B84C8F File Offset: 0x00B82E8F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public QuickHackOnScreenTargetInfo()
		{
		}
	}
}
