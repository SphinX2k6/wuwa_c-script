using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040F8 RID: 16632
	[RequiredMember]
	public class CollectCardDetailViewTabData
	{
		// Token: 0x0602A056 RID: 172118 RVA: 0x00BE1616 File Offset: 0x00BDF816
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CollectCardDetailViewTabData()
		{
		}

		// Token: 0x04016EC6 RID: 93894
		[RequiredMember]
		public ECollectCardDetailViewTab Index;

		// Token: 0x04016EC7 RID: 93895
		[Nullable(1)]
		[RequiredMember]
		public string NameId;
	}
}
