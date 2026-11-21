using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Comic
{
	// Token: 0x02004B6C RID: 19308
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ComicPanelOpenParam : IComicPanelOpenParam
	{
		// Token: 0x170060AA RID: 24746
		// (get) Token: 0x060303FB RID: 197627 RVA: 0x00D71D03 File Offset: 0x00D6FF03
		// (set) Token: 0x060303FC RID: 197628 RVA: 0x00D71D0B File Offset: 0x00D6FF0B
		public int ComicConfigId { get; set; }

		// Token: 0x170060AB RID: 24747
		// (get) Token: 0x060303FD RID: 197629 RVA: 0x00D71D14 File Offset: 0x00D6FF14
		// (set) Token: 0x060303FE RID: 197630 RVA: 0x00D71D1C File Offset: 0x00D6FF1C
		[RequiredMember]
		public Action OnSkip { get; set; }

		// Token: 0x170060AC RID: 24748
		// (get) Token: 0x060303FF RID: 197631 RVA: 0x00D71D25 File Offset: 0x00D6FF25
		// (set) Token: 0x06030400 RID: 197632 RVA: 0x00D71D2D File Offset: 0x00D6FF2D
		[RequiredMember]
		public Action OnComplete { get; set; }

		// Token: 0x06030401 RID: 197633 RVA: 0x00D71D36 File Offset: 0x00D6FF36
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ComicPanelOpenParam()
		{
		}
	}
}
