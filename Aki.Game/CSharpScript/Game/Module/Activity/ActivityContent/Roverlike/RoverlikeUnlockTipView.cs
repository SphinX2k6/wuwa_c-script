using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006171 RID: 24945
	public class RoverlikeUnlockTipView : UiViewBase
	{
		// Token: 0x0603F0EE RID: 258286 RVA: 0x00F3CE9F File Offset: 0x00F3B09F
		[NullableContext(1)]
		public RoverlikeUnlockTipView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603F0EF RID: 258287 RVA: 0x00F3CEA8 File Offset: 0x00F3B0A8
		protected override void OnAfterShow()
		{
			base.CloseMe(null);
		}
	}
}
