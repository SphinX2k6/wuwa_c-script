using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005218 RID: 21016
	[NullableContext(1)]
	public interface ICardDetailConditionOutData
	{
		// Token: 0x17008211 RID: 33297
		// (get) Token: 0x06035BDE RID: 220126
		// (set) Token: 0x06035BDF RID: 220127
		int CurrentProgress { get; set; }

		// Token: 0x17008212 RID: 33298
		// (get) Token: 0x06035BE0 RID: 220128
		// (set) Token: 0x06035BE1 RID: 220129
		int MaxProgress { get; set; }

		// Token: 0x17008213 RID: 33299
		// (get) Token: 0x06035BE2 RID: 220130
		// (set) Token: 0x06035BE3 RID: 220131
		string Icon { get; set; }

		// Token: 0x17008214 RID: 33300
		// (get) Token: 0x06035BE4 RID: 220132
		// (set) Token: 0x06035BE5 RID: 220133
		string ConditionDesc { get; set; }

		// Token: 0x17008215 RID: 33301
		// (get) Token: 0x06035BE6 RID: 220134
		// (set) Token: 0x06035BE7 RID: 220135
		string Title { get; set; }

		// Token: 0x17008216 RID: 33302
		// (get) Token: 0x06035BE8 RID: 220136
		// (set) Token: 0x06035BE9 RID: 220137
		bool? TitleChangeColor { get; set; }
	}
}
