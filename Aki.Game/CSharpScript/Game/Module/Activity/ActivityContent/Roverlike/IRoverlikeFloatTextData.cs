using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200506C RID: 20588
	[NullableContext(1)]
	public interface IRoverlikeFloatTextData
	{
		// Token: 0x170064AB RID: 25771
		// (get) Token: 0x060338CE RID: 211150
		// (set) Token: 0x060338CF RID: 211151
		ERoverlikeFloatTextType Type { get; set; }

		// Token: 0x170064AC RID: 25772
		// (get) Token: 0x060338D0 RID: 211152
		// (set) Token: 0x060338D1 RID: 211153
		string TextKey { get; set; }

		// Token: 0x170064AD RID: 25773
		// (get) Token: 0x060338D2 RID: 211154
		// (set) Token: 0x060338D3 RID: 211155
		string[] TextParam { get; set; }
	}
}
