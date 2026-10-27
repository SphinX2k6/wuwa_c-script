using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CCE RID: 19662
	[NullableContext(1)]
	public interface IButtonState
	{
		// Token: 0x17007D73 RID: 32115
		// (get) Token: 0x06032C31 RID: 207921
		// (set) Token: 0x06032C32 RID: 207922
		string Text { get; set; }

		// Token: 0x17007D74 RID: 32116
		// (get) Token: 0x06032C33 RID: 207923
		// (set) Token: 0x06032C34 RID: 207924
		bool IsHighlight { get; set; }
	}
}
