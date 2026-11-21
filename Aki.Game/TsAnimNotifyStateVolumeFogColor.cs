using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200018B RID: 395
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVolumeFogColor.TsAnimNotifyStateVolumeFogColor_C")]
public class TsAnimNotifyStateVolumeFogColor : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000423 RID: 1059
	// (get) Token: 0x06001969 RID: 6505 RVA: 0x00089F89 File Offset: 0x00088189
	// (set) Token: 0x0600196A RID: 6506 RVA: 0x00089F9D File Offset: 0x0008819D
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UMaterialParameterCollection MPCObject
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateVolumeFogColor.__PropertyOffset_MPCObject);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStateVolumeFogColor.__PropertyOffset_MPCObject, value);
		}
	}

	// Token: 0x17000424 RID: 1060
	// (get) Token: 0x0600196B RID: 6507 RVA: 0x00089FB2 File Offset: 0x000881B2
	// (set) Token: 0x0600196C RID: 6508 RVA: 0x00089FC6 File Offset: 0x000881C6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FLinearColor ActiveColor
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVolumeFogColor.__PropertyOffset_ActiveColor);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVolumeFogColor.__PropertyOffset_ActiveColor) = value;
		}
	}

	// Token: 0x17000425 RID: 1061
	// (get) Token: 0x0600196D RID: 6509 RVA: 0x00089FDB File Offset: 0x000881DB
	// (set) Token: 0x0600196E RID: 6510 RVA: 0x00089FEB File Offset: 0x000881EB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool bUseBlend
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVolumeFogColor.__PropertyOffset_bUseBlend) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVolumeFogColor.__PropertyOffset_bUseBlend) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000426 RID: 1062
	// (get) Token: 0x0600196F RID: 6511 RVA: 0x00089FFC File Offset: 0x000881FC
	// (set) Token: 0x06001970 RID: 6512 RVA: 0x0008A00C File Offset: 0x0008820C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float BlendInDuration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVolumeFogColor.__PropertyOffset_BlendInDuration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVolumeFogColor.__PropertyOffset_BlendInDuration) = value;
		}
	}

	// Token: 0x17000427 RID: 1063
	// (get) Token: 0x06001971 RID: 6513 RVA: 0x0008A01D File Offset: 0x0008821D
	// (set) Token: 0x06001972 RID: 6514 RVA: 0x0008A02D File Offset: 0x0008822D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float BlendOutDuration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateVolumeFogColor.__PropertyOffset_BlendOutDuration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateVolumeFogColor.__PropertyOffset_BlendOutDuration) = value;
		}
	}

	// Token: 0x17000428 RID: 1064
	// (get) Token: 0x06001973 RID: 6515 RVA: 0x0008A040 File Offset: 0x00088240
	// (set) Token: 0x06001974 RID: 6516 RVA: 0x0008A079 File Offset: 0x00088279
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat BlendInCurve
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._BlendInCurve) == null)
			{
				result = (this._BlendInCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)TsAnimNotifyStateVolumeFogColor.__PropertyOffset_BlendInCurve, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateVolumeFogColor.__PropertyOffset_BlendInCurve, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x17000429 RID: 1065
	// (get) Token: 0x06001975 RID: 6517 RVA: 0x0008A0A4 File Offset: 0x000882A4
	// (set) Token: 0x06001976 RID: 6518 RVA: 0x0008A0DD File Offset: 0x000882DD
	[UProperty(EPropertyFlags.CPF_None)]
	public FKuroCurveFloat BlendOutCurve
	{
		get
		{
			base.FastCheckIsValid();
			FKuroCurveFloat result;
			if ((result = this._BlendOutCurve) == null)
			{
				result = (this._BlendOutCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)TsAnimNotifyStateVolumeFogColor.__PropertyOffset_BlendOutCurve, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateVolumeFogColor.__PropertyOffset_BlendOutCurve, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x06001977 RID: 6519 RVA: 0x0008A108 File Offset: 0x00088308
	private void setColor(USkeletalMeshComponent meshComp, FLinearColor color)
	{
		UKismetMaterialLibrary.SetVectorParameterValue(meshComp, this.MPCObject, FNameUtil.GetDynamicFName(TsAnimNotifyStateVolumeFogColor.PARAM_NAME).Value, color);
	}

	// Token: 0x06001978 RID: 6520 RVA: 0x0008A135 File Offset: 0x00088335
	[NullableContext(2)]
	private float sampleAlpha(FKuroCurveFloat curve, float t)
	{
		if (curve != null)
		{
			return UKuroCurveLibrary.GetValue_Float(curve, t);
		}
		return t;
	}

	// Token: 0x06001979 RID: 6521 RVA: 0x0008A14C File Offset: 0x0008834C
	private FLinearColor lerpColor(FLinearColor a, FLinearColor b, float t)
	{
		return new FLinearColor(a.R + (b.R - a.R) * t, a.G + (b.G - a.G) * t, a.B + (b.B - a.B) * t, a.A + (b.A - a.A) * t);
	}

	// Token: 0x0600197A RID: 6522 RVA: 0x0008A1B8 File Offset: 0x000883B8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVolumeFogColor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateVolumeFogColor.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600197B RID: 6523 RVA: 0x0008A278 File Offset: 0x00088478
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		UMaterialParameterCollection mpcobject = this.MPCObject;
		if (mpcobject == null || !mpcobject.IsValid())
		{
			return false;
		}
		this.OriginalColor = UKismetMaterialLibrary.GetVectorParameterValue(meshComp, this.MPCObject, FNameUtil.GetDynamicFName(TsAnimNotifyStateVolumeFogColor.PARAM_NAME).Value);
		if (!this.bUseBlend)
		{
			this.setColor(meshComp, this.ActiveColor);
			this.BlendPhase = TsAnimNotifyStateVolumeFogColor.EBlendPhase.Done;
			return true;
		}
		this.BlendElapsed = 0f;
		this.BlendPhase = ((this.BlendInDuration > 0f) ? TsAnimNotifyStateVolumeFogColor.EBlendPhase.In : TsAnimNotifyStateVolumeFogColor.EBlendPhase.Hold);
		return true;
	}

	// Token: 0x0600197C RID: 6524 RVA: 0x0008A304 File Offset: 0x00088504
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVolumeFogColor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateVolumeFogColor.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, frameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = frameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600197D RID: 6525 RVA: 0x0008A3C4 File Offset: 0x000885C4
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if (!this.bUseBlend || this.BlendPhase == TsAnimNotifyStateVolumeFogColor.EBlendPhase.Done)
		{
			return true;
		}
		UMaterialParameterCollection mpcobject = this.MPCObject;
		if (mpcobject == null || !mpcobject.IsValid())
		{
			return false;
		}
		this.BlendElapsed += frameDeltaTime;
		if (this.BlendPhase == TsAnimNotifyStateVolumeFogColor.EBlendPhase.In)
		{
			float num = (this.BlendInDuration > 0f) ? this.BlendInDuration : 1f;
			float num2 = Math.Min(this.BlendElapsed / num, 1f);
			float t = this.sampleAlpha(this.BlendInCurve, num2);
			this.setColor(meshComp, this.lerpColor(this.OriginalColor, this.ActiveColor, t));
			if (num2 >= 1f)
			{
				this.BlendPhase = TsAnimNotifyStateVolumeFogColor.EBlendPhase.Hold;
				this.BlendElapsed = 0f;
				this.setColor(meshComp, this.ActiveColor);
			}
			return true;
		}
		if (this.BlendPhase == TsAnimNotifyStateVolumeFogColor.EBlendPhase.Hold)
		{
			return true;
		}
		if (this.BlendPhase == TsAnimNotifyStateVolumeFogColor.EBlendPhase.Out)
		{
			float num3 = (this.BlendOutDuration > 0f) ? this.BlendOutDuration : 1f;
			float num4 = Math.Min(this.BlendElapsed / num3, 1f);
			float t2 = this.sampleAlpha(this.BlendOutCurve, num4);
			this.setColor(meshComp, this.lerpColor(this.BlendOutStartColor, this.OriginalColor, t2));
			if (num4 >= 1f)
			{
				this.BlendPhase = TsAnimNotifyStateVolumeFogColor.EBlendPhase.Done;
				this.setColor(meshComp, this.OriginalColor);
			}
		}
		return true;
	}

	// Token: 0x0600197E RID: 6526 RVA: 0x0008A520 File Offset: 0x00088720
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVolumeFogColor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateVolumeFogColor.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600197F RID: 6527 RVA: 0x0008A5D6 File Offset: 0x000887D6
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		UMaterialParameterCollection mpcobject = this.MPCObject;
		if (mpcobject == null || !mpcobject.IsValid())
		{
			return false;
		}
		this.setColor(meshComp, this.OriginalColor);
		this.BlendPhase = TsAnimNotifyStateVolumeFogColor.EBlendPhase.Done;
		return true;
	}

	// Token: 0x06001980 RID: 6528 RVA: 0x0008A608 File Offset: 0x00088808
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateVolumeFogColor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateVolumeFogColor.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001981 RID: 6529 RVA: 0x0008A698 File Offset: 0x00088898
	protected override string GetNotifyName_Implementation()
	{
		return "体积雾颜色控制通知状态";
	}

	// Token: 0x06001982 RID: 6530 RVA: 0x0008A69F File Offset: 0x0008889F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateVolumeFogColor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVolumeFogColor.TsAnimNotifyStateVolumeFogColor_C");
		}
		return TsAnimNotifyStateVolumeFogColor._ClassPtr;
	}

	// Token: 0x06001983 RID: 6531 RVA: 0x0008A6C4 File Offset: 0x000888C4
	public TsAnimNotifyStateVolumeFogColor() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVolumeFogColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001984 RID: 6532 RVA: 0x0008A6EC File Offset: 0x000888EC
	public TsAnimNotifyStateVolumeFogColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVolumeFogColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001985 RID: 6533 RVA: 0x0008A720 File Offset: 0x00088920
	protected TsAnimNotifyStateVolumeFogColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x0008A774 File Offset: 0x00088974
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001987 RID: 6535 RVA: 0x0008A7B0 File Offset: 0x000889B0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001988 RID: 6536 RVA: 0x0008A7EC File Offset: 0x000889EC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001989 RID: 6537 RVA: 0x0008A81F File Offset: 0x00088A1F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010BA RID: 4282
	protected FLinearColor OriginalColor = new FLinearColor(0f, 0f, 0f, 0f);

	// Token: 0x040010BB RID: 4283
	protected TsAnimNotifyStateVolumeFogColor.EBlendPhase BlendPhase;

	// Token: 0x040010BC RID: 4284
	protected float BlendElapsed;

	// Token: 0x040010BD RID: 4285
	protected FLinearColor BlendOutStartColor = new FLinearColor(0f, 0f, 0f, 0f);

	// Token: 0x040010BE RID: 4286
	[StaticVariableRuleIgnore]
	private static readonly string PARAM_NAME = "KuroVolumeColor";

	// Token: 0x040010BF RID: 4287
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVolumeFogColor.TsAnimNotifyStateVolumeFogColor_C";

	// Token: 0x040010C0 RID: 4288
	private static IntPtr _ClassPtr;

	// Token: 0x040010C1 RID: 4289
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010C2 RID: 4290
	private static int __PropertyOffset_MPCObject;

	// Token: 0x040010C3 RID: 4291
	private static int __PropertyOffset_ActiveColor;

	// Token: 0x040010C4 RID: 4292
	private static int __PropertyOffset_bUseBlend;

	// Token: 0x040010C5 RID: 4293
	private static int __PropertyOffset_BlendInDuration;

	// Token: 0x040010C6 RID: 4294
	private static int __PropertyOffset_BlendOutDuration;

	// Token: 0x040010C7 RID: 4295
	private static int __PropertyOffset_BlendInCurve;

	// Token: 0x040010C8 RID: 4296
	[Nullable(2)]
	private FKuroCurveFloat _BlendInCurve;

	// Token: 0x040010C9 RID: 4297
	private static int __PropertyOffset_BlendOutCurve;

	// Token: 0x040010CA RID: 4298
	[Nullable(2)]
	private FKuroCurveFloat _BlendOutCurve;

	// Token: 0x0200654B RID: 25931
	[NullableContext(0)]
	protected enum EBlendPhase
	{
		// Token: 0x040219AF RID: 137647
		Done,
		// Token: 0x040219B0 RID: 137648
		Hold,
		// Token: 0x040219B1 RID: 137649
		In,
		// Token: 0x040219B2 RID: 137650
		Out
	}
}
