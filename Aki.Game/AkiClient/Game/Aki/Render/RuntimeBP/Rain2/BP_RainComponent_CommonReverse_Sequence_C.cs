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
	// Token: 0x02003BC0 RID: 15296
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/BP_RainComponent_CommonReverse_Sequence.BP_RainComponent_CommonReverse_Sequence_C")]
	[UnrealStructLayout(944, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 941)]
	public class BP_RainComponent_CommonReverse_Sequence_C : UKuroRainComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060223B6 RID: 140214 RVA: 0x009031D9 File Offset: 0x009013D9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RainComponent_CommonReverse_Sequence_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Rain2/BP_RainComponent_CommonReverse_Sequence.BP_RainComponent_CommonReverse_Sequence_C");
			}
			return BP_RainComponent_CommonReverse_Sequence_C._ClassPtr;
		}

		// Token: 0x060223B7 RID: 140215 RVA: 0x00903200 File Offset: 0x00901400
		public BP_RainComponent_CommonReverse_Sequence_C() : this(BuiltinUtils.AllocNativeUObject(BP_RainComponent_CommonReverse_Sequence_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060223B8 RID: 140216 RVA: 0x00903228 File Offset: 0x00901428
		public BP_RainComponent_CommonReverse_Sequence_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RainComponent_CommonReverse_Sequence_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A6D RID: 14957
		// (get) Token: 0x060223B9 RID: 140217 RVA: 0x0090325B File Offset: 0x0090145B
		// (set) Token: 0x060223BA RID: 140218 RVA: 0x0090326B File Offset: 0x0090146B
		public unsafe int RandomSpawnerHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17003A6E RID: 14958
		// (get) Token: 0x060223BB RID: 140219 RVA: 0x0090327C File Offset: 0x0090147C
		// (set) Token: 0x060223BC RID: 140220 RVA: 0x0090328C File Offset: 0x0090148C
		public unsafe int ArraySpawnerHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003A6F RID: 14959
		// (get) Token: 0x060223BD RID: 140221 RVA: 0x0090329D File Offset: 0x0090149D
		// (set) Token: 0x060223BE RID: 140222 RVA: 0x009032AD File Offset: 0x009014AD
		public unsafe int CycleBoxHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003A70 RID: 14960
		// (get) Token: 0x060223BF RID: 140223 RVA: 0x009032BE File Offset: 0x009014BE
		// (set) Token: 0x060223C0 RID: 140224 RVA: 0x009032D2 File Offset: 0x009014D2
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003A71 RID: 14961
		// (get) Token: 0x060223C1 RID: 140225 RVA: 0x009032E7 File Offset: 0x009014E7
		// (set) Token: 0x060223C2 RID: 140226 RVA: 0x009032F7 File Offset: 0x009014F7
		public unsafe int WindHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003A72 RID: 14962
		// (get) Token: 0x060223C3 RID: 140227 RVA: 0x00903308 File Offset: 0x00901508
		// (set) Token: 0x060223C4 RID: 140228 RVA: 0x00903318 File Offset: 0x00901518
		public unsafe int GravityHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003A73 RID: 14963
		// (get) Token: 0x060223C5 RID: 140229 RVA: 0x00903329 File Offset: 0x00901529
		// (set) Token: 0x060223C6 RID: 140230 RVA: 0x00903339 File Offset: 0x00901539
		public unsafe int DragHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003A74 RID: 14964
		// (get) Token: 0x060223C7 RID: 140231 RVA: 0x0090334A File Offset: 0x0090154A
		// (set) Token: 0x060223C8 RID: 140232 RVA: 0x0090335E File Offset: 0x0090155E
		public unsafe FVector TempSpawnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003A75 RID: 14965
		// (get) Token: 0x060223C9 RID: 140233 RVA: 0x00903373 File Offset: 0x00901573
		// (set) Token: 0x060223CA RID: 140234 RVA: 0x00903387 File Offset: 0x00901587
		[Nullable(2)]
		public unsafe PDA_RainConfig_CommonReverse_C RainConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_RainConfig_CommonReverse_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_9);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003A76 RID: 14966
		// (get) Token: 0x060223CB RID: 140235 RVA: 0x0090339C File Offset: 0x0090159C
		// (set) Token: 0x060223CC RID: 140236 RVA: 0x009033D5 File Offset: 0x009015D5
		public TMap<int, int> ArraySpawnerHandles
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._ArraySpawnerHandles) == null)
				{
					result = (this._ArraySpawnerHandles = new TMap<int, int>(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.ArraySpawnerHandles.CopyAssign(value);
			}
		}

		// Token: 0x17003A77 RID: 14967
		// (get) Token: 0x060223CD RID: 140237 RVA: 0x009033E4 File Offset: 0x009015E4
		// (set) Token: 0x060223CE RID: 140238 RVA: 0x0090341D File Offset: 0x0090161D
		public TMap<int, int> RandomSpawnerHandles
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._RandomSpawnerHandles) == null)
				{
					result = (this._RandomSpawnerHandles = new TMap<int, int>(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.RandomSpawnerHandles.CopyAssign(value);
			}
		}

		// Token: 0x17003A78 RID: 14968
		// (get) Token: 0x060223CF RID: 140239 RVA: 0x0090342B File Offset: 0x0090162B
		// (set) Token: 0x060223D0 RID: 140240 RVA: 0x0090343F File Offset: 0x0090163F
		public unsafe FVector PerformanceGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003A79 RID: 14969
		// (get) Token: 0x060223D1 RID: 140241 RVA: 0x00903454 File Offset: 0x00901654
		// (set) Token: 0x060223D2 RID: 140242 RVA: 0x00903464 File Offset: 0x00901664
		public unsafe float PerformanceDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003A7A RID: 14970
		// (get) Token: 0x060223D3 RID: 140243 RVA: 0x00903475 File Offset: 0x00901675
		// (set) Token: 0x060223D4 RID: 140244 RVA: 0x00903489 File Offset: 0x00901689
		public unsafe FVector PerformanceWind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003A7B RID: 14971
		// (get) Token: 0x060223D5 RID: 140245 RVA: 0x0090349E File Offset: 0x0090169E
		// (set) Token: 0x060223D6 RID: 140246 RVA: 0x009034AE File Offset: 0x009016AE
		public unsafe float PerformanceSpawnScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003A7C RID: 14972
		// (get) Token: 0x060223D7 RID: 140247 RVA: 0x009034BF File Offset: 0x009016BF
		// (set) Token: 0x060223D8 RID: 140248 RVA: 0x009034CF File Offset: 0x009016CF
		public unsafe int CustomRandomHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003A7D RID: 14973
		// (get) Token: 0x060223D9 RID: 140249 RVA: 0x009034E0 File Offset: 0x009016E0
		// (set) Token: 0x060223DA RID: 140250 RVA: 0x009034F0 File Offset: 0x009016F0
		public unsafe long GravityCurveSampleTaskHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003A7E RID: 14974
		// (get) Token: 0x060223DB RID: 140251 RVA: 0x00903501 File Offset: 0x00901701
		// (set) Token: 0x060223DC RID: 140252 RVA: 0x00903511 File Offset: 0x00901711
		public unsafe long WindCurveSampleTaskHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003A7F RID: 14975
		// (get) Token: 0x060223DD RID: 140253 RVA: 0x00903522 File Offset: 0x00901722
		// (set) Token: 0x060223DE RID: 140254 RVA: 0x00903532 File Offset: 0x00901732
		public unsafe long DragCurveSampleTaskHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003A80 RID: 14976
		// (get) Token: 0x060223DF RID: 140255 RVA: 0x00903543 File Offset: 0x00901743
		// (set) Token: 0x060223E0 RID: 140256 RVA: 0x00903553 File Offset: 0x00901753
		public unsafe long SpawnCurveSampleTaskHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003A81 RID: 14977
		// (get) Token: 0x060223E1 RID: 140257 RVA: 0x00903564 File Offset: 0x00901764
		// (set) Token: 0x060223E2 RID: 140258 RVA: 0x00903574 File Offset: 0x00901774
		public unsafe float SpawnScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003A82 RID: 14978
		// (get) Token: 0x060223E3 RID: 140259 RVA: 0x00903585 File Offset: 0x00901785
		// (set) Token: 0x060223E4 RID: 140260 RVA: 0x00903595 File Offset: 0x00901795
		public unsafe bool IsPendingDeactivate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A83 RID: 14979
		// (get) Token: 0x060223E5 RID: 140261 RVA: 0x009035A6 File Offset: 0x009017A6
		// (set) Token: 0x060223E6 RID: 140262 RVA: 0x009035BA File Offset: 0x009017BA
		public unsafe FVector ActualSpawnCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003A84 RID: 14980
		// (get) Token: 0x060223E7 RID: 140263 RVA: 0x009035CF File Offset: 0x009017CF
		// (set) Token: 0x060223E8 RID: 140264 RVA: 0x009035DF File Offset: 0x009017DF
		public unsafe long TimeDilationCurveSampleTaskHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003A85 RID: 14981
		// (get) Token: 0x060223E9 RID: 140265 RVA: 0x009035F0 File Offset: 0x009017F0
		// (set) Token: 0x060223EA RID: 140266 RVA: 0x00903600 File Offset: 0x00901800
		public unsafe float VelocitySpawnScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17003A86 RID: 14982
		// (get) Token: 0x060223EB RID: 140267 RVA: 0x00903611 File Offset: 0x00901811
		// (set) Token: 0x060223EC RID: 140268 RVA: 0x00903621 File Offset: 0x00901821
		public unsafe float RainFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003A87 RID: 14983
		// (get) Token: 0x060223ED RID: 140269 RVA: 0x00903632 File Offset: 0x00901832
		// (set) Token: 0x060223EE RID: 140270 RVA: 0x00903642 File Offset: 0x00901842
		public unsafe float PerformanceTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17003A88 RID: 14984
		// (get) Token: 0x060223EF RID: 140271 RVA: 0x00903653 File Offset: 0x00901853
		// (set) Token: 0x060223F0 RID: 140272 RVA: 0x00903663 File Offset: 0x00901863
		public unsafe bool StartOnBeginPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonReverse_Sequence_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x060223F1 RID: 140273 RVA: 0x00903674 File Offset: 0x00901874
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DeactivateRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonReverse_Sequence_C.__DeactivateRain_NativeFunctionPtr, null);
		}

		// Token: 0x060223F2 RID: 140274 RVA: 0x00903688 File Offset: 0x00901888
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonReverse_Sequence_C.__StopRain_NativeFunctionPtr, null);
		}

		// Token: 0x060223F3 RID: 140275 RVA: 0x0090369C File Offset: 0x0090189C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Start_Rain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonReverse_Sequence_C.__Start_Rain_NativeFunctionPtr, null);
		}

		// Token: 0x060223F4 RID: 140276 RVA: 0x009036B0 File Offset: 0x009018B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void PreSolveRainParticles(float DeltaSeconds)
		{
			BP_RainComponent_CommonReverse_Sequence_C.__PreSolveRainParticles_FunctionParams* ptr = stackalloc BP_RainComponent_CommonReverse_Sequence_C.__PreSolveRainParticles_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RainComponent_CommonReverse_Sequence_C.__PreSolveRainParticles_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RainComponent_CommonReverse_Sequence_C.__PreSolveRainParticles_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonReverse_Sequence_C.__PreSolveRainParticles_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060223F5 RID: 140277 RVA: 0x009036F8 File Offset: 0x009018F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void PreSolveRainParticles_Implementation(float DeltaSeconds)
		{
			BP_RainComponent_CommonReverse_Sequence_C.__PreSolveRainParticles_FunctionParams* ptr = stackalloc BP_RainComponent_CommonReverse_Sequence_C.__PreSolveRainParticles_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RainComponent_CommonReverse_Sequence_C.__PreSolveRainParticles_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RainComponent_CommonReverse_Sequence_C.__PreSolveRainParticles_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RainComponent_CommonReverse_Sequence_C.__PreSolveRainParticles_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060223F6 RID: 140278 RVA: 0x0090373F File Offset: 0x0090193F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void SetupRainEmitters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonReverse_Sequence_C.__SetupRainEmitters_NativeFunctionPtr, null);
		}

		// Token: 0x060223F7 RID: 140279 RVA: 0x00903753 File Offset: 0x00901953
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void SetupRainEmitters_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RainComponent_CommonReverse_Sequence_C.__SetupRainEmitters_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060223F8 RID: 140280 RVA: 0x00903768 File Offset: 0x00901968
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_RainComponent_CommonReverse_Sequence_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RainComponent_CommonReverse_Sequence_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RainComponent_CommonReverse_Sequence_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RainComponent_CommonReverse_Sequence_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonReverse_Sequence_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060223F9 RID: 140281 RVA: 0x009037B4 File Offset: 0x009019B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_RainComponent_CommonReverse_Sequence_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RainComponent_CommonReverse_Sequence_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RainComponent_CommonReverse_Sequence_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RainComponent_CommonReverse_Sequence_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RainComponent_CommonReverse_Sequence_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060223FA RID: 140282 RVA: 0x00903800 File Offset: 0x00901A00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonReverse_Sequence_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060223FB RID: 140283 RVA: 0x00903814 File Offset: 0x00901A14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RainComponent_CommonReverse_Sequence_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060223FC RID: 140284 RVA: 0x00903829 File Offset: 0x00901A29
		protected BP_RainComponent_CommonReverse_Sequence_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010C72 RID: 68722
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/BP_RainComponent_CommonReverse_Sequence.BP_RainComponent_CommonReverse_Sequence_C";

		// Token: 0x04010C73 RID: 68723
		private static IntPtr _ClassPtr;

		// Token: 0x04010C74 RID: 68724
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010C75 RID: 68725
		internal static int __PropertyOffset_1;

		// Token: 0x04010C76 RID: 68726
		internal static int __PropertyOffset_2;

		// Token: 0x04010C77 RID: 68727
		internal static int __PropertyOffset_3;

		// Token: 0x04010C78 RID: 68728
		internal static int __PropertyOffset_4;

		// Token: 0x04010C79 RID: 68729
		internal static int __PropertyOffset_5;

		// Token: 0x04010C7A RID: 68730
		internal static int __PropertyOffset_6;

		// Token: 0x04010C7B RID: 68731
		internal static int __PropertyOffset_7;

		// Token: 0x04010C7C RID: 68732
		internal static int __PropertyOffset_8;

		// Token: 0x04010C7D RID: 68733
		internal static int __PropertyOffset_9;

		// Token: 0x04010C7E RID: 68734
		internal static int __PropertyOffset_10;

		// Token: 0x04010C7F RID: 68735
		[Nullable(2)]
		private TMap<int, int> _ArraySpawnerHandles;

		// Token: 0x04010C80 RID: 68736
		internal static int __PropertyOffset_11;

		// Token: 0x04010C81 RID: 68737
		[Nullable(2)]
		private TMap<int, int> _RandomSpawnerHandles;

		// Token: 0x04010C82 RID: 68738
		internal static int __PropertyOffset_12;

		// Token: 0x04010C83 RID: 68739
		internal static int __PropertyOffset_13;

		// Token: 0x04010C84 RID: 68740
		internal static int __PropertyOffset_14;

		// Token: 0x04010C85 RID: 68741
		internal static int __PropertyOffset_15;

		// Token: 0x04010C86 RID: 68742
		internal static int __PropertyOffset_16;

		// Token: 0x04010C87 RID: 68743
		internal static int __PropertyOffset_17;

		// Token: 0x04010C88 RID: 68744
		internal static int __PropertyOffset_18;

		// Token: 0x04010C89 RID: 68745
		internal static int __PropertyOffset_19;

		// Token: 0x04010C8A RID: 68746
		internal static int __PropertyOffset_20;

		// Token: 0x04010C8B RID: 68747
		internal static int __PropertyOffset_21;

		// Token: 0x04010C8C RID: 68748
		internal static int __PropertyOffset_22;

		// Token: 0x04010C8D RID: 68749
		internal static int __PropertyOffset_23;

		// Token: 0x04010C8E RID: 68750
		internal static int __PropertyOffset_24;

		// Token: 0x04010C8F RID: 68751
		internal static int __PropertyOffset_25;

		// Token: 0x04010C90 RID: 68752
		internal static int __PropertyOffset_26;

		// Token: 0x04010C91 RID: 68753
		internal static int __PropertyOffset_27;

		// Token: 0x04010C92 RID: 68754
		internal static int __PropertyOffset_28;

		// Token: 0x04010C93 RID: 68755
		private static IntPtr __DeactivateRain_NativeFunctionPtr;

		// Token: 0x04010C94 RID: 68756
		private static IntPtr __StopRain_NativeFunctionPtr;

		// Token: 0x04010C95 RID: 68757
		private static IntPtr __Start_Rain_NativeFunctionPtr;

		// Token: 0x04010C96 RID: 68758
		private static IntPtr __PreSolveRainParticles_NativeFunctionPtr;

		// Token: 0x04010C97 RID: 68759
		private static IntPtr __SetupRainEmitters_NativeFunctionPtr;

		// Token: 0x04010C98 RID: 68760
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04010C99 RID: 68761
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009D56 RID: 40278
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __PreSolveRainParticles_FunctionParams
		{
			// Token: 0x040314CA RID: 201930
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D57 RID: 40279
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040314CB RID: 201931
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
