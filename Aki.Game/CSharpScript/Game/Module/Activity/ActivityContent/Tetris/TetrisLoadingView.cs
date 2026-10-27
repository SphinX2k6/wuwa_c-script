using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x0200600B RID: 24587
	public class TetrisLoadingView : UiViewBase
	{
		// Token: 0x0603E44A RID: 255050 RVA: 0x00F08E24 File Offset: 0x00F07024
		[NullableContext(1)]
		public TetrisLoadingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E44B RID: 255051 RVA: 0x00F08E2D File Offset: 0x00F0702D
		protected override void OnAfterShow()
		{
			UiManager.Instance.OpenView(EUiViewName.TetrisPlayView, this.ChallengeId, delegate(bool value, int viewId)
			{
				base.CloseMe(null);
			});
		}

		// Token: 0x0603E44C RID: 255052 RVA: 0x00F08E55 File Offset: 0x00F07055
		protected override void OnStart()
		{
			this.ChallengeId = (this.OpenParam as int?);
		}

		// Token: 0x0603E44D RID: 255053 RVA: 0x00F08E70 File Offset: 0x00F07070
		protected override void OnBeforeDestroy()
		{
			TetrisPlayView tetrisPlayView = UiManager.Instance.GetViewByName(EUiViewName.TetrisPlayView) as TetrisPlayView;
			if (tetrisPlayView != null)
			{
				tetrisPlayView.RefreshEndlessLoading();
			}
		}

		// Token: 0x0402088C RID: 133260
		private int? ChallengeId;
	}
}
