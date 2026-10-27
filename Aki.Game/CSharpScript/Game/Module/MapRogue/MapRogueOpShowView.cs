using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055BD RID: 21949
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpShowView : MapRogueOp
	{
		// Token: 0x170086D3 RID: 34515
		// (get) Token: 0x06037F4F RID: 229199 RVA: 0x00D41DF2 File Offset: 0x00D3FFF2
		// (set) Token: 0x06037F50 RID: 229200 RVA: 0x00D41DFA File Offset: 0x00D3FFFA
		public override int StepSize { get; set; } = 1;

		// Token: 0x06037F51 RID: 229201 RVA: 0x00D41E04 File Offset: 0x00D40004
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
			defaultInterpolatedStringHandler.AppendLiteral("[ShowView] IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			defaultInterpolatedStringHandler.AppendLiteral(" Step:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentStep);
			defaultInterpolatedStringHandler.AppendLiteral(" SubType:");
			ShowViewOp showViewOp = this.Data.ShowViewOp;
			defaultInterpolatedStringHandler.AppendFormatted<ShowViewType?>((showViewOp != null) ? new ShowViewType?(showViewOp.ShowViewType) : null);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06037F52 RID: 229202 RVA: 0x00D41E8B File Offset: 0x00D4008B
		protected override void OnUpdate(MapRogueGameInfo gameInfo)
		{
			if (this.Data.ShowViewOp.ShowViewType == ShowViewType.InstResult)
			{
				this.ExecuteInMapView = false;
			}
		}

		// Token: 0x06037F53 RID: 229203 RVA: 0x00D41EA8 File Offset: 0x00D400A8
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			ShowViewOp showViewOp = this.Data.ShowViewOp;
			if (showViewOp == null)
			{
				return;
			}
			switch (showViewOp.ShowViewType)
			{
			case ShowViewType.GridTake:
				UiManager.Instance.OpenView(EUiViewName.MapRogueGridTakeView, this.IncId, null);
				return;
			case ShowViewType.RogueResAddRole:
			case ShowViewType.PhantomEntryUnlock:
			case ShowViewType.RoleBuffUnlock:
				break;
			case ShowViewType.InstResult:
				UiManager.Instance.OpenView(EUiViewName.RogueBattleSettleView, this.Data.ShowViewOp.InstResultView, null);
				return;
			case ShowViewType.RoleBond:
				UiManager.Instance.OpenView(EUiViewName.RogueBattleRoleStarUpView, this.IncId, null);
				return;
			case ShowViewType.AddToken:
				UiManager.Instance.OpenView(EUiViewName.RogueBattleTokenSelectResultView, this.IncId, null);
				break;
			default:
				return;
			}
		}

		// Token: 0x06037F54 RID: 229204 RVA: 0x00D41F65 File Offset: 0x00D40165
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
			if (this.AutoFinish)
			{
				base.Execute(gameInfo, null);
			}
		}

		// Token: 0x06037F55 RID: 229205 RVA: 0x00D41F77 File Offset: 0x00D40177
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037F56 RID: 229206 RVA: 0x00D41F7C File Offset: 0x00D4017C
		protected override bool OnBeforeStartExecuteCheck(MapRogueGameInfo gameInfo)
		{
			ShowViewOp showViewOp = this.Data.ShowViewOp;
			return showViewOp != null && (showViewOp.ShowViewType != ShowViewType.RoleBond || !UiManager.Instance.IsViewOpen(EUiViewName.RogueBattleRoleBuffSelectView));
		}

		// Token: 0x0401D644 RID: 120388
		public bool AutoFinish = true;
	}
}
