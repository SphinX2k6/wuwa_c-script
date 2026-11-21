using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A7 RID: 28839
	public class ILifePointT
	{
		// Token: 0x1700D344 RID: 54084
		// (get) Token: 0x0603212D RID: 205101 RVA: 0x006C7253 File Offset: 0x006C5453
		// (set) Token: 0x0603212E RID: 205102 RVA: 0x006C725B File Offset: 0x006C545B
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D345 RID: 54085
		// (get) Token: 0x0603212F RID: 205103 RVA: 0x006C7264 File Offset: 0x006C5464
		// (set) Token: 0x06032130 RID: 205104 RVA: 0x006C726C File Offset: 0x006C546C
		public ILifePointColorBoardT ColorBoard { get; set; }

		// Token: 0x1700D346 RID: 54086
		// (get) Token: 0x06032131 RID: 205105 RVA: 0x006C7275 File Offset: 0x006C5475
		// (set) Token: 0x06032132 RID: 205106 RVA: 0x006C727D File Offset: 0x006C547D
		public int StepLimit { get; set; }

		// Token: 0x1700D347 RID: 54087
		// (get) Token: 0x06032133 RID: 205107 RVA: 0x006C7286 File Offset: 0x006C5486
		// (set) Token: 0x06032134 RID: 205108 RVA: 0x006C728E File Offset: 0x006C548E
		public string TidDesc { get; set; }

		// Token: 0x1700D348 RID: 54088
		// (get) Token: 0x06032135 RID: 205109 RVA: 0x006C7297 File Offset: 0x006C5497
		// (set) Token: 0x06032136 RID: 205110 RVA: 0x006C729F File Offset: 0x006C549F
		public List<ILifePointMaxStepRewardRuleItemT> MaxStepRewardRule { get; set; }

		// Token: 0x1700D349 RID: 54089
		// (get) Token: 0x06032137 RID: 205111 RVA: 0x006C72A8 File Offset: 0x006C54A8
		// (set) Token: 0x06032138 RID: 205112 RVA: 0x006C72B0 File Offset: 0x006C54B0
		public bool CloseUiAfterCompletion { get; set; }

		// Token: 0x1700D34A RID: 54090
		// (get) Token: 0x06032139 RID: 205113 RVA: 0x006C72B9 File Offset: 0x006C54B9
		// (set) Token: 0x0603213A RID: 205114 RVA: 0x006C72C1 File Offset: 0x006C54C1
		public byte NullMask { get; set; }

		// Token: 0x0603213B RID: 205115 RVA: 0x006C72CA File Offset: 0x006C54CA
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
