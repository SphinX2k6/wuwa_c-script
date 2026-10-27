using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Seq_BP.BPSeqDissolve
{
	// Token: 0x02003A21 RID: 14881
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/BPSeqDissolve/BP_MediaDissolveManagea.BP_MediaDissolveManagea_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1577)]
	public class BP_MediaDissolveManagea_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F403 RID: 128003 RVA: 0x008B2B64 File Offset: 0x008B0D64
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MediaDissolveManagea_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/BPSeqDissolve/BP_MediaDissolveManagea.BP_MediaDissolveManagea_C");
			}
			return BP_MediaDissolveManagea_C._ClassPtr;
		}

		// Token: 0x0601F404 RID: 128004 RVA: 0x008B2B88 File Offset: 0x008B0D88
		public BP_MediaDissolveManagea_C() : this(BuiltinUtils.AllocNativeUObject(BP_MediaDissolveManagea_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F405 RID: 128005 RVA: 0x008B2BB0 File Offset: 0x008B0DB0
		[NullableContext(1)]
		public BP_MediaDissolveManagea_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MediaDissolveManagea_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x0601F406 RID: 128006 RVA: 0x008B2BE3 File Offset: 0x008B0DE3
		// (set) Token: 0x0601F407 RID: 128007 RVA: 0x008B2BF7 File Offset: 0x008B0DF7
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002A6A RID: 10858
		// (get) Token: 0x0601F408 RID: 128008 RVA: 0x008B2C0C File Offset: 0x008B0E0C
		// (set) Token: 0x0601F409 RID: 128009 RVA: 0x008B2C20 File Offset: 0x008B0E20
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002A6B RID: 10859
		// (get) Token: 0x0601F40A RID: 128010 RVA: 0x008B2C35 File Offset: 0x008B0E35
		// (set) Token: 0x0601F40B RID: 128011 RVA: 0x008B2C49 File Offset: 0x008B0E49
		public unsafe UMediaSource MainMediaSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaSource>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x0601F40C RID: 128012 RVA: 0x008B2C5E File Offset: 0x008B0E5E
		// (set) Token: 0x0601F40D RID: 128013 RVA: 0x008B2C72 File Offset: 0x008B0E72
		public unsafe UMediaPlayer MediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x0601F40E RID: 128014 RVA: 0x008B2C87 File Offset: 0x008B0E87
		// (set) Token: 0x0601F40F RID: 128015 RVA: 0x008B2C9B File Offset: 0x008B0E9B
		public unsafe UMediaTexture MediaPlayerTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x0601F410 RID: 128016 RVA: 0x008B2CB0 File Offset: 0x008B0EB0
		// (set) Token: 0x0601F411 RID: 128017 RVA: 0x008B2CC4 File Offset: 0x008B0EC4
		public unsafe UMaterial PostMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x0601F412 RID: 128018 RVA: 0x008B2CD9 File Offset: 0x008B0ED9
		// (set) Token: 0x0601F413 RID: 128019 RVA: 0x008B2CED File Offset: 0x008B0EED
		public unsafe UMaterialInstanceDynamic DynamicMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MediaDissolveManagea_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x0601F414 RID: 128020 RVA: 0x008B2D02 File Offset: 0x008B0F02
		// (set) Token: 0x0601F415 RID: 128021 RVA: 0x008B2D12 File Offset: 0x008B0F12
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x0601F416 RID: 128022 RVA: 0x008B2D23 File Offset: 0x008B0F23
		// (set) Token: 0x0601F417 RID: 128023 RVA: 0x008B2D33 File Offset: 0x008B0F33
		public unsafe float MediaScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x0601F418 RID: 128024 RVA: 0x008B2D44 File Offset: 0x008B0F44
		// (set) Token: 0x0601F419 RID: 128025 RVA: 0x008B2D54 File Offset: 0x008B0F54
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x0601F41A RID: 128026 RVA: 0x008B2D65 File Offset: 0x008B0F65
		// (set) Token: 0x0601F41B RID: 128027 RVA: 0x008B2D75 File Offset: 0x008B0F75
		public unsafe float SphereSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x0601F41C RID: 128028 RVA: 0x008B2D86 File Offset: 0x008B0F86
		// (set) Token: 0x0601F41D RID: 128029 RVA: 0x008B2D96 File Offset: 0x008B0F96
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x0601F41E RID: 128030 RVA: 0x008B2DA7 File Offset: 0x008B0FA7
		// (set) Token: 0x0601F41F RID: 128031 RVA: 0x008B2DB7 File Offset: 0x008B0FB7
		public unsafe float OutSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002A76 RID: 10870
		// (get) Token: 0x0601F420 RID: 128032 RVA: 0x008B2DC8 File Offset: 0x008B0FC8
		// (set) Token: 0x0601F421 RID: 128033 RVA: 0x008B2DDC File Offset: 0x008B0FDC
		public unsafe FVector2D CenterPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x0601F422 RID: 128034 RVA: 0x008B2DF1 File Offset: 0x008B0FF1
		// (set) Token: 0x0601F423 RID: 128035 RVA: 0x008B2E01 File Offset: 0x008B1001
		public unsafe bool IsMaterialTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A78 RID: 10872
		// (get) Token: 0x0601F424 RID: 128036 RVA: 0x008B2E12 File Offset: 0x008B1012
		// (set) Token: 0x0601F425 RID: 128037 RVA: 0x008B2E22 File Offset: 0x008B1022
		public unsafe bool IsChangeSceneColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A79 RID: 10873
		// (get) Token: 0x0601F426 RID: 128038 RVA: 0x008B2E33 File Offset: 0x008B1033
		// (set) Token: 0x0601F427 RID: 128039 RVA: 0x008B2E43 File Offset: 0x008B1043
		public unsafe bool Is_Open
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A7A RID: 10874
		// (get) Token: 0x0601F428 RID: 128040 RVA: 0x008B2E54 File Offset: 0x008B1054
		// (set) Token: 0x0601F429 RID: 128041 RVA: 0x008B2E64 File Offset: 0x008B1064
		public unsafe bool Sphere_Or_Full_Screen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A7B RID: 10875
		// (get) Token: 0x0601F42A RID: 128042 RVA: 0x008B2E75 File Offset: 0x008B1075
		// (set) Token: 0x0601F42B RID: 128043 RVA: 0x008B2E89 File Offset: 0x008B1089
		[Nullable(1)]
		public unsafe string Name
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_19)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_19)), value);
			}
		}

		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x0601F42C RID: 128044 RVA: 0x008B2E9E File Offset: 0x008B109E
		// (set) Token: 0x0601F42D RID: 128045 RVA: 0x008B2EAE File Offset: 0x008B10AE
		public unsafe float FadeinTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x0601F42E RID: 128046 RVA: 0x008B2EBF File Offset: 0x008B10BF
		// (set) Token: 0x0601F42F RID: 128047 RVA: 0x008B2ECF File Offset: 0x008B10CF
		public unsafe float FadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x0601F430 RID: 128048 RVA: 0x008B2EE0 File Offset: 0x008B10E0
		// (set) Token: 0x0601F431 RID: 128049 RVA: 0x008B2EF0 File Offset: 0x008B10F0
		public unsafe bool IsReadyToPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MediaDissolveManagea_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F432 RID: 128050 RVA: 0x008B2F04 File Offset: 0x008B1104
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PlayEffect(string Name, FVector2D CenterPos, float MediaScale, float FadeinTime, float FadeOutTime, [Nullable(2)] UMediaSource MediaSource, bool SphereOrFullScreen)
		{
			BP_MediaDissolveManagea_C.__PlayEffect_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__PlayEffect_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__PlayEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__PlayEffect_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->CenterPos = CenterPos;
			ptr->MediaScale = MediaScale;
			ptr->FadeinTime = FadeinTime;
			ptr->FadeOutTime = FadeOutTime;
			ptr->MediaSource = ((MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero);
			ptr->SphereOrFullScreen = SphereOrFullScreen;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__PlayEffect_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_MediaDissolveManagea_C.__PlayEffect_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F433 RID: 128051 RVA: 0x008B2FA0 File Offset: 0x008B11A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetOpacity(UMaterialInstanceDynamic MaterialInstanceDynamic, bool IsOpen)
		{
			BP_MediaDissolveManagea_C.__SetOpacity_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__SetOpacity_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__SetOpacity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__SetOpacity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MaterialInstanceDynamic = ((MaterialInstanceDynamic != null) ? MaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			ptr->IsOpen = IsOpen;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__SetOpacity_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F434 RID: 128052 RVA: 0x008B2FFC File Offset: 0x008B11FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Post_Material()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__Set_Post_Material_NativeFunctionPtr, null);
		}

		// Token: 0x0601F435 RID: 128053 RVA: 0x008B3010 File Offset: 0x008B1210
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Play(UMediaSource MediaSource, ref UMediaPlayer MediaPlayer)
		{
			BP_MediaDissolveManagea_C.__Play_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__Play_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__Play_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__Play_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MediaSource = ((MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero);
			ref BP_MediaDissolveManagea_C.__Play_FunctionParams ptr2 = ref *ptr;
			UMediaPlayer umediaPlayer = MediaPlayer;
			ptr2.MediaPlayer = ((umediaPlayer != null) ? umediaPlayer.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__Play_NativeFunctionPtr, (void*)ptr);
			MediaPlayer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaPlayer>(ptr->MediaPlayer);
		}

		// Token: 0x0601F436 RID: 128054 RVA: 0x008B308A File Offset: 0x008B128A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601F437 RID: 128055 RVA: 0x008B309E File Offset: 0x008B129E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F438 RID: 128056 RVA: 0x008B30B3 File Offset: 0x008B12B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F439 RID: 128057 RVA: 0x008B30C7 File Offset: 0x008B12C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F43A RID: 128058 RVA: 0x008B30DC File Offset: 0x008B12DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MediaDissolveManagea_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F43B RID: 128059 RVA: 0x008B3124 File Offset: 0x008B1324
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MediaDissolveManagea_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F43C RID: 128060 RVA: 0x008B316B File Offset: 0x008B136B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnVideoEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__OnVideoEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0601F43D RID: 128061 RVA: 0x008B3180 File Offset: 0x008B1380
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_MediaDissolveManagea_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F43E RID: 128062 RVA: 0x008B31C8 File Offset: 0x008B13C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_MediaDissolveManagea_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F43F RID: 128063 RVA: 0x008B320F File Offset: 0x008B140F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601F440 RID: 128064 RVA: 0x008B3223 File Offset: 0x008B1423
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F441 RID: 128065 RVA: 0x008B3238 File Offset: 0x008B1438
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnMediaOpened(string OpenedUrl)
		{
			BP_MediaDissolveManagea_C.__OnMediaOpened_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__OnMediaOpened_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__OnMediaOpened_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__OnMediaOpened_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->OpenedUrl), OpenedUrl);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__OnMediaOpened_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_MediaDissolveManagea_C.__OnMediaOpened_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F442 RID: 128066 RVA: 0x008B3298 File Offset: 0x008B1498
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OpenFailed(string FailedUrl)
		{
			BP_MediaDissolveManagea_C.__OpenFailed_FunctionParams* ptr = stackalloc BP_MediaDissolveManagea_C.__OpenFailed_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_MediaDissolveManagea_C.__OpenFailed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MediaDissolveManagea_C.__OpenFailed_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->FailedUrl), FailedUrl);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MediaDissolveManagea_C.__OpenFailed_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_MediaDissolveManagea_C.__OpenFailed_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F443 RID: 128067 RVA: 0x008B32F5 File Offset: 0x008B14F5
		protected BP_MediaDissolveManagea_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EFC6 RID: 61382
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/BPSeqDissolve/BP_MediaDissolveManagea.BP_MediaDissolveManagea_C";

		// Token: 0x0400EFC7 RID: 61383
		private static IntPtr _ClassPtr;

		// Token: 0x0400EFC8 RID: 61384
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EFC9 RID: 61385
		internal static int __PropertyOffset_1;

		// Token: 0x0400EFCA RID: 61386
		internal static int __PropertyOffset_2;

		// Token: 0x0400EFCB RID: 61387
		internal static int __PropertyOffset_3;

		// Token: 0x0400EFCC RID: 61388
		internal static int __PropertyOffset_4;

		// Token: 0x0400EFCD RID: 61389
		internal static int __PropertyOffset_5;

		// Token: 0x0400EFCE RID: 61390
		internal static int __PropertyOffset_6;

		// Token: 0x0400EFCF RID: 61391
		internal static int __PropertyOffset_7;

		// Token: 0x0400EFD0 RID: 61392
		internal static int __PropertyOffset_8;

		// Token: 0x0400EFD1 RID: 61393
		internal static int __PropertyOffset_9;

		// Token: 0x0400EFD2 RID: 61394
		internal static int __PropertyOffset_10;

		// Token: 0x0400EFD3 RID: 61395
		internal static int __PropertyOffset_11;

		// Token: 0x0400EFD4 RID: 61396
		internal static int __PropertyOffset_12;

		// Token: 0x0400EFD5 RID: 61397
		internal static int __PropertyOffset_13;

		// Token: 0x0400EFD6 RID: 61398
		internal static int __PropertyOffset_14;

		// Token: 0x0400EFD7 RID: 61399
		internal static int __PropertyOffset_15;

		// Token: 0x0400EFD8 RID: 61400
		internal static int __PropertyOffset_16;

		// Token: 0x0400EFD9 RID: 61401
		internal static int __PropertyOffset_17;

		// Token: 0x0400EFDA RID: 61402
		internal static int __PropertyOffset_18;

		// Token: 0x0400EFDB RID: 61403
		internal static int __PropertyOffset_19;

		// Token: 0x0400EFDC RID: 61404
		internal static int __PropertyOffset_20;

		// Token: 0x0400EFDD RID: 61405
		internal static int __PropertyOffset_21;

		// Token: 0x0400EFDE RID: 61406
		internal static int __PropertyOffset_22;

		// Token: 0x0400EFDF RID: 61407
		private static IntPtr __PlayEffect_NativeFunctionPtr;

		// Token: 0x0400EFE0 RID: 61408
		private static IntPtr __SetOpacity_NativeFunctionPtr;

		// Token: 0x0400EFE1 RID: 61409
		private static IntPtr __Set_Post_Material_NativeFunctionPtr;

		// Token: 0x0400EFE2 RID: 61410
		private static IntPtr __Play_NativeFunctionPtr;

		// Token: 0x0400EFE3 RID: 61411
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400EFE4 RID: 61412
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400EFE5 RID: 61413
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400EFE6 RID: 61414
		private static IntPtr __OnVideoEnd_NativeFunctionPtr;

		// Token: 0x0400EFE7 RID: 61415
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400EFE8 RID: 61416
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0400EFE9 RID: 61417
		private static IntPtr __OnMediaOpened_NativeFunctionPtr;

		// Token: 0x0400EFEA RID: 61418
		private static IntPtr __OpenFailed_NativeFunctionPtr;

		// Token: 0x02009A9E RID: 39582
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __PlayEffect_FunctionParams
		{
			// Token: 0x04031019 RID: 200729
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x0403101A RID: 200730
			[FieldOffset(16)]
			public FVector2D CenterPos;

			// Token: 0x0403101B RID: 200731
			[FieldOffset(24)]
			public float MediaScale;

			// Token: 0x0403101C RID: 200732
			[FieldOffset(28)]
			public float FadeinTime;

			// Token: 0x0403101D RID: 200733
			[FieldOffset(32)]
			public float FadeOutTime;

			// Token: 0x0403101E RID: 200734
			[FieldOffset(40)]
			public IntPtr MediaSource;

			// Token: 0x0403101F RID: 200735
			[FieldOffset(48)]
			public bool SphereOrFullScreen;
		}

		// Token: 0x02009A9F RID: 39583
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetOpacity_FunctionParams
		{
			// Token: 0x04031020 RID: 200736
			[FieldOffset(0)]
			public IntPtr MaterialInstanceDynamic;

			// Token: 0x04031021 RID: 200737
			[FieldOffset(8)]
			public bool IsOpen;
		}

		// Token: 0x02009AA0 RID: 39584
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Play_FunctionParams
		{
			// Token: 0x04031022 RID: 200738
			[FieldOffset(0)]
			public IntPtr MediaSource;

			// Token: 0x04031023 RID: 200739
			[FieldOffset(8)]
			public IntPtr MediaPlayer;
		}

		// Token: 0x02009AA1 RID: 39585
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031024 RID: 200740
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009AA2 RID: 39586
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031025 RID: 200741
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009AA3 RID: 39587
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnMediaOpened_FunctionParams
		{
			// Token: 0x04031026 RID: 200742
			[FieldOffset(0)]
			public FString OpenedUrl;
		}

		// Token: 0x02009AA4 RID: 39588
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OpenFailed_FunctionParams
		{
			// Token: 0x04031027 RID: 200743
			[FieldOffset(0)]
			public FString FailedUrl;
		}
	}
}
