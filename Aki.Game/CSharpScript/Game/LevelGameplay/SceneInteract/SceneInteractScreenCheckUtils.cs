using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BD9 RID: 23513
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneInteractScreenCheckUtils
	{
		// Token: 0x06039C6A RID: 236650 RVA: 0x0103A728 File Offset: 0x01038928
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

		// Token: 0x06039C6B RID: 236651 RVA: 0x0103A77A File Offset: 0x0103897A
		private static FightCameraLogicComponent GetFightCameraLogicComponent()
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			if (fightCamera == null)
			{
				return null;
			}
			return fightCamera.GetComponent<FightCameraLogicComponent>();
		}

		// Token: 0x0401E860 RID: 125024
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpLocation = Vector.Create();
	}
}
