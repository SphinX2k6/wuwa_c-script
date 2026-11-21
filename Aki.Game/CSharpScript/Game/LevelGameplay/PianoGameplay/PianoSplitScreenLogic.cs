using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.PianoGameplay;
using AkiClient.Game.Aki.Render.RuntimeBP.UI.UISceneView;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C27 RID: 23591
	[NullableContext(2)]
	[Nullable(0)]
	public class PianoSplitScreenLogic
	{
		// Token: 0x17006E5D RID: 28253
		// (get) Token: 0x06039F2E RID: 237358 RVA: 0x0104C8B6 File Offset: 0x0104AAB6
		public bool IsInSplitScreen
		{
			get
			{
				return this.IsInSplitScreenInternal;
			}
		}

		// Token: 0x06039F2F RID: 237359 RVA: 0x0104C8C0 File Offset: 0x0104AAC0
		public void RefreshFov(float width, float height)
		{
			if (this.SceneViewActor == null || !this.IsInSplitScreenInternal || !float.IsFinite(width) || !float.IsFinite(height) || width <= 0f || height <= 0f)
			{
				return;
			}
			BP_PianoGameplaySetting_C pianoGameplaySetting = PianoGameplayModel.Instance.PianoGameplaySetting;
			if (pianoGameplaySetting == null)
			{
				return;
			}
			if (!float.IsFinite(pianoGameplaySetting.Fov) || pianoGameplaySetting.Fov <= 0f || pianoGameplaySetting.Fov >= 180f)
			{
				return;
			}
			double num = (double)width / (double)height;
			if (!double.IsFinite(num) || num <= 0.0)
			{
				return;
			}
			double verticalFov = MathUtils.Instance.HorizontalFovToVertically((double)pianoGameplaySetting.Fov, 1.7777777910232544);
			double num2 = MathUtils.Instance.VerticalFovToHorizontally(verticalFov, num);
			if (!double.IsFinite(num2) || num2 <= 0.0 || num2 >= 180.0)
			{
				return;
			}
			this.SceneViewActor.SetFov((float)num2);
		}

		// Token: 0x06039F30 RID: 237360 RVA: 0x0104C9A8 File Offset: 0x0104ABA8
		[NullableContext(1)]
		public void StartSplitScreen(FTransformDouble transform, AUIContainerActor attachActor)
		{
			if (this.IsInSplitScreenInternal)
			{
				return;
			}
			UClass splitScreenBpClass = PianoGameplayModel.Instance.SplitScreenBpClass;
			if (splitScreenBpClass == null)
			{
				return;
			}
			BP_UISceneView_C bp_UISceneView_C = ActorSystem.Instance.Spawn(splitScreenBpClass.ClassStackOnlyPtr, transform, null) as BP_UISceneView_C;
			if (bp_UISceneView_C == null)
			{
				return;
			}
			this.SceneViewActor = bp_UISceneView_C;
			FVectorDouble captureOffsetLocation = PianoGameplayModel.Instance.PianoGameplaySetting.CaptureOffsetLocation;
			transform.AddToTranslation(captureOffsetLocation);
			FQuat fquat = PianoGameplayModel.Instance.PianoGameplaySetting.CaptureOffsetRotation.Quaternion();
			transform.ConcatenateRotation(fquat);
			this.SceneViewActor.AppendSceneView(attachActor, transform);
			this.IsInSplitScreenInternal = true;
			this.CurrentAlpha = 0f;
			this.TargetAlpha = 0f;
			BP_PianoGameplaySetting_C pianoGameplaySetting = PianoGameplayModel.Instance.PianoGameplaySetting;
			if (pianoGameplaySetting != null)
			{
				if (!GlobalData.IsPlayInEditor || !pianoGameplaySetting.EnableFlowMaskRealtimeTuning)
				{
					this.UpdateFlowMaskParameters(PianoGameplayModel.Instance.GameplayStage);
				}
				this.SceneViewActor.SetFov(pianoGameplaySetting.Fov);
			}
			EventSystem.Instance.Add<EPianoGameplayStage>(EEventName.OnPianoGameplayStageChanged, new Action<EPianoGameplayStage>(this.OnPianoGameplayStageChanged));
		}

		// Token: 0x06039F31 RID: 237361 RVA: 0x0104CAB0 File Offset: 0x0104ACB0
		public void StopSplitScreen()
		{
			if (this.SceneViewActor == null || !this.IsInSplitScreenInternal)
			{
				return;
			}
			this.SceneViewActor.StopSceneView();
			ActorSystem.Instance.Put("StopSplitScreen", this.SceneViewActor, null);
			this.SceneViewActor = null;
			this.IsInSplitScreenInternal = false;
			this.CurrentAlpha = 0f;
			EventSystem.Instance.Remove<EPianoGameplayStage>(EEventName.OnPianoGameplayStageChanged, new Action<EPianoGameplayStage>(this.OnPianoGameplayStageChanged));
		}

		// Token: 0x06039F32 RID: 237362 RVA: 0x0104CB28 File Offset: 0x0104AD28
		private void CheckProgress()
		{
			USplineComponent splineComponent = PianoGameplayModel.Instance.SplineComponent;
			UCurveFloat pianoGameplayAlphaPositionCurve = PianoGameplayModel.Instance.PianoGameplayAlphaPositionCurve;
			if (this.SceneViewActor == null || !this.IsInSplitScreenInternal || splineComponent == null || Global.BaseCharacter == null || pianoGameplayAlphaPositionCurve == null)
			{
				if (this.ProgressTimerHandle != null)
				{
					TimerSystem.Instance.Remove(this.ProgressTimerHandle);
					this.ProgressTimerHandle = null;
				}
				return;
			}
			Vector actorLocationProxy = Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy;
			USplineComponent usplineComponent = splineComponent;
			FVectorDouble fvectorDouble = actorLocationProxy.ToUeVector(false);
			float inKey = usplineComponent.D_FindInputKeyClosestToWorldLocation(fvectorDouble);
			float inTime = splineComponent.GetDistanceAlongSplineAtSplineInputKey(inKey) / PianoGameplayModel.Instance.SplineLength.Value;
			UCurveFloat pianoGameplayAlphaPositionCurve2 = PianoGameplayModel.Instance.PianoGameplayAlphaPositionCurve;
			float? num = (pianoGameplayAlphaPositionCurve2 != null) ? new float?(pianoGameplayAlphaPositionCurve2.GetFloatValue(inTime)) : null;
			if (num != null)
			{
				this.TargetAlpha = num.Value;
			}
		}

		// Token: 0x06039F33 RID: 237363 RVA: 0x0104CC08 File Offset: 0x0104AE08
		public void Tick(float delta)
		{
			if (this.SceneViewActor == null || !this.IsInSplitScreenInternal)
			{
				return;
			}
			if (GlobalData.IsPlayInEditor)
			{
				BP_PianoGameplaySetting_C pianoGameplaySetting = PianoGameplayModel.Instance.PianoGameplaySetting;
				if (pianoGameplaySetting != null && pianoGameplaySetting.EnableFlowMaskRealtimeTuning)
				{
					return;
				}
			}
			if (PianoGameplayModel.Instance.GameplayStage == EPianoGameplayStage.Practice)
			{
				return;
			}
			this.CheckProgress();
			if (this.CurrentAlpha != this.TargetAlpha)
			{
				this.CurrentAlpha = MathUtils.Instance.InterpConstantTo(this.CurrentAlpha, this.TargetAlpha, delta, 0.0005f);
				this.SceneViewActor.SetSceneViewMaterailSingleParameter("AlphaPosition", this.CurrentAlpha);
			}
		}

		// Token: 0x06039F34 RID: 237364 RVA: 0x0104CC9F File Offset: 0x0104AE9F
		private void OnPianoGameplayStageChanged(EPianoGameplayStage stage)
		{
			this.UpdateFlowMaskParameters(stage);
		}

		// Token: 0x06039F35 RID: 237365 RVA: 0x0104CCA8 File Offset: 0x0104AEA8
		private void UpdateFlowMaskParameters(EPianoGameplayStage stage)
		{
			if (this.SceneViewActor == null || !this.IsInSplitScreenInternal)
			{
				return;
			}
			if (stage == EPianoGameplayStage.Practice)
			{
				this.SceneViewActor.SetSceneViewMaterialParams(PianoGameplayModel.Instance.PianoGameplaySetting.FlowMaskCenterOffsetX, PianoGameplayModel.Instance.PianoGameplaySetting.FlowMaskCenterOffsetY);
				return;
			}
			if (stage != EPianoGameplayStage.Normal)
			{
				return;
			}
			AudioSystem.Instance.PostEvent("play_sfx_gp_pianist_scenewhoosh");
		}

		// Token: 0x0401EA48 RID: 125512
		private BP_UISceneView_C SceneViewActor;

		// Token: 0x0401EA49 RID: 125513
		private bool IsInSplitScreenInternal;

		// Token: 0x0401EA4A RID: 125514
		private TimerHandle ProgressTimerHandle;

		// Token: 0x0401EA4B RID: 125515
		private float CurrentAlpha;

		// Token: 0x0401EA4C RID: 125516
		private float TargetAlpha;
	}
}
