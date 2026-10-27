using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061C7 RID: 25031
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorChallengePlayData
	{
		// Token: 0x17009226 RID: 37414
		// (get) Token: 0x0603F3AE RID: 258990 RVA: 0x00F47118 File Offset: 0x00F45318
		public bool HasRedDot
		{
			get
			{
				return this.CheckRedDot(this.RewardIds.ToArray());
			}
		}

		// Token: 0x17009227 RID: 37415
		// (get) Token: 0x0603F3AF RID: 258991 RVA: 0x00F47130 File Offset: 0x00F45330
		public bool IsFinished
		{
			get
			{
				return this.CheckFinished(this.RewardIds.ToArray());
			}
		}

		// Token: 0x04020F2F RID: 134959
		public int TabIndex;

		// Token: 0x04020F30 RID: 134960
		public int PlayId;

		// Token: 0x04020F31 RID: 134961
		public int JumpId;

		// Token: 0x04020F32 RID: 134962
		public string NameTextId = "";

		// Token: 0x04020F33 RID: 134963
		public List<int> RewardIds = new List<int>();

		// Token: 0x04020F34 RID: 134964
		public bool IsUnlock;

		// Token: 0x04020F35 RID: 134965
		public bool IsNew;

		// Token: 0x04020F36 RID: 134966
		public int HighestPoint;

		// Token: 0x04020F37 RID: 134967
		public int ClassId;

		// Token: 0x04020F38 RID: 134968
		public Func<int[], bool> CheckRedDot;

		// Token: 0x04020F39 RID: 134969
		public Func<int[], bool> CheckFinished;
	}
}
