using System;
using System.Collections.Generic;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200468A RID: 18058
	public class PhotoCameraInputDistribute : InputDistributeSetup
	{
		// Token: 0x0602E99E RID: 190878 RVA: 0x00ACA4E0 File Offset: 0x00AC86E0
		public unsafe override bool OnRefresh()
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			CameraSpecialGameplayController cameraSpecialGameplayController;
			if (fightCamera == null)
			{
				cameraSpecialGameplayController = null;
			}
			else
			{
				FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
				cameraSpecialGameplayController = ((logicComponent != null) ? logicComponent.CameraSpecialGameplayController : null);
			}
			CameraSpecialGameplayController cameraSpecialGameplayController2 = cameraSpecialGameplayController;
			if (cameraSpecialGameplayController2 == null || !cameraSpecialGameplayController2.CheckIsInSpecialGameplay(4))
			{
				return false;
			}
			PhotoCamera currentGameplay = cameraSpecialGameplayController2.GetCurrentGameplay<PhotoCamera>();
			PhotoCameraType? photoCameraType = (currentGameplay != null) ? currentGameplay.CurrentMode : null;
			List<string> list = new List<string>
			{
				"UiInputRoot"
			};
			if (PhotoCameraUtil.IsModeAllowCharacterMove(photoCameraType) && !PhotoCameraUtil.IsMoveBlocked())
			{
				list.Add("FightInputRoot.FightInput.AxisInput.MoveInput");
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[InputDistribute]拍照相机输入分发";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("mode", photoCameraType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("tags", list);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.SetInputDistributeTags(list);
			return true;
		}
	}
}
