using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C9B RID: 23707
	[NullableContext(1)]
	public interface IPreLoad
	{
		// Token: 0x17008DED RID: 36333
		// (get) Token: 0x0603BE59 RID: 245337
		string ResourceId { get; }

		// Token: 0x17008DEE RID: 36334
		// (get) Token: 0x0603BE5A RID: 245338
		int PreloadCount { get; }
	}
}
