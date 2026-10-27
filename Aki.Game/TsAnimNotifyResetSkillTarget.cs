using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001CD RID: 461
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetSkillTarget.TsAnimNotifyResetSkillTarget_C")]
public class TsAnimNotifyResetSkillTarget : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000499 RID: 1177
	// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x0009200C File Offset: 0x0009020C
	// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x00092045 File Offset: 0x00090245
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

	// Token: 0x06001CC6 RID: 7366 RVA: 0x00092070 File Offset: 0x00090270
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

	// Token: 0x06001CC7 RID: 7367 RVA: 0x00092110 File Offset: 0x00090310
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

	// Token: 0x06001CC8 RID: 7368 RVA: 0x00092158 File Offset: 0x00090358
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

	// Token: 0x06001CC9 RID: 7369 RVA: 0x000921D3 File Offset: 0x000903D3
	protected override string GetNotifyName_Implementation()
	{
		return "重置技能目标";
	}

	// Token: 0x06001CCA RID: 7370 RVA: 0x000921DA File Offset: 0x000903DA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyResetSkillTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetSkillTarget.TsAnimNotifyResetSkillTarget_C");
		}
		return TsAnimNotifyResetSkillTarget._ClassPtr;
	}

	// Token: 0x06001CCB RID: 7371 RVA: 0x00092200 File Offset: 0x00090400
	public TsAnimNotifyResetSkillTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyResetSkillTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001CCC RID: 7372 RVA: 0x00092228 File Offset: 0x00090428
	public TsAnimNotifyResetSkillTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyResetSkillTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001CCD RID: 7373 RVA: 0x0009225B File Offset: 0x0009045B
	protected TsAnimNotifyResetSkillTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001CCE RID: 7374 RVA: 0x00092264 File Offset: 0x00090464
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001CCF RID: 7375 RVA: 0x00092297 File Offset: 0x00090497
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001206 RID: 4614
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyResetSkillTarget.TsAnimNotifyResetSkillTarget_C";

	// Token: 0x04001207 RID: 4615
	private static IntPtr _ClassPtr;

	// Token: 0x04001208 RID: 4616
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001209 RID: 4617
	private static int __PropertyOffset_技能目标配置;

	// Token: 0x0400120A RID: 4618
	[Nullable(2)]
	private SSkillTarget _技能目标配置;
}
