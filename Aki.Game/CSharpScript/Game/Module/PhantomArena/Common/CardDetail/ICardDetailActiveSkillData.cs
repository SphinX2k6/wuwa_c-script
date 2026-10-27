using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005202 RID: 20994
	[NullableContext(1)]
	public interface ICardDetailActiveSkillData
	{
		// Token: 0x170081FB RID: 33275
		// (get) Token: 0x06035B74 RID: 220020
		// (set) Token: 0x06035B75 RID: 220021
		string Desc { get; set; }

		// Token: 0x170081FC RID: 33276
		// (get) Token: 0x06035B76 RID: 220022
		// (set) Token: 0x06035B77 RID: 220023
		List<string> Params { get; set; }
	}
}
