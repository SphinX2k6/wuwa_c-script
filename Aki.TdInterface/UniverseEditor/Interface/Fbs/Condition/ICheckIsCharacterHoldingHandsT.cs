using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F48 RID: 20296
	public class ICheckIsCharacterHoldingHandsT
	{
		// Token: 0x1700910B RID: 37131
		// (get) Token: 0x0601F931 RID: 129329 RVA: 0x004648B5 File Offset: 0x00462AB5
		// (set) Token: 0x0601F932 RID: 129330 RVA: 0x004648BD File Offset: 0x00462ABD
		public ECondition Type { get; set; }

		// Token: 0x1700910C RID: 37132
		// (get) Token: 0x0601F933 RID: 129331 RVA: 0x004648C6 File Offset: 0x00462AC6
		// (set) Token: 0x0601F934 RID: 129332 RVA: 0x004648CE File Offset: 0x00462ACE
		public TCheckHoldingHandsCharacterUnion Target { get; set; }

		// Token: 0x1700910D RID: 37133
		// (get) Token: 0x0601F935 RID: 129333 RVA: 0x004648D7 File Offset: 0x00462AD7
		// (set) Token: 0x0601F936 RID: 129334 RVA: 0x004648DF File Offset: 0x00462ADF
		public bool IsHoldingHands { get; set; }

		// Token: 0x0601F937 RID: 129335 RVA: 0x004648E8 File Offset: 0x00462AE8
		public ICheckIsCharacterHoldingHandsT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.IsHoldingHands = false;
		}
	}
}
