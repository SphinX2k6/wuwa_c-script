using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004326 RID: 17190
	public class IKurotatoConditionStepShoppingT
	{
		// Token: 0x170075AC RID: 30124
		// (get) Token: 0x060182DA RID: 99034 RVA: 0x003728B2 File Offset: 0x00370AB2
		// (set) Token: 0x060182DB RID: 99035 RVA: 0x003728BA File Offset: 0x00370ABA
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x060182DC RID: 99036 RVA: 0x003728C3 File Offset: 0x00370AC3
		public IKurotatoConditionStepShoppingT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
