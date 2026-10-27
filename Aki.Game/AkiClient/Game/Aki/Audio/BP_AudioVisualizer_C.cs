using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x0200442E RID: 17454
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Audio/BP_AudioVisualizer.BP_AudioVisualizer_C")]
	[UnrealStructLayout(1224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1224)]
	public class BP_AudioVisualizer_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D27C RID: 184956 RVA: 0x00A34D95 File Offset: 0x00A32F95
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AudioVisualizer_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Audio/BP_AudioVisualizer.BP_AudioVisualizer_C");
			}
			return BP_AudioVisualizer_C._ClassPtr;
		}

		// Token: 0x0602D27D RID: 184957 RVA: 0x00A34DBC File Offset: 0x00A32FBC
		public BP_AudioVisualizer_C() : this(BuiltinUtils.AllocNativeUObject(BP_AudioVisualizer_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D27E RID: 184958 RVA: 0x00A34DE4 File Offset: 0x00A32FE4
		[NullableContext(1)]
		public BP_AudioVisualizer_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AudioVisualizer_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007248 RID: 29256
		// (get) Token: 0x0602D27F RID: 184959 RVA: 0x00A34E17 File Offset: 0x00A33017
		// (set) Token: 0x0602D280 RID: 184960 RVA: 0x00A34E2B File Offset: 0x00A3302B
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17007249 RID: 29257
		// (get) Token: 0x0602D281 RID: 184961 RVA: 0x00A34E40 File Offset: 0x00A33040
		// (set) Token: 0x0602D282 RID: 184962 RVA: 0x00A34E54 File Offset: 0x00A33054
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700724A RID: 29258
		// (get) Token: 0x0602D283 RID: 184963 RVA: 0x00A34E69 File Offset: 0x00A33069
		// (set) Token: 0x0602D284 RID: 184964 RVA: 0x00A34E79 File Offset: 0x00A33079
		public unsafe float LeftRight_Amount_E70A81694434E6033ACF01BCCBB3EA40
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700724B RID: 29259
		// (get) Token: 0x0602D285 RID: 184965 RVA: 0x00A34E8A File Offset: 0x00A3308A
		// (set) Token: 0x0602D286 RID: 184966 RVA: 0x00A34E9A File Offset: 0x00A3309A
		public unsafe float LeftRight_Speed_E70A81694434E6033ACF01BCCBB3EA40
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700724C RID: 29260
		// (get) Token: 0x0602D287 RID: 184967 RVA: 0x00A34EAB File Offset: 0x00A330AB
		// (set) Token: 0x0602D288 RID: 184968 RVA: 0x00A34EBF File Offset: 0x00A330BF
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> LeftRight__Direction_E70A81694434E6033ACF01BCCBB3EA40
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_5);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700724D RID: 29261
		// (get) Token: 0x0602D289 RID: 184969 RVA: 0x00A34ED4 File Offset: 0x00A330D4
		// (set) Token: 0x0602D28A RID: 184970 RVA: 0x00A34EE8 File Offset: 0x00A330E8
		public unsafe UTimelineComponent LeftRight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700724E RID: 29262
		// (get) Token: 0x0602D28B RID: 184971 RVA: 0x00A34EFD File Offset: 0x00A330FD
		// (set) Token: 0x0602D28C RID: 184972 RVA: 0x00A34F0D File Offset: 0x00A3310D
		public unsafe float Timeline_1_Amount_E9903C6548E1132FB686C5B44E42F03F
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700724F RID: 29263
		// (get) Token: 0x0602D28D RID: 184973 RVA: 0x00A34F1E File Offset: 0x00A3311E
		// (set) Token: 0x0602D28E RID: 184974 RVA: 0x00A34F2E File Offset: 0x00A3312E
		public unsafe float Timeline_1_Speed_E9903C6548E1132FB686C5B44E42F03F
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17007250 RID: 29264
		// (get) Token: 0x0602D28F RID: 184975 RVA: 0x00A34F3F File Offset: 0x00A3313F
		// (set) Token: 0x0602D290 RID: 184976 RVA: 0x00A34F53 File Offset: 0x00A33153
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_1__Direction_E9903C6548E1132FB686C5B44E42F03F
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_9);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17007251 RID: 29265
		// (get) Token: 0x0602D291 RID: 184977 RVA: 0x00A34F68 File Offset: 0x00A33168
		// (set) Token: 0x0602D292 RID: 184978 RVA: 0x00A34F7C File Offset: 0x00A3317C
		public unsafe UTimelineComponent Timeline_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17007252 RID: 29266
		// (get) Token: 0x0602D293 RID: 184979 RVA: 0x00A34F91 File Offset: 0x00A33191
		// (set) Token: 0x0602D294 RID: 184980 RVA: 0x00A34FA1 File Offset: 0x00A331A1
		public unsafe float BassTimeline_Amount_56F891924BAD722F43E980B6AFE54B74
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17007253 RID: 29267
		// (get) Token: 0x0602D295 RID: 184981 RVA: 0x00A34FB2 File Offset: 0x00A331B2
		// (set) Token: 0x0602D296 RID: 184982 RVA: 0x00A34FC2 File Offset: 0x00A331C2
		public unsafe float BassTimeline_Speed_56F891924BAD722F43E980B6AFE54B74
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17007254 RID: 29268
		// (get) Token: 0x0602D297 RID: 184983 RVA: 0x00A34FD3 File Offset: 0x00A331D3
		// (set) Token: 0x0602D298 RID: 184984 RVA: 0x00A34FE7 File Offset: 0x00A331E7
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> BassTimeline__Direction_56F891924BAD722F43E980B6AFE54B74
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_13);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17007255 RID: 29269
		// (get) Token: 0x0602D299 RID: 184985 RVA: 0x00A34FFC File Offset: 0x00A331FC
		// (set) Token: 0x0602D29A RID: 184986 RVA: 0x00A35010 File Offset: 0x00A33210
		public unsafe UTimelineComponent BassTimeline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17007256 RID: 29270
		// (get) Token: 0x0602D29B RID: 184987 RVA: 0x00A35025 File Offset: 0x00A33225
		// (set) Token: 0x0602D29C RID: 184988 RVA: 0x00A35035 File Offset: 0x00A33235
		public unsafe float Timeline_0_Amount_84FB19EE41A244783A5C418B4069C9D8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17007257 RID: 29271
		// (get) Token: 0x0602D29D RID: 184989 RVA: 0x00A35046 File Offset: 0x00A33246
		// (set) Token: 0x0602D29E RID: 184990 RVA: 0x00A35056 File Offset: 0x00A33256
		public unsafe float Timeline_0_Speed_84FB19EE41A244783A5C418B4069C9D8
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17007258 RID: 29272
		// (get) Token: 0x0602D29F RID: 184991 RVA: 0x00A35067 File Offset: 0x00A33267
		// (set) Token: 0x0602D2A0 RID: 184992 RVA: 0x00A3507B File Offset: 0x00A3327B
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_0__Direction_84FB19EE41A244783A5C418B4069C9D8
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_17);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17007259 RID: 29273
		// (get) Token: 0x0602D2A1 RID: 184993 RVA: 0x00A35090 File Offset: 0x00A33290
		// (set) Token: 0x0602D2A2 RID: 184994 RVA: 0x00A350A4 File Offset: 0x00A332A4
		public unsafe UTimelineComponent Timeline_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x1700725A RID: 29274
		// (get) Token: 0x0602D2A3 RID: 184995 RVA: 0x00A350B9 File Offset: 0x00A332B9
		// (set) Token: 0x0602D2A4 RID: 184996 RVA: 0x00A350C9 File Offset: 0x00A332C9
		public unsafe int NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700725B RID: 29275
		// (get) Token: 0x0602D2A5 RID: 184997 RVA: 0x00A350DA File Offset: 0x00A332DA
		// (set) Token: 0x0602D2A6 RID: 184998 RVA: 0x00A350EE File Offset: 0x00A332EE
		public unsafe UAkAudioEvent Ak_Event
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioVisualizer_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x1700725C RID: 29276
		// (get) Token: 0x0602D2A7 RID: 184999 RVA: 0x00A35103 File Offset: 0x00A33303
		// (set) Token: 0x0602D2A8 RID: 185000 RVA: 0x00A35113 File Offset: 0x00A33313
		public unsafe float A01Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700725D RID: 29277
		// (get) Token: 0x0602D2A9 RID: 185001 RVA: 0x00A35124 File Offset: 0x00A33324
		// (set) Token: 0x0602D2AA RID: 185002 RVA: 0x00A35134 File Offset: 0x00A33334
		public unsafe float A02Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700725E RID: 29278
		// (get) Token: 0x0602D2AB RID: 185003 RVA: 0x00A35145 File Offset: 0x00A33345
		// (set) Token: 0x0602D2AC RID: 185004 RVA: 0x00A35155 File Offset: 0x00A33355
		public unsafe float A03Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700725F RID: 29279
		// (get) Token: 0x0602D2AD RID: 185005 RVA: 0x00A35166 File Offset: 0x00A33366
		// (set) Token: 0x0602D2AE RID: 185006 RVA: 0x00A35176 File Offset: 0x00A33376
		public unsafe float A04Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17007260 RID: 29280
		// (get) Token: 0x0602D2AF RID: 185007 RVA: 0x00A35187 File Offset: 0x00A33387
		// (set) Token: 0x0602D2B0 RID: 185008 RVA: 0x00A35197 File Offset: 0x00A33397
		public unsafe float A01Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17007261 RID: 29281
		// (get) Token: 0x0602D2B1 RID: 185009 RVA: 0x00A351A8 File Offset: 0x00A333A8
		// (set) Token: 0x0602D2B2 RID: 185010 RVA: 0x00A351B8 File Offset: 0x00A333B8
		public unsafe float A02Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17007262 RID: 29282
		// (get) Token: 0x0602D2B3 RID: 185011 RVA: 0x00A351C9 File Offset: 0x00A333C9
		// (set) Token: 0x0602D2B4 RID: 185012 RVA: 0x00A351D9 File Offset: 0x00A333D9
		public unsafe float A03Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17007263 RID: 29283
		// (get) Token: 0x0602D2B5 RID: 185013 RVA: 0x00A351EA File Offset: 0x00A333EA
		// (set) Token: 0x0602D2B6 RID: 185014 RVA: 0x00A351FA File Offset: 0x00A333FA
		public unsafe float A04Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17007264 RID: 29284
		// (get) Token: 0x0602D2B7 RID: 185015 RVA: 0x00A3520B File Offset: 0x00A3340B
		// (set) Token: 0x0602D2B8 RID: 185016 RVA: 0x00A3521B File Offset: 0x00A3341B
		public unsafe bool UsingMax_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007265 RID: 29285
		// (get) Token: 0x0602D2B9 RID: 185017 RVA: 0x00A3522C File Offset: 0x00A3342C
		// (set) Token: 0x0602D2BA RID: 185018 RVA: 0x00A3523C File Offset: 0x00A3343C
		public unsafe int PlayID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioVisualizer_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x0602D2BB RID: 185019 RVA: 0x00A3524D File Offset: 0x00A3344D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopAllEffects()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__StopAllEffects_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2BC RID: 185020 RVA: 0x00A35264 File Offset: 0x00A33464
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void NotifyMidi([Nullable(2)] UAkCallbackInfo CallbackInfo, EAkCallbackType CallbackType, string State)
		{
			BP_AudioVisualizer_C.__NotifyMidi_FunctionParams* ptr = stackalloc BP_AudioVisualizer_C.__NotifyMidi_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_AudioVisualizer_C.__NotifyMidi_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioVisualizer_C.__NotifyMidi_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CallbackInfo = ((CallbackInfo != null) ? CallbackInfo.NativePtr : IntPtr.Zero);
			ptr->CallbackType = CallbackType;
			FString.CopyFrom((void*)(&ptr->State), State);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__NotifyMidi_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_AudioVisualizer_C.__NotifyMidi_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602D2BD RID: 185021 RVA: 0x00A352DE File Offset: 0x00A334DE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BassTimeline__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__BassTimeline__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2BE RID: 185022 RVA: 0x00A352F2 File Offset: 0x00A334F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BassTimeline__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__BassTimeline__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2BF RID: 185023 RVA: 0x00A35306 File Offset: 0x00A33506
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__Timeline_0__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2C0 RID: 185024 RVA: 0x00A3531A File Offset: 0x00A3351A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__Timeline_0__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2C1 RID: 185025 RVA: 0x00A3532E File Offset: 0x00A3352E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_1__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__Timeline_1__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2C2 RID: 185026 RVA: 0x00A35342 File Offset: 0x00A33542
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_1__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__Timeline_1__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2C3 RID: 185027 RVA: 0x00A35356 File Offset: 0x00A33556
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LeftRight__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__LeftRight__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2C4 RID: 185028 RVA: 0x00A3536A File Offset: 0x00A3356A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LeftRight__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__LeftRight__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2C5 RID: 185029 RVA: 0x00A3537E File Offset: 0x00A3357E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2C6 RID: 185030 RVA: 0x00A35392 File Offset: 0x00A33592
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AudioVisualizer_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602D2C7 RID: 185031 RVA: 0x00A353A7 File Offset: 0x00A335A7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void C_4_On()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__C_4_On_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2C8 RID: 185032 RVA: 0x00A353BB File Offset: 0x00A335BB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void D4_On()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__D4_On_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2C9 RID: 185033 RVA: 0x00A353CF File Offset: 0x00A335CF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void D_4_On()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__D_4_On_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2CA RID: 185034 RVA: 0x00A353E3 File Offset: 0x00A335E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void E4_On()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__E4_On_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2CB RID: 185035 RVA: 0x00A353F7 File Offset: 0x00A335F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void F4_On()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__F4_On_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2CC RID: 185036 RVA: 0x00A3540B File Offset: 0x00A3360B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void F_4_On()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__F_4_On_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2CD RID: 185037 RVA: 0x00A3541F File Offset: 0x00A3361F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void G4_On()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__G4_On_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2CE RID: 185038 RVA: 0x00A35433 File Offset: 0x00A33633
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void G_4_On()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__G_4_On_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2CF RID: 185039 RVA: 0x00A35447 File Offset: 0x00A33647
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void F_4_Off()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__F_4_Off_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2D0 RID: 185040 RVA: 0x00A3545B File Offset: 0x00A3365B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void C4_On()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__C4_On_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2D1 RID: 185041 RVA: 0x00A35470 File Offset: 0x00A33670
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_AudioVisualizer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AudioVisualizer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AudioVisualizer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioVisualizer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D2D2 RID: 185042 RVA: 0x00A354B8 File Offset: 0x00A336B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_AudioVisualizer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AudioVisualizer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AudioVisualizer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioVisualizer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AudioVisualizer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602D2D3 RID: 185043 RVA: 0x00A35500 File Offset: 0x00A33700
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MIDICall(EAkCallbackType CallbackType, [Nullable(2)] UAkCallbackInfo CallbackInfo, string State)
		{
			BP_AudioVisualizer_C.__MIDICall_FunctionParams* ptr = stackalloc BP_AudioVisualizer_C.__MIDICall_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_AudioVisualizer_C.__MIDICall_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioVisualizer_C.__MIDICall_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CallbackType = CallbackType;
			ptr->CallbackInfo = ((CallbackInfo != null) ? CallbackInfo.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->State), State);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__MIDICall_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_AudioVisualizer_C.__MIDICall_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602D2D4 RID: 185044 RVA: 0x00A3557A File Offset: 0x00A3377A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioVisualizer_C.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x0602D2D5 RID: 185045 RVA: 0x00A3558E File Offset: 0x00A3378E
		protected BP_AudioVisualizer_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017FDD RID: 98269
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Audio/BP_AudioVisualizer.BP_AudioVisualizer_C";

		// Token: 0x04017FDE RID: 98270
		private static IntPtr _ClassPtr;

		// Token: 0x04017FDF RID: 98271
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017FE0 RID: 98272
		internal static int __PropertyOffset_1;

		// Token: 0x04017FE1 RID: 98273
		internal static int __PropertyOffset_2;

		// Token: 0x04017FE2 RID: 98274
		internal static int __PropertyOffset_3;

		// Token: 0x04017FE3 RID: 98275
		internal static int __PropertyOffset_4;

		// Token: 0x04017FE4 RID: 98276
		internal static int __PropertyOffset_5;

		// Token: 0x04017FE5 RID: 98277
		internal static int __PropertyOffset_6;

		// Token: 0x04017FE6 RID: 98278
		internal static int __PropertyOffset_7;

		// Token: 0x04017FE7 RID: 98279
		internal static int __PropertyOffset_8;

		// Token: 0x04017FE8 RID: 98280
		internal static int __PropertyOffset_9;

		// Token: 0x04017FE9 RID: 98281
		internal static int __PropertyOffset_10;

		// Token: 0x04017FEA RID: 98282
		internal static int __PropertyOffset_11;

		// Token: 0x04017FEB RID: 98283
		internal static int __PropertyOffset_12;

		// Token: 0x04017FEC RID: 98284
		internal static int __PropertyOffset_13;

		// Token: 0x04017FED RID: 98285
		internal static int __PropertyOffset_14;

		// Token: 0x04017FEE RID: 98286
		internal static int __PropertyOffset_15;

		// Token: 0x04017FEF RID: 98287
		internal static int __PropertyOffset_16;

		// Token: 0x04017FF0 RID: 98288
		internal static int __PropertyOffset_17;

		// Token: 0x04017FF1 RID: 98289
		internal static int __PropertyOffset_18;

		// Token: 0x04017FF2 RID: 98290
		internal static int __PropertyOffset_19;

		// Token: 0x04017FF3 RID: 98291
		internal static int __PropertyOffset_20;

		// Token: 0x04017FF4 RID: 98292
		internal static int __PropertyOffset_21;

		// Token: 0x04017FF5 RID: 98293
		internal static int __PropertyOffset_22;

		// Token: 0x04017FF6 RID: 98294
		internal static int __PropertyOffset_23;

		// Token: 0x04017FF7 RID: 98295
		internal static int __PropertyOffset_24;

		// Token: 0x04017FF8 RID: 98296
		internal static int __PropertyOffset_25;

		// Token: 0x04017FF9 RID: 98297
		internal static int __PropertyOffset_26;

		// Token: 0x04017FFA RID: 98298
		internal static int __PropertyOffset_27;

		// Token: 0x04017FFB RID: 98299
		internal static int __PropertyOffset_28;

		// Token: 0x04017FFC RID: 98300
		internal static int __PropertyOffset_29;

		// Token: 0x04017FFD RID: 98301
		internal static int __PropertyOffset_30;

		// Token: 0x04017FFE RID: 98302
		private static IntPtr __StopAllEffects_NativeFunctionPtr;

		// Token: 0x04017FFF RID: 98303
		private static IntPtr __NotifyMidi_NativeFunctionPtr;

		// Token: 0x04018000 RID: 98304
		private static IntPtr __BassTimeline__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04018001 RID: 98305
		private static IntPtr __BassTimeline__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04018002 RID: 98306
		private static IntPtr __Timeline_0__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04018003 RID: 98307
		private static IntPtr __Timeline_0__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04018004 RID: 98308
		private static IntPtr __Timeline_1__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04018005 RID: 98309
		private static IntPtr __Timeline_1__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04018006 RID: 98310
		private static IntPtr __LeftRight__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04018007 RID: 98311
		private static IntPtr __LeftRight__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04018008 RID: 98312
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04018009 RID: 98313
		private static IntPtr __C_4_On_NativeFunctionPtr;

		// Token: 0x0401800A RID: 98314
		private static IntPtr __D4_On_NativeFunctionPtr;

		// Token: 0x0401800B RID: 98315
		private static IntPtr __D_4_On_NativeFunctionPtr;

		// Token: 0x0401800C RID: 98316
		private static IntPtr __E4_On_NativeFunctionPtr;

		// Token: 0x0401800D RID: 98317
		private static IntPtr __F4_On_NativeFunctionPtr;

		// Token: 0x0401800E RID: 98318
		private static IntPtr __F_4_On_NativeFunctionPtr;

		// Token: 0x0401800F RID: 98319
		private static IntPtr __G4_On_NativeFunctionPtr;

		// Token: 0x04018010 RID: 98320
		private static IntPtr __G_4_On_NativeFunctionPtr;

		// Token: 0x04018011 RID: 98321
		private static IntPtr __F_4_Off_NativeFunctionPtr;

		// Token: 0x04018012 RID: 98322
		private static IntPtr __C4_On_NativeFunctionPtr;

		// Token: 0x04018013 RID: 98323
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04018014 RID: 98324
		private static IntPtr __MIDICall_NativeFunctionPtr;

		// Token: 0x04018015 RID: 98325
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x0200A6E5 RID: 42725
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __NotifyMidi_FunctionParams
		{
			// Token: 0x040326D3 RID: 206547
			[FieldOffset(0)]
			public IntPtr CallbackInfo;

			// Token: 0x040326D4 RID: 206548
			[FieldOffset(8)]
			public EAkCallbackType CallbackType;

			// Token: 0x040326D5 RID: 206549
			[FieldOffset(16)]
			public FString State;
		}

		// Token: 0x0200A6E6 RID: 42726
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040326D6 RID: 206550
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A6E7 RID: 42727
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __MIDICall_FunctionParams
		{
			// Token: 0x040326D7 RID: 206551
			[FieldOffset(0)]
			public EAkCallbackType CallbackType;

			// Token: 0x040326D8 RID: 206552
			[FieldOffset(8)]
			public IntPtr CallbackInfo;

			// Token: 0x040326D9 RID: 206553
			[FieldOffset(16)]
			public FString State;
		}
	}
}
