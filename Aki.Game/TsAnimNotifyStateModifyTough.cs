using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000147 RID: 327
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateModifyTough.TsAnimNotifyStateModifyTough_C")]
public class TsAnimNotifyStateModifyTough : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000343 RID: 835
	// (get) Token: 0x0600141C RID: 5148 RVA: 0x000702EF File Offset: 0x0006E4EF
	// (set) Token: 0x0600141D RID: 5149 RVA: 0x00070303 File Offset: 0x0006E503
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ToughModifierId
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateModifyTough.__PropertyOffset_ToughModifierId)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateModifyTough.__PropertyOffset_ToughModifierId)), value);
		}
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x00070318 File Offset: 0x0006E518
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

	// Token: 0x0600141F RID: 5151 RVA: 0x000703C0 File Offset: 0x0006E5C0
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return true;
		}
		long? num = null;
		try
		{
			num = new long?(long.Parse(this.ToughModifierId));
		}
		catch (Exception)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "在修改被削韧倍率中配置了不合法的id";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("animationName", animation);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return true;
		}
		CharacterActorComponent characterActorComponent = ((TsBaseCharacter)owner).CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		BaseDamageComponent baseDamageComponent = (entity != null) ? entity.CheckGetComponent<BaseDamageComponent>() : null;
		ToughCalcRatio? config = ConfigToughCalcRatioById.GetConfig(num.Value, true);
		if (config == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Character;
			ELogAuthor author2 = ELogAuthor.ZQR;
			string message2 = "韧性系数计算表对应id非法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("id", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("animationName", animation);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return true;
		}
		if (entity == null || baseDamageComponent == null || !baseDamageComponent.Valid)
		{
			return true;
		}
		baseDamageComponent.AddToughModifier("ToughRate", (float)config.Value.RatioNormal);
		baseDamageComponent.AddToughModifier("ToughRateOnCounter", (float)config.Value.RatioSpecial);
		if (baseDamageComponent.ActorComponent.IsAutonomousProxy)
		{
			ToughCalcExtraRatioChangePush toughCalcExtraRatioChangePush = ToughCalcExtraRatioChangePush.Create();
			toughCalcExtraRatioChangePush.Id = MathUtils.Instance.BigIntToLong(num.Value);
			toughCalcExtraRatioChangePush.Duration = (int)totalDuration;
			CombatNet.Instance.Send(EPushMessageId.ToughCalcExtraRatioChangePush, entity, toughCalcExtraRatioChangePush, null, null, null);
		}
		return true;
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x000705B4 File Offset: 0x0006E7B4
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

	// Token: 0x06001421 RID: 5153 RVA: 0x00070654 File Offset: 0x0006E854
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return true;
		}
		long? num = null;
		try
		{
			num = new long?(long.Parse(this.ToughModifierId));
		}
		catch (Exception)
		{
			return true;
		}
		CharacterActorComponent characterActorComponent = ((TsBaseCharacter)owner).CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		BaseDamageComponent baseDamageComponent = (entity != null) ? entity.CheckGetComponent<BaseDamageComponent>() : null;
		ToughCalcRatio? config = ConfigToughCalcRatioById.GetConfig(num.Value, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "韧性系数计算表对应id非法";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", num);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}
		if (baseDamageComponent == null || !baseDamageComponent.Valid)
		{
			return true;
		}
		baseDamageComponent.RemoveToughModifier("ToughRate", (float)config.Value.RatioNormal);
		baseDamageComponent.RemoveToughModifier("ToughRateOnCounter", (float)config.Value.RatioSpecial);
		return true;
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x00070758 File Offset: 0x0006E958
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

	// Token: 0x06001423 RID: 5155 RVA: 0x000707D3 File Offset: 0x0006E9D3
	protected override string GetNotifyName_Implementation()
	{
		return "修改被削韧倍率";
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x000707DA File Offset: 0x0006E9DA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateModifyTough._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateModifyTough.TsAnimNotifyStateModifyTough_C");
		}
		return TsAnimNotifyStateModifyTough._ClassPtr;
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x00070800 File Offset: 0x0006EA00
	public TsAnimNotifyStateModifyTough() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateModifyTough.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001426 RID: 5158 RVA: 0x00070828 File Offset: 0x0006EA28
	public TsAnimNotifyStateModifyTough(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateModifyTough.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001427 RID: 5159 RVA: 0x0007085B File Offset: 0x0006EA5B
	protected TsAnimNotifyStateModifyTough(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001428 RID: 5160 RVA: 0x00070864 File Offset: 0x0006EA64
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001429 RID: 5161 RVA: 0x000708A0 File Offset: 0x0006EAA0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600142A RID: 5162 RVA: 0x000708D3 File Offset: 0x0006EAD3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E7F RID: 3711
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateModifyTough.TsAnimNotifyStateModifyTough_C";

	// Token: 0x04000E80 RID: 3712
	private static IntPtr _ClassPtr;

	// Token: 0x04000E81 RID: 3713
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E82 RID: 3714
	private static int __PropertyOffset_ToughModifierId;
}
