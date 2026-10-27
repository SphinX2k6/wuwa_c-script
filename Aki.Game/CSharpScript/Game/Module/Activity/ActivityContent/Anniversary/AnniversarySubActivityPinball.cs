using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02006920 RID: 26912
	[NullableContext(2)]
	[Nullable(0)]
	public class AnniversarySubActivityPinball : AnniversarySubActivityDataBase
	{
		// Token: 0x060431A3 RID: 274851 RVA: 0x0105A427 File Offset: 0x01058627
		public AnniversarySubActivityPinball(int id) : base(id)
		{
		}

		// Token: 0x170097EC RID: 38892
		// (get) Token: 0x060431A4 RID: 274852 RVA: 0x0105A430 File Offset: 0x01058630
		public ActivityBaseData ActivityData
		{
			get
			{
				if (this.ActivityDataCache == null)
				{
					this.ActivityDataCache = base.GetActivityData();
				}
				return this.ActivityDataCache;
			}
		}

		// Token: 0x060431A5 RID: 274853 RVA: 0x0105A44C File Offset: 0x0105864C
		public void ClickOpenView()
		{
			if (this.ActivityData != null && this.ActivityData.IsUnLock())
			{
				PinballController.Instance.OpenMainRootView(null).Forget<bool>();
			}
		}

		// Token: 0x060431A6 RID: 274854 RVA: 0x0105A473 File Offset: 0x01058673
		public bool GetNewChapter()
		{
			ActivityBaseData activityData = this.ActivityData;
			return false;
		}

		// Token: 0x060431A7 RID: 274855 RVA: 0x0105A47D File Offset: 0x0105867D
		public long GetNextLockedChapterTime()
		{
			ActivityBaseData activityData = this.ActivityData;
			return 0L;
		}

		// Token: 0x060431A8 RID: 274856 RVA: 0x0105A488 File Offset: 0x01058688
		[NullableContext(0)]
		public override ValueTuple<int, int> GetCurrentProgress()
		{
			int item = 0;
			if (this.TotalCount == 0)
			{
				IReadOnlyList<PinballTask> configList = ConfigPinballTaskAll.GetConfigList(true);
				if (configList != null)
				{
					foreach (PinballTask pinballTask in configList)
					{
						if (pinballTask.DropId > 0)
						{
							DropPackage? config = ConfigDropPackageById.GetConfig(pinballTask.DropId, true);
							if (config != null)
							{
								foreach (DicIntInt dicIntInt in config.Value.DropPreviewIter())
								{
									if (dicIntInt.Key == 74)
									{
										this.TotalCount += dicIntInt.Value;
									}
								}
							}
						}
					}
				}
			}
			return new ValueTuple<int, int>(item, this.TotalCount);
		}

		// Token: 0x04022EF1 RID: 143089
		private ActivityBaseData ActivityDataCache;

		// Token: 0x04022EF2 RID: 143090
		private int TotalCount;
	}
}
