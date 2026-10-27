using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C6 RID: 454
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyPanelQte.TsAnimNotifyPanelQte_C")]
public class TsAnimNotifyPanelQte : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700048A RID: 1162
	// (get) Token: 0x06001C61 RID: 7265 RVA: 0x00090BFF File Offset: 0x0008EDFF
	// (set) Token: 0x06001C62 RID: 7266 RVA: 0x00090C0F File Offset: 0x0008EE0F
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

	// Token: 0x1700048B RID: 1163
	// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00090C20 File Offset: 0x0008EE20
	// (set) Token: 0x06001C64 RID: 7268 RVA: 0x00090C30 File Offset: 0x0008EE30
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

	// Token: 0x06001C65 RID: 7269 RVA: 0x00090C44 File Offset: 0x0008EE44
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

	// Token: 0x06001C66 RID: 7270 RVA: 0x00090CE4 File Offset: 0x0008EEE4
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

	// Token: 0x06001C67 RID: 7271 RVA: 0x00090D94 File Offset: 0x0008EF94
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

	// Token: 0x06001C68 RID: 7272 RVA: 0x00090E0F File Offset: 0x0008F00F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "通用QTE";
	}

	// Token: 0x06001C69 RID: 7273 RVA: 0x00090E16 File Offset: 0x0008F016
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyPanelQte._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyPanelQte.TsAnimNotifyPanelQte_C");
		}
		return TsAnimNotifyPanelQte._ClassPtr;
	}

	// Token: 0x06001C6A RID: 7274 RVA: 0x00090E3C File Offset: 0x0008F03C
	public TsAnimNotifyPanelQte() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyPanelQte.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C6B RID: 7275 RVA: 0x00090E64 File Offset: 0x0008F064
	[NullableContext(1)]
	public TsAnimNotifyPanelQte(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyPanelQte.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C6C RID: 7276 RVA: 0x00090E97 File Offset: 0x0008F097
	protected TsAnimNotifyPanelQte(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C6D RID: 7277 RVA: 0x00090EA0 File Offset: 0x0008F0A0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C6E RID: 7278 RVA: 0x00090ED3 File Offset: 0x0008F0D3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011E2 RID: 4578
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyPanelQte.TsAnimNotifyPanelQte_C";

	// Token: 0x040011E3 RID: 4579
	private static IntPtr _ClassPtr;

	// Token: 0x040011E4 RID: 4580
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011E5 RID: 4581
	private static int __PropertyOffset_QteId;

	// Token: 0x040011E6 RID: 4582
	private static int __PropertyOffset_CheckAutonomousProxy;
}
