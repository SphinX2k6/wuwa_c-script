using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200469E RID: 18078
	public class ViewHotKeyHandleMapView : ViewHotKeyHandle
	{
		// Token: 0x0602E9DD RID: 190941 RVA: 0x00ACB034 File Offset: 0x00AC9234
		[NullableContext(1)]
		public ViewHotKeyHandleMapView(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x0602E9DE RID: 190942 RVA: 0x00ACB03D File Offset: 0x00AC923D
		protected override bool SpecialConditionCheck()
		{
			return !BabelTowerModel.Instance.CheckInBattleBabelTower() && !DangoAbyssModel.Instance.CheckInAbyss() && !HonamiStoryUtil.CheckInHonamiStoryMainDungeon();
		}
	}
}
