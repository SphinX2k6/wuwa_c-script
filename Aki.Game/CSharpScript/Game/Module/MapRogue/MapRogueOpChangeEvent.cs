using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055B3 RID: 21939
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpChangeEvent : MapRogueOp
	{
		// Token: 0x170086C3 RID: 34499
		// (get) Token: 0x06037EEB RID: 229099 RVA: 0x00D40761 File Offset: 0x00D3E961
		// (set) Token: 0x06037EEC RID: 229100 RVA: 0x00D40769 File Offset: 0x00D3E969
		public override int StepSize { get; set; } = 1;

		// Token: 0x06037EED RID: 229101 RVA: 0x00D40774 File Offset: 0x00D3E974
		public MapRogueOpChangeEvent()
		{
			this.ExecuteInMapView = true;
			this.ExecuteAfterMapViewShow = true;
		}

		// Token: 0x06037EEE RID: 229102 RVA: 0x00D407C0 File Offset: 0x00D3E9C0
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[ChangeEvent] IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06037EEF RID: 229103 RVA: 0x00D407F7 File Offset: 0x00D3E9F7
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			base.Execute(gameInfo, null);
		}

		// Token: 0x06037EF0 RID: 229104 RVA: 0x00D40804 File Offset: 0x00D3EA04
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

		// Token: 0x06037EF1 RID: 229105 RVA: 0x00D40874 File Offset: 0x00D3EA74
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

		// Token: 0x06037EF2 RID: 229106 RVA: 0x00D408DB File Offset: 0x00D3EADB
		private void FinishChangeFlow(MapRogueGameInfo gameInfo)
		{
			gameInfo.SetInteractAvailable(EMapForbiddenTag.FocusLock, true);
			base.Execute(gameInfo, null);
		}

		// Token: 0x06037EF3 RID: 229107 RVA: 0x00D408ED File Offset: 0x00D3EAED
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0401D616 RID: 120342
		private readonly float FocusTweenTime = (float)MapRogueConfig.Instance.GetGlobalParamConfig().Value.FocusTime;

		// Token: 0x0401D618 RID: 120344
		private const int EVENT_CHANGE_ANIM_TIME = 500;
	}
}
