using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Gameplay.PilotThrow;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020025E0 RID: 9696
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
[TickController(0)]
public class PilotThrowController : ControllerBase
{
	// Token: 0x06013B55 RID: 80725 RVA: 0x004F054C File Offset: 0x004EE74C
	[NullableContext(1)]
	public unsafe void EnterInteractHookPoint(int hookPointPbDataId, int titanEntityId, List<IPilotThrowTarget> pilotThrowTarget)
	{
		this.NeedKeepCameraAndUi = true;
		PilotThrowModel.Instance.InitInteractInfo(hookPointPbDataId, titanEntityId, pilotThrowTarget);
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(hookPointPbDataId);
		WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
		if (worldEntity != null)
		{
			GrapplingHookPointComponent component = worldEntity.GetComponent<GrapplingHookPointComponent>();
			IPilotThrow pilotThrow = ((component != null) ? component.GetHookInteractConfig() : null) as IPilotThrow;
			if (pilotThrow != null)
			{
				EPilotThrowAutoThrowType? autoThrowType = pilotThrow.AutoThrowType;
				List<IPilotThrowTarget> targetList = pilotThrow.TargetList;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PilotThrow;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[PilotThrowController] EnterInteractHookPoint ";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("autoLaunchType", autoThrowType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("targetList.length", targetList.Count);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				if (autoThrowType != null && targetList.Count == 1)
				{
					global::Vector vector = global::Vector.Create((double)targetList[0].Position.X.GetValueOrDefault(), (double)targetList[0].Position.Y.GetValueOrDefault(), (double)targetList[0].Position.Z.GetValueOrDefault());
					BaseActorComponent component2 = worldEntity.GetComponent<BaseActorComponent>();
					global::Vector vector2 = global::Vector.Create((component2 != null) ? component2.ActorLocationProxy : null);
					float flySpeed = pilotThrow.FlySpeed;
					float num = pilotThrow.Gravity ?? PilotThrowModel.Instance.Setting.重力加速度;
					global::Vector vector3 = this.CalculateLaunchAngle(vector2, vector, num, flySpeed, autoThrowType.Value);
					if (vector3 != null)
					{
						PilotThrowModel.Instance.LaunchDirection.DeepCopy(vector3);
						PilotThrowModel.Instance.LaunchSpeed = flySpeed;
						PilotThrowModel.Instance.LaunchGravity = num;
						PilotThrowModel.Instance.NeedMotorRide = pilotThrow.IsAutoRide.GetValueOrDefault();
						PilotThrowModel.Instance.DisableInterrupt = pilotThrow.DisableInterrupt.GetValueOrDefault();
						global::Vector vector4 = global::Vector.Create();
						vector4.DeepCopy(vector);
						vector4.SubtractionEqual(vector2);
						vector4.Normalize(9.99999993922529E-09);
						PilotThrowModel.Instance.ForceLookDir = vector4;
						EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
						if (getCurrentEntity == null || getCurrentEntity.Entity == null)
						{
							Log.Instance.Error(ELogModule.PilotThrow, ELogAuthor.CH, "PilotThrowController.EnterInteractHookPoint:当前编队实体为空", default(ReadOnlySpan<ValueTuple<string, object>>));
							return;
						}
						getCurrentEntity.Entity.GetComponent<CharacterSkillComponent>().BeginSkillAsync(210043, null).Forget<bool>();
						TimerSystem.Instance.Delay(delegate(float _)
						{
							this.RequestChangePilotState(true);
						}, PilotThrowModel.Instance.Setting.自动投掷转状态延迟 * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
						this.NeedKeepCameraAndUi = false;
					}
					else
					{
						Log.Instance.Error(ELogModule.PilotThrow, ELogAuthor.CH, "[PilotThrowController] EnterInteractHookPoint CalculateLaunchAngle result is null", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
				}
			}
		}
		else
		{
			Log.Instance.Error(ELogModule.PilotThrow, ELogAuthor.CH, "[PilotThrowController] EnterInteractHookPoint hookPointConfig is null", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		PilotThrowModel.Instance.CurrentInRangePoint = null;
		if (this.NeedKeepCameraAndUi)
		{
			TimerSystem.Instance.Delay(delegate(float _)
			{
				UiManager.Instance.OpenView(EUiViewName.PilotThrowView, null, null);
			}, 1000f, null, null, true, 1f);
		}
	}

	// Token: 0x17001946 RID: 6470
	// (get) Token: 0x06013B56 RID: 80726 RVA: 0x004F08B6 File Offset: 0x004EEAB6
	public USplineComponent ProjectileSpline
	{
		get
		{
			return this.CacheProjectileSplineComp;
		}
	}

	// Token: 0x06013B57 RID: 80727 RVA: 0x004F08C0 File Offset: 0x004EEAC0
	public void GenerateProjectilePoints()
	{
		if (this.PathPositions == null)
		{
			this.PathPositions = new TArray<FVectorDouble>();
		}
		BP_PilotThrowGameplaySetting_C setting = PilotThrowModel.Instance.Setting;
		if (setting == null)
		{
			Log.Instance.Error(ELogModule.PilotThrow, ELogAuthor.CH, "[PilotThrowController] GenerateProjectilePoints setting is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		IGuideEffectSpline guideEffectSpline = GameSplineUtils.GenerateGuideEffect(CameraController.Instance.MainModel.CameraLocation, this.PathPositions, setting.样条特效.ToAssetPathName());
		if (guideEffectSpline == null)
		{
			Log.Instance.Error(ELogModule.PilotThrow, ELogAuthor.CH, "[PilotThrowController] GenerateProjectilePoints projectileSpine is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || getCurrentEntity.Entity == null)
		{
			Log.Instance.Error(ELogModule.PilotThrow, ELogAuthor.CH, "[PilotThrowController] GenerateProjectilePoints currentEntity is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.CacheProjectileEffectHandle = new int?(guideEffectSpline.EffectHandle);
		this.CacheProjectileActor = guideEffectSpline.SplineActor;
		this.CacheProjectileSplineComp = guideEffectSpline.SplineComp;
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
		this.FinalDestinationEffectHandle = new int?(instance.SpawnEffect(world, ftransformDouble, setting.终点特效.ToAssetPathName(), "[PilotThrowController] FinalDestinationEffectHandle", new EffectContext(new int?(getCurrentEntity.Entity.Id), null, false), EEffectType.Scene, null, null, null, false, false));
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(PilotThrowModel.Instance.GetCurrentInteractHookPoint());
		object obj;
		if (entityByPbDataId == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = entityByPbDataId.Entity;
			if (entity == null)
			{
				obj = null;
			}
			else
			{
				GrapplingHookPointComponent component = entity.GetComponent<GrapplingHookPointComponent>();
				obj = ((component != null) ? component.GetHookInteractConfig() : null);
			}
		}
		IPilotThrow pilotThrow = obj as IPilotThrow;
		PilotThrowModel.Instance.LaunchSpeed = ((pilotThrow != null) ? pilotThrow.FlySpeed : setting.初速度);
		PilotThrowModel.Instance.LaunchGravity = (((pilotThrow != null) ? pilotThrow.Gravity : null) ?? setting.重力加速度);
		PilotThrowModel.Instance.NeedMotorRide = ((pilotThrow != null) ? pilotThrow.IsAutoRide : null).GetValueOrDefault();
		PilotThrowModel.Instance.DisableInterrupt = ((pilotThrow != null) ? pilotThrow.DisableInterrupt : null).GetValueOrDefault();
		base.ResumeTick();
	}

	// Token: 0x06013B58 RID: 80728 RVA: 0x004F0AFC File Offset: 0x004EECFC
	public void ClearProjectilePoints()
	{
		if (this.CacheProjectileEffectHandle != null && EffectSystem.Instance.IsValid(this.CacheProjectileEffectHandle.Value))
		{
			EffectSystem.Instance.StopEffectById(this.CacheProjectileEffectHandle.Value, "[PortalController] ClearProjectilePoints", true, null);
			this.CacheProjectileEffectHandle = null;
		}
		if (this.FinalDestinationEffectHandle != null && EffectSystem.Instance.IsValid(this.FinalDestinationEffectHandle.Value))
		{
			EffectSystem.Instance.StopEffectById(this.FinalDestinationEffectHandle.Value, "[PortalController] ClearProjectilePoints", true, null);
			this.FinalDestinationEffectHandle = null;
		}
		if (this.CacheProjectileActor != null && this.CacheProjectileActor.IsValid())
		{
			ActorSystem.Instance.Put("PilotThrowController.ClearProjectilePoints", this.CacheProjectileActor, null);
			this.CacheProjectileActor = null;
			this.CacheProjectileSplineComp = null;
		}
		base.PauseTick();
	}

	// Token: 0x06013B59 RID: 80729 RVA: 0x004F0BF4 File Offset: 0x004EEDF4
	private void UpdateProjectileSpline()
	{
		if (this.CacheProjectileSplineComp == null)
		{
			return;
		}
		BP_PilotThrowGameplaySetting_C setting = PilotThrowModel.Instance.Setting;
		if (setting == null)
		{
			Log.Instance.Error(ELogModule.PilotThrow, ELogAuthor.CH, "[PilotThrowController] UpdateProjectileSpline setting is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || getCurrentEntity.Entity == null)
		{
			Log.Instance.Error(ELogModule.PilotThrow, ELogAuthor.CH, "[PilotThrowController] UpdateProjectileSpline curEntity is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		CharacterActorComponent component = getCurrentEntity.Entity.GetComponent<CharacterActorComponent>();
		if (component == null || component.Owner == null || !component.Owner.IsValid())
		{
			Log.Instance.Error(ELogModule.PilotThrow, ELogAuthor.CH, "[PilotThrowController] UpdateProjectileSpline actorComp is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int currentInteractHookPoint = PilotThrowModel.Instance.GetCurrentInteractHookPoint();
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(currentInteractHookPoint);
		WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
		object obj;
		if (worldEntity == null)
		{
			obj = null;
		}
		else
		{
			GrapplingHookPointComponent component2 = worldEntity.GetComponent<GrapplingHookPointComponent>();
			obj = ((component2 != null) ? component2.GetHookInteractConfig() : null);
		}
		IPilotThrow pilotThrow = obj as IPilotThrow;
		if (pilotThrow == null)
		{
			Log.Instance.Error(ELogModule.PilotThrow, ELogAuthor.CH, "[PilotThrowController] UpdateProjectileSpline hookPointConfig is null", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		float overrideGravityZ = pilotThrow.Gravity ?? setting.重力加速度;
		float flySpeed = pilotThrow.FlySpeed;
		global::Vector vector = global::Vector.Create(CameraController.Instance.MainModel.CameraLocation);
		global::Vector vector2 = global::Vector.Create();
		global::Rotator rotator = global::Rotator.Create(CameraController.Instance.MainModel.CameraRotator.Pitch, CameraController.Instance.MainModel.CameraRotator.Yaw, 0f);
		FTransformDouble ftransformDouble = new FTransformDouble();
		FVectorDouble fvectorDouble = vector.ToUeVector(false);
		ftransformDouble.SetLocation(fvectorDouble);
		FQuat fquat = rotator.ToUeRotator().Quaternion();
		ftransformDouble.SetRotation(fquat);
		global::Vector vector3 = vector2;
		fvectorDouble = setting.抛物线起点偏移;
		FVectorDouble fvectorDouble2 = ftransformDouble.TransformVector(fvectorDouble);
		vector3.FromUeVector(fvectorDouble2);
		vector.AdditionEqual(vector2);
		this.LauncherVelocity.Set(0.0, 0.0, 0.0);
		this.CameraRot.DeepCopy(CameraController.Instance.MainModel.CameraRotator);
		if (this.OffsetRot == null)
		{
			this.OffsetRot = global::Rotator.Create(setting.初速度仰角, 0f, 0f);
		}
		MathUtils.Instance.ComposeRotator(this.OffsetRot, this.CameraRot, MathUtils.Instance.CommonTempRotator);
		MathUtils.Instance.CommonTempRotator.Vector(this.LauncherVelocity);
		this.LauncherVelocity.Normalize(9.99999993922529E-09);
		PilotThrowModel.Instance.LaunchDirection.DeepCopy(this.LauncherVelocity);
		this.LauncherVelocity.MultiplyEqual((double)flySpeed);
		if (this.TraceObjectTypes == null)
		{
			this.TraceObjectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>();
			this.TraceObjectTypes.Add(KuroObjectTypeQuery.WorldStatic);
			this.TraceObjectTypes.Add(KuroObjectTypeQuery.Destructible);
			this.TraceObjectTypes.Add(KuroObjectTypeQuery.WorldStaticIgnoreBullet);
		}
		if (this.ProjectilePathParams == null)
		{
			this.ProjectilePathParams = new FPredictProjectilePathParams();
		}
		FVector startLocation = UKismetMathLibrary.WD_WorldToLocal(GlobalData.World, vector.ToUeVector(false));
		this.ProjectilePathParams.StartLocation = startLocation;
		this.ProjectilePathParams.LaunchVelocity = this.LauncherVelocity.ToUeVectorOld();
		this.ProjectilePathParams.bTraceWithCollision = true;
		this.ProjectilePathParams.ProjectileRadius = setting.射线检测半径;
		this.ProjectilePathParams.ObjectTypes = this.TraceObjectTypes;
		this.ProjectilePathParams.bTraceComplex = false;
		this.ProjectilePathParams.DrawDebugType = (setting.DebugMode ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None);
		this.ProjectilePathParams.DrawDebugTime = 0.1f;
		this.ProjectilePathParams.MaxSimTime = 40f;
		this.ProjectilePathParams.SimFrequency = 3f;
		this.ProjectilePathParams.OverrideGravityZ = overrideGravityZ;
		TArray<AActor> tarray = new TArray<AActor>();
		tarray.Add(component.Owner);
		this.ProjectilePathParams.ActorsToIgnore = tarray;
		FPredictProjectilePathResult projectilePathResult = new FPredictProjectilePathResult();
		bool flag = UGameplayStatics.Blueprint_PredictProjectilePath_Advanced(GlobalData.World, this.ProjectilePathParams, ref projectilePathResult);
		this.ProjectilePathResult = projectilePathResult;
		TArray<FPredictProjectilePathPointData> pathData = this.ProjectilePathResult.PathData;
		if (this.PathPositions == null)
		{
			this.PathPositions = new TArray<FVectorDouble>();
		}
		else
		{
			this.PathPositions.Empty(true);
		}
		FVectorDouble fvectorDouble3 = new FVectorDouble(ref startLocation);
		for (int i = 0; i < pathData.Num(); i++)
		{
			FVector location = pathData[i].Location;
			FVectorDouble value = new FVectorDouble(ref location);
			value = value - fvectorDouble3;
			this.PathPositions.Add(value);
		}
		this.CacheProjectileSplineComp.D_SetSplinePoints(this.PathPositions, ESplineCoordinateSpace.Local, true);
		FHitResult fhitResult = new FHitResult();
		this.CacheProjectileActor.D_K2_SetActorLocation(vector.ToUeVector(false), false, ref fhitResult, true);
		global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
		fvectorDouble = this.PathPositions[this.PathPositions.Num() - 1];
		commonTempVector.FromUeVector(fvectorDouble);
		MathUtils.Instance.CommonTempVector.AdditionEqual(vector);
		PilotThrowModel.Instance.ProjectileSplineLastPoint.DeepCopy(MathUtils.Instance.CommonTempVector);
		if (!flag)
		{
			if (this.FinalDestinationEffectHandle != null && EffectSystem.Instance.IsValid(this.FinalDestinationEffectHandle.Value))
			{
				EffectSystem.Instance.StopEffectById(this.FinalDestinationEffectHandle.Value, "[PortalController] ClearProjectilePoints", true, null);
				this.FinalDestinationEffectHandle = null;
			}
			return;
		}
		if (this.FinalDestinationEffectHandle != null && EffectSystem.Instance.IsValid(this.FinalDestinationEffectHandle.Value))
		{
			FHitResult fhitResult2 = new FHitResult();
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.FinalDestinationEffectHandle.Value);
			fvectorDouble = MathUtils.Instance.CommonTempVector.ToUeVector(false);
			effectActor.D_K2_SetActorLocation(fvectorDouble, false, ref fhitResult2, true);
			return;
		}
		EntityHandle getCurrentEntity2 = SceneTeamModel.Instance.GetCurrentEntity;
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble2 = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
		this.FinalDestinationEffectHandle = new int?(instance.SpawnEffect(world, ftransformDouble2, setting.终点特效.ToAssetPathName(), "[PilotThrowController] FinalDestinationEffectHandle", new EffectContext(new int?(getCurrentEntity2.Entity.Id), null, false), EEffectType.Scene, null, null, null, false, false));
	}

	// Token: 0x06013B5A RID: 80730 RVA: 0x004F126B File Offset: 0x004EF46B
	protected override void OnTick(float delta)
	{
		this.UpdateProjectileSpline();
	}

	// Token: 0x06013B5B RID: 80731 RVA: 0x004F1273 File Offset: 0x004EF473
	protected override bool OnInit()
	{
		base.PauseTick();
		return true;
	}

	// Token: 0x06013B5C RID: 80732 RVA: 0x004F127C File Offset: 0x004EF47C
	[NullableContext(1)]
	[return: Nullable(2)]
	private unsafe global::Vector CalculateLaunchAngle(global::Vector startPos, global::Vector targetPos, float gravity, float v0, EPilotThrowAutoThrowType launchType)
	{
		global::Vector vector = global::Vector.Create();
		vector.DeepCopy(targetPos);
		vector.SubtractionEqual(startPos);
		float num = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
		double z = vector.Z;
		if (num < 0.001f)
		{
			if (z > 0.0 && (double)(v0 * v0) >= (double)(2f * Math.Abs(gravity)) * z)
			{
				return global::Vector.Create(0.0, 0.0, 1.0);
			}
			return null;
		}
		else
		{
			float num2 = num;
			double num3 = z;
			float num4 = Math.Abs(gravity);
			float num5 = v0 * v0;
			double num6 = (double)(num5 * num5) - (double)num4 * ((double)(num4 * num2 * num2) + (double)(2f * num5) * num3);
			if (num6 < 0.0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PilotThrow;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[PilotThrowController] CalculateLaunchAngle 初速度不足或参数设置错误";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("距离", num2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("高度差", num3);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("初速度", v0);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("重力", num4);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return null;
			}
			float num7 = (float)Math.Sqrt(num6);
			float num8 = (num5 + num7) / (num4 * num2);
			float num9 = (num5 - num7) / (num4 * num2);
			Func<float, float, float> func;
			if (launchType != EPilotThrowAutoThrowType.HighAngle)
			{
				if ((func = PilotThrowController.<>O.<1>__Min) == null)
				{
					func = (PilotThrowController.<>O.<1>__Min = new Func<float, float, float>(Math.Min));
				}
			}
			else if ((func = PilotThrowController.<>O.<0>__Max) == null)
			{
				func = (PilotThrowController.<>O.<0>__Max = new Func<float, float, float>(Math.Max));
			}
			float num10 = (float)Math.Atan((double)((func(Math.Abs(num8), Math.Abs(num9)) == Math.Abs(num8)) ? num8 : num9));
			float num11 = (float)Math.Atan2(vector.Y, vector.X);
			global::Rotator rotator = global::Rotator.Create(num10, num11, 0f);
			global::Vector outV = global::Vector.Create();
			rotator.Vector(outV);
			global::Vector vector2 = global::Vector.Create();
			vector2.X = (double)((float)(Math.Cos((double)num10) * Math.Cos((double)num11)));
			vector2.Y = (double)((float)(Math.Cos((double)num10) * Math.Sin((double)num11)));
			vector2.Z = (double)((float)Math.Sin((double)num10));
			vector2.Normalize(9.99999993922529E-09);
			return vector2;
		}
	}

	// Token: 0x06013B5D RID: 80733 RVA: 0x004F150C File Offset: 0x004EF70C
	public void RequestChangePilotState(bool isLaunch)
	{
		PilotThrowOperationRequest pilotThrowOperationRequest = PilotThrowOperationRequest.Create();
		pilotThrowOperationRequest.OpType = (isLaunch ? PilotThrowOperationType.Ptothrow : PilotThrowOperationType.Ptocancel);
		Net.Instance.Call(ERequestMessageId.PilotThrowOperationRequest, pilotThrowOperationRequest, delegate(IMessage response, Net.CallbackStatus _)
		{
		}, 0);
	}

	// Token: 0x17001947 RID: 6471
	// (get) Token: 0x06013B5E RID: 80734 RVA: 0x004F155C File Offset: 0x004EF75C
	[Nullable(1)]
	public static PilotThrowController Instance
	{
		[NullableContext(1)]
		get
		{
			return PilotThrowController._Instance;
		}
	}

	// Token: 0x06013B5F RID: 80735 RVA: 0x004F1563 File Offset: 0x004EF763
	[NullableContext(1)]
	public static PilotThrowController GetOrCreateInstance()
	{
		if (PilotThrowController._Instance == null)
		{
			PilotThrowController.CreateInstance();
		}
		return PilotThrowController._Instance;
	}

	// Token: 0x06013B60 RID: 80736 RVA: 0x004F1577 File Offset: 0x004EF777
	public static bool CreateInstance()
	{
		if (PilotThrowController._Instance != null)
		{
			return true;
		}
		PilotThrowController._Instance = new PilotThrowController();
		return true;
	}

	// Token: 0x06013B61 RID: 80737 RVA: 0x004F158D File Offset: 0x004EF78D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013B62 RID: 80738 RVA: 0x004F158F File Offset: 0x004EF78F
	public static void ResetStaticDefaultValue()
	{
		PilotThrowController._Instance = null;
	}

	// Token: 0x06013B63 RID: 80739 RVA: 0x004F1597 File Offset: 0x004EF797
	static PilotThrowController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PilotThrowController.CreateStaticDefaultValue), new Action(PilotThrowController.ResetStaticDefaultValue));
	}

	// Token: 0x04009471 RID: 38001
	public bool NeedKeepCameraAndUi = true;

	// Token: 0x04009472 RID: 38002
	private TArray<FVectorDouble> PathPositions;

	// Token: 0x04009473 RID: 38003
	private int? CacheProjectileEffectHandle;

	// Token: 0x04009474 RID: 38004
	private AActor CacheProjectileActor;

	// Token: 0x04009475 RID: 38005
	private USplineComponent CacheProjectileSplineComp;

	// Token: 0x04009476 RID: 38006
	private int? FinalDestinationEffectHandle;

	// Token: 0x04009477 RID: 38007
	[Nullable(new byte[]
	{
		2,
		0
	})]
	private TArray<TEnumAsByte<EObjectTypeQuery>> TraceObjectTypes;

	// Token: 0x04009478 RID: 38008
	private FPredictProjectilePathParams ProjectilePathParams;

	// Token: 0x04009479 RID: 38009
	private FPredictProjectilePathResult ProjectilePathResult;

	// Token: 0x0400947A RID: 38010
	[Nullable(1)]
	private readonly global::Vector LauncherVelocity = global::Vector.Create();

	// Token: 0x0400947B RID: 38011
	[Nullable(1)]
	private readonly global::Rotator CameraRot = global::Rotator.Create();

	// Token: 0x0400947C RID: 38012
	private global::Rotator OffsetRot;

	// Token: 0x0400947D RID: 38013
	private const int PILOT_AUTO_THROW_SKILL_ID = 210043;

	// Token: 0x0400947E RID: 38014
	private static PilotThrowController _Instance;

	// Token: 0x02008C18 RID: 35864
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402D7B8 RID: 186296
		[Nullable(0)]
		public static Func<float, float, float> <0>__Max;

		// Token: 0x0402D7B9 RID: 186297
		[Nullable(0)]
		public static Func<float, float, float> <1>__Min;
	}
}
