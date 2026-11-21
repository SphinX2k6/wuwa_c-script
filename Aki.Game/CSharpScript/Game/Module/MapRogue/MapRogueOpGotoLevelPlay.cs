using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200458B RID: 17803
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpGotoLevelPlay : MapRogueOp
	{
		// Token: 0x17005A8C RID: 23180
		// (get) Token: 0x0602CDFB RID: 183803 RVA: 0x00C8E70E File Offset: 0x00C8C90E
		// (set) Token: 0x0602CDFC RID: 183804 RVA: 0x00C8E716 File Offset: 0x00C8C916
		public override int StepSize { get; set; } = 1;

		// Token: 0x0602CDFE RID: 183806 RVA: 0x00C8E738 File Offset: 0x00C8C938
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[LevelPlay] IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			defaultInterpolatedStringHandler.AppendLiteral(" Step:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentStep);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602CDFF RID: 183807 RVA: 0x00C8E788 File Offset: 0x00C8C988
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			if (this.Data.RogueGotoLevelPlayOp.CanSkipBattle && gameInfo.IsSkipBattle)
			{
				this.OpExecuteClientId = 2;
				base.ExecuteOp(null);
				return;
			}
			if (this.Data.RogueGotoLevelPlayOp.IsFormation)
			{
				UiManager.Instance.OpenView(EUiViewName.RogueBattleTeamEditView, this.IncId, null);
				return;
			}
			base.Execute(gameInfo, null);
		}

		// Token: 0x0602CE00 RID: 183808 RVA: 0x00C8E7F4 File Offset: 0x00C8C9F4
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
			this.OnRogueSubLevelNotify(this.Data.RogueGotoLevelPlayOp.RogueResSubLevelData, gameInfo);
		}

		// Token: 0x0602CE01 RID: 183809 RVA: 0x00C8E80D File Offset: 0x00C8CA0D
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CE02 RID: 183810 RVA: 0x00C8E810 File Offset: 0x00C8CA10
		private void OnRogueSubLevelNotify(RogueResSubLevelData notify, MapRogueGameInfo gameInfo)
		{
			MapRogueOpGotoLevelPlay.<>c__DisplayClass10_0 CS$<>8__locals1 = new MapRogueOpGotoLevelPlay.<>c__DisplayClass10_0();
			CS$<>8__locals1.notify = notify;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.gameInfo = gameInfo;
			AsyncTask task = new AsyncTask("RogueBattleSubLevelNotify", delegate()
			{
				MapRogueOpGotoLevelPlay.<>c__DisplayClass10_0.<<OnRogueSubLevelNotify>b__0>d <<OnRogueSubLevelNotify>b__0>d;
				<<OnRogueSubLevelNotify>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
				<<OnRogueSubLevelNotify>b__0>d.<>4__this = CS$<>8__locals1;
				<<OnRogueSubLevelNotify>b__0>d.<>1__state = -1;
				<<OnRogueSubLevelNotify>b__0>d.<>t__builder.Start<MapRogueOpGotoLevelPlay.<>c__DisplayClass10_0.<<OnRogueSubLevelNotify>b__0>d>(ref <<OnRogueSubLevelNotify>b__0>d);
				return <<OnRogueSubLevelNotify>b__0>d.<>t__builder.Task;
			}, null, null, null);
			TaskSystem.Instance.AddTask(task);
			TaskSystem.Instance.Run();
		}

		// Token: 0x040180A7 RID: 98471
		public int SelectIndex = -1;
	}
}
