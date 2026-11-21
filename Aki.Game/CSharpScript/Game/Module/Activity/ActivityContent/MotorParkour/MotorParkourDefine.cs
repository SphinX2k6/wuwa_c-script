using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x0200536C RID: 21356
	public class MotorParkourDefine
	{
		// Token: 0x0401C0B5 RID: 114869
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static Vector worldToMotorParkourUiUnit = Vector.Create(1.0, -1.0, 1.0);

		// Token: 0x0401C0B6 RID: 114870
		public const int SPLINE_DISTANCE_INTERVAL = 1000;

		// Token: 0x0401C0B7 RID: 114871
		public const int MOTORPARKOUR_WORLD_TO_UI_ROTATION_REVISE_ANGLE = 90;
	}
}
