using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041F0 RID: 16880
	[NullableContext(1)]
	public interface ICardDetailPassiveSkillData
	{
		// Token: 0x170055E7 RID: 21991
		// (get) Token: 0x0602AB09 RID: 174857
		// (set) Token: 0x0602AB0A RID: 174858
		string Desc { get; set; }

		// Token: 0x170055E8 RID: 21992
		// (get) Token: 0x0602AB0B RID: 174859
		// (set) Token: 0x0602AB0C RID: 174860
		List<string> Params { get; set; }

		// Token: 0x170055E9 RID: 21993
		// (get) Token: 0x0602AB0D RID: 174861
		// (set) Token: 0x0602AB0E RID: 174862
		ICardDetailEffectCountData EffectCountData { get; set; }

		// Token: 0x170055EA RID: 21994
		// (get) Token: 0x0602AB0F RID: 174863
		// (set) Token: 0x0602AB10 RID: 174864
		ICardDetailPassiveSkillFieldData FieldData { get; set; }
	}
}
