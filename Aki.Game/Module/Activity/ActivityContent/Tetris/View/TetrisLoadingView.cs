using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FD2 RID: 12242
	public class TetrisLoadingView : UiViewBase
	{
		// Token: 0x0601D0D1 RID: 118993 RVA: 0x008E0318 File Offset: 0x008DE518
		[NullableContext(1)]
		public TetrisLoadingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0601D0D2 RID: 118994 RVA: 0x008E0321 File Offset: 0x008DE521
		protected override void OnAfterShow()
		{
			UiManager.Instance.OpenView(EUiViewName.TetrisPlayView, this.ChallengeId, delegate(bool value, int viewId)
			{
				base.CloseMe(null);
			});
		}

		// Token: 0x0601D0D3 RID: 118995 RVA: 0x008E0349 File Offset: 0x008DE549
		protected override void OnStart()
		{
			this.ChallengeId = (this.OpenParam as int?);
		}

		// Token: 0x0601D0D4 RID: 118996 RVA: 0x008E0364 File Offset: 0x008DE564
		protected override void OnBeforeDestroy()
		{
			TetrisPlayView tetrisPlayView = UiManager.Instance.GetViewByName(EUiViewName.TetrisPlayView) as TetrisPlayView;
			if (tetrisPlayView != null)
			{
				tetrisPlayView.RefreshEndlessLoading();
			}
		}

		// Token: 0x0400F4DB RID: 62683
		private int? ChallengeId;
	}
}
