using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004164 RID: 16740
	public class ISurvivorsRougeConditionStepEndT
	{
		// Token: 0x17007697 RID: 30359
		// (get) Token: 0x06018966 RID: 100710 RVA: 0x0038AD22 File Offset: 0x00388F22
		// (set) Token: 0x06018967 RID: 100711 RVA: 0x0038AD2A File Offset: 0x00388F2A
		public ESurvivorsRougeConditionStep Type { get; set; }

		// Token: 0x06018968 RID: 100712 RVA: 0x0038AD33 File Offset: 0x00388F33
		public ISurvivorsRougeConditionStepEndT()
		{
			this.Type = ESurvivorsRougeConditionStep.Prepare;
		}
	}
}
