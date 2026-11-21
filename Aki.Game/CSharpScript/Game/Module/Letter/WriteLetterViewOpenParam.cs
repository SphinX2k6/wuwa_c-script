using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Letter
{
	// Token: 0x0200469F RID: 18079
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WriteLetterViewOpenParam : IWriteLetterViewOpenParam
	{
		// Token: 0x17005B66 RID: 23398
		// (get) Token: 0x0602D72F RID: 186159 RVA: 0x00CBAB5B File Offset: 0x00CB8D5B
		// (set) Token: 0x0602D730 RID: 186160 RVA: 0x00CBAB63 File Offset: 0x00CB8D63
		[RequiredMember]
		public string FlowListName { get; set; }

		// Token: 0x17005B67 RID: 23399
		// (get) Token: 0x0602D731 RID: 186161 RVA: 0x00CBAB6C File Offset: 0x00CB8D6C
		// (set) Token: 0x0602D732 RID: 186162 RVA: 0x00CBAB74 File Offset: 0x00CB8D74
		[RequiredMember]
		public int FlowId { get; set; }

		// Token: 0x17005B68 RID: 23400
		// (get) Token: 0x0602D733 RID: 186163 RVA: 0x00CBAB7D File Offset: 0x00CB8D7D
		// (set) Token: 0x0602D734 RID: 186164 RVA: 0x00CBAB85 File Offset: 0x00CB8D85
		[RequiredMember]
		public int StateId { get; set; }

		// Token: 0x17005B69 RID: 23401
		// (get) Token: 0x0602D735 RID: 186165 RVA: 0x00CBAB8E File Offset: 0x00CB8D8E
		// (set) Token: 0x0602D736 RID: 186166 RVA: 0x00CBAB96 File Offset: 0x00CB8D96
		[RequiredMember]
		public ELetterStyle LetterStyle { get; set; }

		// Token: 0x17005B6A RID: 23402
		// (get) Token: 0x0602D737 RID: 186167 RVA: 0x00CBAB9F File Offset: 0x00CB8D9F
		// (set) Token: 0x0602D738 RID: 186168 RVA: 0x00CBABA7 File Offset: 0x00CB8DA7
		[Nullable(2)]
		public string GameplayId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005B6B RID: 23403
		// (get) Token: 0x0602D739 RID: 186169 RVA: 0x00CBABB0 File Offset: 0x00CB8DB0
		// (set) Token: 0x0602D73A RID: 186170 RVA: 0x00CBABB8 File Offset: 0x00CB8DB8
		public int? LetterId { get; set; }

		// Token: 0x0602D73B RID: 186171 RVA: 0x00CBABC1 File Offset: 0x00CB8DC1
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WriteLetterViewOpenParam()
		{
		}
	}
}
