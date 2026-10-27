using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004714 RID: 18196
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WuWaGoMovableFloorBatchResult : IWuWaGoMovableFloorBatchResult
	{
		// Token: 0x170076E9 RID: 30441
		// (get) Token: 0x0602F8CD RID: 194765 RVA: 0x00B03966 File Offset: 0x00B01B66
		// (set) Token: 0x0602F8CE RID: 194766 RVA: 0x00B0396E File Offset: 0x00B01B6E
		[RequiredMember]
		public bool Committed { get; set; }

		// Token: 0x170076EA RID: 30442
		// (get) Token: 0x0602F8CF RID: 194767 RVA: 0x00B03977 File Offset: 0x00B01B77
		// (set) Token: 0x0602F8D0 RID: 194768 RVA: 0x00B0397F File Offset: 0x00B01B7F
		[RequiredMember]
		public IReadOnlyList<int> MovedRoleIds { get; set; }

		// Token: 0x0602F8D1 RID: 194769 RVA: 0x00B03988 File Offset: 0x00B01B88
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WuWaGoMovableFloorBatchResult()
		{
		}
	}
}
