using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050EF RID: 20719
	public class RoverlikeUnlockTipView : UiViewBase
	{
		// Token: 0x06033DAE RID: 212398 RVA: 0x00E83D73 File Offset: 0x00E81F73
		[NullableContext(1)]
		public RoverlikeUnlockTipView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033DAF RID: 212399 RVA: 0x00E83D7C File Offset: 0x00E81F7C
		protected override void OnAfterShow()
		{
			base.CloseMe(null);
		}
	}
}
