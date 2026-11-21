using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001BD RID: 445
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFinishPokerPerformAction.TsAnimNotifyFinishPokerPerformAction_C")]
public class TsAnimNotifyFinishPokerPerformAction : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000496 RID: 1174
	// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00095127 File Offset: 0x00093327
	// (set) Token: 0x06001C55 RID: 7253 RVA: 0x00095137 File Offset: 0x00093337
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EPokerStateType PokerState
	{
		get
		{
			return (EPokerStateType)(*(base.NativePtr + (IntPtr)TsAnimNotifyFinishPokerPerformAction.__PropertyOffset_PokerState));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyFinishPokerPerformAction.__PropertyOffset_PokerState) = (byte)value;
		}
	}

	// Token: 0x06001C56 RID: 7254 RVA: 0x00095148 File Offset: 0x00093348
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyFinishPokerPerformAction) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyFinishPokerPerformAction.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001C57 RID: 7255 RVA: 0x000951FE File Offset: 0x000933FE
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		EventSystem.Instance.Emit<EPokerStateType>(EEventName.GuessJokerFinishPokerPerformAction, this.PokerState);
		return true;
	}

	// Token: 0x06001C58 RID: 7256 RVA: 0x00095218 File Offset: 0x00093418
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyFinishPokerPerformAction) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyFinishPokerPerformAction.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001C59 RID: 7257 RVA: 0x000952A8 File Offset: 0x000934A8
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "猜鬼牌完成动作动画通知";
	}

	// Token: 0x06001C5A RID: 7258 RVA: 0x000952AF File Offset: 0x000934AF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyFinishPokerPerformAction._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFinishPokerPerformAction.TsAnimNotifyFinishPokerPerformAction_C");
		}
		return TsAnimNotifyFinishPokerPerformAction._ClassPtr;
	}

	// Token: 0x06001C5B RID: 7259 RVA: 0x000952D4 File Offset: 0x000934D4
	public TsAnimNotifyFinishPokerPerformAction() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFinishPokerPerformAction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C5C RID: 7260 RVA: 0x000952FC File Offset: 0x000934FC
	[NullableContext(1)]
	public TsAnimNotifyFinishPokerPerformAction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFinishPokerPerformAction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C5D RID: 7261 RVA: 0x0009532F File Offset: 0x0009352F
	protected TsAnimNotifyFinishPokerPerformAction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C5E RID: 7262 RVA: 0x00095338 File Offset: 0x00093538
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C5F RID: 7263 RVA: 0x0009536B File Offset: 0x0009356B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011E8 RID: 4584
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFinishPokerPerformAction.TsAnimNotifyFinishPokerPerformAction_C";

	// Token: 0x040011E9 RID: 4585
	private static IntPtr _ClassPtr;

	// Token: 0x040011EA RID: 4586
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011EB RID: 4587
	private static int __PropertyOffset_PokerState;
}
