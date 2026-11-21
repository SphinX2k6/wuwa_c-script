using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039B7 RID: 14775
	[NullableContext(2)]
	[Nullable(0)]
	public static class UiCameraUtil
	{
		// Token: 0x060260E6 RID: 155878 RVA: 0x00AADF00 File Offset: 0x00AAC100
		public static UiCameraHandleData CreateHandleDataByView(EUiTabViewName viewName)
		{
			string viewName2 = viewName.ToString();
			string handleNameByView = UiCameraModel.Instance.GetHandleNameByView(viewName2);
			if (!string.IsNullOrEmpty(handleNameByView))
			{
				return UiCameraUtil.CreateHandleData(handleNameByView, viewName2);
			}
			return null;
		}

		// Token: 0x060260E7 RID: 155879 RVA: 0x00AADF38 File Offset: 0x00AAC138
		public static UiCameraHandleData CreateHandleData([Nullable(1)] string handleName, string viewName = null)
		{
			UiCameraConfig instance = UiCameraConfig.Instance;
			SUiCameraAnimationSettings suiCameraAnimationSettings = (instance != null) ? instance.GetUiCameraAnimationConfig(handleName) : null;
			if (suiCameraAnimationSettings == null)
			{
				UiCameraConfigHandleData uiCameraConfigHandleData = new UiCameraConfigHandleData();
				UiCameraUtil.InitializeHandleData(uiCameraConfigHandleData, handleName, viewName);
				return uiCameraConfigHandleData;
			}
			UiCameraHandleData uiCameraHandleData;
			if (suiCameraAnimationSettings.IsEmptyState)
			{
				uiCameraHandleData = new UiCameraEmptyHandleData();
			}
			else
			{
				SeqCameraThings savedSeqCameraThings = CameraModel.Instance.MainModel.GetSavedSeqCameraThings();
				if (savedSeqCameraThings != null)
				{
					UiCameraSequenceHandleData uiCameraSequenceHandleData = new UiCameraSequenceHandleData();
					UiCameraUtil.InitializeHandleData(uiCameraSequenceHandleData, handleName, viewName);
					uiCameraSequenceHandleData.SetSequenceCameraData(savedSeqCameraThings);
					return uiCameraSequenceHandleData;
				}
				TSoftObjectPtr<UObject> tsoftObjectPtr = new TSoftObjectPtr<UObject>(suiCameraAnimationSettings.BlendInCameraSequence);
				if (UKismetSystemLibrary.IsValidSoftObjectReference(tsoftObjectPtr))
				{
					uiCameraHandleData = new UiCameraSequenceHandleData();
				}
				else if (!string.IsNullOrEmpty(suiCameraAnimationSettings.ReplaceCameraTag))
				{
					uiCameraHandleData = new UiCameraActorTagHandleData();
				}
				else
				{
					uiCameraHandleData = new UiCameraConfigHandleData();
				}
			}
			UiCameraUtil.InitializeHandleData(uiCameraHandleData, handleName, viewName);
			return uiCameraHandleData;
		}

		// Token: 0x060260E8 RID: 155880 RVA: 0x00AADFE8 File Offset: 0x00AAC1E8
		public static UiCameraTransformHandleData CreateTransformHandleData([Nullable(1)] string handleName, FTransformDouble? transform, string viewName = null)
		{
			UiCameraConfig instance = UiCameraConfig.Instance;
			if (((instance != null) ? instance.GetUiCameraAnimationConfig(handleName) : null) == null)
			{
				return null;
			}
			UiCameraTransformHandleData uiCameraTransformHandleData = new UiCameraTransformHandleData();
			uiCameraTransformHandleData.SetTransform(transform);
			UiCameraUtil.InitializeHandleData(uiCameraTransformHandleData, handleName, viewName);
			return uiCameraTransformHandleData;
		}

		// Token: 0x060260E9 RID: 155881 RVA: 0x00AAE01A File Offset: 0x00AAC21A
		[NullableContext(1)]
		[return: Nullable(2)]
		public static UiCameraReplaceActorHandleData CreateReplaceActorHandleData(string handleName, ACineCameraActor replaceCameraActor, [Nullable(2)] string viewName = null)
		{
			UiCameraConfig instance = UiCameraConfig.Instance;
			if (((instance != null) ? instance.GetUiCameraAnimationConfig(handleName) : null) == null || !replaceCameraActor.IsValid())
			{
				return null;
			}
			UiCameraReplaceActorHandleData uiCameraReplaceActorHandleData = new UiCameraReplaceActorHandleData();
			uiCameraReplaceActorHandleData.SetReplaceCameraActor(replaceCameraActor);
			UiCameraUtil.InitializeHandleData(uiCameraReplaceActorHandleData, handleName, viewName);
			return uiCameraReplaceActorHandleData;
		}

		// Token: 0x060260EA RID: 155882 RVA: 0x00AAE054 File Offset: 0x00AAC254
		[NullableContext(1)]
		private static void InitializeHandleData(UiCameraHandleData handleData, string handleName, [Nullable(2)] string viewName)
		{
			handleData.Initialize(handleName, viewName);
		}
	}
}
