using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070AD RID: 28845
	public class ILifePointMaxStepRewardRuleItemT
	{
		// Token: 0x1700D355 RID: 54101
		// (get) Token: 0x06032171 RID: 205169 RVA: 0x006C7A50 File Offset: 0x006C5C50
		// (set) Token: 0x06032172 RID: 205170 RVA: 0x006C7A58 File Offset: 0x006C5C58
		public int PaintCount { get; set; }

		// Token: 0x1700D356 RID: 54102
		// (get) Token: 0x06032173 RID: 205171 RVA: 0x006C7A61 File Offset: 0x006C5C61
		// (set) Token: 0x06032174 RID: 205172 RVA: 0x006C7A69 File Offset: 0x006C5C69
		public int AddStep { get; set; }

		// Token: 0x06032175 RID: 205173 RVA: 0x006C7A72 File Offset: 0x006C5C72
		public ILifePointMaxStepRewardRuleItemT()
		{
			this.PaintCount = 0;
			this.AddStep = 0;
		}
	}
}
