using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005566 RID: 21862
	[NullableContext(1)]
	public interface IBoxMark
	{
		// Token: 0x06037BE7 RID: 228327
		string GetTitleText();

		// Token: 0x06037BE8 RID: 228328
		string GetDescText();

		// Token: 0x170085F6 RID: 34294
		// (get) Token: 0x06037BE9 RID: 228329
		string IconPath { get; }
	}
}
