using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ProjectPuzzle
{
	// Token: 0x02006AB7 RID: 27319
	[NullableContext(1)]
	[Nullable(0)]
	public class ProjectorPuzzleController
	{
		// Token: 0x06043DED RID: 277997 RVA: 0x010A25E8 File Offset: 0x010A07E8
		public static void StartProjectorPuzzle(int entityId, Action<bool> finishCallback)
		{
			ProjectorComponent projectorComponent = ProjectorPuzzleController.ValidateAndGetProjectorComponent(entityId, finishCallback);
			if (projectorComponent == null)
			{
				return;
			}
			ProjectorPuzzleController.CloseGameplay(false, false, false);
			ProjectorComponent projectorConfig = projectorComponent.ProjectorConfig;
			Rotator[] targetRotators = projectorComponent.TargetRotators;
			ProjectorModel instance = ProjectorModel.Instance;
			instance.Reset();
			float valueOrDefault = projectorConfig.DragRotationCoefficient.GetValueOrDefault();
			instance.InitFromComponent(entityId, projectorConfig.RotationSpeed, valueOrDefault, projectorConfig.MatchTolerance, targetRotators, finishCallback);
			ProjectorPuzzleController.StartGameplayAsync(projectorComponent);
		}

		// Token: 0x06043DEE RID: 277998 RVA: 0x010A2650 File Offset: 0x010A0850
		private static UniTask StartGameplayAsync(ProjectorComponent projectorComponent)
		{
			ProjectorPuzzleController.<StartGameplayAsync>d__9 <StartGameplayAsync>d__;
			<StartGameplayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartGameplayAsync>d__.projectorComponent = projectorComponent;
			<StartGameplayAsync>d__.<>1__state = -1;
			<StartGameplayAsync>d__.<>t__builder.Start<ProjectorPuzzleController.<StartGameplayAsync>d__9>(ref <StartGameplayAsync>d__);
			return <StartGameplayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043DEF RID: 277999 RVA: 0x010A2694 File Offset: 0x010A0894
		[return: Nullable(2)]
		private unsafe static ProjectorComponent ValidateAndGetProjectorComponent(int entityId, Action<bool> finishCallback)
		{
			ProjectorPuzzleController.<>c__DisplayClass10_0 CS$<>8__locals1;
			CS$<>8__locals1.finishCallback = finishCallback;
			Entity entity = EntitySystem.Instance.Get(entityId);
			if (entity == null)
			{
				return ProjectorPuzzleController.<ValidateAndGetProjectorComponent>g__Fail|10_0("ProjectorPuzzle启动失败，实体不存在", default(ReadOnlySpan<ValueTuple<string, object>>), ref CS$<>8__locals1);
			}
			ProjectorComponent component = entity.GetComponent<ProjectorComponent>();
			if (component == null)
			{
				return ProjectorPuzzleController.<ValidateAndGetProjectorComponent>g__Fail|10_0("ProjectorPuzzle启动失败，缺少ProjectorComponent组件", default(ReadOnlySpan<ValueTuple<string, object>>), ref CS$<>8__locals1);
			}
			ProjectorComponent projectorConfig = component.ProjectorConfig;
			if (projectorConfig == null)
			{
				return ProjectorPuzzleController.<ValidateAndGetProjectorComponent>g__Fail|10_0("ProjectorPuzzle启动失败，缺少ProjectorComponent配置", default(ReadOnlySpan<ValueTuple<string, object>>), ref CS$<>8__locals1);
			}
			if (component.Pattern == null)
			{
				string message = "ProjectorPuzzle启动失败，找不到投影仪玩法配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ProjectorPatternId", projectorConfig.ProjectorPatternId);
				return ProjectorPuzzleController.<ValidateAndGetProjectorComponent>g__Fail|10_0(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple), ref CS$<>8__locals1);
			}
			if (component.TargetRotators.Length == 0)
			{
				return ProjectorPuzzleController.<ValidateAndGetProjectorComponent>g__Fail|10_0("ProjectorPuzzle启动失败，RotationTargetAngles为空", default(ReadOnlySpan<ValueTuple<string, object>>), ref CS$<>8__locals1);
			}
			if (string.IsNullOrEmpty(component.MeshPath))
			{
				return ProjectorPuzzleController.<ValidateAndGetProjectorComponent>g__Fail|10_0("ProjectorPuzzle启动失败，被投影物mesh为空", default(ReadOnlySpan<ValueTuple<string, object>>), ref CS$<>8__locals1);
			}
			int backgroundEntityId = component.BackgroundEntityId;
			string backgroundDecalPath = component.BackgroundDecalPath;
			if (backgroundEntityId == 0 || string.IsNullOrEmpty(backgroundDecalPath))
			{
				string message2 = "ProjectorPuzzle启动失败，背景板配置缺失";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BackgroundEntityId", backgroundEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BackgroundDecalPath", backgroundDecalPath);
				return ProjectorPuzzleController.<ValidateAndGetProjectorComponent>g__Fail|10_0(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2), ref CS$<>8__locals1);
			}
			return component;
		}

		// Token: 0x06043DF0 RID: 278000 RVA: 0x010A2804 File Offset: 0x010A0A04
		public static void CloseGameplay(bool callFinishCallback = false, bool closeView = true, bool result = false)
		{
			ProjectorModel instance = ProjectorModel.Instance;
			if (instance == null || !instance.IsActive)
			{
				return;
			}
			object obj = callFinishCallback ? instance.FinishCallback : null;
			int backgroundDecalEffectId = instance.BackgroundDecalEffectId;
			if (EffectSystem.Instance.IsValid(backgroundDecalEffectId))
			{
				EffectSystem.Instance.StopEffectById(backgroundDecalEffectId, "[ProjectorPuzzleController] DelayStopBackgroundDecal", false, new bool?(false));
			}
			ProjectorPuzzleController.StopRotationAudio();
			ProjectorPuzzleController.ReleaseShadowCompensationActor(instance);
			instance.Reset();
			if (closeView)
			{
				UiManager.Instance.CloseView(EUiViewName.ProjectorPuzzleView, null);
			}
			object obj2 = obj;
			if (obj2 == null)
			{
				return;
			}
			obj2(result);
		}

		// Token: 0x06043DF1 RID: 278001 RVA: 0x010A288C File Offset: 0x010A0A8C
		public static void ResetGameplay()
		{
			ProjectorModel instance = ProjectorModel.Instance;
			AActor aactor = (instance != null) ? instance.AttachActor : null;
			if (instance == null || !instance.IsActive || aactor == null || !aactor.IsValid())
			{
				return;
			}
			instance.IsCompleted = false;
			ProjectorPuzzleController.StopRotationAudio();
			instance.ResetInputState();
			ProjectorPuzzleController.ResetAttachActorRotation(aactor, instance.InitialAttachRelativeRotator);
		}

		// Token: 0x06043DF2 RID: 278002 RVA: 0x010A28E4 File Offset: 0x010A0AE4
		public static void BeginInput(float localX, float localY, double width, double height)
		{
			ProjectorModel instance = ProjectorModel.Instance;
			if (instance == null || !instance.IsActive || instance.IsCompleted)
			{
				return;
			}
			instance.DragCenterX = localX;
			instance.DragCenterY = localY;
			ProjectorPuzzleController.GetArcballVector(localX, localY, width, height, instance.DragCenterX, instance.DragCenterY, instance.LastArcballVector);
			instance.HasLastArcballVector = true;
		}

		// Token: 0x06043DF3 RID: 278003 RVA: 0x010A293C File Offset: 0x010A0B3C
		public static void UpdateInput(float localX, float localY, double width, double height)
		{
			ProjectorModel instance = ProjectorModel.Instance;
			if (instance == null || !instance.IsActive || instance.IsCompleted)
			{
				return;
			}
			if (!instance.HasLastArcballVector)
			{
				ProjectorPuzzleController.BeginInput(localX, localY, width, height);
				return;
			}
			ProjectorPuzzleController.GetArcballVector(localX, localY, width, height, instance.DragCenterX, instance.DragCenterY, instance.TempArcballVector);
			if (ProjectorPuzzleController.ShouldRecenterArcball(localX, localY, width, height, instance.DragCenterX, instance.DragCenterY))
			{
				instance.DragCenterX = localX;
				instance.DragCenterY = localY;
				ProjectorPuzzleController.GetArcballVector(localX, localY, width, height, instance.DragCenterX, instance.DragCenterY, instance.TempArcballVector);
				instance.LastArcballVector.DeepCopy(instance.TempArcballVector);
				return;
			}
			ProjectorPuzzleController.ApplyArcballRotation(instance.LastArcballVector, instance.TempArcballVector);
			instance.LastArcballVector.DeepCopy(instance.TempArcballVector);
		}

		// Token: 0x06043DF4 RID: 278004 RVA: 0x010A2A04 File Offset: 0x010A0C04
		public static void EndInput()
		{
			ProjectorModel instance = ProjectorModel.Instance;
			if (instance == null || !instance.IsActive)
			{
				return;
			}
			instance.HasLastArcballVector = false;
		}

		// Token: 0x06043DF5 RID: 278005 RVA: 0x010A2A2C File Offset: 0x010A0C2C
		public static void Update(float delta, float rollInput = 0f)
		{
			ProjectorModel instance = ProjectorModel.Instance;
			if (instance == null || !instance.IsActive || instance.IsCompleted)
			{
				return;
			}
			if ((double)Math.Abs(rollInput) > 1E-08)
			{
				ProjectorPuzzleController.ApplyRollRotation(rollInput, delta);
			}
			ProjectorPuzzleController.CheckRotationMatch();
			ProjectorPuzzleController.UpdateShadowCompensation();
			ProjectorPuzzleController.UpdateRotationAudio(delta);
		}

		// Token: 0x06043DF6 RID: 278006 RVA: 0x010A2A7C File Offset: 0x010A0C7C
		public static void UpdateStickRotation(float inputX, float inputY, float delta)
		{
			ProjectorModel instance = ProjectorModel.Instance;
			AActor aactor = (instance != null) ? instance.AttachActor : null;
			if (instance == null || instance.IsCompleted || aactor == null || !aactor.IsValid())
			{
				return;
			}
			if ((double)Math.Abs(inputX) <= 1E-08 && (double)Math.Abs(inputY) <= 1E-08)
			{
				return;
			}
			float num = delta * 0.001f;
			if (num <= 0f)
			{
				return;
			}
			float rotationSpeed = instance.RotationSpeed;
			if (rotationSpeed <= 0f)
			{
				return;
			}
			float num2 = -inputX * rotationSpeed * 0.017453292f * num;
			float num3 = inputY * rotationSpeed * 0.017453292f * num;
			if ((double)Math.Abs(num2) <= 1E-08 && (double)Math.Abs(num3) <= 1E-08)
			{
				return;
			}
			if (ProjectorPuzzleController.TryGetReferenceRotation(instance.TempRotator))
			{
				instance.TempRotator.Quaternion(instance.TempQuat2);
				instance.TempAxis.Set(0.0, 0.0, 1.0);
				instance.TempQuat2.RotateVector(instance.TempAxis, instance.TempWorldAxis);
				instance.TempAxis.Set(1.0, 0.0, 0.0);
				instance.TempQuat2.RotateVector(instance.TempAxis, instance.TempArcballVector);
			}
			else
			{
				instance.TempWorldAxis.Set(0.0, 0.0, 1.0);
				instance.TempArcballVector.Set(1.0, 0.0, 0.0);
			}
			if ((double)Math.Abs(num2) > 1E-08 && !instance.TempWorldAxis.IsNearlyZero(1E-08))
			{
				instance.TempWorldAxis.Normalize(9.99999993922529E-09);
				Quat.ConstructorByAxisAngle(instance.TempWorldAxis, num2, instance.TempQuat);
				instance.TempQuat2.FromUeQuat(aactor.K2_GetActorQuaternion());
				instance.TempQuat.Multiply(instance.TempQuat2, instance.TempQuat2);
				instance.TempQuat2.Rotator(instance.TempRotator);
				aactor.K2_SetActorRotation(instance.TempRotator.ToUeRotator(), false);
				instance.FrameStickAngle += Math.Abs(num2);
			}
			if ((double)Math.Abs(num3) > 1E-08 && !instance.TempArcballVector.IsNearlyZero(1E-08))
			{
				instance.TempArcballVector.Normalize(9.99999993922529E-09);
				Quat.ConstructorByAxisAngle(instance.TempArcballVector, num3, instance.TempQuat);
				instance.TempQuat2.FromUeQuat(aactor.K2_GetActorQuaternion());
				instance.TempQuat.Multiply(instance.TempQuat2, instance.TempQuat2);
				instance.TempQuat2.Rotator(instance.TempRotator);
				aactor.K2_SetActorRotation(instance.TempRotator.ToUeRotator(), false);
				instance.FrameStickAngle += Math.Abs(num3);
			}
		}

		// Token: 0x06043DF7 RID: 278007 RVA: 0x010A2D98 File Offset: 0x010A0F98
		private unsafe static bool SetupBackgroundDecal(int backgroundEntityId, string decalPath)
		{
			ProjectorModel instance = ProjectorModel.Instance;
			if (instance == null || !instance.IsActive)
			{
				return false;
			}
			CreatureModel instance2 = CreatureModel.Instance;
			EntityHandle entityHandle = (instance2 != null) ? instance2.GetEntityByPbDataId(backgroundEntityId) : null;
			WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
			if (worldEntity == null || !worldEntity.IsInit)
			{
				Log instance3 = Log.Instance;
				ELogModule module = ELogModule.ProjectorPuzzle;
				ELogAuthor author = ELogAuthor.WRY;
				string message = "ProjectorPuzzle背景板实体无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BackgroundEntityId", backgroundEntityId);
				instance3.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			SceneItemActorComponent component = worldEntity.GetComponent<SceneItemActorComponent>();
			AActor aactor = (component != null) ? component.Owner : null;
			if (aactor == null || !aactor.IsValid())
			{
				Log instance4 = Log.Instance;
				ELogModule module2 = ELogModule.ProjectorPuzzle;
				ELogAuthor author2 = ELogAuthor.WRY;
				string message2 = "ProjectorPuzzle背景板Actor无效";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("BackgroundEntityId", backgroundEntityId);
				instance4.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			AActor aactor2 = (component != null) ? component.GetActorInSceneInteraction("ProjectorDecalAttachActor") : null;
			if (aactor2 == null || !aactor2.IsValid())
			{
				Log instance5 = Log.Instance;
				ELogModule module3 = ELogModule.ProjectorPuzzle;
				ELogAuthor author3 = ELogAuthor.WRY;
				string message3 = "ProjectorPuzzle背景贴花挂点Actor无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BackgroundEntityId", backgroundEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AttachActorKey", "ProjectorDecalAttachActor");
				instance5.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			FTransformDouble value = new FTransformDouble();
			FVectorDouble fvectorDouble = aactor2.D_K2_GetActorLocation();
			value.SetLocation(fvectorDouble);
			FQuat fquat = aactor2.K2_GetActorQuaternion();
			value.SetRotation(fquat);
			EffectSystem instance6 = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(value);
			int num = instance6.SpawnEffect(world, ftransformDouble, decalPath, "[ProjectorPuzzleController] SpawnBackgroundDecal", null, EEffectType.Scene, null, null, null, false, false);
			if (!EffectSystem.Instance.IsValid(num))
			{
				Log instance7 = Log.Instance;
				ELogModule module4 = ELogModule.ProjectorPuzzle;
				ELogAuthor author4 = ELogAuthor.WRY;
				string message4 = "ProjectorPuzzle背景贴花加载失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("decalPath", decalPath);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("BackgroundEntityId", backgroundEntityId);
				instance7.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(num);
			AActor parent = aactor2;
			FName? fname = null;
			effectActor.K2_AttachToActor(parent, fname, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false);
			instance.BackgroundDecalEffectId = num;
			instance.BackgroundActor = aactor;
			return true;
		}

		// Token: 0x06043DF8 RID: 278008 RVA: 0x010A2FD4 File Offset: 0x010A11D4
		private static void CheckRotationMatch()
		{
			ProjectorModel instance = ProjectorModel.Instance;
			AActor aactor = (instance != null) ? instance.AttachActor : null;
			if (instance == null || instance.IsCompleted || aactor == null || !aactor.IsValid())
			{
				return;
			}
			if (instance.TargetRotators.Length == 0)
			{
				return;
			}
			Rotator tempRotator = instance.TempRotator;
			FRotator frotator = aactor.K2_GetActorRotation();
			tempRotator.FromUeRotator(frotator);
			float matchTolerance = instance.MatchTolerance;
			foreach (Rotator b in instance.TargetRotators)
			{
				if (instance.TempRotator.Equals(b, matchTolerance))
				{
					ProjectorPuzzleController.OnRotationCompleted();
					return;
				}
			}
		}

		// Token: 0x06043DF9 RID: 278009 RVA: 0x010A3068 File Offset: 0x010A1268
		private static void OnRotationCompleted()
		{
			ProjectorModel instance = ProjectorModel.Instance;
			if (instance == null || instance.IsCompleted)
			{
				return;
			}
			instance.IsCompleted = true;
			ProjectorPuzzleController.FinishGameplay();
		}

		// Token: 0x06043DFA RID: 278010 RVA: 0x010A3094 File Offset: 0x010A1294
		private static void FinishGameplay()
		{
			ProjectorModel instance = ProjectorModel.Instance;
			if (instance == null || !instance.IsActive)
			{
				return;
			}
			ProjectorPuzzleController.CloseGameplay(true, true, true);
		}

		// Token: 0x06043DFB RID: 278011 RVA: 0x010A30BC File Offset: 0x010A12BC
		private static void ApplyArcballRotation(Vector from, Vector to)
		{
			ProjectorModel instance = ProjectorModel.Instance;
			AActor aactor = (instance != null) ? instance.AttachActor : null;
			if (instance == null || instance.IsCompleted || aactor == null || !aactor.IsValid())
			{
				return;
			}
			to.CrossProduct(from, instance.TempAxis);
			if (instance.TempAxis.IsNearlyZero(1E-08))
			{
				return;
			}
			float num = (float)Math.Acos(MathUtils.Instance.Clamp(from.DotProduct(to), -1.0, 1.0));
			if ((double)num <= 1E-08)
			{
				return;
			}
			float dragRotationCoefficient = instance.DragRotationCoefficient;
			if (dragRotationCoefficient > 0f)
			{
				num *= dragRotationCoefficient;
			}
			double x = instance.TempAxis.X;
			instance.TempAxis.X = instance.TempAxis.Y;
			instance.TempAxis.Y = x;
			instance.TempAxis.Normalize(9.99999993922529E-09);
			if (ProjectorPuzzleController.TryGetReferenceRotation(instance.TempRotator))
			{
				instance.TempRotator.Quaternion(instance.TempQuat2);
				instance.TempQuat2.RotateVector(instance.TempAxis, instance.TempWorldAxis);
			}
			else
			{
				instance.TempWorldAxis.DeepCopy(instance.TempAxis);
			}
			Quat.ConstructorByAxisAngle(instance.TempWorldAxis, num, instance.TempQuat);
			instance.TempQuat2.FromUeQuat(aactor.K2_GetActorQuaternion());
			instance.TempQuat.Multiply(instance.TempQuat2, instance.TempQuat2);
			instance.TempQuat2.Rotator(instance.TempRotator);
			aactor.K2_SetActorRotation(instance.TempRotator.ToUeRotator(), false);
			instance.FrameDragAngle += Math.Abs(num);
		}

		// Token: 0x06043DFC RID: 278012 RVA: 0x010A3264 File Offset: 0x010A1464
		private static void ApplyRollRotation(float rollInput, float delta)
		{
			ProjectorModel instance = ProjectorModel.Instance;
			AActor aactor = (instance != null) ? instance.AttachActor : null;
			if (instance == null || instance.IsCompleted || aactor == null || !aactor.IsValid())
			{
				return;
			}
			float num = delta * 0.001f;
			if (num <= 0f)
			{
				return;
			}
			float rotationSpeed = instance.RotationSpeed;
			if (rotationSpeed <= 0f)
			{
				return;
			}
			float num2 = rollInput * rotationSpeed * 0.017453292f * num;
			if ((double)Math.Abs(num2) <= 1E-08)
			{
				return;
			}
			instance.TempAxis.Set(0.0, 1.0, 0.0);
			if (ProjectorPuzzleController.TryGetReferenceRotation(instance.TempRotator))
			{
				instance.TempRotator.Quaternion(instance.TempQuat2);
				instance.TempQuat2.RotateVector(instance.TempAxis, instance.TempWorldAxis);
			}
			else
			{
				instance.TempWorldAxis.Set(0.0, 1.0, 0.0);
			}
			if (instance.TempWorldAxis.IsNearlyZero(1E-08))
			{
				return;
			}
			instance.TempWorldAxis.Normalize(9.99999993922529E-09);
			Quat.ConstructorByAxisAngle(instance.TempWorldAxis, num2, instance.TempQuat);
			instance.TempQuat2.FromUeQuat(aactor.K2_GetActorQuaternion());
			instance.TempQuat.Multiply(instance.TempQuat2, instance.TempQuat2);
			instance.TempQuat2.Rotator(instance.TempRotator);
			aactor.K2_SetActorRotation(instance.TempRotator.ToUeRotator(), false);
			instance.FrameStickAngle += Math.Abs(num2);
		}

		// Token: 0x06043DFD RID: 278013 RVA: 0x010A3404 File Offset: 0x010A1604
		private static void GetArcballVector(float localX, float localY, double width, double height, float centerX, float centerY, Vector outValue)
		{
			double num = width * 0.5;
			double num2 = height * 0.5;
			if (num <= 0.0 || num2 <= 0.0)
			{
				outValue.Reset();
				return;
			}
			double num3 = MathUtils.Instance.Clamp((double)(localX - centerX) / num, -1.0, 1.0);
			double num4 = MathUtils.Instance.Clamp((double)(localY - centerY) / num2, -1.0, 1.0);
			double num5 = num3 * num3 + num4 * num4;
			double inX = 0.0;
			if (num5 <= 1.0)
			{
				inX = Math.Sqrt(1.0 - num5);
			}
			else if (num5 > 1E-08)
			{
				double num6 = Math.Sqrt(num5);
				num3 /= num6;
				num4 /= num6;
				inX = 0.0;
			}
			outValue.Set(inX, num3, num4);
		}

		// Token: 0x06043DFE RID: 278014 RVA: 0x010A3500 File Offset: 0x010A1700
		private static bool ShouldRecenterArcball(float localX, float localY, double width, double height, float centerX, float centerY)
		{
			double num = width * 0.5;
			double num2 = height * 0.5;
			if (num <= 0.0 || num2 <= 0.0)
			{
				return false;
			}
			double num3 = (double)(localX - centerX) / num;
			double num4 = (double)(localY - centerY) / num2;
			return num3 * num3 + num4 * num4 >= 1.0;
		}

		// Token: 0x06043DFF RID: 278015 RVA: 0x010A3564 File Offset: 0x010A1764
		private static bool TryGetReferenceRotation(Rotator outValue)
		{
			ProjectorModel instance = ProjectorModel.Instance;
			AActor aactor = (instance != null) ? instance.BackgroundActor : null;
			if (aactor != null && aactor.IsValid())
			{
				FRotator frotator = aactor.K2_GetActorRotation();
				outValue.FromUeRotator(frotator);
				return true;
			}
			return false;
		}

		// Token: 0x06043E00 RID: 278016 RVA: 0x010A35A0 File Offset: 0x010A17A0
		private static void CacheInitialAttachRelativeRotation(AActor actor, Rotator outValue)
		{
			USceneComponent usceneComponent = actor.K2_GetRootComponent();
			if (usceneComponent != null && usceneComponent.IsValid())
			{
				FRotator relativeRotation = usceneComponent.RelativeRotation;
				outValue.FromUeRotator(relativeRotation);
				return;
			}
			outValue.Set(0f, 0f, 0f);
			Log.Instance.Warn(ELogModule.ProjectorPuzzle, ELogAuthor.WRY, "ProjectorPuzzle缓存挂点初始相对旋转失败，RootComponent无效", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06043E01 RID: 278017 RVA: 0x010A3604 File Offset: 0x010A1804
		private static void ResetAttachActorRotation(AActor actor, Rotator initialRotator)
		{
			FHitResult fhitResult = new FHitResult();
			actor.K2_SetActorRelativeRotation(initialRotator.ToUeRotator(), false, ref fhitResult, false);
		}

		// Token: 0x06043E02 RID: 278018 RVA: 0x010A3628 File Offset: 0x010A1828
		private static void UpdateRotationAudio(float delta)
		{
			ProjectorModel instance = ProjectorModel.Instance;
			if (instance == null || !instance.IsActive)
			{
				return;
			}
			AActor attachActor = instance.AttachActor;
			if (attachActor == null || !attachActor.IsValid())
			{
				return;
			}
			float frameDragAngle = instance.FrameDragAngle;
			float frameStickAngle = instance.FrameStickAngle;
			instance.FrameDragAngle = 0f;
			instance.FrameStickAngle = 0f;
			float num = delta * 0.001f;
			bool flag = (double)(frameDragAngle + frameStickAngle) > 1E-08 && num > 0f;
			if (flag && instance.RotationAudioHandle <= 0)
			{
				instance.RotationAudioHandle = AudioSystem.Instance.PostEvent("play_sfx_gp_projectorpuzzle_stonerotate_loop", attachActor, null);
			}
			else if (!flag && instance.RotationAudioHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(instance.RotationAudioHandle, EAudioActionType.Stop, null);
				instance.RotationAudioHandle = 0;
			}
			if (num > 0f)
			{
				float num2 = instance.RotationSpeed * 0.017453292f;
				float val = ((double)num2 > 1E-08) ? MathUtils.Instance.Clamp(frameStickAngle / num / num2, 0f, 1f) : 0f;
				float val2 = MathUtils.Instance.Clamp(frameDragAngle / num / 6.2831855f, 0f, 1f);
				float value = Math.Max(val, val2);
				AudioSystem.Instance.SetRtpcValue("projectorpuzzle_rotation", value, new SetRtpcValueArgs?(new SetRtpcValueArgs
				{
					Actor = attachActor
				}));
			}
		}

		// Token: 0x06043E03 RID: 278019 RVA: 0x010A37A0 File Offset: 0x010A19A0
		private static void StopRotationAudio()
		{
			ProjectorModel instance = ProjectorModel.Instance;
			if (instance == null)
			{
				return;
			}
			if (instance.RotationAudioHandle > 0)
			{
				AudioSystem.Instance.ExecuteAction(instance.RotationAudioHandle, EAudioActionType.Stop, null);
				instance.RotationAudioHandle = 0;
			}
			instance.FrameDragAngle = 0f;
			instance.FrameStickAngle = 0f;
			AActor attachActor = instance.AttachActor;
			if (attachActor != null && attachActor.IsValid())
			{
				AudioSystem.Instance.SetRtpcValue("projectorpuzzle_rotation", 0f, new SetRtpcValueArgs?(new SetRtpcValueArgs
				{
					Actor = attachActor
				}));
			}
		}

		// Token: 0x06043E04 RID: 278020 RVA: 0x010A3834 File Offset: 0x010A1A34
		private static bool SetupShadowCompensationActor(ProjectorComponent projectorComponent, ProjectorModel model)
		{
			AStaticMeshActor projectedActor = projectorComponent.ProjectedActor;
			if (projectedActor == null || !projectedActor.IsValid())
			{
				return false;
			}
			UStaticMeshComponent staticMeshComponent = projectedActor.StaticMeshComponent;
			UStaticMesh ustaticMesh = (staticMeshComponent != null) ? staticMeshComponent.StaticMesh : null;
			if (ustaticMesh == null || !ustaticMesh.IsValid())
			{
				return false;
			}
			AStaticMeshActor shadowActor = ActorSystem.Instance.Get(AStaticMeshActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as AStaticMeshActor;
			if (shadowActor == null || !shadowActor.IsValid())
			{
				Log.Instance.Warn(ELogModule.ProjectorPuzzle, ELogAuthor.WRY, "ProjectorPuzzle阴影补偿Actor创建失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			UStaticMeshComponent shadowMeshComp = shadowActor.StaticMeshComponent;
			if (shadowMeshComp == null)
			{
				ActorSystem.Instance.Put("[ProjectorPuzzleController] ShadowActorNoMeshComp", shadowActor, null);
				return false;
			}
			shadowMeshComp.SetMobility(EComponentMobility.Movable);
			shadowMeshComp.SetStaticMesh(ustaticMesh);
			shadowMeshComp.SetCastShadow(false);
			shadowMeshComp.MobileCastShadow = false;
			if (!string.IsNullOrEmpty("/Game/Aki/Render/Shaders/Scene/Interaction/MaterialInstance/MI_SceneInteraction_PlaneShadow.MI_SceneInteraction_PlaneShadow"))
			{
				ResourceSystem.Instance.LoadAsync<UMaterialInterface>("/Game/Aki/Render/Shaders/Scene/Interaction/MaterialInstance/MI_SceneInteraction_PlaneShadow.MI_SceneInteraction_PlaneShadow", delegate([Nullable(2)] UMaterialInterface mat, string _)
				{
					ProjectorModel instance = ProjectorModel.Instance;
					if (instance == null || !instance.IsActive)
					{
						return;
					}
					if (!shadowActor.IsValid() || !shadowMeshComp.IsValid())
					{
						instance.ShadowCompensationActor = null;
						return;
					}
					if (mat == null || !mat.IsValid())
					{
						Log instance2 = Log.Instance;
						ELogModule module = ELogModule.ProjectorPuzzle;
						ELogAuthor author = ELogAuthor.WRY;
						string message = "ProjectorPuzzle阴影补偿材质加载失败";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MaterialPath", "/Game/Aki/Render/Shaders/Scene/Interaction/MaterialInstance/MI_SceneInteraction_PlaneShadow.MI_SceneInteraction_PlaneShadow");
						instance2.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						ProjectorPuzzleController.ReleaseShadowCompensationActor(instance);
						return;
					}
					if (!projectorComponent.Valid)
					{
						Log.Instance.Warn(ELogModule.ProjectorPuzzle, ELogAuthor.WRY, "ProjectorPuzzle阴影补偿材质回调时ProjectorComponent已失效", default(ReadOnlySpan<ValueTuple<string, object>>));
						ProjectorPuzzleController.ReleaseShadowCompensationActor(instance);
						return;
					}
					SceneItemActorComponent component = projectorComponent.Entity.GetComponent<SceneItemActorComponent>();
					if (component == null)
					{
						Log.Instance.Warn(ELogModule.ProjectorPuzzle, ELogAuthor.WRY, "ProjectorComponent找不到SceneItemActorComponent组件", default(ReadOnlySpan<ValueTuple<string, object>>));
						ProjectorPuzzleController.ReleaseShadowCompensationActor(instance);
						return;
					}
					AActor actorInSceneInteraction = component.GetActorInSceneInteraction("SpotLight");
					if (actorInSceneInteraction == null || !actorInSceneInteraction.IsValid())
					{
						Log instance3 = Log.Instance;
						ELogModule module2 = ELogModule.ProjectorPuzzle;
						ELogAuthor author2 = ELogAuthor.WRY;
						string message2 = "ProjectorComponent找不到Light挂点Actor";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Key", "SpotLight");
						instance3.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						ProjectorPuzzleController.ReleaseShadowCompensationActor(instance);
						return;
					}
					UMaterialInstanceDynamic umaterialInstanceDynamic = UKismetMaterialLibrary.CreateDynamicMaterialInstance(shadowActor, mat, default(FName), EMIDCreationFlags.None);
					if (umaterialInstanceDynamic == null || !umaterialInstanceDynamic.IsValid())
					{
						Log.Instance.Warn(ELogModule.ProjectorPuzzle, ELogAuthor.WRY, "ProjectorPuzzle阴影补偿动态材质实例创建失败", default(ReadOnlySpan<ValueTuple<string, object>>));
						ProjectorPuzzleController.ReleaseShadowCompensationActor(instance);
						return;
					}
					for (int i = 0; i < shadowMeshComp.GetNumMaterials(); i++)
					{
						shadowMeshComp.SetMaterial(i, umaterialInstanceDynamic);
					}
					Vector vector = Vector.Create(actorInSceneInteraction.D_K2_GetActorLocation());
					FLinearColor value = new FLinearColor((float)vector.X, (float)vector.Y, (float)vector.Z, 0f);
					umaterialInstanceDynamic.SetVectorParameterValue(ProjectorPuzzleController.SHADOW_COMPENSATION_LIGHT_POINT_POS_NAME, value);
					AStaticMeshActor projectedActor2 = projectorComponent.ProjectedActor;
					if (projectedActor2 != null && projectedActor2.IsValid())
					{
						shadowActor.D_K2_SetActorLocationAndRotation(projectedActor2.D_K2_GetActorLocation(), projectedActor2.K2_GetActorRotation(), false, ref WorldGlobal.SweepHitResult, false);
						shadowActor.D_SetActorScale3D(new FVectorDouble(3.299999952316284, 3.299999952316284, 3.299999952316284));
					}
				}, 100, "js_undefined");
			}
			model.ShadowCompensationActor = shadowActor;
			return true;
		}

		// Token: 0x06043E05 RID: 278021 RVA: 0x010A3984 File Offset: 0x010A1B84
		private static void UpdateShadowCompensation()
		{
			ProjectorModel instance = ProjectorModel.Instance;
			if (instance == null || !instance.IsActive)
			{
				return;
			}
			AStaticMeshActor shadowCompensationActor = instance.ShadowCompensationActor;
			if (shadowCompensationActor == null || !shadowCompensationActor.IsValid())
			{
				return;
			}
			AActor attachActor = instance.AttachActor;
			if (attachActor == null || !attachActor.IsValid())
			{
				return;
			}
			FRotator newRotation = attachActor.K2_GetActorRotation();
			shadowCompensationActor.K2_SetActorRotation(newRotation, false);
		}

		// Token: 0x06043E06 RID: 278022 RVA: 0x010A39DC File Offset: 0x010A1BDC
		private static void ReleaseShadowCompensationActor(ProjectorModel model)
		{
			AStaticMeshActor shadowCompensationActor = model.ShadowCompensationActor;
			if (shadowCompensationActor != null && shadowCompensationActor.IsValid())
			{
				ActorSystem.Instance.Put("[ProjectorPuzzleController] ReleaseShadowCompensationActor", shadowCompensationActor, null);
			}
			model.ShadowCompensationActor = null;
		}

		// Token: 0x06043E09 RID: 278025 RVA: 0x010A3A2D File Offset: 0x010A1C2D
		[CompilerGenerated]
		[return: Nullable(2)]
		internal static ProjectorComponent <ValidateAndGetProjectorComponent>g__Fail|10_0(string message, [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs, ref ProjectorPuzzleController.<>c__DisplayClass10_0 A_2)
		{
			Log.Instance.Warn(ELogModule.ProjectorPuzzle, ELogAuthor.WRY, message, pairs);
			A_2.finishCallback(false);
			return null;
		}

		// Token: 0x0402379B RID: 145307
		private const string BACKGROUND_DECAL_ATTACH_ACTOR_KEY = "ProjectorDecalAttachActor";

		// Token: 0x0402379C RID: 145308
		private const string SPOT_LIGHT_KEY = "SpotLight";

		// Token: 0x0402379D RID: 145309
		private const float SHADOW_COMPENSATION_SCALE = 3.3f;

		// Token: 0x0402379E RID: 145310
		private const string SHADOW_COMPENSATION_MATERIAL_PATH = "/Game/Aki/Render/Shaders/Scene/Interaction/MaterialInstance/MI_SceneInteraction_PlaneShadow.MI_SceneInteraction_PlaneShadow";

		// Token: 0x0402379F RID: 145311
		private static readonly FName SHADOW_COMPENSATION_LIGHT_POINT_POS_NAME = new FName("LightPointPos");

		// Token: 0x040237A0 RID: 145312
		private const string ROTATION_LOOP_AUDIO_EVENT = "play_sfx_gp_projectorpuzzle_stonerotate_loop";

		// Token: 0x040237A1 RID: 145313
		private const string ROTATION_RTPC_NAME = "projectorpuzzle_rotation";

		// Token: 0x040237A2 RID: 145314
		private const float DRAG_RTPC_MAX_ANGULAR_VELOCITY = 6.2831855f;
	}
}
