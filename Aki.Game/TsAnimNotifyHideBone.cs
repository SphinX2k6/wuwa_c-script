using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C1 RID: 449
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyHideBone.TsAnimNotifyHideBone_C")]
public class TsAnimNotifyHideBone : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700049A RID: 1178
	// (get) Token: 0x06001C84 RID: 7300 RVA: 0x00095B73 File Offset: 0x00093D73
	// (set) Token: 0x06001C85 RID: 7301 RVA: 0x00095B87 File Offset: 0x00093D87
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

	// Token: 0x1700049B RID: 1179
	// (get) Token: 0x06001C86 RID: 7302 RVA: 0x00095B9C File Offset: 0x00093D9C
	// (set) Token: 0x06001C87 RID: 7303 RVA: 0x00095BAC File Offset: 0x00093DAC
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

	// Token: 0x1700049C RID: 1180
	// (get) Token: 0x06001C88 RID: 7304 RVA: 0x00095BBD File Offset: 0x00093DBD
	// (set) Token: 0x06001C89 RID: 7305 RVA: 0x00095BCD File Offset: 0x00093DCD
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

	// Token: 0x06001C8A RID: 7306 RVA: 0x00095BE0 File Offset: 0x00093DE0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyHideBone) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyHideBone.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001C8B RID: 7307 RVA: 0x00095C98 File Offset: 0x00093E98
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

	// Token: 0x06001C8C RID: 7308 RVA: 0x00095D10 File Offset: 0x00093F10
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyHideBone) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyHideBone.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001C8D RID: 7309 RVA: 0x00095DA0 File Offset: 0x00093FA0
	protected override string GetNotifyName_Implementation()
	{
		return "隐藏骨骼";
	}

	// Token: 0x06001C8E RID: 7310 RVA: 0x00095DA7 File Offset: 0x00093FA7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyHideBone._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyHideBone.TsAnimNotifyHideBone_C");
		}
		return TsAnimNotifyHideBone._ClassPtr;
	}

	// Token: 0x06001C8F RID: 7311 RVA: 0x00095DCC File Offset: 0x00093FCC
	public TsAnimNotifyHideBone() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyHideBone.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C90 RID: 7312 RVA: 0x00095DF4 File Offset: 0x00093FF4
	public TsAnimNotifyHideBone(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyHideBone.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C91 RID: 7313 RVA: 0x00095E27 File Offset: 0x00094027
	protected TsAnimNotifyHideBone(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C92 RID: 7314 RVA: 0x00095E30 File Offset: 0x00094030
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C93 RID: 7315 RVA: 0x00095E63 File Offset: 0x00094063
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011F8 RID: 4600
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyHideBone.TsAnimNotifyHideBone_C";

	// Token: 0x040011F9 RID: 4601
	private static IntPtr _ClassPtr;

	// Token: 0x040011FA RID: 4602
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011FB RID: 4603
	private static int __PropertyOffset_BoneName;

	// Token: 0x040011FC RID: 4604
	private static int __PropertyOffset_Hide;

	// Token: 0x040011FD RID: 4605
	private static int __PropertyOffset_IgnoreTsBaseCharacter;
}
