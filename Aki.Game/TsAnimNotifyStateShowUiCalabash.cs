using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200016D RID: 365
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiCalabash.TsAnimNotifyStateShowUiCalabash_C")]
public class TsAnimNotifyStateShowUiCalabash : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003C3 RID: 963
	// (get) Token: 0x06001709 RID: 5897 RVA: 0x0007CA13 File Offset: 0x0007AC13
	// (set) Token: 0x0600170A RID: 5898 RVA: 0x0007CA27 File Offset: 0x0007AC27
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName Socket
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiCalabash.__PropertyOffset_Socket);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiCalabash.__PropertyOffset_Socket) = value;
		}
	}

	// Token: 0x170003C4 RID: 964
	// (get) Token: 0x0600170B RID: 5899 RVA: 0x0007CA3C File Offset: 0x0007AC3C
	// (set) Token: 0x0600170C RID: 5900 RVA: 0x0007CA4C File Offset: 0x0007AC4C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsRotate
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiCalabash.__PropertyOffset_IsRotate) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiCalabash.__PropertyOffset_IsRotate) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600170D RID: 5901 RVA: 0x0007CA60 File Offset: 0x0007AC60
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

	// Token: 0x0600170E RID: 5902 RVA: 0x0007CB08 File Offset: 0x0007AD08
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (this.Socket == FName.NAME_None)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "Ui界面葫芦显示动画通知中socket配置为空";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("meshComp", meshComp);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("animation", animation);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		AActor owner = meshComp.GetOwner();
		if (owner is TsUiSceneRoleActor)
		{
			UiCalabashAnsContext value = new UiCalabashAnsContext(this.Socket, this.IsRotate);
			UiModelBase model = (owner as TsUiSceneRoleActor).Model;
			if (model != null)
			{
				model.CheckGetComponent<UiModelAnsControllerComponent>().AddAns<UiCalabashAnsContext>("UiCalabashAnsContext", value);
			}
		}
		return false;
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x0007CBC0 File Offset: 0x0007ADC0
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

	// Token: 0x06001710 RID: 5904 RVA: 0x0007CC60 File Offset: 0x0007AE60
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.Socket == FName.NAME_None)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "Ui界面葫芦显示动画通知中socket配置为空";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("meshComp", meshComp);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("animation", animation);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		AActor owner = meshComp.GetOwner();
		if (owner is TsUiSceneRoleActor)
		{
			UiCalabashAnsContext value = new UiCalabashAnsContext(this.Socket, this.IsRotate);
			UiModelBase model = (owner as TsUiSceneRoleActor).Model;
			if (model != null)
			{
				model.CheckGetComponent<UiModelAnsControllerComponent>().ReduceAns<UiCalabashAnsContext>("UiCalabashAnsContext", value);
			}
		}
		return false;
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x0007CD18 File Offset: 0x0007AF18
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

	// Token: 0x06001712 RID: 5906 RVA: 0x0007CD93 File Offset: 0x0007AF93
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "Ui界面葫芦显示";
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x0007CD9A File Offset: 0x0007AF9A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateShowUiCalabash._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiCalabash.TsAnimNotifyStateShowUiCalabash_C");
		}
		return TsAnimNotifyStateShowUiCalabash._ClassPtr;
	}

	// Token: 0x06001714 RID: 5908 RVA: 0x0007CDC0 File Offset: 0x0007AFC0
	public TsAnimNotifyStateShowUiCalabash() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateShowUiCalabash.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001715 RID: 5909 RVA: 0x0007CDE8 File Offset: 0x0007AFE8
	[NullableContext(1)]
	public TsAnimNotifyStateShowUiCalabash(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateShowUiCalabash.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001716 RID: 5910 RVA: 0x0007CE1B File Offset: 0x0007B01B
	protected TsAnimNotifyStateShowUiCalabash(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001717 RID: 5911 RVA: 0x0007CE24 File Offset: 0x0007B024
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x0007CE60 File Offset: 0x0007B060
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001719 RID: 5913 RVA: 0x0007CE93 File Offset: 0x0007B093
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FC7 RID: 4039
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiCalabash.TsAnimNotifyStateShowUiCalabash_C";

	// Token: 0x04000FC8 RID: 4040
	private static IntPtr _ClassPtr;

	// Token: 0x04000FC9 RID: 4041
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FCA RID: 4042
	private static int __PropertyOffset_Socket;

	// Token: 0x04000FCB RID: 4043
	private static int __PropertyOffset_IsRotate;
}
