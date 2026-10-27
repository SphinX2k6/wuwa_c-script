using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree
{
	// Token: 0x020059EC RID: 23020
	[NullableContext(1)]
	[Nullable(0)]
	public class BehaviorTreeTimerCenter
	{
		// Token: 0x0603A54E RID: 238926 RVA: 0x00DE029C File Offset: 0x00DDE49C
		public BehaviorTreeTimerCenter(long treeIncId, Blackboard blackBoard)
		{
			this.TreeIncId = treeIncId;
			this.Blackboard = blackBoard;
		}

		// Token: 0x0603A54F RID: 238927 RVA: 0x00DE02C0 File Offset: 0x00DDE4C0
		public void Dispose()
		{
			foreach (LogicTreeTimerBase logicTreeTimerBase in this.Timers.Values)
			{
				logicTreeTimerBase.Destroy();
			}
			this.Timers.Clear();
		}

		// Token: 0x0603A550 RID: 238928 RVA: 0x00DE0320 File Offset: 0x00DDE520
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

		// Token: 0x0603A551 RID: 238929 RVA: 0x00DE0370 File Offset: 0x00DDE570
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

		// Token: 0x0603A552 RID: 238930 RVA: 0x00DE071C File Offset: 0x00DDE91C
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

		// Token: 0x0603A553 RID: 238931 RVA: 0x00DE0777 File Offset: 0x00DDE977
		[return: Nullable(2)]
		public LogicTreeTimerBase GetTimer(string timerType)
		{
			return this.Timers.GetValueOrDefault(timerType);
		}

		// Token: 0x0603A554 RID: 238932 RVA: 0x00DE0788 File Offset: 0x00DDE988
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

		// Token: 0x0603A555 RID: 238933 RVA: 0x00DE07D8 File Offset: 0x00DDE9D8
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

		// Token: 0x0401E69E RID: 124574
		private const int TICK_INTETVAL_TIME = 20;

		// Token: 0x0401E69F RID: 124575
		private const int FAILEDRANGE_INTERTVAL = 100;

		// Token: 0x0401E6A0 RID: 124576
		private readonly long TreeIncId;

		// Token: 0x0401E6A1 RID: 124577
		private readonly Blackboard Blackboard;

		// Token: 0x0401E6A2 RID: 124578
		private readonly Dictionary<string, LogicTreeTimerBase> Timers = new Dictionary<string, LogicTreeTimerBase>();
	}
}
