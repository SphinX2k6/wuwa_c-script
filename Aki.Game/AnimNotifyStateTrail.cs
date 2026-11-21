using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029DB RID: 10715
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateTrail.AnimNotifyStateTrail_C")]
public class AnimNotifyStateTrail : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002BAE RID: 11182
	// (get) Token: 0x0601AE85 RID: 110213 RVA: 0x00843680 File Offset: 0x00841880
	// (set) Token: 0x0601AE86 RID: 110214 RVA: 0x008436B9 File Offset: 0x008418B9
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

	// Token: 0x17002BAF RID: 11183
	// (get) Token: 0x0601AE87 RID: 110215 RVA: 0x008436DE File Offset: 0x008418DE
	// (set) Token: 0x0601AE88 RID: 110216 RVA: 0x008436EE File Offset: 0x008418EE
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

	// Token: 0x17002BB0 RID: 11184
	// (get) Token: 0x0601AE89 RID: 110217 RVA: 0x008436FF File Offset: 0x008418FF
	// (set) Token: 0x0601AE8A RID: 110218 RVA: 0x0084370F File Offset: 0x0084190F
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

	// Token: 0x0601AE8B RID: 110219 RVA: 0x00843720 File Offset: 0x00841920
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_ValidateAssets()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStateTrail) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_ValidateAssets"), AnimNotifyStateTrail.StaticClass(), out intPtr, out num))
		{
			return this.K2_ValidateAssets_Implementation();
		}
		UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601AE8C RID: 110220 RVA: 0x008437AA File Offset: 0x008419AA
	protected virtual bool K2_ValidateAssets_Implementation()
	{
		return true;
	}

	// Token: 0x0601AE8D RID: 110221 RVA: 0x008437B0 File Offset: 0x008419B0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStateTrail) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), AnimNotifyStateTrail.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AE8E RID: 110222 RVA: 0x00843870 File Offset: 0x00841A70
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

	// Token: 0x0601AE8F RID: 110223 RVA: 0x00843A60 File Offset: 0x00841C60
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStateTrail) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), AnimNotifyStateTrail.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AE90 RID: 110224 RVA: 0x00843B18 File Offset: 0x00841D18
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

	// Token: 0x0601AE91 RID: 110225 RVA: 0x00843B61 File Offset: 0x00841D61
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyStateTrail._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateTrail.AnimNotifyStateTrail_C");
		}
		return AnimNotifyStateTrail._ClassPtr;
	}

	// Token: 0x0601AE92 RID: 110226 RVA: 0x00843B88 File Offset: 0x00841D88
	public AnimNotifyStateTrail() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateTrail.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AE93 RID: 110227 RVA: 0x00843BB0 File Offset: 0x00841DB0
	[NullableContext(1)]
	public AnimNotifyStateTrail(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AE94 RID: 110228 RVA: 0x00843BE3 File Offset: 0x00841DE3
	protected AnimNotifyStateTrail(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AE95 RID: 110229 RVA: 0x00843BEC File Offset: 0x00841DEC
	protected unsafe virtual void __CPPCALL_K2_ValidateAssets_Implementation(UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams* __Params)
	{
		__Params->__Result = this.K2_ValidateAssets_Implementation();
	}

	// Token: 0x0601AE96 RID: 110230 RVA: 0x00843BFC File Offset: 0x00841DFC
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601AE97 RID: 110231 RVA: 0x00843C38 File Offset: 0x00841E38
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400E9C0 RID: 59840
	public int Handle;

	// Token: 0x0400E9C1 RID: 59841
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateTrail.AnimNotifyStateTrail_C";

	// Token: 0x0400E9C2 RID: 59842
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9C3 RID: 59843
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E9C4 RID: 59844
	private static int __PropertyOffset_TrailingConfigData;

	// Token: 0x0400E9C5 RID: 59845
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<EffectModelTrail> _TrailingConfigData;

	// Token: 0x0400E9C6 RID: 59846
	private static int __PropertyOffset_UseWeapon;

	// Token: 0x0400E9C7 RID: 59847
	private static int __PropertyOffset_WeaponCaseIndex;
}
