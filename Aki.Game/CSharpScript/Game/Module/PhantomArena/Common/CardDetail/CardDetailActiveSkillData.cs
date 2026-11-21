using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041D3 RID: 16851
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailActiveSkillData : ICardDetailActiveSkillData
	{
		// Token: 0x170055BD RID: 21949
		// (get) Token: 0x0602AA73 RID: 174707 RVA: 0x00C056E3 File Offset: 0x00C038E3
		// (set) Token: 0x0602AA74 RID: 174708 RVA: 0x00C056EB File Offset: 0x00C038EB
		public string Desc { get; set; }

		// Token: 0x170055BE RID: 21950
		// (get) Token: 0x0602AA75 RID: 174709 RVA: 0x00C056F4 File Offset: 0x00C038F4
		// (set) Token: 0x0602AA76 RID: 174710 RVA: 0x00C056FC File Offset: 0x00C038FC
		public List<string> Params { get; set; }
	}
}
