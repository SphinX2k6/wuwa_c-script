using System;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005DB9 RID: 23993
	public class LevelConditionCheckGravityFlipEntityDirectionSameAsPlayerInfo : CodeCondition
	{
		// Token: 0x17006EB1 RID: 28337
		// (get) Token: 0x0603A632 RID: 239154 RVA: 0x0107D802 File Offset: 0x0107BA02
		public override ECodeCondition CodeType
		{
			get
			{
				return ECodeCondition.CheckGravityFlipEntityDirectionSameAsPlayer;
			}
		}

		// Token: 0x0401EC3E RID: 126014
		public int EntityId;
	}
}
