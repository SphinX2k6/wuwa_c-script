using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000198 RID: 408
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleMessageBox.TsAnimNotifyBattleMessageBox_C")]
public class TsAnimNotifyBattleMessageBox : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000451 RID: 1105
	// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0008E1F3 File Offset: 0x0008C3F3
	// (set) Token: 0x06001A5D RID: 6749 RVA: 0x0008E203 File Offset: 0x0008C403
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int BoardId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBattleMessageBox.__PropertyOffset_BoardId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBattleMessageBox.__PropertyOffset_BoardId) = value;
		}
	}

	// Token: 0x06001A5E RID: 6750 RVA: 0x0008E214 File Offset: 0x0008C414
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBattleMessageBox) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyBattleMessageBox.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001A5F RID: 6751 RVA: 0x0008E2CA File Offset: 0x0008C4CA
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.BoardId > 0)
		{
			SoundAreaPlayTipsController.Instance.OpenSoundAreaPlayTips(this.BoardId);
		}
		return true;
	}

	// Token: 0x06001A60 RID: 6752 RVA: 0x0008E2E8 File Offset: 0x0008C4E8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBattleMessageBox) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyBattleMessageBox.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001A61 RID: 6753 RVA: 0x0008E378 File Offset: 0x0008C578
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "战斗弹窗";
	}

	// Token: 0x06001A62 RID: 6754 RVA: 0x0008E37F File Offset: 0x0008C57F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBattleMessageBox._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleMessageBox.TsAnimNotifyBattleMessageBox_C");
		}
		return TsAnimNotifyBattleMessageBox._ClassPtr;
	}

	// Token: 0x06001A63 RID: 6755 RVA: 0x0008E3A4 File Offset: 0x0008C5A4
	public TsAnimNotifyBattleMessageBox() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBattleMessageBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A64 RID: 6756 RVA: 0x0008E3CC File Offset: 0x0008C5CC
	[NullableContext(1)]
	public TsAnimNotifyBattleMessageBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBattleMessageBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A65 RID: 6757 RVA: 0x0008E3FF File Offset: 0x0008C5FF
	protected TsAnimNotifyBattleMessageBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A66 RID: 6758 RVA: 0x0008E408 File Offset: 0x0008C608
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A67 RID: 6759 RVA: 0x0008E43B File Offset: 0x0008C63B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001125 RID: 4389
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleMessageBox.TsAnimNotifyBattleMessageBox_C";

	// Token: 0x04001126 RID: 4390
	private static IntPtr _ClassPtr;

	// Token: 0x04001127 RID: 4391
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001128 RID: 4392
	private static int __PropertyOffset_BoardId;
}
