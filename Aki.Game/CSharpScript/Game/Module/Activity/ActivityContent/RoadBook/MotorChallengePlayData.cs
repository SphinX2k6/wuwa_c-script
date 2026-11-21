using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005145 RID: 20805
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorChallengePlayData
	{
		// Token: 0x17006588 RID: 25992
		// (get) Token: 0x0603406F RID: 213103 RVA: 0x00E8E070 File Offset: 0x00E8C270
		public bool HasRedDot
		{
			get
			{
				return this.CheckRedDot(this.RewardIds.ToArray());
			}
		}

		// Token: 0x17006589 RID: 25993
		// (get) Token: 0x06034070 RID: 213104 RVA: 0x00E8E088 File Offset: 0x00E8C288
		public bool IsFinished
		{
			get
			{
				return this.CheckFinished(this.RewardIds.ToArray());
			}
		}

		// Token: 0x0401B85E RID: 112734
		public int TabIndex;

		// Token: 0x0401B85F RID: 112735
		public int PlayId;

		// Token: 0x0401B860 RID: 112736
		public int JumpId;

		// Token: 0x0401B861 RID: 112737
		public string NameTextId = "";

		// Token: 0x0401B862 RID: 112738
		public List<int> RewardIds = new List<int>();

		// Token: 0x0401B863 RID: 112739
		public bool IsUnlock;

		// Token: 0x0401B864 RID: 112740
		public bool IsNew;

		// Token: 0x0401B865 RID: 112741
		public int HighestPoint;

		// Token: 0x0401B866 RID: 112742
		public int ClassId;

		// Token: 0x0401B867 RID: 112743
		public Func<int[], bool> CheckRedDot;

		// Token: 0x0401B868 RID: 112744
		public Func<int[], bool> CheckFinished;
	}
}
