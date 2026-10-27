using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005128 RID: 20776
	[RequiredMember]
	public class CollectCardDetailViewTabData
	{
		// Token: 0x0603515D RID: 217437 RVA: 0x00C94202 File Offset: 0x00C92402
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CollectCardDetailViewTabData()
		{
		}

		// Token: 0x0401C491 RID: 115857
		[RequiredMember]
		public ECollectCardDetailViewTab Index;

		// Token: 0x0401C492 RID: 115858
		[Nullable(1)]
		[RequiredMember]
		public string NameId;
	}
}
