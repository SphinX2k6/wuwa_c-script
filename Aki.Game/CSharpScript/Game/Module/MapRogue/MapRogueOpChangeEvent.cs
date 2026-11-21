using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004589 RID: 17801
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpChangeEvent : MapRogueOp
	{
		// Token: 0x17005A8A RID: 23178
		// (get) Token: 0x0602CDE9 RID: 183785 RVA: 0x00C8E4A9 File Offset: 0x00C8C6A9
		// (set) Token: 0x0602CDEA RID: 183786 RVA: 0x00C8E4B1 File Offset: 0x00C8C6B1
		public override int StepSize { get; set; } = 1;

		// Token: 0x0602CDEB RID: 183787 RVA: 0x00C8E4BC File Offset: 0x00C8C6BC
		public MapRogueOpChangeEvent()
		{
			this.ExecuteInMapView = true;
			this.ExecuteAfterMapViewShow = true;
		}

		// Token: 0x0602CDEC RID: 183788 RVA: 0x00C8E508 File Offset: 0x00C8C708
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[ChangeEvent] IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602CDED RID: 183789 RVA: 0x00C8E53F File Offset: 0x00C8C73F
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			base.Execute(gameInfo, null);
		}

		// Token: 0x0602CDEE RID: 183790 RVA: 0x00C8E54C File Offset: 0x00C8C74C
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
			ChangeEventByPosOp changeEventByPosOp = this.Data.ChangeEventByPosOp;
			if (changeEventByPosOp == null)
			{
				return;
			}
			gameInfo.SetInteractAvailable(EMapForbiddenTag.FocusLock, false);
			for (int i = 0; i < changeEventByPosOp.ChangeEventDatas.Count; i++)
			{
				ChangeEventData changeEventData = changeEventByPosOp.ChangeEventDatas[i];
				bool finishChangeFlow = i == changeEventByPosOp.ChangeEventDatas.Count - 1;
				this.SingleGridChangeFlow(gameInfo, changeEventData.Index, changeEventData.RogueResGridData, finishChangeFlow);
			}
		}

		// Token: 0x0602CDEF RID: 183791 RVA: 0x00C8E5BC File Offset: 0x00C8C7BC
		private void SingleGridChangeFlow(MapRogueGameInfo gameInfo, int gridIndex, RogueResGridData gridInfo, bool finishChangeFlow)
		{
			MapRogueOpChangeEvent.<>c__DisplayClass10_0 CS$<>8__locals1 = new MapRogueOpChangeEvent.<>c__DisplayClass10_0();
			CS$<>8__locals1.gameInfo = gameInfo;
			CS$<>8__locals1.gridIndex = gridIndex;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.gridInfo = gridInfo;
			CS$<>8__locals1.finishChangeFlow = finishChangeFlow;
			AsyncTask task = new AsyncTask("MapRogueOpChangeEvent.SingleGridChangeFlow", delegate()
			{
				MapRogueOpChangeEvent.<>c__DisplayClass10_0.<<SingleGridChangeFlow>b__0>d <<SingleGridChangeFlow>b__0>d;
				<<SingleGridChangeFlow>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
				<<SingleGridChangeFlow>b__0>d.<>4__this = CS$<>8__locals1;
				<<SingleGridChangeFlow>b__0>d.<>1__state = -1;
				<<SingleGridChangeFlow>b__0>d.<>t__builder.Start<MapRogueOpChangeEvent.<>c__DisplayClass10_0.<<SingleGridChangeFlow>b__0>d>(ref <<SingleGridChangeFlow>b__0>d);
				return <<SingleGridChangeFlow>b__0>d.<>t__builder.Task;
			}, null, null, null);
			TaskSystem.Instance.AddTask(task);
			TaskSystem.Instance.Run();
		}

		// Token: 0x0602CDF0 RID: 183792 RVA: 0x00C8E623 File Offset: 0x00C8C823
		private void FinishChangeFlow(MapRogueGameInfo gameInfo)
		{
			gameInfo.SetInteractAvailable(EMapForbiddenTag.FocusLock, true);
			base.Execute(gameInfo, null);
		}

		// Token: 0x0602CDF1 RID: 183793 RVA: 0x00C8E635 File Offset: 0x00C8C835
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x040180A1 RID: 98465
		private readonly float FocusTweenTime = (float)MapRogueConfig.Instance.GetGlobalParamConfig().Value.FocusTime;

		// Token: 0x040180A3 RID: 98467
		private const int EVENT_CHANGE_ANIM_TIME = 500;
	}
}
