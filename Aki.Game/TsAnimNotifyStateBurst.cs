using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000116 RID: 278
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBurst.TsAnimNotifyStateBurst_C")]
public class TsAnimNotifyStateBurst : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002A1 RID: 673
	// (get) Token: 0x06001075 RID: 4213 RVA: 0x0005E09F File Offset: 0x0005C29F
	// (set) Token: 0x06001076 RID: 4214 RVA: 0x0005E0AF File Offset: 0x0005C2AF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int HitPriority
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateBurst.__PropertyOffset_HitPriority);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateBurst.__PropertyOffset_HitPriority) = value;
		}
	}

	// Token: 0x170002A2 RID: 674
	// (get) Token: 0x06001077 RID: 4215 RVA: 0x0005E0C0 File Offset: 0x0005C2C0
	// (set) Token: 0x06001078 RID: 4216 RVA: 0x0005E0D0 File Offset: 0x0005C2D0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 不能切人
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateBurst.__PropertyOffset_不能切人) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateBurst.__PropertyOffset_不能切人) = (value ? 1 : 0);
		}
	}

	// Token: 0x170002A3 RID: 675
	// (get) Token: 0x06001079 RID: 4217 RVA: 0x0005E0E1 File Offset: 0x0005C2E1
	// (set) Token: 0x0600107A RID: 4218 RVA: 0x0005E0F1 File Offset: 0x0005C2F1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否无敌
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateBurst.__PropertyOffset_是否无敌) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateBurst.__PropertyOffset_是否无敌) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x0005E104 File Offset: 0x0005C304
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

	// Token: 0x0600107C RID: 4220 RVA: 0x0005E1AC File Offset: 0x0005C3AC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity != null)
			{
				BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
				if (component != null)
				{
					if (this.不能切人)
					{
						component.TagContainer.UpdateExactTag(ETagChannel.BattleBuff, GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"], 1);
					}
					if (this.是否无敌)
					{
						component.TagContainer.UpdateExactTag(ETagChannel.BattleBuff, GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.无敌.通用无敌"], 1);
					}
				}
				tsBaseCharacter.CharacterMovement.HitPriority = this.HitPriority;
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "No Entity for TsBaseCharacter";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", owner);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return false;
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x0005E274 File Offset: 0x0005C474
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

	// Token: 0x0600107E RID: 4222 RVA: 0x0005E314 File Offset: 0x0005C514
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity != null)
			{
				BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
				if (component != null)
				{
					if (this.不能切人)
					{
						component.TagContainer.UpdateExactTag(ETagChannel.BattleBuff, GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"], -1);
					}
					if (this.是否无敌)
					{
						component.TagContainer.UpdateExactTag(ETagChannel.BattleBuff, GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.无敌.通用无敌"], -1);
					}
				}
				tsBaseCharacter.GetEntityNoBlueprint().GetComponent<CharacterMoveComponent>().ResetHitPriorityAndGoThrough();
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "No Entity for TsBaseCharacter";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", owner);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return false;
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x0005E3DC File Offset: 0x0005C5DC
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

	// Token: 0x06001080 RID: 4224 RVA: 0x0005E457 File Offset: 0x0005C657
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "角色放大招";
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x0005E45E File Offset: 0x0005C65E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateBurst._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBurst.TsAnimNotifyStateBurst_C");
		}
		return TsAnimNotifyStateBurst._ClassPtr;
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x0005E484 File Offset: 0x0005C684
	public TsAnimNotifyStateBurst() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBurst.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x0005E4AC File Offset: 0x0005C6AC
	[NullableContext(1)]
	public TsAnimNotifyStateBurst(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBurst.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x0005E4DF File Offset: 0x0005C6DF
	protected TsAnimNotifyStateBurst(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x0005E4E8 File Offset: 0x0005C6E8
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x0005E524 File Offset: 0x0005C724
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x0005E557 File Offset: 0x0005C757
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CA4 RID: 3236
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBurst.TsAnimNotifyStateBurst_C";

	// Token: 0x04000CA5 RID: 3237
	private static IntPtr _ClassPtr;

	// Token: 0x04000CA6 RID: 3238
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CA7 RID: 3239
	private static int __PropertyOffset_HitPriority;

	// Token: 0x04000CA8 RID: 3240
	private static int __PropertyOffset_不能切人;

	// Token: 0x04000CA9 RID: 3241
	private static int __PropertyOffset_是否无敌;
}
