using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200626A RID: 25194
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorChallengePlayData
	{
		// Token: 0x17009269 RID: 37481
		// (get) Token: 0x0603F726 RID: 259878 RVA: 0x00F56839 File Offset: 0x00F54A39
		public bool HasRedDot
		{
			get
			{
				return this.CheckRedDot(this.RewardIds.ToArray());
			}
		}

		// Token: 0x1700926A RID: 37482
		// (get) Token: 0x0603F727 RID: 259879 RVA: 0x00F56851 File Offset: 0x00F54A51
		public bool IsFinished
		{
			get
			{
				return this.CheckFinished(this.RewardIds.ToArray());
			}
		}

		// Token: 0x0402123D RID: 135741
		public int TabIndex;

		// Token: 0x0402123E RID: 135742
		public int PlayId;

		// Token: 0x0402123F RID: 135743
		public int JumpId;

		// Token: 0x04021240 RID: 135744
		public string NameTextId = "";

		// Token: 0x04021241 RID: 135745
		public List<int> RewardIds = new List<int>();

		// Token: 0x04021242 RID: 135746
		public bool IsUnlock;

		// Token: 0x04021243 RID: 135747
		public bool IsNew;

		// Token: 0x04021244 RID: 135748
		public int HighestPoint;

		// Token: 0x04021245 RID: 135749
		public int ClassId;

		// Token: 0x04021246 RID: 135750
		public Func<int[], bool> CheckRedDot;

		// Token: 0x04021247 RID: 135751
		public Func<int[], bool> CheckFinished;
	}
}
