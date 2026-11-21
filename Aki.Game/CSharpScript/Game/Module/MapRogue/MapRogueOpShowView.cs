using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004593 RID: 17811
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpShowView : MapRogueOp
	{
		// Token: 0x17005A9A RID: 23194
		// (get) Token: 0x0602CE4D RID: 183885 RVA: 0x00C8FB3A File Offset: 0x00C8DD3A
		// (set) Token: 0x0602CE4E RID: 183886 RVA: 0x00C8FB42 File Offset: 0x00C8DD42
		public override int StepSize { get; set; } = 1;

		// Token: 0x0602CE4F RID: 183887 RVA: 0x00C8FB4C File Offset: 0x00C8DD4C
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

		// Token: 0x0602CE50 RID: 183888 RVA: 0x00C8FBD3 File Offset: 0x00C8DDD3
		protected override void OnUpdate(MapRogueGameInfo gameInfo)
		{
			if (this.Data.ShowViewOp.ShowViewType == ShowViewType.InstResult)
			{
				this.ExecuteInMapView = false;
			}
		}

		// Token: 0x0602CE51 RID: 183889 RVA: 0x00C8FBF0 File Offset: 0x00C8DDF0
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

		// Token: 0x0602CE52 RID: 183890 RVA: 0x00C8FCAD File Offset: 0x00C8DEAD
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
			if (this.AutoFinish)
			{
				base.Execute(gameInfo, null);
			}
		}

		// Token: 0x0602CE53 RID: 183891 RVA: 0x00C8FCBF File Offset: 0x00C8DEBF
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CE54 RID: 183892 RVA: 0x00C8FCC4 File Offset: 0x00C8DEC4
		protected override bool OnBeforeStartExecuteCheck(MapRogueGameInfo gameInfo)
		{
			ShowViewOp showViewOp = this.Data.ShowViewOp;
			return showViewOp != null && (showViewOp.ShowViewType != ShowViewType.RoleBond || !UiManager.Instance.IsViewOpen(EUiViewName.RogueBattleRoleBuffSelectView));
		}

		// Token: 0x040180CF RID: 98511
		public bool AutoFinish = true;
	}
}
