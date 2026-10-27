using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067D4 RID: 26580
	public class DangoBrawlTaskData
	{
		// Token: 0x06042339 RID: 271161 RVA: 0x0100DAED File Offset: 0x0100BCED
		public DangoBrawlTaskData(int configId)
		{
			this.ConfigId = configId;
		}

		// Token: 0x0604233A RID: 271162 RVA: 0x0100DB0A File Offset: 0x0100BD0A
		private DangoBrawlReward? GetConfig()
		{
			return DangoBrawlConfig.Instance.GetRewardConfigById(this.ConfigId);
		}

		// Token: 0x0604233B RID: 271163 RVA: 0x0100DB1C File Offset: 0x0100BD1C
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

		// Token: 0x0604233C RID: 271164 RVA: 0x0100DB5C File Offset: 0x0100BD5C
		public void UpdateState(EActivityTaskState state)
		{
			this.StatusInternal = state;
		}

		// Token: 0x170096F2 RID: 38642
		// (get) Token: 0x0604233D RID: 271165 RVA: 0x0100DB68 File Offset: 0x0100BD68
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

		// Token: 0x170096F3 RID: 38643
		// (get) Token: 0x0604233E RID: 271166 RVA: 0x0100DB98 File Offset: 0x0100BD98
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

		// Token: 0x170096F4 RID: 38644
		// (get) Token: 0x0604233F RID: 271167 RVA: 0x0100DBC8 File Offset: 0x0100BDC8
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

		// Token: 0x170096F5 RID: 38645
		// (get) Token: 0x06042340 RID: 271168 RVA: 0x0100DBF8 File Offset: 0x0100BDF8
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

		// Token: 0x170096F6 RID: 38646
		// (get) Token: 0x06042341 RID: 271169 RVA: 0x0100DC28 File Offset: 0x0100BE28
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

		// Token: 0x170096F7 RID: 38647
		// (get) Token: 0x06042342 RID: 271170 RVA: 0x0100DC56 File Offset: 0x0100BE56
		public EActivityTaskState Status
		{
			get
			{
				return this.StatusInternal;
			}
		}

		// Token: 0x040228E4 RID: 141540
		public int ConfigId;

		// Token: 0x040228E5 RID: 141541
		private EActivityTaskState StatusInternal = EActivityTaskState.Active;

		// Token: 0x040228E6 RID: 141542
		public int Current;

		// Token: 0x040228E7 RID: 141543
		public int Target = 1;
	}
}
