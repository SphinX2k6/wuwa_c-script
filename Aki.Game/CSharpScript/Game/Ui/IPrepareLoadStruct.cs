using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046C5 RID: 18117
	[NullableContext(1)]
	public interface IPrepareLoadStruct
	{
		// Token: 0x1700766B RID: 30315
		// (get) Token: 0x0602EB90 RID: 191376
		string ResourceId { get; }

		// Token: 0x1700766C RID: 30316
		// (get) Token: 0x0602EB91 RID: 191377
		Func<int> CacheCount { get; }
	}
}
