using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200742B RID: 29739
	public class ITraceTracingT
	{
		// Token: 0x1700E1CD RID: 57805
		// (get) Token: 0x06036066 RID: 221286 RVA: 0x007594E2 File Offset: 0x007576E2
		// (set) Token: 0x06036067 RID: 221287 RVA: 0x007594EA File Offset: 0x007576EA
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700E1CE RID: 57806
		// (get) Token: 0x06036068 RID: 221288 RVA: 0x007594F3 File Offset: 0x007576F3
		// (set) Token: 0x06036069 RID: 221289 RVA: 0x007594FB File Offset: 0x007576FB
		public ETraceTracingImageType ImageResourceType { get; set; }

		// Token: 0x1700E1CF RID: 57807
		// (get) Token: 0x0603606A RID: 221290 RVA: 0x00759504 File Offset: 0x00757704
		// (set) Token: 0x0603606B RID: 221291 RVA: 0x0075950C File Offset: 0x0075770C
		public ITraceTracingGridBoardT BoardConfig { get; set; }

		// Token: 0x1700E1D0 RID: 57808
		// (get) Token: 0x0603606C RID: 221292 RVA: 0x00759515 File Offset: 0x00757715
		// (set) Token: 0x0603606D RID: 221293 RVA: 0x0075951D File Offset: 0x0075771D
		public int StepLimit { get; set; }

		// Token: 0x1700E1D1 RID: 57809
		// (get) Token: 0x0603606E RID: 221294 RVA: 0x00759526 File Offset: 0x00757726
		// (set) Token: 0x0603606F RID: 221295 RVA: 0x0075952E File Offset: 0x0075772E
		public List<ITraceTracingMaxStepRewardRuleItemT> MaxStepRewardRule { get; set; }

		// Token: 0x1700E1D2 RID: 57810
		// (get) Token: 0x06036070 RID: 221296 RVA: 0x00759537 File Offset: 0x00757737
		// (set) Token: 0x06036071 RID: 221297 RVA: 0x0075953F File Offset: 0x0075773F
		public bool RemainUiAfterCompletion { get; set; }

		// Token: 0x1700E1D3 RID: 57811
		// (get) Token: 0x06036072 RID: 221298 RVA: 0x00759548 File Offset: 0x00757748
		// (set) Token: 0x06036073 RID: 221299 RVA: 0x00759550 File Offset: 0x00757750
		public byte NullMask { get; set; }

		// Token: 0x06036074 RID: 221300 RVA: 0x00759559 File Offset: 0x00757759
		public ITraceTracingT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.ImageResourceType = ETraceTracingImageType.None;
			this.BoardConfig = null;
			this.StepLimit = 0;
			this.MaxStepRewardRule = null;
			this.RemainUiAfterCompletion = false;
			this.NullMask = 0;
		}
	}
}
