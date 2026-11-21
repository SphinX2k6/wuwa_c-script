using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02004961 RID: 18785
	[RequiredMember]
	public class GiantQuestGuideItemInfo : IGiantQuestGuideItemInfo
	{
		// Token: 0x17005F24 RID: 24356
		// (get) Token: 0x0602F1A7 RID: 192935 RVA: 0x00D22CFD File Offset: 0x00D20EFD
		// (set) Token: 0x0602F1A8 RID: 192936 RVA: 0x00D22D05 File Offset: 0x00D20F05
		[RequiredMember]
		public int ItemId { get; set; }

		// Token: 0x17005F25 RID: 24357
		// (get) Token: 0x0602F1A9 RID: 192937 RVA: 0x00D22D0E File Offset: 0x00D20F0E
		// (set) Token: 0x0602F1AA RID: 192938 RVA: 0x00D22D16 File Offset: 0x00D20F16
		[RequiredMember]
		public int Count { get; set; }

		// Token: 0x0602F1AB RID: 192939 RVA: 0x00D22D1F File Offset: 0x00D20F1F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantQuestGuideItemInfo()
		{
		}
	}
}
