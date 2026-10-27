using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001CA RID: 458
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRemoveSummonedEntity.TsAnimNotifyRemoveSummonedEntity_C")]
public class TsAnimNotifyRemoveSummonedEntity : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000493 RID: 1171
	// (get) Token: 0x06001C99 RID: 7321 RVA: 0x00091727 File Offset: 0x0008F927
	// (set) Token: 0x06001C9A RID: 7322 RVA: 0x00091737 File Offset: 0x0008F937
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

	// Token: 0x17000494 RID: 1172
	// (get) Token: 0x06001C9B RID: 7323 RVA: 0x00091748 File Offset: 0x0008F948
	// (set) Token: 0x06001C9C RID: 7324 RVA: 0x00091758 File Offset: 0x0008F958
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

	// Token: 0x17000495 RID: 1173
	// (get) Token: 0x06001C9D RID: 7325 RVA: 0x00091769 File Offset: 0x0008F969
	// (set) Token: 0x06001C9E RID: 7326 RVA: 0x00091779 File Offset: 0x0008F979
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

	// Token: 0x17000496 RID: 1174
	// (get) Token: 0x06001C9F RID: 7327 RVA: 0x0009178A File Offset: 0x0008F98A
	// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x0009179A File Offset: 0x0008F99A
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

	// Token: 0x17000497 RID: 1175
	// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x000917AB File Offset: 0x0008F9AB
	// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x000917BB File Offset: 0x0008F9BB
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

	// Token: 0x17000498 RID: 1176
	// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x000917CC File Offset: 0x0008F9CC
	// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x000917DC File Offset: 0x0008F9DC
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

	// Token: 0x06001CA5 RID: 7333 RVA: 0x000917F0 File Offset: 0x0008F9F0
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

	// Token: 0x06001CA6 RID: 7334 RVA: 0x00091890 File Offset: 0x0008FA90
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

	// Token: 0x06001CA7 RID: 7335 RVA: 0x000919CC File Offset: 0x0008FBCC
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

	// Token: 0x06001CA8 RID: 7336 RVA: 0x00091A47 File Offset: 0x0008FC47
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "删除技能召唤的实体";
	}

	// Token: 0x06001CA9 RID: 7337 RVA: 0x00091A50 File Offset: 0x0008FC50
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

	// Token: 0x06001CAA RID: 7338 RVA: 0x00091AEC File Offset: 0x0008FCEC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyRemoveSummonedEntity._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRemoveSummonedEntity.TsAnimNotifyRemoveSummonedEntity_C");
		}
		return TsAnimNotifyRemoveSummonedEntity._ClassPtr;
	}

	// Token: 0x06001CAB RID: 7339 RVA: 0x00091B10 File Offset: 0x0008FD10
	public TsAnimNotifyRemoveSummonedEntity() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRemoveSummonedEntity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001CAC RID: 7340 RVA: 0x00091B38 File Offset: 0x0008FD38
	[NullableContext(1)]
	public TsAnimNotifyRemoveSummonedEntity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRemoveSummonedEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001CAD RID: 7341 RVA: 0x00091B6B File Offset: 0x0008FD6B
	protected TsAnimNotifyRemoveSummonedEntity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001CAE RID: 7342 RVA: 0x00091B74 File Offset: 0x0008FD74
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001CAF RID: 7343 RVA: 0x00091BA7 File Offset: 0x0008FDA7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011F7 RID: 4599
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRemoveSummonedEntity.TsAnimNotifyRemoveSummonedEntity_C";

	// Token: 0x040011F8 RID: 4600
	private static IntPtr _ClassPtr;

	// Token: 0x040011F9 RID: 4601
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011FA RID: 4602
	private static int __PropertyOffset_技能ID;

	// Token: 0x040011FB RID: 4603
	private static int __PropertyOffset_是否用当前Montage对应的技能ID;

	// Token: 0x040011FC RID: 4604
	private static int __PropertyOffset_召唤者实体ID;

	// Token: 0x040011FD RID: 4605
	private static int __PropertyOffset_是否把当前播放动画的角色实体作为召唤者;

	// Token: 0x040011FE RID: 4606
	private static int __PropertyOffset_要删除的实体ID;

	// Token: 0x040011FF RID: 4607
	private static int __PropertyOffset_删除所有召唤者通过SkillId生成的实体;
}
