using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02005964 RID: 22884
	public interface IGiantSystemCollectOpenParam
	{
		// Token: 0x17008B28 RID: 35624
		// (get) Token: 0x0603A116 RID: 237846
		// (set) Token: 0x0603A117 RID: 237847
		GiantEcoNetType EcoType { get; set; }

		// Token: 0x17008B29 RID: 35625
		// (get) Token: 0x0603A118 RID: 237848
		// (set) Token: 0x0603A119 RID: 237849
		int IncId { get; set; }
	}
}
