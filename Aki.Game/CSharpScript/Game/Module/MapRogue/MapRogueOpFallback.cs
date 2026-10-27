using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055B4 RID: 21940
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueOpFallback : MapRogueOp
	{
		// Token: 0x170086C4 RID: 34500
		// (get) Token: 0x06037EF4 RID: 229108 RVA: 0x00D408EF File Offset: 0x00D3EAEF
		// (set) Token: 0x06037EF5 RID: 229109 RVA: 0x00D408F7 File Offset: 0x00D3EAF7
		public override int StepSize { get; set; } = 1;

		// Token: 0x06037EF6 RID: 229110 RVA: 0x00D40900 File Offset: 0x00D3EB00
		public MapRogueOpFallback()
		{
			this.ExecuteInMapView = false;
		}

		// Token: 0x06037EF7 RID: 229111 RVA: 0x00D40920 File Offset: 0x00D3EB20
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[Fallback] IncId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
			defaultInterpolatedStringHandler.AppendLiteral(" Step:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentStep);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06037EF8 RID: 229112 RVA: 0x00D40970 File Offset: 0x00D3EB70
		protected override void OnUpdate(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037EF9 RID: 229113 RVA: 0x00D40972 File Offset: 0x00D3EB72
		protected override void OnStartExecute(MapRogueGameInfo gameInfo)
		{
			UiManager.Instance.OpenView(EUiViewName.RogueBattleFallbackView, this.IncId, null);
		}

		// Token: 0x06037EFA RID: 229114 RVA: 0x00D4098F File Offset: 0x00D3EB8F
		protected override void OnExecute(MapRogueGameInfo gameInfo)
		{
			if (this.AutoFinish)
			{
				base.Execute(gameInfo, null);
			}
		}

		// Token: 0x06037EFB RID: 229115 RVA: 0x00D409A1 File Offset: 0x00D3EBA1
		protected override void OnFinish(MapRogueGameInfo gameInfo)
		{
		}

		// Token: 0x06037EFC RID: 229116 RVA: 0x00D409A3 File Offset: 0x00D3EBA3
		protected override void OnDelete(MapRogueGameInfo gameInfo)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.RogueBattleFallbackView))
			{
				UiManager.Instance.CloseView(EUiViewName.RogueBattleFallbackView, null);
			}
		}

		// Token: 0x0401D61A RID: 120346
		public bool AutoFinish = true;
	}
}
