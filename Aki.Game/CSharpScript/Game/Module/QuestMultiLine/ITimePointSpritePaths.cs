using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuestMultiLine
{
	// Token: 0x02004FA5 RID: 20389
	[NullableContext(1)]
	public interface ITimePointSpritePaths
	{
		// Token: 0x17007F6F RID: 32623
		// (get) Token: 0x0603431C RID: 213788
		// (set) Token: 0x0603431D RID: 213789
		string Idle { get; set; }

		// Token: 0x17007F70 RID: 32624
		// (get) Token: 0x0603431E RID: 213790
		// (set) Token: 0x0603431F RID: 213791
		string Hover { get; set; }

		// Token: 0x17007F71 RID: 32625
		// (get) Token: 0x06034320 RID: 213792
		// (set) Token: 0x06034321 RID: 213793
		string Pressed { get; set; }

		// Token: 0x17007F72 RID: 32626
		// (get) Token: 0x06034322 RID: 213794
		// (set) Token: 0x06034323 RID: 213795
		string Selected { get; set; }
	}
}
