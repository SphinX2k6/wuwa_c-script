using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063E9 RID: 25577
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourTaskData
	{
		// Token: 0x0604055F RID: 263519 RVA: 0x00F8FB54 File Offset: 0x00F8DD54
		public MotorParkourTaskData(int id)
		{
			MotorParkourReward? motorParkourTaskById = MotorParkourConfig.Instance.GetMotorParkourTaskById(id);
			if (motorParkourTaskById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorParkour;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "摩托跑酷任务不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.Config = motorParkourTaskById.Value;
			this.RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(this.Config.DropId).ToArray();
		}

		// Token: 0x17009427 RID: 37927
		// (get) Token: 0x06040560 RID: 263520 RVA: 0x00F8FBEB File Offset: 0x00F8DDEB
		public bool IsRunning
		{
			get
			{
				return this.Status == EActivityTaskState.Active;
			}
		}

		// Token: 0x17009428 RID: 37928
		// (get) Token: 0x06040561 RID: 263521 RVA: 0x00F8FBF6 File Offset: 0x00F8DDF6
		public bool IsFinished
		{
			get
			{
				return this.Status == EActivityTaskState.FinishedAndUnclaimed;
			}
		}

		// Token: 0x17009429 RID: 37929
		// (get) Token: 0x06040562 RID: 263522 RVA: 0x00F8FC01 File Offset: 0x00F8DE01
		public bool IsReceived
		{
			get
			{
				return this.Status == EActivityTaskState.FinishedAndClaimed;
			}
		}

		// Token: 0x1700942A RID: 37930
		// (get) Token: 0x06040563 RID: 263523 RVA: 0x00F8FC0C File Offset: 0x00F8DE0C
		// (set) Token: 0x06040564 RID: 263524 RVA: 0x00F8FC14 File Offset: 0x00F8DE14
		public int LevelId
		{
			get
			{
				return this.LevelInternal;
			}
			set
			{
				this.LevelInternal = value;
			}
		}

		// Token: 0x1700942B RID: 37931
		// (get) Token: 0x06040565 RID: 263525 RVA: 0x00F8FC1D File Offset: 0x00F8DE1D
		public int RecordId
		{
			get
			{
				return this.Config.RecordId;
			}
		}

		// Token: 0x1700942C RID: 37932
		// (get) Token: 0x06040566 RID: 263526 RVA: 0x00F8FC2A File Offset: 0x00F8DE2A
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x04021776 RID: 137078
		private MotorParkourReward Config;

		// Token: 0x04021777 RID: 137079
		public TItem[] RewardList = Array.Empty<TItem>();

		// Token: 0x04021778 RID: 137080
		private int LevelInternal;

		// Token: 0x04021779 RID: 137081
		public EActivityTaskState Status = EActivityTaskState.Active;
	}
}
