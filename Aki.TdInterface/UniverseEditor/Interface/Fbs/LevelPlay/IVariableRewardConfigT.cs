using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045E8 RID: 17896
	public class IVariableRewardConfigT
	{
		// Token: 0x17007F3E RID: 32574
		// (get) Token: 0x0601B1A3 RID: 111011 RVA: 0x003DCDCB File Offset: 0x003DAFCB
		// (set) Token: 0x0601B1A4 RID: 111012 RVA: 0x003DCDD3 File Offset: 0x003DAFD3
		public TVarRefUnion Var1 { get; set; }

		// Token: 0x17007F3F RID: 32575
		// (get) Token: 0x0601B1A5 RID: 111013 RVA: 0x003DCDDC File Offset: 0x003DAFDC
		// (set) Token: 0x0601B1A6 RID: 111014 RVA: 0x003DCDE4 File Offset: 0x003DAFE4
		public ECompare Compare { get; set; }

		// Token: 0x17007F40 RID: 32576
		// (get) Token: 0x0601B1A7 RID: 111015 RVA: 0x003DCDED File Offset: 0x003DAFED
		// (set) Token: 0x0601B1A8 RID: 111016 RVA: 0x003DCDF5 File Offset: 0x003DAFF5
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x17007F41 RID: 32577
		// (get) Token: 0x0601B1A9 RID: 111017 RVA: 0x003DCDFE File Offset: 0x003DAFFE
		// (set) Token: 0x0601B1AA RID: 111018 RVA: 0x003DCE06 File Offset: 0x003DB006
		public int RewardId { get; set; }

		// Token: 0x0601B1AB RID: 111019 RVA: 0x003DCE0F File Offset: 0x003DB00F
		public IVariableRewardConfigT()
		{
			this.Var1 = null;
			this.Compare = ECompare.Eq;
			this.Var2 = null;
			this.RewardId = 0;
		}
	}
}
