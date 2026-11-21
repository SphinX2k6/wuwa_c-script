using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02005F95 RID: 24469
	public class GuaranteeActionRestorePlayerCameraAdjustment : GuaranteeActionBase, IGuaranteeActionComparer
	{
		// Token: 0x0603ACD7 RID: 240855 RVA: 0x0109FF94 File Offset: 0x0109E194
		[NullableContext(2)]
		public bool IsSameAction(ActionParams left, ActionParams right)
		{
			RestorePlayerCameraAdjustment restorePlayerCameraAdjustment = left as RestorePlayerCameraAdjustment;
			if (restorePlayerCameraAdjustment != null)
			{
				RestorePlayerCameraAdjustment restorePlayerCameraAdjustment2 = right as RestorePlayerCameraAdjustment;
				if (restorePlayerCameraAdjustment2 != null)
				{
					string a = StringUtils.IsNothing(restorePlayerCameraAdjustment.SubScreenKey ?? string.Empty) ? "MainCamera" : restorePlayerCameraAdjustment.SubScreenKey;
					string b = StringUtils.IsNothing(restorePlayerCameraAdjustment2.SubScreenKey ?? string.Empty) ? "MainCamera" : restorePlayerCameraAdjustment2.SubScreenKey;
					return a == b;
				}
			}
			return false;
		}

		// Token: 0x0603ACD8 RID: 240856 RVA: 0x010A0004 File Offset: 0x0109E204
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
