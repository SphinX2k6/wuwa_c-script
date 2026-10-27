using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F7 RID: 27127
	public class ILifePointT
	{
		// Token: 0x1700C944 RID: 51524
		// (get) Token: 0x0602F76D RID: 194413 RVA: 0x00676EFB File Offset: 0x006750FB
		// (set) Token: 0x0602F76E RID: 194414 RVA: 0x00676F03 File Offset: 0x00675103
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700C945 RID: 51525
		// (get) Token: 0x0602F76F RID: 194415 RVA: 0x00676F0C File Offset: 0x0067510C
		// (set) Token: 0x0602F770 RID: 194416 RVA: 0x00676F14 File Offset: 0x00675114
		public ILifePointColorBoardT ColorBoard { get; set; }

		// Token: 0x1700C946 RID: 51526
		// (get) Token: 0x0602F771 RID: 194417 RVA: 0x00676F1D File Offset: 0x0067511D
		// (set) Token: 0x0602F772 RID: 194418 RVA: 0x00676F25 File Offset: 0x00675125
		public int StepLimit { get; set; }

		// Token: 0x1700C947 RID: 51527
		// (get) Token: 0x0602F773 RID: 194419 RVA: 0x00676F2E File Offset: 0x0067512E
		// (set) Token: 0x0602F774 RID: 194420 RVA: 0x00676F36 File Offset: 0x00675136
		public string TidDesc { get; set; }

		// Token: 0x1700C948 RID: 51528
		// (get) Token: 0x0602F775 RID: 194421 RVA: 0x00676F3F File Offset: 0x0067513F
		// (set) Token: 0x0602F776 RID: 194422 RVA: 0x00676F47 File Offset: 0x00675147
		public List<ILifePointMaxStepRewardRuleItemT> MaxStepRewardRule { get; set; }

		// Token: 0x1700C949 RID: 51529
		// (get) Token: 0x0602F777 RID: 194423 RVA: 0x00676F50 File Offset: 0x00675150
		// (set) Token: 0x0602F778 RID: 194424 RVA: 0x00676F58 File Offset: 0x00675158
		public bool CloseUiAfterCompletion { get; set; }

		// Token: 0x1700C94A RID: 51530
		// (get) Token: 0x0602F779 RID: 194425 RVA: 0x00676F61 File Offset: 0x00675161
		// (set) Token: 0x0602F77A RID: 194426 RVA: 0x00676F69 File Offset: 0x00675169
		public byte NullMask { get; set; }

		// Token: 0x0602F77B RID: 194427 RVA: 0x00676F72 File Offset: 0x00675172
		public ILifePointT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.ColorBoard = null;
			this.StepLimit = 0;
			this.TidDesc = null;
			this.MaxStepRewardRule = null;
			this.CloseUiAfterCompletion = false;
			this.NullMask = 0;
		}
	}
}
