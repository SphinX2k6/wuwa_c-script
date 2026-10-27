using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005120 RID: 20768
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class CardSpineData
	{
		// Token: 0x06035155 RID: 217429 RVA: 0x00C941C2 File Offset: 0x00C923C2
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardSpineData()
		{
		}

		// Token: 0x0401C47D RID: 115837
		[RequiredMember]
		public string CardSpineAtlasPath;

		// Token: 0x0401C47E RID: 115838
		[RequiredMember]
		public string CardSpineSkeletonPath;

		// Token: 0x0401C47F RID: 115839
		[RequiredMember]
		public ECardSpineAnimation AnimationName;

		// Token: 0x0401C480 RID: 115840
		[RequiredMember]
		public bool IsLoop;
	}
}
