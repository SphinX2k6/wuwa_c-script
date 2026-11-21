using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x02005310 RID: 21264
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorTaskData
	{
		// Token: 0x06034E82 RID: 216706 RVA: 0x00ECB254 File Offset: 0x00EC9454
		public MultiMotorTaskData(int taskId)
		{
			this.TaskId = taskId;
		}

		// Token: 0x06034E83 RID: 216707 RVA: 0x00ECB278 File Offset: 0x00EC9478
		public void RefreshByTaskInfo(OnlineMotorTask taskInfo)
		{
			switch (taskInfo.State)
			{
			case ActivityTaskState.ActivityTaskRunning:
				this.Status = EActivityTaskState.Active;
				break;
			case ActivityTaskState.ActivityTaskFinish:
				this.Status = EActivityTaskState.FinishedAndUnclaimed;
				break;
			case ActivityTaskState.ActivityTaskTaken:
				this.Status = EActivityTaskState.FinishedAndClaimed;
				break;
			}
			this.Champion = taskInfo.Champion;
			this.FirstRunner = taskInfo.FirstRunner;
			this.PlayCount = taskInfo.PlayCount;
			this.SpeedLap = taskInfo.SpeedLap;
			if (this.IsGlobalTask)
			{
				OnlineMotorGlobalTask? motorGlobalTaskByTaskId = MultiMotorConfig.Instance.GetMotorGlobalTaskByTaskId(this.TaskId);
				if (motorGlobalTaskByTaskId != null)
				{
					this.RewardList.Clear();
					this.RewardList.AddRange(CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(motorGlobalTaskByTaskId.Value.DropId));
					return;
				}
			}
			else
			{
				OnlineMotorLevelTask? motorLevelTaskByTaskId = MultiMotorConfig.Instance.GetMotorLevelTaskByTaskId(this.TaskId);
				if (motorLevelTaskByTaskId != null)
				{
					this.RewardList.Clear();
					this.RewardList.AddRange(CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(motorLevelTaskByTaskId.Value.DropId));
				}
			}
		}

		// Token: 0x170066C3 RID: 26307
		// (get) Token: 0x06034E84 RID: 216708 RVA: 0x00ECB385 File Offset: 0x00EC9585
		public bool IsRunning
		{
			get
			{
				return this.Status == EActivityTaskState.Active;
			}
		}

		// Token: 0x170066C4 RID: 26308
		// (get) Token: 0x06034E85 RID: 216709 RVA: 0x00ECB390 File Offset: 0x00EC9590
		public bool IsFinished
		{
			get
			{
				return this.Status == EActivityTaskState.FinishedAndUnclaimed;
			}
		}

		// Token: 0x170066C5 RID: 26309
		// (get) Token: 0x06034E86 RID: 216710 RVA: 0x00ECB39B File Offset: 0x00EC959B
		public bool IsReceived
		{
			get
			{
				return this.Status == EActivityTaskState.FinishedAndClaimed;
			}
		}

		// Token: 0x06034E87 RID: 216711 RVA: 0x00ECB3A6 File Offset: 0x00EC95A6
		public void RefreshState(EActivityTaskState state)
		{
			this.Status = state;
		}

		// Token: 0x170066C6 RID: 26310
		// (get) Token: 0x06034E88 RID: 216712 RVA: 0x00ECB3AF File Offset: 0x00EC95AF
		// (set) Token: 0x06034E89 RID: 216713 RVA: 0x00ECB3B7 File Offset: 0x00EC95B7
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

		// Token: 0x170066C7 RID: 26311
		// (get) Token: 0x06034E8A RID: 216714 RVA: 0x00ECB3C0 File Offset: 0x00EC95C0
		public bool IsGlobalTask
		{
			get
			{
				return this.LevelId < 0;
			}
		}

		// Token: 0x170066C8 RID: 26312
		// (get) Token: 0x06034E8B RID: 216715 RVA: 0x00ECB3CC File Offset: 0x00EC95CC
		public string DescString
		{
			get
			{
				string text = "";
				if (this.IsGlobalTask)
				{
					OnlineMotorGlobalTask? motorGlobalTaskByTaskId = MultiMotorConfig.Instance.GetMotorGlobalTaskByTaskId(this.TaskId);
					if (motorGlobalTaskByTaskId == null)
					{
						return "";
					}
					if (motorGlobalTaskByTaskId.Value.PlayCount != 0)
					{
						text += ConfigMultiTextLang.GetLocalTextNew(motorGlobalTaskByTaskId.Value.PlayCountDes, null);
						text = StringUtils.Format(text, new string[]
						{
							this.PlayCount.ToString(),
							motorGlobalTaskByTaskId.Value.PlayCount.ToString()
						});
					}
					if (motorGlobalTaskByTaskId.Value.SpeedLap != 0)
					{
						if (!string.IsNullOrEmpty(text))
						{
							text += ConfigMultiTextLang.GetLocalTextNew("MultiMotorTaskDesMiddle", null);
						}
						text += ConfigMultiTextLang.GetLocalTextNew(motorGlobalTaskByTaskId.Value.SpeedLapDes, null);
						text = StringUtils.Format(text, new string[]
						{
							this.SpeedLap.ToString(),
							motorGlobalTaskByTaskId.Value.SpeedLap.ToString()
						});
					}
					if (motorGlobalTaskByTaskId.Value.Champion != 0)
					{
						if (!string.IsNullOrEmpty(text))
						{
							text += ConfigMultiTextLang.GetLocalTextNew("MultiMotorTaskDesMiddle", null);
						}
						text += ConfigMultiTextLang.GetLocalTextNew(motorGlobalTaskByTaskId.Value.ChampionDes, null);
						text = StringUtils.Format(text, new string[]
						{
							this.Champion.ToString(),
							motorGlobalTaskByTaskId.Value.Champion.ToString()
						});
					}
					if (motorGlobalTaskByTaskId.Value.FirstRunner != 0)
					{
						if (!string.IsNullOrEmpty(text))
						{
							text += ConfigMultiTextLang.GetLocalTextNew("MultiMotorTaskDesMiddle", null);
						}
						text += ConfigMultiTextLang.GetLocalTextNew(motorGlobalTaskByTaskId.Value.FirstRunnerDes, null);
						text = StringUtils.Format(text, new string[]
						{
							this.FirstRunner.ToString(),
							motorGlobalTaskByTaskId.Value.FirstRunner.ToString()
						});
					}
				}
				else
				{
					OnlineMotorLevelTask? motorLevelTaskByTaskId = MultiMotorConfig.Instance.GetMotorLevelTaskByTaskId(this.TaskId);
					if (motorLevelTaskByTaskId == null)
					{
						return "";
					}
					if (motorLevelTaskByTaskId.Value.PlayCount != 0)
					{
						text += ConfigMultiTextLang.GetLocalTextNew(motorLevelTaskByTaskId.Value.PlayCountDes, null);
						text = StringUtils.Format(text, new string[]
						{
							this.PlayCount.ToString(),
							motorLevelTaskByTaskId.Value.PlayCount.ToString()
						});
					}
					if (motorLevelTaskByTaskId.Value.SpeedLap != 0)
					{
						if (!string.IsNullOrEmpty(text))
						{
							text += ConfigMultiTextLang.GetLocalTextNew("MultiMotorTaskDesMiddle", null);
						}
						text += ConfigMultiTextLang.GetLocalTextNew(motorLevelTaskByTaskId.Value.SpeedLapDes, null);
						text = StringUtils.Format(text, new string[]
						{
							this.SpeedLap.ToString(),
							motorLevelTaskByTaskId.Value.SpeedLap.ToString()
						});
					}
					if (motorLevelTaskByTaskId.Value.Champion != 0)
					{
						if (!string.IsNullOrEmpty(text))
						{
							text += ConfigMultiTextLang.GetLocalTextNew("MultiMotorTaskDesMiddle", null);
						}
						text += ConfigMultiTextLang.GetLocalTextNew(motorLevelTaskByTaskId.Value.ChampionDes, null);
						text = StringUtils.Format(text, new string[]
						{
							this.Champion.ToString(),
							motorLevelTaskByTaskId.Value.Champion.ToString()
						});
					}
					if (motorLevelTaskByTaskId.Value.FirstRunner != 0)
					{
						if (!string.IsNullOrEmpty(text))
						{
							text += ConfigMultiTextLang.GetLocalTextNew("MultiMotorTaskDesMiddle", null);
						}
						text += ConfigMultiTextLang.GetLocalTextNew(motorLevelTaskByTaskId.Value.FirstRunnerDes, null);
						text = StringUtils.Format(text, new string[]
						{
							this.FirstRunner.ToString(),
							motorLevelTaskByTaskId.Value.FirstRunner.ToString()
						});
					}
				}
				return text;
			}
		}

		// Token: 0x0401BF8F RID: 114575
		public int TaskId;

		// Token: 0x0401BF90 RID: 114576
		public readonly List<TItem> RewardList = new List<TItem>();

		// Token: 0x0401BF91 RID: 114577
		private int LevelInternal;

		// Token: 0x0401BF92 RID: 114578
		private int Champion;

		// Token: 0x0401BF93 RID: 114579
		private int FirstRunner;

		// Token: 0x0401BF94 RID: 114580
		private int PlayCount;

		// Token: 0x0401BF95 RID: 114581
		private int SpeedLap;

		// Token: 0x0401BF96 RID: 114582
		public EActivityTaskState Status = EActivityTaskState.Active;
	}
}
