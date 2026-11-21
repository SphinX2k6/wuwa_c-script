using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x020055B5 RID: 21941
	[NullableContext(1)]
	[Nullable(0)]
	public class FeiXuePreheatTaskData
	{
		// Token: 0x06036651 RID: 222801 RVA: 0x00F2FD80 File Offset: 0x00F2DF80
		public FeiXuePreheatTaskData(FeiXuePreheatInfo taskData)
		{
			this.Data = taskData;
			this.Status = (EFeiXuePreheatTaskState)taskData.State;
			this.Current = ((taskData.State >= 2) ? 1 : 0);
			this.Config = ConfigFeiXuePreheatById.GetConfig(taskData.Id, true);
			this.RewardList = new List<TItem>(CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(this.Config.Value.DropId));
		}

		// Token: 0x06036652 RID: 222802 RVA: 0x00F2FE04 File Offset: 0x00F2E004
		public void UpdateTaskData(FeiXuePreheatInfo taskData)
		{
			this.Data = taskData;
			this.Status = (EFeiXuePreheatTaskState)taskData.State;
			this.Current = ((taskData.State >= 2) ? 1 : 0);
		}

		// Token: 0x1700696E RID: 26990
		// (get) Token: 0x06036653 RID: 222803 RVA: 0x00F2FE2B File Offset: 0x00F2E02B
		public bool IsLock
		{
			get
			{
				return this.Status == EFeiXuePreheatTaskState.Lock;
			}
		}

		// Token: 0x1700696F RID: 26991
		// (get) Token: 0x06036654 RID: 222804 RVA: 0x00F2FE36 File Offset: 0x00F2E036
		public bool IsDoing
		{
			get
			{
				return this.Status == EFeiXuePreheatTaskState.UnLock;
			}
		}

		// Token: 0x17006970 RID: 26992
		// (get) Token: 0x06036655 RID: 222805 RVA: 0x00F2FE41 File Offset: 0x00F2E041
		public bool IsUnclaimed
		{
			get
			{
				return this.Status == EFeiXuePreheatTaskState.Claimable;
			}
		}

		// Token: 0x17006971 RID: 26993
		// (get) Token: 0x06036656 RID: 222806 RVA: 0x00F2FE4C File Offset: 0x00F2E04C
		public bool IsFinished
		{
			get
			{
				return this.Status == EFeiXuePreheatTaskState.Finished;
			}
		}

		// Token: 0x17006972 RID: 26994
		// (get) Token: 0x06036657 RID: 222807 RVA: 0x00F2FE57 File Offset: 0x00F2E057
		public int Id
		{
			get
			{
				return this.Data.Id;
			}
		}

		// Token: 0x17006973 RID: 26995
		// (get) Token: 0x06036658 RID: 222808 RVA: 0x00F2FE64 File Offset: 0x00F2E064
		public string QuestName
		{
			get
			{
				return this.Config.Value.QuestName;
			}
		}

		// Token: 0x17006974 RID: 26996
		// (get) Token: 0x06036659 RID: 222809 RVA: 0x00F2FE84 File Offset: 0x00F2E084
		public long UnlockTime
		{
			get
			{
				return MathUtils.Instance.LongToBigInt(this.Data.QuestUnlockTime);
			}
		}

		// Token: 0x17006975 RID: 26997
		// (get) Token: 0x0603665A RID: 222810 RVA: 0x00F2FE9C File Offset: 0x00F2E09C
		public string QuestDesc
		{
			get
			{
				return this.Config.Value.QuestDesc;
			}
		}

		// Token: 0x0401CB2C RID: 117548
		public FeiXuePreheat? Config;

		// Token: 0x0401CB2D RID: 117549
		[Nullable(2)]
		public FeiXuePreheatInfo Data;

		// Token: 0x0401CB2E RID: 117550
		public EFeiXuePreheatTaskState Status;

		// Token: 0x0401CB2F RID: 117551
		public List<TItem> RewardList = new List<TItem>();

		// Token: 0x0401CB30 RID: 117552
		public int Current;

		// Token: 0x0401CB31 RID: 117553
		public int Target = 1;
	}
}
