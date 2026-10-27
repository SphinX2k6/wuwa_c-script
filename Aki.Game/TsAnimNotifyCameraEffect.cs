using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200019C RID: 412
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraEffect.TsAnimNotifyCameraEffect_C")]
public class TsAnimNotifyCameraEffect : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700043D RID: 1085
	// (get) Token: 0x06001A2B RID: 6699 RVA: 0x000893AB File Offset: 0x000875AB
	// (set) Token: 0x06001A2C RID: 6700 RVA: 0x000893BF File Offset: 0x000875BF
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EffectScreenPlayData_C EffectData
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<EffectScreenPlayData_C>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyCameraEffect.__PropertyOffset_EffectData);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyCameraEffect.__PropertyOffset_EffectData, value);
		}
	}

	// Token: 0x06001A2D RID: 6701 RVA: 0x000893D4 File Offset: 0x000875D4
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

	// Token: 0x06001A2E RID: 6702 RVA: 0x00089473 File Offset: 0x00087673
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.EffectData != null)
		{
			ScreenEffectSystem.GetInstance().PlayScreenEffect(this.EffectData);
		}
		return true;
	}

	// Token: 0x06001A2F RID: 6703 RVA: 0x00089490 File Offset: 0x00087690
	[NullableContext(1)]
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

	// Token: 0x06001A30 RID: 6704 RVA: 0x0008950B File Offset: 0x0008770B
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "镜头特效";
	}

	// Token: 0x06001A31 RID: 6705 RVA: 0x00089512 File Offset: 0x00087712
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyCameraEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraEffect.TsAnimNotifyCameraEffect_C");
		}
		return TsAnimNotifyCameraEffect._ClassPtr;
	}

	// Token: 0x06001A32 RID: 6706 RVA: 0x00089538 File Offset: 0x00087738
	public TsAnimNotifyCameraEffect() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A33 RID: 6707 RVA: 0x00089560 File Offset: 0x00087760
	[NullableContext(1)]
	public TsAnimNotifyCameraEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A34 RID: 6708 RVA: 0x00089593 File Offset: 0x00087793
	protected TsAnimNotifyCameraEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A35 RID: 6709 RVA: 0x0008959C File Offset: 0x0008779C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A36 RID: 6710 RVA: 0x000895CF File Offset: 0x000877CF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400110A RID: 4362
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraEffect.TsAnimNotifyCameraEffect_C";

	// Token: 0x0400110B RID: 4363
	private static IntPtr _ClassPtr;

	// Token: 0x0400110C RID: 4364
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400110D RID: 4365
	private static int __PropertyOffset_EffectData;
}
