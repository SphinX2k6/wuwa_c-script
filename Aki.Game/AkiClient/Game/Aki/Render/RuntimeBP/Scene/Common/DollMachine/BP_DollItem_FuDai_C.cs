using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B8D RID: 15245
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_FuDai.BP_DollItem_FuDai_C")]
	[UnrealStructLayout(1792, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1792)]
	public class BP_DollItem_FuDai_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021EEA RID: 138986 RVA: 0x008F9E55 File Offset: 0x008F8055
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_FuDai_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_FuDai.BP_DollItem_FuDai_C");
			}
			return BP_DollItem_FuDai_C._ClassPtr;
		}

		// Token: 0x06021EEB RID: 138987 RVA: 0x008F9E7C File Offset: 0x008F807C
		public BP_DollItem_FuDai_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_FuDai_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021EEC RID: 138988 RVA: 0x008F9EA4 File Offset: 0x008F80A4
		[NullableContext(1)]
		public BP_DollItem_FuDai_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_FuDai_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x06021EED RID: 138989 RVA: 0x008F9ED7 File Offset: 0x008F80D7
		// (set) Token: 0x06021EEE RID: 138990 RVA: 0x008F9EEB File Offset: 0x008F80EB
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x06021EEF RID: 138991 RVA: 0x008F9F00 File Offset: 0x008F8100
		// (set) Token: 0x06021EF0 RID: 138992 RVA: 0x008F9F14 File Offset: 0x008F8114
		public unsafe UNiagaraComponent NS_Fx_Sl2_MZ_FuDai_02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x06021EF1 RID: 138993 RVA: 0x008F9F29 File Offset: 0x008F8129
		// (set) Token: 0x06021EF2 RID: 138994 RVA: 0x008F9F3D File Offset: 0x008F813D
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x06021EF3 RID: 138995 RVA: 0x008F9F52 File Offset: 0x008F8152
		// (set) Token: 0x06021EF4 RID: 138996 RVA: 0x008F9F66 File Offset: 0x008F8166
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x06021EF5 RID: 138997 RVA: 0x008F9F7B File Offset: 0x008F817B
		// (set) Token: 0x06021EF6 RID: 138998 RVA: 0x008F9F8B File Offset: 0x008F818B
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollItem_FuDai_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollItem_FuDai_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x06021EF7 RID: 138999 RVA: 0x008F9F9C File Offset: 0x008F819C
		// (set) Token: 0x06021EF8 RID: 139000 RVA: 0x008F9FB0 File Offset: 0x008F81B0
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollItem_FuDai_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollItem_FuDai_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x06021EF9 RID: 139001 RVA: 0x008F9FC5 File Offset: 0x008F81C5
		// (set) Token: 0x06021EFA RID: 139002 RVA: 0x008F9FD5 File Offset: 0x008F81D5
		public unsafe float Tightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollItem_FuDai_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollItem_FuDai_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x06021EFB RID: 139003 RVA: 0x008F9FE6 File Offset: 0x008F81E6
		// (set) Token: 0x06021EFC RID: 139004 RVA: 0x008F9FFA File Offset: 0x008F81FA
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x06021EFD RID: 139005 RVA: 0x008FA00F File Offset: 0x008F820F
		// (set) Token: 0x06021EFE RID: 139006 RVA: 0x008FA023 File Offset: 0x008F8223
		public unsafe UHoudiniPointCache HoudiniPointCache
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x06021EFF RID: 139007 RVA: 0x008FA038 File Offset: 0x008F8238
		// (set) Token: 0x06021F00 RID: 139008 RVA: 0x008FA048 File Offset: 0x008F8248
		public unsafe float dt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollItem_FuDai_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollItem_FuDai_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x06021F01 RID: 139009 RVA: 0x008FA059 File Offset: 0x008F8259
		// (set) Token: 0x06021F02 RID: 139010 RVA: 0x008FA069 File Offset: 0x008F8269
		public unsafe float fade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollItem_FuDai_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollItem_FuDai_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003912 RID: 14610
		// (get) Token: 0x06021F03 RID: 139011 RVA: 0x008FA07A File Offset: 0x008F827A
		// (set) Token: 0x06021F04 RID: 139012 RVA: 0x008FA08E File Offset: 0x008F828E
		public unsafe UMaterialInstance InputMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x06021F05 RID: 139013 RVA: 0x008FA0A3 File Offset: 0x008F82A3
		// (set) Token: 0x06021F06 RID: 139014 RVA: 0x008FA0B7 File Offset: 0x008F82B7
		public unsafe UMaterialInstanceDynamic Dmaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x06021F07 RID: 139015 RVA: 0x008FA0CC File Offset: 0x008F82CC
		// (set) Token: 0x06021F08 RID: 139016 RVA: 0x008FA0E0 File Offset: 0x008F82E0
		public unsafe UMaterialInstanceDynamic Dmaterial_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x06021F09 RID: 139017 RVA: 0x008FA0F5 File Offset: 0x008F82F5
		// (set) Token: 0x06021F0A RID: 139018 RVA: 0x008FA109 File Offset: 0x008F8309
		public unsafe UMaterialInstance InputMaterial_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_FuDai_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x06021F0B RID: 139019 RVA: 0x008FA11E File Offset: 0x008F831E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_FuDai_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021F0C RID: 139020 RVA: 0x008FA132 File Offset: 0x008F8332
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollItem_FuDai_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021F0D RID: 139021 RVA: 0x008FA147 File Offset: 0x008F8347
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_FuDai_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021F0E RID: 139022 RVA: 0x008FA15B File Offset: 0x008F835B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollItem_FuDai_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021F0F RID: 139023 RVA: 0x008FA170 File Offset: 0x008F8370
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DollItem_FuDai_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DollItem_FuDai_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DollItem_FuDai_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollItem_FuDai_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_FuDai_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021F10 RID: 139024 RVA: 0x008FA1B8 File Offset: 0x008F83B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DollItem_FuDai_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DollItem_FuDai_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DollItem_FuDai_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollItem_FuDai_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollItem_FuDai_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021F11 RID: 139025 RVA: 0x008FA1FF File Offset: 0x008F83FF
		protected BP_DollItem_FuDai_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401096C RID: 67948
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_FuDai.BP_DollItem_FuDai_C";

		// Token: 0x0401096D RID: 67949
		private static IntPtr _ClassPtr;

		// Token: 0x0401096E RID: 67950
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401096F RID: 67951
		internal new static int __PropertyOffset_1;

		// Token: 0x04010970 RID: 67952
		internal new static int __PropertyOffset_2;

		// Token: 0x04010971 RID: 67953
		internal new static int __PropertyOffset_3;

		// Token: 0x04010972 RID: 67954
		internal new static int __PropertyOffset_4;

		// Token: 0x04010973 RID: 67955
		internal new static int __PropertyOffset_5;

		// Token: 0x04010974 RID: 67956
		internal new static int __PropertyOffset_6;

		// Token: 0x04010975 RID: 67957
		internal new static int __PropertyOffset_7;

		// Token: 0x04010976 RID: 67958
		internal new static int __PropertyOffset_8;

		// Token: 0x04010977 RID: 67959
		internal new static int __PropertyOffset_9;

		// Token: 0x04010978 RID: 67960
		internal new static int __PropertyOffset_10;

		// Token: 0x04010979 RID: 67961
		internal new static int __PropertyOffset_11;

		// Token: 0x0401097A RID: 67962
		internal static int __PropertyOffset_12;

		// Token: 0x0401097B RID: 67963
		internal static int __PropertyOffset_13;

		// Token: 0x0401097C RID: 67964
		internal static int __PropertyOffset_14;

		// Token: 0x0401097D RID: 67965
		internal static int __PropertyOffset_15;

		// Token: 0x0401097E RID: 67966
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401097F RID: 67967
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010980 RID: 67968
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009CF5 RID: 40181
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040313F6 RID: 201718
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
