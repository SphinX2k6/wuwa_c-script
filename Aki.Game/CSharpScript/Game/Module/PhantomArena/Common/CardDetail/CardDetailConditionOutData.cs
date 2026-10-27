using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005219 RID: 21017
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailConditionOutData : ICardDetailConditionOutData
	{
		// Token: 0x17008217 RID: 33303
		// (get) Token: 0x06035BEA RID: 220138 RVA: 0x00CB90DE File Offset: 0x00CB72DE
		// (set) Token: 0x06035BEB RID: 220139 RVA: 0x00CB90E6 File Offset: 0x00CB72E6
		public int CurrentProgress { get; set; }

		// Token: 0x17008218 RID: 33304
		// (get) Token: 0x06035BEC RID: 220140 RVA: 0x00CB90EF File Offset: 0x00CB72EF
		// (set) Token: 0x06035BED RID: 220141 RVA: 0x00CB90F7 File Offset: 0x00CB72F7
		public int MaxProgress { get; set; }

		// Token: 0x17008219 RID: 33305
		// (get) Token: 0x06035BEE RID: 220142 RVA: 0x00CB9100 File Offset: 0x00CB7300
		// (set) Token: 0x06035BEF RID: 220143 RVA: 0x00CB9108 File Offset: 0x00CB7308
		public string Icon { get; set; }

		// Token: 0x1700821A RID: 33306
		// (get) Token: 0x06035BF0 RID: 220144 RVA: 0x00CB9111 File Offset: 0x00CB7311
		// (set) Token: 0x06035BF1 RID: 220145 RVA: 0x00CB9119 File Offset: 0x00CB7319
		public string ConditionDesc { get; set; }

		// Token: 0x1700821B RID: 33307
		// (get) Token: 0x06035BF2 RID: 220146 RVA: 0x00CB9122 File Offset: 0x00CB7322
		// (set) Token: 0x06035BF3 RID: 220147 RVA: 0x00CB912A File Offset: 0x00CB732A
		public string Title { get; set; }

		// Token: 0x1700821C RID: 33308
		// (get) Token: 0x06035BF4 RID: 220148 RVA: 0x00CB9133 File Offset: 0x00CB7333
		// (set) Token: 0x06035BF5 RID: 220149 RVA: 0x00CB913B File Offset: 0x00CB733B
		public bool? TitleChangeColor { get; set; }
	}
}
