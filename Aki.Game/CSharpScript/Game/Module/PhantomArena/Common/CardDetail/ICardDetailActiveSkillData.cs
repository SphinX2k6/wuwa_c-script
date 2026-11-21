using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041D2 RID: 16850
	[NullableContext(1)]
	public interface ICardDetailActiveSkillData
	{
		// Token: 0x170055BB RID: 21947
		// (get) Token: 0x0602AA6F RID: 174703
		// (set) Token: 0x0602AA70 RID: 174704
		string Desc { get; set; }

		// Token: 0x170055BC RID: 21948
		// (get) Token: 0x0602AA71 RID: 174705
		// (set) Token: 0x0602AA72 RID: 174706
		List<string> Params { get; set; }
	}
}
