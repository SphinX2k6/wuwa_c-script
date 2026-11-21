using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x02005367 RID: 21351
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourTaskData
	{
		// Token: 0x06035220 RID: 217632 RVA: 0x00ED6AEC File Offset: 0x00ED4CEC
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

		// Token: 0x17006789 RID: 26505
		// (get) Token: 0x06035221 RID: 217633 RVA: 0x00ED6B83 File Offset: 0x00ED4D83
		public bool IsRunning
		{
			get
			{
				return this.Status == EActivityTaskState.Active;
			}
		}

		// Token: 0x1700678A RID: 26506
		// (get) Token: 0x06035222 RID: 217634 RVA: 0x00ED6B8E File Offset: 0x00ED4D8E
		public bool IsFinished
		{
			get
			{
				return this.Status == EActivityTaskState.FinishedAndUnclaimed;
			}
		}

		// Token: 0x1700678B RID: 26507
		// (get) Token: 0x06035223 RID: 217635 RVA: 0x00ED6B99 File Offset: 0x00ED4D99
		public bool IsReceived
		{
			get
			{
				return this.Status == EActivityTaskState.FinishedAndClaimed;
			}
		}

		// Token: 0x1700678C RID: 26508
		// (get) Token: 0x06035224 RID: 217636 RVA: 0x00ED6BA4 File Offset: 0x00ED4DA4
		// (set) Token: 0x06035225 RID: 217637 RVA: 0x00ED6BAC File Offset: 0x00ED4DAC
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

		// Token: 0x1700678D RID: 26509
		// (get) Token: 0x06035226 RID: 217638 RVA: 0x00ED6BB5 File Offset: 0x00ED4DB5
		public int RecordId
		{
			get
			{
				return this.Config.RecordId;
			}
		}

		// Token: 0x1700678E RID: 26510
		// (get) Token: 0x06035227 RID: 217639 RVA: 0x00ED6BC2 File Offset: 0x00ED4DC2
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x0401C0A5 RID: 114853
		private MotorParkourReward Config;

		// Token: 0x0401C0A6 RID: 114854
		public TItem[] RewardList = Array.Empty<TItem>();

		// Token: 0x0401C0A7 RID: 114855
		private int LevelInternal;

		// Token: 0x0401C0A8 RID: 114856
		public EActivityTaskState Status = EActivityTaskState.Active;
	}
}
