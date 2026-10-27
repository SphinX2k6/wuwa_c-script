using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EF1 RID: 28401
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class DollDescriptionItemData : IDollDescriptionItemData
	{
		// Token: 0x17009AF4 RID: 39668
		// (get) Token: 0x0604528E RID: 283278 RVA: 0x0111B075 File Offset: 0x01119275
		// (set) Token: 0x0604528F RID: 283279 RVA: 0x0111B07D File Offset: 0x0111927D
		[RequiredMember]
		public string IconPath { get; set; }

		// Token: 0x17009AF5 RID: 39669
		// (get) Token: 0x06045290 RID: 283280 RVA: 0x0111B086 File Offset: 0x01119286
		// (set) Token: 0x06045291 RID: 283281 RVA: 0x0111B08E File Offset: 0x0111928E
		[RequiredMember]
		public string TextTitle { get; set; }

		// Token: 0x17009AF6 RID: 39670
		// (get) Token: 0x06045292 RID: 283282 RVA: 0x0111B097 File Offset: 0x01119297
		// (set) Token: 0x06045293 RID: 283283 RVA: 0x0111B09F File Offset: 0x0111929F
		[RequiredMember]
		public string TextContent { get; set; }

		// Token: 0x06045294 RID: 283284 RVA: 0x0111B0A8 File Offset: 0x011192A8
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DollDescriptionItemData()
		{
		}
	}
}
