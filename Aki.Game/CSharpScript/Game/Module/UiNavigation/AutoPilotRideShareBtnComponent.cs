using System;
using CSharpScript.Game.Module.AutoPilot;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004949 RID: 18761
	public class AutoPilotRideShareBtnComponent : LongPressWithProgressComponent
	{
		// Token: 0x06030FCB RID: 200651 RVA: 0x00B6066D File Offset: 0x00B5E86D
		public AutoPilotRideShareBtnComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FCC RID: 200652 RVA: 0x00B60676 File Offset: 0x00B5E876
		protected override float OnGetProgress()
		{
			return AutoPilotModel.Instance.RideShareBtnProgress;
		}
	}
}
