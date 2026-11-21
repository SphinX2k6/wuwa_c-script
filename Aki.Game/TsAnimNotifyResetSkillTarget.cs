using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D1 RID: 465
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetSkillTarget.TsAnimNotifyResetSkillTarget_C")]
public class TsAnimNotifyResetSkillTarget : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004BB RID: 1211
	// (get) Token: 0x06001D61 RID: 7521 RVA: 0x00098D08 File Offset: 0x00096F08
	// (set) Token: 0x06001D62 RID: 7522 RVA: 0x00098D41 File Offset: 0x00096F41
	[UProperty(EPropertyFlags.CPF_None)]
	public SSkillTarget 技能目标配置
	{
		get
		{
			base.FastCheckIsValid();
			SSkillTarget result;
			if ((result = this._技能目标配置) == null)
			{
				result = (this._技能目标配置 = new SSkillTarget(base.NativePtr + (IntPtr)TsAnimNotifyResetSkillTarget.__PropertyOffset_技能目标配置, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SSkillTarget.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyResetSkillTarget.__PropertyOffset_技能目标配置, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x06001D63 RID: 7523 RVA: 0x00098D6C File Offset: 0x00096F6C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyResetSkillTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyResetSkillTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001D64 RID: 7524 RVA: 0x00098E24 File Offset: 0x00097024
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterSkillComponent component = (owner as TsBaseCharacter).CharacterActorComponent.Entity.GetComponent<CharacterSkillComponent>();
		if (component == null)
		{
			return false;
		}
		component.LockOnTargetAndSetShow(this.技能目标配置, true);
		return true;
	}

	// Token: 0x06001D65 RID: 7525 RVA: 0x00098E6C File Offset: 0x0009706C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyResetSkillTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyResetSkillTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001D66 RID: 7526 RVA: 0x00098EFC File Offset: 0x000970FC
	protected override string GetNotifyName_Implementation()
	{
		return "重置技能目标";
	}

	// Token: 0x06001D67 RID: 7527 RVA: 0x00098F03 File Offset: 0x00097103
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyResetSkillTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetSkillTarget.TsAnimNotifyResetSkillTarget_C");
		}
		return TsAnimNotifyResetSkillTarget._ClassPtr;
	}

	// Token: 0x06001D68 RID: 7528 RVA: 0x00098F28 File Offset: 0x00097128
	public TsAnimNotifyResetSkillTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyResetSkillTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D69 RID: 7529 RVA: 0x00098F50 File Offset: 0x00097150
	public TsAnimNotifyResetSkillTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyResetSkillTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D6A RID: 7530 RVA: 0x00098F83 File Offset: 0x00097183
	protected TsAnimNotifyResetSkillTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D6B RID: 7531 RVA: 0x00098F8C File Offset: 0x0009718C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D6C RID: 7532 RVA: 0x00098FBF File Offset: 0x000971BF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001249 RID: 4681
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetSkillTarget.TsAnimNotifyResetSkillTarget_C";

	// Token: 0x0400124A RID: 4682
	private static IntPtr _ClassPtr;

	// Token: 0x0400124B RID: 4683
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400124C RID: 4684
	private static int __PropertyOffset_技能目标配置;

	// Token: 0x0400124D RID: 4685
	[Nullable(2)]
	private SSkillTarget _技能目标配置;
}
