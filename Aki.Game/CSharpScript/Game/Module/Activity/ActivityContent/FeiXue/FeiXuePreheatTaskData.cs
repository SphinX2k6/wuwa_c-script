using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x02006637 RID: 26167
	[NullableContext(1)]
	[Nullable(0)]
	public class FeiXuePreheatTaskData
	{
		// Token: 0x0604198C RID: 268684 RVA: 0x00FE8CC8 File Offset: 0x00FE6EC8
		public FeiXuePreheatTaskData(FeiXuePreheatInfo taskData)
		{
			this.Data = taskData;
			this.Status = (EFeiXuePreheatTaskState)taskData.State;
			this.Current = ((taskData.State >= 2) ? 1 : 0);
			this.Config = ConfigFeiXuePreheatById.GetConfig(taskData.Id, true);
			this.RewardList = new List<TItem>(CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(this.Config.Value.DropId));
		}

		// Token: 0x0604198D RID: 268685 RVA: 0x00FE8D4C File Offset: 0x00FE6F4C
		public void UpdateTaskData(FeiXuePreheatInfo taskData)
		{
			this.Data = taskData;
			this.Status = (EFeiXuePreheatTaskState)taskData.State;
			this.Current = ((taskData.State >= 2) ? 1 : 0);
		}

		// Token: 0x1700960C RID: 38412
		// (get) Token: 0x0604198E RID: 268686 RVA: 0x00FE8D73 File Offset: 0x00FE6F73
		public bool IsLock
		{
			get
			{
				return this.Status == EFeiXuePreheatTaskState.Lock;
			}
		}

		// Token: 0x1700960D RID: 38413
		// (get) Token: 0x0604198F RID: 268687 RVA: 0x00FE8D7E File Offset: 0x00FE6F7E
		public bool IsDoing
		{
			get
			{
				return this.Status == EFeiXuePreheatTaskState.UnLock;
			}
		}

		// Token: 0x1700960E RID: 38414
		// (get) Token: 0x06041990 RID: 268688 RVA: 0x00FE8D89 File Offset: 0x00FE6F89
		public bool IsUnclaimed
		{
			get
			{
				return this.Status == EFeiXuePreheatTaskState.Claimable;
			}
		}

		// Token: 0x1700960F RID: 38415
		// (get) Token: 0x06041991 RID: 268689 RVA: 0x00FE8D94 File Offset: 0x00FE6F94
		public bool IsFinished
		{
			get
			{
				return this.Status == EFeiXuePreheatTaskState.Finished;
			}
		}

		// Token: 0x17009610 RID: 38416
		// (get) Token: 0x06041992 RID: 268690 RVA: 0x00FE8D9F File Offset: 0x00FE6F9F
		public int Id
		{
			get
			{
				return this.Data.Id;
			}
		}

		// Token: 0x17009611 RID: 38417
		// (get) Token: 0x06041993 RID: 268691 RVA: 0x00FE8DAC File Offset: 0x00FE6FAC
		public string QuestName
		{
			get
			{
				return this.Config.Value.QuestName;
			}
		}

		// Token: 0x17009612 RID: 38418
		// (get) Token: 0x06041994 RID: 268692 RVA: 0x00FE8DCC File Offset: 0x00FE6FCC
		public long UnlockTime
		{
			get
			{
				return MathUtils.Instance.LongToBigInt(this.Data.QuestUnlockTime);
			}
		}

		// Token: 0x17009613 RID: 38419
		// (get) Token: 0x06041995 RID: 268693 RVA: 0x00FE8DE4 File Offset: 0x00FE6FE4
		public string QuestDesc
		{
			get
			{
				return this.Config.Value.QuestDesc;
			}
		}

		// Token: 0x040221FB RID: 139771
		public FeiXuePreheat? Config;

		// Token: 0x040221FC RID: 139772
		[Nullable(2)]
		public FeiXuePreheatInfo Data;

		// Token: 0x040221FD RID: 139773
		public EFeiXuePreheatTaskState Status;

		// Token: 0x040221FE RID: 139774
		public List<TItem> RewardList = new List<TItem>();

		// Token: 0x040221FF RID: 139775
		public int Current;

		// Token: 0x04022200 RID: 139776
		public int Target = 1;
	}
}
