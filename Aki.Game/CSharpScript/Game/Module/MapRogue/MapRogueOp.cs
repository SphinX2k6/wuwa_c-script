using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004588 RID: 17800
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MapRogueOp
	{
		// Token: 0x17005A86 RID: 23174
		// (get) Token: 0x0602CDD2 RID: 183762
		// (set) Token: 0x0602CDD3 RID: 183763
		public abstract int StepSize { get; set; }

		// Token: 0x17005A87 RID: 23175
		// (get) Token: 0x0602CDD4 RID: 183764 RVA: 0x00C8E2B4 File Offset: 0x00C8C4B4
		public RogueResOpType Type
		{
			get
			{
				return this.Data.RogueResOpType;
			}
		}

		// Token: 0x0602CDD5 RID: 183765 RVA: 0x00C8E2C1 File Offset: 0x00C8C4C1
		public void Update(RogueResOpData data, MapRogueGameInfo gameInfo)
		{
			this.Data = data;
			this.IncId = this.Data.IncId;
			this.OnUpdate(gameInfo);
		}

		// Token: 0x0602CDD6 RID: 183766 RVA: 0x00C8E2E4 File Offset: 0x00C8C4E4
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

		// Token: 0x17005A88 RID: 23176
		// (get) Token: 0x0602CDD7 RID: 183767 RVA: 0x00C8E352 File Offset: 0x00C8C552
		public bool IsFinished
		{
			get
			{
				return this.CurrentStep > this.StepSize;
			}
		}

		// Token: 0x17005A89 RID: 23177
		// (get) Token: 0x0602CDD8 RID: 183768 RVA: 0x00C8E362 File Offset: 0x00C8C562
		public bool IsStartExecute
		{
			get
			{
				return this.CurrentStep >= 0;
			}
		}

		// Token: 0x0602CDD9 RID: 183769 RVA: 0x00C8E370 File Offset: 0x00C8C570
		public void BattleStateUpdate(bool inBattle, MapRogueGameInfo gameInfo)
		{
			this.OnBattleStateUpdate(inBattle, gameInfo);
		}

		// Token: 0x0602CDDA RID: 183770 RVA: 0x00C8E37A File Offset: 0x00C8C57A
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

		// Token: 0x0602CDDB RID: 183771 RVA: 0x00C8E398 File Offset: 0x00C8C598
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

		// Token: 0x0602CDDC RID: 183772 RVA: 0x00C8E3E4 File Offset: 0x00C8C5E4
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

		// Token: 0x0602CDDD RID: 183773 RVA: 0x00C8E430 File Offset: 0x00C8C630
		public void Delete(MapRogueGameInfo gameInfo)
		{
			this.OnDelete(gameInfo);
		}

		// Token: 0x0602CDDE RID: 183774 RVA: 0x00C8E439 File Offset: 0x00C8C639
		private void Finish(MapRogueGameInfo gameInfo, [Nullable(2)] Action<bool> callback = null)
		{
			this.OnFinish(gameInfo);
			this.ExecuteOp(callback);
		}

		// Token: 0x0602CDDF RID: 183775 RVA: 0x00C8E449 File Offset: 0x00C8C649
		[NullableContext(2)]
		protected void ExecuteOp(Action<bool> callback = null)
		{
			MapRogueController.Instance.RequestExecuteOp(this.IncId, this.OpExecuteClientId, callback);
		}

		// Token: 0x0602CDE0 RID: 183776 RVA: 0x00C8E462 File Offset: 0x00C8C662
		protected void ExecuteOpMultiSelect(List<int> ids, [Nullable(2)] Action<bool> callback = null)
		{
			MapRogueController.Instance.RequestExecuteOpMultiSelect(this.IncId, ids, callback);
		}

		// Token: 0x0602CDE1 RID: 183777 RVA: 0x00C8E476 File Offset: 0x00C8C676
		protected virtual void OnUpdate(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CDE2 RID: 183778 RVA: 0x00C8E478 File Offset: 0x00C8C678
		protected virtual void OnBattleStateUpdate(bool inBattle, MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CDE3 RID: 183779 RVA: 0x00C8E47A File Offset: 0x00C8C67A
		protected virtual void OnStartExecute(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CDE4 RID: 183780 RVA: 0x00C8E47C File Offset: 0x00C8C67C
		protected virtual void OnExecute(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CDE5 RID: 183781 RVA: 0x00C8E47E File Offset: 0x00C8C67E
		protected virtual void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CDE6 RID: 183782 RVA: 0x00C8E480 File Offset: 0x00C8C680
		protected virtual void OnDelete(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CDE7 RID: 183783 RVA: 0x00C8E482 File Offset: 0x00C8C682
		protected virtual bool OnBeforeStartExecuteCheck(MapRogueGameInfo gameInfo)
		{
			return true;
		}

		// Token: 0x0401809A RID: 98458
		public int IncId = -1;

		// Token: 0x0401809B RID: 98459
		public RogueResOpData Data;

		// Token: 0x0401809C RID: 98460
		public bool ExecuteInMapView = true;

		// Token: 0x0401809D RID: 98461
		public bool ExecuteAfterMapViewShow;

		// Token: 0x0401809E RID: 98462
		protected int CurrentStep = -1;

		// Token: 0x0401809F RID: 98463
		public int OpExecuteClientId;

		// Token: 0x040180A0 RID: 98464
		public ERogueOpPriority Priority = ERogueOpPriority.Normal;
	}
}
