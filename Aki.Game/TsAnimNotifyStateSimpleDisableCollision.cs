using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000176 RID: 374
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSimpleDisableCollision.TsAnimNotifyStateSimpleDisableCollision_C")]
public class TsAnimNotifyStateSimpleDisableCollision : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x060017FC RID: 6140 RVA: 0x00083BD3 File Offset: 0x00081DD3
	static TsAnimNotifyStateSimpleDisableCollision()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateSimpleDisableCollision.CreateStaticDefaultValue), new Action(TsAnimNotifyStateSimpleDisableCollision.ResetStaticDefaultValue));
	}

	// Token: 0x060017FD RID: 6141 RVA: 0x00083BF2 File Offset: 0x00081DF2
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap = new Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, int>>();
	}

	// Token: 0x060017FE RID: 6142 RVA: 0x00083BFE File Offset: 0x00081DFE
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap = null;
	}

	// Token: 0x060017FF RID: 6143 RVA: 0x00083C06 File Offset: 0x00081E06
	[NullableContext(1)]
	[return: Nullable(2)]
	private BaseActorComponent GetActorComponent(TsBaseCharacter owner)
	{
		if (owner.CharacterActorComponent != null)
		{
			return owner.CharacterActorComponent;
		}
		return owner.SimpleNpcActorComponent;
	}

	// Token: 0x06001800 RID: 6144 RVA: 0x00083C20 File Offset: 0x00081E20
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSimpleDisableCollision) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSimpleDisableCollision.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001801 RID: 6145 RVA: 0x00083CE0 File Offset: 0x00081EE0
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			BaseActorComponent actorComponent = this.GetActorComponent(tsBaseCharacter);
			if (actorComponent == null || !actorComponent.Valid)
			{
				return true;
			}
			Dictionary<UAnimNotifyState, int> dictionary;
			if (!TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap.TryGetValue(meshComp, out dictionary))
			{
				dictionary = (TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap[meshComp] = new Dictionary<UAnimNotifyState, int>());
			}
			if (dictionary.ContainsKey(this))
			{
				return false;
			}
			int value = actorComponent.DisableCollision("TsAnimNotifyStateSimpleDisableCollision.K2_NotifyBegin");
			dictionary[this] = value;
		}
		return true;
	}

	// Token: 0x06001802 RID: 6146 RVA: 0x00083D58 File Offset: 0x00081F58
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSimpleDisableCollision) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSimpleDisableCollision.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001803 RID: 6147 RVA: 0x00083E10 File Offset: 0x00082010
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter && TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap.ContainsKey(meshComp))
		{
			Dictionary<UAnimNotifyState, int> dictionary = TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap[meshComp];
			if (dictionary.ContainsKey(this))
			{
				int handle = dictionary[this];
				EntityHandle handle2 = CharacterModel.Instance.GetHandle((owner as TsBaseCharacter).EntityId);
				if (handle2 != null && handle2.Valid)
				{
					BaseActorComponent actorComponent = this.GetActorComponent(owner as TsBaseCharacter);
					if (actorComponent != null)
					{
						actorComponent.EnableCollision(handle);
					}
				}
				dictionary.Remove(this);
				if (dictionary.Count == 0)
				{
					TsAnimNotifyStateSimpleDisableCollision.collisionDisableHandleMap.Remove(meshComp);
				}
			}
		}
		return true;
	}

	// Token: 0x06001804 RID: 6148 RVA: 0x00083EB4 File Offset: 0x000820B4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSimpleDisableCollision) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSimpleDisableCollision.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001805 RID: 6149 RVA: 0x00083F44 File Offset: 0x00082144
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "禁用Actor碰撞";
	}

	// Token: 0x06001806 RID: 6150 RVA: 0x00083F4B File Offset: 0x0008214B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSimpleDisableCollision._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSimpleDisableCollision.TsAnimNotifyStateSimpleDisableCollision_C");
		}
		return TsAnimNotifyStateSimpleDisableCollision._ClassPtr;
	}

	// Token: 0x06001807 RID: 6151 RVA: 0x00083F70 File Offset: 0x00082170
	public TsAnimNotifyStateSimpleDisableCollision() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSimpleDisableCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001808 RID: 6152 RVA: 0x00083F98 File Offset: 0x00082198
	[NullableContext(1)]
	public TsAnimNotifyStateSimpleDisableCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSimpleDisableCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001809 RID: 6153 RVA: 0x00083FCB File Offset: 0x000821CB
	protected TsAnimNotifyStateSimpleDisableCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600180A RID: 6154 RVA: 0x00083FD4 File Offset: 0x000821D4
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600180B RID: 6155 RVA: 0x00084010 File Offset: 0x00082210
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600180C RID: 6156 RVA: 0x00084043 File Offset: 0x00082243
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001029 RID: 4137
	[Nullable(1)]
	private static Dictionary<USkeletalMeshComponent, Dictionary<UAnimNotifyState, int>> collisionDisableHandleMap;

	// Token: 0x0400102A RID: 4138
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSimpleDisableCollision.TsAnimNotifyStateSimpleDisableCollision_C";

	// Token: 0x0400102B RID: 4139
	private static IntPtr _ClassPtr;

	// Token: 0x0400102C RID: 4140
	private static IntPtr _ClassDefaultObjectPtr;
}
