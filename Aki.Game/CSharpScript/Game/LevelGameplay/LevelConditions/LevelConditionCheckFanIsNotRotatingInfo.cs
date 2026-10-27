using System;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006C3D RID: 27709
	public class LevelConditionCheckFanIsNotRotatingInfo : CodeCondition
	{
		// Token: 0x170099AB RID: 39339
		// (get) Token: 0x060444D4 RID: 279764 RVA: 0x010D3931 File Offset: 0x010D1B31
		public override ECodeCondition CodeType
		{
			get
			{
				return ECodeCondition.CheckFanIsNotRotating;
			}
		}

		// Token: 0x04023997 RID: 145815
		public int EntityId;
	}
}
