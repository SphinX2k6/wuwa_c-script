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
	// Token: 0x02003CEB RID: 15595
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/MagneticStorm/BP_MagneticStorm_3_0.BP_MagneticStorm_3_0_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class BP_MagneticStorm_3_0_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025218 RID: 152088 RVA: 0x00951F1F File Offset: 0x0095011F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MagneticStorm_3_0_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/MagneticStorm/BP_MagneticStorm_3_0.BP_MagneticStorm_3_0_C");
			}
			return BP_MagneticStorm_3_0_C._ClassPtr;
		}

		// Token: 0x06025219 RID: 152089 RVA: 0x00951F44 File Offset: 0x00950144
		public BP_MagneticStorm_3_0_C() : this(BuiltinUtils.AllocNativeUObject(BP_MagneticStorm_3_0_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602521A RID: 152090 RVA: 0x00951F6C File Offset: 0x0095016C
		[NullableContext(1)]
		public BP_MagneticStorm_3_0_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MagneticStorm_3_0_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B04 RID: 19204
		// (get) Token: 0x0602521B RID: 152091 RVA: 0x00951F9F File Offset: 0x0095019F
		// (set) Token: 0x0602521C RID: 152092 RVA: 0x00951FB3 File Offset: 0x009501B3
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_0_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_0_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004B05 RID: 19205
		// (get) Token: 0x0602521D RID: 152093 RVA: 0x00951FC8 File Offset: 0x009501C8
		// (set) Token: 0x0602521E RID: 152094 RVA: 0x00951FDC File Offset: 0x009501DC
		public unsafe UNiagaraComponent NS_Fx_SC3_MagneticStorm_Mobile_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_0_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_0_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004B06 RID: 19206
		// (get) Token: 0x0602521F RID: 152095 RVA: 0x00951FF1 File Offset: 0x009501F1
		// (set) Token: 0x06025220 RID: 152096 RVA: 0x00952005 File Offset: 0x00950205
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_0_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_0_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004B07 RID: 19207
		// (get) Token: 0x06025221 RID: 152097 RVA: 0x0095201A File Offset: 0x0095021A
		// (set) Token: 0x06025222 RID: 152098 RVA: 0x0095202E File Offset: 0x0095022E
		public unsafe UNiagaraComponent NS_Fx_MagneticStorm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_0_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_0_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004B08 RID: 19208
		// (get) Token: 0x06025223 RID: 152099 RVA: 0x00952043 File Offset: 0x00950243
		// (set) Token: 0x06025224 RID: 152100 RVA: 0x00952057 File Offset: 0x00950257
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_0_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MagneticStorm_3_0_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004B09 RID: 19209
		// (get) Token: 0x06025225 RID: 152101 RVA: 0x0095206C File Offset: 0x0095026C
		// (set) Token: 0x06025226 RID: 152102 RVA: 0x00952080 File Offset: 0x00950280
		public unsafe FVector WroldOriginLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004B0A RID: 19210
		// (get) Token: 0x06025227 RID: 152103 RVA: 0x00952095 File Offset: 0x00950295
		// (set) Token: 0x06025228 RID: 152104 RVA: 0x009520A5 File Offset: 0x009502A5
		public unsafe bool DisplayShockwave
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B0B RID: 19211
		// (get) Token: 0x06025229 RID: 152105 RVA: 0x009520B6 File Offset: 0x009502B6
		// (set) Token: 0x0602522A RID: 152106 RVA: 0x009520C6 File Offset: 0x009502C6
		public unsafe bool DisplayParticle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B0C RID: 19212
		// (get) Token: 0x0602522B RID: 152107 RVA: 0x009520D7 File Offset: 0x009502D7
		// (set) Token: 0x0602522C RID: 152108 RVA: 0x009520E7 File Offset: 0x009502E7
		public unsafe bool DisplayPointLattice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B0D RID: 19213
		// (get) Token: 0x0602522D RID: 152109 RVA: 0x009520F8 File Offset: 0x009502F8
		// (set) Token: 0x0602522E RID: 152110 RVA: 0x00952108 File Offset: 0x00950308
		public unsafe bool bInTheArea
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B0E RID: 19214
		// (get) Token: 0x0602522F RID: 152111 RVA: 0x00952119 File Offset: 0x00950319
		// (set) Token: 0x06025230 RID: 152112 RVA: 0x0095212D File Offset: 0x0095032D
		[Nullable(0)]
		public unsafe TEnumAsByte<E_MagneticStorm_RegionType> RegionType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_11);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004B0F RID: 19215
		// (get) Token: 0x06025231 RID: 152113 RVA: 0x00952142 File Offset: 0x00950342
		// (set) Token: 0x06025232 RID: 152114 RVA: 0x00952152 File Offset: 0x00950352
		public unsafe bool DisplaySphereMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B10 RID: 19216
		// (get) Token: 0x06025233 RID: 152115 RVA: 0x00952163 File Offset: 0x00950363
		// (set) Token: 0x06025234 RID: 152116 RVA: 0x00952173 File Offset: 0x00950373
		public unsafe float AttenuationDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004B11 RID: 19217
		// (get) Token: 0x06025235 RID: 152117 RVA: 0x00952184 File Offset: 0x00950384
		// (set) Token: 0x06025236 RID: 152118 RVA: 0x00952194 File Offset: 0x00950394
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004B12 RID: 19218
		// (get) Token: 0x06025237 RID: 152119 RVA: 0x009521A5 File Offset: 0x009503A5
		// (set) Token: 0x06025238 RID: 152120 RVA: 0x009521B5 File Offset: 0x009503B5
		public unsafe bool DisplayPrint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B13 RID: 19219
		// (get) Token: 0x06025239 RID: 152121 RVA: 0x009521C6 File Offset: 0x009503C6
		// (set) Token: 0x0602523A RID: 152122 RVA: 0x009521D6 File Offset: 0x009503D6
		public unsafe float PointLatticeOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004B14 RID: 19220
		// (get) Token: 0x0602523B RID: 152123 RVA: 0x009521E7 File Offset: 0x009503E7
		// (set) Token: 0x0602523C RID: 152124 RVA: 0x009521F7 File Offset: 0x009503F7
		public unsafe float ShockwaveIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004B15 RID: 19221
		// (get) Token: 0x0602523D RID: 152125 RVA: 0x00952208 File Offset: 0x00950408
		// (set) Token: 0x0602523E RID: 152126 RVA: 0x00952218 File Offset: 0x00950418
		public unsafe float ParticleOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004B16 RID: 19222
		// (get) Token: 0x0602523F RID: 152127 RVA: 0x00952229 File Offset: 0x00950429
		// (set) Token: 0x06025240 RID: 152128 RVA: 0x00952239 File Offset: 0x00950439
		public unsafe float InTheAreaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004B17 RID: 19223
		// (get) Token: 0x06025241 RID: 152129 RVA: 0x0095224A File Offset: 0x0095044A
		// (set) Token: 0x06025242 RID: 152130 RVA: 0x0095225A File Offset: 0x0095045A
		public unsafe bool bSetParamFromSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004B18 RID: 19224
		// (get) Token: 0x06025243 RID: 152131 RVA: 0x0095226B File Offset: 0x0095046B
		// (set) Token: 0x06025244 RID: 152132 RVA: 0x0095227F File Offset: 0x0095047F
		public unsafe FVector OriginLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MagneticStorm_3_0_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x06025245 RID: 152133 RVA: 0x00952294 File Offset: 0x00950494
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FadeIn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__FadeIn_NativeFunctionPtr, null);
		}

		// Token: 0x06025246 RID: 152134 RVA: 0x009522A8 File Offset: 0x009504A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__SetParam_NativeFunctionPtr, null);
		}

		// Token: 0x06025247 RID: 152135 RVA: 0x009522BC File Offset: 0x009504BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateNS()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__UpdateNS_NativeFunctionPtr, null);
		}

		// Token: 0x06025248 RID: 152136 RVA: 0x009522D0 File Offset: 0x009504D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RemoveParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__RemoveParam_NativeFunctionPtr, null);
		}

		// Token: 0x06025249 RID: 152137 RVA: 0x009522E4 File Offset: 0x009504E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseAllMagneticStorm()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__CloseAllMagneticStorm_NativeFunctionPtr, null);
		}

		// Token: 0x0602524A RID: 152138 RVA: 0x009522F8 File Offset: 0x009504F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InTheBox(FVector pos, ref bool IntheBox)
		{
			BP_MagneticStorm_3_0_C.__InTheBox_FunctionParams* ptr = stackalloc BP_MagneticStorm_3_0_C.__InTheBox_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_MagneticStorm_3_0_C.__InTheBox_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_3_0_C.__InTheBox_NativeFunctionPtr, (void*)ptr, 1);
			ptr->pos = pos;
			ptr->IntheBox = IntheBox;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__InTheBox_NativeFunctionPtr, (void*)ptr);
			IntheBox = ptr->IntheBox;
		}

		// Token: 0x0602524B RID: 152139 RVA: 0x0095234E File Offset: 0x0095054E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OpenMagneticStorm()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__OpenMagneticStorm_NativeFunctionPtr, null);
		}

		// Token: 0x0602524C RID: 152140 RVA: 0x00952362 File Offset: 0x00950562
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__UpdateParam_NativeFunctionPtr, null);
		}

		// Token: 0x0602524D RID: 152141 RVA: 0x00952376 File Offset: 0x00950576
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__InitParam_NativeFunctionPtr, null);
		}

		// Token: 0x0602524E RID: 152142 RVA: 0x0095238A File Offset: 0x0095058A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602524F RID: 152143 RVA: 0x0095239E File Offset: 0x0095059E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025250 RID: 152144 RVA: 0x009523B3 File Offset: 0x009505B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025251 RID: 152145 RVA: 0x009523C7 File Offset: 0x009505C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025252 RID: 152146 RVA: 0x009523DC File Offset: 0x009505DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MagneticStorm_3_0_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MagneticStorm_3_0_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MagneticStorm_3_0_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_3_0_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025253 RID: 152147 RVA: 0x00952424 File Offset: 0x00950624
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MagneticStorm_3_0_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MagneticStorm_3_0_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MagneticStorm_3_0_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_3_0_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025254 RID: 152148 RVA: 0x0095246B File Offset: 0x0095066B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__CustomTick_NativeFunctionPtr, null);
		}

		// Token: 0x06025255 RID: 152149 RVA: 0x0095247F File Offset: 0x0095067F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06025256 RID: 152150 RVA: 0x00952493 File Offset: 0x00950693
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025257 RID: 152151 RVA: 0x009524A8 File Offset: 0x009506A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_MagneticStorm_3_0_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_MagneticStorm_3_0_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MagneticStorm_3_0_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_3_0_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025258 RID: 152152 RVA: 0x009524F4 File Offset: 0x009506F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_MagneticStorm_3_0_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_MagneticStorm_3_0_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MagneticStorm_3_0_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MagneticStorm_3_0_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025259 RID: 152153 RVA: 0x00952540 File Offset: 0x00950740
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParamFromSeq()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MagneticStorm_3_0_C.__SetParamFromSeq_NativeFunctionPtr, null);
		}

		// Token: 0x0602525A RID: 152154 RVA: 0x00952554 File Offset: 0x00950754
		protected BP_MagneticStorm_3_0_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040127CE RID: 75726
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/MagneticStorm/BP_MagneticStorm_3_0.BP_MagneticStorm_3_0_C";

		// Token: 0x040127CF RID: 75727
		private static IntPtr _ClassPtr;

		// Token: 0x040127D0 RID: 75728
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040127D1 RID: 75729
		internal static int __PropertyOffset_1;

		// Token: 0x040127D2 RID: 75730
		internal static int __PropertyOffset_2;

		// Token: 0x040127D3 RID: 75731
		internal static int __PropertyOffset_3;

		// Token: 0x040127D4 RID: 75732
		internal static int __PropertyOffset_4;

		// Token: 0x040127D5 RID: 75733
		internal static int __PropertyOffset_5;

		// Token: 0x040127D6 RID: 75734
		internal static int __PropertyOffset_6;

		// Token: 0x040127D7 RID: 75735
		internal static int __PropertyOffset_7;

		// Token: 0x040127D8 RID: 75736
		internal static int __PropertyOffset_8;

		// Token: 0x040127D9 RID: 75737
		internal static int __PropertyOffset_9;

		// Token: 0x040127DA RID: 75738
		internal static int __PropertyOffset_10;

		// Token: 0x040127DB RID: 75739
		internal static int __PropertyOffset_11;

		// Token: 0x040127DC RID: 75740
		internal static int __PropertyOffset_12;

		// Token: 0x040127DD RID: 75741
		internal static int __PropertyOffset_13;

		// Token: 0x040127DE RID: 75742
		internal static int __PropertyOffset_14;

		// Token: 0x040127DF RID: 75743
		internal static int __PropertyOffset_15;

		// Token: 0x040127E0 RID: 75744
		internal static int __PropertyOffset_16;

		// Token: 0x040127E1 RID: 75745
		internal static int __PropertyOffset_17;

		// Token: 0x040127E2 RID: 75746
		internal static int __PropertyOffset_18;

		// Token: 0x040127E3 RID: 75747
		internal static int __PropertyOffset_19;

		// Token: 0x040127E4 RID: 75748
		internal static int __PropertyOffset_20;

		// Token: 0x040127E5 RID: 75749
		internal static int __PropertyOffset_21;

		// Token: 0x040127E6 RID: 75750
		private static IntPtr __FadeIn_NativeFunctionPtr;

		// Token: 0x040127E7 RID: 75751
		private static IntPtr __SetParam_NativeFunctionPtr;

		// Token: 0x040127E8 RID: 75752
		private static IntPtr __UpdateNS_NativeFunctionPtr;

		// Token: 0x040127E9 RID: 75753
		private static IntPtr __RemoveParam_NativeFunctionPtr;

		// Token: 0x040127EA RID: 75754
		private static IntPtr __CloseAllMagneticStorm_NativeFunctionPtr;

		// Token: 0x040127EB RID: 75755
		private static IntPtr __InTheBox_NativeFunctionPtr;

		// Token: 0x040127EC RID: 75756
		private static IntPtr __OpenMagneticStorm_NativeFunctionPtr;

		// Token: 0x040127ED RID: 75757
		private static IntPtr __UpdateParam_NativeFunctionPtr;

		// Token: 0x040127EE RID: 75758
		private static IntPtr __InitParam_NativeFunctionPtr;

		// Token: 0x040127EF RID: 75759
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040127F0 RID: 75760
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040127F1 RID: 75761
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040127F2 RID: 75762
		private static IntPtr __CustomTick_NativeFunctionPtr;

		// Token: 0x040127F3 RID: 75763
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x040127F4 RID: 75764
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x040127F5 RID: 75765
		private static IntPtr __SetParamFromSeq_NativeFunctionPtr;

		// Token: 0x02009FB7 RID: 40887
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __InTheBox_FunctionParams
		{
			// Token: 0x04031A17 RID: 203287
			[FieldOffset(0)]
			public FVector pos;

			// Token: 0x04031A18 RID: 203288
			[FieldOffset(12)]
			public bool IntheBox;
		}

		// Token: 0x02009FB8 RID: 40888
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A19 RID: 203289
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FB9 RID: 40889
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031A1A RID: 203290
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
