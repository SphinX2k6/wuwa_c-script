using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x0200725B RID: 29275
	[NullableContext(1)]
	public interface IPlaySequenceData
	{
		// Token: 0x17009E75 RID: 40565
		// (get) Token: 0x06047BD4 RID: 293844
		// (set) Token: 0x06047BD5 RID: 293845
		string Path { get; set; }

		// Token: 0x17009E76 RID: 40566
		// (get) Token: 0x06047BD6 RID: 293846
		// (set) Token: 0x06047BD7 RID: 293847
		bool? ResetCamera { get; set; }
	}
}
