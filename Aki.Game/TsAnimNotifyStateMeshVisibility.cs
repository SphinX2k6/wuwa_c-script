using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.CreatureTools;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000145 RID: 325
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMeshVisibility.TsAnimNotifyStateMeshVisibility_C")]
public class TsAnimNotifyStateMeshVisibility : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000340 RID: 832
	// (get) Token: 0x060013FC RID: 5116 RVA: 0x0006F937 File Offset: 0x0006DB37
	// (set) Token: 0x060013FD RID: 5117 RVA: 0x0006F94B File Offset: 0x0006DB4B
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

	// Token: 0x17000341 RID: 833
	// (get) Token: 0x060013FE RID: 5118 RVA: 0x0006F960 File Offset: 0x0006DB60
	// (set) Token: 0x060013FF RID: 5119 RVA: 0x0006F970 File Offset: 0x0006DB70
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

	// Token: 0x06001400 RID: 5120 RVA: 0x0006F984 File Offset: 0x0006DB84
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

	// Token: 0x06001401 RID: 5121 RVA: 0x0006FA2C File Offset: 0x0006DC2C
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

	// Token: 0x06001402 RID: 5122 RVA: 0x0006FB64 File Offset: 0x0006DD64
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

	// Token: 0x06001403 RID: 5123 RVA: 0x0006FC04 File Offset: 0x0006DE04
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

	// Token: 0x06001404 RID: 5124 RVA: 0x0006FD14 File Offset: 0x0006DF14
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

	// Token: 0x06001405 RID: 5125 RVA: 0x0006FD8F File Offset: 0x0006DF8F
	protected override string GetNotifyName_Implementation()
	{
		return "控制角色Mesh显隐";
	}

	// Token: 0x06001406 RID: 5126 RVA: 0x0006FD96 File Offset: 0x0006DF96
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateMeshVisibility._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMeshVisibility.TsAnimNotifyStateMeshVisibility_C");
		}
		return TsAnimNotifyStateMeshVisibility._ClassPtr;
	}

	// Token: 0x06001407 RID: 5127 RVA: 0x0006FDBC File Offset: 0x0006DFBC
	public TsAnimNotifyStateMeshVisibility() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateMeshVisibility.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001408 RID: 5128 RVA: 0x0006FDE4 File Offset: 0x0006DFE4
	public TsAnimNotifyStateMeshVisibility(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateMeshVisibility.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x0006FE17 File Offset: 0x0006E017
	protected TsAnimNotifyStateMeshVisibility(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x0006FE2C File Offset: 0x0006E02C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x0006FE68 File Offset: 0x0006E068
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600140C RID: 5132 RVA: 0x0006FE9B File Offset: 0x0006E09B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E75 RID: 3701
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<int, List<USkeletalMeshComponent>> EntityMeshMap = new Dictionary<int, List<USkeletalMeshComponent>>();

	// Token: 0x04000E76 RID: 3702
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateMeshVisibility.TsAnimNotifyStateMeshVisibility_C";

	// Token: 0x04000E77 RID: 3703
	private static IntPtr _ClassPtr;

	// Token: 0x04000E78 RID: 3704
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E79 RID: 3705
	private static int __PropertyOffset_HideMeshName;

	// Token: 0x04000E7A RID: 3706
	private static int __PropertyOffset_Visibility;
}
