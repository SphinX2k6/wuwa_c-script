using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004693 RID: 18067
	[NullableContext(1)]
	[Nullable(0)]
	public class axisMappings
	{
		// Token: 0x0602E9B6 RID: 190902 RVA: 0x00ACAAA1 File Offset: 0x00AC8CA1
		public static bool HasField(string fieldName)
		{
			return typeof(axisMappings).GetField(fieldName) != null;
		}

		// Token: 0x04019606 RID: 103942
		public const string LookUp = "LookUp";

		// Token: 0x04019607 RID: 103943
		public const string LookUpRate = "LookUpRate";

		// Token: 0x04019608 RID: 103944
		public const string MoveForward = "MoveForward";

		// Token: 0x04019609 RID: 103945
		public const string MoveRight = "MoveRight";

		// Token: 0x0401960A RID: 103946
		public const string Turn = "Turn";

		// Token: 0x0401960B RID: 103947
		public const string Zoom = "Zoom";

		// Token: 0x0401960C RID: 103948
		public const string WheelAxis = "WheelAxis";

		// Token: 0x0401960D RID: 103949
		public const string UiIncrease = "UiIncrease";

		// Token: 0x0401960E RID: 103950
		public const string UiReduce = "UiReduce";

		// Token: 0x0401960F RID: 103951
		public const string UiIncrease2 = "UiIncrease2";

		// Token: 0x04019610 RID: 103952
		public const string UiReduce2 = "UiReduce2";

		// Token: 0x04019611 RID: 103953
		public const string UiIncrease3 = "UiIncrease3";

		// Token: 0x04019612 RID: 103954
		public const string UiReduce3 = "UiReduce3";

		// Token: 0x04019613 RID: 103955
		public const string UiMoveForward = "UiMoveForward";

		// Token: 0x04019614 RID: 103956
		public const string UiMoveRight = "UiMoveRight";

		// Token: 0x04019615 RID: 103957
		public const string NavigationTopDown = "NavigationTopDown";

		// Token: 0x04019616 RID: 103958
		public const string NavigationLeftRight = "NavigationLeftRight";

		// Token: 0x04019617 RID: 103959
		public const string UiScroll1 = "UiScroll1";

		// Token: 0x04019618 RID: 103960
		public const string UiScroll2 = "UiScroll2";

		// Token: 0x04019619 RID: 103961
		public const string UiLookUp = "UiLookUp";

		// Token: 0x0401961A RID: 103962
		public const string UiTurn = "UiTurn";

		// Token: 0x0401961B RID: 103963
		public const string UiLookInOut = "UiLookInOut";

		// Token: 0x0401961C RID: 103964
		public const string UiCamRotate = "UiCamRotate";

		// Token: 0x0401961D RID: 103965
		public const string UiCamRotate2 = "UiCamRotate2";

		// Token: 0x0401961E RID: 103966
		public const string UiWheelAxis = "UiWheelAxis";

		// Token: 0x0401961F RID: 103967
		public const string Ui左摇杆 = "Ui左摇杆";

		// Token: 0x04019620 RID: 103968
		public const string Ui右摇杆 = "Ui右摇杆";

		// Token: 0x04019621 RID: 103969
		public const string NextGroup = "NextGroup";

		// Token: 0x04019622 RID: 103970
		public const string PrevGroup = "PrevGroup";

		// Token: 0x04019623 RID: 103971
		public const string NextGroup2 = "NextGroup2";

		// Token: 0x04019624 RID: 103972
		public const string MapIncrease = "MapIncrease";

		// Token: 0x04019625 RID: 103973
		public const string MapReduce = "MapReduce";

		// Token: 0x04019626 RID: 103974
		public const string MapIncrease2 = "MapIncrease2";

		// Token: 0x04019627 RID: 103975
		public const string MapReduce2 = "MapReduce2";

		// Token: 0x04019628 RID: 103976
		public const string MapMoveForward = "MapMoveForward";

		// Token: 0x04019629 RID: 103977
		public const string MapMoveRight = "MapMoveRight";

		// Token: 0x0401962A RID: 103978
		public const string MapMoveForward2 = "MapMoveForward2";

		// Token: 0x0401962B RID: 103979
		public const string MapMoveRight2 = "MapMoveRight2";

		// Token: 0x0401962C RID: 103980
		public const string MouseMove = "MouseMove";

		// Token: 0x0401962D RID: 103981
		public const string RoleLookUp = "RoleLookUp";

		// Token: 0x0401962E RID: 103982
		public const string RoleTurn = "RoleTurn";

		// Token: 0x0401962F RID: 103983
		public const string RoleIncrease = "RoleIncrease";

		// Token: 0x04019630 RID: 103984
		public const string RoleReduce = "RoleReduce";

		// Token: 0x04019631 RID: 103985
		public const string TrapDefenseMoveForward = "TrapDefenseMoveForward";

		// Token: 0x04019632 RID: 103986
		public const string TrapDefenseMoveRight = "TrapDefenseMoveRight";

		// Token: 0x04019633 RID: 103987
		public const string TrapDefenseZoom = "TrapDefenseZoom";

		// Token: 0x04019634 RID: 103988
		public const string MotorMoveForward = "MotorMoveForward";

		// Token: 0x04019635 RID: 103989
		public const string MotorMoveRight = "MotorMoveRight";

		// Token: 0x04019636 RID: 103990
		public const string MotorSoarMoveForward = "MotorSoarMoveForward";

		// Token: 0x04019637 RID: 103991
		public const string PhotoMoveForward = "PhotoMoveForward";

		// Token: 0x04019638 RID: 103992
		public const string PhotoMoveRight = "PhotoMoveRight";

		// Token: 0x04019639 RID: 103993
		public const string PhotoMoveUp = "PhotoMoveUp";

		// Token: 0x0401963A RID: 103994
		public const string PhotoPitch = "PhotoPitch";

		// Token: 0x0401963B RID: 103995
		public const string PhotoYaw = "PhotoYaw";

		// Token: 0x0401963C RID: 103996
		public const string PhotoRoll = "PhotoRoll";

		// Token: 0x0401963D RID: 103997
		public const string PhotoFov = "PhotoFov";

		// Token: 0x0401963E RID: 103998
		public const string CameraFocusHor = "CameraFocusHor";

		// Token: 0x0401963F RID: 103999
		public const string CameraFocusVer = "CameraFocusVer";
	}
}
