using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200431D RID: 17181
	public class IKurotatoConditionStepEndT
	{
		// Token: 0x170075A3 RID: 30115
		// (get) Token: 0x060182A4 RID: 98980 RVA: 0x0037244A File Offset: 0x0037064A
		// (set) Token: 0x060182A5 RID: 98981 RVA: 0x00372452 File Offset: 0x00370652
		public EKurotatoConditionStep Type { get; set; }

		// Token: 0x060182A6 RID: 98982 RVA: 0x0037245B File Offset: 0x0037065B
		public IKurotatoConditionStepEndT()
		{
			this.Type = EKurotatoConditionStep.Prepare;
		}
	}
}
