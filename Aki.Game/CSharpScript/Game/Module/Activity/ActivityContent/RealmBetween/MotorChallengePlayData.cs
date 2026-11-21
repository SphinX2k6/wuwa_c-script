using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051E8 RID: 20968
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorChallengePlayData
	{
		// Token: 0x170065CB RID: 26059
		// (get) Token: 0x060343E7 RID: 213991 RVA: 0x00E9D795 File Offset: 0x00E9B995
		public bool HasRedDot
		{
			get
			{
				return this.CheckRedDot(this.RewardIds.ToArray());
			}
		}

		// Token: 0x170065CC RID: 26060
		// (get) Token: 0x060343E8 RID: 213992 RVA: 0x00E9D7AD File Offset: 0x00E9B9AD
		public bool IsFinished
		{
			get
			{
				return this.CheckFinished(this.RewardIds.ToArray());
			}
		}

		// Token: 0x0401BB6C RID: 113516
		public int TabIndex;

		// Token: 0x0401BB6D RID: 113517
		public int PlayId;

		// Token: 0x0401BB6E RID: 113518
		public int JumpId;

		// Token: 0x0401BB6F RID: 113519
		public string NameTextId = "";

		// Token: 0x0401BB70 RID: 113520
		public List<int> RewardIds = new List<int>();

		// Token: 0x0401BB71 RID: 113521
		public bool IsUnlock;

		// Token: 0x0401BB72 RID: 113522
		public bool IsNew;

		// Token: 0x0401BB73 RID: 113523
		public int HighestPoint;

		// Token: 0x0401BB74 RID: 113524
		public int ClassId;

		// Token: 0x0401BB75 RID: 113525
		public Func<int[], bool> CheckRedDot;

		// Token: 0x0401BB76 RID: 113526
		public Func<int[], bool> CheckFinished;
	}
}
