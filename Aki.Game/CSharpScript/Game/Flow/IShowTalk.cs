using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063CE RID: 25550
	[NullableContext(1)]
	public interface IShowTalk
	{
		// Token: 0x170075C0 RID: 30144
		// (get) Token: 0x0603DF6C RID: 253804
		// (set) Token: 0x0603DF6D RID: 253805
		bool? ResetCamera { get; set; }

		// Token: 0x170075C1 RID: 30145
		// (get) Token: 0x0603DF6E RID: 253806
		// (set) Token: 0x0603DF6F RID: 253807
		ITalkItem[] TalkItems { get; set; }
	}
}
