using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Sequence.Manager;
using CSharpScript.Core.Common;
using CSharpScript.Game.GameSettings;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02003FFF RID: 16383
	[NullableContext(2)]
	[Nullable(0)]
	public class RenderAssistant : SeqBaseAssistant
	{
		// Token: 0x06029779 RID: 169849 RVA: 0x00BB17E0 File Offset: 0x00BAF9E0
		public override void PreAllPlay(Action<bool> callback = null)
		{
			this.IsEnableMobileKuroSpotlightsShadow = UKismetSystemLibrary.GetConsoleVariableFloatValue("r.Mobile.EnableKuroSpotlightsShadow");
			RenderUtil.CloseToonSceneShadow();
			RenderUtil.OpenMobileSpotLightShadow();
			if (!this.Model.IsControlEntity)
			{
				GameSettingsDeviceRender.Instance.SetSequenceFrameRateLimit();
			}
			if (Info.Instance.IsLowMemoryDevice)
			{
				int value = UStreamableRenderAsset.EncodeStreamingLODBiasMapping(0, 0, 0, 3, 4);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.RuntimeLODBiasDeviceMappingIndices ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				UKuroSequencePerformanceManager.SimpleExecuteCommand(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			if (Info.Instance.IsPcOrGamepadPlatform())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.AutoExposure 0", null);
			}
			this.Model.PreviousMotionBlur = new float?(UKismetSystemLibrary.GetConsoleVariableFloatValue("r.MotionBlur.Amount"));
			float? previousMotionBlur = this.Model.PreviousMotionBlur;
			float num = 0f;
			if (!(previousMotionBlur.GetValueOrDefault() == num & previousMotionBlur != null))
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MotionBlur.Amount 0", null);
			}
			UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetEyesParameterMaterialParameterCollection(), this.EyesLightName, 0f);
			GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("PrePlaySequence");
			ULevelSequence currentSequence = this.Model.GetCurrentSequence();
			UKuroSequencePerformanceManager.OpenKuroPerformanceMode(currentSequence);
			if (UKuroStaticLibrary.GetEnableMobileLowStreaming(currentSequence))
			{
				float? num2;
				if (currentSequence == null)
				{
					num2 = null;
				}
				else
				{
					UKuroSequenceConsoleCommandDataAsset sequenceDataAsset = currentSequence.SequenceDataAsset;
					num2 = ((sequenceDataAsset != null) ? new float?(sequenceDataAsset.MobileLowStreamingScale) : null);
				}
				float? num3 = num2;
				if (num3 != null)
				{
					GameModeModel.Instance.ScaleStreamingSource(EStreamingSourceScaleType.Plot, num3.Value);
				}
			}
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(819, UKuroSequencePerformanceManager.GetPerformanceMode().ToString());
			}
			this.IsAllSet = true;
			int? currentValue = GameSettingsManager.Instance.GetCurrentValue(EFunction.METALFX, true, true);
			EPlotSequenceType? type = this.Model.GetType();
			EPlotSequenceType eplotSequenceType = EPlotSequenceType.过场;
			if ((type.GetValueOrDefault() == eplotSequenceType & type != null) && GameSettingsDeviceRender.Instance.IsMetalFxDevice() && currentValue != null)
			{
				int? num4 = currentValue;
				int num5 = 0;
				if (num4.GetValueOrDefault() > num5 & num4 != null)
				{
					this.IsMuteMetalFxDevice = true;
					GameSettingsUtils.ApplyMetalFxEnable(0);
				}
			}
		}

		// Token: 0x0602977A RID: 169850 RVA: 0x00BB1A00 File Offset: 0x00BAFC00
		public override void PreEachPlay()
		{
			this.IsEachSet = true;
			this.PreStream.Collect();
		}

		// Token: 0x0602977B RID: 169851 RVA: 0x00BB1A14 File Offset: 0x00BAFC14
		public override void EachStop()
		{
			this.IsEachSet = false;
			this.PreStream.Release();
		}

		// Token: 0x0602977C RID: 169852 RVA: 0x00BB1A28 File Offset: 0x00BAFC28
		public override void AllStop(Action<bool> callback = null)
		{
			RenderUtil.OpenToonSceneShadow();
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.Mobile.EnableKuroSpotlightsShadow ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.IsEnableMobileKuroSpotlightsShadow);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			if (Info.Instance.IsLowMemoryDevice)
			{
				int value = UStreamableRenderAsset.EncodeStreamingLODBiasMapping(0, 1, 2, 3, 4);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.Streaming.RuntimeLODBiasDeviceMappingIndices ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				UKuroSequencePerformanceManager.SimpleExecuteCommand(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			if (!this.Model.IsControlEntity)
			{
				GameSettingsDeviceRender.Instance.CancleSequenceFrameRateLimit();
			}
			if (Info.Instance.IsPcOrGamepadPlatform())
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.AutoExposure 1", null);
			}
			float? previousMotionBlur = this.Model.PreviousMotionBlur;
			float num = 0f;
			if (!(previousMotionBlur.GetValueOrDefault() == num & previousMotionBlur != null))
			{
				UObject world2 = GlobalData.World;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("r.MotionBlur.Amount ");
				defaultInterpolatedStringHandler.AppendFormatted<float?>(this.Model.PreviousMotionBlur);
				UKismetSystemLibrary.ExecuteConsoleCommand(world2, defaultInterpolatedStringHandler.ToStringAndClear(), null);
			}
			UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, RenderDataManager.Instance.GetEyesParameterMaterialParameterCollection(), this.EyesLightName, 1f);
			GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("PrePlaySequence");
			UKuroSequencePerformanceManager.CloseKuroPerformanceMode();
			GameModeModel.Instance.CleanScaleStreamingSource(EStreamingSourceScaleType.Plot);
			if (PerfSightController.IsEnable)
			{
				UPerfSightHelper.PostEvent(819, UKuroSequencePerformanceManager.GetPerformanceMode().ToString());
			}
			this.ReleaseSeqStreamingData();
			this.PreStream.Release();
			if (this.IsMuteMetalFxDevice)
			{
				this.IsMuteMetalFxDevice = false;
				GameSettingsUtils.ApplyMetalFxEnable(1);
			}
			this.IsAllSet = false;
		}

		// Token: 0x0602977D RID: 169853 RVA: 0x00BB1BD4 File Offset: 0x00BAFDD4
		public override void End()
		{
			if (this.IsEachSet)
			{
				this.EachStop();
			}
			if (this.IsAllSet)
			{
				this.AllStop(null);
			}
		}

		// Token: 0x0602977E RID: 169854 RVA: 0x00BB1BF3 File Offset: 0x00BAFDF3
		public void TickPreStream()
		{
			this.PreStream.Tick();
		}

		// Token: 0x0602977F RID: 169855 RVA: 0x00BB1C00 File Offset: 0x00BAFE00
		public bool CheckSeqStreamingData()
		{
			bool result = true;
			if (!SequenceRenderSettings.GetTexureStreamingEnable((EGameQualitySettingLevel)((GameSettingsManager.Instance.GetCurrentValue(EFunction.IMAGEQUALITY, true, true) != null) ? GameSettingsManager.Instance.GetCurrentValue(EFunction.IMAGEQUALITY, true, true).Value : 2)))
			{
				Log.Instance.Info(ELogModule.Plot, ELogAuthor.YZH, "当前画质等级不开启纹理流送", default(ReadOnlySpan<ValueTuple<string, object>>));
				return result;
			}
			BP_SequenceData_C sequenceData = this.Model.SequenceData;
			bool gmForceCollectExtraTexture = SequenceController.Instance.GmForceCollectExtraTexture;
			for (int i = 0; i < sequenceData.剧情资源.Num(); i++)
			{
				ULevelSequence levelSequences = sequenceData.剧情资源.Get(i);
				bool bCollectExtraTexture = sequenceData.CollectExtraTexture || gmForceCollectExtraTexture;
				if (!UKuroSequenceRuntimeFunctionLibrary.HandleSeqTexStreaming(levelSequences, true, bCollectExtraTexture))
				{
					result = false;
				}
			}
			if (!this.Model.DoNotHandlePlayerForControlEntityMode && this.Model.SequenceData.NeedSwitchMainCharacter && this.Model.MainSeqCharacterMesh != null && !UKuroMeshTextureFunctionLibrary.IsSkeletalMeshComponentStreamingComplete(this.Model.MainSeqCharacterMesh))
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06029780 RID: 169856 RVA: 0x00BB1CFC File Offset: 0x00BAFEFC
		public void ReleaseSeqStreamingData()
		{
			if (!SequenceRenderSettings.GetTexureStreamingEnable((EGameQualitySettingLevel)((GameSettingsManager.Instance.GetCurrentValue(EFunction.IMAGEQUALITY, true, true) != null) ? GameSettingsManager.Instance.GetCurrentValue(EFunction.IMAGEQUALITY, true, true).Value : 2)))
			{
				Log.Instance.Info(ELogModule.Plot, ELogAuthor.YZH, "当前画质等级不开启纹理流送", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			BP_SequenceData_C sequenceData = this.Model.SequenceData;
			bool gmForceCollectExtraTexture = SequenceController.Instance.GmForceCollectExtraTexture;
			for (int i = 0; i < sequenceData.剧情资源.Num(); i++)
			{
				ULevelSequence levelSequences = sequenceData.剧情资源.Get(i);
				bool bCollectExtraTexture = sequenceData.CollectExtraTexture || gmForceCollectExtraTexture;
				UKuroSequenceRuntimeFunctionLibrary.HandleSeqTexStreaming(levelSequences, false, bCollectExtraTexture);
			}
			if (!this.Model.DoNotHandlePlayerForControlEntityMode && this.Model.SequenceData.NeedSwitchMainCharacter && this.Model.MainSeqCharacterMesh != null)
			{
				UKuroMeshTextureFunctionLibrary.HandleSkeletalMeshComponentStreaming(this.Model.MainSeqCharacterMesh, false);
			}
		}

		// Token: 0x06029781 RID: 169857 RVA: 0x00BB1DEB File Offset: 0x00BAFFEB
		public void SetMotionBlurState(bool isEnable)
		{
			if (isEnable)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MotionBlurQuality 4", null);
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MotionBlurQuality 0", null);
		}

		// Token: 0x06029782 RID: 169858 RVA: 0x00BB1E11 File Offset: 0x00BB0011
		public override void CmdShadowUpdate()
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CacheMode3CacheUpdateIntervalsOverride 0,0,0", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.CSMMode3EnableUpdateIntervalOverride 1", null);
		}

		// Token: 0x04016A09 RID: 92681
		private bool IsEachSet;

		// Token: 0x04016A0A RID: 92682
		private bool IsAllSet;

		// Token: 0x04016A0B RID: 92683
		private readonly FName EyesLightName = new FName("LightDisableSwitch");

		// Token: 0x04016A0C RID: 92684
		private float IsEnableMobileKuroSpotlightsShadow;

		// Token: 0x04016A0D RID: 92685
		private bool IsMuteMetalFxDevice;

		// Token: 0x04016A0E RID: 92686
		[Nullable(1)]
		private readonly PreStreamScheduler PreStream = new PreStreamScheduler();
	}
}
