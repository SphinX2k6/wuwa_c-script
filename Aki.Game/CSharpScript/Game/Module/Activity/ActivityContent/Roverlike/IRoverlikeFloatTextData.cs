using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060EE RID: 24814
	[NullableContext(1)]
	public interface IRoverlikeFloatTextData
	{
		// Token: 0x17009149 RID: 37193
		// (get) Token: 0x0603EC0C RID: 257036
		// (set) Token: 0x0603EC0D RID: 257037
		ERoverlikeFloatTextType Type { get; set; }

		// Token: 0x1700914A RID: 37194
		// (get) Token: 0x0603EC0E RID: 257038
		// (set) Token: 0x0603EC0F RID: 257039
		string TextKey { get; set; }

		// Token: 0x1700914B RID: 37195
		// (get) Token: 0x0603EC10 RID: 257040
		// (set) Token: 0x0603EC11 RID: 257041
		string[] TextParam { get; set; }
	}
}
