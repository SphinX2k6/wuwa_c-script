using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003644 RID: 13892
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WuWaGoMovableFloorBatchResult : IWuWaGoMovableFloorBatchResult
	{
		// Token: 0x170049A5 RID: 18853
		// (get) Token: 0x06024093 RID: 147603 RVA: 0x00A33636 File Offset: 0x00A31836
		// (set) Token: 0x06024094 RID: 147604 RVA: 0x00A3363E File Offset: 0x00A3183E
		[RequiredMember]
		public bool Committed { get; set; }

		// Token: 0x170049A6 RID: 18854
		// (get) Token: 0x06024095 RID: 147605 RVA: 0x00A33647 File Offset: 0x00A31847
		// (set) Token: 0x06024096 RID: 147606 RVA: 0x00A3364F File Offset: 0x00A3184F
		[RequiredMember]
		public IReadOnlyList<int> MovedRoleIds { get; set; }

		// Token: 0x06024097 RID: 147607 RVA: 0x00A33658 File Offset: 0x00A31858
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WuWaGoMovableFloorBatchResult()
		{
		}
	}
}
