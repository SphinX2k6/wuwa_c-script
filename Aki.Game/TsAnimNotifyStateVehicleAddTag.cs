using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000187 RID: 391
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVehicleAddTag.TsAnimNotifyStateVehicleAddTag_C")]
public class TsAnimNotifyStateVehicleAddTag : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000418 RID: 1048
	// (get) Token: 0x06001917 RID: 6423 RVA: 0x0008871F File Offset: 0x0008691F
	// (set) Token: 0x06001918 RID: 6424 RVA: 0x00088733 File Offset: 0x00086933
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

	// Token: 0x17000419 RID: 1049
	// (get) Token: 0x06001919 RID: 6425 RVA: 0x00088748 File Offset: 0x00086948
	// (set) Token: 0x0600191A RID: 6426 RVA: 0x00088758 File Offset: 0x00086958
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

	// Token: 0x1700041A RID: 1050
	// (get) Token: 0x0600191B RID: 6427 RVA: 0x00088769 File Offset: 0x00086969
	// (set) Token: 0x0600191C RID: 6428 RVA: 0x00088779 File Offset: 0x00086979
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

	// Token: 0x1700041B RID: 1051
	// (get) Token: 0x0600191D RID: 6429 RVA: 0x0008878A File Offset: 0x0008698A
	// (set) Token: 0x0600191E RID: 6430 RVA: 0x0008879A File Offset: 0x0008699A
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

	// Token: 0x0600191F RID: 6431 RVA: 0x000887AC File Offset: 0x000869AC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVehicleAddTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateVehicleAddTag.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001920 RID: 6432 RVA: 0x0008886C File Offset: 0x00086A6C
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

	// Token: 0x06001921 RID: 6433 RVA: 0x00088974 File Offset: 0x00086B74
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVehicleAddTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateVehicleAddTag.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001922 RID: 6434 RVA: 0x00088A2C File Offset: 0x00086C2C
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

	// Token: 0x06001923 RID: 6435 RVA: 0x00088B44 File Offset: 0x00086D44
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVehicleAddTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateVehicleAddTag.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001924 RID: 6436 RVA: 0x00088BD4 File Offset: 0x00086DD4
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "载具添加TAG";
	}

	// Token: 0x06001925 RID: 6437 RVA: 0x00088BDB File Offset: 0x00086DDB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateVehicleAddTag._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVehicleAddTag.TsAnimNotifyStateVehicleAddTag_C");
		}
		return TsAnimNotifyStateVehicleAddTag._ClassPtr;
	}

	// Token: 0x06001926 RID: 6438 RVA: 0x00088C00 File Offset: 0x00086E00
	public TsAnimNotifyStateVehicleAddTag() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVehicleAddTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001927 RID: 6439 RVA: 0x00088C28 File Offset: 0x00086E28
	[NullableContext(1)]
	public TsAnimNotifyStateVehicleAddTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVehicleAddTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001928 RID: 6440 RVA: 0x00088C5B File Offset: 0x00086E5B
	protected TsAnimNotifyStateVehicleAddTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001929 RID: 6441 RVA: 0x00088C64 File Offset: 0x00086E64
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600192A RID: 6442 RVA: 0x00088CA0 File Offset: 0x00086EA0
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600192B RID: 6443 RVA: 0x00088CD3 File Offset: 0x00086ED3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400109A RID: 4250
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVehicleAddTag.TsAnimNotifyStateVehicleAddTag_C";

	// Token: 0x0400109B RID: 4251
	private static IntPtr _ClassPtr;

	// Token: 0x0400109C RID: 4252
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400109D RID: 4253
	private static int __PropertyOffset_Tag;

	// Token: 0x0400109E RID: 4254
	private static int __PropertyOffset_AddToVehicle;

	// Token: 0x0400109F RID: 4255
	private static int __PropertyOffset_AddToDriver;

	// Token: 0x040010A0 RID: 4256
	private static int __PropertyOffset_AddToPassengerExceptDriver;
}
