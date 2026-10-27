using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000183 RID: 387
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVehicleAddTag.TsAnimNotifyStateVehicleAddTag_C")]
public class TsAnimNotifyStateVehicleAddTag : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003F6 RID: 1014
	// (get) Token: 0x0600187A RID: 6266 RVA: 0x000826B7 File Offset: 0x000808B7
	// (set) Token: 0x0600187B RID: 6267 RVA: 0x000826CB File Offset: 0x000808CB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleAddTag.__PropertyOffset_Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleAddTag.__PropertyOffset_Tag) = value;
		}
	}

	// Token: 0x170003F7 RID: 1015
	// (get) Token: 0x0600187C RID: 6268 RVA: 0x000826E0 File Offset: 0x000808E0
	// (set) Token: 0x0600187D RID: 6269 RVA: 0x000826F0 File Offset: 0x000808F0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool AddToVehicle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleAddTag.__PropertyOffset_AddToVehicle) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleAddTag.__PropertyOffset_AddToVehicle) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003F8 RID: 1016
	// (get) Token: 0x0600187E RID: 6270 RVA: 0x00082701 File Offset: 0x00080901
	// (set) Token: 0x0600187F RID: 6271 RVA: 0x00082711 File Offset: 0x00080911
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool AddToDriver
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleAddTag.__PropertyOffset_AddToDriver) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleAddTag.__PropertyOffset_AddToDriver) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003F9 RID: 1017
	// (get) Token: 0x06001880 RID: 6272 RVA: 0x00082722 File Offset: 0x00080922
	// (set) Token: 0x06001881 RID: 6273 RVA: 0x00082732 File Offset: 0x00080932
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool AddToPassengerExceptDriver
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleAddTag.__PropertyOffset_AddToPassengerExceptDriver) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVehicleAddTag.__PropertyOffset_AddToPassengerExceptDriver) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001882 RID: 6274 RVA: 0x00082744 File Offset: 0x00080944
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001883 RID: 6275 RVA: 0x000827EC File Offset: 0x000809EC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		int tagId = this.Tag.TagId();
		if (!(owner is TsBaseVehicle))
		{
			return false;
		}
		VehicleActorComponent vehicleActorComponent = (owner as TsBaseVehicle).VehicleActorComponent;
		Entity entity = (vehicleActorComponent != null) ? vehicleActorComponent.Entity : null;
		VehicleTagComponent vehicleTagComponent = (entity != null) ? entity.GetComponent<VehicleTagComponent>() : null;
		if (entity == null || vehicleTagComponent == null)
		{
			return false;
		}
		if (this.AddToVehicle)
		{
			vehicleTagComponent.TagContainer.AddExactTag(ETagChannel.Anim, tagId);
		}
		BaseVehiclePerformComponent component = entity.GetComponent<BaseVehiclePerformComponent>();
		if (this.AddToDriver && component.Driver != null)
		{
			vehicleTagComponent.AddTagForPassenger(component.Driver, ETagChannel.Anim, tagId);
		}
		if (this.AddToPassengerExceptDriver)
		{
			foreach (VehiclePassengerInfo vehiclePassengerInfo in component.PassengerInfoMap.Values)
			{
				if (!vehiclePassengerInfo.IsDriver && vehiclePassengerInfo.PassengerEntity != null)
				{
					vehicleTagComponent.AddTagForPassenger(vehiclePassengerInfo.PassengerEntity, ETagChannel.Anim, tagId);
				}
			}
		}
		return true;
	}

	// Token: 0x06001884 RID: 6276 RVA: 0x000828F4 File Offset: 0x00080AF4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001885 RID: 6277 RVA: 0x00082994 File Offset: 0x00080B94
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		int tagId = this.Tag.TagId();
		if (!(owner is TsBaseVehicle))
		{
			return false;
		}
		VehicleActorComponent vehicleActorComponent = (owner as TsBaseVehicle).VehicleActorComponent;
		Entity entity = (vehicleActorComponent != null) ? vehicleActorComponent.Entity : null;
		VehicleTagComponent vehicleTagComponent = (entity != null) ? entity.GetComponent<VehicleTagComponent>() : null;
		if (entity == null || vehicleTagComponent == null)
		{
			return false;
		}
		if (this.AddToVehicle)
		{
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null)
			{
				baseTagComponent.TagContainer.RemoveExactTag(ETagChannel.Anim, tagId);
			}
		}
		BaseVehiclePerformComponent component = entity.GetComponent<BaseVehiclePerformComponent>();
		if (this.AddToDriver && component.Driver != null)
		{
			vehicleTagComponent.RemoveTagForPassenger(component.Driver, ETagChannel.Anim, tagId);
		}
		if (this.AddToPassengerExceptDriver)
		{
			foreach (VehiclePassengerInfo vehiclePassengerInfo in component.PassengerInfoMap.Values)
			{
				if (!vehiclePassengerInfo.IsDriver && vehiclePassengerInfo.PassengerEntity != null)
				{
					vehicleTagComponent.RemoveTagForPassenger(vehiclePassengerInfo.PassengerEntity, ETagChannel.Anim, tagId);
				}
			}
		}
		return true;
	}

	// Token: 0x06001886 RID: 6278 RVA: 0x00082AAC File Offset: 0x00080CAC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x06001887 RID: 6279 RVA: 0x00082B27 File Offset: 0x00080D27
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "载具添加TAG";
	}

	// Token: 0x06001888 RID: 6280 RVA: 0x00082B2E File Offset: 0x00080D2E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateVehicleAddTag._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVehicleAddTag.TsAnimNotifyStateVehicleAddTag_C");
		}
		return TsAnimNotifyStateVehicleAddTag._ClassPtr;
	}

	// Token: 0x06001889 RID: 6281 RVA: 0x00082B54 File Offset: 0x00080D54
	public TsAnimNotifyStateVehicleAddTag() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVehicleAddTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600188A RID: 6282 RVA: 0x00082B7C File Offset: 0x00080D7C
	[NullableContext(1)]
	public TsAnimNotifyStateVehicleAddTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVehicleAddTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600188B RID: 6283 RVA: 0x00082BAF File Offset: 0x00080DAF
	protected TsAnimNotifyStateVehicleAddTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600188C RID: 6284 RVA: 0x00082BB8 File Offset: 0x00080DB8
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600188D RID: 6285 RVA: 0x00082BF4 File Offset: 0x00080DF4
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600188E RID: 6286 RVA: 0x00082C27 File Offset: 0x00080E27
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001057 RID: 4183
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVehicleAddTag.TsAnimNotifyStateVehicleAddTag_C";

	// Token: 0x04001058 RID: 4184
	private static IntPtr _ClassPtr;

	// Token: 0x04001059 RID: 4185
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400105A RID: 4186
	private static int __PropertyOffset_Tag;

	// Token: 0x0400105B RID: 4187
	private static int __PropertyOffset_AddToVehicle;

	// Token: 0x0400105C RID: 4188
	private static int __PropertyOffset_AddToDriver;

	// Token: 0x0400105D RID: 4189
	private static int __PropertyOffset_AddToPassengerExceptDriver;
}
