using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02005870 RID: 22640
	[NullableContext(2)]
	[Nullable(0)]
	public class AnniversarySubActivityPinball : AnniversarySubActivityDataBase
	{
		// Token: 0x06037CFB RID: 228603 RVA: 0x00F9BA53 File Offset: 0x00F99C53
		public AnniversarySubActivityPinball(int id) : base(id)
		{
		}

		// Token: 0x17006B2C RID: 27436
		// (get) Token: 0x06037CFC RID: 228604 RVA: 0x00F9BA5C File Offset: 0x00F99C5C
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

		// Token: 0x06037CFD RID: 228605 RVA: 0x00F9BA78 File Offset: 0x00F99C78
		public void ClickOpenView()
		{
			if (this.ActivityData != null && this.ActivityData.IsUnLock())
			{
				PinballController.Instance.OpenMainRootView(null).Forget<bool>();
			}
		}

		// Token: 0x06037CFE RID: 228606 RVA: 0x00F9BA9F File Offset: 0x00F99C9F
		public bool GetNewChapter()
		{
			ActivityBaseData activityData = this.ActivityData;
			return false;
		}

		// Token: 0x06037CFF RID: 228607 RVA: 0x00F9BAA9 File Offset: 0x00F99CA9
		public long GetNextLockedChapterTime()
		{
			ActivityBaseData activityData = this.ActivityData;
			return 0L;
		}

		// Token: 0x06037D00 RID: 228608 RVA: 0x00F9BAB4 File Offset: 0x00F99CB4
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

		// Token: 0x0401D74D RID: 120653
		private ActivityBaseData ActivityDataCache;

		// Token: 0x0401D74E RID: 120654
		private int TotalCount;
	}
}
