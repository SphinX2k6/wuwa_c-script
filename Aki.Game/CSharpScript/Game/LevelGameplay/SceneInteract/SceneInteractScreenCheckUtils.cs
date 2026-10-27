using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A7C RID: 27260
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneInteractScreenCheckUtils
	{
		// Token: 0x06043C1C RID: 277532 RVA: 0x01095EE8 File Offset: 0x010940E8
		public static bool IsLocationInScreen(Vector location)
		{
			if (location == null)
			{
				return false;
			}
			FightCameraLogicComponent fightCameraLogicComponent = SceneInteractScreenCheckUtils.GetFightCameraLogicComponent();
			if (fightCameraLogicComponent == null)
			{
				return false;
			}
			SceneInteractScreenCheckUtils.TmpLocation.DeepCopy(location);
			CameraAdjustController cameraAdjustController = fightCameraLogicComponent.CameraAdjustController;
			return fightCameraLogicComponent.CheckPositionInScreen(SceneInteractScreenCheckUtils.TmpLocation, cameraAdjustController.CheckInScreenMinX, cameraAdjustController.CheckInScreenMaxX, cameraAdjustController.CheckInScreenMinY, cameraAdjustController.CheckInScreenMaxY);
		}

		// Token: 0x06043C1D RID: 277533 RVA: 0x01095F3A File Offset: 0x0109413A
		private static FightCameraLogicComponent GetFightCameraLogicComponent()
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			if (fightCamera == null)
			{
				return null;
			}
			return fightCamera.GetComponent<FightCameraLogicComponent>();
		}

		// Token: 0x0402366E RID: 145006
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpLocation = Vector.Create();
	}
}
