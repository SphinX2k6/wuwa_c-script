using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02006E15 RID: 28181
	public class GuaranteeActionRestorePlayerCameraAdjustment : GuaranteeActionBase
	{
		// Token: 0x06044B70 RID: 281456 RVA: 0x010F5B60 File Offset: 0x010F3D60
		[NullableContext(2)]
		protected unsafe override void OnExecute(ActionParams inParams = null)
		{
			RestorePlayerCameraAdjustment restorePlayerCameraAdjustment = inParams as RestorePlayerCameraAdjustment;
			if (restorePlayerCameraAdjustment == null)
			{
				return;
			}
			string text = restorePlayerCameraAdjustment.SubScreenKey ?? "MainCamera";
			string text2 = StringUtils.IsNothing(text) ? "MainCamera" : text;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelEvent;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "保底相机调整";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("subScreenKey", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("targetCamera", text2);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			CameraModelInstance separateCameraModel = CameraModel.Instance.GetSeparateCameraModel(text2);
			if (separateCameraModel == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Event;
				ELogAuthor author2 = ELogAuthor.LJM;
				string message2 = "进入保底相机调整失败,因为model不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("targetCamera", text2);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			separateCameraModel.FightCamera.LogicComponent.RestoreCameraFromAdjust(null, null, true);
			PanoramicModel instance3 = PanoramicModel.Instance;
			if (instance3 != null && instance3.IsPanoramic)
			{
				PanoramicController.Instance.EnterPanoramic(false, null);
			}
		}
	}
}
