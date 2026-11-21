using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D6 RID: 470
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleSitDown.TsAnimNotifyRoleSitDown_C")]
public class TsAnimNotifyRoleSitDown : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001DB8 RID: 7608 RVA: 0x0009A2E4 File Offset: 0x000984E4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyRoleSitDown) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyRoleSitDown.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001DB9 RID: 7609 RVA: 0x0009A39C File Offset: 0x0009859C
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActionComponent component = tsBaseCharacter.CharacterActorComponent.Entity.GetComponent<CharacterActionComponent>();
			if (component != null)
			{
				component.DoSitDownAction();
				return true;
			}
			NpcSitOnChairComponent component2 = tsBaseCharacter.CharacterActorComponent.Entity.GetComponent<NpcSitOnChairComponent>();
			if (((component2 != null) ? component2.CurrentChairEntity : null) != null)
			{
				component2.DoSitDownAction(component2.CurrentChairEntity);
			}
		}
		return true;
	}

	// Token: 0x06001DBA RID: 7610 RVA: 0x0009A400 File Offset: 0x00098600
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyRoleSitDown) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyRoleSitDown.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001DBB RID: 7611 RVA: 0x0009A490 File Offset: 0x00098690
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "角色坐下";
	}

	// Token: 0x06001DBC RID: 7612 RVA: 0x0009A497 File Offset: 0x00098697
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyRoleSitDown._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleSitDown.TsAnimNotifyRoleSitDown_C");
		}
		return TsAnimNotifyRoleSitDown._ClassPtr;
	}

	// Token: 0x06001DBD RID: 7613 RVA: 0x0009A4BC File Offset: 0x000986BC
	public TsAnimNotifyRoleSitDown() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRoleSitDown.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001DBE RID: 7614 RVA: 0x0009A4E4 File Offset: 0x000986E4
	[NullableContext(1)]
	public TsAnimNotifyRoleSitDown(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRoleSitDown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001DBF RID: 7615 RVA: 0x0009A517 File Offset: 0x00098717
	protected TsAnimNotifyRoleSitDown(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001DC0 RID: 7616 RVA: 0x0009A520 File Offset: 0x00098720
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x0009A553 File Offset: 0x00098753
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001272 RID: 4722
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRoleSitDown.TsAnimNotifyRoleSitDown_C";

	// Token: 0x04001273 RID: 4723
	private static IntPtr _ClassPtr;

	// Token: 0x04001274 RID: 4724
	private static IntPtr _ClassDefaultObjectPtr;
}
