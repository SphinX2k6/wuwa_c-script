using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Rain2.Configs;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Rain2
{
	// Token: 0x02003BBF RID: 15295
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/BP_RainComponent_CommonReverse.BP_RainComponent_CommonReverse_C")]
	[UnrealStructLayout(1008, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1000)]
	public class BP_RainComponent_CommonReverse_C : UKuroRainComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022369 RID: 140137 RVA: 0x00902B15 File Offset: 0x00900D15
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RainComponent_CommonReverse_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Rain2/BP_RainComponent_CommonReverse.BP_RainComponent_CommonReverse_C");
			}
			return BP_RainComponent_CommonReverse_C._ClassPtr;
		}

		// Token: 0x0602236A RID: 140138 RVA: 0x00902B3C File Offset: 0x00900D3C
		public BP_RainComponent_CommonReverse_C() : this(BuiltinUtils.AllocNativeUObject(BP_RainComponent_CommonReverse_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602236B RID: 140139 RVA: 0x00902B64 File Offset: 0x00900D64
		public BP_RainComponent_CommonReverse_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RainComponent_CommonReverse_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A4D RID: 14925
		// (get) Token: 0x0602236C RID: 140140 RVA: 0x00902B97 File Offset: 0x00900D97
		// (set) Token: 0x0602236D RID: 140141 RVA: 0x00902BA7 File Offset: 0x00900DA7
		public unsafe int RandomSpawnerHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17003A4E RID: 14926
		// (get) Token: 0x0602236E RID: 140142 RVA: 0x00902BB8 File Offset: 0x00900DB8
		// (set) Token: 0x0602236F RID: 140143 RVA: 0x00902BC8 File Offset: 0x00900DC8
		public unsafe int ArraySpawnerHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003A4F RID: 14927
		// (get) Token: 0x06022370 RID: 140144 RVA: 0x00902BD9 File Offset: 0x00900DD9
		// (set) Token: 0x06022371 RID: 140145 RVA: 0x00902BE9 File Offset: 0x00900DE9
		public unsafe int CycleBoxHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003A50 RID: 14928
		// (get) Token: 0x06022372 RID: 140146 RVA: 0x00902BFA File Offset: 0x00900DFA
		// (set) Token: 0x06022373 RID: 140147 RVA: 0x00902C0E File Offset: 0x00900E0E
		public unsafe FVectorDouble Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003A51 RID: 14929
		// (get) Token: 0x06022374 RID: 140148 RVA: 0x00902C23 File Offset: 0x00900E23
		// (set) Token: 0x06022375 RID: 140149 RVA: 0x00902C33 File Offset: 0x00900E33
		public unsafe int WindHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003A52 RID: 14930
		// (get) Token: 0x06022376 RID: 140150 RVA: 0x00902C44 File Offset: 0x00900E44
		// (set) Token: 0x06022377 RID: 140151 RVA: 0x00902C54 File Offset: 0x00900E54
		public unsafe int GravityHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003A53 RID: 14931
		// (get) Token: 0x06022378 RID: 140152 RVA: 0x00902C65 File Offset: 0x00900E65
		// (set) Token: 0x06022379 RID: 140153 RVA: 0x00902C75 File Offset: 0x00900E75
		public unsafe int DragHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003A54 RID: 14932
		// (get) Token: 0x0602237A RID: 140154 RVA: 0x00902C86 File Offset: 0x00900E86
		// (set) Token: 0x0602237B RID: 140155 RVA: 0x00902C9A File Offset: 0x00900E9A
		public unsafe FVector TempSpawnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003A55 RID: 14933
		// (get) Token: 0x0602237C RID: 140156 RVA: 0x00902CAF File Offset: 0x00900EAF
		// (set) Token: 0x0602237D RID: 140157 RVA: 0x00902CC3 File Offset: 0x00900EC3
		[Nullable(2)]
		public unsafe PDA_RainConfig_CommonReverse_C RainConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_RainConfig_CommonReverse_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RainComponent_CommonReverse_C.__PropertyOffset_9);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RainComponent_CommonReverse_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003A56 RID: 14934
		// (get) Token: 0x0602237E RID: 140158 RVA: 0x00902CD8 File Offset: 0x00900ED8
		// (set) Token: 0x0602237F RID: 140159 RVA: 0x00902D11 File Offset: 0x00900F11
		public TMap<int, int> ArraySpawnerHandles
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._ArraySpawnerHandles) == null)
				{
					result = (this._ArraySpawnerHandles = new TMap<int, int>(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.ArraySpawnerHandles.CopyAssign(value);
			}
		}

		// Token: 0x17003A57 RID: 14935
		// (get) Token: 0x06022380 RID: 140160 RVA: 0x00902D20 File Offset: 0x00900F20
		// (set) Token: 0x06022381 RID: 140161 RVA: 0x00902D59 File Offset: 0x00900F59
		public TMap<int, int> RandomSpawnerHandles
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._RandomSpawnerHandles) == null)
				{
					result = (this._RandomSpawnerHandles = new TMap<int, int>(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.RandomSpawnerHandles.CopyAssign(value);
			}
		}

		// Token: 0x17003A58 RID: 14936
		// (get) Token: 0x06022382 RID: 140162 RVA: 0x00902D67 File Offset: 0x00900F67
		// (set) Token: 0x06022383 RID: 140163 RVA: 0x00902D77 File Offset: 0x00900F77
		public unsafe float PassTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003A59 RID: 14937
		// (get) Token: 0x06022384 RID: 140164 RVA: 0x00902D88 File Offset: 0x00900F88
		// (set) Token: 0x06022385 RID: 140165 RVA: 0x00902D9C File Offset: 0x00900F9C
		public unsafe FVector PerformanceGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003A5A RID: 14938
		// (get) Token: 0x06022386 RID: 140166 RVA: 0x00902DB1 File Offset: 0x00900FB1
		// (set) Token: 0x06022387 RID: 140167 RVA: 0x00902DC1 File Offset: 0x00900FC1
		public unsafe float PerformanceDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003A5B RID: 14939
		// (get) Token: 0x06022388 RID: 140168 RVA: 0x00902DD2 File Offset: 0x00900FD2
		// (set) Token: 0x06022389 RID: 140169 RVA: 0x00902DE6 File Offset: 0x00900FE6
		public unsafe FVector PerformanceWind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003A5C RID: 14940
		// (get) Token: 0x0602238A RID: 140170 RVA: 0x00902DFB File Offset: 0x00900FFB
		// (set) Token: 0x0602238B RID: 140171 RVA: 0x00902E0B File Offset: 0x0090100B
		public unsafe float PerformanceSpawnScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003A5D RID: 14941
		// (get) Token: 0x0602238C RID: 140172 RVA: 0x00902E1C File Offset: 0x0090101C
		// (set) Token: 0x0602238D RID: 140173 RVA: 0x00902E2C File Offset: 0x0090102C
		public unsafe float Shape
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003A5E RID: 14942
		// (get) Token: 0x0602238E RID: 140174 RVA: 0x00902E3D File Offset: 0x0090103D
		// (set) Token: 0x0602238F RID: 140175 RVA: 0x00902E4D File Offset: 0x0090104D
		public unsafe int CustomRandomHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003A5F RID: 14943
		// (get) Token: 0x06022390 RID: 140176 RVA: 0x00902E5E File Offset: 0x0090105E
		// (set) Token: 0x06022391 RID: 140177 RVA: 0x00902E6E File Offset: 0x0090106E
		public unsafe long GravityCurveSampleTaskHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003A60 RID: 14944
		// (get) Token: 0x06022392 RID: 140178 RVA: 0x00902E7F File Offset: 0x0090107F
		// (set) Token: 0x06022393 RID: 140179 RVA: 0x00902E8F File Offset: 0x0090108F
		public unsafe long WindCurveSampleTaskHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003A61 RID: 14945
		// (get) Token: 0x06022394 RID: 140180 RVA: 0x00902EA0 File Offset: 0x009010A0
		// (set) Token: 0x06022395 RID: 140181 RVA: 0x00902EB0 File Offset: 0x009010B0
		public unsafe long DragCurveSampleTaskHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003A62 RID: 14946
		// (get) Token: 0x06022396 RID: 140182 RVA: 0x00902EC1 File Offset: 0x009010C1
		// (set) Token: 0x06022397 RID: 140183 RVA: 0x00902ED1 File Offset: 0x009010D1
		public unsafe long SpawnCurveSampleTaskHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003A63 RID: 14947
		// (get) Token: 0x06022398 RID: 140184 RVA: 0x00902EE2 File Offset: 0x009010E2
		// (set) Token: 0x06022399 RID: 140185 RVA: 0x00902EF2 File Offset: 0x009010F2
		public unsafe float SpawnScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003A64 RID: 14948
		// (get) Token: 0x0602239A RID: 140186 RVA: 0x00902F03 File Offset: 0x00901103
		// (set) Token: 0x0602239B RID: 140187 RVA: 0x00902F13 File Offset: 0x00901113
		public unsafe bool IsPendingDeactivate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A65 RID: 14949
		// (get) Token: 0x0602239C RID: 140188 RVA: 0x00902F24 File Offset: 0x00901124
		// (set) Token: 0x0602239D RID: 140189 RVA: 0x00902F38 File Offset: 0x00901138
		public unsafe FVectorDouble ActualSpawnCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17003A66 RID: 14950
		// (get) Token: 0x0602239E RID: 140190 RVA: 0x00902F4D File Offset: 0x0090114D
		// (set) Token: 0x0602239F RID: 140191 RVA: 0x00902F61 File Offset: 0x00901161
		public unsafe FVector GlobalWind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003A67 RID: 14951
		// (get) Token: 0x060223A0 RID: 140192 RVA: 0x00902F76 File Offset: 0x00901176
		// (set) Token: 0x060223A1 RID: 140193 RVA: 0x00902F86 File Offset: 0x00901186
		public unsafe float GlobalDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17003A68 RID: 14952
		// (get) Token: 0x060223A2 RID: 140194 RVA: 0x00902F97 File Offset: 0x00901197
		// (set) Token: 0x060223A3 RID: 140195 RVA: 0x00902FA7 File Offset: 0x009011A7
		public unsafe long TimeDilationCurveSampleTaskHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17003A69 RID: 14953
		// (get) Token: 0x060223A4 RID: 140196 RVA: 0x00902FB8 File Offset: 0x009011B8
		// (set) Token: 0x060223A5 RID: 140197 RVA: 0x00902FC8 File Offset: 0x009011C8
		public unsafe float VelocitySpawnScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17003A6A RID: 14954
		// (get) Token: 0x060223A6 RID: 140198 RVA: 0x00902FD9 File Offset: 0x009011D9
		// (set) Token: 0x060223A7 RID: 140199 RVA: 0x00902FED File Offset: 0x009011ED
		[Nullable(2)]
		public unsafe UNiagaraComponent NiagaraComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RainComponent_CommonReverse_C.__PropertyOffset_30);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RainComponent_CommonReverse_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x17003A6B RID: 14955
		// (get) Token: 0x060223A8 RID: 140200 RVA: 0x00903002 File Offset: 0x00901202
		// (set) Token: 0x060223A9 RID: 140201 RVA: 0x00903012 File Offset: 0x00901212
		public unsafe bool NiagaraValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A6C RID: 14956
		// (get) Token: 0x060223AA RID: 140202 RVA: 0x00903023 File Offset: 0x00901223
		// (set) Token: 0x060223AB RID: 140203 RVA: 0x00903033 File Offset: 0x00901233
		public unsafe float RainFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x060223AC RID: 140204 RVA: 0x00903044 File Offset: 0x00901244
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DeactivateRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonReverse_C.__DeactivateRain_NativeFunctionPtr, null);
		}

		// Token: 0x060223AD RID: 140205 RVA: 0x00903058 File Offset: 0x00901258
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonReverse_C.__StopRain_NativeFunctionPtr, null);
		}

		// Token: 0x060223AE RID: 140206 RVA: 0x0090306C File Offset: 0x0090126C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Start_Rain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonReverse_C.__Start_Rain_NativeFunctionPtr, null);
		}

		// Token: 0x060223AF RID: 140207 RVA: 0x00903080 File Offset: 0x00901280
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void PreSolveRainParticles(float DeltaSeconds)
		{
			BP_RainComponent_CommonReverse_C.__PreSolveRainParticles_FunctionParams* ptr = stackalloc BP_RainComponent_CommonReverse_C.__PreSolveRainParticles_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RainComponent_CommonReverse_C.__PreSolveRainParticles_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RainComponent_CommonReverse_C.__PreSolveRainParticles_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonReverse_C.__PreSolveRainParticles_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060223B0 RID: 140208 RVA: 0x009030C8 File Offset: 0x009012C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void PreSolveRainParticles_Implementation(float DeltaSeconds)
		{
			BP_RainComponent_CommonReverse_C.__PreSolveRainParticles_FunctionParams* ptr = stackalloc BP_RainComponent_CommonReverse_C.__PreSolveRainParticles_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RainComponent_CommonReverse_C.__PreSolveRainParticles_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RainComponent_CommonReverse_C.__PreSolveRainParticles_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RainComponent_CommonReverse_C.__PreSolveRainParticles_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060223B1 RID: 140209 RVA: 0x0090310F File Offset: 0x0090130F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void SetupRainEmitters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonReverse_C.__SetupRainEmitters_NativeFunctionPtr, null);
		}

		// Token: 0x060223B2 RID: 140210 RVA: 0x00903123 File Offset: 0x00901323
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void SetupRainEmitters_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RainComponent_CommonReverse_C.__SetupRainEmitters_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060223B3 RID: 140211 RVA: 0x00903138 File Offset: 0x00901338
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_RainComponent_CommonReverse_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RainComponent_CommonReverse_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RainComponent_CommonReverse_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RainComponent_CommonReverse_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonReverse_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060223B4 RID: 140212 RVA: 0x00903184 File Offset: 0x00901384
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_RainComponent_CommonReverse_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RainComponent_CommonReverse_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RainComponent_CommonReverse_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RainComponent_CommonReverse_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RainComponent_CommonReverse_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060223B5 RID: 140213 RVA: 0x009031D0 File Offset: 0x009013D0
		protected BP_RainComponent_CommonReverse_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010C47 RID: 68679
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/BP_RainComponent_CommonReverse.BP_RainComponent_CommonReverse_C";

		// Token: 0x04010C48 RID: 68680
		private static IntPtr _ClassPtr;

		// Token: 0x04010C49 RID: 68681
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010C4A RID: 68682
		internal static int __PropertyOffset_1;

		// Token: 0x04010C4B RID: 68683
		internal static int __PropertyOffset_2;

		// Token: 0x04010C4C RID: 68684
		internal static int __PropertyOffset_3;

		// Token: 0x04010C4D RID: 68685
		internal static int __PropertyOffset_4;

		// Token: 0x04010C4E RID: 68686
		internal static int __PropertyOffset_5;

		// Token: 0x04010C4F RID: 68687
		internal static int __PropertyOffset_6;

		// Token: 0x04010C50 RID: 68688
		internal static int __PropertyOffset_7;

		// Token: 0x04010C51 RID: 68689
		internal static int __PropertyOffset_8;

		// Token: 0x04010C52 RID: 68690
		internal static int __PropertyOffset_9;

		// Token: 0x04010C53 RID: 68691
		internal static int __PropertyOffset_10;

		// Token: 0x04010C54 RID: 68692
		[Nullable(2)]
		private TMap<int, int> _ArraySpawnerHandles;

		// Token: 0x04010C55 RID: 68693
		internal static int __PropertyOffset_11;

		// Token: 0x04010C56 RID: 68694
		[Nullable(2)]
		private TMap<int, int> _RandomSpawnerHandles;

		// Token: 0x04010C57 RID: 68695
		internal static int __PropertyOffset_12;

		// Token: 0x04010C58 RID: 68696
		internal static int __PropertyOffset_13;

		// Token: 0x04010C59 RID: 68697
		internal static int __PropertyOffset_14;

		// Token: 0x04010C5A RID: 68698
		internal static int __PropertyOffset_15;

		// Token: 0x04010C5B RID: 68699
		internal static int __PropertyOffset_16;

		// Token: 0x04010C5C RID: 68700
		internal static int __PropertyOffset_17;

		// Token: 0x04010C5D RID: 68701
		internal static int __PropertyOffset_18;

		// Token: 0x04010C5E RID: 68702
		internal static int __PropertyOffset_19;

		// Token: 0x04010C5F RID: 68703
		internal static int __PropertyOffset_20;

		// Token: 0x04010C60 RID: 68704
		internal static int __PropertyOffset_21;

		// Token: 0x04010C61 RID: 68705
		internal static int __PropertyOffset_22;

		// Token: 0x04010C62 RID: 68706
		internal static int __PropertyOffset_23;

		// Token: 0x04010C63 RID: 68707
		internal static int __PropertyOffset_24;

		// Token: 0x04010C64 RID: 68708
		internal static int __PropertyOffset_25;

		// Token: 0x04010C65 RID: 68709
		internal static int __PropertyOffset_26;

		// Token: 0x04010C66 RID: 68710
		internal static int __PropertyOffset_27;

		// Token: 0x04010C67 RID: 68711
		internal static int __PropertyOffset_28;

		// Token: 0x04010C68 RID: 68712
		internal static int __PropertyOffset_29;

		// Token: 0x04010C69 RID: 68713
		internal static int __PropertyOffset_30;

		// Token: 0x04010C6A RID: 68714
		internal static int __PropertyOffset_31;

		// Token: 0x04010C6B RID: 68715
		internal static int __PropertyOffset_32;

		// Token: 0x04010C6C RID: 68716
		private static IntPtr __DeactivateRain_NativeFunctionPtr;

		// Token: 0x04010C6D RID: 68717
		private static IntPtr __StopRain_NativeFunctionPtr;

		// Token: 0x04010C6E RID: 68718
		private static IntPtr __Start_Rain_NativeFunctionPtr;

		// Token: 0x04010C6F RID: 68719
		private static IntPtr __PreSolveRainParticles_NativeFunctionPtr;

		// Token: 0x04010C70 RID: 68720
		private static IntPtr __SetupRainEmitters_NativeFunctionPtr;

		// Token: 0x04010C71 RID: 68721
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009D54 RID: 40276
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __PreSolveRainParticles_FunctionParams
		{
			// Token: 0x040314C8 RID: 201928
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D55 RID: 40277
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040314C9 RID: 201929
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
