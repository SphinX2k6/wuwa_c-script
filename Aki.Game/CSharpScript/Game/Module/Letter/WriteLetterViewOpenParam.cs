using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Letter
{
	// Token: 0x020056C8 RID: 22216
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WriteLetterViewOpenParam : IWriteLetterViewOpenParam
	{
		// Token: 0x1700879E RID: 34718
		// (get) Token: 0x0603881F RID: 231455 RVA: 0x00D6C5A3 File Offset: 0x00D6A7A3
		// (set) Token: 0x06038820 RID: 231456 RVA: 0x00D6C5AB File Offset: 0x00D6A7AB
		[RequiredMember]
		public string FlowListName { get; set; }

		// Token: 0x1700879F RID: 34719
		// (get) Token: 0x06038821 RID: 231457 RVA: 0x00D6C5B4 File Offset: 0x00D6A7B4
		// (set) Token: 0x06038822 RID: 231458 RVA: 0x00D6C5BC File Offset: 0x00D6A7BC
		[RequiredMember]
		public int FlowId { get; set; }

		// Token: 0x170087A0 RID: 34720
		// (get) Token: 0x06038823 RID: 231459 RVA: 0x00D6C5C5 File Offset: 0x00D6A7C5
		// (set) Token: 0x06038824 RID: 231460 RVA: 0x00D6C5CD File Offset: 0x00D6A7CD
		[RequiredMember]
		public int StateId { get; set; }

		// Token: 0x170087A1 RID: 34721
		// (get) Token: 0x06038825 RID: 231461 RVA: 0x00D6C5D6 File Offset: 0x00D6A7D6
		// (set) Token: 0x06038826 RID: 231462 RVA: 0x00D6C5DE File Offset: 0x00D6A7DE
		[RequiredMember]
		public ELetterStyle LetterStyle { get; set; }

		// Token: 0x170087A2 RID: 34722
		// (get) Token: 0x06038827 RID: 231463 RVA: 0x00D6C5E7 File Offset: 0x00D6A7E7
		// (set) Token: 0x06038828 RID: 231464 RVA: 0x00D6C5EF File Offset: 0x00D6A7EF
		[Nullable(2)]
		public string GameplayId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170087A3 RID: 34723
		// (get) Token: 0x06038829 RID: 231465 RVA: 0x00D6C5F8 File Offset: 0x00D6A7F8
		// (set) Token: 0x0603882A RID: 231466 RVA: 0x00D6C600 File Offset: 0x00D6A800
		public int? LetterId { get; set; }

		// Token: 0x0603882B RID: 231467 RVA: 0x00D6C609 File Offset: 0x00D6A809
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WriteLetterViewOpenParam()
		{
		}
	}
}
