using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005212 RID: 21010
	[NullableContext(1)]
	public interface ICardDescriptionData
	{
		// Token: 0x17008209 RID: 33289
		// (get) Token: 0x06035BB2 RID: 220082
		// (set) Token: 0x06035BB3 RID: 220083
		string Description { get; set; }

		// Token: 0x1700820A RID: 33290
		// (get) Token: 0x06035BB4 RID: 220084
		// (set) Token: 0x06035BB5 RID: 220085
		List<string> DescriptionParams { get; set; }
	}
}
