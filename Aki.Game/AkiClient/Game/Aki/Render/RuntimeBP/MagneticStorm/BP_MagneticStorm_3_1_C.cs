using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.MagneticStorm.Data;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.MagneticStorm
{
	// Token: 0x02003CEC RID: 15596
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/MagneticStorm/BP_MagneticStorm_3_1.BP_MagneticStorm_3_1_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class BP_MagneticStorm_3_1_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602525B RID: 152155 RVA: 0x0095255D File Offset: 0x0095075D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MagneticStorm_3_1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/MagneticStorm/BP_MagneticStorm_3_1.BP_MagneticStorm_3_1_C");
			}
			return BP_MagneticStorm_3_1_C._ClassPtr;
		}

		// Token: 0x0602525C RID: 152156 RVA: 0x00952584 File Offset: 0x00950784
		public BP_MagneticStorm_3_1_C() : this(BuiltinUtils.AllocNativeUObject(BP_MagneticStorm_3_1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602525D RID: 152157 RVA: 0x009525AC File Offset: 0x009507AC
		[NullableContext(1)]
		public BP_MagneticStorm_3_1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MagneticStorm_3_1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B19 RID: 19225
		// (get) Token: 0x0602525E RID: 152158 RVA: 0x009525DF File Offset: 0x009507DF
		// (set) Token: 0x0602525F RID: 152159 RVA: 0x009525F3 File Offset: 0x009507F3
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_1_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_1_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004B1A RID: 19226
		// (get) Token: 0x06025260 RID: 152160 RVA: 0x00952608 File Offset: 0x00950808
		// (set) Token: 0x06025261 RID: 152161 RVA: 0x0095261C File Offset: 0x0095081C
		public unsafe UNiagaraComponent NS_Fx_SC3_MagneticStorm_Mobile_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_1_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_1_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004B1B RID: 19227
		// (get) Token: 0x06025262 RID: 152162 RVA: 0x00952631 File Offset: 0x00950831
		// (set) Token: 0x06025263 RID: 152163 RVA: 0x00952645 File Offset: 0x00950845
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_1_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_1_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004B1C RID: 19228
		// (get) Token: 0x06025264 RID: 152164 RVA: 0x0095265A File Offset: 0x0095085A
		// (set) Token: 0x06025265 RID: 152165 RVA: 0x0095266E File Offset: 0x0095086E
		public unsafe UNiagaraComponent NS_Fx_MagneticStorm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_1_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_1_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004B1D RID: 19229
		// (get) Token: 0x06025266 RID: 152166 RVA: 0x00952683 File Offset: 0x00950883
		// (set) Token: 0x06025267 RID: 152167 RVA: 0x00952697 File Offset: 0x00950897
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_1_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_1_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004B1E RID: 19230
		// (get) Token: 0x06025268 RID: 152168 RVA: 0x009526AC File Offset: 0x009508AC
		// (set) Token: 0x06025269 RID: 152169 RVA: 0x009526C0 File Offset: 0x009508C0
		public unsafe FVector WroldOriginLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004B1F RID: 19231
		// (get) Token: 0x0602526A RID: 152170 RVA: 0x009526D5 File Offset: 0x009508D5
		// (set) Token: 0x0602526B RID: 152171 RVA: 0x009526E5 File Offset: 0x009508E5
		public unsafe bool DisplayShockwave
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B20 RID: 19232
		// (get) Token: 0x0602526C RID: 152172 RVA: 0x009526F6 File Offset: 0x009508F6
		// (set) Token: 0x0602526D RID: 152173 RVA: 0x00952706 File Offset: 0x00950906
		public unsafe bool DisplayParticle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B21 RID: 19233
		// (get) Token: 0x0602526E RID: 152174 RVA: 0x00952717 File Offset: 0x00950917
		// (set) Token: 0x0602526F RID: 152175 RVA: 0x00952727 File Offset: 0x00950927
		public unsafe bool DisplayPointLattice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B22 RID: 19234
		// (get) Token: 0x06025270 RID: 152176 RVA: 0x00952738 File Offset: 0x00950938
		// (set) Token: 0x06025271 RID: 152177 RVA: 0x00952748 File Offset: 0x00950948
		public unsafe bool bInTheArea
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B23 RID: 19235
		// (get) Token: 0x06025272 RID: 152178 RVA: 0x00952759 File Offset: 0x00950959
		// (set) Token: 0x06025273 RID: 152179 RVA: 0x0095276D File Offset: 0x0095096D
		[Nullable(0)]
		public unsafe TEnumAsByte<E_MagneticStorm_RegionType> RegionType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_11);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004B24 RID: 19236
		// (get) Token: 0x06025274 RID: 152180 RVA: 0x00952782 File Offset: 0x00950982
		// (set) Token: 0x06025275 RID: 152181 RVA: 0x00952792 File Offset: 0x00950992
		public unsafe bool DisplaySphereMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B25 RID: 19237
		// (get) Token: 0x06025276 RID: 152182 RVA: 0x009527A3 File Offset: 0x009509A3
		// (set) Token: 0x06025277 RID: 152183 RVA: 0x009527B3 File Offset: 0x009509B3
		public unsafe float AttenuationDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004B26 RID: 19238
		// (get) Token: 0x06025278 RID: 152184 RVA: 0x009527C4 File Offset: 0x009509C4
		// (set) Token: 0x06025279 RID: 152185 RVA: 0x009527D4 File Offset: 0x009509D4
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004B27 RID: 19239
		// (get) Token: 0x0602527A RID: 152186 RVA: 0x009527E5 File Offset: 0x009509E5
		// (set) Token: 0x0602527B RID: 152187 RVA: 0x009527F5 File Offset: 0x009509F5
		public unsafe bool DisplayPrint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B28 RID: 19240
		// (get) Token: 0x0602527C RID: 152188 RVA: 0x00952806 File Offset: 0x00950A06
		// (set) Token: 0x0602527D RID: 152189 RVA: 0x00952816 File Offset: 0x00950A16
		public unsafe float PointLatticeOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004B29 RID: 19241
		// (get) Token: 0x0602527E RID: 152190 RVA: 0x00952827 File Offset: 0x00950A27
		// (set) Token: 0x0602527F RID: 152191 RVA: 0x00952837 File Offset: 0x00950A37
		public unsafe float ShockwaveFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004B2A RID: 19242
		// (get) Token: 0x06025280 RID: 152192 RVA: 0x00952848 File Offset: 0x00950A48
		// (set) Token: 0x06025281 RID: 152193 RVA: 0x00952858 File Offset: 0x00950A58
		public unsafe float ShockwaveIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004B2B RID: 19243
		// (get) Token: 0x06025282 RID: 152194 RVA: 0x00952869 File Offset: 0x00950A69
		// (set) Token: 0x06025283 RID: 152195 RVA: 0x00952879 File Offset: 0x00950A79
		public unsafe float ParticleOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004B2C RID: 19244
		// (get) Token: 0x06025284 RID: 152196 RVA: 0x0095288A File Offset: 0x00950A8A
		// (set) Token: 0x06025285 RID: 152197 RVA: 0x0095289A File Offset: 0x00950A9A
		public unsafe bool UseColorParam
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B2D RID: 19245
		// (get) Token: 0x06025286 RID: 152198 RVA: 0x009528AB File Offset: 0x00950AAB
		// (set) Token: 0x06025287 RID: 152199 RVA: 0x009528BB File Offset: 0x00950ABB
		public unsafe float InTheAreaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004B2E RID: 19246
		// (get) Token: 0x06025288 RID: 152200 RVA: 0x009528CC File Offset: 0x00950ACC
		// (set) Token: 0x06025289 RID: 152201 RVA: 0x009528DC File Offset: 0x00950ADC
		public unsafe bool bSetParamFromSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B2F RID: 19247
		// (get) Token: 0x0602528A RID: 152202 RVA: 0x009528ED File Offset: 0x00950AED
		// (set) Token: 0x0602528B RID: 152203 RVA: 0x00952901 File Offset: 0x00950B01
		public unsafe FVector OriginLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004B30 RID: 19248
		// (get) Token: 0x0602528C RID: 152204 RVA: 0x00952916 File Offset: 0x00950B16
		// (set) Token: 0x0602528D RID: 152205 RVA: 0x0095292A File Offset: 0x00950B2A
		public unsafe FLinearColor PointLatticeColor01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004B31 RID: 19249
		// (get) Token: 0x0602528E RID: 152206 RVA: 0x0095293F File Offset: 0x00950B3F
		// (set) Token: 0x0602528F RID: 152207 RVA: 0x00952953 File Offset: 0x00950B53
		public unsafe FLinearColor PointLatticeColor02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004B32 RID: 19250
		// (get) Token: 0x06025290 RID: 152208 RVA: 0x00952968 File Offset: 0x00950B68
		// (set) Token: 0x06025291 RID: 152209 RVA: 0x0095297C File Offset: 0x00950B7C
		public unsafe FLinearColor LightningColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004B33 RID: 19251
		// (get) Token: 0x06025292 RID: 152210 RVA: 0x00952991 File Offset: 0x00950B91
		// (set) Token: 0x06025293 RID: 152211 RVA: 0x009529A5 File Offset: 0x00950BA5
		public unsafe FLinearColor ParticlesColor_Lizi_01_Mobile_PC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17004B34 RID: 19252
		// (get) Token: 0x06025294 RID: 152212 RVA: 0x009529BA File Offset: 0x00950BBA
		// (set) Token: 0x06025295 RID: 152213 RVA: 0x009529CE File Offset: 0x00950BCE
		public unsafe FLinearColor ParticlesColor_Lizi_02_Mobile_PC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17004B35 RID: 19253
		// (get) Token: 0x06025296 RID: 152214 RVA: 0x009529E3 File Offset: 0x00950BE3
		// (set) Token: 0x06025297 RID: 152215 RVA: 0x009529F7 File Offset: 0x00950BF7
		public unsafe FLinearColor ParticlesColor_Fire_PC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004B36 RID: 19254
		// (get) Token: 0x06025298 RID: 152216 RVA: 0x00952A0C File Offset: 0x00950C0C
		// (set) Token: 0x06025299 RID: 152217 RVA: 0x00952A20 File Offset: 0x00950C20
		public unsafe FLinearColor ParticlesColor_FireEdge_PC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_1_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x0602529A RID: 152218 RVA: 0x00952A35 File Offset: 0x00950C35
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitNS()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__InitNS_NativeFunctionPtr, null);
		}

		// Token: 0x0602529B RID: 152219 RVA: 0x00952A49 File Offset: 0x00950C49
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FadeIn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__FadeIn_NativeFunctionPtr, null);
		}

		// Token: 0x0602529C RID: 152220 RVA: 0x00952A5D File Offset: 0x00950C5D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__SetParam_NativeFunctionPtr, null);
		}

		// Token: 0x0602529D RID: 152221 RVA: 0x00952A71 File Offset: 0x00950C71
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateNS()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__UpdateNS_NativeFunctionPtr, null);
		}

		// Token: 0x0602529E RID: 152222 RVA: 0x00952A85 File Offset: 0x00950C85
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RemoveParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__RemoveParam_NativeFunctionPtr, null);
		}

		// Token: 0x0602529F RID: 152223 RVA: 0x00952A99 File Offset: 0x00950C99
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseAllMagneticStorm()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__CloseAllMagneticStorm_NativeFunctionPtr, null);
		}

		// Token: 0x060252A0 RID: 152224 RVA: 0x00952AB0 File Offset: 0x00950CB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InTheBox(FVector pos, ref bool IntheBox)
		{
			BP_MagneticStorm_3_1_C.__InTheBox_FunctionParams* ptr = stackalloc BP_MagneticStorm_3_1_C.__InTheBox_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_MagneticStorm_3_1_C.__InTheBox_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_3_1_C.__InTheBox_NativeFunctionPtr, (void*)ptr, 1);
			ptr->pos = pos;
			ptr->IntheBox = IntheBox;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__InTheBox_NativeFunctionPtr, (void*)ptr);
			IntheBox = ptr->IntheBox;
		}

		// Token: 0x060252A1 RID: 152225 RVA: 0x00952B06 File Offset: 0x00950D06
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OpenMagneticStorm()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__OpenMagneticStorm_NativeFunctionPtr, null);
		}

		// Token: 0x060252A2 RID: 152226 RVA: 0x00952B1A File Offset: 0x00950D1A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__UpdateParam_NativeFunctionPtr, null);
		}

		// Token: 0x060252A3 RID: 152227 RVA: 0x00952B2E File Offset: 0x00950D2E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__InitParam_NativeFunctionPtr, null);
		}

		// Token: 0x060252A4 RID: 152228 RVA: 0x00952B42 File Offset: 0x00950D42
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060252A5 RID: 152229 RVA: 0x00952B56 File Offset: 0x00950D56
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060252A6 RID: 152230 RVA: 0x00952B6B File Offset: 0x00950D6B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060252A7 RID: 152231 RVA: 0x00952B7F File Offset: 0x00950D7F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060252A8 RID: 152232 RVA: 0x00952B94 File Offset: 0x00950D94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MagneticStorm_3_1_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MagneticStorm_3_1_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MagneticStorm_3_1_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_3_1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060252A9 RID: 152233 RVA: 0x00952BDC File Offset: 0x00950DDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MagneticStorm_3_1_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MagneticStorm_3_1_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MagneticStorm_3_1_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_3_1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060252AA RID: 152234 RVA: 0x00952C23 File Offset: 0x00950E23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__CustomTick_NativeFunctionPtr, null);
		}

		// Token: 0x060252AB RID: 152235 RVA: 0x00952C37 File Offset: 0x00950E37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x060252AC RID: 152236 RVA: 0x00952C4B File Offset: 0x00950E4B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060252AD RID: 152237 RVA: 0x00952C60 File Offset: 0x00950E60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_MagneticStorm_3_1_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_MagneticStorm_3_1_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MagneticStorm_3_1_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_3_1_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060252AE RID: 152238 RVA: 0x00952CAC File Offset: 0x00950EAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_MagneticStorm_3_1_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_MagneticStorm_3_1_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MagneticStorm_3_1_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_3_1_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060252AF RID: 152239 RVA: 0x00952CF8 File Offset: 0x00950EF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParamFromSeq()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_1_C.__SetParamFromSeq_NativeFunctionPtr, null);
		}

		// Token: 0x060252B0 RID: 152240 RVA: 0x00952D0C File Offset: 0x00950F0C
		protected BP_MagneticStorm_3_1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040127F6 RID: 75766
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/MagneticStorm/BP_MagneticStorm_3_1.BP_MagneticStorm_3_1_C";

		// Token: 0x040127F7 RID: 75767
		private static IntPtr _ClassPtr;

		// Token: 0x040127F8 RID: 75768
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040127F9 RID: 75769
		internal static int __PropertyOffset_1;

		// Token: 0x040127FA RID: 75770
		internal static int __PropertyOffset_2;

		// Token: 0x040127FB RID: 75771
		internal static int __PropertyOffset_3;

		// Token: 0x040127FC RID: 75772
		internal static int __PropertyOffset_4;

		// Token: 0x040127FD RID: 75773
		internal static int __PropertyOffset_5;

		// Token: 0x040127FE RID: 75774
		internal static int __PropertyOffset_6;

		// Token: 0x040127FF RID: 75775
		internal static int __PropertyOffset_7;

		// Token: 0x04012800 RID: 75776
		internal static int __PropertyOffset_8;

		// Token: 0x04012801 RID: 75777
		internal static int __PropertyOffset_9;

		// Token: 0x04012802 RID: 75778
		internal static int __PropertyOffset_10;

		// Token: 0x04012803 RID: 75779
		internal static int __PropertyOffset_11;

		// Token: 0x04012804 RID: 75780
		internal static int __PropertyOffset_12;

		// Token: 0x04012805 RID: 75781
		internal static int __PropertyOffset_13;

		// Token: 0x04012806 RID: 75782
		internal static int __PropertyOffset_14;

		// Token: 0x04012807 RID: 75783
		internal static int __PropertyOffset_15;

		// Token: 0x04012808 RID: 75784
		internal static int __PropertyOffset_16;

		// Token: 0x04012809 RID: 75785
		internal static int __PropertyOffset_17;

		// Token: 0x0401280A RID: 75786
		internal static int __PropertyOffset_18;

		// Token: 0x0401280B RID: 75787
		internal static int __PropertyOffset_19;

		// Token: 0x0401280C RID: 75788
		internal static int __PropertyOffset_20;

		// Token: 0x0401280D RID: 75789
		internal static int __PropertyOffset_21;

		// Token: 0x0401280E RID: 75790
		internal static int __PropertyOffset_22;

		// Token: 0x0401280F RID: 75791
		internal static int __PropertyOffset_23;

		// Token: 0x04012810 RID: 75792
		internal static int __PropertyOffset_24;

		// Token: 0x04012811 RID: 75793
		internal static int __PropertyOffset_25;

		// Token: 0x04012812 RID: 75794
		internal static int __PropertyOffset_26;

		// Token: 0x04012813 RID: 75795
		internal static int __PropertyOffset_27;

		// Token: 0x04012814 RID: 75796
		internal static int __PropertyOffset_28;

		// Token: 0x04012815 RID: 75797
		internal static int __PropertyOffset_29;

		// Token: 0x04012816 RID: 75798
		internal static int __PropertyOffset_30;

		// Token: 0x04012817 RID: 75799
		private static IntPtr __InitNS_NativeFunctionPtr;

		// Token: 0x04012818 RID: 75800
		private static IntPtr __FadeIn_NativeFunctionPtr;

		// Token: 0x04012819 RID: 75801
		private static IntPtr __SetParam_NativeFunctionPtr;

		// Token: 0x0401281A RID: 75802
		private static IntPtr __UpdateNS_NativeFunctionPtr;

		// Token: 0x0401281B RID: 75803
		private static IntPtr __RemoveParam_NativeFunctionPtr;

		// Token: 0x0401281C RID: 75804
		private static IntPtr __CloseAllMagneticStorm_NativeFunctionPtr;

		// Token: 0x0401281D RID: 75805
		private static IntPtr __InTheBox_NativeFunctionPtr;

		// Token: 0x0401281E RID: 75806
		private static IntPtr __OpenMagneticStorm_NativeFunctionPtr;

		// Token: 0x0401281F RID: 75807
		private static IntPtr __UpdateParam_NativeFunctionPtr;

		// Token: 0x04012820 RID: 75808
		private static IntPtr __InitParam_NativeFunctionPtr;

		// Token: 0x04012821 RID: 75809
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012822 RID: 75810
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012823 RID: 75811
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012824 RID: 75812
		private static IntPtr __CustomTick_NativeFunctionPtr;

		// Token: 0x04012825 RID: 75813
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x04012826 RID: 75814
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04012827 RID: 75815
		private static IntPtr __SetParamFromSeq_NativeFunctionPtr;

		// Token: 0x02009FBA RID: 40890
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __InTheBox_FunctionParams
		{
			// Token: 0x04031A1B RID: 203291
			[FieldOffset(0)]
			public FVector pos;

			// Token: 0x04031A1C RID: 203292
			[FieldOffset(12)]
			public bool IntheBox;
		}

		// Token: 0x02009FBB RID: 40891
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A1D RID: 203293
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FBC RID: 40892
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031A1E RID: 203294
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
