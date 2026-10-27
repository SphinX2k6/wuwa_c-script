using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000170 RID: 368
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiWeapon.TsAnimNotifyStateShowUiWeapon_C")]
public class TsAnimNotifyStateShowUiWeapon : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003CA RID: 970
	// (get) Token: 0x06001738 RID: 5944 RVA: 0x0007D642 File Offset: 0x0007B842
	// (set) Token: 0x06001739 RID: 5945 RVA: 0x0007D652 File Offset: 0x0007B852
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

	// Token: 0x170003CB RID: 971
	// (get) Token: 0x0600173A RID: 5946 RVA: 0x0007D663 File Offset: 0x0007B863
	// (set) Token: 0x0600173B RID: 5947 RVA: 0x0007D673 File Offset: 0x0007B873
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

	// Token: 0x170003CC RID: 972
	// (get) Token: 0x0600173C RID: 5948 RVA: 0x0007D684 File Offset: 0x0007B884
	// (set) Token: 0x0600173D RID: 5949 RVA: 0x0007D694 File Offset: 0x0007B894
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

	// Token: 0x170003CD RID: 973
	// (get) Token: 0x0600173E RID: 5950 RVA: 0x0007D6A5 File Offset: 0x0007B8A5
	// (set) Token: 0x0600173F RID: 5951 RVA: 0x0007D6B9 File Offset: 0x0007B8B9
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

	// Token: 0x170003CE RID: 974
	// (get) Token: 0x06001740 RID: 5952 RVA: 0x0007D6CE File Offset: 0x0007B8CE
	// (set) Token: 0x06001741 RID: 5953 RVA: 0x0007D6E2 File Offset: 0x0007B8E2
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

	// Token: 0x06001742 RID: 5954 RVA: 0x0007D6F8 File Offset: 0x0007B8F8
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

	// Token: 0x06001743 RID: 5955 RVA: 0x0007D7A0 File Offset: 0x0007B9A0
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
					model.CheckGetComponent<UiModelAnsControllerComponent>().AddAns<UiWeaponAnsContext>("UiWeaponAnsContext", value);
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

	// Token: 0x06001744 RID: 5956 RVA: 0x0007D848 File Offset: 0x0007BA48
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

	// Token: 0x06001745 RID: 5957 RVA: 0x0007D8E8 File Offset: 0x0007BAE8
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
					model.CheckGetComponent<UiModelAnsControllerComponent>().ReduceAns<UiWeaponAnsContext>("UiWeaponAnsContext", value);
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

	// Token: 0x06001746 RID: 5958 RVA: 0x0007D990 File Offset: 0x0007BB90
	[NullableContext(1)]
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

	// Token: 0x06001747 RID: 5959 RVA: 0x0007DA0B File Offset: 0x0007BC0B
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "Ui界面武器显示";
	}

	// Token: 0x06001748 RID: 5960 RVA: 0x0007DA12 File Offset: 0x0007BC12
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateShowUiWeapon._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiWeapon.TsAnimNotifyStateShowUiWeapon_C");
		}
		return TsAnimNotifyStateShowUiWeapon._ClassPtr;
	}

	// Token: 0x06001749 RID: 5961 RVA: 0x0007DA38 File Offset: 0x0007BC38
	public TsAnimNotifyStateShowUiWeapon() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateShowUiWeapon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x0007DA60 File Offset: 0x0007BC60
	[NullableContext(1)]
	public TsAnimNotifyStateShowUiWeapon(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateShowUiWeapon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600174B RID: 5963 RVA: 0x0007DA93 File Offset: 0x0007BC93
	protected TsAnimNotifyStateShowUiWeapon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600174C RID: 5964 RVA: 0x0007DA9C File Offset: 0x0007BC9C
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600174D RID: 5965 RVA: 0x0007DAD8 File Offset: 0x0007BCD8
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600174E RID: 5966 RVA: 0x0007DB0B File Offset: 0x0007BD0B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FD7 RID: 4055
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateShowUiWeapon.TsAnimNotifyStateShowUiWeapon_C";

	// Token: 0x04000FD8 RID: 4056
	private static IntPtr _ClassPtr;

	// Token: 0x04000FD9 RID: 4057
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FDA RID: 4058
	private static int __PropertyOffset_WeaponIndex;

	// Token: 0x04000FDB RID: 4059
	private static int __PropertyOffset_ShowMaterialController;

	// Token: 0x04000FDC RID: 4060
	private static int __PropertyOffset_HideEffect;

	// Token: 0x04000FDD RID: 4061
	private static int __PropertyOffset_Transform;

	// Token: 0x04000FDE RID: 4062
	private static int __PropertyOffset_HangSocketName;
}
