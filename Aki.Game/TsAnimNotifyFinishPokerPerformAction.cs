using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B9 RID: 441
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFinishPokerPerformAction.TsAnimNotifyFinishPokerPerformAction_C")]
public class TsAnimNotifyFinishPokerPerformAction : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000474 RID: 1140
	// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x0008E743 File Offset: 0x0008C943
	// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x0008E753 File Offset: 0x0008C953
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

	// Token: 0x06001BB9 RID: 7097 RVA: 0x0008E764 File Offset: 0x0008C964
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

	// Token: 0x06001BBA RID: 7098 RVA: 0x0008E803 File Offset: 0x0008CA03
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		EventSystem.Instance.Emit<EPokerStateType>(EEventName.GuessJokerFinishPokerPerformAction, this.PokerState);
		return true;
	}

	// Token: 0x06001BBB RID: 7099 RVA: 0x0008E81C File Offset: 0x0008CA1C
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

	// Token: 0x06001BBC RID: 7100 RVA: 0x0008E897 File Offset: 0x0008CA97
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "猜鬼牌完成动作动画通知";
	}

	// Token: 0x06001BBD RID: 7101 RVA: 0x0008E89E File Offset: 0x0008CA9E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyFinishPokerPerformAction._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFinishPokerPerformAction.TsAnimNotifyFinishPokerPerformAction_C");
		}
		return TsAnimNotifyFinishPokerPerformAction._ClassPtr;
	}

	// Token: 0x06001BBE RID: 7102 RVA: 0x0008E8C4 File Offset: 0x0008CAC4
	public TsAnimNotifyFinishPokerPerformAction() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFinishPokerPerformAction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x0008E8EC File Offset: 0x0008CAEC
	[NullableContext(1)]
	public TsAnimNotifyFinishPokerPerformAction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFinishPokerPerformAction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x0008E91F File Offset: 0x0008CB1F
	protected TsAnimNotifyFinishPokerPerformAction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x0008E928 File Offset: 0x0008CB28
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x0008E95B File Offset: 0x0008CB5B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011A5 RID: 4517
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFinishPokerPerformAction.TsAnimNotifyFinishPokerPerformAction_C";

	// Token: 0x040011A6 RID: 4518
	private static IntPtr _ClassPtr;

	// Token: 0x040011A7 RID: 4519
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011A8 RID: 4520
	private static int __PropertyOffset_PokerState;
}
