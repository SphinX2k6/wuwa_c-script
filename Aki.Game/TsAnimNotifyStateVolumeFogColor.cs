using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000187 RID: 391
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVolumeFogColor.TsAnimNotifyStateVolumeFogColor_C")]
public class TsAnimNotifyStateVolumeFogColor : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000401 RID: 1025
	// (get) Token: 0x060018CC RID: 6348 RVA: 0x00083DF5 File Offset: 0x00081FF5
	// (set) Token: 0x060018CD RID: 6349 RVA: 0x00083E09 File Offset: 0x00082009
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

	// Token: 0x17000402 RID: 1026
	// (get) Token: 0x060018CE RID: 6350 RVA: 0x00083E1E File Offset: 0x0008201E
	// (set) Token: 0x060018CF RID: 6351 RVA: 0x00083E32 File Offset: 0x00082032
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

	// Token: 0x17000403 RID: 1027
	// (get) Token: 0x060018D0 RID: 6352 RVA: 0x00083E47 File Offset: 0x00082047
	// (set) Token: 0x060018D1 RID: 6353 RVA: 0x00083E57 File Offset: 0x00082057
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

	// Token: 0x17000404 RID: 1028
	// (get) Token: 0x060018D2 RID: 6354 RVA: 0x00083E68 File Offset: 0x00082068
	// (set) Token: 0x060018D3 RID: 6355 RVA: 0x00083E78 File Offset: 0x00082078
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

	// Token: 0x17000405 RID: 1029
	// (get) Token: 0x060018D4 RID: 6356 RVA: 0x00083E89 File Offset: 0x00082089
	// (set) Token: 0x060018D5 RID: 6357 RVA: 0x00083E99 File Offset: 0x00082099
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

	// Token: 0x17000406 RID: 1030
	// (get) Token: 0x060018D6 RID: 6358 RVA: 0x00083EAC File Offset: 0x000820AC
	// (set) Token: 0x060018D7 RID: 6359 RVA: 0x00083EE5 File Offset: 0x000820E5
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

	// Token: 0x17000407 RID: 1031
	// (get) Token: 0x060018D8 RID: 6360 RVA: 0x00083F10 File Offset: 0x00082110
	// (set) Token: 0x060018D9 RID: 6361 RVA: 0x00083F49 File Offset: 0x00082149
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

	// Token: 0x060018DA RID: 6362 RVA: 0x00083F74 File Offset: 0x00082174
	private void setColor(USkeletalMeshComponent meshComp, FLinearColor color)
	{
		UKismetMaterialLibrary.SetVectorParameterValue(meshComp, this.MPCObject, FNameUtil.GetDynamicFName(TsAnimNotifyStateVolumeFogColor.PARAM_NAME).Value, color);
	}

	// Token: 0x060018DB RID: 6363 RVA: 0x00083FA1 File Offset: 0x000821A1
	[NullableContext(2)]
	private float sampleAlpha(FKuroCurveFloat curve, float t)
	{
		if (curve != null)
		{
			return UKuroCurveLibrary.GetValue_Float(curve, t);
		}
		return t;
	}

	// Token: 0x060018DC RID: 6364 RVA: 0x00083FB8 File Offset: 0x000821B8
	private FLinearColor lerpColor(FLinearColor a, FLinearColor b, float t)
	{
		return new FLinearColor(a.R + (b.R - a.R) * t, a.G + (b.G - a.G) * t, a.B + (b.B - a.B) * t, a.A + (b.A - a.A) * t);
	}

	// Token: 0x060018DD RID: 6365 RVA: 0x00084024 File Offset: 0x00082224
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

	// Token: 0x060018DE RID: 6366 RVA: 0x000840CC File Offset: 0x000822CC
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

	// Token: 0x060018DF RID: 6367 RVA: 0x00084158 File Offset: 0x00082358
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = frameDeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060018E0 RID: 6368 RVA: 0x00084200 File Offset: 0x00082400
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

	// Token: 0x060018E1 RID: 6369 RVA: 0x0008435C File Offset: 0x0008255C
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

	// Token: 0x060018E2 RID: 6370 RVA: 0x000843FB File Offset: 0x000825FB
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

	// Token: 0x060018E3 RID: 6371 RVA: 0x0008442C File Offset: 0x0008262C
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

	// Token: 0x060018E4 RID: 6372 RVA: 0x000844A7 File Offset: 0x000826A7
	protected override string GetNotifyName_Implementation()
	{
		return "体积雾颜色控制通知状态";
	}

	// Token: 0x060018E5 RID: 6373 RVA: 0x000844AE File Offset: 0x000826AE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateVolumeFogColor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVolumeFogColor.TsAnimNotifyStateVolumeFogColor_C");
		}
		return TsAnimNotifyStateVolumeFogColor._ClassPtr;
	}

	// Token: 0x060018E6 RID: 6374 RVA: 0x000844D4 File Offset: 0x000826D4
	public TsAnimNotifyStateVolumeFogColor() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVolumeFogColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060018E7 RID: 6375 RVA: 0x000844FC File Offset: 0x000826FC
	public TsAnimNotifyStateVolumeFogColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateVolumeFogColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060018E8 RID: 6376 RVA: 0x00084530 File Offset: 0x00082730
	protected TsAnimNotifyStateVolumeFogColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060018E9 RID: 6377 RVA: 0x00084584 File Offset: 0x00082784
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060018EA RID: 6378 RVA: 0x000845C0 File Offset: 0x000827C0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060018EB RID: 6379 RVA: 0x000845FC File Offset: 0x000827FC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060018EC RID: 6380 RVA: 0x0008462F File Offset: 0x0008282F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001077 RID: 4215
	protected FLinearColor OriginalColor = new FLinearColor(0f, 0f, 0f, 0f);

	// Token: 0x04001078 RID: 4216
	protected TsAnimNotifyStateVolumeFogColor.EBlendPhase BlendPhase;

	// Token: 0x04001079 RID: 4217
	protected float BlendElapsed;

	// Token: 0x0400107A RID: 4218
	protected FLinearColor BlendOutStartColor = new FLinearColor(0f, 0f, 0f, 0f);

	// Token: 0x0400107B RID: 4219
	[StaticVariableRuleIgnore]
	private static readonly string PARAM_NAME = "KuroVolumeColor";

	// Token: 0x0400107C RID: 4220
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateVolumeFogColor.TsAnimNotifyStateVolumeFogColor_C";

	// Token: 0x0400107D RID: 4221
	private static IntPtr _ClassPtr;

	// Token: 0x0400107E RID: 4222
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400107F RID: 4223
	private static int __PropertyOffset_MPCObject;

	// Token: 0x04001080 RID: 4224
	private static int __PropertyOffset_ActiveColor;

	// Token: 0x04001081 RID: 4225
	private static int __PropertyOffset_bUseBlend;

	// Token: 0x04001082 RID: 4226
	private static int __PropertyOffset_BlendInDuration;

	// Token: 0x04001083 RID: 4227
	private static int __PropertyOffset_BlendOutDuration;

	// Token: 0x04001084 RID: 4228
	private static int __PropertyOffset_BlendInCurve;

	// Token: 0x04001085 RID: 4229
	[Nullable(2)]
	private FKuroCurveFloat _BlendInCurve;

	// Token: 0x04001086 RID: 4230
	private static int __PropertyOffset_BlendOutCurve;

	// Token: 0x04001087 RID: 4231
	[Nullable(2)]
	private FKuroCurveFloat _BlendOutCurve;

	// Token: 0x020073C3 RID: 29635
	[NullableContext(0)]
	protected enum EBlendPhase
	{
		// Token: 0x0402668E RID: 157326
		Done,
		// Token: 0x0402668F RID: 157327
		Hold,
		// Token: 0x04026690 RID: 157328
		In,
		// Token: 0x04026691 RID: 157329
		Out
	}
}
