using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005221 RID: 21025
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailPassiveSkillData : ICardDetailPassiveSkillData
	{
		// Token: 0x1700822B RID: 33323
		// (get) Token: 0x06035C16 RID: 220182 RVA: 0x00CB91B9 File Offset: 0x00CB73B9
		// (set) Token: 0x06035C17 RID: 220183 RVA: 0x00CB91C1 File Offset: 0x00CB73C1
		public string Desc { get; set; }

		// Token: 0x1700822C RID: 33324
		// (get) Token: 0x06035C18 RID: 220184 RVA: 0x00CB91CA File Offset: 0x00CB73CA
		// (set) Token: 0x06035C19 RID: 220185 RVA: 0x00CB91D2 File Offset: 0x00CB73D2
		public List<string> Params { get; set; }

		// Token: 0x1700822D RID: 33325
		// (get) Token: 0x06035C1A RID: 220186 RVA: 0x00CB91DB File Offset: 0x00CB73DB
		// (set) Token: 0x06035C1B RID: 220187 RVA: 0x00CB91E3 File Offset: 0x00CB73E3
		public ICardDetailEffectCountData EffectCountData { get; set; }

		// Token: 0x1700822E RID: 33326
		// (get) Token: 0x06035C1C RID: 220188 RVA: 0x00CB91EC File Offset: 0x00CB73EC
		// (set) Token: 0x06035C1D RID: 220189 RVA: 0x00CB91F4 File Offset: 0x00CB73F4
		public ICardDetailPassiveSkillFieldData FieldData { get; set; }
	}
}
