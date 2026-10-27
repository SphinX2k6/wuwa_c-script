using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072DA RID: 29402
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneSubCamera
	{
		// Token: 0x0604825B RID: 295515 RVA: 0x01282E44 File Offset: 0x01281044
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

		// Token: 0x0604825C RID: 295516 RVA: 0x01282E67 File Offset: 0x01281067
		public void Clear()
		{
			if (this.Camera != null && this.Camera.IsValid())
			{
				ActorSystem.Instance.Put("SceneSubCamera.Clear", this.Camera, null);
				this.Camera = null;
			}
		}

		// Token: 0x0604825D RID: 295517 RVA: 0x01282E9C File Offset: 0x0128109C
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

		// Token: 0x0402613E RID: 155966
		public ESceneSubCameraType Type = ESceneSubCameraType.Default;

		// Token: 0x0402613F RID: 155967
		public BP_CineCamera_C Camera;

		// Token: 0x04026140 RID: 155968
		[Nullable(1)]
		public Rotator StartRotation = new Rotator();

		// Token: 0x04026141 RID: 155969
		public float FadeIn;

		// Token: 0x04026142 RID: 155970
		public EViewTargetBlendFunction FadeInFunc;

		// Token: 0x04026143 RID: 155971
		public float FadeInExp;

		// Token: 0x04026144 RID: 155972
		public UCurveFloat FadeInCurve;

		// Token: 0x04026145 RID: 155973
		public float FadeOut;

		// Token: 0x04026146 RID: 155974
		public EViewTargetBlendFunction FadeOutFunc;

		// Token: 0x04026147 RID: 155975
		public float FadeOutExp;

		// Token: 0x04026148 RID: 155976
		public UCurveFloat FadeOutCurve;

		// Token: 0x04026149 RID: 155977
		public bool IsBinding;

		// Token: 0x0402614A RID: 155978
		public bool IsKeepUi;

		// Token: 0x0402614B RID: 155979
		public bool IsCameraAberrationEnable;

		// Token: 0x0402614C RID: 155980
		public CameraAberrationView CameraAberrationView;

		// Token: 0x0402614D RID: 155981
		public bool CanAcceptInput;

		// Token: 0x0402614E RID: 155982
		public bool EnableInPlotMode;

		// Token: 0x0402614F RID: 155983
		public SceneFixInputData FixInputData;

		// Token: 0x04026150 RID: 155984
		public SceneCameraFollowConfig FollowConfig;
	}
}
