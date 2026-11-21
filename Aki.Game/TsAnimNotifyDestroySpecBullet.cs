using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B0 RID: 432
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDestroySpecBullet.TsAnimNotifyDestroySpecBullet_C")]
public class TsAnimNotifyDestroySpecBullet : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000483 RID: 1155
	// (get) Token: 0x06001BAC RID: 7084 RVA: 0x00092927 File Offset: 0x00090B27
	// (set) Token: 0x06001BAD RID: 7085 RVA: 0x0009293B File Offset: 0x00090B3B
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

	// Token: 0x17000484 RID: 1156
	// (get) Token: 0x06001BAE RID: 7086 RVA: 0x00092950 File Offset: 0x00090B50
	// (set) Token: 0x06001BAF RID: 7087 RVA: 0x00092960 File Offset: 0x00090B60
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

	// Token: 0x17000485 RID: 1157
	// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x00092971 File Offset: 0x00090B71
	// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x00092981 File Offset: 0x00090B81
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

	// Token: 0x17000486 RID: 1158
	// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x00092994 File Offset: 0x00090B94
	// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x000929CD File Offset: 0x00090BCD
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

	// Token: 0x06001BB4 RID: 7092 RVA: 0x000929F8 File Offset: 0x00090BF8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyDestroySpecBullet) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyDestroySpecBullet.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001BB5 RID: 7093 RVA: 0x00092AB0 File Offset: 0x00090CB0
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

	// Token: 0x06001BB6 RID: 7094 RVA: 0x00092BEC File Offset: 0x00090DEC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyDestroySpecBullet) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyDestroySpecBullet.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001BB7 RID: 7095 RVA: 0x00092C7C File Offset: 0x00090E7C
	protected override string GetNotifyName_Implementation()
	{
		return "销毁子弹";
	}

	// Token: 0x06001BB8 RID: 7096 RVA: 0x00092C83 File Offset: 0x00090E83
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyDestroySpecBullet._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDestroySpecBullet.TsAnimNotifyDestroySpecBullet_C");
		}
		return TsAnimNotifyDestroySpecBullet._ClassPtr;
	}

	// Token: 0x06001BB9 RID: 7097 RVA: 0x00092CA8 File Offset: 0x00090EA8
	public TsAnimNotifyDestroySpecBullet() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDestroySpecBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001BBA RID: 7098 RVA: 0x00092CD0 File Offset: 0x00090ED0
	public TsAnimNotifyDestroySpecBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDestroySpecBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001BBB RID: 7099 RVA: 0x00092D03 File Offset: 0x00090F03
	protected TsAnimNotifyDestroySpecBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001BBC RID: 7100 RVA: 0x00092D0C File Offset: 0x00090F0C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001BBD RID: 7101 RVA: 0x00092D3F File Offset: 0x00090F3F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011A7 RID: 4519
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyDestroySpecBullet.TsAnimNotifyDestroySpecBullet_C";

	// Token: 0x040011A8 RID: 4520
	private static IntPtr _ClassPtr;

	// Token: 0x040011A9 RID: 4521
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011AA RID: 4522
	private static int __PropertyOffset_bulletName;

	// Token: 0x040011AB RID: 4523
	private static int __PropertyOffset_是否召唤子子弹;

	// Token: 0x040011AC RID: 4524
	private static int __PropertyOffset_立即销毁子弹特效;

	// Token: 0x040011AD RID: 4525
	private static int __PropertyOffset_角色拥有标签执行判定;

	// Token: 0x040011AE RID: 4526
	[Nullable(2)]
	private FGameplayTagContainer _角色拥有标签执行判定;
}
