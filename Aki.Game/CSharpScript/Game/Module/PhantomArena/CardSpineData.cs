using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040F0 RID: 16624
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class CardSpineData
	{
		// Token: 0x0602A04E RID: 172110 RVA: 0x00BE15D6 File Offset: 0x00BDF7D6
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CardSpineData()
		{
		}

		// Token: 0x04016EB2 RID: 93874
		[RequiredMember]
		public string CardSpineAtlasPath;

		// Token: 0x04016EB3 RID: 93875
		[RequiredMember]
		public string CardSpineSkeletonPath;

		// Token: 0x04016EB4 RID: 93876
		[RequiredMember]
		public ECardSpineAnimation AnimationName;

		// Token: 0x04016EB5 RID: 93877
		[RequiredMember]
		public bool IsLoop;
	}
}
