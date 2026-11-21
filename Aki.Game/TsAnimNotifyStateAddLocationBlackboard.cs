using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000106 RID: 262
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddLocationBlackboard.TsAnimNotifyStateAddLocationBlackboard_C")]
public class TsAnimNotifyStateAddLocationBlackboard : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000F46 RID: 3910 RVA: 0x0005960A File Offset: 0x0005780A
	static TsAnimNotifyStateAddLocationBlackboard()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateAddLocationBlackboard.CreateStaticDefaultValue), new Action(TsAnimNotifyStateAddLocationBlackboard.ResetStaticDefaultValue));
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x00059633 File Offset: 0x00057833
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateAddLocationBlackboard.paramsPool = new List<AddLocationBlackboardParams>();
		TsAnimNotifyStateAddLocationBlackboard.paramsMaps = new Dictionary<string, Dictionary<int, AddLocationBlackboardParams>>();
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x00059649 File Offset: 0x00057849
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateAddLocationBlackboard.paramsPool = null;
		TsAnimNotifyStateAddLocationBlackboard.paramsMaps = null;
	}

	// Token: 0x17000277 RID: 631
	// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00059657 File Offset: 0x00057857
	// (set) Token: 0x06000F4A RID: 3914 RVA: 0x0005966B File Offset: 0x0005786B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string AddLocationKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_AddLocationKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_AddLocationKey)), value);
		}
	}

	// Token: 0x17000278 RID: 632
	// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00059680 File Offset: 0x00057880
	// (set) Token: 0x06000F4C RID: 3916 RVA: 0x00059694 File Offset: 0x00057894
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat Curve
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_Curve);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_Curve, value);
		}
	}

	// Token: 0x17000279 RID: 633
	// (get) Token: 0x06000F4D RID: 3917 RVA: 0x000596A9 File Offset: 0x000578A9
	// (set) Token: 0x06000F4E RID: 3918 RVA: 0x000596B9 File Offset: 0x000578B9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NeedChangeToFlying
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_NeedChangeToFlying) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_NeedChangeToFlying) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700027A RID: 634
	// (get) Token: 0x06000F4F RID: 3919 RVA: 0x000596CA File Offset: 0x000578CA
	// (set) Token: 0x06000F50 RID: 3920 RVA: 0x000596DA File Offset: 0x000578DA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAnsBlackboardType 黑板类型
	{
		get
		{
			return (EAnsBlackboardType)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_黑板类型));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddLocationBlackboard.__PropertyOffset_黑板类型) = (byte)value;
		}
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x000596EC File Offset: 0x000578EC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddLocationBlackboard) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateAddLocationBlackboard.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x000597AC File Offset: 0x000579AC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		int id = (owner as TsBaseCharacter).CharacterActorComponent.Entity.Id;
		if (string.IsNullOrEmpty(this.AddLocationKey))
		{
			return false;
		}
		Dictionary<int, AddLocationBlackboardParams> dictionary;
		if (!TsAnimNotifyStateAddLocationBlackboard.paramsMaps.TryGetValue(this.AddLocationKey, out dictionary))
		{
			dictionary = new Dictionary<int, AddLocationBlackboardParams>();
			TsAnimNotifyStateAddLocationBlackboard.paramsMaps.Add(this.AddLocationKey, dictionary);
		}
		AddLocationBlackboardParams addLocationBlackboardParams = (TsAnimNotifyStateAddLocationBlackboard.paramsPool.Count > 0) ? TsAnimNotifyStateAddLocationBlackboard.paramsPool[TsAnimNotifyStateAddLocationBlackboard.paramsPool.Count - 1] : new AddLocationBlackboardParams();
		if (TsAnimNotifyStateAddLocationBlackboard.paramsPool.Count > 0)
		{
			TsAnimNotifyStateAddLocationBlackboard.paramsPool.RemoveAt(TsAnimNotifyStateAddLocationBlackboard.paramsPool.Count - 1);
		}
		addLocationBlackboardParams.TotalDuration = totalDuration;
		addLocationBlackboardParams.RunTime = 0f;
		switch (this.黑板类型)
		{
		case EAnsBlackboardType.Direct:
		{
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(id, this.AddLocationKey);
			if (vectorValueByEntity == null)
			{
				return false;
			}
			addLocationBlackboardParams.AddOffset.FromUeVector(vectorValueByEntity);
			break;
		}
		case EAnsBlackboardType.Location:
		{
			Aki.Protocol.Vector vectorValueByEntity2 = BlackboardController.Instance.GetVectorValueByEntity(id, this.AddLocationKey);
			if (vectorValueByEntity2 == null)
			{
				return false;
			}
			addLocationBlackboardParams.AddOffset.FromUeVector(vectorValueByEntity2);
			addLocationBlackboardParams.AddOffset.SubtractionEqual((owner as TsBaseCharacter).CharacterActorComponent.ActorLocationProxy);
			break;
		}
		case EAnsBlackboardType.EntityId:
		case EAnsBlackboardType.Int:
		{
			int? num = null;
			if (this.黑板类型 == EAnsBlackboardType.EntityId)
			{
				num = BlackboardController.Instance.GetEntityIdByEntity(id, this.AddLocationKey);
			}
			else
			{
				num = BlackboardController.Instance.GetIntValueByEntity(id, this.AddLocationKey);
			}
			if (num == null)
			{
				return false;
			}
			Entity entity = EntitySystem.Instance.Get(num.Value);
			if (entity == null || !entity.Valid)
			{
				return false;
			}
			BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
			addLocationBlackboardParams.AddOffset.DeepCopy(component.ActorLocationProxy);
			addLocationBlackboardParams.AddOffset.SubtractionEqual((owner as TsBaseCharacter).CharacterActorComponent.ActorLocationProxy);
			break;
		}
		default:
			return false;
		}
		dictionary.Add(id, addLocationBlackboardParams);
		if (this.NeedChangeToFlying)
		{
			(owner as TsBaseCharacter).KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Flying,
				Context = "[TsAnimNotifyStateAddLocationBlackboard.K2_NotifyBegin]"
			});
		}
		return true;
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x000599EC File Offset: 0x00057BEC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float deltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddLocationBlackboard) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateAddLocationBlackboard.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, deltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = deltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x00059AAC File Offset: 0x00057CAC
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float deltaTime)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Entity entity = (owner as TsBaseCharacter).CharacterActorComponent.Entity;
		int id = entity.Id;
		Dictionary<int, AddLocationBlackboardParams> dictionary;
		if (!TsAnimNotifyStateAddLocationBlackboard.paramsMaps.TryGetValue(this.AddLocationKey, out dictionary))
		{
			return false;
		}
		AddLocationBlackboardParams addLocationBlackboardParams;
		if (!dictionary.TryGetValue(id, out addLocationBlackboardParams))
		{
			return false;
		}
		if (addLocationBlackboardParams.RunTime >= addLocationBlackboardParams.TotalDuration)
		{
			return true;
		}
		float num = Math.Min(addLocationBlackboardParams.TotalDuration, addLocationBlackboardParams.RunTime + deltaTime);
		float num2;
		if (this.Curve != null)
		{
			num2 = this.Curve.GetFloatValue(num / addLocationBlackboardParams.TotalDuration) - this.Curve.GetFloatValue(addLocationBlackboardParams.RunTime / addLocationBlackboardParams.TotalDuration);
		}
		else
		{
			num2 = (num - addLocationBlackboardParams.RunTime) / addLocationBlackboardParams.TotalDuration;
		}
		BaseMoveComponent component = entity.GetComponent<CharacterMoveComponent>();
		addLocationBlackboardParams.AddOffset.Multiply((double)num2, TsAnimNotifyStateAddLocationBlackboard.tmpVector);
		component.MoveCharacter(TsAnimNotifyStateAddLocationBlackboard.tmpVector, deltaTime, "");
		addLocationBlackboardParams.RunTime = num;
		return true;
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x00059BBC File Offset: 0x00057DBC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddLocationBlackboard) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateAddLocationBlackboard.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x00059C74 File Offset: 0x00057E74
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Dictionary<int, AddLocationBlackboardParams> dictionary;
		if (!TsAnimNotifyStateAddLocationBlackboard.paramsMaps.TryGetValue(this.AddLocationKey, out dictionary))
		{
			return false;
		}
		int id = (owner as TsBaseCharacter).CharacterActorComponent.Entity.Id;
		AddLocationBlackboardParams item;
		if (!dictionary.TryGetValue(id, out item))
		{
			return true;
		}
		TsAnimNotifyStateAddLocationBlackboard.paramsPool.Add(item);
		dictionary.Remove(id);
		return true;
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x00059CE0 File Offset: 0x00057EE0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAddLocationBlackboard) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateAddLocationBlackboard.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x00059D70 File Offset: 0x00057F70
	protected override string GetNotifyName_Implementation()
	{
		return "黑板位置设置角色位置偏移";
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x00059D77 File Offset: 0x00057F77
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAddLocationBlackboard._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddLocationBlackboard.TsAnimNotifyStateAddLocationBlackboard_C");
		}
		return TsAnimNotifyStateAddLocationBlackboard._ClassPtr;
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x00059D9C File Offset: 0x00057F9C
	public TsAnimNotifyStateAddLocationBlackboard() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddLocationBlackboard.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x00059DC4 File Offset: 0x00057FC4
	public TsAnimNotifyStateAddLocationBlackboard(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddLocationBlackboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x00059DF7 File Offset: 0x00057FF7
	protected TsAnimNotifyStateAddLocationBlackboard(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x00059E00 File Offset: 0x00058000
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x00059E3C File Offset: 0x0005803C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06000F5F RID: 3935 RVA: 0x00059E78 File Offset: 0x00058078
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x00059EAB File Offset: 0x000580AB
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C11 RID: 3089
	private static List<AddLocationBlackboardParams> paramsPool;

	// Token: 0x04000C12 RID: 3090
	private static Dictionary<string, Dictionary<int, AddLocationBlackboardParams>> paramsMaps;

	// Token: 0x04000C13 RID: 3091
	[StaticVariableRuleIgnore]
	private static global::Vector tmpVector = global::Vector.Create();

	// Token: 0x04000C14 RID: 3092
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAddLocationBlackboard.TsAnimNotifyStateAddLocationBlackboard_C";

	// Token: 0x04000C15 RID: 3093
	private static IntPtr _ClassPtr;

	// Token: 0x04000C16 RID: 3094
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C17 RID: 3095
	private static int __PropertyOffset_AddLocationKey;

	// Token: 0x04000C18 RID: 3096
	private static int __PropertyOffset_Curve;

	// Token: 0x04000C19 RID: 3097
	private static int __PropertyOffset_NeedChangeToFlying;

	// Token: 0x04000C1A RID: 3098
	private static int __PropertyOffset_黑板类型;
}
