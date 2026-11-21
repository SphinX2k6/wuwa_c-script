using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006439 RID: 25657
	[NullableContext(1)]
	[Nullable(0)]
	public class SeparateCameraLayout
	{
		// Token: 0x0603E496 RID: 255126 RVA: 0x0121A3CC File Offset: 0x012185CC
		public SeparateCameraLayout(CameraModelInstance cameraModeInstance)
		{
		}

		// Token: 0x17007676 RID: 30326
		// (get) Token: 0x0603E497 RID: 255127 RVA: 0x0121A433 File Offset: 0x01218633
		public CameraModelInstance CameraModeInstance { get; } = cameraModeInstance;

		// Token: 0x0603E498 RID: 255128 RVA: 0x0121A43C File Offset: 0x0121863C
		public unsafe void SetViewInfo(Vector2D viewLocation, Vector2D viewSize, bool enableScissorOffset)
		{
			this.CurrentBlendState = ESeparateBlendState.Stay;
			this.UpdateViewLocation(viewLocation);
			this.UpdateViewSize(viewSize);
			this.UpdateScissorOffset(enableScissorOffset);
			if (SeparateCameraLayout.Debug)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[分屏相机]设置分屏信息";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", this.CameraModeInstance.CameraName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ViewLocation", this.GetFormatVector2D(this.CurrentViewLocation));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ViewSize", this.GetFormatVector2D(this.CurrentViewSize));
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}

		// Token: 0x0603E499 RID: 255129 RVA: 0x0121A4FC File Offset: 0x012186FC
		public unsafe void SetTargetViewInfo(float blendTime, Vector2D targetViewLocation, Vector2D targetViewSize, bool enableScissorOffset, [Nullable(2)] UCurveFloat curveFloat, [Nullable(2)] Action callback = null)
		{
			this.BlendTime = blendTime;
			this.TargetViewLocation.DeepCopy(targetViewLocation);
			this.TargetViewSize.DeepCopy(targetViewSize);
			this.UpdateScissorOffset(enableScissorOffset);
			this.BlendCurve = curveFloat;
			this.FinishCallback = callback;
			this.CurrentBlendState = ESeparateBlendState.Blend;
			this.StartViewLocation.DeepCopy(this.CurrentViewLocation);
			this.StartViewSize.DeepCopy(this.CurrentViewSize);
			this.CurrentBlendTime = 0f;
			if (SeparateCameraLayout.Debug)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[分屏相机]开始插值分屏信息";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", this.CameraModeInstance.CameraName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BlendTime", this.BlendTime);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ViewLocation(from)", this.GetFormatVector2D(this.CurrentViewLocation));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ViewSize(from)", this.GetFormatVector2D(this.CurrentViewSize));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("ViewLocation(to)", this.GetFormatVector2D(this.TargetViewLocation));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("ViewSize(to)", this.GetFormatVector2D(this.TargetViewSize));
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			}
		}

		// Token: 0x0603E49A RID: 255130 RVA: 0x0121A674 File Offset: 0x01218874
		public unsafe void BlendToTarget(float deltaTime)
		{
			if (this.CurrentBlendState != ESeparateBlendState.Blend)
			{
				return;
			}
			this.CurrentBlendTime += deltaTime * 0.001f;
			float num = (this.BlendTime <= 0f) ? 1f : Math.Min(this.CurrentBlendTime / this.BlendTime, 1f);
			float num2 = num;
			if (this.BlendCurve != null)
			{
				num2 = MathUtils.Instance.Clamp(this.BlendCurve.GetFloatValue(num), 0f, 1f);
			}
			double inX = MathUtils.Instance.Lerp(this.StartViewLocation.X, this.TargetViewLocation.X, (double)num2);
			double inY = MathUtils.Instance.Lerp(this.StartViewLocation.Y, this.TargetViewLocation.Y, (double)num2);
			this.TmpVector2D.Set(inX, inY);
			this.UpdateViewLocation(this.TmpVector2D);
			double inX2 = MathUtils.Instance.Lerp(this.StartViewSize.X, this.TargetViewSize.X, (double)num2);
			double inY2 = MathUtils.Instance.Lerp(this.StartViewSize.Y, this.TargetViewSize.Y, (double)num2);
			this.TmpVector2D.Set(inX2, inY2);
			this.UpdateViewSize(this.TmpVector2D);
			if (num >= 1f)
			{
				this.CurrentBlendState = ESeparateBlendState.Stay;
				Action finishCallback = this.FinishCallback;
				if (finishCallback != null)
				{
					finishCallback();
				}
			}
			if (SeparateCameraLayout.Debug)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "[分屏相机]插值分屏信息";
				<>y__InlineArray10<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray10<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", this.CameraModeInstance.CameraName);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "Alpha";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<float>(num, "F2");
				ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item2 = "Ratio";
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<float>(num2, "F2");
				ptr2 = new ValueTuple<string, object>(item2, defaultInterpolatedStringHandler.ToStringAndClear());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("State", this.CurrentBlendState);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("ViewLocation(current)", this.GetFormatVector2D(this.CurrentViewLocation));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("ViewSize(current)", this.GetFormatVector2D(this.CurrentViewSize));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("ViewLocation(from)", this.GetFormatVector2D(this.StartViewLocation));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("ViewSize(from)", this.GetFormatVector2D(this.StartViewSize));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("ViewLocation(to)", this.GetFormatVector2D(this.TargetViewLocation));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 9) = new ValueTuple<string, object>("ViewSize(to)", this.GetFormatVector2D(this.TargetViewSize));
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 10));
			}
		}

		// Token: 0x0603E49B RID: 255131 RVA: 0x0121A985 File Offset: 0x01218B85
		private void UpdateViewLocation(Vector2D viewLocation)
		{
			this.CurrentViewLocation.DeepCopy(viewLocation);
			this.CameraModeInstance.PlayerCameraManager.ViewPointOverride = viewLocation.ToUeVector2D(false);
		}

		// Token: 0x0603E49C RID: 255132 RVA: 0x0121A9AA File Offset: 0x01218BAA
		private void UpdateViewSize(Vector2D viewSize)
		{
			this.CurrentViewSize.DeepCopy(viewSize);
			this.CameraModeInstance.PlayerCameraManager.ViewSizeOverride = viewSize.ToUeVector2D(false);
		}

		// Token: 0x0603E49D RID: 255133 RVA: 0x0121A9CF File Offset: 0x01218BCF
		private void UpdateScissorOffset(bool enableScissorOffset)
		{
			this.EnableScissorOffset = enableScissorOffset;
			if (this.CameraModeInstance.CurrentCameraComponent != null && this.CameraModeInstance.CurrentCameraComponent.IsValid())
			{
				this.CameraModeInstance.CurrentCameraComponent.bEnableScissorOffCenter = enableScissorOffset;
			}
		}

		// Token: 0x0603E49E RID: 255134 RVA: 0x0121AA08 File Offset: 0x01218C08
		private string GetFormatVector2D(Vector2D vector)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<double>(vector.X, "F4");
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<double>(vector.Y, "F4");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040212BD RID: 135869
		[StaticVariableRuleIgnore]
		public static bool Debug;

		// Token: 0x040212BE RID: 135870
		public Vector2D TargetViewLocation = Vector2D.Create();

		// Token: 0x040212BF RID: 135871
		public Vector2D TargetViewSize = Vector2D.Create();

		// Token: 0x040212C0 RID: 135872
		public float BlendTime;

		// Token: 0x040212C1 RID: 135873
		[Nullable(2)]
		public UCurveFloat BlendCurve;

		// Token: 0x040212C2 RID: 135874
		[Nullable(2)]
		public Action FinishCallback;

		// Token: 0x040212C3 RID: 135875
		public Vector2D StartViewLocation = Vector2D.Create();

		// Token: 0x040212C4 RID: 135876
		public Vector2D StartViewSize = Vector2D.Create();

		// Token: 0x040212C5 RID: 135877
		public Vector2D CurrentViewLocation = Vector2D.Create();

		// Token: 0x040212C6 RID: 135878
		public Vector2D CurrentViewSize = Vector2D.Create();

		// Token: 0x040212C7 RID: 135879
		public float CurrentBlendTime;

		// Token: 0x040212C8 RID: 135880
		public ESeparateBlendState CurrentBlendState;

		// Token: 0x040212C9 RID: 135881
		public bool EnableScissorOffset;

		// Token: 0x040212CA RID: 135882
		private readonly Vector2D TmpVector2D = Vector2D.Create();
	}
}
