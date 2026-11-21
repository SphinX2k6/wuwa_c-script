using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007469 RID: 29801
	public class IPlayerBlendAnimTargetT
	{
		// Token: 0x1700DAF7 RID: 56055
		// (get) Token: 0x060342BD RID: 213693 RVA: 0x0070754E File Offset: 0x0070574E
		// (set) Token: 0x060342BE RID: 213694 RVA: 0x00707556 File Offset: 0x00705756
		public EBlendAnimTarget Type { get; set; }

		// Token: 0x060342BF RID: 213695 RVA: 0x0070755F File Offset: 0x0070575F
		public IPlayerBlendAnimTargetT()
		{
			this.Type = EBlendAnimTarget.Player;
		}
	}
}
