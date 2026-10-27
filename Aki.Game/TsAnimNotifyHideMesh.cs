using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001BE RID: 446
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyHideMesh.TsAnimNotifyHideMesh_C")]
public class TsAnimNotifyHideMesh : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700047B RID: 1147
	// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x0008F3B7 File Offset: 0x0008D5B7
	// (set) Token: 0x06001BF8 RID: 7160 RVA: 0x0008F3CB File Offset: 0x0008D5CB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ChildMeshName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_ChildMeshName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_ChildMeshName)), value);
		}
	}

	// Token: 0x1700047C RID: 1148
	// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x0008F3E0 File Offset: 0x0008D5E0
	// (set) Token: 0x06001BFA RID: 7162 RVA: 0x0008F3F0 File Offset: 0x0008D5F0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HideChildren
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_HideChildren) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_HideChildren) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700047D RID: 1149
	// (get) Token: 0x06001BFB RID: 7163 RVA: 0x0008F401 File Offset: 0x0008D601
	// (set) Token: 0x06001BFC RID: 7164 RVA: 0x0008F411 File Offset: 0x0008D611
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HideChildrenActors
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_HideChildrenActors) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_HideChildrenActors) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700047E RID: 1150
	// (get) Token: 0x06001BFD RID: 7165 RVA: 0x0008F422 File Offset: 0x0008D622
	// (set) Token: 0x06001BFE RID: 7166 RVA: 0x0008F432 File Offset: 0x0008D632
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Hide
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_Hide) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyHideMesh.__PropertyOffset_Hide) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001BFF RID: 7167 RVA: 0x0008F444 File Offset: 0x0008D644
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
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

	// Token: 0x06001C00 RID: 7168 RVA: 0x0008F4E4 File Offset: 0x0008D6E4
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		UMeshComponent umeshComponent = null;
		if (string.IsNullOrEmpty(this.ChildMeshName))
		{
			umeshComponent = meshComp;
		}
		else
		{
			TArray<UActorComponent> tarray = owner.K2_GetComponentsByClass(UMeshComponent.StaticClass());
			for (int i = tarray.Num() - 1; i >= 0; i--)
			{
				UMeshComponent umeshComponent2 = tarray.Get(i) as UMeshComponent;
				if (((umeshComponent2 != null) ? umeshComponent2.GetName() : null) == this.ChildMeshName)
				{
					umeshComponent = umeshComponent2;
					break;
				}
			}
		}
		if (umeshComponent == null)
		{
			return false;
		}
		umeshComponent.SetHiddenInGame(this.Hide, this.HideChildren);
		return true;
	}

	// Token: 0x06001C01 RID: 7169 RVA: 0x0008F57C File Offset: 0x0008D77C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06001C02 RID: 7170 RVA: 0x0008F5F7 File Offset: 0x0008D7F7
	protected override string GetNotifyName_Implementation()
	{
		return "隐藏网格体";
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x0008F5FE File Offset: 0x0008D7FE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyHideMesh._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyHideMesh.TsAnimNotifyHideMesh_C");
		}
		return TsAnimNotifyHideMesh._ClassPtr;
	}

	// Token: 0x06001C04 RID: 7172 RVA: 0x0008F624 File Offset: 0x0008D824
	public TsAnimNotifyHideMesh() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyHideMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C05 RID: 7173 RVA: 0x0008F64C File Offset: 0x0008D84C
	public TsAnimNotifyHideMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyHideMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x0008F67F File Offset: 0x0008D87F
	protected TsAnimNotifyHideMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C07 RID: 7175 RVA: 0x0008F688 File Offset: 0x0008D888
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C08 RID: 7176 RVA: 0x0008F6BB File Offset: 0x0008D8BB
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011BB RID: 4539
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyHideMesh.TsAnimNotifyHideMesh_C";

	// Token: 0x040011BC RID: 4540
	private static IntPtr _ClassPtr;

	// Token: 0x040011BD RID: 4541
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011BE RID: 4542
	private static int __PropertyOffset_ChildMeshName;

	// Token: 0x040011BF RID: 4543
	private static int __PropertyOffset_HideChildren;

	// Token: 0x040011C0 RID: 4544
	private static int __PropertyOffset_HideChildrenActors;

	// Token: 0x040011C1 RID: 4545
	private static int __PropertyOffset_Hide;
}
