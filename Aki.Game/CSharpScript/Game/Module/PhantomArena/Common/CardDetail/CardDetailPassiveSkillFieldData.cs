using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041EF RID: 16879
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailPassiveSkillFieldData : ICardDetailPassiveSkillFieldData
	{
		// Token: 0x170055E5 RID: 21989
		// (get) Token: 0x0602AB04 RID: 174852 RVA: 0x00C067D3 File Offset: 0x00C049D3
		// (set) Token: 0x0602AB05 RID: 174853 RVA: 0x00C067DB File Offset: 0x00C049DB
		public ICardDetailConditionOutData OutData { get; set; }

		// Token: 0x170055E6 RID: 21990
		// (get) Token: 0x0602AB06 RID: 174854 RVA: 0x00C067E4 File Offset: 0x00C049E4
		// (set) Token: 0x0602AB07 RID: 174855 RVA: 0x00C067EC File Offset: 0x00C049EC
		public ICardDetailConditionInData InData { get; set; }
	}
}
