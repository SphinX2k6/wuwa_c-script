using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.CreatureTools;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000149 RID: 329
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMeshVisibility.TsAnimNotifyStateMeshVisibility_C")]
public class TsAnimNotifyStateMeshVisibility : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000362 RID: 866
	// (get) Token: 0x06001499 RID: 5273 RVA: 0x00074B37 File Offset: 0x00072D37
	// (set) Token: 0x0600149A RID: 5274 RVA: 0x00074B4B File Offset: 0x00072D4B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string HideMeshName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateMeshVisibility.__PropertyOffset_HideMeshName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateMeshVisibility.__PropertyOffset_HideMeshName)), value);
		}
	}

	// Token: 0x17000363 RID: 867
	// (get) Token: 0x0600149B RID: 5275 RVA: 0x00074B60 File Offset: 0x00072D60
	// (set) Token: 0x0600149C RID: 5276 RVA: 0x00074B70 File Offset: 0x00072D70
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Visibility
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateMeshVisibility.__PropertyOffset_Visibility) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateMeshVisibility.__PropertyOffset_Visibility) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600149D RID: 5277 RVA: 0x00074B84 File Offset: 0x00072D84
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateMeshVisibility) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateMeshVisibility.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600149E RID: 5278 RVA: 0x00074C44 File Offset: 0x00072E44
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (this.EntityMeshMap == null)
		{
			this.EntityMeshMap = new Dictionary<int, List<USkeletalMeshComponent>>();
		}
		AActor owner = meshComp.GetOwner();
		TArray<UActorComponent> tarray = owner.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
		USkeletalMeshComponent uskeletalMeshComponent = null;
		for (int i = 0; i < tarray.Num(); i++)
		{
			UActorComponent uactorComponent = tarray.Get(i);
			if (uactorComponent.GetName() == this.HideMeshName)
			{
				uskeletalMeshComponent = (uactorComponent as USkeletalMeshComponent);
				break;
			}
		}
		BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(owner);
		if (worldType != BP_EWorldType.Game && worldType != BP_EWorldType.PIE)
		{
			if (uskeletalMeshComponent != null)
			{
				uskeletalMeshComponent.SetVisibility(this.Visibility, false);
			}
			return true;
		}
		IBPI_CreatureInterface_C ibpi_CreatureInterface_C = owner as IBPI_CreatureInterface_C;
		if (ibpi_CreatureInterface_C == null)
		{
			Log.Instance.Error(ELogModule.Render, ELogAuthor.YZ, "TsAnimNotifyStateHideMesh,该Actor不是一个实体", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		int entityId = ibpi_CreatureInterface_C.GetEntityId();
		List<USkeletalMeshComponent> list;
		if (!this.EntityMeshMap.TryGetValue(entityId, out list))
		{
			list = (this.EntityMeshMap[entityId] = new List<USkeletalMeshComponent>());
		}
		if (uskeletalMeshComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Render;
			ELogAuthor author = ELogAuthor.YZ;
			string message = "TsAnimNotifyStateHideMesh无法找到Mesh";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("填入Mesh名", this.HideMeshName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		list.Add(uskeletalMeshComponent);
		uskeletalMeshComponent.SetVisibility(this.Visibility, false);
		return true;
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x00074D7C File Offset: 0x00072F7C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateMeshVisibility) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateMeshVisibility.StaticClass(), out intPtr, out num))
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

	// Token: 0x060014A0 RID: 5280 RVA: 0x00074E34 File Offset: 0x00073034
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		BP_EWorldType worldType = UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldType(owner);
		if (worldType != BP_EWorldType.Game && worldType != BP_EWorldType.PIE)
		{
			TArray<UActorComponent> tarray = owner.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
			USkeletalMeshComponent uskeletalMeshComponent = null;
			for (int i = 0; i < tarray.Num(); i++)
			{
				UActorComponent uactorComponent = tarray.Get(i);
				if (uactorComponent.GetName() == this.HideMeshName)
				{
					uskeletalMeshComponent = (uactorComponent as USkeletalMeshComponent);
					break;
				}
			}
			if (uskeletalMeshComponent != null)
			{
				uskeletalMeshComponent.SetVisibility(!this.Visibility, false);
			}
			return true;
		}
		int entityId = (owner as IBPI_CreatureInterface_C).GetEntityId();
		List<USkeletalMeshComponent> list;
		if (this.EntityMeshMap.TryGetValue(entityId, out list))
		{
			foreach (USkeletalMeshComponent uskeletalMeshComponent2 in list)
			{
				if (uskeletalMeshComponent2.GetName() == this.HideMeshName)
				{
					uskeletalMeshComponent2.SetVisibility(!this.Visibility, false);
					break;
				}
			}
		}
		return true;
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x00074F44 File Offset: 0x00073144
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateMeshVisibility) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateMeshVisibility.StaticClass(), out intPtr, out num))
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

	// Token: 0x060014A2 RID: 5282 RVA: 0x00074FD4 File Offset: 0x000731D4
	protected override string GetNotifyName_Implementation()
	{
		return "控制角色Mesh显隐";
	}

	// Token: 0x060014A3 RID: 5283 RVA: 0x00074FDB File Offset: 0x000731DB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateMeshVisibility._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMeshVisibility.TsAnimNotifyStateMeshVisibility_C");
		}
		return TsAnimNotifyStateMeshVisibility._ClassPtr;
	}

	// Token: 0x060014A4 RID: 5284 RVA: 0x00075000 File Offset: 0x00073200
	public TsAnimNotifyStateMeshVisibility() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateMeshVisibility.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x00075028 File Offset: 0x00073228
	public TsAnimNotifyStateMeshVisibility(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateMeshVisibility.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x0007505B File Offset: 0x0007325B
	protected TsAnimNotifyStateMeshVisibility(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060014A7 RID: 5287 RVA: 0x00075070 File Offset: 0x00073270
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x000750AC File Offset: 0x000732AC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x000750DF File Offset: 0x000732DF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000EB8 RID: 3768
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<int, List<USkeletalMeshComponent>> EntityMeshMap = new Dictionary<int, List<USkeletalMeshComponent>>();

	// Token: 0x04000EB9 RID: 3769
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMeshVisibility.TsAnimNotifyStateMeshVisibility_C";

	// Token: 0x04000EBA RID: 3770
	private static IntPtr _ClassPtr;

	// Token: 0x04000EBB RID: 3771
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000EBC RID: 3772
	private static int __PropertyOffset_HideMeshName;

	// Token: 0x04000EBD RID: 3773
	private static int __PropertyOffset_Visibility;
}
