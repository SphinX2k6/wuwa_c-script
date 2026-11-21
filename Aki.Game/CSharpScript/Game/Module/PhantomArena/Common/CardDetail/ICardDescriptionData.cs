using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041E2 RID: 16866
	[NullableContext(1)]
	public interface ICardDescriptionData
	{
		// Token: 0x170055C9 RID: 21961
		// (get) Token: 0x0602AAAD RID: 174765
		// (set) Token: 0x0602AAAE RID: 174766
		string Description { get; set; }

		// Token: 0x170055CA RID: 21962
		// (get) Token: 0x0602AAAF RID: 174767
		// (set) Token: 0x0602AAB0 RID: 174768
		List<string> DescriptionParams { get; set; }
	}
}
