using System;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DB6 RID: 23990
	public class LevelConditionCheckFanIsNotRotatingInfo : CodeCondition
	{
		// Token: 0x17006EAE RID: 28334
		// (get) Token: 0x0603A62C RID: 239148 RVA: 0x0107D7E1 File Offset: 0x0107B9E1
		public override ECodeCondition CodeType
		{
			get
			{
				return ECodeCondition.CheckFanIsNotRotating;
			}
		}

		// Token: 0x0401EC39 RID: 126009
		public int EntityId;
	}
}
