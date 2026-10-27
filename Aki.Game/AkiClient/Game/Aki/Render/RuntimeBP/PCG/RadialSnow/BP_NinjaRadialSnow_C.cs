using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive;
using AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Volumetrics;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RadialSnow
{
	// Token: 0x02003C30 RID: 15408
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RadialSnow/BP_NinjaRadialSnow.BP_NinjaRadialSnow_C")]
	[UnrealStructLayout(2264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2260)]
	public class BP_NinjaRadialSnow_C : NinjaLive_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602366F RID: 145007 RVA: 0x00923044 File Offset: 0x00921244
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NinjaRadialSnow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/RadialSnow/BP_NinjaRadialSnow.BP_NinjaRadialSnow_C");
			}
			return BP_NinjaRadialSnow_C._ClassPtr;
		}

		// Token: 0x06023670 RID: 145008 RVA: 0x00923068 File Offset: 0x00921268
		public BP_NinjaRadialSnow_C() : this(BuiltinUtils.AllocNativeUObject(BP_NinjaRadialSnow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023671 RID: 145009 RVA: 0x00923090 File Offset: 0x00921290
		[NullableContext(1)]
		public BP_NinjaRadialSnow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NinjaRadialSnow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004120 RID: 16672
		// (get) Token: 0x06023672 RID: 145010 RVA: 0x009230C3 File Offset: 0x009212C3
		// (set) Token: 0x06023673 RID: 145011 RVA: 0x009230D7 File Offset: 0x009212D7
		public unsafe UStaticMeshComponent DepthSlicer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaRadialSnow_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaRadialSnow_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004121 RID: 16673
		// (get) Token: 0x06023674 RID: 145012 RVA: 0x009230EC File Offset: 0x009212EC
		// (set) Token: 0x06023675 RID: 145013 RVA: 0x00923100 File Offset: 0x00921300
		public unsafe VolumeSmokeComponent_C VolumeSmokeComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<VolumeSmokeComponent_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaRadialSnow_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaRadialSnow_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004122 RID: 16674
		// (get) Token: 0x06023676 RID: 145014 RVA: 0x00923115 File Offset: 0x00921315
		// (set) Token: 0x06023677 RID: 145015 RVA: 0x00923125 File Offset: 0x00921325
		public unsafe bool OnMeltPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004123 RID: 16675
		// (get) Token: 0x06023678 RID: 145016 RVA: 0x00923136 File Offset: 0x00921336
		// (set) Token: 0x06023679 RID: 145017 RVA: 0x00923146 File Offset: 0x00921346
		public unsafe bool bMoto
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004124 RID: 16676
		// (get) Token: 0x0602367A RID: 145018 RVA: 0x00923157 File Offset: 0x00921357
		// (set) Token: 0x0602367B RID: 145019 RVA: 0x00923167 File Offset: 0x00921367
		public unsafe float OriginKuroTrailEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004125 RID: 16677
		// (get) Token: 0x0602367C RID: 145020 RVA: 0x00923178 File Offset: 0x00921378
		// (set) Token: 0x0602367D RID: 145021 RVA: 0x00923188 File Offset: 0x00921388
		public unsafe float CharacterVeloMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004126 RID: 16678
		// (get) Token: 0x0602367E RID: 145022 RVA: 0x00923199 File Offset: 0x00921399
		// (set) Token: 0x0602367F RID: 145023 RVA: 0x009231A9 File Offset: 0x009213A9
		public unsafe float CharacterGlobalBrush
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004127 RID: 16679
		// (get) Token: 0x06023680 RID: 145024 RVA: 0x009231BA File Offset: 0x009213BA
		// (set) Token: 0x06023681 RID: 145025 RVA: 0x009231CE File Offset: 0x009213CE
		public unsafe BP_GlobalGI_C GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaRadialSnow_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaRadialSnow_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004128 RID: 16680
		// (get) Token: 0x06023682 RID: 145026 RVA: 0x009231E3 File Offset: 0x009213E3
		// (set) Token: 0x06023683 RID: 145027 RVA: 0x009231F3 File Offset: 0x009213F3
		public unsafe bool bIsVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004129 RID: 16681
		// (get) Token: 0x06023684 RID: 145028 RVA: 0x00923204 File Offset: 0x00921404
		// (set) Token: 0x06023685 RID: 145029 RVA: 0x0092323D File Offset: 0x0092143D
		[Nullable(1)]
		public TSet<string> physicMaterialSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._physicMaterialSet) == null)
				{
					result = (this._physicMaterialSet = new TSet<string>(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.physicMaterialSet.CopyAssign(value);
			}
		}

		// Token: 0x1700412A RID: 16682
		// (get) Token: 0x06023686 RID: 145030 RVA: 0x0092324B File Offset: 0x0092144B
		// (set) Token: 0x06023687 RID: 145031 RVA: 0x0092325F File Offset: 0x0092145F
		public unsafe UMaterialInterface VolumeSmokeMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaRadialSnow_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaRadialSnow_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x1700412B RID: 16683
		// (get) Token: 0x06023688 RID: 145032 RVA: 0x00923274 File Offset: 0x00921474
		// (set) Token: 0x06023689 RID: 145033 RVA: 0x00923284 File Offset: 0x00921484
		public unsafe float BrushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700412C RID: 16684
		// (get) Token: 0x0602368A RID: 145034 RVA: 0x00923295 File Offset: 0x00921495
		// (set) Token: 0x0602368B RID: 145035 RVA: 0x009232A5 File Offset: 0x009214A5
		public unsafe float BrushScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700412D RID: 16685
		// (get) Token: 0x0602368C RID: 145036 RVA: 0x009232B6 File Offset: 0x009214B6
		// (set) Token: 0x0602368D RID: 145037 RVA: 0x009232CA File Offset: 0x009214CA
		public unsafe FVectorDouble ValidBoxLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700412E RID: 16686
		// (get) Token: 0x0602368E RID: 145038 RVA: 0x009232DF File Offset: 0x009214DF
		// (set) Token: 0x0602368F RID: 145039 RVA: 0x009232F3 File Offset: 0x009214F3
		public unsafe UTextureRenderTarget2D VolumeSmokeInputRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaRadialSnow_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaRadialSnow_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700412F RID: 16687
		// (get) Token: 0x06023690 RID: 145040 RVA: 0x00923308 File Offset: 0x00921508
		// (set) Token: 0x06023691 RID: 145041 RVA: 0x00923318 File Offset: 0x00921518
		public unsafe int CachedQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaRadialSnow_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x06023692 RID: 145042 RVA: 0x0092332C File Offset: 0x0092152C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CheckQuality(ref bool IsValid)
		{
			BP_NinjaRadialSnow_C.__CheckQuality_FunctionParams* ptr = stackalloc BP_NinjaRadialSnow_C.__CheckQuality_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_NinjaRadialSnow_C.__CheckQuality_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NinjaRadialSnow_C.__CheckQuality_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsValid = IsValid;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NinjaRadialSnow_C.__CheckQuality_NativeFunctionPtr, (void*)ptr);
			IsValid = ptr->IsValid;
		}

		// Token: 0x06023693 RID: 145043 RVA: 0x0092337B File Offset: 0x0092157B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NinjaRadialSnow_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023694 RID: 145044 RVA: 0x0092338F File Offset: 0x0092158F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NinjaRadialSnow_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023695 RID: 145045 RVA: 0x009233A4 File Offset: 0x009215A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_NinjaRadialSnow_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_NinjaRadialSnow_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_NinjaRadialSnow_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NinjaRadialSnow_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NinjaRadialSnow_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023696 RID: 145046 RVA: 0x009233F0 File Offset: 0x009215F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_NinjaRadialSnow_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_NinjaRadialSnow_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_NinjaRadialSnow_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NinjaRadialSnow_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NinjaRadialSnow_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023697 RID: 145047 RVA: 0x0092343C File Offset: 0x0092163C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_NinjaRadialSnow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NinjaRadialSnow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NinjaRadialSnow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NinjaRadialSnow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NinjaRadialSnow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023698 RID: 145048 RVA: 0x00923484 File Offset: 0x00921684
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_NinjaRadialSnow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NinjaRadialSnow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NinjaRadialSnow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NinjaRadialSnow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NinjaRadialSnow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023699 RID: 145049 RVA: 0x009234CB File Offset: 0x009216CB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NinjaRadialSnow_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602369A RID: 145050 RVA: 0x009234DF File Offset: 0x009216DF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NinjaRadialSnow_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602369B RID: 145051 RVA: 0x009234F4 File Offset: 0x009216F4
		protected BP_NinjaRadialSnow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401178D RID: 71565
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RadialSnow/BP_NinjaRadialSnow.BP_NinjaRadialSnow_C";

		// Token: 0x0401178E RID: 71566
		private static IntPtr _ClassPtr;

		// Token: 0x0401178F RID: 71567
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011790 RID: 71568
		internal new static int __PropertyOffset_1;

		// Token: 0x04011791 RID: 71569
		internal new static int __PropertyOffset_2;

		// Token: 0x04011792 RID: 71570
		internal new static int __PropertyOffset_3;

		// Token: 0x04011793 RID: 71571
		internal new static int __PropertyOffset_4;

		// Token: 0x04011794 RID: 71572
		internal new static int __PropertyOffset_5;

		// Token: 0x04011795 RID: 71573
		internal new static int __PropertyOffset_6;

		// Token: 0x04011796 RID: 71574
		internal new static int __PropertyOffset_7;

		// Token: 0x04011797 RID: 71575
		internal new static int __PropertyOffset_8;

		// Token: 0x04011798 RID: 71576
		internal new static int __PropertyOffset_9;

		// Token: 0x04011799 RID: 71577
		internal new static int __PropertyOffset_10;

		// Token: 0x0401179A RID: 71578
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _physicMaterialSet;

		// Token: 0x0401179B RID: 71579
		internal new static int __PropertyOffset_11;

		// Token: 0x0401179C RID: 71580
		internal new static int __PropertyOffset_12;

		// Token: 0x0401179D RID: 71581
		internal new static int __PropertyOffset_13;

		// Token: 0x0401179E RID: 71582
		internal new static int __PropertyOffset_14;

		// Token: 0x0401179F RID: 71583
		internal new static int __PropertyOffset_15;

		// Token: 0x040117A0 RID: 71584
		internal new static int __PropertyOffset_16;

		// Token: 0x040117A1 RID: 71585
		private static IntPtr __CheckQuality_NativeFunctionPtr;

		// Token: 0x040117A2 RID: 71586
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040117A3 RID: 71587
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x040117A4 RID: 71588
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040117A5 RID: 71589
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009E67 RID: 40551
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __CheckQuality_FunctionParams
		{
			// Token: 0x040316ED RID: 202477
			[FieldOffset(0)]
			public bool IsValid;
		}

		// Token: 0x02009E68 RID: 40552
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040316EE RID: 202478
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009E69 RID: 40553
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316EF RID: 202479
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
