using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006020 RID: 24608
	public class TetrisTipsBaseView : UiViewBase
	{
		// Token: 0x0603E4C9 RID: 255177 RVA: 0x00F0C1E3 File Offset: 0x00F0A3E3
		[NullableContext(1)]
		public TetrisTipsBaseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E4CA RID: 255178 RVA: 0x00F0C1EC File Offset: 0x00F0A3EC
		protected override void OnFinishShow()
		{
			this.OnClose();
		}

		// Token: 0x0603E4CB RID: 255179 RVA: 0x00F0C1F4 File Offset: 0x00F0A3F4
		protected virtual void OnClose()
		{
			base.CloseMe(null);
		}
	}
}
