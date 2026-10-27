using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004161 RID: 16737
	public class ISurvivorsRougeConditionStepChooseWeaponT
	{
		// Token: 0x17007694 RID: 30356
		// (get) Token: 0x06018954 RID: 100692 RVA: 0x0038ABAA File Offset: 0x00388DAA
		// (set) Token: 0x06018955 RID: 100693 RVA: 0x0038ABB2 File Offset: 0x00388DB2
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x06018956 RID: 100694 RVA: 0x0038ABBB File Offset: 0x00388DBB
		public ISurvivorsRougeConditionStepChooseWeaponT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
