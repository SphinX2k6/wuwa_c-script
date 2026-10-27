using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000185 RID: 389
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVisionCounterAttack.TsAnimNotifyStateVisionCounterAttack_C")]
public class TsAnimNotifyStateVisionCounterAttack : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003FF RID: 1023
	// (get) Token: 0x060018AD RID: 6317 RVA: 0x000835D0 File Offset: 0x000817D0
	// (set) Token: 0x060018AE RID: 6318 RVA: 0x00083609 File Offset: 0x00081809
	[UProperty(EPropertyFlags.CPF_None)]
	public SVisionCounterAttack 对策设置
	{
		get
		{
			base.FastCheckIsValid();
			SVisionCounterAttack result;
			if ((result = this._对策设置) == null)
			{
				result = (this._对策设置 = new SVisionCounterAttack(base.NativePtr + (IntPtr)TsAnimNotifyStateVisionCounterAttack.__PropertyOffset_对策设置, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SVisionCounterAttack.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateVisionCounterAttack.__PropertyOffset_对策设置, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x060018AF RID: 6319 RVA: 0x00083634 File Offset: 0x00081834
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

	// Token: 0x060018B0 RID: 6320 RVA: 0x000836DC File Offset: 0x000818DC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null || !entity.Valid)
		{
			return false;
		}
		BaseBuffComponent component = entity.GetComponent<BaseBuffComponent>();
		long? anMessageId = (component != null) ? component.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null;
		CharacterHitComponent component2 = entity.GetComponent<CharacterHitComponent>();
		if (component2 != null)
		{
			component2.SetCounterAttackAnsInfo(anMessageId, base.exportIndex);
		}
		if (component2 != null)
		{
			component2.SetVisionCounterAttackInfo(this.对策设置);
		}
		if (component2 != null)
		{
			component2.SetCounterAttackEndTime(totalDuration);
		}
		return true;
	}

	// Token: 0x060018B1 RID: 6321 RVA: 0x00083788 File Offset: 0x00081988
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

	// Token: 0x060018B2 RID: 6322 RVA: 0x00083828 File Offset: 0x00081A28
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null || !entity.Valid)
		{
			return false;
		}
		CharacterHitComponent component = entity.GetComponent<CharacterHitComponent>();
		if (component != null)
		{
			component.VisionCounterAttackEnd();
		}
		return true;
	}

	// Token: 0x060018B3 RID: 6323 RVA: 0x00083884 File Offset: 0x00081A84
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

	// Token: 0x060018B4 RID: 6324 RVA: 0x000838FF File Offset: 0x00081AFF
	protected override string GetNotifyName_Implementation()
	{
		return "幻象弹反";
	}

	// Token: 0x060018B5 RID: 6325 RVA: 0x00083906 File Offset: 0x00081B06
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateVisionCounterAttack._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVisionCounterAttack.TsAnimNotifyStateVisionCounterAttack_C");
		}
		return TsAnimNotifyStateVisionCounterAttack._ClassPtr;
	}

	// Token: 0x060018B6 RID: 6326 RVA: 0x0008392C File Offset: 0x00081B2C
	public TsAnimNotifyStateVisionCounterAttack() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVisionCounterAttack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060018B7 RID: 6327 RVA: 0x00083954 File Offset: 0x00081B54
	public TsAnimNotifyStateVisionCounterAttack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVisionCounterAttack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060018B8 RID: 6328 RVA: 0x00083987 File Offset: 0x00081B87
	protected TsAnimNotifyStateVisionCounterAttack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060018B9 RID: 6329 RVA: 0x00083990 File Offset: 0x00081B90
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060018BA RID: 6330 RVA: 0x000839CC File Offset: 0x00081BCC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060018BB RID: 6331 RVA: 0x000839FF File Offset: 0x00081BFF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400106C RID: 4204
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVisionCounterAttack.TsAnimNotifyStateVisionCounterAttack_C";

	// Token: 0x0400106D RID: 4205
	private static IntPtr _ClassPtr;

	// Token: 0x0400106E RID: 4206
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400106F RID: 4207
	private static int __PropertyOffset_对策设置;

	// Token: 0x04001070 RID: 4208
	[Nullable(2)]
	private SVisionCounterAttack _对策设置;
}
