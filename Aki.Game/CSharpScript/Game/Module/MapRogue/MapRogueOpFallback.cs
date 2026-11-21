using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200458A RID: 17802
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpFallback : MapRogueOp
	{
		// Token: 0x17005A8B RID: 23179
		// (get) Token: 0x0602CDF2 RID: 183794 RVA: 0x00C8E637 File Offset: 0x00C8C837
		// (set) Token: 0x0602CDF3 RID: 183795 RVA: 0x00C8E63F File Offset: 0x00C8C83F
		public override int StepSize { get; set; } = 1;

		// Token: 0x0602CDF4 RID: 183796 RVA: 0x00C8E648 File Offset: 0x00C8C848
		public MapRogueOpFallback()
		{
			this.ExecuteInMapView = false;
		}

		// Token: 0x0602CDF5 RID: 183797 RVA: 0x00C8E668 File Offset: 0x00C8C868
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[Fallback] IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			defaultInterpolatedStringHandler.AppendLiteral(" Step:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentStep);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602CDF6 RID: 183798 RVA: 0x00C8E6B8 File Offset: 0x00C8C8B8
		protected override void OnUpdate(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CDF7 RID: 183799 RVA: 0x00C8E6BA File Offset: 0x00C8C8BA
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			UiManager.Instance.OpenView(EUiViewName.RogueBattleFallbackView, this.IncId, null);
		}

		// Token: 0x0602CDF8 RID: 183800 RVA: 0x00C8E6D7 File Offset: 0x00C8C8D7
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
			if (this.AutoFinish)
			{
				base.Execute(gameInfo, null);
			}
		}

		// Token: 0x0602CDF9 RID: 183801 RVA: 0x00C8E6E9 File Offset: 0x00C8C8E9
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x0602CDFA RID: 183802 RVA: 0x00C8E6EB File Offset: 0x00C8C8EB
		protected override void OnDelete(MapRogueGameInfo gameInfo)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.RogueBattleFallbackView))
			{
				UiManager.Instance.CloseView(EUiViewName.RogueBattleFallbackView, null);
			}
		}

		// Token: 0x040180A5 RID: 98469
		public bool AutoFinish = true;
	}
}
