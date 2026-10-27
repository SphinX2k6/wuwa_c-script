using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x0200596E RID: 22894
	[RequiredMember]
	public class GiantCollectItemData
	{
		// Token: 0x0603A185 RID: 237957 RVA: 0x00DCE5A8 File Offset: 0x00DCC7A8
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantCollectItemData()
		{
		}

		// Token: 0x0401E4B1 RID: 124081
		[RequiredMember]
		public int ItemId;

		// Token: 0x0401E4B2 RID: 124082
		[RequiredMember]
		public bool IsLocked;

		// Token: 0x0401E4B3 RID: 124083
		public bool? IsDelivered;

		// Token: 0x0401E4B4 RID: 124084
		[Nullable(1)]
		[RequiredMember]
		public Action<int> OnClick;
	}
}
