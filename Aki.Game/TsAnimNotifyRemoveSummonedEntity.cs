using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001CE RID: 462
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRemoveSummonedEntity.TsAnimNotifyRemoveSummonedEntity_C")]
public class TsAnimNotifyRemoveSummonedEntity : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004B5 RID: 1205
	// (get) Token: 0x06001D36 RID: 7478 RVA: 0x0009839F File Offset: 0x0009659F
	// (set) Token: 0x06001D37 RID: 7479 RVA: 0x000983AF File Offset: 0x000965AF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int 技能ID
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyRemoveSummonedEntity.__PropertyOffset_技能ID);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyRemoveSummonedEntity.__PropertyOffset_技能ID) = value;
		}
	}

	// Token: 0x170004B6 RID: 1206
	// (get) Token: 0x06001D38 RID: 7480 RVA: 0x000983C0 File Offset: 0x000965C0
	// (set) Token: 0x06001D39 RID: 7481 RVA: 0x000983D0 File Offset: 0x000965D0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否用当前Montage对应的技能ID
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyRemoveSummonedEntity.__PropertyOffset_是否用当前Montage对应的技能ID) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyRemoveSummonedEntity.__PropertyOffset_是否用当前Montage对应的技能ID) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004B7 RID: 1207
	// (get) Token: 0x06001D3A RID: 7482 RVA: 0x000983E1 File Offset: 0x000965E1
	// (set) Token: 0x06001D3B RID: 7483 RVA: 0x000983F1 File Offset: 0x000965F1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int 召唤者实体ID
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyRemoveSummonedEntity.__PropertyOffset_召唤者实体ID);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyRemoveSummonedEntity.__PropertyOffset_召唤者实体ID) = value;
		}
	}

	// Token: 0x170004B8 RID: 1208
	// (get) Token: 0x06001D3C RID: 7484 RVA: 0x00098402 File Offset: 0x00096602
	// (set) Token: 0x06001D3D RID: 7485 RVA: 0x00098412 File Offset: 0x00096612
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否把当前播放动画的角色实体作为召唤者
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyRemoveSummonedEntity.__PropertyOffset_是否把当前播放动画的角色实体作为召唤者) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyRemoveSummonedEntity.__PropertyOffset_是否把当前播放动画的角色实体作为召唤者) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004B9 RID: 1209
	// (get) Token: 0x06001D3E RID: 7486 RVA: 0x00098423 File Offset: 0x00096623
	// (set) Token: 0x06001D3F RID: 7487 RVA: 0x00098433 File Offset: 0x00096633
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int 要删除的实体ID
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyRemoveSummonedEntity.__PropertyOffset_要删除的实体ID);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyRemoveSummonedEntity.__PropertyOffset_要删除的实体ID) = value;
		}
	}

	// Token: 0x170004BA RID: 1210
	// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00098444 File Offset: 0x00096644
	// (set) Token: 0x06001D41 RID: 7489 RVA: 0x00098454 File Offset: 0x00096654
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 删除所有召唤者通过SkillId生成的实体
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyRemoveSummonedEntity.__PropertyOffset_删除所有召唤者通过SkillId生成的实体) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyRemoveSummonedEntity.__PropertyOffset_删除所有召唤者通过SkillId生成的实体) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x00098468 File Offset: 0x00096668
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyRemoveSummonedEntity) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyRemoveSummonedEntity.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001D43 RID: 7491 RVA: 0x00098520 File Offset: 0x00096720
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		int skillId = this.技能ID;
		int num = this.召唤者实体ID;
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity != null && entity.Valid)
			{
				if (this.是否把当前播放动画的角色实体作为召唤者)
				{
					num = entity.Id;
				}
				if (this.是否用当前Montage对应的技能ID)
				{
					CharacterSkillComponent characterSkillComponent = entity.CheckGetComponent<CharacterSkillComponent>();
					if (characterSkillComponent != null)
					{
						skillId = characterSkillComponent.GetCurrentMontageCorrespondingSkillId();
					}
				}
			}
		}
		if (CreatureModel.Instance.GetServerEntityId(num) == 0L)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler.AppendLiteral("不存在召唤者实体");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			this.LogInternal(defaultInterpolatedStringHandler.ToStringAndClear());
			return false;
		}
		IReadOnlyList<int> readOnlyList;
		if (this.删除所有召唤者通过SkillId生成的实体)
		{
			readOnlyList = BulletModel.Instance.GetSummonEntityIds(num);
		}
		else
		{
			readOnlyList = new <>z__ReadOnlySingleElementList<int>(this.要删除的实体ID);
		}
		foreach (int num2 in readOnlyList)
		{
			if (CreatureModel.Instance.GetServerEntityId(num2) == 0L)
			{
				this.LogInternal("不存在要删除的实体");
			}
			else
			{
				CreatureController.Instance.RemoveSummonEntityRequest(skillId, num, num2).Forget<bool>();
			}
		}
		return true;
	}

	// Token: 0x06001D44 RID: 7492 RVA: 0x0009865C File Offset: 0x0009685C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyRemoveSummonedEntity) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyRemoveSummonedEntity.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001D45 RID: 7493 RVA: 0x000986EC File Offset: 0x000968EC
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "删除技能召唤的实体";
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x000986F4 File Offset: 0x000968F4
	[NullableContext(1)]
	private unsafe void LogInternal(string message)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Entity;
		ELogAuthor author = ELogAuthor.XDW;
		string message2 = "[TsAnimNotifyRemoveSummonEntity]" + message;
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("this.技能ID", this.技能ID);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("this.召唤者实体ID", this.召唤者实体ID);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("this.要删除的实体ID", this.要删除的实体ID);
		instance.Warn(module, author, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x00098790 File Offset: 0x00096990
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyRemoveSummonedEntity._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRemoveSummonedEntity.TsAnimNotifyRemoveSummonedEntity_C");
		}
		return TsAnimNotifyRemoveSummonedEntity._ClassPtr;
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x000987B4 File Offset: 0x000969B4
	public TsAnimNotifyRemoveSummonedEntity() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRemoveSummonedEntity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x000987DC File Offset: 0x000969DC
	[NullableContext(1)]
	public TsAnimNotifyRemoveSummonedEntity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRemoveSummonedEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x0009880F File Offset: 0x00096A0F
	protected TsAnimNotifyRemoveSummonedEntity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D4B RID: 7499 RVA: 0x00098818 File Offset: 0x00096A18
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D4C RID: 7500 RVA: 0x0009884B File Offset: 0x00096A4B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400123A RID: 4666
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRemoveSummonedEntity.TsAnimNotifyRemoveSummonedEntity_C";

	// Token: 0x0400123B RID: 4667
	private static IntPtr _ClassPtr;

	// Token: 0x0400123C RID: 4668
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400123D RID: 4669
	private static int __PropertyOffset_技能ID;

	// Token: 0x0400123E RID: 4670
	private static int __PropertyOffset_是否用当前Montage对应的技能ID;

	// Token: 0x0400123F RID: 4671
	private static int __PropertyOffset_召唤者实体ID;

	// Token: 0x04001240 RID: 4672
	private static int __PropertyOffset_是否把当前播放动画的角色实体作为召唤者;

	// Token: 0x04001241 RID: 4673
	private static int __PropertyOffset_要删除的实体ID;

	// Token: 0x04001242 RID: 4674
	private static int __PropertyOffset_删除所有召唤者通过SkillId生成的实体;
}
