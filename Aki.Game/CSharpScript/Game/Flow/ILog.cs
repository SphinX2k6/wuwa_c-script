using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063C8 RID: 25544
	[NullableContext(1)]
	public interface ILog
	{
		// Token: 0x170075B1 RID: 30129
		// (get) Token: 0x0603DF4E RID: 253774
		// (set) Token: 0x0603DF4F RID: 253775
		string Level { get; set; }

		// Token: 0x170075B2 RID: 30130
		// (get) Token: 0x0603DF50 RID: 253776
		// (set) Token: 0x0603DF51 RID: 253777
		string Content { get; set; }
	}
}
