using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B13 RID: 15123
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_MediaBurning.BP_MediaBurning_C")]
	[UnrealStructLayout(1808, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1808)]
	public class BP_MediaBurning_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021059 RID: 135257 RVA: 0x008E2DCC File Offset: 0x008E0FCC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MediaBurning_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_MediaBurning.BP_MediaBurning_C");
			}
			return BP_MediaBurning_C._ClassPtr;
		}

		// Token: 0x0602105A RID: 135258 RVA: 0x008E2DF0 File Offset: 0x008E0FF0
		public BP_MediaBurning_C() : this(BuiltinUtils.AllocNativeUObject(BP_MediaBurning_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602105B RID: 135259 RVA: 0x008E2E18 File Offset: 0x008E1018
		[NullableContext(1)]
		public BP_MediaBurning_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MediaBurning_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0602105C RID: 135260 RVA: 0x008E2E4B File Offset: 0x008E104B
		// (set) Token: 0x0602105D RID: 135261 RVA: 0x008E2E5F File Offset: 0x008E105F
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaBurning_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaBurning_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0602105E RID: 135262 RVA: 0x008E2E74 File Offset: 0x008E1074
		// (set) Token: 0x0602105F RID: 135263 RVA: 0x008E2E88 File Offset: 0x008E1088
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaBurning_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaBurning_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x06021060 RID: 135264 RVA: 0x008E2E9D File Offset: 0x008E109D
		// (set) Token: 0x06021061 RID: 135265 RVA: 0x008E2EB1 File Offset: 0x008E10B1
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaBurning_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaBurning_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x06021062 RID: 135266 RVA: 0x008E2EC8 File Offset: 0x008E10C8
		// (set) Token: 0x06021063 RID: 135267 RVA: 0x008E2F01 File Offset: 0x008E1101
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x06021064 RID: 135268 RVA: 0x008E2F10 File Offset: 0x008E1110
		// (set) Token: 0x06021065 RID: 135269 RVA: 0x008E2F49 File Offset: 0x008E1149
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x06021066 RID: 135270 RVA: 0x008E2F58 File Offset: 0x008E1158
		// (set) Token: 0x06021067 RID: 135271 RVA: 0x008E2F91 File Offset: 0x008E1191
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x06021068 RID: 135272 RVA: 0x008E2F9F File Offset: 0x008E119F
		// (set) Token: 0x06021069 RID: 135273 RVA: 0x008E2FB3 File Offset: 0x008E11B3
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaBurning_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaBurning_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0602106A RID: 135274 RVA: 0x008E2FC8 File Offset: 0x008E11C8
		// (set) Token: 0x0602106B RID: 135275 RVA: 0x008E2FD8 File Offset: 0x008E11D8
		public unsafe float FireIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0602106C RID: 135276 RVA: 0x008E2FE9 File Offset: 0x008E11E9
		// (set) Token: 0x0602106D RID: 135277 RVA: 0x008E2FF9 File Offset: 0x008E11F9
		public unsafe float NumSamples
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0602106E RID: 135278 RVA: 0x008E300A File Offset: 0x008E120A
		// (set) Token: 0x0602106F RID: 135279 RVA: 0x008E301E File Offset: 0x008E121E
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x06021070 RID: 135280 RVA: 0x008E3033 File Offset: 0x008E1233
		// (set) Token: 0x06021071 RID: 135281 RVA: 0x008E3043 File Offset: 0x008E1243
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x06021072 RID: 135282 RVA: 0x008E3054 File Offset: 0x008E1254
		// (set) Token: 0x06021073 RID: 135283 RVA: 0x008E3064 File Offset: 0x008E1264
		public unsafe float SkyRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x06021074 RID: 135284 RVA: 0x008E3075 File Offset: 0x008E1275
		// (set) Token: 0x06021075 RID: 135285 RVA: 0x008E3085 File Offset: 0x008E1285
		public unsafe float SkyDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x06021076 RID: 135286 RVA: 0x008E3096 File Offset: 0x008E1296
		// (set) Token: 0x06021077 RID: 135287 RVA: 0x008E30A6 File Offset: 0x008E12A6
		public unsafe float TangFreq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x06021078 RID: 135288 RVA: 0x008E30B7 File Offset: 0x008E12B7
		// (set) Token: 0x06021079 RID: 135289 RVA: 0x008E30C7 File Offset: 0x008E12C7
		public unsafe float NoiseScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0602107A RID: 135290 RVA: 0x008E30D8 File Offset: 0x008E12D8
		// (set) Token: 0x0602107B RID: 135291 RVA: 0x008E30E8 File Offset: 0x008E12E8
		public unsafe bool EnableSimLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0602107C RID: 135292 RVA: 0x008E30F9 File Offset: 0x008E12F9
		// (set) Token: 0x0602107D RID: 135293 RVA: 0x008E3109 File Offset: 0x008E1309
		public unsafe float Soft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0602107E RID: 135294 RVA: 0x008E311A File Offset: 0x008E131A
		// (set) Token: 0x0602107F RID: 135295 RVA: 0x008E312A File Offset: 0x008E132A
		public unsafe float WarpStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x06021080 RID: 135296 RVA: 0x008E313B File Offset: 0x008E133B
		// (set) Token: 0x06021081 RID: 135297 RVA: 0x008E314B File Offset: 0x008E134B
		public unsafe float ShapeAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x06021082 RID: 135298 RVA: 0x008E315C File Offset: 0x008E135C
		// (set) Token: 0x06021083 RID: 135299 RVA: 0x008E316C File Offset: 0x008E136C
		public unsafe float ShapeNoiseSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x06021084 RID: 135300 RVA: 0x008E317D File Offset: 0x008E137D
		// (set) Token: 0x06021085 RID: 135301 RVA: 0x008E318D File Offset: 0x008E138D
		public unsafe float ShapeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x06021086 RID: 135302 RVA: 0x008E319E File Offset: 0x008E139E
		// (set) Token: 0x06021087 RID: 135303 RVA: 0x008E31AE File Offset: 0x008E13AE
		public unsafe bool Invert
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x06021088 RID: 135304 RVA: 0x008E31BF File Offset: 0x008E13BF
		// (set) Token: 0x06021089 RID: 135305 RVA: 0x008E31CF File Offset: 0x008E13CF
		public unsafe bool DebugSimLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaBurning_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0602108A RID: 135306 RVA: 0x008E31E0 File Offset: 0x008E13E0
		// (set) Token: 0x0602108B RID: 135307 RVA: 0x008E31F4 File Offset: 0x008E13F4
		public unsafe UTexture2D ShapeTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaBurning_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaBurning_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x0602108C RID: 135308 RVA: 0x008E3209 File Offset: 0x008E1409
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaBurning_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x0602108D RID: 135309 RVA: 0x008E321D File Offset: 0x008E141D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaBurning_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602108E RID: 135310 RVA: 0x008E3231 File Offset: 0x008E1431
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaBurning_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602108F RID: 135311 RVA: 0x008E3246 File Offset: 0x008E1446
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaBurning_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021090 RID: 135312 RVA: 0x008E325A File Offset: 0x008E145A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaBurning_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021091 RID: 135313 RVA: 0x008E3270 File Offset: 0x008E1470
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MediaBurning_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MediaBurning_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaBurning_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaBurning_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaBurning_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021092 RID: 135314 RVA: 0x008E32B8 File Offset: 0x008E14B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MediaBurning_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MediaBurning_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaBurning_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaBurning_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaBurning_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021093 RID: 135315 RVA: 0x008E32FF File Offset: 0x008E14FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaBurning_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06021094 RID: 135316 RVA: 0x008E3313 File Offset: 0x008E1513
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaBurning_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021095 RID: 135317 RVA: 0x008E3328 File Offset: 0x008E1528
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_MediaBurning_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MediaBurning_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaBurning_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaBurning_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaBurning_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021096 RID: 135318 RVA: 0x008E3370 File Offset: 0x008E1570
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_MediaBurning_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MediaBurning_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaBurning_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaBurning_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaBurning_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021097 RID: 135319 RVA: 0x008E33B7 File Offset: 0x008E15B7
		protected BP_MediaBurning_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040100F8 RID: 65784
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_MediaBurning.BP_MediaBurning_C";

		// Token: 0x040100F9 RID: 65785
		private static IntPtr _ClassPtr;

		// Token: 0x040100FA RID: 65786
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040100FB RID: 65787
		internal static int __PropertyOffset_1;

		// Token: 0x040100FC RID: 65788
		internal static int __PropertyOffset_2;

		// Token: 0x040100FD RID: 65789
		internal static int __PropertyOffset_3;

		// Token: 0x040100FE RID: 65790
		internal static int __PropertyOffset_4;

		// Token: 0x040100FF RID: 65791
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04010100 RID: 65792
		internal static int __PropertyOffset_5;

		// Token: 0x04010101 RID: 65793
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x04010102 RID: 65794
		internal static int __PropertyOffset_6;

		// Token: 0x04010103 RID: 65795
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x04010104 RID: 65796
		internal static int __PropertyOffset_7;

		// Token: 0x04010105 RID: 65797
		internal static int __PropertyOffset_8;

		// Token: 0x04010106 RID: 65798
		internal static int __PropertyOffset_9;

		// Token: 0x04010107 RID: 65799
		internal static int __PropertyOffset_10;

		// Token: 0x04010108 RID: 65800
		internal static int __PropertyOffset_11;

		// Token: 0x04010109 RID: 65801
		internal static int __PropertyOffset_12;

		// Token: 0x0401010A RID: 65802
		internal static int __PropertyOffset_13;

		// Token: 0x0401010B RID: 65803
		internal static int __PropertyOffset_14;

		// Token: 0x0401010C RID: 65804
		internal static int __PropertyOffset_15;

		// Token: 0x0401010D RID: 65805
		internal static int __PropertyOffset_16;

		// Token: 0x0401010E RID: 65806
		internal static int __PropertyOffset_17;

		// Token: 0x0401010F RID: 65807
		internal static int __PropertyOffset_18;

		// Token: 0x04010110 RID: 65808
		internal static int __PropertyOffset_19;

		// Token: 0x04010111 RID: 65809
		internal static int __PropertyOffset_20;

		// Token: 0x04010112 RID: 65810
		internal static int __PropertyOffset_21;

		// Token: 0x04010113 RID: 65811
		internal static int __PropertyOffset_22;

		// Token: 0x04010114 RID: 65812
		internal static int __PropertyOffset_23;

		// Token: 0x04010115 RID: 65813
		internal static int __PropertyOffset_24;

		// Token: 0x04010116 RID: 65814
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x04010117 RID: 65815
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010118 RID: 65816
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010119 RID: 65817
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401011A RID: 65818
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0401011B RID: 65819
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C61 RID: 40033
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403131F RID: 201503
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C62 RID: 40034
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031320 RID: 201504
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
