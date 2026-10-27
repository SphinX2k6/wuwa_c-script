using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005203 RID: 20995
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailActiveSkillData : ICardDetailActiveSkillData
	{
		// Token: 0x170081FD RID: 33277
		// (get) Token: 0x06035B78 RID: 220024 RVA: 0x00CB80A7 File Offset: 0x00CB62A7
		// (set) Token: 0x06035B79 RID: 220025 RVA: 0x00CB80AF File Offset: 0x00CB62AF
		public string Desc { get; set; }

		// Token: 0x170081FE RID: 33278
		// (get) Token: 0x06035B7A RID: 220026 RVA: 0x00CB80B8 File Offset: 0x00CB62B8
		// (set) Token: 0x06035B7B RID: 220027 RVA: 0x00CB80C0 File Offset: 0x00CB62C0
		public List<string> Params { get; set; }
	}
}
