using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003467 RID: 13415
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateTrail.AnimNotifyStateTrail_C")]
public class AnimNotifyStateTrail : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700280F RID: 10255
	// (get) Token: 0x0601D17D RID: 119165 RVA: 0x0081C3E0 File Offset: 0x0081A5E0
	// (set) Token: 0x0601D17E RID: 119166 RVA: 0x0081C419 File Offset: 0x0081A619
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<EffectModelTrail> TrailingConfigData
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<EffectModelTrail> result;
			if ((result = this._TrailingConfigData) == null)
			{
				result = (this._TrailingConfigData = new TSoftObjectPtr<EffectModelTrail>(base.NativePtr + (IntPtr)AnimNotifyStateTrail.__PropertyOffset_TrailingConfigData, this));
			}
			return result;
		}
		[NullableContext(1)]
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)AnimNotifyStateTrail.__PropertyOffset_TrailingConfigData, 1);
		}
	}

	// Token: 0x17002810 RID: 10256
	// (get) Token: 0x0601D17F RID: 119167 RVA: 0x0081C43E File Offset: 0x0081A63E
	// (set) Token: 0x0601D180 RID: 119168 RVA: 0x0081C44E File Offset: 0x0081A64E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseWeapon
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateTrail.__PropertyOffset_UseWeapon) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateTrail.__PropertyOffset_UseWeapon) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002811 RID: 10257
	// (get) Token: 0x0601D181 RID: 119169 RVA: 0x0081C45F File Offset: 0x0081A65F
	// (set) Token: 0x0601D182 RID: 119170 RVA: 0x0081C46F File Offset: 0x0081A66F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int WeaponCaseIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateTrail.__PropertyOffset_WeaponCaseIndex);
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateTrail.__PropertyOffset_WeaponCaseIndex) = value;
		}
	}

	// Token: 0x0601D183 RID: 119171 RVA: 0x0081C480 File Offset: 0x0081A680
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_ValidateAssets()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_ValidateAssets"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601D184 RID: 119172 RVA: 0x0081C4F5 File Offset: 0x0081A6F5
	protected virtual bool K2_ValidateAssets_Implementation()
	{
		return true;
	}

	// Token: 0x0601D185 RID: 119173 RVA: 0x0081C4F8 File Offset: 0x0081A6F8
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

	// Token: 0x0601D186 RID: 119174 RVA: 0x0081C5A0 File Offset: 0x0081A7A0
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.Handle = 0;
		if (meshComp == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "拖尾特效传入空参数";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("动画", animation);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (this.TrailingConfigData == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RenderEffect;
			ELogAuthor author2 = ELogAuthor.LSY;
			string message2 = "拖尾特效缺失配置";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("动画", animation);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		USkeletalMeshComponent uskeletalMeshComponent = meshComp;
		if (this.UseWeapon)
		{
			string b = "WeaponCase" + this.WeaponCaseIndex.ToString();
			TArray<UActorComponent> tarray = meshComp.GetOwner().K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
			bool flag = false;
			for (int i = 0; i < tarray.Num(); i++)
			{
				if (tarray.Get(i).GetName() == b)
				{
					uskeletalMeshComponent = (tarray.Get(i) as USkeletalMeshComponent);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				Log.Instance.Error(ELogModule.Render, ELogAuthor.LSY, "AnimNotifyStateTrail未找到武器", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
		}
		AActor owner = uskeletalMeshComponent.GetOwner();
		SkeletalMeshEffectContext skeletalMeshEffectContext = new SkeletalMeshEffectContext(null, null, false);
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			if (((characterActorComponent != null) ? characterActorComponent.Entity : null) != null)
			{
				EffectContext effectContext = skeletalMeshEffectContext;
				CharacterActorComponent characterActorComponent2 = tsBaseCharacter.CharacterActorComponent;
				effectContext.EntityId = ((characterActorComponent2 != null) ? new int?(characterActorComponent2.Entity.Id) : null);
			}
		}
		skeletalMeshEffectContext.SourceObject = uskeletalMeshComponent.GetOwner();
		skeletalMeshEffectContext.SkeletalMeshComp = uskeletalMeshComponent;
		EffectSystem instance3 = EffectSystem.Instance;
		UObject worldContext = owner;
		FTransformDouble? ftransformDouble = new FTransformDouble?(meshComp.D_K2_GetComponentToWorld());
		this.Handle = instance3.SpawnEffect(worldContext, ftransformDouble, this.TrailingConfigData.ToAssetPathName(), "[AnimNotifyStateTrail.K2_NotifyBegin]", skeletalMeshEffectContext, EEffectType.Scene, null, null, null, false, false);
		if (!EffectSystem.Instance.IsValid(this.Handle))
		{
			return false;
		}
		EffectSystem.Instance.SetEffectNotRecord(this.Handle, true);
		return true;
	}

	// Token: 0x0601D187 RID: 119175 RVA: 0x0081C790 File Offset: 0x0081A990
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

	// Token: 0x0601D188 RID: 119176 RVA: 0x0081C830 File Offset: 0x0081AA30
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (!EffectSystem.Instance.IsValid(this.Handle))
		{
			return false;
		}
		EffectSystem.Instance.StopEffectById(this.Handle, "AnimNotifyTrail: K2_NotifyEnd", false, null);
		this.Handle = 0;
		return true;
	}

	// Token: 0x0601D189 RID: 119177 RVA: 0x0081C879 File Offset: 0x0081AA79
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyStateTrail._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateTrail.AnimNotifyStateTrail_C");
		}
		return AnimNotifyStateTrail._ClassPtr;
	}

	// Token: 0x0601D18A RID: 119178 RVA: 0x0081C8A0 File Offset: 0x0081AAA0
	public AnimNotifyStateTrail() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateTrail.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D18B RID: 119179 RVA: 0x0081C8C8 File Offset: 0x0081AAC8
	[NullableContext(1)]
	public AnimNotifyStateTrail(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D18C RID: 119180 RVA: 0x0081C8FB File Offset: 0x0081AAFB
	protected AnimNotifyStateTrail(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601D18D RID: 119181 RVA: 0x0081C904 File Offset: 0x0081AB04
	protected unsafe virtual void __CPPCALL_K2_ValidateAssets_Implementation(UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams* __Params)
	{
		__Params->__Result = this.K2_ValidateAssets_Implementation();
	}

	// Token: 0x0601D18E RID: 119182 RVA: 0x0081C914 File Offset: 0x0081AB14
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601D18F RID: 119183 RVA: 0x0081C950 File Offset: 0x0081AB50
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400E508 RID: 58632
	public int Handle;

	// Token: 0x0400E509 RID: 58633
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateTrail.AnimNotifyStateTrail_C";

	// Token: 0x0400E50A RID: 58634
	private static IntPtr _ClassPtr;

	// Token: 0x0400E50B RID: 58635
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E50C RID: 58636
	private static int __PropertyOffset_TrailingConfigData;

	// Token: 0x0400E50D RID: 58637
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<EffectModelTrail> _TrailingConfigData;

	// Token: 0x0400E50E RID: 58638
	private static int __PropertyOffset_UseWeapon;

	// Token: 0x0400E50F RID: 58639
	private static int __PropertyOffset_WeaponCaseIndex;
}
