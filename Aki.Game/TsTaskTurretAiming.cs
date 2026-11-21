using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Effect.Struct;
using CSharpScript.Game.Effect;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000CC RID: 204
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurretAiming.TsTaskTurretAiming_C")]
public class TsTaskTurretAiming : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700022E RID: 558
	// (get) Token: 0x06000BDB RID: 3035 RVA: 0x0003C517 File Offset: 0x0003A717
	// (set) Token: 0x06000BDC RID: 3036 RVA: 0x0003C52B File Offset: 0x0003A72B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TargetIdBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTurretAiming.__PropertyOffset_TargetIdBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTurretAiming.__PropertyOffset_TargetIdBlackboardKey)), value);
		}
	}

	// Token: 0x1700022F RID: 559
	// (get) Token: 0x06000BDD RID: 3037 RVA: 0x0003C540 File Offset: 0x0003A740
	// (set) Token: 0x06000BDE RID: 3038 RVA: 0x0003C554 File Offset: 0x0003A754
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TurretAimingStateBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTurretAiming.__PropertyOffset_TurretAimingStateBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTurretAiming.__PropertyOffset_TurretAimingStateBlackboardKey)), value);
		}
	}

	// Token: 0x17000230 RID: 560
	// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0003C569 File Offset: 0x0003A769
	// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x0003C57D File Offset: 0x0003A77D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName MuzzleSocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_MuzzleSocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_MuzzleSocketName) = value;
		}
	}

	// Token: 0x17000231 RID: 561
	// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0003C592 File Offset: 0x0003A792
	// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x0003C5A6 File Offset: 0x0003A7A6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName TargetSocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_TargetSocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_TargetSocketName) = value;
		}
	}

	// Token: 0x17000232 RID: 562
	// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0003C5BB File Offset: 0x0003A7BB
	// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x0003C5CB File Offset: 0x0003A7CB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float StartChargeToleranceDegree
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_StartChargeToleranceDegree);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_StartChargeToleranceDegree) = value;
		}
	}

	// Token: 0x17000233 RID: 563
	// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x0003C5DC File Offset: 0x0003A7DC
	// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x0003C5EC File Offset: 0x0003A7EC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float BreakChargeToleranceDegree
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_BreakChargeToleranceDegree);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_BreakChargeToleranceDegree) = value;
		}
	}

	// Token: 0x17000234 RID: 564
	// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x0003C5FD File Offset: 0x0003A7FD
	// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x0003C60D File Offset: 0x0003A80D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float FastChargeTimeSeconds
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_FastChargeTimeSeconds);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_FastChargeTimeSeconds) = value;
		}
	}

	// Token: 0x17000235 RID: 565
	// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x0003C61E File Offset: 0x0003A81E
	// (set) Token: 0x06000BEA RID: 3050 RVA: 0x0003C62E File Offset: 0x0003A82E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SlowChargeTriggerTimeSeconds
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_SlowChargeTriggerTimeSeconds);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_SlowChargeTriggerTimeSeconds) = value;
		}
	}

	// Token: 0x17000236 RID: 566
	// (get) Token: 0x06000BEB RID: 3051 RVA: 0x0003C63F File Offset: 0x0003A83F
	// (set) Token: 0x06000BEC RID: 3052 RVA: 0x0003C64F File Offset: 0x0003A84F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float LockTimeSeconds
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_LockTimeSeconds);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_LockTimeSeconds) = value;
		}
	}

	// Token: 0x17000237 RID: 567
	// (get) Token: 0x06000BED RID: 3053 RVA: 0x0003C660 File Offset: 0x0003A860
	// (set) Token: 0x06000BEE RID: 3054 RVA: 0x0003C670 File Offset: 0x0003A870
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float FireDelaySeconds
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_FireDelaySeconds);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_FireDelaySeconds) = value;
		}
	}

	// Token: 0x17000238 RID: 568
	// (get) Token: 0x06000BEF RID: 3055 RVA: 0x0003C681 File Offset: 0x0003A881
	// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x0003C691 File Offset: 0x0003A891
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxAimDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_MaxAimDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_MaxAimDistance) = value;
		}
	}

	// Token: 0x17000239 RID: 569
	// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x0003C6A2 File Offset: 0x0003A8A2
	// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x0003C6B2 File Offset: 0x0003A8B2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SightPredictTimeSeconds
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_SightPredictTimeSeconds);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_SightPredictTimeSeconds) = value;
		}
	}

	// Token: 0x1700023A RID: 570
	// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0003C6C4 File Offset: 0x0003A8C4
	// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x0003C6FD File Offset: 0x0003A8FD
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UObject> AimLineEffectPath
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UObject> result;
			if ((result = this._AimLineEffectPath) == null)
			{
				result = (this._AimLineEffectPath = new TSoftObjectPtr<UObject>(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_AimLineEffectPath, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_AimLineEffectPath, 1);
		}
	}

	// Token: 0x1700023B RID: 571
	// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0003C724 File Offset: 0x0003A924
	// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x0003C75D File Offset: 0x0003A95D
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAnimMontage> ChargeMontage
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAnimMontage> result;
			if ((result = this._ChargeMontage) == null)
			{
				result = (this._ChargeMontage = new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_ChargeMontage, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_ChargeMontage, 1);
		}
	}

	// Token: 0x1700023C RID: 572
	// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0003C782 File Offset: 0x0003A982
	// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x0003C792 File Offset: 0x0003A992
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int FireSkillId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_FireSkillId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_FireSkillId) = value;
		}
	}

	// Token: 0x1700023D RID: 573
	// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x0003C7A3 File Offset: 0x0003A9A3
	// (set) Token: 0x06000BFA RID: 3066 RVA: 0x0003C7B3 File Offset: 0x0003A9B3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SlowAimSoundBuffId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_SlowAimSoundBuffId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_SlowAimSoundBuffId) = value;
		}
	}

	// Token: 0x1700023E RID: 574
	// (get) Token: 0x06000BFB RID: 3067 RVA: 0x0003C7C4 File Offset: 0x0003A9C4
	// (set) Token: 0x06000BFC RID: 3068 RVA: 0x0003C7D4 File Offset: 0x0003A9D4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int FastAimSoundBuffId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_FastAimSoundBuffId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_FastAimSoundBuffId) = value;
		}
	}

	// Token: 0x1700023F RID: 575
	// (get) Token: 0x06000BFD RID: 3069 RVA: 0x0003C7E5 File Offset: 0x0003A9E5
	// (set) Token: 0x06000BFE RID: 3070 RVA: 0x0003C7F9 File Offset: 0x0003A9F9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector SocketPoseForward
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_SocketPoseForward);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_SocketPoseForward) = value;
		}
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x06000BFF RID: 3071 RVA: 0x0003C80E File Offset: 0x0003AA0E
	// (set) Token: 0x06000C00 RID: 3072 RVA: 0x0003C81E File Offset: 0x0003AA1E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableDebug
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_EnableDebug) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurretAiming.__PropertyOffset_EnableDebug) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x0003C830 File Offset: 0x0003AA30
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsTargetIdBlackboardKey = this.TargetIdBlackboardKey;
			this.TsTurretAimingStateBlackboardKey = this.TurretAimingStateBlackboardKey;
			this.TsMuzzleSocketName = new FName?((this.MuzzleSocketName == FNameUtil.NONE) ? null : this.MuzzleSocketName);
			this.TsStartChargeToleranceDegree = this.StartChargeToleranceDegree;
			this.TsBreakChargeToleranceDegree = this.BreakChargeToleranceDegree;
			this.TsFastChargeTimeSeconds = this.FastChargeTimeSeconds;
			this.TsSlowChargeTriggerTimeSeconds = this.SlowChargeTriggerTimeSeconds;
			this.TsLockTimeSeconds = this.LockTimeSeconds;
			this.TsFireDelaySeconds = this.FireDelaySeconds;
			this.TsMaxAimDistance = this.MaxAimDistance;
			this.TsSightPredictTimeSeconds = this.SightPredictTimeSeconds;
			TSoftObjectPtr<UObject> aimLineEffectPath = this.AimLineEffectPath;
			this.TsAimLineEffectPath = (((aimLineEffectPath != null) ? aimLineEffectPath.ToAssetPathName() : null) ?? "");
			TSoftObjectPtr<UAnimMontage> chargeMontage = this.ChargeMontage;
			this.TsChargeMontage = (((chargeMontage != null) ? chargeMontage.ToAssetPathName() : null) ?? "");
			this.TsFireSkillId = this.FireSkillId;
			this.TsSlowAimSoundBuffId = this.SlowAimSoundBuffId;
			this.TsFastAimSoundBuffId = this.FastAimSoundBuffId;
			this.TsTargetSocketName = new FName?((this.TargetSocketName == FNameUtil.NONE) ? null : this.TargetSocketName);
		}
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x0003C98C File Offset: 0x0003AB8C
	private bool IsConfigValid()
	{
		return !string.IsNullOrEmpty(this.TsTargetIdBlackboardKey) && !string.IsNullOrEmpty(this.TsTurretAimingStateBlackboardKey) && this.TsMuzzleSocketName != null && !string.IsNullOrEmpty(this.TsAimLineEffectPath) && !string.IsNullOrEmpty(this.TsChargeMontage) && this.TsStartChargeToleranceDegree >= 0f && this.TsBreakChargeToleranceDegree >= this.TsStartChargeToleranceDegree && this.TsFastChargeTimeSeconds >= 0f && this.TsSlowChargeTriggerTimeSeconds >= 0f && this.TsLockTimeSeconds >= this.TsFastChargeTimeSeconds && this.TsFireDelaySeconds >= 0f && this.TsMaxAimDistance > 0f && this.TsSightPredictTimeSeconds >= 0f;
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x0003CA54 File Offset: 0x0003AC54
	private bool IsRuntimeContextValid(Entity entity)
	{
		if (!entity.Valid)
		{
			return false;
		}
		CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
		CharacterAnimationComponent component2 = entity.GetComponent<CharacterAnimationComponent>();
		return component != null && component.Valid && component.Owner != null && component2 != null && component2.Valid && this.IsMuzzleSocketValid(entity);
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x0003CAA0 File Offset: 0x0003ACA0
	private bool IsMuzzleSocketValid(Entity entity)
	{
		CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
		USkeletalMeshComponent uskeletalMeshComponent = (component != null) ? component.SkeletalMesh : null;
		return uskeletalMeshComponent != null && uskeletalMeshComponent.IsValid() && this.TsMuzzleSocketName != null && (uskeletalMeshComponent.DoesSocketExist(this.TsMuzzleSocketName ?? FNameUtil.NONE) || uskeletalMeshComponent.GetBoneIndex(this.TsMuzzleSocketName ?? FNameUtil.NONE) >= 0);
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x0003CB34 File Offset: 0x0003AD34
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTurretAiming) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskTurretAiming.StaticClass(), out intPtr, out num))
		{
			this.ReceiveExecuteAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x0003CBE4 File Offset: 0x0003ADE4
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ((ownerController != null) ? ownerController.GetClass().GetName() : null) ?? "undefined");
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.Finish(false);
			return;
		}
		this.TsAiCombatMessageId = aiController.AiCombatMessageId;
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		Entity entity = (charActorComp != null) ? charActorComp.Entity : null;
		if (entity == null)
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming 初始化失败，角色实体或必要组件无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.Finish(false);
			return;
		}
		if (!this.IsConfigValid())
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming 缺少必要配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.Finish(false);
			return;
		}
		if (!this.IsRuntimeContextValid(entity))
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming 初始化失败，角色实体或必要组件无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.Finish(false);
			return;
		}
		if (this.TsTargetSocketName == null)
		{
			Log.Instance.Warn(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming 未配置目标Socket，将使用角色位置作为瞄准点", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		CharacterAnimationComponent component = entity.GetComponent<CharacterAnimationComponent>();
		if (component != null && component.Valid && !component.EnableSightDirect)
		{
			Log.Instance.Warn(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming 未开启视线驱动(EnableSightDirect)，炮口可能无法转向目标", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		int? targetId = this.GetTargetId(entity);
		if (targetId == null || this.GetValidTargetActorComponent(targetId.Value) == null)
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming 初始目标无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.Finish(false);
			return;
		}
		this.Entity = entity;
		this.IsTaskActive = true;
		this.CurrentTurretAimingState = TsTaskTurretAiming.ETurretAimingState.None;
		this.CurrentTargetId = targetId.Value;
		this.CurrentStateTimeSeconds = 0f;
		this.WaitingFireSkill = false;
		this.DebugLog("开始瞄准", new ValueTuple<string, object>[]
		{
			new ValueTuple<string, object>("SelfId", entity.Id),
			new ValueTuple<string, object>("TargetId", targetId.Value)
		});
		if (!this.PlayAimLineEffect())
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming 播放瞄准线特效失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CompleteTask(false);
			return;
		}
		this.ChangeState(TsTaskTurretAiming.ETurretAimingState.Tracking);
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x0003CE54 File Offset: 0x0003B054
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTurretAiming) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskTurretAiming.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x0003CF0C File Offset: 0x0003B10C
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (!this.IsTaskActive)
		{
			return;
		}
		Entity entity = this.Entity;
		if (entity == null || !this.IsRuntimeContextValid(entity))
		{
			this.CompleteTask(false);
			return;
		}
		int? targetId = this.GetTargetId(entity);
		BaseActorComponent baseActorComponent = (targetId == null) ? null : this.GetValidTargetActorComponent(targetId.Value);
		if (targetId == null || baseActorComponent == null)
		{
			this.UpdateTurretSightToTarget(null);
			this.CompleteTask(false);
			return;
		}
		if (targetId.Value != this.CurrentTargetId)
		{
			this.DebugLog("瞄准目标变更", new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("SelfId", entity.Id),
				new ValueTuple<string, object>("OldTargetId", this.CurrentTargetId),
				new ValueTuple<string, object>("NewTargetId", targetId.Value)
			});
			this.CurrentTargetId = targetId.Value;
			if (!this.ChangeState(TsTaskTurretAiming.ETurretAimingState.Tracking))
			{
				return;
			}
		}
		if (!this.UpdateAimLineEffect(deltaSeconds))
		{
			this.CompleteTask(false);
			return;
		}
		switch (this.CurrentTurretAimingState)
		{
		case TsTaskTurretAiming.ETurretAimingState.Tracking:
			this.TickTracking(deltaSeconds, baseActorComponent);
			break;
		case TsTaskTurretAiming.ETurretAimingState.SlowCharging:
		case TsTaskTurretAiming.ETurretAimingState.FastCharging:
			this.TickCharging(deltaSeconds, baseActorComponent);
			break;
		case TsTaskTurretAiming.ETurretAimingState.Locked:
			this.TickLocked(deltaSeconds);
			break;
		case TsTaskTurretAiming.ETurretAimingState.Firing:
			this.TickFiring(ownerController, targetId.Value);
			break;
		}
		this.DrawDebugInfo(baseActorComponent);
		this.DebugAimAlignment(deltaSeconds, baseActorComponent);
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x0003D078 File Offset: 0x0003B278
	protected override void OnAbort()
	{
		string message = "瞄准任务被中止";
		ValueTuple<string, object>[] array = new ValueTuple<string, object>[3];
		int num = 0;
		string item = "SelfId";
		Entity entity = this.Entity;
		array[num] = new ValueTuple<string, object>(item, (entity != null) ? new int?(entity.Id) : null);
		array[1] = new ValueTuple<string, object>("TargetId", this.CurrentTargetId);
		array[2] = new ValueTuple<string, object>("State", this.GetStateDebugName(this.CurrentTurretAimingState));
		this.DebugLog(message, array);
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x0003D104 File Offset: 0x0003B304
	protected override void OnClear()
	{
		Entity entity = this.Entity;
		if (entity != null && entity.Valid)
		{
			this.UpdateTurretSightToTarget(null);
		}
		this.StopAimLineEffect();
		this.StopChargeMontage();
		this.ManageAimSoundBuff(TsTaskTurretAiming.ETurretAimingState.None);
		this.AimLineTrace = null;
		if (entity != null && entity.Valid && !string.IsNullOrEmpty(this.TsTurretAimingStateBlackboardKey))
		{
			BlackboardController.Instance.SetIntValueByEntity(entity.Id, this.TsTurretAimingStateBlackboardKey, 0);
		}
		this.CurrentTurretAimingState = TsTaskTurretAiming.ETurretAimingState.None;
		this.CurrentStateTimeSeconds = 0f;
		this.CurrentTargetId = -1;
		this.IsTaskActive = false;
		this.Entity = null;
		this.WaitingFireSkill = false;
		this.TsAiCombatMessageId = null;
		this.IsSocketForwardInitialized = false;
		this.IsTargetVelocityInitialized = false;
		this.IsAimLineSnappedToTarget = false;
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x0003D1C4 File Offset: 0x0003B3C4
	private void CompleteTask(bool success)
	{
		if (!this.IsTaskActive)
		{
			return;
		}
		string message = "瞄准任务结束";
		ValueTuple<string, object>[] array = new ValueTuple<string, object>[4];
		array[0] = new ValueTuple<string, object>("Success", success);
		int num = 1;
		string item = "SelfId";
		Entity entity = this.Entity;
		array[num] = new ValueTuple<string, object>(item, (entity != null) ? new int?(entity.Id) : null);
		array[2] = new ValueTuple<string, object>("TargetId", this.CurrentTargetId);
		array[3] = new ValueTuple<string, object>("State", this.GetStateDebugName(this.CurrentTurretAimingState));
		this.DebugLog(message, array);
		this.IsTaskActive = false;
		base.Finish(success);
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x0003D27E File Offset: 0x0003B47E
	private int? GetTargetId(Entity entity)
	{
		return BlackboardController.Instance.GetEntityIdByEntity(entity.Id, this.TsTargetIdBlackboardKey);
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x0003D298 File Offset: 0x0003B498
	[NullableContext(2)]
	private BaseActorComponent GetValidTargetActorComponent(int targetId)
	{
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(targetId);
		if (component == null || !component.Valid || component.Owner == null)
		{
			return null;
		}
		return component;
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x0003D2D0 File Offset: 0x0003B4D0
	private bool ChangeState(TsTaskTurretAiming.ETurretAimingState newState)
	{
		if (this.CurrentTurretAimingState == newState)
		{
			return true;
		}
		TsTaskTurretAiming.ETurretAimingState currentTurretAimingState = this.CurrentTurretAimingState;
		this.CurrentTurretAimingState = newState;
		string message = "瞄准状态变更";
		ValueTuple<string, object>[] array = new ValueTuple<string, object>[4];
		int num = 0;
		string item = "SelfId";
		Entity entity = this.Entity;
		array[num] = new ValueTuple<string, object>(item, (entity != null) ? new int?(entity.Id) : null);
		array[1] = new ValueTuple<string, object>("TargetId", this.CurrentTargetId);
		array[2] = new ValueTuple<string, object>("OldState", this.GetStateDebugName(currentTurretAimingState));
		array[3] = new ValueTuple<string, object>("NewState", this.GetStateDebugName(newState));
		this.DebugLog(message, array);
		if (!this.EnterState(newState))
		{
			this.CompleteTask(false);
			return false;
		}
		if (this.Entity != null && !string.IsNullOrEmpty(this.TsTurretAimingStateBlackboardKey))
		{
			BlackboardController.Instance.SetIntValueByEntity(this.Entity.Id, this.TsTurretAimingStateBlackboardKey, (int)newState);
		}
		return true;
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x0003D3CC File Offset: 0x0003B5CC
	private bool EnterState(TsTaskTurretAiming.ETurretAimingState newState)
	{
		switch (newState)
		{
		case TsTaskTurretAiming.ETurretAimingState.Tracking:
			this.CurrentStateTimeSeconds = 0f;
			this.StopChargeMontage();
			if (!this.TrySetAimLineRate(0f))
			{
				return false;
			}
			this.ManageAimSoundBuff(TsTaskTurretAiming.ETurretAimingState.Tracking);
			return true;
		case TsTaskTurretAiming.ETurretAimingState.SlowCharging:
			this.CurrentStateTimeSeconds = 0f;
			if (!this.PlayChargeMontage())
			{
				return false;
			}
			if (!this.TrySetAimLineRate(0f))
			{
				return false;
			}
			this.ManageAimSoundBuff(TsTaskTurretAiming.ETurretAimingState.SlowCharging);
			return true;
		case TsTaskTurretAiming.ETurretAimingState.FastCharging:
			if (!this.TrySetAimLineRate(1f))
			{
				return false;
			}
			this.ManageAimSoundBuff(TsTaskTurretAiming.ETurretAimingState.FastCharging);
			return true;
		case TsTaskTurretAiming.ETurretAimingState.Locked:
			this.CurrentStateTimeSeconds = 0f;
			this.UpdateTurretSightToTarget(null);
			this.ManageAimSoundBuff(TsTaskTurretAiming.ETurretAimingState.Locked);
			return true;
		case TsTaskTurretAiming.ETurretAimingState.Firing:
			this.FiringHitPosition.DeepCopy(this.AimLineEndPoint);
			this.ManageAimSoundBuff(TsTaskTurretAiming.ETurretAimingState.Firing);
			return true;
		}
		return true;
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x0003D4A0 File Offset: 0x0003B6A0
	private void TickTracking(float deltaSeconds, BaseActorComponent targetActorComp)
	{
		this.UpdateTargetSightPoint(deltaSeconds, targetActorComp);
		this.UpdateTurretSightToTarget(this.TargetSightPoint);
		if (this.IsAimDirectReachTarget(this.TargetSocketLocation, this.TsStartChargeToleranceDegree))
		{
			this.CurrentStateTimeSeconds += deltaSeconds;
			if (this.CurrentStateTimeSeconds >= this.TsSlowChargeTriggerTimeSeconds)
			{
				this.ChangeState(TsTaskTurretAiming.ETurretAimingState.SlowCharging);
				return;
			}
		}
		else
		{
			this.CurrentStateTimeSeconds = 0f;
		}
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x0003D508 File Offset: 0x0003B708
	private void TickCharging(float deltaSeconds, BaseActorComponent targetActorComp)
	{
		this.UpdateTargetSightPoint(deltaSeconds, targetActorComp);
		this.UpdateTurretSightToTarget(this.TargetSightPoint);
		if (this.PlayingMontageId < 0)
		{
			this.CompleteTask(false);
			return;
		}
		if (!this.IsAimDirectReachTarget(this.TargetSocketLocation, this.TsBreakChargeToleranceDegree))
		{
			this.ChangeState(TsTaskTurretAiming.ETurretAimingState.Tracking);
			return;
		}
		this.CurrentStateTimeSeconds += deltaSeconds;
		if (this.CurrentStateTimeSeconds >= this.TsLockTimeSeconds)
		{
			this.ChangeState(TsTaskTurretAiming.ETurretAimingState.Locked);
			return;
		}
		if (this.CurrentTurretAimingState == TsTaskTurretAiming.ETurretAimingState.SlowCharging && this.CurrentStateTimeSeconds >= this.TsFastChargeTimeSeconds)
		{
			this.ChangeState(TsTaskTurretAiming.ETurretAimingState.FastCharging);
		}
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x0003D59B File Offset: 0x0003B79B
	private void TickLocked(float deltaSeconds)
	{
		this.CurrentStateTimeSeconds += deltaSeconds;
		if (this.CurrentStateTimeSeconds >= this.TsFireDelaySeconds)
		{
			this.ChangeState(TsTaskTurretAiming.ETurretAimingState.Firing);
		}
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x0003D5C4 File Offset: 0x0003B7C4
	[NullableContext(2)]
	private unsafe void TickFiring(AAIController ownerController, int targetId)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			this.CompleteTask(false);
			return;
		}
		if (aiController.AiSkill == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "没有技能信息";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AiBaseId", aiController.AiBase.Value.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.CompleteTask(false);
			return;
		}
		AiSkillInfos aiSkillInfos;
		if (!aiController.AiSkill.SkillInfos.TryGetValue(this.TsFireSkillId, out aiSkillInfos))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "当前AI没有对应的技能ID";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AiBaseId", aiController.AiBase.Value.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkillInfoId", this.TsFireSkillId);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item = "Tree";
			UBehaviorTree treeAsset = base.TreeAsset;
			ptr = new ValueTuple<string, object>(item, (treeAsset != null) ? treeAsset.GetName() : null);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.CompleteTask(false);
			return;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(targetId);
		if (entityById == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.BehaviorTree;
			ELogAuthor author3 = ELogAuthor.ZJL;
			string message3 = "当前AI的目标实体不存在";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("AiBaseId", aiController.AiBase.Value.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("TargetId", targetId);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2);
			string item2 = "Tree";
			UBehaviorTree treeAsset2 = base.TreeAsset;
			ptr2 = new ValueTuple<string, object>(item2, (treeAsset2 != null) ? treeAsset2.GetName() : null);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			this.CompleteTask(false);
			return;
		}
		CharacterAiComponent charAiDesignComp = aiController.CharAiDesignComp;
		if (((charAiDesignComp != null) ? charAiDesignComp.Entity : null) == null)
		{
			Log.Instance.Warn(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming 拿不到CharAiDesignComp", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CompleteTask(false);
			return;
		}
		CharacterSkillComponent component = charAiDesignComp.Entity.GetComponent<CharacterSkillComponent>();
		if (component == null || !component.Valid)
		{
			Log.Instance.Warn(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming No SkillComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CompleteTask(false);
			return;
		}
		if (this.WaitingFireSkill)
		{
			return;
		}
		this.WaitingFireSkill = true;
		component.BeginSkillAsync(int.Parse(aiSkillInfos.SkillId), new SkillParam
		{
			Target = entityById.Entity,
			ExtraTargetLocation = new FVectorDouble?(this.FiringHitPosition.ToUeVector(false)),
			Reason = "TsTaskTurretAiming TickFiring"
		}).ContinueWith(delegate(bool result)
		{
			if (!this.IsTaskActive || !this.WaitingFireSkill)
			{
				return;
			}
			this.CompleteTask(result);
		});
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x0003D89C File Offset: 0x0003BA9C
	private string GetStateDebugName(TsTaskTurretAiming.ETurretAimingState state)
	{
		switch (state)
		{
		case TsTaskTurretAiming.ETurretAimingState.None:
			return "None";
		case TsTaskTurretAiming.ETurretAimingState.Tracking:
			return "Tracking";
		case TsTaskTurretAiming.ETurretAimingState.SlowCharging:
			return "SlowCharging";
		case TsTaskTurretAiming.ETurretAimingState.FastCharging:
			return "FastCharging";
		case TsTaskTurretAiming.ETurretAimingState.Locked:
			return "Locked";
		case TsTaskTurretAiming.ETurretAimingState.Firing:
			return "Firing";
		default:
			return "Unknown";
		}
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x0003D8F4 File Offset: 0x0003BAF4
	private void UpdateTargetSightPoint(float deltaSeconds, BaseActorComponent targetActorComp)
	{
		global::Vector targetSocketLocation = this.TargetSocketLocation;
		FVectorDouble socketLocation = targetActorComp.GetSocketLocation(this.TsTargetSocketName ?? FNameUtil.NONE);
		targetSocketLocation.DeepCopy(socketLocation);
		this.TargetSightPoint.DeepCopy(this.TargetSocketLocation);
		if (this.TsSightPredictTimeSeconds > 0f)
		{
			global::Vector safeActorVelocityProxy = targetActorComp.SafeActorVelocityProxy;
			if (safeActorVelocityProxy != null)
			{
				if (!this.IsTargetVelocityInitialized)
				{
					this.SmoothedTargetVelocity.DeepCopy(safeActorVelocityProxy);
					this.IsTargetVelocityInitialized = true;
				}
				else
				{
					double num = 1.0 - Math.Exp((double)(-(double)deltaSeconds / 0.1f));
					this.SmoothedTargetVelocity.X += (safeActorVelocityProxy.X - this.SmoothedTargetVelocity.X) * num;
					this.SmoothedTargetVelocity.Y += (safeActorVelocityProxy.Y - this.SmoothedTargetVelocity.Y) * num;
					this.SmoothedTargetVelocity.Z += (safeActorVelocityProxy.Z - this.SmoothedTargetVelocity.Z) * num;
				}
				this.TargetSightPoint.X += this.SmoothedTargetVelocity.X * (double)this.TsSightPredictTimeSeconds;
				this.TargetSightPoint.Y += this.SmoothedTargetVelocity.Y * (double)this.TsSightPredictTimeSeconds;
			}
		}
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x0003DA58 File Offset: 0x0003BC58
	[NullableContext(2)]
	private void UpdateTurretSightToTarget(global::Vector targetActorPosition)
	{
		Entity entity = this.Entity;
		CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
		Entity entity2 = this.Entity;
		CharacterAnimationComponent characterAnimationComponent = (entity2 != null) ? entity2.GetComponent<CharacterAnimationComponent>() : null;
		if (characterActorComponent == null || !characterActorComponent.Valid || (characterAnimationComponent == null || !characterAnimationComponent.Valid))
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming 拿不到ActorComponent或AnimationComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (targetActorPosition != null)
		{
			global::Vector socketLocation = this.SocketLocation;
			FVectorDouble socketLocation2 = characterActorComponent.GetSocketLocation(this.TsMuzzleSocketName ?? FNameUtil.NONE);
			socketLocation.FromUeVector(socketLocation2);
			this.TmpWorldSightDir.DeepCopy(targetActorPosition);
			this.TmpWorldSightDir.SubtractionEqual(this.SocketLocation);
			if (this.TmpWorldSightDir.IsNearlyZero(9.999999747378752E-05))
			{
				characterAnimationComponent.GetWorldSightDirect(this.TmpWorldSightDir);
			}
		}
		else
		{
			characterAnimationComponent.GetWorldSightDirect(this.TmpWorldSightDir);
		}
		this.TmpWorldSightDir.Normalize(9.99999993922529E-09);
		this.SightTargetPoint.DeepCopy(this.TmpWorldSightDir);
		this.SightTargetPoint.MultiplyEqual((double)this.TsMaxAimDistance);
		this.SightTargetPoint.AdditionEqual(characterActorComponent.ActorLocationProxy);
		this.SightTargetPoint.Z += (double)characterActorComponent.ScaledHalfHeight;
		characterAnimationComponent.SetSightTargetPoint(this.SightTargetPoint);
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x0003DBC0 File Offset: 0x0003BDC0
	private bool IsAimDirectReachTarget(global::Vector targetPoint, float toleranceDegree)
	{
		Entity entity = this.Entity;
		CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		FTransformDouble socketTransform = characterActorComponent.GetSocketTransform(this.TsMuzzleSocketName ?? FNameUtil.NONE);
		global::Vector socketLocation = this.SocketLocation;
		FVectorDouble location = socketTransform.GetLocation();
		socketLocation.FromUeVector(location);
		global::Vector socketForward = this.SocketForward;
		FQuat rotation = socketTransform.GetRotation();
		FVector socketPoseForward = this.SocketPoseForward;
		FVector fvector = rotation.RotateVector(socketPoseForward);
		socketForward.FromUeVector(fvector);
		if (!this.SocketForward.Normalize(9.99999993922529E-09))
		{
			return false;
		}
		this.TmpWorldSightDir.DeepCopy(targetPoint);
		this.TmpWorldSightDir.SubtractionEqual(this.SocketLocation);
		return this.TmpWorldSightDir.Normalize(9.99999993922529E-09) && MathUtils.Instance.GetAngleByVectorDot(this.SocketForward, this.TmpWorldSightDir) <= (double)toleranceDegree;
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x0003DCCC File Offset: 0x0003BECC
	private bool PlayAimLineEffect()
	{
		int? effectHandle = this.EffectHandle;
		if (effectHandle != null && effectHandle.GetValueOrDefault() != 0)
		{
			if (TsEffectFunctionLibrary.EffectHandleIsValid(this.EffectHandle.Value))
			{
				return true;
			}
			this.EffectHandle = null;
		}
		if (string.IsNullOrEmpty(this.TsAimLineEffectPath))
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming 未配置瞄准线特效路径", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		Entity entity = this.Entity;
		CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
		USkeletalMeshComponent uskeletalMeshComponent = (characterActorComponent != null) ? characterActorComponent.SkeletalMesh : null;
		if (uskeletalMeshComponent == null)
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming 拿不到SkeletalMeshComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		int num = TsEffectFunctionLibrary.SpawnEffectAttachToBone(this, this, uskeletalMeshComponent, this.TsMuzzleSocketName ?? FNameUtil.NONE, this.TsAimLineEffectPath, new FTransformDouble(), "TsTaskTurretAiming PlayAimLineEffect", EEffectPlay.Play, false);
		if (num == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "TsTaskTurretAiming 播放瞄准线特效失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EffectPath", this.TsAimLineEffectPath);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.EffectHandle = new int?(num);
		return true;
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x0003DDF8 File Offset: 0x0003BFF8
	private void StopAimLineEffect()
	{
		int? effectHandle = this.EffectHandle;
		if (effectHandle != null && effectHandle.GetValueOrDefault() != 0)
		{
			if (TsEffectFunctionLibrary.EffectHandleIsValid(this.EffectHandle.Value))
			{
				TsEffectFunctionLibrary.StopAndDestroyEffect(this.EffectHandle.Value, this, "TsTaskTurretAiming StopAimLineEffect", true);
			}
			this.EffectHandle = null;
		}
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x0003DE54 File Offset: 0x0003C054
	private bool UpdateAimLineEffect(float deltaSeconds)
	{
		global::Vector aimLineEndPoint = this.GetAimLineEndPoint(deltaSeconds);
		if (aimLineEndPoint == null)
		{
			return false;
		}
		this.HitPositionWorldRelative.DeepCopy(aimLineEndPoint);
		WorldController.Instance.ToWorldRelativeLocation(this.HitPositionWorldRelative, this.HitPositionWorldRelative);
		return this.SetAimLineEffectVectorParam(TsTaskTurretAiming.HIT_POSITION_PARAM_NAME, this.HitPositionWorldRelative);
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x0003DEA1 File Offset: 0x0003C0A1
	private bool TrySetAimLineRate(float rate)
	{
		if (this.SetAimLineEffectFloatParam(TsTaskTurretAiming.RATE_PARAM_NAME, rate))
		{
			return true;
		}
		this.CompleteTask(false);
		return false;
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x0003DEBC File Offset: 0x0003C0BC
	[NullableContext(2)]
	private global::Vector GetAimLineEndPoint(float deltaSeconds)
	{
		Entity entity = this.Entity;
		CharacterActorComponent characterActorComponent = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
		TsBaseCharacter tsBaseCharacter = (characterActorComponent != null) ? characterActorComponent.Actor : null;
		if (characterActorComponent == null || !characterActorComponent.Valid || (tsBaseCharacter == null || !tsBaseCharacter.IsValid()))
		{
			return null;
		}
		FTransformDouble socketTransform = characterActorComponent.GetSocketTransform(this.TsMuzzleSocketName ?? FNameUtil.NONE);
		global::Vector socketLocation = this.SocketLocation;
		FVectorDouble location = socketTransform.GetLocation();
		socketLocation.FromUeVector(location);
		global::Vector socketForward = this.SocketForward;
		FQuat rotation = socketTransform.GetRotation();
		FVector socketPoseForward = this.SocketPoseForward;
		FVector fvector = rotation.RotateVector(socketPoseForward);
		socketForward.FromUeVector(fvector);
		if (!this.SocketForward.Normalize(9.99999993922529E-09))
		{
			return null;
		}
		if (!this.IsSocketForwardInitialized)
		{
			this.SmoothedSocketForward.DeepCopy(this.SocketForward);
			this.IsSocketForwardInitialized = true;
		}
		else
		{
			double num = 1.0 - Math.Exp((double)(-(double)deltaSeconds / 0.01f));
			this.SmoothedSocketForward.X += (this.SocketForward.X - this.SmoothedSocketForward.X) * num;
			this.SmoothedSocketForward.Y += (this.SocketForward.Y - this.SmoothedSocketForward.Y) * num;
			this.SmoothedSocketForward.Z += (this.SocketForward.Z - this.SmoothedSocketForward.Z) * num;
		}
		this.SocketForward.DeepCopy(this.SmoothedSocketForward);
		this.AimLineTraceEndPoint.DeepCopy(this.SocketForward);
		this.AimLineTraceEndPoint.MultiplyEqual((double)this.TsMaxAimDistance);
		this.AimLineTraceEndPoint.AdditionEqual(this.SocketLocation);
		this.AimLineEndPoint.DeepCopy(this.AimLineTraceEndPoint);
		this.AimLineVisibleHitPoint.DeepCopy(this.AimLineTraceEndPoint);
		this.AimLineSelectedHitType = "None";
		this.AimLineVisibleHitActorName = "None";
		if (this.AimLineTrace == null)
		{
			this.AimLineTrace = new UTraceLineElement();
			this.AimLineTrace.bIsSingle = true;
			this.AimLineTrace.bTraceComplex = false;
			this.AimLineTrace.bIgnoreSelf = true;
			this.AimLineTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
		}
		this.AimLineTrace.WorldContextObject = tsBaseCharacter;
		TraceElementCommon.Instance.SetStartLocation(this.AimLineTrace, this.SocketLocation);
		TraceElementCommon.Instance.SetEndLocation(this.AimLineTrace, this.AimLineTraceEndPoint);
		bool flag = TraceElementCommon.Instance.LineTrace(this.AimLineTrace, "TsTaskTurretAiming_AimLine");
		UKuroHitResult hitResult = this.AimLineTrace.HitResult;
		bool flag2 = flag && hitResult != null && hitResult.bBlockingHit;
		if (flag2)
		{
			TraceElementCommon.Instance.GetHitLocation(hitResult, 0, this.AimLineVisibleHitPoint);
			this.AimLineVisibleHitActorName = this.GetFirstHitActorName(hitResult);
		}
		this.TmpWorldSightDir.DeepCopy(this.TargetSocketLocation);
		this.TmpWorldSightDir.SubtractionEqual(this.SocketLocation);
		double num2 = Math.Clamp(this.TmpWorldSightDir.DotProduct(this.SocketForward), 0.0, (double)this.TsMaxAimDistance);
		this.TmpWorldSightDir.DeepCopy(this.SocketForward);
		this.TmpWorldSightDir.MultiplyEqual((double)((float)num2));
		this.TmpWorldSightDir.AdditionEqual(this.SocketLocation);
		double num3 = global::Vector.DistSquared(this.TargetSocketLocation, this.TmpWorldSightDir);
		double num4 = global::Vector.Dist(this.SocketLocation, this.TargetSocketLocation);
		double num5 = num4 * Math.Tan((double)(this.TsStartChargeToleranceDegree * 0.017453292f));
		double num6 = num4 * Math.Tan((double)(this.TsBreakChargeToleranceDegree * 0.017453292f));
		double num7 = this.IsAimLineSnappedToTarget ? num6 : num5;
		bool flag3 = num3 <= num7 * num7;
		double num8 = flag2 ? global::Vector.Dist(this.SocketLocation, this.AimLineVisibleHitPoint) : double.MaxValue;
		if (flag3 && num2 <= num8)
		{
			this.AimLineEndPoint.DeepCopy(this.TargetSocketLocation);
			this.AimLineSelectedHitType = "Character";
			this.IsAimLineSnappedToTarget = true;
		}
		else if (flag2)
		{
			this.AimLineEndPoint.DeepCopy(this.AimLineVisibleHitPoint);
			this.AimLineSelectedHitType = "Visible";
			this.IsAimLineSnappedToTarget = false;
		}
		else
		{
			this.IsAimLineSnappedToTarget = false;
		}
		this.AimLineEndPointResult.DeepCopy(this.AimLineEndPoint);
		return this.AimLineEndPointResult;
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x0003E320 File Offset: 0x0003C520
	private string GetFirstHitActorName(UKuroHitResult hitResult)
	{
		if (hitResult.Actors.Num() <= 0)
		{
			return "Unknown";
		}
		AActor aactor = hitResult.Actors.Get(0).Get();
		return ((aactor != null) ? aactor.GetName() : null) ?? "Unknown";
	}

	// Token: 0x06000C1E RID: 3102 RVA: 0x0003E36C File Offset: 0x0003C56C
	private bool SetAimLineEffectFloatParam(FName parameterName, float value)
	{
		bool flag = (this.EffectHandle ?? 0) == 0;
		if (flag || !TsEffectFunctionLibrary.EffectHandleIsValid(this.EffectHandle.Value))
		{
			return false;
		}
		OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> niagaraComponent = EffectSystem.Instance.GetNiagaraComponent(this.EffectHandle.Value);
		if (!niagaraComponent.HasValue)
		{
			return false;
		}
		niagaraComponent.SetFloatParameter(parameterName, value);
		return true;
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x0003E3DC File Offset: 0x0003C5DC
	private bool SetAimLineEffectVectorParam(FName parameterName, global::Vector value)
	{
		bool flag = (this.EffectHandle ?? 0) == 0;
		if (flag || !TsEffectFunctionLibrary.EffectHandleIsValid(this.EffectHandle.Value))
		{
			return false;
		}
		OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> niagaraComponent = EffectSystem.Instance.GetNiagaraComponent(this.EffectHandle.Value);
		if (!niagaraComponent.HasValue)
		{
			return false;
		}
		this.EffectVectorParam.Set((float)value.X, (float)value.Y, (float)value.Z);
		niagaraComponent.SetVectorParameter(parameterName, this.EffectVectorParam);
		return true;
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x0003E470 File Offset: 0x0003C670
	private bool PlayChargeMontage()
	{
		if (string.IsNullOrEmpty(this.TsChargeMontage))
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming 未配置蓄力蒙太奇路径", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		Entity entity = this.Entity;
		CharacterAnimationComponent characterAnimationComponent = (entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null;
		if (characterAnimationComponent == null || !characterAnimationComponent.Valid)
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskTurretAiming 拿不到AnimationComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		this.StopChargeMontage();
		int montageId = -1;
		montageId = characterAnimationComponent.MontageManager.PlayMontage(new IPlayMontageParam
		{
			MontagePath = this.TsChargeMontage,
			IsLoop = new bool?(true),
			OnEndCallback = delegate(UAnimMontage m, bool b)
			{
				if (this.PlayingMontageId == montageId)
				{
					this.PlayingMontageId = -1;
				}
			}
		});
		this.PlayingMontageId = montageId;
		return this.PlayingMontageId >= 0;
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x0003E55C File Offset: 0x0003C75C
	private void StopChargeMontage()
	{
		if (this.PlayingMontageId >= 0)
		{
			Entity entity = this.Entity;
			CharacterAnimationComponent characterAnimationComponent = (entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null;
			if (characterAnimationComponent != null && characterAnimationComponent.Valid)
			{
				characterAnimationComponent.StopMontageByHandleId(new IStopMontageParam
				{
					HandleId = new int?(this.PlayingMontageId),
					Method = new EStopMethod?(EStopMethod.BlendOut)
				});
			}
			this.PlayingMontageId = -1;
		}
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x0003E5C0 File Offset: 0x0003C7C0
	private void ManageAimSoundBuff(TsTaskTurretAiming.ETurretAimingState currentState)
	{
		Entity entity = this.Entity;
		if (entity == null || !entity.Valid)
		{
			return;
		}
		CharacterBuffComponent component = entity.GetComponent<CharacterBuffComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		if (this.TsSlowAimSoundBuffId > 0 && currentState != TsTaskTurretAiming.ETurretAimingState.SlowCharging)
		{
			component.RemoveBuff((long)this.TsSlowAimSoundBuffId, -1, "TsTaskTurretAiming ManageAimSoundBuff Remove SlowCharging", null, null, null);
		}
		if (this.TsFastAimSoundBuffId > 0 && currentState != TsTaskTurretAiming.ETurretAimingState.FastCharging && currentState != TsTaskTurretAiming.ETurretAimingState.Locked)
		{
			component.RemoveBuff((long)this.TsFastAimSoundBuffId, -1, "TsTaskTurretAiming ManageAimSoundBuff Remove FastCharging", null, null, null);
		}
		if (currentState == TsTaskTurretAiming.ETurretAimingState.SlowCharging && this.TsSlowAimSoundBuffId > 0)
		{
			component.AddBuffFromAi(this.TsAiCombatMessageId, (long)this.TsSlowAimSoundBuffId, new AddBuffParam
			{
				InstigatorId = component.CreatureDataId,
				Reason = "TsTaskTurretAiming ManageAimSoundBuff SlowCharging"
			});
			return;
		}
		if (currentState == TsTaskTurretAiming.ETurretAimingState.FastCharging && this.TsFastAimSoundBuffId > 0)
		{
			component.AddBuffFromAi(this.TsAiCombatMessageId, (long)this.TsFastAimSoundBuffId, new AddBuffParam
			{
				InstigatorId = component.CreatureDataId,
				Reason = "TsTaskTurretAiming ManageAimSoundBuff FastCharging"
			});
		}
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x0003E6EC File Offset: 0x0003C8EC
	private void DebugLog(string message, [Nullable(new byte[]
	{
		1,
		0,
		1,
		2
	})] params ValueTuple<string, object>[] pairs)
	{
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x0003E6F0 File Offset: 0x0003C8F0
	private void DrawDebugInfo(BaseActorComponent targetActorComponent)
	{
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x0003E700 File Offset: 0x0003C900
	private void DebugAimAlignment(float deltaSeconds, BaseActorComponent targetActorComponent)
	{
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x0003E710 File Offset: 0x0003C910
	[NullableContext(0)]
	private ValueTuple<double, double, double, double, double> GetNiagaraDebugMetrics()
	{
		double item = -1.0;
		double item2 = -1.0;
		double item3 = -1.0;
		double item4 = -1.0;
		double item5 = -1.0;
		UNiagaraComponent uniagaraComponent = ((this.EffectHandle ?? 0) != 0) ? EffectSystem.Instance.GetSureNiagaraComponent(this.EffectHandle.Value) : null;
		if (uniagaraComponent != null && uniagaraComponent.IsValid())
		{
			global::Vector niagaraComponentLocation = this.NiagaraComponentLocation;
			FVectorDouble fvectorDouble = uniagaraComponent.D_K2_GetComponentLocation();
			niagaraComponentLocation.FromUeVector(fvectorDouble);
			this.DebugNiagaraDirection.DeepCopy(this.AimLineEndPoint);
			this.DebugNiagaraDirection.SubtractionEqual(this.NiagaraComponentLocation);
			if (this.DebugNiagaraDirection.Normalize(9.99999993922529E-09))
			{
				item = MathUtils.Instance.GetAngleByVectorDot(this.TmpWorldSightDir, this.DebugNiagaraDirection);
				item2 = MathUtils.Instance.GetAngleByVectorDot(this.SocketForward, this.DebugNiagaraDirection);
				global::Vector debugNiagaraForward = this.DebugNiagaraForward;
				fvectorDouble = uniagaraComponent.D_GetForwardVector();
				debugNiagaraForward.FromUeVector(fvectorDouble);
				if (this.DebugNiagaraForward.Normalize(9.99999993922529E-09))
				{
					item3 = MathUtils.Instance.GetAngleByVectorDot(this.DebugNiagaraForward, this.DebugNiagaraDirection);
				}
			}
			item4 = global::Vector.Dist(this.SocketLocation, this.NiagaraComponentLocation);
			item5 = global::Vector.Dist(this.NiagaraComponentLocation, this.AimLineEndPoint);
		}
		return new ValueTuple<double, double, double, double, double>(item, item2, item3, item4, item5);
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x0003E8A8 File Offset: 0x0003CAA8
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTurretAiming._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurretAiming.TsTaskTurretAiming_C");
		}
		return TsTaskTurretAiming._ClassPtr;
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x0003E8CC File Offset: 0x0003CACC
	public TsTaskTurretAiming() : this(BuiltinUtils.AllocNativeUObject(TsTaskTurretAiming.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x0003E8F4 File Offset: 0x0003CAF4
	public TsTaskTurretAiming(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurretAiming.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x0003E928 File Offset: 0x0003CB28
	protected TsTaskTurretAiming(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x0003EB98 File Offset: 0x0003CD98
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x0003EBC8 File Offset: 0x0003CDC8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400095A RID: 2394
	private static readonly FName HIT_POSITION_PARAM_NAME = new FName("HitPosition");

	// Token: 0x0400095B RID: 2395
	private static readonly FName RATE_PARAM_NAME = new FName("Rate");

	// Token: 0x0400095C RID: 2396
	private const int SLOW_RATE = 0;

	// Token: 0x0400095D RID: 2397
	private const int FAST_RATE = 1;

	// Token: 0x0400095E RID: 2398
	private const string AIM_LINE_TRACE_PROFILE_KEY = "TsTaskTurretAiming_AimLine";

	// Token: 0x0400095F RID: 2399
	private const float SOCKET_FORWARD_SMOOTH_TIME = 0.01f;

	// Token: 0x04000960 RID: 2400
	private const float TARGET_VELOCITY_SMOOTH_TIME = 0.1f;

	// Token: 0x04000961 RID: 2401
	private const float DEBUG_DRAW_DURATION = 0.1f;

	// Token: 0x04000962 RID: 2402
	private const float DEBUG_LINE_THICKNESS = 2f;

	// Token: 0x04000963 RID: 2403
	private const float DEBUG_ARROW_SIZE = 30f;

	// Token: 0x04000964 RID: 2404
	private const float DEBUG_ARROW_LENGTH = 700f;

	// Token: 0x04000965 RID: 2405
	private const float DEBUG_TARGET_RADIUS = 30f;

	// Token: 0x04000966 RID: 2406
	private const float DEBUG_SIGHT_TARGET_RADIUS = 20f;

	// Token: 0x04000967 RID: 2407
	private const float DEBUG_NIAGARA_RADIUS = 15f;

	// Token: 0x04000968 RID: 2408
	private const float DEBUG_NIAGARA_LINE_EXTENSION = 500f;

	// Token: 0x04000969 RID: 2409
	private const float DEBUG_ALIGNMENT_LOG_INTERVAL = 0.5f;

	// Token: 0x0400096A RID: 2410
	private const int DEBUG_SPHERE_SEGMENTS = 12;

	// Token: 0x0400096B RID: 2411
	private const float DEBUG_TEXT_Z_OFFSET = 50f;

	// Token: 0x0400096C RID: 2412
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor currentSightColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x0400096D RID: 2413
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor targetLineColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x0400096E RID: 2414
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor aimLineColor = new FLinearColor(0f, 1f, 1f, 1f);

	// Token: 0x0400096F RID: 2415
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor sightTargetPointColor = new FLinearColor(1f, 0f, 1f, 1f);

	// Token: 0x04000970 RID: 2416
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor niagaraAimLineColor = new FLinearColor(1f, 1f, 0f, 1f);

	// Token: 0x04000971 RID: 2417
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor debugTextColor = new FLinearColor(1f, 1f, 0f, 1f);

	// Token: 0x04000972 RID: 2418
	private bool IsInitTsVariables;

	// Token: 0x04000973 RID: 2419
	private string TsTargetIdBlackboardKey = "";

	// Token: 0x04000974 RID: 2420
	private string TsTurretAimingStateBlackboardKey = "";

	// Token: 0x04000975 RID: 2421
	private FName? TsMuzzleSocketName;

	// Token: 0x04000976 RID: 2422
	private FName? TsTargetSocketName;

	// Token: 0x04000977 RID: 2423
	private float TsStartChargeToleranceDegree = 5f;

	// Token: 0x04000978 RID: 2424
	private float TsBreakChargeToleranceDegree = 7.5f;

	// Token: 0x04000979 RID: 2425
	private float TsFastChargeTimeSeconds = 2.2f;

	// Token: 0x0400097A RID: 2426
	private float TsSlowChargeTriggerTimeSeconds;

	// Token: 0x0400097B RID: 2427
	private float TsLockTimeSeconds = 4f;

	// Token: 0x0400097C RID: 2428
	private float TsFireDelaySeconds = 1f;

	// Token: 0x0400097D RID: 2429
	private float TsMaxAimDistance = 2000f;

	// Token: 0x0400097E RID: 2430
	private float TsSightPredictTimeSeconds;

	// Token: 0x0400097F RID: 2431
	private string TsAimLineEffectPath = "";

	// Token: 0x04000980 RID: 2432
	private string TsChargeMontage = "";

	// Token: 0x04000981 RID: 2433
	private int TsFireSkillId;

	// Token: 0x04000982 RID: 2434
	private int TsSlowAimSoundBuffId;

	// Token: 0x04000983 RID: 2435
	private int TsFastAimSoundBuffId;

	// Token: 0x04000984 RID: 2436
	private TsTaskTurretAiming.ETurretAimingState CurrentTurretAimingState;

	// Token: 0x04000985 RID: 2437
	private float CurrentStateTimeSeconds;

	// Token: 0x04000986 RID: 2438
	private int CurrentTargetId = -1;

	// Token: 0x04000987 RID: 2439
	private bool IsTaskActive;

	// Token: 0x04000988 RID: 2440
	private float DebugAlignmentLogElapsedSeconds;

	// Token: 0x04000989 RID: 2441
	private string AimLineSelectedHitType = "None";

	// Token: 0x0400098A RID: 2442
	private string AimLineVisibleHitActorName = "None";

	// Token: 0x0400098B RID: 2443
	private int? EffectHandle;

	// Token: 0x0400098C RID: 2444
	private int PlayingMontageId = -1;

	// Token: 0x0400098D RID: 2445
	[Nullable(2)]
	private Entity Entity;

	// Token: 0x0400098E RID: 2446
	[Nullable(2)]
	private UTraceLineElement AimLineTrace;

	// Token: 0x0400098F RID: 2447
	private bool WaitingFireSkill;

	// Token: 0x04000990 RID: 2448
	private long? TsAiCombatMessageId;

	// Token: 0x04000991 RID: 2449
	private readonly global::Vector SmoothedSocketForward = global::Vector.Create();

	// Token: 0x04000992 RID: 2450
	private bool IsSocketForwardInitialized;

	// Token: 0x04000993 RID: 2451
	private readonly global::Vector SmoothedTargetVelocity = global::Vector.Create();

	// Token: 0x04000994 RID: 2452
	private bool IsTargetVelocityInitialized;

	// Token: 0x04000995 RID: 2453
	private readonly global::Vector FiringHitPosition = global::Vector.Create();

	// Token: 0x04000996 RID: 2454
	private bool IsAimLineSnappedToTarget;

	// Token: 0x04000997 RID: 2455
	private readonly global::Vector TmpWorldSightDir = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04000998 RID: 2456
	private readonly global::Vector SightTargetPoint = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04000999 RID: 2457
	private readonly global::Vector SocketLocation = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400099A RID: 2458
	private readonly global::Vector TargetSocketLocation = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400099B RID: 2459
	private readonly global::Vector TargetSightPoint = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400099C RID: 2460
	private readonly global::Vector SocketForward = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400099D RID: 2461
	private readonly global::Vector DebugSightEndPoint = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400099E RID: 2462
	private readonly global::Vector DebugTextLocation = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400099F RID: 2463
	private readonly global::Vector AimLineEndPoint = global::Vector.Create();

	// Token: 0x040009A0 RID: 2464
	private readonly global::Vector AimLineEndPointResult = global::Vector.Create();

	// Token: 0x040009A1 RID: 2465
	private readonly global::Vector AimLineTraceEndPoint = global::Vector.Create();

	// Token: 0x040009A2 RID: 2466
	private readonly global::Vector AimLineVisibleHitPoint = global::Vector.Create();

	// Token: 0x040009A3 RID: 2467
	private readonly global::Vector NiagaraComponentLocation = global::Vector.Create();

	// Token: 0x040009A4 RID: 2468
	private readonly global::Vector HitPositionWorldRelative = global::Vector.Create();

	// Token: 0x040009A5 RID: 2469
	private readonly global::Vector NiagaraAimLineStartPoint = global::Vector.Create();

	// Token: 0x040009A6 RID: 2470
	private readonly global::Vector DebugTargetDirection = global::Vector.Create();

	// Token: 0x040009A7 RID: 2471
	private readonly global::Vector DebugNiagaraDirection = global::Vector.Create();

	// Token: 0x040009A8 RID: 2472
	private readonly global::Vector DebugNiagaraForward = global::Vector.Create();

	// Token: 0x040009A9 RID: 2473
	private FVector EffectVectorParam = new FVector();

	// Token: 0x040009AA RID: 2474
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTurretAiming.TsTaskTurretAiming_C";

	// Token: 0x040009AB RID: 2475
	private static IntPtr _ClassPtr;

	// Token: 0x040009AC RID: 2476
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040009AD RID: 2477
	private static int __PropertyOffset_TargetIdBlackboardKey;

	// Token: 0x040009AE RID: 2478
	private static int __PropertyOffset_TurretAimingStateBlackboardKey;

	// Token: 0x040009AF RID: 2479
	private static int __PropertyOffset_MuzzleSocketName;

	// Token: 0x040009B0 RID: 2480
	private static int __PropertyOffset_TargetSocketName;

	// Token: 0x040009B1 RID: 2481
	private static int __PropertyOffset_StartChargeToleranceDegree;

	// Token: 0x040009B2 RID: 2482
	private static int __PropertyOffset_BreakChargeToleranceDegree;

	// Token: 0x040009B3 RID: 2483
	private static int __PropertyOffset_FastChargeTimeSeconds;

	// Token: 0x040009B4 RID: 2484
	private static int __PropertyOffset_SlowChargeTriggerTimeSeconds;

	// Token: 0x040009B5 RID: 2485
	private static int __PropertyOffset_LockTimeSeconds;

	// Token: 0x040009B6 RID: 2486
	private static int __PropertyOffset_FireDelaySeconds;

	// Token: 0x040009B7 RID: 2487
	private static int __PropertyOffset_MaxAimDistance;

	// Token: 0x040009B8 RID: 2488
	private static int __PropertyOffset_SightPredictTimeSeconds;

	// Token: 0x040009B9 RID: 2489
	private static int __PropertyOffset_AimLineEffectPath;

	// Token: 0x040009BA RID: 2490
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UObject> _AimLineEffectPath;

	// Token: 0x040009BB RID: 2491
	private static int __PropertyOffset_ChargeMontage;

	// Token: 0x040009BC RID: 2492
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAnimMontage> _ChargeMontage;

	// Token: 0x040009BD RID: 2493
	private static int __PropertyOffset_FireSkillId;

	// Token: 0x040009BE RID: 2494
	private static int __PropertyOffset_SlowAimSoundBuffId;

	// Token: 0x040009BF RID: 2495
	private static int __PropertyOffset_FastAimSoundBuffId;

	// Token: 0x040009C0 RID: 2496
	private static int __PropertyOffset_SocketPoseForward;

	// Token: 0x040009C1 RID: 2497
	private static int __PropertyOffset_EnableDebug;

	// Token: 0x02006508 RID: 25864
	[NullableContext(0)]
	private enum ETurretAimingState
	{
		// Token: 0x04021904 RID: 137476
		None,
		// Token: 0x04021905 RID: 137477
		Tracking,
		// Token: 0x04021906 RID: 137478
		SlowCharging,
		// Token: 0x04021907 RID: 137479
		FastCharging,
		// Token: 0x04021908 RID: 137480
		Locked,
		// Token: 0x04021909 RID: 137481
		Firing
	}
}
