using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006024 RID: 24612
	public class TetrisTipsLoseView : TetrisTipsBaseView
	{
		// Token: 0x0603E4D9 RID: 255193 RVA: 0x00F0C416 File Offset: 0x00F0A616
		[NullableContext(1)]
		public TetrisTipsLoseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E4DA RID: 255194 RVA: 0x00F0C420 File Offset: 0x00F0A620
		protected override void OnClose()
		{
			base.OnClose();
			TetrisPlayView tetrisPlayView = UiManager.Instance.GetViewByName(EUiViewName.TetrisPlayView) as TetrisPlayView;
			if (tetrisPlayView != null)
			{
				tetrisPlayView.OpenLoseConfirm();
			}
		}
	}
}
