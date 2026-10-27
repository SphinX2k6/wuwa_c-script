using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063EE RID: 25582
	public class MotorParkourDefine
	{
		// Token: 0x04021786 RID: 137094
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static Vector worldToMotorParkourUiUnit = Vector.Create(1.0, -1.0, 1.0);

		// Token: 0x04021787 RID: 137095
		public const int SPLINE_DISTANCE_INTERVAL = 1000;

		// Token: 0x04021788 RID: 137096
		public const int MOTORPARKOUR_WORLD_TO_UI_ROTATION_REVISE_ANGLE = 90;
	}
}
