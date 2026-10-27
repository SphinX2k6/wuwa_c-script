using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000164 RID: 356
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetCollisionSize.TsAnimNotifyStateSetCollisionSize_C")]
public class TsAnimNotifyStateSetCollisionSize : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001666 RID: 5734 RVA: 0x0007A437 File Offset: 0x00078637
	static TsAnimNotifyStateSetCollisionSize()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateSetCollisionSize.CreateStaticDefaultValue), new Action(TsAnimNotifyStateSetCollisionSize.ResetStaticDefaultValue));
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x0007A456 File Offset: 0x00078656
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateSetCollisionSize.saveId = new Dictionary<int, int>();
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x0007A462 File Offset: 0x00078662
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateSetCollisionSize.saveId = null;
	}

	// Token: 0x170003AE RID: 942
	// (get) Token: 0x06001669 RID: 5737 RVA: 0x0007A46A File Offset: 0x0007866A
	// (set) Token: 0x0600166A RID: 5738 RVA: 0x0007A47A File Offset: 0x0007867A
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

	// Token: 0x170003AF RID: 943
	// (get) Token: 0x0600166B RID: 5739 RVA: 0x0007A48B File Offset: 0x0007868B
	// (set) Token: 0x0600166C RID: 5740 RVA: 0x0007A49B File Offset: 0x0007869B
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

	// Token: 0x170003B0 RID: 944
	// (get) Token: 0x0600166D RID: 5741 RVA: 0x0007A4AC File Offset: 0x000786AC
	// (set) Token: 0x0600166E RID: 5742 RVA: 0x0007A4BC File Offset: 0x000786BC
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

	// Token: 0x0600166F RID: 5743 RVA: 0x0007A4D0 File Offset: 0x000786D0
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

	// Token: 0x06001670 RID: 5744 RVA: 0x0007A578 File Offset: 0x00078778
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

	// Token: 0x06001671 RID: 5745 RVA: 0x0007A66C File Offset: 0x0007886C
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

	// Token: 0x06001672 RID: 5746 RVA: 0x0007A70C File Offset: 0x0007890C
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

	// Token: 0x06001673 RID: 5747 RVA: 0x0007A770 File Offset: 0x00078970
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

	// Token: 0x06001674 RID: 5748 RVA: 0x0007A7EB File Offset: 0x000789EB
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置胶囊体大小";
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x0007A7F2 File Offset: 0x000789F2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetCollisionSize._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetCollisionSize.TsAnimNotifyStateSetCollisionSize_C");
		}
		return TsAnimNotifyStateSetCollisionSize._ClassPtr;
	}

	// Token: 0x06001676 RID: 5750 RVA: 0x0007A818 File Offset: 0x00078A18
	public TsAnimNotifyStateSetCollisionSize() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetCollisionSize.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001677 RID: 5751 RVA: 0x0007A840 File Offset: 0x00078A40
	[NullableContext(1)]
	public TsAnimNotifyStateSetCollisionSize(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetCollisionSize.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x0007A873 File Offset: 0x00078A73
	protected TsAnimNotifyStateSetCollisionSize(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x0007A87C File Offset: 0x00078A7C
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x0007A8B8 File Offset: 0x00078AB8
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x0007A8EB File Offset: 0x00078AEB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F90 RID: 3984
	[Nullable(1)]
	private static Dictionary<int, int> saveId;

	// Token: 0x04000F91 RID: 3985
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetCollisionSize.TsAnimNotifyStateSetCollisionSize_C";

	// Token: 0x04000F92 RID: 3986
	private static IntPtr _ClassPtr;

	// Token: 0x04000F93 RID: 3987
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F94 RID: 3988
	private static int __PropertyOffset_Id;

	// Token: 0x04000F95 RID: 3989
	private static int __PropertyOffset_Radius;

	// Token: 0x04000F96 RID: 3990
	private static int __PropertyOffset_HalfHeight;
}
