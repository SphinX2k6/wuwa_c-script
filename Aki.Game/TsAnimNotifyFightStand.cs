using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001BC RID: 444
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFightStand.TsAnimNotifyFightStand_C")]
public class TsAnimNotifyFightStand : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000495 RID: 1173
	// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00094E83 File Offset: 0x00093083
	// (set) Token: 0x06001C49 RID: 7241 RVA: 0x00094E93 File Offset: 0x00093093
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int BattleIdleTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyFightStand.__PropertyOffset_BattleIdleTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyFightStand.__PropertyOffset_BattleIdleTime) = value;
		}
	}

	// Token: 0x06001C4A RID: 7242 RVA: 0x00094EA4 File Offset: 0x000930A4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyFightStand) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyFightStand.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001C4B RID: 7243 RVA: 0x00094F5C File Offset: 0x0009315C
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			object obj;
			if (characterActorComponent == null)
			{
				obj = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				obj = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				obj2.EnterBattleIdle(new int?((this.BattleIdleTime > 0) ? this.BattleIdleTime : 5000));
			}
		}
		return true;
	}

	// Token: 0x06001C4C RID: 7244 RVA: 0x00094FC0 File Offset: 0x000931C0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyFightStand) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyFightStand.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001C4D RID: 7245 RVA: 0x00095050 File Offset: 0x00093250
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置战斗待机";
	}

	// Token: 0x06001C4E RID: 7246 RVA: 0x00095057 File Offset: 0x00093257
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyFightStand._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFightStand.TsAnimNotifyFightStand_C");
		}
		return TsAnimNotifyFightStand._ClassPtr;
	}

	// Token: 0x06001C4F RID: 7247 RVA: 0x0009507C File Offset: 0x0009327C
	public TsAnimNotifyFightStand() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFightStand.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C50 RID: 7248 RVA: 0x000950A4 File Offset: 0x000932A4
	[NullableContext(1)]
	public TsAnimNotifyFightStand(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFightStand.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C51 RID: 7249 RVA: 0x000950D7 File Offset: 0x000932D7
	protected TsAnimNotifyFightStand(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C52 RID: 7250 RVA: 0x000950E0 File Offset: 0x000932E0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C53 RID: 7251 RVA: 0x00095113 File Offset: 0x00093313
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011E3 RID: 4579
	private const int BATLLE_IDLE_TIME = 5000;

	// Token: 0x040011E4 RID: 4580
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFightStand.TsAnimNotifyFightStand_C";

	// Token: 0x040011E5 RID: 4581
	private static IntPtr _ClassPtr;

	// Token: 0x040011E6 RID: 4582
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011E7 RID: 4583
	private static int __PropertyOffset_BattleIdleTime;
}
