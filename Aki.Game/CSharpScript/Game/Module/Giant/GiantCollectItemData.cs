using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02004947 RID: 18759
	[RequiredMember]
	public class GiantCollectItemData
	{
		// Token: 0x0602F0AB RID: 192683 RVA: 0x00D1D830 File Offset: 0x00D1BA30
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantCollectItemData()
		{
		}

		// Token: 0x04018F4F RID: 102223
		[RequiredMember]
		public int ItemId;

		// Token: 0x04018F50 RID: 102224
		[RequiredMember]
		public bool IsLocked;

		// Token: 0x04018F51 RID: 102225
		public bool? IsDelivered;

		// Token: 0x04018F52 RID: 102226
		[Nullable(1)]
		[RequiredMember]
		public Action<int> OnClick;
	}
}
