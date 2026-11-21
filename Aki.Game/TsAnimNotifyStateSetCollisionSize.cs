using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000168 RID: 360
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetCollisionSize.TsAnimNotifyStateSetCollisionSize_C")]
public class TsAnimNotifyStateSetCollisionSize : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001703 RID: 5891 RVA: 0x0007FD87 File Offset: 0x0007DF87
	static TsAnimNotifyStateSetCollisionSize()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateSetCollisionSize.CreateStaticDefaultValue), new Action(TsAnimNotifyStateSetCollisionSize.ResetStaticDefaultValue));
	}

	// Token: 0x06001704 RID: 5892 RVA: 0x0007FDA6 File Offset: 0x0007DFA6
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateSetCollisionSize.saveId = new Dictionary<int, int>();
	}

	// Token: 0x06001705 RID: 5893 RVA: 0x0007FDB2 File Offset: 0x0007DFB2
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateSetCollisionSize.saveId = null;
	}

	// Token: 0x170003D0 RID: 976
	// (get) Token: 0x06001706 RID: 5894 RVA: 0x0007FDBA File Offset: 0x0007DFBA
	// (set) Token: 0x06001707 RID: 5895 RVA: 0x0007FDCA File Offset: 0x0007DFCA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Id
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetCollisionSize.__PropertyOffset_Id);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetCollisionSize.__PropertyOffset_Id) = value;
		}
	}

	// Token: 0x170003D1 RID: 977
	// (get) Token: 0x06001708 RID: 5896 RVA: 0x0007FDDB File Offset: 0x0007DFDB
	// (set) Token: 0x06001709 RID: 5897 RVA: 0x0007FDEB File Offset: 0x0007DFEB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Radius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetCollisionSize.__PropertyOffset_Radius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetCollisionSize.__PropertyOffset_Radius) = value;
		}
	}

	// Token: 0x170003D2 RID: 978
	// (get) Token: 0x0600170A RID: 5898 RVA: 0x0007FDFC File Offset: 0x0007DFFC
	// (set) Token: 0x0600170B RID: 5899 RVA: 0x0007FE0C File Offset: 0x0007E00C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float HalfHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetCollisionSize.__PropertyOffset_HalfHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetCollisionSize.__PropertyOffset_HalfHeight) = value;
		}
	}

	// Token: 0x0600170C RID: 5900 RVA: 0x0007FE20 File Offset: 0x0007E020
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetCollisionSize) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSetCollisionSize.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600170D RID: 5901 RVA: 0x0007FEE0 File Offset: 0x0007E0E0
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		if (this.HalfHeight <= 0f || this.Radius <= 0f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "TsAnimNotifyStateSetCollisionSize配置了错误的大小。为避免穿墙，必须大于0";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", owner);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HalfHeight", this.HalfHeight);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Radius", this.Radius);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		int id = characterActorComponent.Entity.Id;
		TsAnimNotifyStateSetCollisionSize.saveId[id] = this.Id;
		characterActorComponent.SetRadiusAndHalfHeight(this.Radius, this.HalfHeight, false, false);
		return true;
	}

	// Token: 0x0600170E RID: 5902 RVA: 0x0007FFD4 File Offset: 0x0007E1D4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetCollisionSize) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSetCollisionSize.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600170F RID: 5903 RVA: 0x0008008C File Offset: 0x0007E28C
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		int id = characterActorComponent.Entity.Id;
		int num;
		if (TsAnimNotifyStateSetCollisionSize.saveId.TryGetValue(id, out num) && num == this.Id)
		{
			characterActorComponent.ResetCapsuleRadiusAndHeight(false);
			TsAnimNotifyStateSetCollisionSize.saveId.Remove(id);
		}
		return true;
	}

	// Token: 0x06001710 RID: 5904 RVA: 0x000800F0 File Offset: 0x0007E2F0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetCollisionSize) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSetCollisionSize.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001711 RID: 5905 RVA: 0x00080180 File Offset: 0x0007E380
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置胶囊体大小";
	}

	// Token: 0x06001712 RID: 5906 RVA: 0x00080187 File Offset: 0x0007E387
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetCollisionSize._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetCollisionSize.TsAnimNotifyStateSetCollisionSize_C");
		}
		return TsAnimNotifyStateSetCollisionSize._ClassPtr;
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x000801AC File Offset: 0x0007E3AC
	public TsAnimNotifyStateSetCollisionSize() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetCollisionSize.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001714 RID: 5908 RVA: 0x000801D4 File Offset: 0x0007E3D4
	[NullableContext(1)]
	public TsAnimNotifyStateSetCollisionSize(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetCollisionSize.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001715 RID: 5909 RVA: 0x00080207 File Offset: 0x0007E407
	protected TsAnimNotifyStateSetCollisionSize(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001716 RID: 5910 RVA: 0x00080210 File Offset: 0x0007E410
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001717 RID: 5911 RVA: 0x0008024C File Offset: 0x0007E44C
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x0008027F File Offset: 0x0007E47F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FD3 RID: 4051
	[Nullable(1)]
	private static Dictionary<int, int> saveId;

	// Token: 0x04000FD4 RID: 4052
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetCollisionSize.TsAnimNotifyStateSetCollisionSize_C";

	// Token: 0x04000FD5 RID: 4053
	private static IntPtr _ClassPtr;

	// Token: 0x04000FD6 RID: 4054
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FD7 RID: 4055
	private static int __PropertyOffset_Id;

	// Token: 0x04000FD8 RID: 4056
	private static int __PropertyOffset_Radius;

	// Token: 0x04000FD9 RID: 4057
	private static int __PropertyOffset_HalfHeight;
}
