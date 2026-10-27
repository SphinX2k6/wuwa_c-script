using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CB3 RID: 15539
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_BoxCol.BP_BoxCol_C")]
	[UnrealStructLayout(1784, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1781)]
	public class BP_BoxCol_C : AKuroCSRpbd, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024914 RID: 149780 RVA: 0x009427DE File Offset: 0x009409DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BoxCol_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_BoxCol.BP_BoxCol_C");
			}
			return BP_BoxCol_C._ClassPtr;
		}

		// Token: 0x06024915 RID: 149781 RVA: 0x00942804 File Offset: 0x00940A04
		public BP_BoxCol_C() : this(BuiltinUtils.AllocNativeUObject(BP_BoxCol_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024916 RID: 149782 RVA: 0x0094282C File Offset: 0x00940A2C
		[NullableContext(1)]
		public BP_BoxCol_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BoxCol_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170047B9 RID: 18361
		// (get) Token: 0x06024917 RID: 149783 RVA: 0x0094285F File Offset: 0x00940A5F
		// (set) Token: 0x06024918 RID: 149784 RVA: 0x00942873 File Offset: 0x00940A73
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170047BA RID: 18362
		// (get) Token: 0x06024919 RID: 149785 RVA: 0x00942888 File Offset: 0x00940A88
		// (set) Token: 0x0602491A RID: 149786 RVA: 0x0094289C File Offset: 0x00940A9C
		public unsafe UStaticMeshComponent xpbd_test
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170047BB RID: 18363
		// (get) Token: 0x0602491B RID: 149787 RVA: 0x009428B1 File Offset: 0x00940AB1
		// (set) Token: 0x0602491C RID: 149788 RVA: 0x009428C5 File Offset: 0x00940AC5
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170047BC RID: 18364
		// (get) Token: 0x0602491D RID: 149789 RVA: 0x009428DA File Offset: 0x00940ADA
		// (set) Token: 0x0602491E RID: 149790 RVA: 0x009428EE File Offset: 0x00940AEE
		public unsafe UDataTable DT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170047BD RID: 18365
		// (get) Token: 0x0602491F RID: 149791 RVA: 0x00942903 File Offset: 0x00940B03
		// (set) Token: 0x06024920 RID: 149792 RVA: 0x00942917 File Offset: 0x00940B17
		public unsafe UMaterialInstanceDynamic MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170047BE RID: 18366
		// (get) Token: 0x06024921 RID: 149793 RVA: 0x0094292C File Offset: 0x00940B2C
		// (set) Token: 0x06024922 RID: 149794 RVA: 0x0094293C File Offset: 0x00940B3C
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047BF RID: 18367
		// (get) Token: 0x06024923 RID: 149795 RVA: 0x0094294D File Offset: 0x00940B4D
		// (set) Token: 0x06024924 RID: 149796 RVA: 0x00942961 File Offset: 0x00940B61
		public unsafe UMaterialInstance InputMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170047C0 RID: 18368
		// (get) Token: 0x06024925 RID: 149797 RVA: 0x00942976 File Offset: 0x00940B76
		// (set) Token: 0x06024926 RID: 149798 RVA: 0x00942986 File Offset: 0x00940B86
		public unsafe float force
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170047C1 RID: 18369
		// (get) Token: 0x06024927 RID: 149799 RVA: 0x00942997 File Offset: 0x00940B97
		// (set) Token: 0x06024928 RID: 149800 RVA: 0x009429A7 File Offset: 0x00940BA7
		public unsafe bool Pressing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047C2 RID: 18370
		// (get) Token: 0x06024929 RID: 149801 RVA: 0x009429B8 File Offset: 0x00940BB8
		// (set) Token: 0x0602492A RID: 149802 RVA: 0x009429C8 File Offset: 0x00940BC8
		public unsafe bool FS_isPhysicSimulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047C3 RID: 18371
		// (get) Token: 0x0602492B RID: 149803 RVA: 0x009429D9 File Offset: 0x00940BD9
		// (set) Token: 0x0602492C RID: 149804 RVA: 0x009429E9 File Offset: 0x00940BE9
		public unsafe float mass_in_kg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170047C4 RID: 18372
		// (get) Token: 0x0602492D RID: 149805 RVA: 0x009429FA File Offset: 0x00940BFA
		// (set) Token: 0x0602492E RID: 149806 RVA: 0x00942A0A File Offset: 0x00940C0A
		public unsafe bool editorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047C5 RID: 18373
		// (get) Token: 0x0602492F RID: 149807 RVA: 0x00942A1B File Offset: 0x00940C1B
		// (set) Token: 0x06024930 RID: 149808 RVA: 0x00942A2B File Offset: 0x00940C2B
		public unsafe bool _2DRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047C6 RID: 18374
		// (get) Token: 0x06024931 RID: 149809 RVA: 0x00942A3C File Offset: 0x00940C3C
		// (set) Token: 0x06024932 RID: 149810 RVA: 0x00942A4C File Offset: 0x00940C4C
		public unsafe int XCount_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170047C7 RID: 18375
		// (get) Token: 0x06024933 RID: 149811 RVA: 0x00942A5D File Offset: 0x00940C5D
		// (set) Token: 0x06024934 RID: 149812 RVA: 0x00942A6D File Offset: 0x00940C6D
		public unsafe bool ReadDataInBeginPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047C8 RID: 18376
		// (get) Token: 0x06024935 RID: 149813 RVA: 0x00942A7E File Offset: 0x00940C7E
		// (set) Token: 0x06024936 RID: 149814 RVA: 0x00942A92 File Offset: 0x00940C92
		public unsafe UStaticMesh inputStaticMesh_ForBPL_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x170047C9 RID: 18377
		// (get) Token: 0x06024937 RID: 149815 RVA: 0x00942AA7 File Offset: 0x00940CA7
		// (set) Token: 0x06024938 RID: 149816 RVA: 0x00942AB7 File Offset: 0x00940CB7
		public unsafe bool extraOneMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047CA RID: 18378
		// (get) Token: 0x06024939 RID: 149817 RVA: 0x00942AC8 File Offset: 0x00940CC8
		// (set) Token: 0x0602493A RID: 149818 RVA: 0x00942ADC File Offset: 0x00940CDC
		public unsafe UMaterialInstance InputMat1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x170047CB RID: 18379
		// (get) Token: 0x0602493B RID: 149819 RVA: 0x00942AF1 File Offset: 0x00940CF1
		// (set) Token: 0x0602493C RID: 149820 RVA: 0x00942B05 File Offset: 0x00940D05
		public unsafe UMaterialInstanceDynamic MID1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BoxCol_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x170047CC RID: 18380
		// (get) Token: 0x0602493D RID: 149821 RVA: 0x00942B1A File Offset: 0x00940D1A
		// (set) Token: 0x0602493E RID: 149822 RVA: 0x00942B2A File Offset: 0x00940D2A
		public unsafe bool StopBP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047CD RID: 18381
		// (get) Token: 0x0602493F RID: 149823 RVA: 0x00942B3B File Offset: 0x00940D3B
		// (set) Token: 0x06024940 RID: 149824 RVA: 0x00942B4B File Offset: 0x00940D4B
		public unsafe bool UseYCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047CE RID: 18382
		// (get) Token: 0x06024941 RID: 149825 RVA: 0x00942B5C File Offset: 0x00940D5C
		// (set) Token: 0x06024942 RID: 149826 RVA: 0x00942B6C File Offset: 0x00940D6C
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170047CF RID: 18383
		// (get) Token: 0x06024943 RID: 149827 RVA: 0x00942B7D File Offset: 0x00940D7D
		// (set) Token: 0x06024944 RID: 149828 RVA: 0x00942B91 File Offset: 0x00940D91
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170047D0 RID: 18384
		// (get) Token: 0x06024945 RID: 149829 RVA: 0x00942BA6 File Offset: 0x00940DA6
		// (set) Token: 0x06024946 RID: 149830 RVA: 0x00942BBA File Offset: 0x00940DBA
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170047D1 RID: 18385
		// (get) Token: 0x06024947 RID: 149831 RVA: 0x00942BCF File Offset: 0x00940DCF
		// (set) Token: 0x06024948 RID: 149832 RVA: 0x00942BDF File Offset: 0x00940DDF
		public unsafe bool alreadyBuildArr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047D2 RID: 18386
		// (get) Token: 0x06024949 RID: 149833 RVA: 0x00942BF0 File Offset: 0x00940DF0
		// (set) Token: 0x0602494A RID: 149834 RVA: 0x00942C00 File Offset: 0x00940E00
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047D3 RID: 18387
		// (get) Token: 0x0602494B RID: 149835 RVA: 0x00942C11 File Offset: 0x00940E11
		// (set) Token: 0x0602494C RID: 149836 RVA: 0x00942C21 File Offset: 0x00940E21
		public unsafe bool NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047D4 RID: 18388
		// (get) Token: 0x0602494D RID: 149837 RVA: 0x00942C32 File Offset: 0x00940E32
		// (set) Token: 0x0602494E RID: 149838 RVA: 0x00942C42 File Offset: 0x00940E42
		public unsafe bool PlatformCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047D5 RID: 18389
		// (get) Token: 0x0602494F RID: 149839 RVA: 0x00942C53 File Offset: 0x00940E53
		// (set) Token: 0x06024950 RID: 149840 RVA: 0x00942C63 File Offset: 0x00940E63
		public unsafe bool bAfterBeginplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BoxCol_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024951 RID: 149841 RVA: 0x00942C74 File Offset: 0x00940E74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BoxCol_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024952 RID: 149842 RVA: 0x00942C88 File Offset: 0x00940E88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BoxCol_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024953 RID: 149843 RVA: 0x00942C9D File Offset: 0x00940E9D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BoxCol_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024954 RID: 149844 RVA: 0x00942CB1 File Offset: 0x00940EB1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BoxCol_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024955 RID: 149845 RVA: 0x00942CC8 File Offset: 0x00940EC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BoxCol_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BoxCol_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BoxCol_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BoxCol_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BoxCol_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024956 RID: 149846 RVA: 0x00942D10 File Offset: 0x00940F10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BoxCol_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BoxCol_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BoxCol_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BoxCol_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BoxCol_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024957 RID: 149847 RVA: 0x00942D58 File Offset: 0x00940F58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_BoxCol_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_BoxCol_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BoxCol_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BoxCol_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BoxCol_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024958 RID: 149848 RVA: 0x00942DA4 File Offset: 0x00940FA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_BoxCol_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_BoxCol_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BoxCol_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BoxCol_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BoxCol_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024959 RID: 149849 RVA: 0x00942DF0 File Offset: 0x00940FF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult Hit)
		{
			BP_BoxCol_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BoxCol_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_BoxCol_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BoxCol_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitComponent = ((HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->NormalImpulse = NormalImpulse;
			if (Hit != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->Hit, Hit.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BoxCol_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602495A RID: 149850 RVA: 0x00942EA4 File Offset: 0x009410A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_BoxCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BoxCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_BoxCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BoxCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BoxCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602495B RID: 149851 RVA: 0x00942F60 File Offset: 0x00941160
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_BoxCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BoxCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BoxCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BoxCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BoxCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602495C RID: 149852 RVA: 0x00942FEC File Offset: 0x009411EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_BoxCol_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_BoxCol_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_BoxCol_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BoxCol_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BoxCol_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602495D RID: 149853 RVA: 0x0094304F File Offset: 0x0094124F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OpenPhysicsVisibility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BoxCol_C.__OpenPhysicsVisibility_NativeFunctionPtr, null);
		}

		// Token: 0x0602495E RID: 149854 RVA: 0x00943063 File Offset: 0x00941263
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void OpenPhysicsVisibility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BoxCol_C.__OpenPhysicsVisibility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602495F RID: 149855 RVA: 0x00943078 File Offset: 0x00941278
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ClosePhysicsVisibility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BoxCol_C.__ClosePhysicsVisibility_NativeFunctionPtr, null);
		}

		// Token: 0x06024960 RID: 149856 RVA: 0x0094308C File Offset: 0x0094128C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ClosePhysicsVisibility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BoxCol_C.__ClosePhysicsVisibility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024961 RID: 149857 RVA: 0x009430A4 File Offset: 0x009412A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnApplyWorldOffset(in FVector InWorldOffset, bool bWorldShift)
		{
			BP_BoxCol_C.__OnApplyWorldOffset_FunctionParams* ptr = stackalloc BP_BoxCol_C.__OnApplyWorldOffset_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_BoxCol_C.__OnApplyWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BoxCol_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InWorldOffset = InWorldOffset;
			ptr->bWorldShift = bWorldShift;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BoxCol_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024962 RID: 149858 RVA: 0x009430F8 File Offset: 0x009412F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnApplyWorldOffset_Implementation(in FVector InWorldOffset, bool bWorldShift)
		{
			BP_BoxCol_C.__OnApplyWorldOffset_FunctionParams* ptr = stackalloc BP_BoxCol_C.__OnApplyWorldOffset_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_BoxCol_C.__OnApplyWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BoxCol_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InWorldOffset = InWorldOffset;
			ptr->bWorldShift = bWorldShift;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BoxCol_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024963 RID: 149859 RVA: 0x0094314C File Offset: 0x0094134C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void AfterTick(float DeltaSeconds)
		{
			BP_BoxCol_C.__AfterTick_FunctionParams* ptr = stackalloc BP_BoxCol_C.__AfterTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BoxCol_C.__AfterTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BoxCol_C.__AfterTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BoxCol_C.__AfterTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024964 RID: 149860 RVA: 0x00943194 File Offset: 0x00941394
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void AfterTick_Implementation(float DeltaSeconds)
		{
			BP_BoxCol_C.__AfterTick_FunctionParams* ptr = stackalloc BP_BoxCol_C.__AfterTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BoxCol_C.__AfterTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BoxCol_C.__AfterTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BoxCol_C.__AfterTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024965 RID: 149861 RVA: 0x009431DB File Offset: 0x009413DB
		protected BP_BoxCol_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012293 RID: 74387
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_BoxCol.BP_BoxCol_C";

		// Token: 0x04012294 RID: 74388
		private static IntPtr _ClassPtr;

		// Token: 0x04012295 RID: 74389
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012296 RID: 74390
		internal static int __PropertyOffset_1;

		// Token: 0x04012297 RID: 74391
		internal static int __PropertyOffset_2;

		// Token: 0x04012298 RID: 74392
		internal static int __PropertyOffset_3;

		// Token: 0x04012299 RID: 74393
		internal static int __PropertyOffset_4;

		// Token: 0x0401229A RID: 74394
		internal static int __PropertyOffset_5;

		// Token: 0x0401229B RID: 74395
		internal static int __PropertyOffset_6;

		// Token: 0x0401229C RID: 74396
		internal static int __PropertyOffset_7;

		// Token: 0x0401229D RID: 74397
		internal static int __PropertyOffset_8;

		// Token: 0x0401229E RID: 74398
		internal static int __PropertyOffset_9;

		// Token: 0x0401229F RID: 74399
		internal static int __PropertyOffset_10;

		// Token: 0x040122A0 RID: 74400
		internal static int __PropertyOffset_11;

		// Token: 0x040122A1 RID: 74401
		internal static int __PropertyOffset_12;

		// Token: 0x040122A2 RID: 74402
		internal static int __PropertyOffset_13;

		// Token: 0x040122A3 RID: 74403
		internal static int __PropertyOffset_14;

		// Token: 0x040122A4 RID: 74404
		internal static int __PropertyOffset_15;

		// Token: 0x040122A5 RID: 74405
		internal static int __PropertyOffset_16;

		// Token: 0x040122A6 RID: 74406
		internal static int __PropertyOffset_17;

		// Token: 0x040122A7 RID: 74407
		internal static int __PropertyOffset_18;

		// Token: 0x040122A8 RID: 74408
		internal static int __PropertyOffset_19;

		// Token: 0x040122A9 RID: 74409
		internal static int __PropertyOffset_20;

		// Token: 0x040122AA RID: 74410
		internal static int __PropertyOffset_21;

		// Token: 0x040122AB RID: 74411
		internal static int __PropertyOffset_22;

		// Token: 0x040122AC RID: 74412
		internal static int __PropertyOffset_23;

		// Token: 0x040122AD RID: 74413
		internal static int __PropertyOffset_24;

		// Token: 0x040122AE RID: 74414
		internal static int __PropertyOffset_25;

		// Token: 0x040122AF RID: 74415
		internal static int __PropertyOffset_26;

		// Token: 0x040122B0 RID: 74416
		internal static int __PropertyOffset_27;

		// Token: 0x040122B1 RID: 74417
		internal static int __PropertyOffset_28;

		// Token: 0x040122B2 RID: 74418
		internal static int __PropertyOffset_29;

		// Token: 0x040122B3 RID: 74419
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040122B4 RID: 74420
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040122B5 RID: 74421
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040122B6 RID: 74422
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x040122B7 RID: 74423
		private static IntPtr __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040122B8 RID: 74424
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040122B9 RID: 74425
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040122BA RID: 74426
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x040122BB RID: 74427
		private static IntPtr __OpenPhysicsVisibility_NativeFunctionPtr;

		// Token: 0x040122BC RID: 74428
		private static IntPtr __ClosePhysicsVisibility_NativeFunctionPtr;

		// Token: 0x040122BD RID: 74429
		private static IntPtr __OnApplyWorldOffset_NativeFunctionPtr;

		// Token: 0x040122BE RID: 74430
		private static IntPtr __AfterTick_NativeFunctionPtr;

		// Token: 0x02009F40 RID: 40768
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040318E3 RID: 202979
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F41 RID: 40769
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040318E4 RID: 202980
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009F42 RID: 40770
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040318E5 RID: 202981
			[FieldOffset(0)]
			public IntPtr HitComponent;

			// Token: 0x040318E6 RID: 202982
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040318E7 RID: 202983
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040318E8 RID: 202984
			[FieldOffset(24)]
			public FVector NormalImpulse;

			// Token: 0x040318E9 RID: 202985
			[FieldOffset(36)]
			public byte Hit;
		}

		// Token: 0x02009F43 RID: 40771
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040318EA RID: 202986
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040318EB RID: 202987
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040318EC RID: 202988
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040318ED RID: 202989
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040318EE RID: 202990
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040318EF RID: 202991
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F44 RID: 40772
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040318F0 RID: 202992
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040318F1 RID: 202993
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040318F2 RID: 202994
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040318F3 RID: 202995
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009F45 RID: 40773
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x040318F4 RID: 202996
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x040318F5 RID: 202997
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x040318F6 RID: 202998
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009F46 RID: 40774
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected new ref struct __OnApplyWorldOffset_FunctionParams
		{
			// Token: 0x040318F7 RID: 202999
			[FieldOffset(0)]
			public FVector InWorldOffset;

			// Token: 0x040318F8 RID: 203000
			[FieldOffset(12)]
			public bool bWorldShift;
		}

		// Token: 0x02009F47 RID: 40775
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __AfterTick_FunctionParams
		{
			// Token: 0x040318F9 RID: 203001
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
