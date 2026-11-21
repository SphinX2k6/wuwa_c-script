using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.RollBlock
{
	// Token: 0x02005C02 RID: 23554
	[NullableContext(1)]
	[Nullable(0)]
	public class RollBlockGameplayInfo
	{
		// Token: 0x06039D7C RID: 236924 RVA: 0x0103EFE0 File Offset: 0x0103D1E0
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

		// Token: 0x0401E8E9 RID: 125161
		public int GroupId;

		// Token: 0x0401E8EA RID: 125162
		public int Difficulty;

		// Token: 0x0401E8EB RID: 125163
		public int TotalDifficulty;

		// Token: 0x0401E8EC RID: 125164
		public bool IsMainController;

		// Token: 0x0401E8ED RID: 125165
		public List<long> EntityIds = new List<long>();

		// Token: 0x0401E8EE RID: 125166
		public List<long> InitVisibleEntityIds = new List<long>();

		// Token: 0x0401E8EF RID: 125167
		public global::Vector Forward;

		// Token: 0x0401E8F0 RID: 125168
		public global::Vector Right;

		// Token: 0x0401E8F1 RID: 125169
		public List<RbBaseComponent> RollBlockEntities = new List<RbBaseComponent>();

		// Token: 0x0401E8F2 RID: 125170
		public global::Vector TmpVec;

		// Token: 0x0401E8F3 RID: 125171
		public global::Rotator TmpRot;

		// Token: 0x0401E8F4 RID: 125172
		public int HasTipActorNum;

		// Token: 0x0401E8F5 RID: 125173
		public int Width;

		// Token: 0x0401E8F6 RID: 125174
		public int Height;

		// Token: 0x0401E8F7 RID: 125175
		public List<RbGridDirection> AvailableInputs = new List<RbGridDirection>();

		// Token: 0x0401E8F8 RID: 125176
		public Dictionary<string, List<RbBaseComponent>> IndexedEntityMap = new Dictionary<string, List<RbBaseComponent>>();

		// Token: 0x0401E8F9 RID: 125177
		public int ShowTipsInputCount;

		// Token: 0x0401E8FA RID: 125178
		public bool ShowedTips;

		// Token: 0x0401E8FB RID: 125179
		public bool MultiBlock;

		// Token: 0x0401E8FC RID: 125180
		public int? CameraTag;

		// Token: 0x0401E8FD RID: 125181
		public ERollBlockInitState InitState;
	}
}
