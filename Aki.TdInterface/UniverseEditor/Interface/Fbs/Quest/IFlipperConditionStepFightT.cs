using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200429F RID: 17055
	public class IFlipperConditionStepFightT
	{
		// Token: 0x170074A0 RID: 29856
		// (get) Token: 0x06017DED RID: 97773 RVA: 0x00368C8E File Offset: 0x00366E8E
		// (set) Token: 0x06017DEE RID: 97774 RVA: 0x00368C96 File Offset: 0x00366E96
		public EFlipperConditionStep Type { get; set; }

		// Token: 0x06017DEF RID: 97775 RVA: 0x00368C9F File Offset: 0x00366E9F
		public IFlipperConditionStepFightT()
		{
			this.Type = EFlipperConditionStep.Fight;
		}
	}
}
