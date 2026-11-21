using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005931 RID: 22833
	public sealed class SolarSchoolPrizeDrawingGameplay : SolarSchoolGameplayBase, ISolarSchoolPrizeDrawingViewHandler
	{
		// Token: 0x06038434 RID: 230452 RVA: 0x00FBB188 File Offset: 0x00FB9388
		protected override void OnGameplayStart()
		{
			PrizeActivity? prizeActivityById = SolarSchoolConfig.Instance.GetPrizeActivityById(base.GameplayId);
			if (prizeActivityById == null || prizeActivityById.Value.AwardsAmount <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 一番赏奖池为空，无法开启";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("kujiId", base.GameplayId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.MarkFailed();
				return;
			}
			SolarSchoolPrizeDrawingCenter.Instance.SetCurrentActivityId(base.GameplayId);
			base.AddState("OpenView", new Action(this.EnterOpenView));
		}

		// Token: 0x06038435 RID: 230453 RVA: 0x00FBB223 File Offset: 0x00FB9423
		protected override void OnGameplayEnd()
		{
			this.CloseView();
		}

		// Token: 0x06038436 RID: 230454 RVA: 0x00FBB22B File Offset: 0x00FB942B
		private void EnterOpenView()
		{
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolPrizeDrawingView, this, null);
		}

		// Token: 0x06038437 RID: 230455 RVA: 0x00FBB23E File Offset: 0x00FB943E
		[NullableContext(1)]
		public void OnViewReady(SolarSchoolPrizeDrawingView view)
		{
			this.View = view;
			base.FinishActionEarly();
		}

		// Token: 0x06038438 RID: 230456 RVA: 0x00FBB24D File Offset: 0x00FB944D
		public void OnViewClosed()
		{
			this.View = null;
			base.FinishGameplay();
		}

		// Token: 0x06038439 RID: 230457 RVA: 0x00FBB25C File Offset: 0x00FB945C
		private void CloseView()
		{
			if (this.View == null)
			{
				base.CloseOpeningView(EUiViewName.SolarSchoolPrizeDrawingView);
				return;
			}
			UiViewBase view = this.View;
			this.View = null;
			view.CloseMe(null);
		}

		// Token: 0x0401DA18 RID: 121368
		[Nullable(2)]
		private SolarSchoolPrizeDrawingView View;

		// Token: 0x0200B4EA RID: 46314
		private static class GameplayState
		{
			// Token: 0x04037EFD RID: 229117
			[Nullable(1)]
			public const string OpenView = "OpenView";
		}
	}
}
