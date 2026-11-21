using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000174 RID: 372
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiWeapon.TsAnimNotifyStateShowUiWeapon_C")]
public class TsAnimNotifyStateShowUiWeapon : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003EC RID: 1004
	// (get) Token: 0x060017D5 RID: 6101 RVA: 0x0008327C File Offset: 0x0008147C
	// (set) Token: 0x060017D6 RID: 6102 RVA: 0x0008328C File Offset: 0x0008148C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int WeaponIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiWeapon.__PropertyOffset_WeaponIndex);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiWeapon.__PropertyOffset_WeaponIndex) = value;
		}
	}

	// Token: 0x170003ED RID: 1005
	// (get) Token: 0x060017D7 RID: 6103 RVA: 0x0008329D File Offset: 0x0008149D
	// (set) Token: 0x060017D8 RID: 6104 RVA: 0x000832AD File Offset: 0x000814AD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ShowMaterialController
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiWeapon.__PropertyOffset_ShowMaterialController) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiWeapon.__PropertyOffset_ShowMaterialController) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003EE RID: 1006
	// (get) Token: 0x060017D9 RID: 6105 RVA: 0x000832BE File Offset: 0x000814BE
	// (set) Token: 0x060017DA RID: 6106 RVA: 0x000832CE File Offset: 0x000814CE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool HideEffect
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiWeapon.__PropertyOffset_HideEffect) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiWeapon.__PropertyOffset_HideEffect) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003EF RID: 1007
	// (get) Token: 0x060017DB RID: 6107 RVA: 0x000832DF File Offset: 0x000814DF
	// (set) Token: 0x060017DC RID: 6108 RVA: 0x000832F3 File Offset: 0x000814F3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FTransform Transform
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiWeapon.__PropertyOffset_Transform);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiWeapon.__PropertyOffset_Transform) = value;
		}
	}

	// Token: 0x170003F0 RID: 1008
	// (get) Token: 0x060017DD RID: 6109 RVA: 0x00083308 File Offset: 0x00081508
	// (set) Token: 0x060017DE RID: 6110 RVA: 0x0008331C File Offset: 0x0008151C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName HangSocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiWeapon.__PropertyOffset_HangSocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateShowUiWeapon.__PropertyOffset_HangSocketName) = value;
		}
	}

	// Token: 0x060017DF RID: 6111 RVA: 0x00083334 File Offset: 0x00081534
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateShowUiWeapon) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateShowUiWeapon.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060017E0 RID: 6112 RVA: 0x000833F4 File Offset: 0x000815F4
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsUiSceneRoleActor)
		{
			if (this.WeaponIndex >= 0)
			{
				UiWeaponAnsContext value = new UiWeaponAnsContext(this.WeaponIndex, this.ShowMaterialController, this.HideEffect, new FTransform?(this.Transform), this.HangSocketName);
				UiModelBase model = (owner as TsUiSceneRoleActor).Model;
				if (model != null)
				{
					model.CheckGetComponent<UiModelAnsControllerComponent>().AddAns(value);
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "UI武器显隐配置的索引不合法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", this.WeaponIndex);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		return false;
	}

	// Token: 0x060017E1 RID: 6113 RVA: 0x00083498 File Offset: 0x00081698
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateShowUiWeapon) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateShowUiWeapon.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060017E2 RID: 6114 RVA: 0x00083550 File Offset: 0x00081750
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsUiSceneRoleActor)
		{
			if (this.WeaponIndex >= 0)
			{
				UiWeaponAnsContext value = new UiWeaponAnsContext(this.WeaponIndex, this.ShowMaterialController, this.HideEffect, new FTransform?(this.Transform), this.HangSocketName);
				UiModelBase model = (owner as TsUiSceneRoleActor).Model;
				if (model != null)
				{
					model.CheckGetComponent<UiModelAnsControllerComponent>().ReduceAns(value);
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "UI武器显隐配置的索引不合法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", this.WeaponIndex);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
		return false;
	}

	// Token: 0x060017E3 RID: 6115 RVA: 0x000835F4 File Offset: 0x000817F4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateShowUiWeapon) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateShowUiWeapon.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x060017E4 RID: 6116 RVA: 0x00083684 File Offset: 0x00081884
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "Ui界面武器显示";
	}

	// Token: 0x060017E5 RID: 6117 RVA: 0x0008368B File Offset: 0x0008188B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateShowUiWeapon._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiWeapon.TsAnimNotifyStateShowUiWeapon_C");
		}
		return TsAnimNotifyStateShowUiWeapon._ClassPtr;
	}

	// Token: 0x060017E6 RID: 6118 RVA: 0x000836B0 File Offset: 0x000818B0
	public TsAnimNotifyStateShowUiWeapon() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateShowUiWeapon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060017E7 RID: 6119 RVA: 0x000836D8 File Offset: 0x000818D8
	[NullableContext(1)]
	public TsAnimNotifyStateShowUiWeapon(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateShowUiWeapon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060017E8 RID: 6120 RVA: 0x0008370B File Offset: 0x0008190B
	protected TsAnimNotifyStateShowUiWeapon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060017E9 RID: 6121 RVA: 0x00083714 File Offset: 0x00081914
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060017EA RID: 6122 RVA: 0x00083750 File Offset: 0x00081950
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060017EB RID: 6123 RVA: 0x00083783 File Offset: 0x00081983
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400101A RID: 4122
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiWeapon.TsAnimNotifyStateShowUiWeapon_C";

	// Token: 0x0400101B RID: 4123
	private static IntPtr _ClassPtr;

	// Token: 0x0400101C RID: 4124
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400101D RID: 4125
	private static int __PropertyOffset_WeaponIndex;

	// Token: 0x0400101E RID: 4126
	private static int __PropertyOffset_ShowMaterialController;

	// Token: 0x0400101F RID: 4127
	private static int __PropertyOffset_HideEffect;

	// Token: 0x04001020 RID: 4128
	private static int __PropertyOffset_Transform;

	// Token: 0x04001021 RID: 4129
	private static int __PropertyOffset_HangSocketName;
}
