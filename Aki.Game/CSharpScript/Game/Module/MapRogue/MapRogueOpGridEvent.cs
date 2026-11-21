using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200458D RID: 17805
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpGridEvent : MapRogueOp
	{
		// Token: 0x17005A8D RID: 23181
		// (get) Token: 0x0602CE03 RID: 183811 RVA: 0x00C8E868 File Offset: 0x00C8CA68
		// (set) Token: 0x0602CE04 RID: 183812 RVA: 0x00C8E870 File Offset: 0x00C8CA70
		public override int StepSize { get; set; } = 2;

		// Token: 0x0602CE05 RID: 183813 RVA: 0x00C8E87C File Offset: 0x00C8CA7C
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 4);
			defaultInterpolatedStringHandler.AppendLiteral("[GridEvent] IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			defaultInterpolatedStringHandler.AppendLiteral(" InStart:");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(this.IsInStart);
			defaultInterpolatedStringHandler.AppendLiteral(" InPlot:");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(this.IsInPlot);
			defaultInterpolatedStringHandler.AppendLiteral(" PlotStepId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentStepId);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602CE06 RID: 183814 RVA: 0x00C8E8FE File Offset: 0x00C8CAFE
		protected override void OnUpdate(MapRogueGameInfo gameInfo)
		{
			if (!base.IsStartExecute)
			{
				return;
			}
			this.RefreshEvent(gameInfo);
		}

		// Token: 0x0602CE07 RID: 183815 RVA: 0x00C8E910 File Offset: 0x00C8CB10
		private void RefreshEvent(MapRogueGameInfo gameInfo)
		{
			if (!this.IsInStart)
			{
				if (this.IsInPlot && !gameInfo.InBattle)
				{
					if (!this.InEventView)
					{
						RogueResEventStep? rogueEventStepById = MapRogueConfig.Instance.GetRogueEventStepById(this.CurrentStepId);
						if (rogueEventStepById != null && rogueEventStepById.GetValueOrDefault().Type == 3)
						{
							this.ExecuteStep(this.CurrentStepId, 0);
							return;
						}
						UiManager.Instance.OpenView(EUiViewName.MapRogueGridEventView, this.IncId, delegate(bool success, int viewId)
						{
							this.InEventView = success;
						});
						return;
					}
					else
					{
						Action<int> eventStepUpdateFunc = this.EventStepUpdateFunc;
						if (eventStepUpdateFunc == null)
						{
							return;
						}
						eventStepUpdateFunc(this.CurrentStepId);
					}
				}
				return;
			}
			GridEventOp gridEventOp = this.Data.GridEventOp;
			int? num;
			if (gridEventOp == null)
			{
				num = null;
			}
			else
			{
				GridEventData gridEventData = gridEventOp.GridEventData;
				num = ((gridEventData != null) ? new int?(gridEventData.EventId) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			RogueResGridEvent? gridEventConfigById = MapRogueConfig.Instance.GetGridEventConfigById(valueOrDefault);
			if (gridEventConfigById == null)
			{
				base.Execute(gameInfo, null);
				return;
			}
			RogueResGlobalParam? globalParamConfig = MapRogueConfig.Instance.GetGlobalParamConfig();
			int[] array = globalParamConfig.Value.GetEventStartSpineTypeArray();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == gridEventConfigById.Value.EventType)
				{
					gameInfo.RoleAnimProxy(EMapRogueSpineAnim.Fight, false);
					break;
				}
			}
			bool flag = true;
			array = globalParamConfig.Value.GetEventStartSeqTypeArray();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == gridEventConfigById.Value.EventType)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				base.Execute(gameInfo, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.MapRogueEventStartView, this.IncId, null);
		}

		// Token: 0x0602CE08 RID: 183816 RVA: 0x00C8EAE1 File Offset: 0x00C8CCE1
		protected override void OnBattleStateUpdate(bool inBattle, MapRogueGameInfo gameInfo)
		{
			if (inBattle && this.InEventView)
			{
				UiManager.Instance.CloseView(EUiViewName.MapRogueGridEventView, delegate(bool _)
				{
					this.InEventView = false;
				});
			}
		}

		// Token: 0x0602CE09 RID: 183817 RVA: 0x00C8EB09 File Offset: 0x00C8CD09
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			this.RefreshEvent(gameInfo);
		}

		// Token: 0x0602CE0A RID: 183818 RVA: 0x00C8EB12 File Offset: 0x00C8CD12
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
			if (this.CurrentStep == 1)
			{
				base.ExecuteOp(null);
			}
		}

		// Token: 0x0602CE0B RID: 183819 RVA: 0x00C8EB24 File Offset: 0x00C8CD24
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CE0C RID: 183820 RVA: 0x00C8EB26 File Offset: 0x00C8CD26
		protected override void OnDelete(MapRogueGameInfo gameInfo)
		{
			if (this.InEventView)
			{
				UiManager.Instance.CloseView(EUiViewName.MapRogueGridEventView, delegate(bool _)
				{
					this.InEventView = false;
				});
			}
		}

		// Token: 0x0602CE0D RID: 183821 RVA: 0x00C8EB4C File Offset: 0x00C8CD4C
		public void ExecuteStep(int stepId, int optionId)
		{
			if (this.CurrentStepId != stepId)
			{
				return;
			}
			if (this.ExecutingStepIdSet.Contains(stepId))
			{
				return;
			}
			if (this.Data.GridEventOp.EventPlotInfo.StepState == StepState.WaitConfirm)
			{
				this.ExecutingStepIdSet.Add(stepId);
				this.OpExecuteClientId = optionId;
				base.ExecuteOp(delegate(bool _)
				{
					this.ExecutingStepIdSet.Remove(stepId);
				});
			}
		}

		// Token: 0x17005A8E RID: 23182
		// (get) Token: 0x0602CE0E RID: 183822 RVA: 0x00C8EBD4 File Offset: 0x00C8CDD4
		public bool IsInStart
		{
			get
			{
				GridEventOp gridEventOp = this.Data.GridEventOp;
				return ((gridEventOp != null) ? new ClientStepState?(gridEventOp.ClientStepState) : null).GetValueOrDefault() == ClientStepState.SpecialEffect;
			}
		}

		// Token: 0x17005A8F RID: 23183
		// (get) Token: 0x0602CE0F RID: 183823 RVA: 0x00C8EC10 File Offset: 0x00C8CE10
		public bool IsInPlot
		{
			get
			{
				GridEventOp gridEventOp = this.Data.GridEventOp;
				return ((gridEventOp != null) ? new ClientStepState?(gridEventOp.ClientStepState) : null).GetValueOrDefault() == ClientStepState.EventPloting;
			}
		}

		// Token: 0x17005A90 RID: 23184
		// (get) Token: 0x0602CE10 RID: 183824 RVA: 0x00C8EC4C File Offset: 0x00C8CE4C
		public int CurrentPlotId
		{
			get
			{
				if (!this.IsInPlot)
				{
					return 0;
				}
				GridEventOp gridEventOp = this.Data.GridEventOp;
				int? num;
				if (gridEventOp == null)
				{
					num = null;
				}
				else
				{
					EventPlotInfo eventPlotInfo = gridEventOp.EventPlotInfo;
					num = ((eventPlotInfo != null) ? new int?(eventPlotInfo.PlotId) : null);
				}
				int? num2 = num;
				return num2.GetValueOrDefault();
			}
		}

		// Token: 0x17005A91 RID: 23185
		// (get) Token: 0x0602CE11 RID: 183825 RVA: 0x00C8ECA4 File Offset: 0x00C8CEA4
		public int CurrentStepId
		{
			get
			{
				if (!this.IsInPlot)
				{
					return 0;
				}
				GridEventOp gridEventOp = this.Data.GridEventOp;
				int? num;
				if (gridEventOp == null)
				{
					num = null;
				}
				else
				{
					EventPlotInfo eventPlotInfo = gridEventOp.EventPlotInfo;
					num = ((eventPlotInfo != null) ? new int?(eventPlotInfo.StepId) : null);
				}
				int? num2 = num;
				return num2.GetValueOrDefault();
			}
		}

		// Token: 0x17005A92 RID: 23186
		// (get) Token: 0x0602CE12 RID: 183826 RVA: 0x00C8ECFC File Offset: 0x00C8CEFC
		public int CurrentPlotBgId
		{
			get
			{
				if (!this.IsInPlot)
				{
					return 0;
				}
				GridEventOp gridEventOp = this.Data.GridEventOp;
				int? num;
				if (gridEventOp == null)
				{
					num = null;
				}
				else
				{
					EventPlotInfo eventPlotInfo = gridEventOp.EventPlotInfo;
					num = ((eventPlotInfo != null) ? new int?(eventPlotInfo.ModifyImage) : null);
				}
				int? num2 = num;
				return num2.GetValueOrDefault();
			}
		}

		// Token: 0x17005A93 RID: 23187
		// (get) Token: 0x0602CE13 RID: 183827 RVA: 0x00C8ED54 File Offset: 0x00C8CF54
		public int CurrentPlotBgmId
		{
			get
			{
				if (!this.IsInPlot)
				{
					return 0;
				}
				GridEventOp gridEventOp = this.Data.GridEventOp;
				int? num;
				if (gridEventOp == null)
				{
					num = null;
				}
				else
				{
					EventPlotInfo eventPlotInfo = gridEventOp.EventPlotInfo;
					num = ((eventPlotInfo != null) ? new int?(eventPlotInfo.ModifyBgm) : null);
				}
				int? num2 = num;
				return num2.GetValueOrDefault();
			}
		}

		// Token: 0x17005A94 RID: 23188
		// (get) Token: 0x0602CE14 RID: 183828 RVA: 0x00C8EDAC File Offset: 0x00C8CFAC
		public IList<EventOption> CurrentOptions
		{
			get
			{
				if (!this.IsInPlot)
				{
					return new List<EventOption>();
				}
				if (this.Data.GridEventOp.EventPlotInfo.Options == null)
				{
					return new List<EventOption>();
				}
				return new List<EventOption>(this.Data.GridEventOp.EventPlotInfo.Options);
			}
		}

		// Token: 0x040180AC RID: 98476
		protected bool InEventView;

		// Token: 0x040180AE RID: 98478
		private readonly HashSet<int> ExecutingStepIdSet = new HashSet<int>();

		// Token: 0x040180AF RID: 98479
		[Nullable(2)]
		public Action<int> EventStepUpdateFunc;
	}
}
