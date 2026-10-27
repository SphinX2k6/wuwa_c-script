using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001BD RID: 445
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyHideBone.TsAnimNotifyHideBone_C")]
public class TsAnimNotifyHideBone : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000478 RID: 1144
	// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x0008F0DF File Offset: 0x0008D2DF
	// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x0008F0F3 File Offset: 0x0008D2F3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BoneName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyHideBone.__PropertyOffset_BoneName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyHideBone.__PropertyOffset_BoneName)), value);
		}
	}

	// Token: 0x17000479 RID: 1145
	// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0008F108 File Offset: 0x0008D308
	// (set) Token: 0x06001BEA RID: 7146 RVA: 0x0008F118 File Offset: 0x0008D318
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Hide
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyHideBone.__PropertyOffset_Hide) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyHideBone.__PropertyOffset_Hide) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700047A RID: 1146
	// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0008F129 File Offset: 0x0008D329
	// (set) Token: 0x06001BEC RID: 7148 RVA: 0x0008F139 File Offset: 0x0008D339
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IgnoreTsBaseCharacter
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyHideBone.__PropertyOffset_IgnoreTsBaseCharacter) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyHideBone.__PropertyOffset_IgnoreTsBaseCharacter) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001BED RID: 7149 RVA: 0x0008F14C File Offset: 0x0008D34C
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

	// Token: 0x06001BEE RID: 7150 RVA: 0x0008F1EC File Offset: 0x0008D3EC
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.IgnoreTsBaseCharacter)
		{
			MeshComponentUtils.HideBone(meshComp, this.BoneName, this.Hide);
			return true;
		}
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null && tsBaseCharacter.CharacterActorComponent != null)
		{
			CharacterAnimationComponent component = tsBaseCharacter.CharacterActorComponent.Entity.GetComponent<CharacterAnimationComponent>();
			if (component != null)
			{
				component.HideBone(FNameUtil.GetDynamicFName(this.BoneName).Value, this.Hide, true);
			}
		}
		return true;
	}

	// Token: 0x06001BEF RID: 7151 RVA: 0x0008F264 File Offset: 0x0008D464
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

	// Token: 0x06001BF0 RID: 7152 RVA: 0x0008F2DF File Offset: 0x0008D4DF
	protected override string GetNotifyName_Implementation()
	{
		return "隐藏骨骼";
	}

	// Token: 0x06001BF1 RID: 7153 RVA: 0x0008F2E6 File Offset: 0x0008D4E6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyHideBone._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyHideBone.TsAnimNotifyHideBone_C");
		}
		return TsAnimNotifyHideBone._ClassPtr;
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x0008F30C File Offset: 0x0008D50C
	public TsAnimNotifyHideBone() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyHideBone.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001BF3 RID: 7155 RVA: 0x0008F334 File Offset: 0x0008D534
	public TsAnimNotifyHideBone(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyHideBone.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001BF4 RID: 7156 RVA: 0x0008F367 File Offset: 0x0008D567
	protected TsAnimNotifyHideBone(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x0008F370 File Offset: 0x0008D570
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x0008F3A3 File Offset: 0x0008D5A3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011B5 RID: 4533
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyHideBone.TsAnimNotifyHideBone_C";

	// Token: 0x040011B6 RID: 4534
	private static IntPtr _ClassPtr;

	// Token: 0x040011B7 RID: 4535
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011B8 RID: 4536
	private static int __PropertyOffset_BoneName;

	// Token: 0x040011B9 RID: 4537
	private static int __PropertyOffset_Hide;

	// Token: 0x040011BA RID: 4538
	private static int __PropertyOffset_IgnoreTsBaseCharacter;
}
