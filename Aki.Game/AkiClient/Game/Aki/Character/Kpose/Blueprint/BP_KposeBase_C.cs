using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Kpose.Blueprint
{
	// Token: 0x02004256 RID: 16982
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Kpose/Blueprint/BP_KposeBase.BP_KposeBase_C")]
	[UnrealStructLayout(1816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1816)]
	public class BP_KposeBase_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BFF3 RID: 180211 RVA: 0x00A114B7 File Offset: 0x00A0F6B7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KposeBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Kpose/Blueprint/BP_KposeBase.BP_KposeBase_C");
			}
			return BP_KposeBase_C._ClassPtr;
		}

		// Token: 0x0602BFF4 RID: 180212 RVA: 0x00A114DC File Offset: 0x00A0F6DC
		public BP_KposeBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_KposeBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BFF5 RID: 180213 RVA: 0x00A11504 File Offset: 0x00A0F704
		public BP_KposeBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KposeBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D3D RID: 27965
		// (get) Token: 0x0602BFF6 RID: 180214 RVA: 0x00A11537 File Offset: 0x00A0F737
		// (set) Token: 0x0602BFF7 RID: 180215 RVA: 0x00A1154B File Offset: 0x00A0F74B
		[Nullable(2)]
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006D3E RID: 27966
		// (get) Token: 0x0602BFF8 RID: 180216 RVA: 0x00A11560 File Offset: 0x00A0F760
		// (set) Token: 0x0602BFF9 RID: 180217 RVA: 0x00A11574 File Offset: 0x00A0F774
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006D3F RID: 27967
		// (get) Token: 0x0602BFFA RID: 180218 RVA: 0x00A1158C File Offset: 0x00A0F78C
		// (set) Token: 0x0602BFFB RID: 180219 RVA: 0x00A115C5 File Offset: 0x00A0F7C5
		public TArray<SKposeEffect> PermanentEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SKposeEffect> result;
				if ((result = this._PermanentEffects) == null)
				{
					result = (this._PermanentEffects = new TArray<SKposeEffect>(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.PermanentEffects.CopyAssign(value);
			}
		}

		// Token: 0x17006D40 RID: 27968
		// (get) Token: 0x0602BFFC RID: 180220 RVA: 0x00A115D4 File Offset: 0x00A0F7D4
		// (set) Token: 0x0602BFFD RID: 180221 RVA: 0x00A1160D File Offset: 0x00A0F80D
		public TArray<SKposeEffect> EffectsOnEnd
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SKposeEffect> result;
				if ((result = this._EffectsOnEnd) == null)
				{
					result = (this._EffectsOnEnd = new TArray<SKposeEffect>(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.EffectsOnEnd.CopyAssign(value);
			}
		}

		// Token: 0x17006D41 RID: 27969
		// (get) Token: 0x0602BFFE RID: 180222 RVA: 0x00A1161C File Offset: 0x00A0F81C
		// (set) Token: 0x0602BFFF RID: 180223 RVA: 0x00A11655 File Offset: 0x00A0F855
		public TArray<SKposeEffect> EffectsOnStart
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SKposeEffect> result;
				if ((result = this._EffectsOnStart) == null)
				{
					result = (this._EffectsOnStart = new TArray<SKposeEffect>(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.EffectsOnStart.CopyAssign(value);
			}
		}

		// Token: 0x17006D42 RID: 27970
		// (get) Token: 0x0602C000 RID: 180224 RVA: 0x00A11664 File Offset: 0x00A0F864
		// (set) Token: 0x0602C001 RID: 180225 RVA: 0x00A1169D File Offset: 0x00A0F89D
		public TArray<FKuroRainMaterialFloatParameter> FloatParameterCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRainMaterialFloatParameter> result;
				if ((result = this._FloatParameterCurves) == null)
				{
					result = (this._FloatParameterCurves = new TArray<FKuroRainMaterialFloatParameter>(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.FloatParameterCurves.CopyAssign(value);
			}
		}

		// Token: 0x17006D43 RID: 27971
		// (get) Token: 0x0602C002 RID: 180226 RVA: 0x00A116AC File Offset: 0x00A0F8AC
		// (set) Token: 0x0602C003 RID: 180227 RVA: 0x00A116E5 File Offset: 0x00A0F8E5
		public TArray<FKuroRainMaterialColorParameter> ColorParameterCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRainMaterialColorParameter> result;
				if ((result = this._ColorParameterCurves) == null)
				{
					result = (this._ColorParameterCurves = new TArray<FKuroRainMaterialColorParameter>(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.ColorParameterCurves.CopyAssign(value);
			}
		}

		// Token: 0x17006D44 RID: 27972
		// (get) Token: 0x0602C004 RID: 180228 RVA: 0x00A116F3 File Offset: 0x00A0F8F3
		// (set) Token: 0x0602C005 RID: 180229 RVA: 0x00A11703 File Offset: 0x00A0F903
		public unsafe bool IsInEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D45 RID: 27973
		// (get) Token: 0x0602C006 RID: 180230 RVA: 0x00A11714 File Offset: 0x00A0F914
		// (set) Token: 0x0602C007 RID: 180231 RVA: 0x00A11724 File Offset: 0x00A0F924
		public unsafe float MaterialPlayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006D46 RID: 27974
		// (get) Token: 0x0602C008 RID: 180232 RVA: 0x00A11738 File Offset: 0x00A0F938
		// (set) Token: 0x0602C009 RID: 180233 RVA: 0x00A11771 File Offset: 0x00A0F971
		public TArray<int> CachedHandles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._CachedHandles) == null)
				{
					result = (this._CachedHandles = new TArray<int>(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.CachedHandles.CopyAssign(value);
			}
		}

		// Token: 0x17006D47 RID: 27975
		// (get) Token: 0x0602C00A RID: 180234 RVA: 0x00A11780 File Offset: 0x00A0F980
		// (set) Token: 0x0602C00B RID: 180235 RVA: 0x00A117B9 File Offset: 0x00A0F9B9
		public TArray<UMaterialInstanceDynamic> DynamicMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._DynamicMaterials) == null)
				{
					result = (this._DynamicMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.DynamicMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17006D48 RID: 27976
		// (get) Token: 0x0602C00C RID: 180236 RVA: 0x00A117C7 File Offset: 0x00A0F9C7
		// (set) Token: 0x0602C00D RID: 180237 RVA: 0x00A117D7 File Offset: 0x00A0F9D7
		public unsafe float PassTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006D49 RID: 27977
		// (get) Token: 0x0602C00E RID: 180238 RVA: 0x00A117E8 File Offset: 0x00A0F9E8
		// (set) Token: 0x0602C00F RID: 180239 RVA: 0x00A11821 File Offset: 0x00A0FA21
		public TMap<FName, float> TempFloatValue
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._TempFloatValue) == null)
				{
					result = (this._TempFloatValue = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				this.TempFloatValue.CopyAssign(value);
			}
		}

		// Token: 0x17006D4A RID: 27978
		// (get) Token: 0x0602C010 RID: 180240 RVA: 0x00A11830 File Offset: 0x00A0FA30
		// (set) Token: 0x0602C011 RID: 180241 RVA: 0x00A11869 File Offset: 0x00A0FA69
		public TMap<FName, FLinearColor> TempColorValue
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._TempColorValue) == null)
				{
					result = (this._TempColorValue = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				this.TempColorValue.CopyAssign(value);
			}
		}

		// Token: 0x17006D4B RID: 27979
		// (get) Token: 0x0602C012 RID: 180242 RVA: 0x00A11877 File Offset: 0x00A0FA77
		// (set) Token: 0x0602C013 RID: 180243 RVA: 0x00A11887 File Offset: 0x00A0FA87
		public unsafe float TimeNormalized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006D4C RID: 27980
		// (get) Token: 0x0602C014 RID: 180244 RVA: 0x00A11898 File Offset: 0x00A0FA98
		// (set) Token: 0x0602C015 RID: 180245 RVA: 0x00A118AC File Offset: 0x00A0FAAC
		[Nullable(2)]
		public unsafe UStaticMesh PlatformStaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_16);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17006D4D RID: 27981
		// (get) Token: 0x0602C016 RID: 180246 RVA: 0x00A118C1 File Offset: 0x00A0FAC1
		// (set) Token: 0x0602C017 RID: 180247 RVA: 0x00A118D5 File Offset: 0x00A0FAD5
		[Nullable(0)]
		public unsafe TEnumAsByte<BP_Enum_PlatformSize> Size
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_17);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006D4E RID: 27982
		// (get) Token: 0x0602C018 RID: 180248 RVA: 0x00A118EA File Offset: 0x00A0FAEA
		// (set) Token: 0x0602C019 RID: 180249 RVA: 0x00A118FE File Offset: 0x00A0FAFE
		public unsafe string MaterialPrefix1_不可修改_
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_KposeBase_C.__PropertyOffset_18)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_KposeBase_C.__PropertyOffset_18)), value);
			}
		}

		// Token: 0x17006D4F RID: 27983
		// (get) Token: 0x0602C01A RID: 180250 RVA: 0x00A11913 File Offset: 0x00A0FB13
		// (set) Token: 0x0602C01B RID: 180251 RVA: 0x00A11923 File Offset: 0x00A0FB23
		public unsafe int CameraArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KposeBase_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006D50 RID: 27984
		// (get) Token: 0x0602C01C RID: 180252 RVA: 0x00A11934 File Offset: 0x00A0FB34
		// (set) Token: 0x0602C01D RID: 180253 RVA: 0x00A11948 File Offset: 0x00A0FB48
		[Nullable(2)]
		public unsafe UKuroWeatherDataAsset DA_UIWeather
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_20);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KposeBase_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x0602C01E RID: 180254 RVA: 0x00A1195D File Offset: 0x00A0FB5D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ChangePlatform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__ChangePlatform_NativeFunctionPtr, null);
		}

		// Token: 0x0602C01F RID: 180255 RVA: 0x00A11971 File Offset: 0x00A0FB71
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__PlayEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602C020 RID: 180256 RVA: 0x00A11985 File Offset: 0x00A0FB85
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__PlayStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602C021 RID: 180257 RVA: 0x00A1199C File Offset: 0x00A0FB9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PlayKposeEffects([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SKposeEffect> Data, float AutoScale)
		{
			BP_KposeBase_C.__PlayKposeEffects_FunctionParams* ptr = stackalloc BP_KposeBase_C.__PlayKposeEffects_FunctionParams[(UIntPtr)367] + 15L / (long)sizeof(BP_KposeBase_C.__PlayKposeEffects_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KposeBase_C.__PlayKposeEffects_NativeFunctionPtr, (void*)ptr, 1);
			TArray<SKposeEffect> tarray = Data;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Data);
			}
			ptr->AutoScale = AutoScale;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__PlayKposeEffects_NativeFunctionPtr, (void*)ptr);
			TArray<SKposeEffect> tarray2 = Data;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_KposeBase_C.__PlayKposeEffects_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C022 RID: 180258 RVA: 0x00A11A20 File Offset: 0x00A0FC20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PlayEffect(TSoftObjectPtr<UEffectModelBase> EffectData, [Nullable(2)] USkeletalMeshComponent Component, FName AttachSocket, FTransform Transform)
		{
			BP_KposeBase_C.__PlayEffect_FunctionParams* ptr = stackalloc BP_KposeBase_C.__PlayEffect_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(BP_KposeBase_C.__PlayEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KposeBase_C.__PlayEffect_NativeFunctionPtr, (void*)ptr, 1);
			if (EffectData != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->EffectData, EffectData.NativePtr, 1);
			}
			ptr->Component = ((Component != null) ? Component.NativePtr : IntPtr.Zero);
			ptr->AttachSocket = AttachSocket;
			ptr->Transform = Transform;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__PlayEffect_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KposeBase_C.__PlayEffect_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C023 RID: 180259 RVA: 0x00A11AB4 File Offset: 0x00A0FCB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopEffects()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__StopEffects_NativeFunctionPtr, null);
		}

		// Token: 0x0602C024 RID: 180260 RVA: 0x00A11AC8 File Offset: 0x00A0FCC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602C025 RID: 180261 RVA: 0x00A11ADC File Offset: 0x00A0FCDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KposeBase_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602C026 RID: 180262 RVA: 0x00A11AF1 File Offset: 0x00A0FCF1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602C027 RID: 180263 RVA: 0x00A11B05 File Offset: 0x00A0FD05
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KposeBase_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602C028 RID: 180264 RVA: 0x00A11B1A File Offset: 0x00A0FD1A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void EditorInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x0602C029 RID: 180265 RVA: 0x00A11B2E File Offset: 0x00A0FD2E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void EditorInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KposeBase_C.__EditorInit_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602C02A RID: 180266 RVA: 0x00A11B44 File Offset: 0x00A0FD44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KposeBase_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KposeBase_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KposeBase_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KposeBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C02B RID: 180267 RVA: 0x00A11B90 File Offset: 0x00A0FD90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KposeBase_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KposeBase_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KposeBase_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KposeBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KposeBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602C02C RID: 180268 RVA: 0x00A11BDC File Offset: 0x00A0FDDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KposeBase_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KposeBase_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KposeBase_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KposeBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KposeBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C02D RID: 180269 RVA: 0x00A11C24 File Offset: 0x00A0FE24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KposeBase_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KposeBase_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KposeBase_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KposeBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KposeBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602C02E RID: 180270 RVA: 0x00A11C6B File Offset: 0x00A0FE6B
		protected BP_KposeBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016FB1 RID: 94129
		public new const string __ObjectPath = "/Game/Aki/Character/Kpose/Blueprint/BP_KposeBase.BP_KposeBase_C";

		// Token: 0x04016FB2 RID: 94130
		private static IntPtr _ClassPtr;

		// Token: 0x04016FB3 RID: 94131
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016FB4 RID: 94132
		internal static int __PropertyOffset_1;

		// Token: 0x04016FB5 RID: 94133
		internal static int __PropertyOffset_2;

		// Token: 0x04016FB6 RID: 94134
		internal static int __PropertyOffset_3;

		// Token: 0x04016FB7 RID: 94135
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SKposeEffect> _PermanentEffects;

		// Token: 0x04016FB8 RID: 94136
		internal static int __PropertyOffset_4;

		// Token: 0x04016FB9 RID: 94137
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SKposeEffect> _EffectsOnEnd;

		// Token: 0x04016FBA RID: 94138
		internal static int __PropertyOffset_5;

		// Token: 0x04016FBB RID: 94139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SKposeEffect> _EffectsOnStart;

		// Token: 0x04016FBC RID: 94140
		internal static int __PropertyOffset_6;

		// Token: 0x04016FBD RID: 94141
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRainMaterialFloatParameter> _FloatParameterCurves;

		// Token: 0x04016FBE RID: 94142
		internal static int __PropertyOffset_7;

		// Token: 0x04016FBF RID: 94143
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRainMaterialColorParameter> _ColorParameterCurves;

		// Token: 0x04016FC0 RID: 94144
		internal static int __PropertyOffset_8;

		// Token: 0x04016FC1 RID: 94145
		internal static int __PropertyOffset_9;

		// Token: 0x04016FC2 RID: 94146
		internal static int __PropertyOffset_10;

		// Token: 0x04016FC3 RID: 94147
		[Nullable(2)]
		private TArray<int> _CachedHandles;

		// Token: 0x04016FC4 RID: 94148
		internal static int __PropertyOffset_11;

		// Token: 0x04016FC5 RID: 94149
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _DynamicMaterials;

		// Token: 0x04016FC6 RID: 94150
		internal static int __PropertyOffset_12;

		// Token: 0x04016FC7 RID: 94151
		internal static int __PropertyOffset_13;

		// Token: 0x04016FC8 RID: 94152
		[Nullable(2)]
		private TMap<FName, float> _TempFloatValue;

		// Token: 0x04016FC9 RID: 94153
		internal static int __PropertyOffset_14;

		// Token: 0x04016FCA RID: 94154
		[Nullable(2)]
		private TMap<FName, FLinearColor> _TempColorValue;

		// Token: 0x04016FCB RID: 94155
		internal static int __PropertyOffset_15;

		// Token: 0x04016FCC RID: 94156
		internal static int __PropertyOffset_16;

		// Token: 0x04016FCD RID: 94157
		internal static int __PropertyOffset_17;

		// Token: 0x04016FCE RID: 94158
		internal static int __PropertyOffset_18;

		// Token: 0x04016FCF RID: 94159
		internal static int __PropertyOffset_19;

		// Token: 0x04016FD0 RID: 94160
		internal static int __PropertyOffset_20;

		// Token: 0x04016FD1 RID: 94161
		private static IntPtr __ChangePlatform_NativeFunctionPtr;

		// Token: 0x04016FD2 RID: 94162
		private static IntPtr __PlayEnd_NativeFunctionPtr;

		// Token: 0x04016FD3 RID: 94163
		private static IntPtr __PlayStart_NativeFunctionPtr;

		// Token: 0x04016FD4 RID: 94164
		private static IntPtr __PlayKposeEffects_NativeFunctionPtr;

		// Token: 0x04016FD5 RID: 94165
		private static IntPtr __PlayEffect_NativeFunctionPtr;

		// Token: 0x04016FD6 RID: 94166
		private static IntPtr __StopEffects_NativeFunctionPtr;

		// Token: 0x04016FD7 RID: 94167
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04016FD8 RID: 94168
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04016FD9 RID: 94169
		private static IntPtr __EditorInit_NativeFunctionPtr;

		// Token: 0x04016FDA RID: 94170
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04016FDB RID: 94171
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A5AE RID: 42414
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 352)]
		protected ref struct __PlayKposeEffects_FunctionParams
		{
			// Token: 0x04032442 RID: 205890
			[FieldOffset(0)]
			public byte Data;

			// Token: 0x04032443 RID: 205891
			[FieldOffset(16)]
			public float AutoScale;
		}

		// Token: 0x0200A5AF RID: 42415
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __PlayEffect_FunctionParams
		{
			// Token: 0x04032444 RID: 205892
			[FieldOffset(0)]
			public byte EffectData;

			// Token: 0x04032445 RID: 205893
			[FieldOffset(48)]
			public IntPtr Component;

			// Token: 0x04032446 RID: 205894
			[FieldOffset(56)]
			public FName AttachSocket;

			// Token: 0x04032447 RID: 205895
			[FieldOffset(80)]
			public FTransform Transform;
		}

		// Token: 0x0200A5B0 RID: 42416
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04032448 RID: 205896
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x0200A5B1 RID: 42417
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032449 RID: 205897
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
