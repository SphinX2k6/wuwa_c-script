using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035C4 RID: 13764
	[NullableContext(1)]
	[Nullable(0)]
	public class axisMappings
	{
		// Token: 0x06023101 RID: 143617 RVA: 0x009F90B3 File Offset: 0x009F72B3
		public static bool HasField(string axisName)
		{
			return axisMappings.AxisMappingValues.Contains(axisName);
		}

		// Token: 0x04013CAA RID: 81066
		public const string LookUp = "LookUp";

		// Token: 0x04013CAB RID: 81067
		public const string LookUpRate = "LookUpRate";

		// Token: 0x04013CAC RID: 81068
		public const string MoveForward = "MoveForward";

		// Token: 0x04013CAD RID: 81069
		public const string MoveRight = "MoveRight";

		// Token: 0x04013CAE RID: 81070
		public const string Turn = "Turn";

		// Token: 0x04013CAF RID: 81071
		public const string Zoom = "Zoom";

		// Token: 0x04013CB0 RID: 81072
		public const string WheelAxis = "WheelAxis";

		// Token: 0x04013CB1 RID: 81073
		public const string UiIncrease = "UiIncrease";

		// Token: 0x04013CB2 RID: 81074
		public const string UiReduce = "UiReduce";

		// Token: 0x04013CB3 RID: 81075
		public const string UiIncrease2 = "UiIncrease2";

		// Token: 0x04013CB4 RID: 81076
		public const string UiReduce2 = "UiReduce2";

		// Token: 0x04013CB5 RID: 81077
		public const string UiIncrease3 = "UiIncrease3";

		// Token: 0x04013CB6 RID: 81078
		public const string UiReduce3 = "UiReduce3";

		// Token: 0x04013CB7 RID: 81079
		public const string UiMoveForward = "UiMoveForward";

		// Token: 0x04013CB8 RID: 81080
		public const string UiMoveRight = "UiMoveRight";

		// Token: 0x04013CB9 RID: 81081
		public const string NavigationTopDown = "NavigationTopDown";

		// Token: 0x04013CBA RID: 81082
		public const string NavigationLeftRight = "NavigationLeftRight";

		// Token: 0x04013CBB RID: 81083
		public const string UiScroll1 = "UiScroll1";

		// Token: 0x04013CBC RID: 81084
		public const string UiScroll2 = "UiScroll2";

		// Token: 0x04013CBD RID: 81085
		public const string UiLookUp = "UiLookUp";

		// Token: 0x04013CBE RID: 81086
		public const string UiTurn = "UiTurn";

		// Token: 0x04013CBF RID: 81087
		public const string UiLookInOut = "UiLookInOut";

		// Token: 0x04013CC0 RID: 81088
		public const string UiCamRotate = "UiCamRotate";

		// Token: 0x04013CC1 RID: 81089
		public const string UiCamRotate2 = "UiCamRotate2";

		// Token: 0x04013CC2 RID: 81090
		public const string UiWheelAxis = "UiWheelAxis";

		// Token: 0x04013CC3 RID: 81091
		public const string Ui左摇杆 = "Ui左摇杆";

		// Token: 0x04013CC4 RID: 81092
		public const string Ui右摇杆 = "Ui右摇杆";

		// Token: 0x04013CC5 RID: 81093
		public const string NextGroup = "NextGroup";

		// Token: 0x04013CC6 RID: 81094
		public const string PrevGroup = "PrevGroup";

		// Token: 0x04013CC7 RID: 81095
		public const string NextGroup2 = "NextGroup2";

		// Token: 0x04013CC8 RID: 81096
		public const string MapIncrease = "MapIncrease";

		// Token: 0x04013CC9 RID: 81097
		public const string MapReduce = "MapReduce";

		// Token: 0x04013CCA RID: 81098
		public const string MapIncrease2 = "MapIncrease2";

		// Token: 0x04013CCB RID: 81099
		public const string MapReduce2 = "MapReduce2";

		// Token: 0x04013CCC RID: 81100
		public const string MapMoveForward = "MapMoveForward";

		// Token: 0x04013CCD RID: 81101
		public const string MapMoveRight = "MapMoveRight";

		// Token: 0x04013CCE RID: 81102
		public const string MapMoveForward2 = "MapMoveForward2";

		// Token: 0x04013CCF RID: 81103
		public const string MapMoveRight2 = "MapMoveRight2";

		// Token: 0x04013CD0 RID: 81104
		public const string MouseMove = "MouseMove";

		// Token: 0x04013CD1 RID: 81105
		public const string RoleLookUp = "RoleLookUp";

		// Token: 0x04013CD2 RID: 81106
		public const string RoleTurn = "RoleTurn";

		// Token: 0x04013CD3 RID: 81107
		public const string RoleIncrease = "RoleIncrease";

		// Token: 0x04013CD4 RID: 81108
		public const string RoleReduce = "RoleReduce";

		// Token: 0x04013CD5 RID: 81109
		public const string TrapDefenseMoveForward = "TrapDefenseMoveForward";

		// Token: 0x04013CD6 RID: 81110
		public const string TrapDefenseMoveRight = "TrapDefenseMoveRight";

		// Token: 0x04013CD7 RID: 81111
		public const string TrapDefenseZoom = "TrapDefenseZoom";

		// Token: 0x04013CD8 RID: 81112
		public const string MotorMoveForward = "MotorMoveForward";

		// Token: 0x04013CD9 RID: 81113
		public const string MotorMoveRight = "MotorMoveRight";

		// Token: 0x04013CDA RID: 81114
		public const string MotorSoarMoveForward = "MotorSoarMoveForward";

		// Token: 0x04013CDB RID: 81115
		public const string PhotoMoveForward = "PhotoMoveForward";

		// Token: 0x04013CDC RID: 81116
		public const string PhotoMoveRight = "PhotoMoveRight";

		// Token: 0x04013CDD RID: 81117
		public const string PhotoMoveUp = "PhotoMoveUp";

		// Token: 0x04013CDE RID: 81118
		public const string PhotoPitch = "PhotoPitch";

		// Token: 0x04013CDF RID: 81119
		public const string PhotoYaw = "PhotoYaw";

		// Token: 0x04013CE0 RID: 81120
		public const string PhotoRoll = "PhotoRoll";

		// Token: 0x04013CE1 RID: 81121
		public const string PhotoFov = "PhotoFov";

		// Token: 0x04013CE2 RID: 81122
		public const string CameraFocusHor = "CameraFocusHor";

		// Token: 0x04013CE3 RID: 81123
		public const string CameraFocusVer = "CameraFocusVer";

		// Token: 0x04013CE4 RID: 81124
		private static readonly IReadOnlySet<string> AxisMappingValues = new HashSet<string>
		{
			"LookUp",
			"LookUpRate",
			"MoveForward",
			"MoveRight",
			"Turn",
			"Zoom",
			"WheelAxis",
			"UiIncrease",
			"UiReduce",
			"UiIncrease2",
			"UiReduce2",
			"UiIncrease3",
			"UiReduce3",
			"UiMoveForward",
			"UiMoveRight",
			"NavigationTopDown",
			"NavigationLeftRight",
			"UiScroll1",
			"UiScroll2",
			"UiLookUp",
			"UiTurn",
			"UiLookInOut",
			"UiCamRotate",
			"UiCamRotate2",
			"UiWheelAxis",
			"Ui左摇杆",
			"Ui右摇杆",
			"NextGroup",
			"PrevGroup",
			"NextGroup2",
			"MapIncrease",
			"MapReduce",
			"MapIncrease2",
			"MapReduce2",
			"MapMoveForward",
			"MapMoveRight",
			"MapMoveForward2",
			"MapMoveRight2",
			"MouseMove",
			"RoleLookUp",
			"RoleTurn",
			"RoleIncrease",
			"RoleReduce",
			"TrapDefenseMoveForward",
			"TrapDefenseMoveRight",
			"TrapDefenseZoom",
			"MotorMoveForward",
			"MotorMoveRight",
			"MotorSoarMoveForward",
			"PhotoMoveForward",
			"PhotoMoveRight",
			"PhotoMoveUp",
			"PhotoPitch",
			"PhotoYaw",
			"PhotoRoll",
			"PhotoFov",
			"CameraFocusHor",
			"CameraFocusVer"
		};
	}
}
