using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006071 RID: 24689
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class DollDescriptionItemData : IDollDescriptionItemData
	{
		// Token: 0x17007033 RID: 28723
		// (get) Token: 0x0603B437 RID: 242743 RVA: 0x010C4E05 File Offset: 0x010C3005
		// (set) Token: 0x0603B438 RID: 242744 RVA: 0x010C4E0D File Offset: 0x010C300D
		[RequiredMember]
		public string IconPath { get; set; }

		// Token: 0x17007034 RID: 28724
		// (get) Token: 0x0603B439 RID: 242745 RVA: 0x010C4E16 File Offset: 0x010C3016
		// (set) Token: 0x0603B43A RID: 242746 RVA: 0x010C4E1E File Offset: 0x010C301E
		[RequiredMember]
		public string TextTitle { get; set; }

		// Token: 0x17007035 RID: 28725
		// (get) Token: 0x0603B43B RID: 242747 RVA: 0x010C4E27 File Offset: 0x010C3027
		// (set) Token: 0x0603B43C RID: 242748 RVA: 0x010C4E2F File Offset: 0x010C302F
		[RequiredMember]
		public string TextContent { get; set; }

		// Token: 0x0603B43D RID: 242749 RVA: 0x010C4E38 File Offset: 0x010C3038
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DollDescriptionItemData()
		{
		}
	}
}
