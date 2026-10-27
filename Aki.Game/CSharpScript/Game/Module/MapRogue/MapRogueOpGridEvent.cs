using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055B7 RID: 21943
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpGridEvent : MapRogueOp
	{
		// Token: 0x170086C6 RID: 34502
		// (get) Token: 0x06037F05 RID: 229125 RVA: 0x00D40B20 File Offset: 0x00D3ED20
		// (set) Token: 0x06037F06 RID: 229126 RVA: 0x00D40B28 File Offset: 0x00D3ED28
		public override int StepSize { get; set; } = 2;

		// Token: 0x06037F07 RID: 229127 RVA: 0x00D40B34 File Offset: 0x00D3ED34
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

		// Token: 0x06037F08 RID: 229128 RVA: 0x00D40BB6 File Offset: 0x00D3EDB6
		protected override void OnUpdate(MapRogueGameInfo gameInfo)
		{
			if (!base.IsStartExecute)
			{
				return;
			}
			this.RefreshEvent(gameInfo);
		}

		// Token: 0x06037F09 RID: 229129 RVA: 0x00D40BC8 File Offset: 0x00D3EDC8
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

		// Token: 0x06037F0A RID: 229130 RVA: 0x00D40D99 File Offset: 0x00D3EF99
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

		// Token: 0x06037F0B RID: 229131 RVA: 0x00D40DC1 File Offset: 0x00D3EFC1
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			this.RefreshEvent(gameInfo);
		}

		// Token: 0x06037F0C RID: 229132 RVA: 0x00D40DCA File Offset: 0x00D3EFCA
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
			if (this.CurrentStep == 1)
			{
				base.ExecuteOp(null);
			}
		}

		// Token: 0x06037F0D RID: 229133 RVA: 0x00D40DDC File Offset: 0x00D3EFDC
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037F0E RID: 229134 RVA: 0x00D40DDE File Offset: 0x00D3EFDE
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

		// Token: 0x06037F0F RID: 229135 RVA: 0x00D40E04 File Offset: 0x00D3F004
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

		// Token: 0x170086C7 RID: 34503
		// (get) Token: 0x06037F10 RID: 229136 RVA: 0x00D40E8C File Offset: 0x00D3F08C
		public bool IsInStart
		{
			get
			{
				GridEventOp gridEventOp = this.Data.GridEventOp;
				return ((gridEventOp != null) ? new ClientStepState?(gridEventOp.ClientStepState) : null).GetValueOrDefault() == ClientStepState.SpecialEffect;
			}
		}

		// Token: 0x170086C8 RID: 34504
		// (get) Token: 0x06037F11 RID: 229137 RVA: 0x00D40EC8 File Offset: 0x00D3F0C8
		public bool IsInPlot
		{
			get
			{
				GridEventOp gridEventOp = this.Data.GridEventOp;
				return ((gridEventOp != null) ? new ClientStepState?(gridEventOp.ClientStepState) : null).GetValueOrDefault() == ClientStepState.EventPloting;
			}
		}

		// Token: 0x170086C9 RID: 34505
		// (get) Token: 0x06037F12 RID: 229138 RVA: 0x00D40F04 File Offset: 0x00D3F104
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

		// Token: 0x170086CA RID: 34506
		// (get) Token: 0x06037F13 RID: 229139 RVA: 0x00D40F5C File Offset: 0x00D3F15C
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

		// Token: 0x170086CB RID: 34507
		// (get) Token: 0x06037F14 RID: 229140 RVA: 0x00D40FB4 File Offset: 0x00D3F1B4
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

		// Token: 0x170086CC RID: 34508
		// (get) Token: 0x06037F15 RID: 229141 RVA: 0x00D4100C File Offset: 0x00D3F20C
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

		// Token: 0x170086CD RID: 34509
		// (get) Token: 0x06037F16 RID: 229142 RVA: 0x00D41064 File Offset: 0x00D3F264
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
				return this.Data.GridEventOp.EventPlotInfo.Options.ToList<EventOption>();
			}
		}

		// Token: 0x0401D621 RID: 120353
		protected bool InEventView;

		// Token: 0x0401D623 RID: 120355
		private readonly HashSet<int> ExecutingStepIdSet = new HashSet<int>();

		// Token: 0x0401D624 RID: 120356
		[Nullable(2)]
		public Action<int> EventStepUpdateFunc;
	}
}
