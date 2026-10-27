using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x0200521F RID: 21023
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailPassiveSkillFieldData : ICardDetailPassiveSkillFieldData
	{
		// Token: 0x17008225 RID: 33317
		// (get) Token: 0x06035C09 RID: 220169 RVA: 0x00CB918F File Offset: 0x00CB738F
		// (set) Token: 0x06035C0A RID: 220170 RVA: 0x00CB9197 File Offset: 0x00CB7397
		public ICardDetailConditionOutData OutData { get; set; }

		// Token: 0x17008226 RID: 33318
		// (get) Token: 0x06035C0B RID: 220171 RVA: 0x00CB91A0 File Offset: 0x00CB73A0
		// (set) Token: 0x06035C0C RID: 220172 RVA: 0x00CB91A8 File Offset: 0x00CB73A8
		public ICardDetailConditionInData InData { get; set; }
	}
}
