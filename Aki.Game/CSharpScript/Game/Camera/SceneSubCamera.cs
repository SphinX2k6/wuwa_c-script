using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200645C RID: 25692
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneSubCamera
	{
		// Token: 0x0603E66F RID: 255599 RVA: 0x0122562C File Offset: 0x0122382C
		[NullableContext(1)]
		public static int Compare(SceneSubCamera a, SceneSubCamera b)
		{
			int num = a.Type - b.Type;
			if (num == 0)
			{
				num--;
			}
			return num;
		}

		// Token: 0x0603E670 RID: 255600 RVA: 0x0122564F File Offset: 0x0122384F
		public void Clear()
		{
			if (this.Camera != null && this.Camera.IsValid())
			{
				ActorSystem.Instance.Put("SceneSubCamera.Clear", this.Camera, null);
				this.Camera = null;
			}
		}

		// Token: 0x0603E671 RID: 255601 RVA: 0x01225684 File Offset: 0x01223884
		[NullableContext(1)]
		public void CopyData(SceneSubCamera camera)
		{
			if (camera.Camera == null || !camera.Camera.IsValid())
			{
				return;
			}
			AActor camera2 = this.Camera;
			FRotator frotator = camera.Camera.K2_GetActorRotation();
			FVectorDouble fvectorDouble = camera.Camera.D_K2_GetActorLocation();
			FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
			FVector fvector = fvectorDouble2;
			FTransformDouble ftransformDouble = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
			camera2.D_K2_SetActorTransform(ftransformDouble, false, ref WorldGlobal.SweepHitResult, true);
			this.FadeIn = camera.FadeIn;
			this.FadeOut = camera.FadeOut;
			this.IsKeepUi = camera.IsKeepUi;
		}

		// Token: 0x04021421 RID: 136225
		public ESceneSubCameraType Type = ESceneSubCameraType.Default;

		// Token: 0x04021422 RID: 136226
		public BP_CineCamera_C Camera;

		// Token: 0x04021423 RID: 136227
		[Nullable(1)]
		public Rotator StartRotation = new Rotator();

		// Token: 0x04021424 RID: 136228
		public float FadeIn;

		// Token: 0x04021425 RID: 136229
		public EViewTargetBlendFunction FadeInFunc;

		// Token: 0x04021426 RID: 136230
		public float FadeInExp;

		// Token: 0x04021427 RID: 136231
		public UCurveFloat FadeInCurve;

		// Token: 0x04021428 RID: 136232
		public float FadeOut;

		// Token: 0x04021429 RID: 136233
		public EViewTargetBlendFunction FadeOutFunc;

		// Token: 0x0402142A RID: 136234
		public float FadeOutExp;

		// Token: 0x0402142B RID: 136235
		public UCurveFloat FadeOutCurve;

		// Token: 0x0402142C RID: 136236
		public bool IsBinding;

		// Token: 0x0402142D RID: 136237
		public bool IsKeepUi;

		// Token: 0x0402142E RID: 136238
		public bool IsCameraAberrationEnable;

		// Token: 0x0402142F RID: 136239
		public CameraAberrationView CameraAberrationView;

		// Token: 0x04021430 RID: 136240
		public bool CanAcceptInput;

		// Token: 0x04021431 RID: 136241
		public bool EnableInPlotMode;

		// Token: 0x04021432 RID: 136242
		public SceneFixInputData FixInputData;

		// Token: 0x04021433 RID: 136243
		public SceneCameraFollowConfig FollowConfig;
	}
}
