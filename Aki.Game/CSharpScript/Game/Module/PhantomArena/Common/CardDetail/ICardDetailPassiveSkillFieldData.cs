using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041EE RID: 16878
	[NullableContext(1)]
	public interface ICardDetailPassiveSkillFieldData
	{
		// Token: 0x170055E3 RID: 21987
		// (get) Token: 0x0602AB00 RID: 174848
		// (set) Token: 0x0602AB01 RID: 174849
		ICardDetailConditionOutData OutData { get; set; }

		// Token: 0x170055E4 RID: 21988
		// (get) Token: 0x0602AB02 RID: 174850
		// (set) Token: 0x0602AB03 RID: 174851
		ICardDetailConditionInData InData { get; set; }
	}
}
