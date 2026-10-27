using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02006922 RID: 26914
	[NullableContext(2)]
	[Nullable(0)]
	public class AnniversarySubActivityWuWuPack : AnniversarySubActivityDataBase
	{
		// Token: 0x060431AB RID: 274859 RVA: 0x0105A643 File Offset: 0x01058843
		public AnniversarySubActivityWuWuPack(int id) : base(id)
		{
		}

		// Token: 0x170097ED RID: 38893
		// (get) Token: 0x060431AC RID: 274860 RVA: 0x0105A64C File Offset: 0x0105884C
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

		// Token: 0x060431AD RID: 274861 RVA: 0x0105A66D File Offset: 0x0105886D
		public void ClickOpenView()
		{
		}

		// Token: 0x060431AE RID: 274862 RVA: 0x0105A670 File Offset: 0x01058870
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

		// Token: 0x04022EF3 RID: 143091
		private WuWuLogisticsActivityData ActivityDataCache;
	}
}
