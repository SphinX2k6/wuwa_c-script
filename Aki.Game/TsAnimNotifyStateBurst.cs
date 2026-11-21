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
	// Token: 0x170002A4 RID: 676
	// (get) Token: 0x0600107B RID: 4219 RVA: 0x0005F397 File Offset: 0x0005D597
	// (set) Token: 0x0600107C RID: 4220 RVA: 0x0005F3A7 File Offset: 0x0005D5A7
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

	// Token: 0x170002A5 RID: 677
	// (get) Token: 0x0600107D RID: 4221 RVA: 0x0005F3B8 File Offset: 0x0005D5B8
	// (set) Token: 0x0600107E RID: 4222 RVA: 0x0005F3C8 File Offset: 0x0005D5C8
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

	// Token: 0x170002A6 RID: 678
	// (get) Token: 0x0600107F RID: 4223 RVA: 0x0005F3D9 File Offset: 0x0005D5D9
	// (set) Token: 0x06001080 RID: 4224 RVA: 0x0005F3E9 File Offset: 0x0005D5E9
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

	// Token: 0x06001081 RID: 4225 RVA: 0x0005F3FC File Offset: 0x0005D5FC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateBurst) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateBurst.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001082 RID: 4226 RVA: 0x0005F4BC File Offset: 0x0005D6BC
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

	// Token: 0x06001083 RID: 4227 RVA: 0x0005F584 File Offset: 0x0005D784
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateBurst) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateBurst.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001084 RID: 4228 RVA: 0x0005F63C File Offset: 0x0005D83C
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

	// Token: 0x06001085 RID: 4229 RVA: 0x0005F704 File Offset: 0x0005D904
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateBurst) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateBurst.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001086 RID: 4230 RVA: 0x0005F794 File Offset: 0x0005D994
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "角色放大招";
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x0005F79B File Offset: 0x0005D99B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateBurst._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBurst.TsAnimNotifyStateBurst_C");
		}
		return TsAnimNotifyStateBurst._ClassPtr;
	}

	// Token: 0x06001088 RID: 4232 RVA: 0x0005F7C0 File Offset: 0x0005D9C0
	public TsAnimNotifyStateBurst() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBurst.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x0005F7E8 File Offset: 0x0005D9E8
	[NullableContext(1)]
	public TsAnimNotifyStateBurst(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBurst.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x0005F81B File Offset: 0x0005DA1B
	protected TsAnimNotifyStateBurst(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x0005F824 File Offset: 0x0005DA24
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x0005F860 File Offset: 0x0005DA60
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x0005F893 File Offset: 0x0005DA93
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CAC RID: 3244
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBurst.TsAnimNotifyStateBurst_C";

	// Token: 0x04000CAD RID: 3245
	private static IntPtr _ClassPtr;

	// Token: 0x04000CAE RID: 3246
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CAF RID: 3247
	private static int __PropertyOffset_HitPriority;

	// Token: 0x04000CB0 RID: 3248
	private static int __PropertyOffset_不能切人;

	// Token: 0x04000CB1 RID: 3249
	private static int __PropertyOffset_是否无敌;
}
