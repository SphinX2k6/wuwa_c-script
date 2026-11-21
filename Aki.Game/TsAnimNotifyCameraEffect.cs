using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A0 RID: 416
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraEffect.TsAnimNotifyCameraEffect_C")]
public class TsAnimNotifyCameraEffect : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700045F RID: 1119
	// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x0008F93F File Offset: 0x0008DB3F
	// (set) Token: 0x06001AC9 RID: 6857 RVA: 0x0008F953 File Offset: 0x0008DB53
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

	// Token: 0x06001ACA RID: 6858 RVA: 0x0008F968 File Offset: 0x0008DB68
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyCameraEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyCameraEffect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001ACB RID: 6859 RVA: 0x0008FA1E File Offset: 0x0008DC1E
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.EffectData != null)
		{
			ScreenEffectSystem.GetInstance().PlayScreenEffect(this.EffectData);
		}
		return true;
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x0008FA3C File Offset: 0x0008DC3C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyCameraEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyCameraEffect.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001ACD RID: 6861 RVA: 0x0008FACC File Offset: 0x0008DCCC
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "镜头特效";
	}

	// Token: 0x06001ACE RID: 6862 RVA: 0x0008FAD3 File Offset: 0x0008DCD3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyCameraEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraEffect.TsAnimNotifyCameraEffect_C");
		}
		return TsAnimNotifyCameraEffect._ClassPtr;
	}

	// Token: 0x06001ACF RID: 6863 RVA: 0x0008FAF8 File Offset: 0x0008DCF8
	public TsAnimNotifyCameraEffect() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001AD0 RID: 6864 RVA: 0x0008FB20 File Offset: 0x0008DD20
	[NullableContext(1)]
	public TsAnimNotifyCameraEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001AD1 RID: 6865 RVA: 0x0008FB53 File Offset: 0x0008DD53
	protected TsAnimNotifyCameraEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001AD2 RID: 6866 RVA: 0x0008FB5C File Offset: 0x0008DD5C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001AD3 RID: 6867 RVA: 0x0008FB8F File Offset: 0x0008DD8F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400114D RID: 4429
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraEffect.TsAnimNotifyCameraEffect_C";

	// Token: 0x0400114E RID: 4430
	private static IntPtr _ClassPtr;

	// Token: 0x0400114F RID: 4431
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001150 RID: 4432
	private static int __PropertyOffset_EffectData;
}
