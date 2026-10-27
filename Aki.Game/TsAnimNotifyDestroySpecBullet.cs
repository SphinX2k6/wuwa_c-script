using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001AC RID: 428
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDestroySpecBullet.TsAnimNotifyDestroySpecBullet_C")]
public class TsAnimNotifyDestroySpecBullet : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000461 RID: 1121
	// (get) Token: 0x06001B0F RID: 6927 RVA: 0x0008C127 File Offset: 0x0008A327
	// (set) Token: 0x06001B10 RID: 6928 RVA: 0x0008C13B File Offset: 0x0008A33B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName bulletName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyDestroySpecBullet.__PropertyOffset_bulletName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyDestroySpecBullet.__PropertyOffset_bulletName) = value;
		}
	}

	// Token: 0x17000462 RID: 1122
	// (get) Token: 0x06001B11 RID: 6929 RVA: 0x0008C150 File Offset: 0x0008A350
	// (set) Token: 0x06001B12 RID: 6930 RVA: 0x0008C160 File Offset: 0x0008A360
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否召唤子子弹
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyDestroySpecBullet.__PropertyOffset_是否召唤子子弹) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyDestroySpecBullet.__PropertyOffset_是否召唤子子弹) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000463 RID: 1123
	// (get) Token: 0x06001B13 RID: 6931 RVA: 0x0008C171 File Offset: 0x0008A371
	// (set) Token: 0x06001B14 RID: 6932 RVA: 0x0008C181 File Offset: 0x0008A381
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 立即销毁子弹特效
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyDestroySpecBullet.__PropertyOffset_立即销毁子弹特效) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyDestroySpecBullet.__PropertyOffset_立即销毁子弹特效) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000464 RID: 1124
	// (get) Token: 0x06001B15 RID: 6933 RVA: 0x0008C194 File Offset: 0x0008A394
	// (set) Token: 0x06001B16 RID: 6934 RVA: 0x0008C1CD File Offset: 0x0008A3CD
	[UProperty(EPropertyFlags.CPF_None)]
	public FGameplayTagContainer 角色拥有标签执行判定
	{
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._角色拥有标签执行判定) == null)
			{
				result = (this._角色拥有标签执行判定 = new FGameplayTagContainer(base.NativePtr + (IntPtr)TsAnimNotifyDestroySpecBullet.__PropertyOffset_角色拥有标签执行判定, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyDestroySpecBullet.__PropertyOffset_角色拥有标签执行判定, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x06001B17 RID: 6935 RVA: 0x0008C1F8 File Offset: 0x0008A3F8
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

	// Token: 0x06001B18 RID: 6936 RVA: 0x0008C298 File Offset: 0x0008A498
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			if (this.角色拥有标签执行判定.GameplayTags.Num() > 0)
			{
				UBaseAbilitySystemComponent ubaseAbilitySystemComponent = tsBaseCharacter.GetComponentByClass(UBaseAbilitySystemComponent.StaticClass()) as UBaseAbilitySystemComponent;
				if (ubaseAbilitySystemComponent != null)
				{
					UBaseAbilitySystemComponent ubaseAbilitySystemComponent2 = ubaseAbilitySystemComponent;
					FGameplayTagContainer 角色拥有标签执行判定 = this.角色拥有标签执行判定;
					if (ubaseAbilitySystemComponent2.HasAnyGameplayTag(角色拥有标签执行判定))
					{
						goto IL_55;
					}
				}
				return false;
			}
			IL_55:
			IReadOnlyCollection<BulletEntity> bulletSetByAttacker = BulletModel.Instance.GetBulletSetByAttacker(tsBaseCharacter.EntityId);
			List<int> list = new List<int>();
			string text = this.bulletName.ToString();
			if (bulletSetByAttacker != null)
			{
				foreach (BulletEntity bulletEntity in bulletSetByAttacker)
				{
					string a = text;
					BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
					if (a == ((bulletInfo != null) ? bulletInfo.BulletDataMain.BulletName : null))
					{
						list.Add(bulletEntity.Id);
					}
				}
			}
			if (list.Count == 0)
			{
				return false;
			}
			for (int i = list.Count - 1; i >= 0; i--)
			{
				BulletController.Instance.DestroyBullet(list[i], this.是否召唤子子弹, EBulletDestroyReason.Normal, this.立即销毁子弹特效);
			}
		}
		return true;
	}

	// Token: 0x06001B19 RID: 6937 RVA: 0x0008C3D4 File Offset: 0x0008A5D4
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

	// Token: 0x06001B1A RID: 6938 RVA: 0x0008C44F File Offset: 0x0008A64F
	protected override string GetNotifyName_Implementation()
	{
		return "销毁子弹";
	}

	// Token: 0x06001B1B RID: 6939 RVA: 0x0008C456 File Offset: 0x0008A656
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyDestroySpecBullet._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDestroySpecBullet.TsAnimNotifyDestroySpecBullet_C");
		}
		return TsAnimNotifyDestroySpecBullet._ClassPtr;
	}

	// Token: 0x06001B1C RID: 6940 RVA: 0x0008C47C File Offset: 0x0008A67C
	public TsAnimNotifyDestroySpecBullet() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDestroySpecBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B1D RID: 6941 RVA: 0x0008C4A4 File Offset: 0x0008A6A4
	public TsAnimNotifyDestroySpecBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDestroySpecBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B1E RID: 6942 RVA: 0x0008C4D7 File Offset: 0x0008A6D7
	protected TsAnimNotifyDestroySpecBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B1F RID: 6943 RVA: 0x0008C4E0 File Offset: 0x0008A6E0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B20 RID: 6944 RVA: 0x0008C513 File Offset: 0x0008A713
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001164 RID: 4452
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDestroySpecBullet.TsAnimNotifyDestroySpecBullet_C";

	// Token: 0x04001165 RID: 4453
	private static IntPtr _ClassPtr;

	// Token: 0x04001166 RID: 4454
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001167 RID: 4455
	private static int __PropertyOffset_bulletName;

	// Token: 0x04001168 RID: 4456
	private static int __PropertyOffset_是否召唤子子弹;

	// Token: 0x04001169 RID: 4457
	private static int __PropertyOffset_立即销毁子弹特效;

	// Token: 0x0400116A RID: 4458
	private static int __PropertyOffset_角色拥有标签执行判定;

	// Token: 0x0400116B RID: 4459
	[Nullable(2)]
	private FGameplayTagContainer _角色拥有标签执行判定;
}
