using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x02006392 RID: 25490
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorTaskData
	{
		// Token: 0x060401C1 RID: 262593 RVA: 0x00F842E0 File Offset: 0x00F824E0
		public MultiMotorTaskData(int taskId)
		{
			this.TaskId = taskId;
		}

		// Token: 0x060401C2 RID: 262594 RVA: 0x00F84304 File Offset: 0x00F82504
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

		// Token: 0x17009361 RID: 37729
		// (get) Token: 0x060401C3 RID: 262595 RVA: 0x00F84411 File Offset: 0x00F82611
		public bool IsRunning
		{
			get
			{
				return this.Status == EActivityTaskState.Active;
			}
		}

		// Token: 0x17009362 RID: 37730
		// (get) Token: 0x060401C4 RID: 262596 RVA: 0x00F8441C File Offset: 0x00F8261C
		public bool IsFinished
		{
			get
			{
				return this.Status == EActivityTaskState.FinishedAndUnclaimed;
			}
		}

		// Token: 0x17009363 RID: 37731
		// (get) Token: 0x060401C5 RID: 262597 RVA: 0x00F84427 File Offset: 0x00F82627
		public bool IsReceived
		{
			get
			{
				return this.Status == EActivityTaskState.FinishedAndClaimed;
			}
		}

		// Token: 0x060401C6 RID: 262598 RVA: 0x00F84432 File Offset: 0x00F82632
		public void RefreshState(EActivityTaskState state)
		{
			this.Status = state;
		}

		// Token: 0x17009364 RID: 37732
		// (get) Token: 0x060401C7 RID: 262599 RVA: 0x00F8443B File Offset: 0x00F8263B
		// (set) Token: 0x060401C8 RID: 262600 RVA: 0x00F84443 File Offset: 0x00F82643
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

		// Token: 0x17009365 RID: 37733
		// (get) Token: 0x060401C9 RID: 262601 RVA: 0x00F8444C File Offset: 0x00F8264C
		public bool IsGlobalTask
		{
			get
			{
				return this.LevelId < 0;
			}
		}

		// Token: 0x17009366 RID: 37734
		// (get) Token: 0x060401CA RID: 262602 RVA: 0x00F84458 File Offset: 0x00F82658
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

		// Token: 0x04021660 RID: 136800
		public int TaskId;

		// Token: 0x04021661 RID: 136801
		public readonly List<TItem> RewardList = new List<TItem>();

		// Token: 0x04021662 RID: 136802
		private int LevelInternal;

		// Token: 0x04021663 RID: 136803
		private int Champion;

		// Token: 0x04021664 RID: 136804
		private int FirstRunner;

		// Token: 0x04021665 RID: 136805
		private int PlayCount;

		// Token: 0x04021666 RID: 136806
		private int SpeedLap;

		// Token: 0x04021667 RID: 136807
		public EActivityTaskState Status = EActivityTaskState.Active;
	}
}
