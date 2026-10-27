using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001B8 RID: 440
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFightStand.TsAnimNotifyFightStand_C")]
public class TsAnimNotifyFightStand : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000473 RID: 1139
	// (get) Token: 0x06001BAB RID: 7083 RVA: 0x0008E4CB File Offset: 0x0008C6CB
	// (set) Token: 0x06001BAC RID: 7084 RVA: 0x0008E4DB File Offset: 0x0008C6DB
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

	// Token: 0x06001BAD RID: 7085 RVA: 0x0008E4EC File Offset: 0x0008C6EC
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

	// Token: 0x06001BAE RID: 7086 RVA: 0x0008E58C File Offset: 0x0008C78C
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

	// Token: 0x06001BAF RID: 7087 RVA: 0x0008E5F0 File Offset: 0x0008C7F0
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

	// Token: 0x06001BB0 RID: 7088 RVA: 0x0008E66B File Offset: 0x0008C86B
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置战斗待机";
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x0008E672 File Offset: 0x0008C872
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyFightStand._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFightStand.TsAnimNotifyFightStand_C");
		}
		return TsAnimNotifyFightStand._ClassPtr;
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x0008E698 File Offset: 0x0008C898
	public TsAnimNotifyFightStand() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFightStand.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001BB3 RID: 7091 RVA: 0x0008E6C0 File Offset: 0x0008C8C0
	[NullableContext(1)]
	public TsAnimNotifyFightStand(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFightStand.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001BB4 RID: 7092 RVA: 0x0008E6F3 File Offset: 0x0008C8F3
	protected TsAnimNotifyFightStand(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001BB5 RID: 7093 RVA: 0x0008E6FC File Offset: 0x0008C8FC
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001BB6 RID: 7094 RVA: 0x0008E72F File Offset: 0x0008C92F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011A0 RID: 4512
	private const int BATLLE_IDLE_TIME = 5000;

	// Token: 0x040011A1 RID: 4513
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFightStand.TsAnimNotifyFightStand_C";

	// Token: 0x040011A2 RID: 4514
	private static IntPtr _ClassPtr;

	// Token: 0x040011A3 RID: 4515
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011A4 RID: 4516
	private static int __PropertyOffset_BattleIdleTime;
}
