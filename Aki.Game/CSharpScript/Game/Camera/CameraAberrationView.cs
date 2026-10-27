using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072D8 RID: 29400
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraAberrationView
	{
		// Token: 0x06048252 RID: 295506 RVA: 0x0128270C File Offset: 0x0128090C
		public CameraAberrationView Set(Vector basicLocation, float fadeInTime, float fadeOutTime, float sceneCameraFadeOutTime)
		{
			this.BasicLocation.DeepCopy(basicLocation);
			this.FadeInTime = fadeInTime;
			this.FadeOutTime = fadeOutTime;
			this.SceneCameraFadeOutTime = sceneCameraFadeOutTime;
			this.LeaveTriggerTime = Math.Max(this.FadeOutTime - this.SceneCameraFadeOutTime, 0f);
			return this;
		}

		// Token: 0x06048253 RID: 295507 RVA: 0x0128275C File Offset: 0x0128095C
		[NullableContext(2)]
		public unsafe void EnablePerspectiveToOrthographicView(BP_CineCamera_C camera, Action callback = null)
		{
			if (camera == null)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[正交镜头]启动正交镜头，从透视过渡到正交";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FadeInTime", this.FadeInTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BasicLocation", this.BasicLocation);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.Camera = camera;
			this.InitialFov = this.Camera.GetCineCameraComponent().FieldOfView;
			this.IsLerpPerspectiveToOrthographicView = true;
			Vector lerpBeginCameraLocation = this.LerpBeginCameraLocation;
			FVectorDouble fvectorDouble = this.Camera.D_K2_GetActorLocation();
			lerpBeginCameraLocation.DeepCopy(fvectorDouble);
			this.TempVector.DeepCopy(this.BasicLocation);
			this.TempVector.SubtractionEqual(this.LerpBeginCameraLocation);
			this.LerpBeginDistance = (float)this.TempVector.Size();
			this.LerpBeginFov = this.InitialFov;
			this.LerpOrthoWidth = this.LerpBeginDistance * (float)Math.Tan((double)(this.LerpBeginFov * 0.5f * 0.017453292f));
			this.LerpTime = 0f;
			this.LerpFinishCallback = callback;
			this.TriggeredCallback = false;
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MotionBlur.TargetFPS 1200", null);
		}

		// Token: 0x06048254 RID: 295508 RVA: 0x0128289C File Offset: 0x01280A9C
		[NullableContext(2)]
		public unsafe void EnableOrthographicToPerspectiveToView(BP_CineCamera_C camera, Action callback = null)
		{
			if (camera == null)
			{
				if (callback != null)
				{
					callback();
				}
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[正交镜头]启动正交镜头，从正交过渡到透视1";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("FadeOutTime", this.FadeOutTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BasicLocation", this.BasicLocation);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.Camera = camera;
			this.IsLerpOrthographicToPerspectiveView = true;
			Vector lerpBeginCameraLocation = this.LerpBeginCameraLocation;
			FVectorDouble fvectorDouble = this.Camera.D_K2_GetActorLocation();
			lerpBeginCameraLocation.DeepCopy(fvectorDouble);
			this.TempVector.DeepCopy(this.BasicLocation);
			this.TempVector.SubtractionEqual(this.LerpBeginCameraLocation);
			this.LerpBeginDistance = (float)this.TempVector.Size();
			this.LerpBeginFov = this.Camera.GetCineCameraComponent().FieldOfView;
			this.LerpOrthoWidth = this.LerpBeginDistance * (float)Math.Tan((double)(this.LerpBeginFov * 0.5f * 0.017453292f));
			this.LerpTime = 0f;
			this.LerpFinishCallback = callback;
			this.TriggeredCallback = false;
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.MotionBlur.TargetFPS -1", null);
		}

		// Token: 0x06048255 RID: 295509 RVA: 0x012829DC File Offset: 0x01280BDC
		public void Update(float second)
		{
			if (this.IsLerpPerspectiveToOrthographicView)
			{
				this.LerpTime = Math.Min(this.LerpTime + second, this.FadeInTime);
				float num = MathUtils.Instance.IsNearlyZero((double)this.FadeInTime, null) ? 1f : (this.LerpTime / this.FadeInTime);
				float num2 = MathUtils.Instance.Lerp(this.LerpBeginFov, 15f, num);
				float num3 = this.LerpOrthoWidth / (float)Math.Tan((double)(num2 * 0.5f * 0.017453292f));
				Rotator tempRotator = this.TempRotator;
				FRotator frotator = this.Camera.K2_GetActorRotation();
				tempRotator.DeepCopy(frotator);
				this.TempRotator.Vector(this.TempVector);
				this.TempVector2.DeepCopy(this.LerpBeginCameraLocation);
				this.TempVector.MultiplyEqual((double)(num3 - this.LerpBeginDistance));
				this.TempVector2.SubtractionEqual(this.TempVector);
				this.Camera.D_K2_SetActorLocation(this.TempVector2.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, false);
				this.Camera.GetCineCameraComponent().SetFieldOfView(num2);
				this.Camera.GetCineCameraComponent().FocusSettings.ManualFocusDistance = num3;
				if (num >= 1f || this.Camera.GetCineCameraComponent().FieldOfView <= 15f)
				{
					this.IsLerpPerspectiveToOrthographicView = false;
					Action lerpFinishCallback = this.LerpFinishCallback;
					if (lerpFinishCallback == null)
					{
						return;
					}
					lerpFinishCallback();
					return;
				}
			}
			else if (this.IsLerpOrthographicToPerspectiveView)
			{
				this.LerpTime = Math.Min(this.LerpTime + second, this.FadeOutTime);
				float num4 = MathUtils.Instance.IsNearlyZero((double)this.FadeOutTime, null) ? 1f : (this.LerpTime / this.FadeOutTime);
				float num5 = MathUtils.Instance.Lerp(this.LerpBeginFov, this.InitialFov, num4);
				float num6 = this.LerpOrthoWidth / (float)Math.Tan((double)(num5 * 0.5f * 0.017453292f));
				Rotator tempRotator2 = this.TempRotator;
				FRotator frotator = this.Camera.K2_GetActorRotation();
				tempRotator2.DeepCopy(frotator);
				this.TempRotator.Vector(this.TempVector);
				this.TempVector2.DeepCopy(this.LerpBeginCameraLocation);
				this.TempVector.MultiplyEqual((double)(num6 - this.LerpBeginDistance));
				this.TempVector2.SubtractionEqual(this.TempVector);
				this.Camera.D_K2_SetActorLocation(this.TempVector2.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, false);
				this.Camera.GetCineCameraComponent().SetFieldOfView(num5);
				this.Camera.GetCineCameraComponent().FocusSettings.ManualFocusDistance = num6;
				if (this.LerpTime > this.LeaveTriggerTime && !this.TriggeredCallback)
				{
					this.TriggeredCallback = true;
					Action lerpFinishCallback2 = this.LerpFinishCallback;
					if (lerpFinishCallback2 != null)
					{
						lerpFinishCallback2();
					}
				}
				if (num4 >= 1f || this.Camera.GetCineCameraComponent().FieldOfView >= this.InitialFov)
				{
					if (!this.TriggeredCallback)
					{
						this.TriggeredCallback = true;
						Action lerpFinishCallback3 = this.LerpFinishCallback;
						if (lerpFinishCallback3 != null)
						{
							lerpFinishCallback3();
						}
					}
					this.IsLerpOrthographicToPerspectiveView = false;
				}
			}
		}

		// Token: 0x04026123 RID: 155939
		private const float DEFAULT_CAMERA_FOV = 75f;

		// Token: 0x04026124 RID: 155940
		private const float MINI_CAMERA_FOV = 15f;

		// Token: 0x04026125 RID: 155941
		[Nullable(2)]
		public BP_CineCamera_C Camera;

		// Token: 0x04026126 RID: 155942
		public readonly Vector BasicLocation = Vector.Create();

		// Token: 0x04026127 RID: 155943
		public float FadeInTime;

		// Token: 0x04026128 RID: 155944
		public float FadeOutTime;

		// Token: 0x04026129 RID: 155945
		public float SceneCameraFadeOutTime;

		// Token: 0x0402612A RID: 155946
		private float InitialFov = 75f;

		// Token: 0x0402612B RID: 155947
		private bool IsLerpPerspectiveToOrthographicView;

		// Token: 0x0402612C RID: 155948
		private bool IsLerpOrthographicToPerspectiveView;

		// Token: 0x0402612D RID: 155949
		private readonly Vector LerpBeginCameraLocation = Vector.Create();

		// Token: 0x0402612E RID: 155950
		private float LerpBeginDistance;

		// Token: 0x0402612F RID: 155951
		private float LerpBeginFov = 75f;

		// Token: 0x04026130 RID: 155952
		private float LerpOrthoWidth;

		// Token: 0x04026131 RID: 155953
		private float LerpTime;

		// Token: 0x04026132 RID: 155954
		[Nullable(2)]
		private Action LerpFinishCallback;

		// Token: 0x04026133 RID: 155955
		private bool TriggeredCallback;

		// Token: 0x04026134 RID: 155956
		private float LeaveTriggerTime;

		// Token: 0x04026135 RID: 155957
		private readonly Rotator TempRotator = Rotator.Create();

		// Token: 0x04026136 RID: 155958
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04026137 RID: 155959
		private readonly Vector TempVector2 = Vector.Create();
	}
}
