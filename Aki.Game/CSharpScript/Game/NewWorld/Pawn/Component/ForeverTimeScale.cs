using System;

namespace CSharpScript.Game.NewWorld.Pawn.Component
{
	// Token: 0x02007073 RID: 28787
	public class ForeverTimeScale
	{
		// Token: 0x06046165 RID: 287077 RVA: 0x0117D55E File Offset: 0x0117B75E
		public ForeverTimeScale(int priority, float timeDilation, ETimeScaleSourceType sourceType, ETimeScaleSourceGroup sourceTypeGroup, int id)
		{
		}

		// Token: 0x17009C14 RID: 39956
		// (get) Token: 0x06046166 RID: 287078 RVA: 0x0117D58B File Offset: 0x0117B78B
		public double EndTime
		{
			get
			{
				return -1.0;
			}
		}

		// Token: 0x04024B65 RID: 150373
		public readonly int Priority = priority;

		// Token: 0x04024B66 RID: 150374
		public readonly float TimeDilation = timeDilation;

		// Token: 0x04024B67 RID: 150375
		public readonly ETimeScaleSourceType SourceType = sourceType;

		// Token: 0x04024B68 RID: 150376
		public readonly ETimeScaleSourceGroup SourceTypeGroup = sourceTypeGroup;

		// Token: 0x04024B69 RID: 150377
		public readonly int Id = id;

		// Token: 0x04024B6A RID: 150378
		public bool MarkDelete;
	}
}
