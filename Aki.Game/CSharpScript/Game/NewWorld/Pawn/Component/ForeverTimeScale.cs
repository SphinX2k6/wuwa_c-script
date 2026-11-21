using System;

namespace CSharpScript.Game.NewWorld.Pawn.Component
{
	// Token: 0x020061F4 RID: 25076
	public class ForeverTimeScale
	{
		// Token: 0x0603C36C RID: 246636 RVA: 0x01126E4E File Offset: 0x0112504E
		public ForeverTimeScale(int priority, float timeDilation, ETimeScaleSourceType sourceType, ETimeScaleSourceGroup sourceTypeGroup, int id)
		{
		}

		// Token: 0x170071A6 RID: 29094
		// (get) Token: 0x0603C36D RID: 246637 RVA: 0x01126E7B File Offset: 0x0112507B
		public double EndTime
		{
			get
			{
				return -1.0;
			}
		}

		// Token: 0x0401FE20 RID: 130592
		public readonly int Priority = priority;

		// Token: 0x0401FE21 RID: 130593
		public readonly float TimeDilation = timeDilation;

		// Token: 0x0401FE22 RID: 130594
		public readonly ETimeScaleSourceType SourceType = sourceType;

		// Token: 0x0401FE23 RID: 130595
		public readonly ETimeScaleSourceGroup SourceTypeGroup = sourceTypeGroup;

		// Token: 0x0401FE24 RID: 130596
		public readonly int Id = id;

		// Token: 0x0401FE25 RID: 130597
		public bool MarkDelete;
	}
}
