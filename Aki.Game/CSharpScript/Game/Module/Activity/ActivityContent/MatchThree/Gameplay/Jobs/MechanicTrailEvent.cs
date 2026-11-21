using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005491 RID: 21649
	public struct MechanicTrailEvent
	{
		// Token: 0x06035B69 RID: 220009 RVA: 0x00F0275B File Offset: 0x00F0095B
		public MechanicTrailEvent(int envId, GridPosition target, EPieceType mechanicType)
		{
			this.EnvId = envId;
			this.Target = target;
			this.MechanicType = mechanicType;
		}

		// Token: 0x0401C6E2 RID: 116450
		public int EnvId;

		// Token: 0x0401C6E3 RID: 116451
		public GridPosition Target;

		// Token: 0x0401C6E4 RID: 116452
		public EPieceType MechanicType;
	}
}
