using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005220 RID: 21024
	[NullableContext(1)]
	public interface ICardDetailPassiveSkillData
	{
		// Token: 0x17008227 RID: 33319
		// (get) Token: 0x06035C0E RID: 220174
		// (set) Token: 0x06035C0F RID: 220175
		string Desc { get; set; }

		// Token: 0x17008228 RID: 33320
		// (get) Token: 0x06035C10 RID: 220176
		// (set) Token: 0x06035C11 RID: 220177
		List<string> Params { get; set; }

		// Token: 0x17008229 RID: 33321
		// (get) Token: 0x06035C12 RID: 220178
		// (set) Token: 0x06035C13 RID: 220179
		ICardDetailEffectCountData EffectCountData { get; set; }

		// Token: 0x1700822A RID: 33322
		// (get) Token: 0x06035C14 RID: 220180
		// (set) Token: 0x06035C15 RID: 220181
		ICardDetailPassiveSkillFieldData FieldData { get; set; }
	}
}
