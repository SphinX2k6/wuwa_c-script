using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock
{
	// Token: 0x02006AA5 RID: 27301
	[NullableContext(1)]
	[Nullable(0)]
	public class RollBlockGameplayInfo
	{
		// Token: 0x06043D27 RID: 277799 RVA: 0x0109A8B8 File Offset: 0x01098AB8
		public RollBlockGameplayInfo(RollBlockGamePlayPbInfo info)
		{
			this.GroupId = info.GroupId;
			this.Difficulty = info.Difficulty;
			this.TotalDifficulty = info.TotalDifficultyCount;
			this.IsMainController = info.IsMainControl;
			this.EntityIds = new List<long>();
			if (info.InitInvisibleEntityIds != null)
			{
				foreach (long item in info.InitInvisibleEntityIds)
				{
					this.EntityIds.Add(item);
				}
			}
			if (info.InitVisibleEntityIds != null)
			{
				foreach (long item2 in info.InitVisibleEntityIds)
				{
					this.InitVisibleEntityIds.Add(item2);
				}
			}
			this.Width = info.GridSizeX;
			this.Height = info.GridSizeY;
			this.ShowTipsInputCount = info.ShowHintErrorInputCount;
			this.CameraTag = new int?(info.SubCameraTag);
			foreach (RbInput rbInput in info.AvailableInputs)
			{
				RbRollInput roll = rbInput.Roll;
				bool flag;
				if (roll == null)
				{
					flag = false;
				}
				else
				{
					RbGridDirection direction = roll.Direction;
					flag = true;
				}
				if (flag)
				{
					this.AvailableInputs.Add(rbInput.Roll.Direction);
				}
			}
			if (info.Rotation != null)
			{
				this.TmpRot = global::Rotator.Create(info.Rotation.Y, info.Rotation.Z, info.Rotation.X);
				FRotator frotator = this.TmpRot.ToUeRotator();
				this.Forward = global::Vector.Create(new FQuat(ref frotator).GetRightVector());
				this.Forward.Normalize(9.99999993922529E-09);
				this.Forward.MultiplyEqual(-1.0);
				frotator = this.TmpRot.ToUeRotator();
				this.Right = global::Vector.Create(new FQuat(ref frotator).GetForwardVector());
				this.Right.Normalize(9.99999993922529E-09);
				Aki.Protocol.Vector position = info.Position;
				double x = (double)((position != null) ? position.X : 0f);
				Aki.Protocol.Vector position2 = info.Position;
				double y = (double)((position2 != null) ? position2.Y : 0f);
				Aki.Protocol.Vector position3 = info.Position;
				this.TmpVec = global::Vector.Create(x, y, (double)((position3 != null) ? position3.Z : 0f));
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RollBlock;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[RollBlockGameplayInfo] 玩法中心位置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Loc", this.TmpVec);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x040236F7 RID: 145143
		public int GroupId;

		// Token: 0x040236F8 RID: 145144
		public int Difficulty;

		// Token: 0x040236F9 RID: 145145
		public int TotalDifficulty;

		// Token: 0x040236FA RID: 145146
		public bool IsMainController;

		// Token: 0x040236FB RID: 145147
		public List<long> EntityIds = new List<long>();

		// Token: 0x040236FC RID: 145148
		public List<long> InitVisibleEntityIds = new List<long>();

		// Token: 0x040236FD RID: 145149
		public global::Vector Forward;

		// Token: 0x040236FE RID: 145150
		public global::Vector Right;

		// Token: 0x040236FF RID: 145151
		public List<RbBaseComponent> RollBlockEntities = new List<RbBaseComponent>();

		// Token: 0x04023700 RID: 145152
		public global::Vector TmpVec;

		// Token: 0x04023701 RID: 145153
		public global::Rotator TmpRot;

		// Token: 0x04023702 RID: 145154
		public int HasTipActorNum;

		// Token: 0x04023703 RID: 145155
		public int Width;

		// Token: 0x04023704 RID: 145156
		public int Height;

		// Token: 0x04023705 RID: 145157
		public List<RbGridDirection> AvailableInputs = new List<RbGridDirection>();

		// Token: 0x04023706 RID: 145158
		public Dictionary<string, List<RbBaseComponent>> IndexedEntityMap = new Dictionary<string, List<RbBaseComponent>>();

		// Token: 0x04023707 RID: 145159
		public int ShowTipsInputCount;

		// Token: 0x04023708 RID: 145160
		public bool ShowedTips;

		// Token: 0x04023709 RID: 145161
		public bool MultiBlock;

		// Token: 0x0402370A RID: 145162
		public int? CameraTag;

		// Token: 0x0402370B RID: 145163
		public ERollBlockInitState InitState;
	}
}
