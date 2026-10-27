using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055B5 RID: 21941
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpGotoLevelPlay : MapRogueOp
	{
		// Token: 0x170086C5 RID: 34501
		// (get) Token: 0x06037EFD RID: 229117 RVA: 0x00D409C6 File Offset: 0x00D3EBC6
		// (set) Token: 0x06037EFE RID: 229118 RVA: 0x00D409CE File Offset: 0x00D3EBCE
		public override int StepSize { get; set; } = 1;

		// Token: 0x06037F00 RID: 229120 RVA: 0x00D409F0 File Offset: 0x00D3EBF0
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[LevelPlay] IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			defaultInterpolatedStringHandler.AppendLiteral(" Step:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentStep);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06037F01 RID: 229121 RVA: 0x00D40A40 File Offset: 0x00D3EC40
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

		// Token: 0x06037F02 RID: 229122 RVA: 0x00D40AAC File Offset: 0x00D3ECAC
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
			this.OnRogueSubLevelNotify(this.Data.RogueGotoLevelPlayOp.RogueResSubLevelData, gameInfo);
		}

		// Token: 0x06037F03 RID: 229123 RVA: 0x00D40AC5 File Offset: 0x00D3ECC5
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037F04 RID: 229124 RVA: 0x00D40AC8 File Offset: 0x00D3ECC8
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

		// Token: 0x0401D61C RID: 120348
		public int SelectIndex = -1;
	}
}
