using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063C5 RID: 25541
	[NullableContext(1)]
	public interface ITextConfig
	{
		// Token: 0x170075AB RID: 30123
		// (get) Token: 0x0603DF40 RID: 253760
		// (set) Token: 0x0603DF41 RID: 253761
		string Text { get; set; }

		// Token: 0x170075AC RID: 30124
		// (get) Token: 0x0603DF42 RID: 253762
		// (set) Token: 0x0603DF43 RID: 253763
		string Sound { get; set; }

		// Token: 0x170075AD RID: 30125
		// (get) Token: 0x0603DF44 RID: 253764
		// (set) Token: 0x0603DF45 RID: 253765
		string EsKey { get; set; }
	}
}
