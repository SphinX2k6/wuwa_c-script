using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x0200521E RID: 21022
	[NullableContext(1)]
	public interface ICardDetailPassiveSkillFieldData
	{
		// Token: 0x17008223 RID: 33315
		// (get) Token: 0x06035C05 RID: 220165
		// (set) Token: 0x06035C06 RID: 220166
		ICardDetailConditionOutData OutData { get; set; }

		// Token: 0x17008224 RID: 33316
		// (get) Token: 0x06035C07 RID: 220167
		// (set) Token: 0x06035C08 RID: 220168
		ICardDetailConditionInData InData { get; set; }
	}
}
