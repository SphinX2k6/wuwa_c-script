using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02005988 RID: 22920
	[RequiredMember]
	public class GiantQuestGuideItemInfo : IGiantQuestGuideItemInfo
	{
		// Token: 0x17008B57 RID: 35671
		// (get) Token: 0x0603A281 RID: 238209 RVA: 0x00DD386D File Offset: 0x00DD1A6D
		// (set) Token: 0x0603A282 RID: 238210 RVA: 0x00DD3875 File Offset: 0x00DD1A75
		[RequiredMember]
		public int ItemId { get; set; }

		// Token: 0x17008B58 RID: 35672
		// (get) Token: 0x0603A283 RID: 238211 RVA: 0x00DD387E File Offset: 0x00DD1A7E
		// (set) Token: 0x0603A284 RID: 238212 RVA: 0x00DD3886 File Offset: 0x00DD1A86
		[RequiredMember]
		public int Count { get; set; }

		// Token: 0x0603A285 RID: 238213 RVA: 0x00DD388F File Offset: 0x00DD1A8F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantQuestGuideItemInfo()
		{
		}
	}
}
