using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FE8 RID: 12264
	public class TetrisTipsLoseView : TetrisTipsBaseView
	{
		// Token: 0x0601D1A1 RID: 119201 RVA: 0x008E537E File Offset: 0x008E357E
		[NullableContext(1)]
		public TetrisTipsLoseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0601D1A2 RID: 119202 RVA: 0x008E5387 File Offset: 0x008E3587
		protected override void OnClose()
		{
			base.OnClose();
			TetrisPlayView tetrisPlayView = UiManager.Instance.GetViewByName(EUiViewName.TetrisPlayView) as TetrisPlayView;
			if (tetrisPlayView == null)
			{
				return;
			}
			tetrisPlayView.OpenLoseConfirm();
		}
	}
}
