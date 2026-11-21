using System;
using CSharpScript.Game.Module.AutoPilot;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038C0 RID: 14528
	public class AutoPilotRideShareBtnComponent : LongPressWithProgressComponent
	{
		// Token: 0x06025AF7 RID: 154359 RVA: 0x00A9B4B1 File Offset: 0x00A996B1
		public AutoPilotRideShareBtnComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025AF8 RID: 154360 RVA: 0x00A9B4BA File Offset: 0x00A996BA
		protected override float OnGetProgress()
		{
			return AutoPilotModel.Instance.RideShareBtnProgress;
		}
	}
}
