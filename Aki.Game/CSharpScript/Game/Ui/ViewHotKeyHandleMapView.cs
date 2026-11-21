using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035CF RID: 13775
	public class ViewHotKeyHandleMapView : ViewHotKeyHandle
	{
		// Token: 0x06023129 RID: 143657 RVA: 0x009F9908 File Offset: 0x009F7B08
		[NullableContext(1)]
		public ViewHotKeyHandleMapView(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x0602312A RID: 143658 RVA: 0x009F9911 File Offset: 0x009F7B11
		protected override bool SpecialConditionCheck()
		{
			return !BabelTowerModel.Instance.CheckInBattleBabelTower() && !DangoAbyssModel.Instance.CheckInAbyss() && !HonamiStoryUtil.CheckInHonamiStoryMainDungeon();
		}
	}
}
