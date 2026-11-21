using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02005872 RID: 22642
	[NullableContext(2)]
	[Nullable(0)]
	public class AnniversarySubActivityWuWuPack : AnniversarySubActivityDataBase
	{
		// Token: 0x06037D03 RID: 228611 RVA: 0x00F9BC6F File Offset: 0x00F99E6F
		public AnniversarySubActivityWuWuPack(int id) : base(id)
		{
		}

		// Token: 0x17006B2D RID: 27437
		// (get) Token: 0x06037D04 RID: 228612 RVA: 0x00F9BC78 File Offset: 0x00F99E78
		public WuWuLogisticsActivityData ActivityData
		{
			get
			{
				if (this.ActivityDataCache == null)
				{
					this.ActivityDataCache = (base.GetActivityData() as WuWuLogisticsActivityData);
				}
				return this.ActivityDataCache;
			}
		}

		// Token: 0x06037D05 RID: 228613 RVA: 0x00F9BC99 File Offset: 0x00F99E99
		public void ClickOpenView()
		{
		}

		// Token: 0x06037D06 RID: 228614 RVA: 0x00F9BC9C File Offset: 0x00F99E9C
		[NullableContext(0)]
		public override ValueTuple<int, int> GetCurrentProgress()
		{
			int num = 0;
			int num2 = 0;
			IReadOnlyList<WuWuTaskPackage> allTaskPackage = WuWuLogisticsConfig.Instance.GetAllTaskPackage();
			if (allTaskPackage == null)
			{
				return new ValueTuple<int, int>(num2, num);
			}
			foreach (WuWuTaskPackage wuWuTaskPackage in allTaskPackage)
			{
				if (wuWuTaskPackage.DropId > 0)
				{
					foreach (TItem titem in CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(wuWuTaskPackage.DropId))
					{
						if (titem.ItemData.ItemId == 74)
						{
							num += titem.Count;
							WuWuLogisticsActivityData activityData = this.ActivityData;
							WuWuTaskPackData wuWuTaskPackData = (activityData != null) ? activityData.GetTaskPackById(wuWuTaskPackage.Id) : null;
							if (wuWuTaskPackData != null && wuWuTaskPackData.HadReward)
							{
								num2 += titem.Count;
							}
						}
					}
				}
				IReadOnlyList<WuWuWeekTask> weekTaskByWrapId = WuWuLogisticsConfig.Instance.GetWeekTaskByWrapId(wuWuTaskPackage.Id);
				if (weekTaskByWrapId != null)
				{
					foreach (WuWuWeekTask wuWuWeekTask in weekTaskByWrapId)
					{
						if (wuWuWeekTask.DropId > 0)
						{
							foreach (TItem titem2 in CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(wuWuWeekTask.DropId))
							{
								if (titem2.ItemData.ItemId == 74)
								{
									num += titem2.Count;
									WuWuLogisticsActivityData activityData2 = this.ActivityData;
									WuWuTaskPackData wuWuTaskPackData2 = (activityData2 != null) ? activityData2.GetTaskPackById(wuWuTaskPackage.Id) : null;
									if (wuWuTaskPackData2 != null && wuWuTaskPackData2.HadReward)
									{
										num2 += titem2.Count;
									}
								}
							}
						}
					}
				}
			}
			return new ValueTuple<int, int>(num2, num);
		}

		// Token: 0x0401D74F RID: 120655
		private WuWuLogisticsActivityData ActivityDataCache;
	}
}
