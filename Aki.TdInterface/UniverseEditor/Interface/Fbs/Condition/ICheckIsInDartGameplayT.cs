using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F57 RID: 20311
	public class ICheckIsInDartGameplayT
	{
		// Token: 0x17009129 RID: 37161
		// (get) Token: 0x0601F9AF RID: 129455 RVA: 0x004656F8 File Offset: 0x004638F8
		// (set) Token: 0x0601F9B0 RID: 129456 RVA: 0x00465700 File Offset: 0x00463900
		public ECondition Type { get; set; }

		// Token: 0x1700912A RID: 37162
		// (get) Token: 0x0601F9B1 RID: 129457 RVA: 0x00465709 File Offset: 0x00463909
		// (set) Token: 0x0601F9B2 RID: 129458 RVA: 0x00465711 File Offset: 0x00463911
		public bool IsIn { get; set; }

		// Token: 0x0601F9B3 RID: 129459 RVA: 0x0046571A File Offset: 0x0046391A
		public ICheckIsInDartGameplayT()
		{
			this.Type = ECondition.CompareVar;
			this.IsIn = false;
		}
	}
}
