using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005724 RID: 22308
	public class DangoBrawlTaskData
	{
		// Token: 0x06036E8F RID: 224911 RVA: 0x00F4EFBD File Offset: 0x00F4D1BD
		public DangoBrawlTaskData(int configId)
		{
			this.ConfigId = configId;
		}

		// Token: 0x06036E90 RID: 224912 RVA: 0x00F4EFDA File Offset: 0x00F4D1DA
		private DangoBrawlReward? GetConfig()
		{
			return DangoBrawlConfig.Instance.GetRewardConfigById(this.ConfigId);
		}

		// Token: 0x06036E91 RID: 224913 RVA: 0x00F4EFEC File Offset: 0x00F4D1EC
		[NullableContext(1)]
		public void UpdateData(ConditionTask data)
		{
			EActivityTaskState statusInternal;
			if (TaskStateResolver.ConditionState.TryGetValue(data.Status, out statusInternal))
			{
				this.StatusInternal = statusInternal;
			}
			this.Current = data.Current;
			this.Target = data.Target;
		}

		// Token: 0x06036E92 RID: 224914 RVA: 0x00F4F02C File Offset: 0x00F4D22C
		public void UpdateState(EActivityTaskState state)
		{
			this.StatusInternal = state;
		}

		// Token: 0x17006A33 RID: 27187
		// (get) Token: 0x06036E93 RID: 224915 RVA: 0x00F4F038 File Offset: 0x00F4D238
		public int Id
		{
			get
			{
				if (this.GetConfig() == null)
				{
					return 0;
				}
				DangoBrawlReward? dangoBrawlReward;
				return dangoBrawlReward.GetValueOrDefault().Id;
			}
		}

		// Token: 0x17006A34 RID: 27188
		// (get) Token: 0x06036E94 RID: 224916 RVA: 0x00F4F068 File Offset: 0x00F4D268
		public int ActivityId
		{
			get
			{
				if (this.GetConfig() == null)
				{
					return 0;
				}
				DangoBrawlReward? dangoBrawlReward;
				return dangoBrawlReward.GetValueOrDefault().ActivityId;
			}
		}

		// Token: 0x17006A35 RID: 27189
		// (get) Token: 0x06036E95 RID: 224917 RVA: 0x00F4F098 File Offset: 0x00F4D298
		public int TabId
		{
			get
			{
				if (this.GetConfig() == null)
				{
					return 0;
				}
				DangoBrawlReward? dangoBrawlReward;
				return dangoBrawlReward.GetValueOrDefault().TabId;
			}
		}

		// Token: 0x17006A36 RID: 27190
		// (get) Token: 0x06036E96 RID: 224918 RVA: 0x00F4F0C8 File Offset: 0x00F4D2C8
		public int ConditionGroup
		{
			get
			{
				if (this.GetConfig() == null)
				{
					return 0;
				}
				DangoBrawlReward? dangoBrawlReward;
				return dangoBrawlReward.GetValueOrDefault().ConditionGroup;
			}
		}

		// Token: 0x17006A37 RID: 27191
		// (get) Token: 0x06036E97 RID: 224919 RVA: 0x00F4F0F8 File Offset: 0x00F4D2F8
		public int DropId
		{
			get
			{
				if (this.GetConfig() == null)
				{
					return 0;
				}
				DangoBrawlReward? dangoBrawlReward;
				return dangoBrawlReward.GetValueOrDefault().DropId;
			}
		}

		// Token: 0x17006A38 RID: 27192
		// (get) Token: 0x06036E98 RID: 224920 RVA: 0x00F4F126 File Offset: 0x00F4D326
		public EActivityTaskState Status
		{
			get
			{
				return this.StatusInternal;
			}
		}

		// Token: 0x0401D141 RID: 119105
		public int ConfigId;

		// Token: 0x0401D142 RID: 119106
		private EActivityTaskState StatusInternal = EActivityTaskState.Active;

		// Token: 0x0401D143 RID: 119107
		public int Current;

		// Token: 0x0401D144 RID: 119108
		public int Target = 1;
	}
}
