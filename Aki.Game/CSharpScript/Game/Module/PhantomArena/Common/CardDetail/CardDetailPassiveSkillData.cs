using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041F1 RID: 16881
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailPassiveSkillData : ICardDetailPassiveSkillData
	{
		// Token: 0x170055EB RID: 21995
		// (get) Token: 0x0602AB11 RID: 174865 RVA: 0x00C067FD File Offset: 0x00C049FD
		// (set) Token: 0x0602AB12 RID: 174866 RVA: 0x00C06805 File Offset: 0x00C04A05
		public string Desc { get; set; }

		// Token: 0x170055EC RID: 21996
		// (get) Token: 0x0602AB13 RID: 174867 RVA: 0x00C0680E File Offset: 0x00C04A0E
		// (set) Token: 0x0602AB14 RID: 174868 RVA: 0x00C06816 File Offset: 0x00C04A16
		public List<string> Params { get; set; }

		// Token: 0x170055ED RID: 21997
		// (get) Token: 0x0602AB15 RID: 174869 RVA: 0x00C0681F File Offset: 0x00C04A1F
		// (set) Token: 0x0602AB16 RID: 174870 RVA: 0x00C06827 File Offset: 0x00C04A27
		public ICardDetailEffectCountData EffectCountData { get; set; }

		// Token: 0x170055EE RID: 21998
		// (get) Token: 0x0602AB17 RID: 174871 RVA: 0x00C06830 File Offset: 0x00C04A30
		// (set) Token: 0x0602AB18 RID: 174872 RVA: 0x00C06838 File Offset: 0x00C04A38
		public ICardDetailPassiveSkillFieldData FieldData { get; set; }
	}
}
