using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.QuickTimeAction;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001CB RID: 459
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyQta.TsAnimNotifyQta_C")]
public class TsAnimNotifyQta : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004AE RID: 1198
	// (get) Token: 0x06001D0C RID: 7436 RVA: 0x00097B07 File Offset: 0x00095D07
	// (set) Token: 0x06001D0D RID: 7437 RVA: 0x00097B17 File Offset: 0x00095D17
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int QtaId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_QtaId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_QtaId) = value;
		}
	}

	// Token: 0x170004AF RID: 1199
	// (get) Token: 0x06001D0E RID: 7438 RVA: 0x00097B28 File Offset: 0x00095D28
	// (set) Token: 0x06001D0F RID: 7439 RVA: 0x00097B38 File Offset: 0x00095D38
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 当前实体为玩家控制时才触发
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_当前实体为玩家控制时才触发) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_当前实体为玩家控制时才触发) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004B0 RID: 1200
	// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00097B49 File Offset: 0x00095D49
	// (set) Token: 0x06001D11 RID: 7441 RVA: 0x00097B5D File Offset: 0x00095D5D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag 存在Tag时才触发
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_存在Tag时才触发);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_存在Tag时才触发) = value;
		}
	}

	// Token: 0x170004B1 RID: 1201
	// (get) Token: 0x06001D12 RID: 7442 RVA: 0x00097B72 File Offset: 0x00095D72
	// (set) Token: 0x06001D13 RID: 7443 RVA: 0x00097B82 File Offset: 0x00095D82
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 开始时直接结束其它Qta
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_开始时直接结束其它Qta) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyQta.__PropertyOffset_开始时直接结束其它Qta) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001D14 RID: 7444 RVA: 0x00097B94 File Offset: 0x00095D94
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyQta) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyQta.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001D15 RID: 7445 RVA: 0x00097C4C File Offset: 0x00095E4C
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (this.当前实体为玩家控制时才触发 && (characterActorComponent == null || !characterActorComponent.Valid || !characterActorComponent.IsAutonomousProxy))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(this.存在Tag时才触发.TagName.ToString()) && this.存在Tag时才触发.TagName != "None")
		{
			BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
			if (baseTagComponent == null || !baseTagComponent.HasTag(this.存在Tag时才触发.TagId()))
			{
				return false;
			}
		}
		EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(entity);
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		long? num = (baseBuffComponent != null) ? baseBuffComponent.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null;
		if (handleByEntity != null && num != null)
		{
			if (this.开始时直接结束其它Qta)
			{
				QtaController.Instance.StopCurrentQta();
			}
			QtaController.Instance.StartQta(this.QtaId, null, EQtaSource.AnimNotify, new IQtaExtraParams
			{
				MessageId = new long?(num.Value),
				EntityHandle = handleByEntity
			});
		}
		return true;
	}

	// Token: 0x06001D16 RID: 7446 RVA: 0x00097D94 File Offset: 0x00095F94
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyQta) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyQta.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001D17 RID: 7447 RVA: 0x00097E24 File Offset: 0x00096024
	protected override string GetNotifyName_Implementation()
	{
		return "特殊交互QTA";
	}

	// Token: 0x06001D18 RID: 7448 RVA: 0x00097E2B File Offset: 0x0009602B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyQta._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyQta.TsAnimNotifyQta_C");
		}
		return TsAnimNotifyQta._ClassPtr;
	}

	// Token: 0x06001D19 RID: 7449 RVA: 0x00097E50 File Offset: 0x00096050
	public TsAnimNotifyQta() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyQta.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D1A RID: 7450 RVA: 0x00097E78 File Offset: 0x00096078
	public TsAnimNotifyQta(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyQta.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D1B RID: 7451 RVA: 0x00097EAB File Offset: 0x000960AB
	protected TsAnimNotifyQta(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D1C RID: 7452 RVA: 0x00097EB4 File Offset: 0x000960B4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D1D RID: 7453 RVA: 0x00097EE7 File Offset: 0x000960E7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400122A RID: 4650
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyQta.TsAnimNotifyQta_C";

	// Token: 0x0400122B RID: 4651
	private static IntPtr _ClassPtr;

	// Token: 0x0400122C RID: 4652
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400122D RID: 4653
	private static int __PropertyOffset_QtaId;

	// Token: 0x0400122E RID: 4654
	private static int __PropertyOffset_当前实体为玩家控制时才触发;

	// Token: 0x0400122F RID: 4655
	private static int __PropertyOffset_存在Tag时才触发;

	// Token: 0x04001230 RID: 4656
	private static int __PropertyOffset_开始时直接结束其它Qta;
}
