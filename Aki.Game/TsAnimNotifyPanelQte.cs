using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001CA RID: 458
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyPanelQte.TsAnimNotifyPanelQte_C")]
public class TsAnimNotifyPanelQte : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004AC RID: 1196
	// (get) Token: 0x06001CFE RID: 7422 RVA: 0x000977F3 File Offset: 0x000959F3
	// (set) Token: 0x06001CFF RID: 7423 RVA: 0x00097803 File Offset: 0x00095A03
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int QteId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyPanelQte.__PropertyOffset_QteId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyPanelQte.__PropertyOffset_QteId) = value;
		}
	}

	// Token: 0x170004AD RID: 1197
	// (get) Token: 0x06001D00 RID: 7424 RVA: 0x00097814 File Offset: 0x00095A14
	// (set) Token: 0x06001D01 RID: 7425 RVA: 0x00097824 File Offset: 0x00095A24
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CheckAutonomousProxy
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyPanelQte.__PropertyOffset_CheckAutonomousProxy) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyPanelQte.__PropertyOffset_CheckAutonomousProxy) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001D02 RID: 7426 RVA: 0x00097838 File Offset: 0x00095A38
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyPanelQte) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyPanelQte.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001D03 RID: 7427 RVA: 0x000978F0 File Offset: 0x00095AF0
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		long? preMessageId = null;
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		if (this.CheckAutonomousProxy)
		{
			CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
			if (characterActorComponent == null || !characterActorComponent.Valid)
			{
				return false;
			}
			if (!characterActorComponent.IsAutonomousProxy)
			{
				return false;
			}
		}
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		object obj;
		if (tsBaseCharacter == null)
		{
			obj = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent2 = tsBaseCharacter.CharacterActorComponent;
			obj = ((characterActorComponent2 != null) ? characterActorComponent2.Entity : null);
		}
		object obj2 = obj;
		preMessageId = ((obj2 != null) ? obj2.GetComponent<BaseBuffComponent>().CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null);
		PanelQteController.Instance.StartAnimNotifyQte(this.QteId, meshComp, preMessageId);
		return true;
	}

	// Token: 0x06001D04 RID: 7428 RVA: 0x000979A0 File Offset: 0x00095BA0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyPanelQte) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyPanelQte.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001D05 RID: 7429 RVA: 0x00097A30 File Offset: 0x00095C30
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "通用QTE";
	}

	// Token: 0x06001D06 RID: 7430 RVA: 0x00097A37 File Offset: 0x00095C37
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyPanelQte._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyPanelQte.TsAnimNotifyPanelQte_C");
		}
		return TsAnimNotifyPanelQte._ClassPtr;
	}

	// Token: 0x06001D07 RID: 7431 RVA: 0x00097A5C File Offset: 0x00095C5C
	public TsAnimNotifyPanelQte() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyPanelQte.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D08 RID: 7432 RVA: 0x00097A84 File Offset: 0x00095C84
	[NullableContext(1)]
	public TsAnimNotifyPanelQte(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyPanelQte.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D09 RID: 7433 RVA: 0x00097AB7 File Offset: 0x00095CB7
	protected TsAnimNotifyPanelQte(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D0A RID: 7434 RVA: 0x00097AC0 File Offset: 0x00095CC0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D0B RID: 7435 RVA: 0x00097AF3 File Offset: 0x00095CF3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001225 RID: 4645
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyPanelQte.TsAnimNotifyPanelQte_C";

	// Token: 0x04001226 RID: 4646
	private static IntPtr _ClassPtr;

	// Token: 0x04001227 RID: 4647
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001228 RID: 4648
	private static int __PropertyOffset_QteId;

	// Token: 0x04001229 RID: 4649
	private static int __PropertyOffset_CheckAutonomousProxy;
}
