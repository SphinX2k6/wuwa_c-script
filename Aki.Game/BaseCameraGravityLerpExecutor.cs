using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200020C RID: 524
[NullableContext(1)]
[Nullable(0)]
public class BaseCameraGravityLerpExecutor : IStaticVariableResetter
{
	// Token: 0x0600211C RID: 8476 RVA: 0x000B3F36 File Offset: 0x000B2136
	static BaseCameraGravityLerpExecutor()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseCameraGravityLerpExecutor.CreateStaticDefaultValue), new Action(BaseCameraGravityLerpExecutor.ResetStaticDefaultValue));
	}

	// Token: 0x0600211D RID: 8477 RVA: 0x000B3F58 File Offset: 0x000B2158
	public unsafe void Init(CameraGravityController owner, CameraGravityLerpConfig lerpConfig)
	{
		this.Owner = owner;
		this.LerpConfig.DeepCopy(lerpConfig);
		this.IsFinished = false;
		this.HasFlatAngleGravityQuatAxis = false;
		this.HasStableModelBufferAxis = false;
		this.FlatAngleGravityQuatAxis.DeepCopy(Vector.RightVectorProxy);
		this.FlatAngleGravityQuatSign = 1f;
		if (BaseCameraGravityLerpExecutor.Debug)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraGravity]插值设置重力方向[开始]";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("config", this.LerpConfig.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GravityDirect", this.Owner.GetCurrentCameraGravityDirect().ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FlatAngleGravityQuatSign", this.FlatAngleGravityQuatSign);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		this.InitInternal();
	}

	// Token: 0x0600211E RID: 8478 RVA: 0x000B4046 File Offset: 0x000B2246
	public void Update(float deltaTime)
	{
		if (!this.EnableUpdate())
		{
			return;
		}
		float num = this.UpdateInternal(deltaTime);
		this.DrawDebugInfo();
		if (num >= 1f)
		{
			this.Finish();
		}
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x000B406B File Offset: 0x000B226B
	public bool EnableUpdate()
	{
		return !this.IsFinished;
	}

	// Token: 0x06002120 RID: 8480 RVA: 0x000B4078 File Offset: 0x000B2278
	private void DrawDebugInfo()
	{
		if (!BaseCameraGravityLerpExecutor.Debug)
		{
			return;
		}
		this.Owner.DrawCameraGravityDebugLine(this.FlatAngleGravityQuatAxis, CameraGravityLerpDebugColors.Yellow);
		this.Owner.DrawCameraGravityDebugLine(this.Owner.GetGravityStartLerpVector(), CameraGravityLerpDebugColors.Red);
		this.Owner.DrawCameraGravityDebugLine(this.Owner.GetGravityEndLerpVector(), CameraGravityLerpDebugColors.White);
		this.Owner.DrawCameraGravityDebugArrow(this.Owner.Camera.GravityUp, CameraGravityLerpDebugColors.Pink);
		this.Owner.DrawCameraGravityDebugArrow(Vector.UpVectorProxy, CameraGravityLerpDebugColors.Orange);
	}

	// Token: 0x06002121 RID: 8481 RVA: 0x000B4110 File Offset: 0x000B2310
	private void DrawGravityQuatDebugInfo(FLinearColor gravityForwardColor)
	{
		if (!BaseCameraGravityLerpExecutor.Debug)
		{
			return;
		}
		this.TempQuat.RotateVector(Vector.ForwardVectorProxy, this.TempVector5);
		this.Owner.DrawCameraGravityDebugArrow(this.TempVector5, gravityForwardColor);
		this.TempVector6.Set(this.TempQuat.X, this.TempQuat.Y, this.TempQuat.Z);
		if (this.TempQuat.W < 0.0)
		{
			this.TempVector6.MultiplyEqual(-1.0);
		}
		this.Owner.DrawCameraGravityDebugArrow(this.TempVector6, CameraGravityLerpDebugColors.Magenta);
	}

	// Token: 0x06002122 RID: 8482 RVA: 0x000B41BC File Offset: 0x000B23BC
	protected unsafe void InternalSetCameraGravityDirect(Vector gravityDirect, Vector flatAngleAxis, float flatAngleSign = 1f)
	{
		if (!gravityDirect.IsNormalized())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraGravity]设置相机重力方向失败，因为不是归一化的向量";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("gravityDirect", gravityDirect);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		FightCameraLogicComponent camera = this.Owner.Camera;
		camera.GravityDirect.DeepCopy(gravityDirect);
		camera.GravityDirect.UnaryNegation(camera.GravityUp);
		if (this.Owner.Camera.ContainsTag(GameplayTagDefine.EGameplayTagId["功能.通用镜头.锁定镜头重力空间方向"], false))
		{
			if (Math.Abs(camera.GravityUp.DotProduct(Vector.ForwardVectorProxy)) < 0.9999)
			{
				MathUtils.Instance.LookRotationUpFirst(Vector.ForwardVectorProxy, camera.GravityUp, this.TempQuat);
			}
			else
			{
				MathUtils.Instance.LookRotationUpFirst(Vector.UpVectorProxy, camera.GravityUp, this.TempQuat);
			}
			this.DrawGravityQuatDebugInfo(CameraGravityLerpDebugColors.Green);
		}
		else if (!this.IsNearOppositeGravityVector(Vector.UpVectorProxy, camera.GravityUp))
		{
			Quat.FindBetween(Vector.UpVectorProxy, camera.GravityUp, this.TempQuat);
			this.DrawGravityQuatDebugInfo(CameraGravityLerpDebugColors.Green);
		}
		else
		{
			Quat.ConstructorByAxisAngle(flatAngleAxis, (float)(3.141592653589793 * (double)flatAngleSign), this.TempQuat);
			this.DrawGravityQuatDebugInfo(CameraGravityLerpDebugColors.Blue);
		}
		camera.GravityQuat.DeepCopy(this.TempQuat);
		camera.GravityQuat.Inverse(camera.GravityInverseQuat);
		if (BaseCameraGravityLerpExecutor.Debug)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Camera;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[CameraGravity]SetCameraGravityMode";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CameraGravityDirect", camera.GravityDirect);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GravityQuaternion", camera.GravityQuat);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("flatAngleAxis", flatAngleAxis);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Rotation", camera.GravityQuat.Rotator(null));
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
	}

	// Token: 0x06002123 RID: 8483 RVA: 0x000B43C8 File Offset: 0x000B25C8
	protected bool SqLerpGravityVector(Vector from, Vector to, float alpha, Vector @out)
	{
		Vector tempVector = this.TempVector4;
		this.Owner.Camera.GetCameraTargetForward(tempVector);
		tempVector.CrossProduct(from, this.TempVector2);
		if (!this.TempVector2.Normalize(9.99999993922529E-09))
		{
			this.TempVector2.DeepCopy(Vector.RightVectorProxy);
			if (MathUtils.Instance.IsNearlyEqual(Math.Abs(Vector.DotProduct(this.TempVector2, from)), 1.0, new double?((double)0.01f)))
			{
				this.TempVector2.DeepCopy(Vector.ForwardVectorProxy);
			}
		}
		from.CrossProduct(this.TempVector2, this.TempVector3);
		if (BaseCameraGravityLerpExecutor.Debug)
		{
			this.Owner.DrawCameraGravityDebugArrow(this.TempVector2, CameraGravityLerpDebugColors.Gray);
			this.Owner.DrawCameraGravityDebugArrow(tempVector, CameraGravityLerpDebugColors.Brown);
		}
		this.TempVector3.Normalize(9.99999993922529E-09);
		this.FlatAngleGravityQuatAxis.DeepCopy(this.TempVector3);
		if (!this.IsNearOppositeGravityVector(from, to))
		{
			MathUtils.Instance.SqLerpVector(from, to, alpha, @out);
			return false;
		}
		float num = this.ResolveNearOppositeGravitySign(this.TempVector3, tempVector);
		this.FlatAngleGravityQuatSign = num;
		this.HasFlatAngleGravityQuatAxis = true;
		Quat.ConstructorByAxisAngle(this.TempVector3, (float)(3.141592653589793 * (double)alpha * (double)num), this.TempQuat);
		this.TempQuat.RotateVector(from, @out);
		return true;
	}

	// Token: 0x06002124 RID: 8484 RVA: 0x000B4530 File Offset: 0x000B2730
	protected bool IsNearOppositeGravityVector(Vector from, Vector to)
	{
		return Math.Abs(Math.Acos(MathUtils.Instance.Clamp(Vector.DotProduct(from, to), -1.0, 1.0)) * 57.295780181884766 - 180.0) <= 5.0;
	}

	// Token: 0x06002125 RID: 8485 RVA: 0x000B458C File Offset: 0x000B278C
	protected float ResolveNearOppositeGravitySign(Vector flatAngleAxis, Vector cameraTargetForward)
	{
		float? num = this.TryResolveNearOppositeGravitySignByModelBuffer(flatAngleAxis);
		if (num != null)
		{
			return num.Value;
		}
		if (!this.HasFlatAngleGravityQuatAxis)
		{
			return (float)((Vector.DotProduct(this.Owner.Camera.CameraForward, cameraTargetForward) >= 0.0) ? 1 : -1);
		}
		return this.FlatAngleGravityQuatSign;
	}

	// Token: 0x06002126 RID: 8486 RVA: 0x000B45E8 File Offset: 0x000B27E8
	protected float? TryResolveNearOppositeGravitySignByModelBuffer(Vector flatAngleAxis)
	{
		if (this.HasStableModelBufferAxis)
		{
			return new float?(this.FlatAngleGravityQuatSign);
		}
		FightCameraLogicComponent camera = this.Owner.Camera;
		bool flag;
		if (camera.EnableFocusOnVehicle)
		{
			VehicleAnimationComponent vehicleAnimationComponent = camera.VehicleAnimationComponent;
			if (vehicleAnimationComponent != null && vehicleAnimationComponent.Valid)
			{
				flag = camera.VehicleAnimationComponent.TryGetModelBufferLerpWorldRotation(this.ModelBufferStartQuat, this.ModelBufferTargetQuat);
				goto IL_9A;
			}
		}
		EntityHandle characterEntityHandle = camera.CharacterEntityHandle;
		CharacterAnimationComponent characterAnimationComponent;
		if (characterEntityHandle == null)
		{
			characterAnimationComponent = null;
		}
		else
		{
			WorldEntity entity = characterEntityHandle.Entity;
			characterAnimationComponent = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
		}
		CharacterAnimationComponent characterAnimationComponent2 = characterAnimationComponent;
		flag = (characterAnimationComponent2 != null && characterAnimationComponent2.Valid && characterAnimationComponent2.TryGetModelBufferLerpWorldRotation(this.ModelBufferStartQuat, this.ModelBufferTargetQuat));
		IL_9A:
		if (!flag)
		{
			return null;
		}
		this.ModelBufferStartQuat.Inverse(this.ModelBufferInverseQuat);
		this.ModelBufferTargetQuat.Multiply(this.ModelBufferInverseQuat, this.ModelBufferDeltaQuat);
		if (!this.ModelBufferDeltaQuat.Normalize(1E-06f))
		{
			return null;
		}
		double num = MathUtils.Instance.Clamp(this.ModelBufferDeltaQuat.W, -1.0, 1.0);
		double num2 = Math.Sqrt(1.0 - num * num);
		if (num2 < 9.999999747378752E-05)
		{
			return null;
		}
		double num3 = this.ModelBufferDeltaQuat.X / num2 * flatAngleAxis.X + this.ModelBufferDeltaQuat.Y / num2 * flatAngleAxis.Y + this.ModelBufferDeltaQuat.Z / num2 * flatAngleAxis.Z;
		if (this.ModelBufferDeltaQuat.W < 0.0)
		{
			num3 = -num3;
		}
		if (Math.Abs(num3) < 0.8660253882408142)
		{
			return null;
		}
		this.HasStableModelBufferAxis = true;
		return new float?((float)((num3 >= 0.0) ? 1 : -1));
	}

	// Token: 0x06002127 RID: 8487 RVA: 0x000B47CC File Offset: 0x000B29CC
	protected unsafe void Finish()
	{
		this.IsFinished = true;
		this.InternalSetCameraGravityDirect(this.Owner.GetGravityEndLerpVector(), this.FlatAngleGravityQuatAxis, this.FlatAngleGravityQuatSign);
		if (BaseCameraGravityLerpExecutor.Debug)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraGravity]插值设置重力方向[结束]";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("config", this.LerpConfig.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GravityDirect", this.Owner.GetCurrentCameraGravityDirect().ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FlatAngleGravityQuatSign", this.FlatAngleGravityQuatSign);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
	}

	// Token: 0x06002128 RID: 8488 RVA: 0x000B4895 File Offset: 0x000B2A95
	protected virtual void InitInternal()
	{
	}

	// Token: 0x06002129 RID: 8489 RVA: 0x000B4897 File Offset: 0x000B2A97
	protected virtual float UpdateInternal(float deltaTime)
	{
		return 1f;
	}

	// Token: 0x0600212A RID: 8490 RVA: 0x000B489E File Offset: 0x000B2A9E
	public static void CreateStaticDefaultValue()
	{
		BaseCameraGravityLerpExecutor.Debug = false;
	}

	// Token: 0x0600212B RID: 8491 RVA: 0x000B48A6 File Offset: 0x000B2AA6
	public static void ResetStaticDefaultValue()
	{
		BaseCameraGravityLerpExecutor.Debug = false;
	}

	// Token: 0x0400149C RID: 5276
	private const float COS_30_DEG = 0.8660254f;

	// Token: 0x0400149D RID: 5277
	protected const float NearOppositeGravityAngleToleranceDeg = 5f;

	// Token: 0x0400149E RID: 5278
	[Nullable(2)]
	public CameraGravityController Owner;

	// Token: 0x0400149F RID: 5279
	public CameraGravityLerpConfig LerpConfig = new CameraGravityLerpConfig();

	// Token: 0x040014A0 RID: 5280
	public bool IsFinished;

	// Token: 0x040014A1 RID: 5281
	public static bool Debug;

	// Token: 0x040014A2 RID: 5282
	protected readonly Vector TempVector = Vector.Create();

	// Token: 0x040014A3 RID: 5283
	protected readonly Vector TempVector2 = Vector.Create();

	// Token: 0x040014A4 RID: 5284
	protected readonly Vector TempVector3 = Vector.Create();

	// Token: 0x040014A5 RID: 5285
	protected readonly Vector TempVector4 = Vector.Create();

	// Token: 0x040014A6 RID: 5286
	protected readonly Vector TempVector5 = Vector.Create();

	// Token: 0x040014A7 RID: 5287
	protected readonly Vector TempVector6 = Vector.Create();

	// Token: 0x040014A8 RID: 5288
	protected readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040014A9 RID: 5289
	protected readonly Quat ModelBufferStartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040014AA RID: 5290
	protected readonly Quat ModelBufferTargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040014AB RID: 5291
	protected readonly Quat ModelBufferInverseQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040014AC RID: 5292
	protected readonly Quat ModelBufferDeltaQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040014AD RID: 5293
	protected readonly Vector FlatAngleGravityQuatAxis = Vector.Create();

	// Token: 0x040014AE RID: 5294
	public float FlatAngleGravityQuatSign = 1f;

	// Token: 0x040014AF RID: 5295
	public bool HasStableModelBufferAxis;

	// Token: 0x040014B0 RID: 5296
	protected bool HasFlatAngleGravityQuatAxis;
}
