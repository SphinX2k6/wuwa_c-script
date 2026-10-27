using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common
{
	// Token: 0x02003B63 RID: 15203
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/BP_SplineLights.BP_SplineLights_C")]
	[UnrealStructLayout(2024, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2020)]
	public class BP_SplineLights_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06021BD3 RID: 138195 RVA: 0x008F4930 File Offset: 0x008F2B30
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplineLights_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_SplineLights.BP_SplineLights_C");
			}
			return BP_SplineLights_C._ClassPtr;
		}

		// Token: 0x06021BD4 RID: 138196 RVA: 0x008F4954 File Offset: 0x008F2B54
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_SplineLights_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06021BD5 RID: 138197 RVA: 0x008F495C File Offset: 0x008F2B5C
		public BP_SplineLights_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplineLights_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021BD6 RID: 138198 RVA: 0x008F4984 File Offset: 0x008F2B84
		public BP_SplineLights_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplineLights_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x06021BD7 RID: 138199 RVA: 0x008F49B7 File Offset: 0x008F2BB7
		// (set) Token: 0x06021BD8 RID: 138200 RVA: 0x008F49CB File Offset: 0x008F2BCB
		[Nullable(2)]
		public unsafe USplineComponent Spline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineLights_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineLights_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x06021BD9 RID: 138201 RVA: 0x008F49E0 File Offset: 0x008F2BE0
		// (set) Token: 0x06021BDA RID: 138202 RVA: 0x008F49F4 File Offset: 0x008F2BF4
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineLights_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineLights_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x06021BDB RID: 138203 RVA: 0x008F4A09 File Offset: 0x008F2C09
		// (set) Token: 0x06021BDC RID: 138204 RVA: 0x008F4A19 File Offset: 0x008F2C19
		public unsafe float Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x06021BDD RID: 138205 RVA: 0x008F4A2A File Offset: 0x008F2C2A
		// (set) Token: 0x06021BDE RID: 138206 RVA: 0x008F4A3E File Offset: 0x008F2C3E
		public unsafe FLinearColor LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x06021BDF RID: 138207 RVA: 0x008F4A53 File Offset: 0x008F2C53
		// (set) Token: 0x06021BE0 RID: 138208 RVA: 0x008F4A63 File Offset: 0x008F2C63
		public unsafe float LightFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x06021BE1 RID: 138209 RVA: 0x008F4A74 File Offset: 0x008F2C74
		// (set) Token: 0x06021BE2 RID: 138210 RVA: 0x008F4A84 File Offset: 0x008F2C84
		public unsafe float 高光度范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003810 RID: 14352
		// (get) Token: 0x06021BE3 RID: 138211 RVA: 0x008F4A95 File Offset: 0x008F2C95
		// (set) Token: 0x06021BE4 RID: 138212 RVA: 0x008F4AA5 File Offset: 0x008F2CA5
		public unsafe float 源半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003811 RID: 14353
		// (get) Token: 0x06021BE5 RID: 138213 RVA: 0x008F4AB6 File Offset: 0x008F2CB6
		// (set) Token: 0x06021BE6 RID: 138214 RVA: 0x008F4AC6 File Offset: 0x008F2CC6
		public unsafe float 软源半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x06021BE7 RID: 138215 RVA: 0x008F4AD7 File Offset: 0x008F2CD7
		// (set) Token: 0x06021BE8 RID: 138216 RVA: 0x008F4AE7 File Offset: 0x008F2CE7
		public unsafe float 源长度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x06021BE9 RID: 138217 RVA: 0x008F4AF8 File Offset: 0x008F2CF8
		// (set) Token: 0x06021BEA RID: 138218 RVA: 0x008F4B31 File Offset: 0x008F2D31
		public FKuroCurveFloat LightsIntensityCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._LightsIntensityCurve) == null)
				{
					result = (this._LightsIntensityCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x06021BEB RID: 138219 RVA: 0x008F4B54 File Offset: 0x008F2D54
		// (set) Token: 0x06021BEC RID: 138220 RVA: 0x008F4B8D File Offset: 0x008F2D8D
		public FKuroCurveFloat LightsRadiusCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._LightsRadiusCurve) == null)
				{
					result = (this._LightsRadiusCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x06021BED RID: 138221 RVA: 0x008F4BAE File Offset: 0x008F2DAE
		// (set) Token: 0x06021BEE RID: 138222 RVA: 0x008F4BBE File Offset: 0x008F2DBE
		public unsafe float CurveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x06021BEF RID: 138223 RVA: 0x008F4BCF File Offset: 0x008F2DCF
		// (set) Token: 0x06021BF0 RID: 138224 RVA: 0x008F4BDF File Offset: 0x008F2DDF
		public unsafe float RadiusScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003817 RID: 14359
		// (get) Token: 0x06021BF1 RID: 138225 RVA: 0x008F4BF0 File Offset: 0x008F2DF0
		// (set) Token: 0x06021BF2 RID: 138226 RVA: 0x008F4C00 File Offset: 0x008F2E00
		public unsafe float IntensityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003818 RID: 14360
		// (get) Token: 0x06021BF3 RID: 138227 RVA: 0x008F4C11 File Offset: 0x008F2E11
		// (set) Token: 0x06021BF4 RID: 138228 RVA: 0x008F4C21 File Offset: 0x008F2E21
		public unsafe float LightGenerateIntervalMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x06021BF5 RID: 138229 RVA: 0x008F4C32 File Offset: 0x008F2E32
		// (set) Token: 0x06021BF6 RID: 138230 RVA: 0x008F4C42 File Offset: 0x008F2E42
		public unsafe float LightGenerateIntervalMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x06021BF7 RID: 138231 RVA: 0x008F4C53 File Offset: 0x008F2E53
		// (set) Token: 0x06021BF8 RID: 138232 RVA: 0x008F4C63 File Offset: 0x008F2E63
		public unsafe float LightLifeTimeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x06021BF9 RID: 138233 RVA: 0x008F4C74 File Offset: 0x008F2E74
		// (set) Token: 0x06021BFA RID: 138234 RVA: 0x008F4C84 File Offset: 0x008F2E84
		public unsafe float LightLifeTimeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700381C RID: 14364
		// (get) Token: 0x06021BFB RID: 138235 RVA: 0x008F4C98 File Offset: 0x008F2E98
		// (set) Token: 0x06021BFC RID: 138236 RVA: 0x008F4CD1 File Offset: 0x008F2ED1
		public FKuroCurveFloat IntensityMask
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._IntensityMask) == null)
				{
					result = (this._IntensityMask = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_19, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700381D RID: 14365
		// (get) Token: 0x06021BFD RID: 138237 RVA: 0x008F4CF2 File Offset: 0x008F2EF2
		// (set) Token: 0x06021BFE RID: 138238 RVA: 0x008F4D02 File Offset: 0x008F2F02
		public unsafe float LightGenerationCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x06021BFF RID: 138239 RVA: 0x008F4D14 File Offset: 0x008F2F14
		// (set) Token: 0x06021C00 RID: 138240 RVA: 0x008F4D4D File Offset: 0x008F2F4D
		public TArray<UPointLightComponent> PointLightsPool
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPointLightComponent> result;
				if ((result = this._PointLightsPool) == null)
				{
					result = (this._PointLightsPool = new TArray<UPointLightComponent>(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_21, this));
				}
				return result;
			}
			set
			{
				this.PointLightsPool.CopyAssign(value);
			}
		}

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x06021C01 RID: 138241 RVA: 0x008F4D5C File Offset: 0x008F2F5C
		// (set) Token: 0x06021C02 RID: 138242 RVA: 0x008F4D95 File Offset: 0x008F2F95
		public TArray<SSpineLightRuntimeData> RuntimeLightsData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSpineLightRuntimeData> result;
				if ((result = this._RuntimeLightsData) == null)
				{
					result = (this._RuntimeLightsData = new TArray<SSpineLightRuntimeData>(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_22, this));
				}
				return result;
			}
			set
			{
				this.RuntimeLightsData.CopyAssign(value);
			}
		}

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x06021C03 RID: 138243 RVA: 0x008F4DA3 File Offset: 0x008F2FA3
		// (set) Token: 0x06021C04 RID: 138244 RVA: 0x008F4DB3 File Offset: 0x008F2FB3
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x06021C05 RID: 138245 RVA: 0x008F4DC4 File Offset: 0x008F2FC4
		// (set) Token: 0x06021C06 RID: 138246 RVA: 0x008F4DD4 File Offset: 0x008F2FD4
		public unsafe bool GenerateAtNightOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x06021C07 RID: 138247 RVA: 0x008F4DE5 File Offset: 0x008F2FE5
		// (set) Token: 0x06021C08 RID: 138248 RVA: 0x008F4DF5 File Offset: 0x008F2FF5
		public unsafe bool OverrideSuperFarActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x06021C09 RID: 138249 RVA: 0x008F4E06 File Offset: 0x008F3006
		// (set) Token: 0x06021C0A RID: 138250 RVA: 0x008F4E16 File Offset: 0x008F3016
		public unsafe bool SpecialBlueprintActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineLights_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021C0B RID: 138251 RVA: 0x008F4E28 File Offset: 0x008F3028
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_SplineLights_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_SplineLights_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineLights_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineLights_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineLights_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021C0C RID: 138252 RVA: 0x008F4E70 File Offset: 0x008F3070
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_SplineLights_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_SplineLights_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineLights_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineLights_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineLights_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021C0D RID: 138253 RVA: 0x008F4EB6 File Offset: 0x008F30B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineLights_C.__UpdateEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06021C0E RID: 138254 RVA: 0x008F4ECC File Offset: 0x008F30CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RecycleLight(int RemoveIndex)
		{
			BP_SplineLights_C.__RecycleLight_FunctionParams* ptr = stackalloc BP_SplineLights_C.__RecycleLight_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_SplineLights_C.__RecycleLight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineLights_C.__RecycleLight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RemoveIndex = RemoveIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineLights_C.__RecycleLight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C0F RID: 138255 RVA: 0x008F4F12 File Offset: 0x008F3112
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLifeTime()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineLights_C.__UpdateLifeTime_NativeFunctionPtr, null);
		}

		// Token: 0x06021C10 RID: 138256 RVA: 0x008F4F26 File Offset: 0x008F3126
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GenerateLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineLights_C.__GenerateLight_NativeFunctionPtr, null);
		}

		// Token: 0x06021C11 RID: 138257 RVA: 0x008F4F3A File Offset: 0x008F313A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateGeneration()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineLights_C.__UpdateGeneration_NativeFunctionPtr, null);
		}

		// Token: 0x06021C12 RID: 138258 RVA: 0x008F4F4E File Offset: 0x008F314E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineLights_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x06021C13 RID: 138259 RVA: 0x008F4F62 File Offset: 0x008F3162
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineLights_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021C14 RID: 138260 RVA: 0x008F4F76 File Offset: 0x008F3176
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineLights_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021C15 RID: 138261 RVA: 0x008F4F8C File Offset: 0x008F318C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SplineLights_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplineLights_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineLights_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineLights_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineLights_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C16 RID: 138262 RVA: 0x008F4FD4 File Offset: 0x008F31D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SplineLights_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplineLights_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineLights_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineLights_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineLights_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021C17 RID: 138263 RVA: 0x008F501C File Offset: 0x008F321C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SplineLights_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplineLights_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineLights_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineLights_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineLights_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C18 RID: 138264 RVA: 0x008F5064 File Offset: 0x008F3264
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SplineLights_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplineLights_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineLights_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineLights_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineLights_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021C19 RID: 138265 RVA: 0x008F50AB File Offset: 0x008F32AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineLights_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021C1A RID: 138266 RVA: 0x008F50BF File Offset: 0x008F32BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineLights_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021C1B RID: 138267 RVA: 0x008F50D4 File Offset: 0x008F32D4
		protected BP_SplineLights_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010772 RID: 67442
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x04010773 RID: 67443
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_SplineLights.BP_SplineLights_C";

		// Token: 0x04010774 RID: 67444
		private static IntPtr _ClassPtr;

		// Token: 0x04010775 RID: 67445
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010776 RID: 67446
		internal static int __PropertyOffset_1;

		// Token: 0x04010777 RID: 67447
		internal static int __PropertyOffset_2;

		// Token: 0x04010778 RID: 67448
		internal static int __PropertyOffset_3;

		// Token: 0x04010779 RID: 67449
		internal static int __PropertyOffset_4;

		// Token: 0x0401077A RID: 67450
		internal static int __PropertyOffset_5;

		// Token: 0x0401077B RID: 67451
		internal static int __PropertyOffset_6;

		// Token: 0x0401077C RID: 67452
		internal static int __PropertyOffset_7;

		// Token: 0x0401077D RID: 67453
		internal static int __PropertyOffset_8;

		// Token: 0x0401077E RID: 67454
		internal static int __PropertyOffset_9;

		// Token: 0x0401077F RID: 67455
		internal static int __PropertyOffset_10;

		// Token: 0x04010780 RID: 67456
		[Nullable(2)]
		private FKuroCurveFloat _LightsIntensityCurve;

		// Token: 0x04010781 RID: 67457
		internal static int __PropertyOffset_11;

		// Token: 0x04010782 RID: 67458
		[Nullable(2)]
		private FKuroCurveFloat _LightsRadiusCurve;

		// Token: 0x04010783 RID: 67459
		internal static int __PropertyOffset_12;

		// Token: 0x04010784 RID: 67460
		internal static int __PropertyOffset_13;

		// Token: 0x04010785 RID: 67461
		internal static int __PropertyOffset_14;

		// Token: 0x04010786 RID: 67462
		internal static int __PropertyOffset_15;

		// Token: 0x04010787 RID: 67463
		internal static int __PropertyOffset_16;

		// Token: 0x04010788 RID: 67464
		internal static int __PropertyOffset_17;

		// Token: 0x04010789 RID: 67465
		internal static int __PropertyOffset_18;

		// Token: 0x0401078A RID: 67466
		internal static int __PropertyOffset_19;

		// Token: 0x0401078B RID: 67467
		[Nullable(2)]
		private FKuroCurveFloat _IntensityMask;

		// Token: 0x0401078C RID: 67468
		internal static int __PropertyOffset_20;

		// Token: 0x0401078D RID: 67469
		internal static int __PropertyOffset_21;

		// Token: 0x0401078E RID: 67470
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPointLightComponent> _PointLightsPool;

		// Token: 0x0401078F RID: 67471
		internal static int __PropertyOffset_22;

		// Token: 0x04010790 RID: 67472
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSpineLightRuntimeData> _RuntimeLightsData;

		// Token: 0x04010791 RID: 67473
		internal static int __PropertyOffset_23;

		// Token: 0x04010792 RID: 67474
		internal static int __PropertyOffset_24;

		// Token: 0x04010793 RID: 67475
		internal static int __PropertyOffset_25;

		// Token: 0x04010794 RID: 67476
		internal static int __PropertyOffset_26;

		// Token: 0x04010795 RID: 67477
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x04010796 RID: 67478
		private static IntPtr __UpdateEffect_NativeFunctionPtr;

		// Token: 0x04010797 RID: 67479
		private static IntPtr __RecycleLight_NativeFunctionPtr;

		// Token: 0x04010798 RID: 67480
		private static IntPtr __UpdateLifeTime_NativeFunctionPtr;

		// Token: 0x04010799 RID: 67481
		private static IntPtr __GenerateLight_NativeFunctionPtr;

		// Token: 0x0401079A RID: 67482
		private static IntPtr __UpdateGeneration_NativeFunctionPtr;

		// Token: 0x0401079B RID: 67483
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x0401079C RID: 67484
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401079D RID: 67485
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401079E RID: 67486
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401079F RID: 67487
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009CCA RID: 40138
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x040313AF RID: 201647
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009CCB RID: 40139
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __RecycleLight_FunctionParams
		{
			// Token: 0x040313B0 RID: 201648
			[FieldOffset(0)]
			public int RemoveIndex;
		}

		// Token: 0x02009CCC RID: 40140
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040313B1 RID: 201649
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009CCD RID: 40141
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040313B2 RID: 201650
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
