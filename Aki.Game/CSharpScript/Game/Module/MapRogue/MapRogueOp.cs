using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055B2 RID: 21938
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MapRogueOp
	{
		// Token: 0x170086BF RID: 34495
		// (get) Token: 0x06037ED4 RID: 229076
		// (set) Token: 0x06037ED5 RID: 229077
		public abstract int StepSize { get; set; }

		// Token: 0x170086C0 RID: 34496
		// (get) Token: 0x06037ED6 RID: 229078 RVA: 0x00D4056C File Offset: 0x00D3E76C
		public RogueResOpType Type
		{
			get
			{
				return this.Data.RogueResOpType;
			}
		}

		// Token: 0x06037ED7 RID: 229079 RVA: 0x00D40579 File Offset: 0x00D3E779
		public void Update(RogueResOpData data, MapRogueGameInfo gameInfo)
		{
			this.Data = data;
			this.IncId = this.Data.IncId;
			this.OnUpdate(gameInfo);
		}

		// Token: 0x06037ED8 RID: 229080 RVA: 0x00D4059C File Offset: 0x00D3E79C
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 3);
			defaultInterpolatedStringHandler.AppendLiteral("IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			defaultInterpolatedStringHandler.AppendLiteral(" Type:");
			defaultInterpolatedStringHandler.AppendFormatted<RogueResOpType>(this.Data.RogueResOpType);
			defaultInterpolatedStringHandler.AppendLiteral(" Step:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentStep);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x170086C1 RID: 34497
		// (get) Token: 0x06037ED9 RID: 229081 RVA: 0x00D4060A File Offset: 0x00D3E80A
		public bool IsFinished
		{
			get
			{
				return this.CurrentStep > this.StepSize;
			}
		}

		// Token: 0x170086C2 RID: 34498
		// (get) Token: 0x06037EDA RID: 229082 RVA: 0x00D4061A File Offset: 0x00D3E81A
		public bool IsStartExecute
		{
			get
			{
				return this.CurrentStep >= 0;
			}
		}

		// Token: 0x06037EDB RID: 229083 RVA: 0x00D40628 File Offset: 0x00D3E828
		public void BattleStateUpdate(bool inBattle, MapRogueGameInfo gameInfo)
		{
			this.OnBattleStateUpdate(inBattle, gameInfo);
		}

		// Token: 0x06037EDC RID: 229084 RVA: 0x00D40632 File Offset: 0x00D3E832
		public void StartExecute(MapRogueGameInfo gameInfo)
		{
			if (!this.OnBeforeStartExecuteCheck(gameInfo))
			{
				return;
			}
			if (this.CurrentStep != -1)
			{
				return;
			}
			this.StartExecuteAsync(gameInfo);
		}

		// Token: 0x06037EDD RID: 229085 RVA: 0x00D40650 File Offset: 0x00D3E850
		private UniTask StartExecuteAsync(MapRogueGameInfo gameInfo)
		{
			MapRogueOp.<StartExecuteAsync>d__20 <StartExecuteAsync>d__;
			<StartExecuteAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartExecuteAsync>d__.<>4__this = this;
			<StartExecuteAsync>d__.gameInfo = gameInfo;
			<StartExecuteAsync>d__.<>1__state = -1;
			<StartExecuteAsync>d__.<>t__builder.Start<MapRogueOp.<StartExecuteAsync>d__20>(ref <StartExecuteAsync>d__);
			return <StartExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037EDE RID: 229086 RVA: 0x00D4069C File Offset: 0x00D3E89C
		public void Execute(MapRogueGameInfo gameInfo, [Nullable(2)] Action<bool> callback = null)
		{
			if (this.IsFinished)
			{
				return;
			}
			this.CurrentStep++;
			if (this.CurrentStep > this.StepSize)
			{
				this.Finish(gameInfo, callback);
				return;
			}
			this.OnExecute(gameInfo);
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x06037EDF RID: 229087 RVA: 0x00D406E8 File Offset: 0x00D3E8E8
		public void Delete(MapRogueGameInfo gameInfo)
		{
			this.OnDelete(gameInfo);
		}

		// Token: 0x06037EE0 RID: 229088 RVA: 0x00D406F1 File Offset: 0x00D3E8F1
		private void Finish(MapRogueGameInfo gameInfo, [Nullable(2)] Action<bool> callback = null)
		{
			this.OnFinish(gameInfo);
			this.ExecuteOp(callback);
		}

		// Token: 0x06037EE1 RID: 229089 RVA: 0x00D40701 File Offset: 0x00D3E901
		[NullableContext(2)]
		protected void ExecuteOp(Action<bool> callback = null)
		{
			MapRogueController.Instance.RequestExecuteOp(this.IncId, this.OpExecuteClientId, callback);
		}

		// Token: 0x06037EE2 RID: 229090 RVA: 0x00D4071A File Offset: 0x00D3E91A
		protected void ExecuteOpMultiSelect(List<int> ids, [Nullable(2)] Action<bool> callback = null)
		{
			MapRogueController.Instance.RequestExecuteOpMultiSelect(this.IncId, ids, callback);
		}

		// Token: 0x06037EE3 RID: 229091 RVA: 0x00D4072E File Offset: 0x00D3E92E
		protected virtual void OnUpdate(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037EE4 RID: 229092 RVA: 0x00D40730 File Offset: 0x00D3E930
		protected virtual void OnBattleStateUpdate(bool inBattle, MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037EE5 RID: 229093 RVA: 0x00D40732 File Offset: 0x00D3E932
		protected virtual void OnStartExecute(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037EE6 RID: 229094 RVA: 0x00D40734 File Offset: 0x00D3E934
		protected virtual void OnExecute(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037EE7 RID: 229095 RVA: 0x00D40736 File Offset: 0x00D3E936
		protected virtual void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037EE8 RID: 229096 RVA: 0x00D40738 File Offset: 0x00D3E938
		protected virtual void OnDelete(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037EE9 RID: 229097 RVA: 0x00D4073A File Offset: 0x00D3E93A
		protected virtual bool OnBeforeStartExecuteCheck(MapRogueGameInfo gameInfo)
		{
			return true;
		}

		// Token: 0x0401D60F RID: 120335
		public int IncId = -1;

		// Token: 0x0401D610 RID: 120336
		public RogueResOpData Data;

		// Token: 0x0401D611 RID: 120337
		public bool ExecuteInMapView = true;

		// Token: 0x0401D612 RID: 120338
		public bool ExecuteAfterMapViewShow;

		// Token: 0x0401D613 RID: 120339
		protected int CurrentStep = -1;

		// Token: 0x0401D614 RID: 120340
		public int OpExecuteClientId;

		// Token: 0x0401D615 RID: 120341
		public ERogueOpPriority Priority = ERogueOpPriority.Normal;
	}
}
