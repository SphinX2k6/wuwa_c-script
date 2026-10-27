using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006513 RID: 25875
	public struct MechanicTrailEvent
	{
		// Token: 0x06040EA5 RID: 265893 RVA: 0x00FBB72B File Offset: 0x00FB992B
		public MechanicTrailEvent(int envId, GridPosition target, EPieceType mechanicType)
		{
			this.EnvId = envId;
			this.Target = target;
			this.MechanicType = mechanicType;
		}

		// Token: 0x04021DB1 RID: 138673
		public int EnvId;

		// Token: 0x04021DB2 RID: 138674
		public GridPosition Target;

		// Token: 0x04021DB3 RID: 138675
		public EPieceType MechanicType;
	}
}
