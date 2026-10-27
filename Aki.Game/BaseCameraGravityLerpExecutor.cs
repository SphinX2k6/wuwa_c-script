using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000208 RID: 520
[NullableContext(1)]
[Nullable(0)]
public class BaseCameraGravityLerpExecutor : IStaticVariableResetter
{
	// Token: 0x0600206E RID: 8302 RVA: 0x000ACC16 File Offset: 0x000AAE16
	static BaseCameraGravityLerpExecutor()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseCameraGravityLerpExecutor.CreateStaticDefaultValue), new Action(BaseCameraGravityLerpExecutor.ResetStaticDefaultValue));
	}

	// Token: 0x0600206F RID: 8303 RVA: 0x000ACC38 File Offset: 0x000AAE38
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

	// Token: 0x06002070 RID: 8304 RVA: 0x000ACD26 File Offset: 0x000AAF26
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

	// Token: 0x06002071 RID: 8305 RVA: 0x000ACD4B File Offset: 0x000AAF4B
	public bool EnableUpdate()
	{
		return !this.IsFinished;
	}

	// Token: 0x06002072 RID: 8306 RVA: 0x000ACD58 File Offset: 0x000AAF58
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

	// Token: 0x06002073 RID: 8307 RVA: 0x000ACDF0 File Offset: 0x000AAFF0
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

	// Token: 0x06002074 RID: 8308 RVA: 0x000ACE9C File Offset: 0x000AB09C
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

	// Token: 0x06002075 RID: 8309 RVA: 0x000AD0A8 File Offset: 0x000AB2A8
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

	// Token: 0x06002076 RID: 8310 RVA: 0x000AD210 File Offset: 0x000AB410
	protected bool IsNearOppositeGravityVector(Vector from, Vector to)
	{
		return Math.Abs(Math.Acos(MathUtils.Instance.Clamp(Vector.DotProduct(from, to), -1.0, 1.0)) * 57.295780181884766 - 180.0) <= 5.0;
	}

	// Token: 0x06002077 RID: 8311 RVA: 0x000AD26C File Offset: 0x000AB46C
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

	// Token: 0x06002078 RID: 8312 RVA: 0x000AD2C8 File Offset: 0x000AB4C8
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

	// Token: 0x06002079 RID: 8313 RVA: 0x000AD4AC File Offset: 0x000AB6AC
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

	// Token: 0x0600207A RID: 8314 RVA: 0x000AD575 File Offset: 0x000AB775
	protected virtual void InitInternal()
	{
	}

	// Token: 0x0600207B RID: 8315 RVA: 0x000AD577 File Offset: 0x000AB777
	protected virtual float UpdateInternal(float deltaTime)
	{
		return 1f;
	}

	// Token: 0x0600207C RID: 8316 RVA: 0x000AD57E File Offset: 0x000AB77E
	public static void CreateStaticDefaultValue()
	{
		BaseCameraGravityLerpExecutor.Debug = false;
	}

	// Token: 0x0600207D RID: 8317 RVA: 0x000AD586 File Offset: 0x000AB786
	public static void ResetStaticDefaultValue()
	{
		BaseCameraGravityLerpExecutor.Debug = false;
	}

	// Token: 0x0400145A RID: 5210
	private const float COS_30_DEG = 0.8660254f;

	// Token: 0x0400145B RID: 5211
	protected const float NearOppositeGravityAngleToleranceDeg = 5f;

	// Token: 0x0400145C RID: 5212
	[Nullable(2)]
	public CameraGravityController Owner;

	// Token: 0x0400145D RID: 5213
	public CameraGravityLerpConfig LerpConfig = new CameraGravityLerpConfig();

	// Token: 0x0400145E RID: 5214
	public bool IsFinished;

	// Token: 0x0400145F RID: 5215
	public static bool Debug;

	// Token: 0x04001460 RID: 5216
	protected readonly Vector TempVector = Vector.Create();

	// Token: 0x04001461 RID: 5217
	protected readonly Vector TempVector2 = Vector.Create();

	// Token: 0x04001462 RID: 5218
	protected readonly Vector TempVector3 = Vector.Create();

	// Token: 0x04001463 RID: 5219
	protected readonly Vector TempVector4 = Vector.Create();

	// Token: 0x04001464 RID: 5220
	protected readonly Vector TempVector5 = Vector.Create();

	// Token: 0x04001465 RID: 5221
	protected readonly Vector TempVector6 = Vector.Create();

	// Token: 0x04001466 RID: 5222
	protected readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04001467 RID: 5223
	protected readonly Quat ModelBufferStartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04001468 RID: 5224
	protected readonly Quat ModelBufferTargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04001469 RID: 5225
	protected readonly Quat ModelBufferInverseQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400146A RID: 5226
	protected readonly Quat ModelBufferDeltaQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400146B RID: 5227
	protected readonly Vector FlatAngleGravityQuatAxis = Vector.Create();

	// Token: 0x0400146C RID: 5228
	public float FlatAngleGravityQuatSign = 1f;

	// Token: 0x0400146D RID: 5229
	public bool HasStableModelBufferAxis;

	// Token: 0x0400146E RID: 5230
	protected bool HasFlatAngleGravityQuatAxis;
}
