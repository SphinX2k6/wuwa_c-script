using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree
{
	// Token: 0x020049C5 RID: 18885
	[NullableContext(1)]
	[Nullable(0)]
	public class BehaviorTreeTimerCenter
	{
		// Token: 0x0602F475 RID: 193653 RVA: 0x00D2FB08 File Offset: 0x00D2DD08
		public BehaviorTreeTimerCenter(long treeIncId, Blackboard blackBoard)
		{
			this.TreeIncId = treeIncId;
			this.Blackboard = blackBoard;
		}

		// Token: 0x0602F476 RID: 193654 RVA: 0x00D2FB2C File Offset: 0x00D2DD2C
		public void Dispose()
		{
			foreach (LogicTreeTimerBase logicTreeTimerBase in this.Timers.Values)
			{
				logicTreeTimerBase.Destroy();
			}
			this.Timers.Clear();
		}

		// Token: 0x0602F477 RID: 193655 RVA: 0x00D2FB8C File Offset: 0x00D2DD8C
		[NullableContext(2)]
		public void UpdateTimerInfo(TimerInfoPb timerInfo)
		{
			if (timerInfo == null)
			{
				return;
			}
			string timerType = timerInfo.TimerType;
			if (timerInfo.EndTime == 0L)
			{
				this.EndShowTimer(timerType);
				return;
			}
			long endTime = timerInfo.EndTime;
			if (endTime == 0L)
			{
				this.EndShowTimer(timerType);
				return;
			}
			long pauseTime = timerInfo.PauseTime;
			this.StartShowTimer(timerType, endTime, pauseTime, timerInfo.NodeId);
		}

		// Token: 0x0602F478 RID: 193656 RVA: 0x00D2FBDC File Offset: 0x00D2DDDC
		private void StartShowTimer(string timerType, long endTime, long pauseTime, int nodeId)
		{
			LogicTreeTimerBase logicTreeTimerBase = null;
			ETimerType timerType2;
			if (!ETimerTypeExtensions.TryFromString(timerType, out timerType2))
			{
				if (timerType == "FailedNodeOutRangeTimerType")
				{
					logicTreeTimerBase = this.GetTimer(ETimerType.CountDownChallenge.ToEnumString());
					double remainTime = this.GetRemainTime(new ETimerType?(ETimerType.CountDownChallenge));
					if (logicTreeTimerBase == null || remainTime > 10.0)
					{
						logicTreeTimerBase = (this.GetTimer(timerType) as FailRangeTimer);
						if (logicTreeTimerBase == null)
						{
							logicTreeTimerBase = new FailRangeTimer(this.TreeIncId, timerType, 100.0);
							this.Timers[timerType] = logicTreeTimerBase;
						}
					}
				}
				else if (timerType == "NpcFarAwayOutRangeTimerType")
				{
					logicTreeTimerBase = this.GetTimer(ETimerType.CountDownChallenge.ToEnumString());
					double remainTime2 = this.GetRemainTime(new ETimerType?(ETimerType.CountDownChallenge));
					if (logicTreeTimerBase == null || remainTime2 > 10.0)
					{
						logicTreeTimerBase = (this.GetTimer(timerType) as FailRangeTimer);
						if (logicTreeTimerBase == null)
						{
							logicTreeTimerBase = new FailRangeTimer(this.TreeIncId, timerType, 100.0);
							this.Timers[timerType] = logicTreeTimerBase;
						}
					}
				}
			}
			else
			{
				switch (timerType2)
				{
				case ETimerType.CountDownChallenge:
				case ETimerType.PublicTime:
				case ETimerType.BehaviorTreeTimer1:
				case ETimerType.BehaviorTreeTimer2:
				case ETimerType.BehaviorTreeTimer3:
				case ETimerType.BehaviorTreeTimer4:
				case ETimerType.BehaviorTreeTimer5:
					logicTreeTimerBase = (this.GetTimer(timerType) as CountDownTimer);
					if (logicTreeTimerBase == null)
					{
						BehaviorNodeBase node = this.Blackboard.GetNode(new int?(nodeId));
						ETimerUiType uiType = ETimerUiType.Default;
						string uiTitle = "";
						QuestFailedBehaviorNode questFailedBehaviorNode = node as QuestFailedBehaviorNode;
						if (questFailedBehaviorNode != null)
						{
							ITimerUiConfig timerUiConfig = questFailedBehaviorNode.TimerUiConfig;
							uiType = ((timerUiConfig != null) ? timerUiConfig.UiType : ETimerUiType.Default);
							ITimerUiConfig timerUiConfig2 = questFailedBehaviorNode.TimerUiConfig;
							if (!string.IsNullOrEmpty((timerUiConfig2 != null) ? timerUiConfig2.TidTitle : null))
							{
								string text;
								if ((text = PublicUtil.Instance.GetConfigTextByKey(questFailedBehaviorNode.TimerUiConfig.TidTitle)) == null)
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
									defaultInterpolatedStringHandler.AppendFormatted<int>(this.Blackboard.TreeConfigId);
									defaultInterpolatedStringHandler.AppendLiteral("-");
									defaultInterpolatedStringHandler.AppendFormatted<int>(nodeId);
									text = defaultInterpolatedStringHandler.ToStringAndClear();
								}
								uiTitle = text;
							}
							else
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
								defaultInterpolatedStringHandler.AppendFormatted<int>(this.Blackboard.TreeConfigId);
								defaultInterpolatedStringHandler.AppendLiteral("-");
								defaultInterpolatedStringHandler.AppendFormatted<int>(nodeId);
								uiTitle = defaultInterpolatedStringHandler.ToStringAndClear();
							}
						}
						else
						{
							TimerNode timerNode = node as TimerNode;
							if (timerNode != null)
							{
								ITimerUiConfig timerUiConfig3 = timerNode.TimerUiConfig;
								uiType = ((timerUiConfig3 != null) ? timerUiConfig3.UiType : ETimerUiType.Default);
								ITimerUiConfig timerUiConfig4 = timerNode.TimerUiConfig;
								if (!string.IsNullOrEmpty((timerUiConfig4 != null) ? timerUiConfig4.TidTitle : null))
								{
									string text2;
									if ((text2 = PublicUtil.Instance.GetConfigTextByKey(timerNode.TimerUiConfig.TidTitle)) == null)
									{
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
										defaultInterpolatedStringHandler.AppendFormatted<int>(this.Blackboard.TreeConfigId);
										defaultInterpolatedStringHandler.AppendLiteral("-");
										defaultInterpolatedStringHandler.AppendFormatted<int>(nodeId);
										text2 = defaultInterpolatedStringHandler.ToStringAndClear();
									}
									uiTitle = text2;
								}
								else
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
									defaultInterpolatedStringHandler.AppendFormatted<int>(this.Blackboard.TreeConfigId);
									defaultInterpolatedStringHandler.AppendLiteral("-");
									defaultInterpolatedStringHandler.AppendFormatted<int>(nodeId);
									uiTitle = defaultInterpolatedStringHandler.ToStringAndClear();
								}
							}
						}
						logicTreeTimerBase = new CountDownTimer(this.TreeIncId, nodeId, timerType2, uiType, uiTitle, 20.0);
						this.Timers[timerType] = logicTreeTimerBase;
					}
					break;
				case ETimerType.PlayStartCountDown:
					logicTreeTimerBase = (this.GetTimer(timerType) as LevelPlayPrepareTimer);
					if (logicTreeTimerBase == null)
					{
						logicTreeTimerBase = new LevelPlayPrepareTimer(this.TreeIncId, timerType, false, 20.0);
						this.Timers[timerType] = logicTreeTimerBase;
					}
					break;
				case ETimerType.WaitTime:
					logicTreeTimerBase = (this.GetTimer(timerType) as NoUiTimer);
					if (logicTreeTimerBase == null)
					{
						logicTreeTimerBase = new NoUiTimer(this.TreeIncId, timerType, true, 20.0);
						this.Timers[timerType] = logicTreeTimerBase;
					}
					break;
				}
			}
			if (logicTreeTimerBase != null)
			{
				logicTreeTimerBase.StartShowTimer((double)endTime, (double)pauseTime);
			}
		}

		// Token: 0x0602F479 RID: 193657 RVA: 0x00D2FF88 File Offset: 0x00D2E188
		private void EndShowTimer(string timerType)
		{
			LogicTreeTimerBase timer = this.GetTimer(timerType);
			if (timer == null)
			{
				return;
			}
			if (timerType == "FailedNodeOutRangeTimerType" || timerType == "NpcFarAwayOutRangeTimerType" || timerType == ETimerType.PlayStartCountDown.ToEnumString())
			{
				timer.EndShowTimer();
				return;
			}
			timer.Destroy();
			this.Timers.Remove(timerType);
		}

		// Token: 0x0602F47A RID: 193658 RVA: 0x00D2FFE3 File Offset: 0x00D2E1E3
		[return: Nullable(2)]
		public LogicTreeTimerBase GetTimer(string timerType)
		{
			return this.Timers.GetValueOrDefault(timerType);
		}

		// Token: 0x0602F47B RID: 193659 RVA: 0x00D2FFF4 File Offset: 0x00D2E1F4
		public double GetRemainTime(ETimerType? timerType = null)
		{
			ETimerType value = timerType.GetValueOrDefault();
			if (timerType == null)
			{
				value = ETimerType.CountDownChallenge;
				timerType = new ETimerType?(value);
			}
			LogicTreeTimerBase timer = this.GetTimer(timerType.Value.ToEnumString());
			if (timer == null)
			{
				return 0.0;
			}
			return timer.GetRemainTime();
		}

		// Token: 0x0602F47C RID: 193660 RVA: 0x00D30044 File Offset: 0x00D2E244
		public bool HasRunningTimers([Nullable(new byte[]
		{
			2,
			1
		})] List<string> includes = null, [Nullable(new byte[]
		{
			2,
			1
		})] List<string> excludes = null)
		{
			foreach (KeyValuePair<string, LogicTreeTimerBase> keyValuePair in this.Timers)
			{
				string text;
				LogicTreeTimerBase logicTreeTimerBase;
				keyValuePair.Deconstruct(out text, out logicTreeTimerBase);
				string item = text;
				LogicTreeTimerBase logicTreeTimerBase2 = logicTreeTimerBase;
				if ((includes == null || includes.Contains(item)) && (excludes == null || !excludes.Contains(item)) && logicTreeTimerBase2.GetRemainTime() > 0.0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0401913D RID: 102717
		private const int TICK_INTETVAL_TIME = 20;

		// Token: 0x0401913E RID: 102718
		private const int FAILEDRANGE_INTERTVAL = 100;

		// Token: 0x0401913F RID: 102719
		private readonly long TreeIncId;

		// Token: 0x04019140 RID: 102720
		private readonly Blackboard Blackboard;

		// Token: 0x04019141 RID: 102721
		private readonly Dictionary<string, LogicTreeTimerBase> Timers = new Dictionary<string, LogicTreeTimerBase>();
	}
}
