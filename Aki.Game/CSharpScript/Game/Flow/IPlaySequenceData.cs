using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Flow
{
	// Token: 0x020063DA RID: 25562
	[NullableContext(1)]
	public interface IPlaySequenceData
	{
		// Token: 0x170075CD RID: 30157
		// (get) Token: 0x0603DF8C RID: 253836
		// (set) Token: 0x0603DF8D RID: 253837
		string Path { get; set; }

		// Token: 0x170075CE RID: 30158
		// (get) Token: 0x0603DF8E RID: 253838
		// (set) Token: 0x0603DF8F RID: 253839
		bool? ResetCamera { get; set; }
	}
}
