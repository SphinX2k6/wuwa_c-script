using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003AF8 RID: 15096
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CageSphere.BP_CageSphere_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1124)]
	public class BP_CageSphere_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020B5F RID: 133983 RVA: 0x008DB2A9 File Offset: 0x008D94A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CageSphere_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CageSphere.BP_CageSphere_C");
			}
			return BP_CageSphere_C._ClassPtr;
		}

		// Token: 0x06020B60 RID: 133984 RVA: 0x008DB2D0 File Offset: 0x008D94D0
		public BP_CageSphere_C() : this(BuiltinUtils.AllocNativeUObject(BP_CageSphere_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020B61 RID: 133985 RVA: 0x008DB2F8 File Offset: 0x008D94F8
		[NullableContext(1)]
		public BP_CageSphere_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CageSphere_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x06020B62 RID: 133986 RVA: 0x008DB32B File Offset: 0x008D952B
		// (set) Token: 0x06020B63 RID: 133987 RVA: 0x008DB33F File Offset: 0x008D953F
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageSphere_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageSphere_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x06020B64 RID: 133988 RVA: 0x008DB354 File Offset: 0x008D9554
		// (set) Token: 0x06020B65 RID: 133989 RVA: 0x008DB368 File Offset: 0x008D9568
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageSphere_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageSphere_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x06020B66 RID: 133990 RVA: 0x008DB37D File Offset: 0x008D957D
		// (set) Token: 0x06020B67 RID: 133991 RVA: 0x008DB391 File Offset: 0x008D9591
		public unsafe UTexture2D Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageSphere_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageSphere_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x06020B68 RID: 133992 RVA: 0x008DB3A6 File Offset: 0x008D95A6
		// (set) Token: 0x06020B69 RID: 133993 RVA: 0x008DB3BA File Offset: 0x008D95BA
		public unsafe UMaterialInstanceDynamic DYMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageSphere_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CageSphere_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x06020B6A RID: 133994 RVA: 0x008DB3CF File Offset: 0x008D95CF
		// (set) Token: 0x06020B6B RID: 133995 RVA: 0x008DB3DF File Offset: 0x008D95DF
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x06020B6C RID: 133996 RVA: 0x008DB3F0 File Offset: 0x008D95F0
		// (set) Token: 0x06020B6D RID: 133997 RVA: 0x008DB400 File Offset: 0x008D9600
		public unsafe float Soft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x06020B6E RID: 133998 RVA: 0x008DB411 File Offset: 0x008D9611
		// (set) Token: 0x06020B6F RID: 133999 RVA: 0x008DB421 File Offset: 0x008D9621
		public unsafe float BlurScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x06020B70 RID: 134000 RVA: 0x008DB432 File Offset: 0x008D9632
		// (set) Token: 0x06020B71 RID: 134001 RVA: 0x008DB442 File Offset: 0x008D9642
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x06020B72 RID: 134002 RVA: 0x008DB453 File Offset: 0x008D9653
		// (set) Token: 0x06020B73 RID: 134003 RVA: 0x008DB463 File Offset: 0x008D9663
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x06020B74 RID: 134004 RVA: 0x008DB474 File Offset: 0x008D9674
		// (set) Token: 0x06020B75 RID: 134005 RVA: 0x008DB484 File Offset: 0x008D9684
		public unsafe float MotionBlur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x06020B76 RID: 134006 RVA: 0x008DB495 File Offset: 0x008D9695
		// (set) Token: 0x06020B77 RID: 134007 RVA: 0x008DB4A5 File Offset: 0x008D96A5
		public unsafe float Zoom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x06020B78 RID: 134008 RVA: 0x008DB4B6 File Offset: 0x008D96B6
		// (set) Token: 0x06020B79 RID: 134009 RVA: 0x008DB4C6 File Offset: 0x008D96C6
		public unsafe float HoldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x06020B7A RID: 134010 RVA: 0x008DB4D7 File Offset: 0x008D96D7
		// (set) Token: 0x06020B7B RID: 134011 RVA: 0x008DB4E7 File Offset: 0x008D96E7
		public unsafe float HoldSoft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CageSphere_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x06020B7C RID: 134012 RVA: 0x008DB4F8 File Offset: 0x008D96F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TickFunction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CageSphere_C.__TickFunction_NativeFunctionPtr, null);
		}

		// Token: 0x06020B7D RID: 134013 RVA: 0x008DB50C File Offset: 0x008D970C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CageSphere_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020B7E RID: 134014 RVA: 0x008DB520 File Offset: 0x008D9720
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CageSphere_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020B7F RID: 134015 RVA: 0x008DB535 File Offset: 0x008D9735
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CageSphere_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020B80 RID: 134016 RVA: 0x008DB549 File Offset: 0x008D9749
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CageSphere_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020B81 RID: 134017 RVA: 0x008DB560 File Offset: 0x008D9760
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CageSphere_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CageSphere_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CageSphere_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CageSphere_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CageSphere_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B82 RID: 134018 RVA: 0x008DB5A8 File Offset: 0x008D97A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CageSphere_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CageSphere_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CageSphere_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CageSphere_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CageSphere_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020B83 RID: 134019 RVA: 0x008DB5F0 File Offset: 0x008D97F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_CageSphere_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_CageSphere_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CageSphere_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CageSphere_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CageSphere_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B84 RID: 134020 RVA: 0x008DB63C File Offset: 0x008D983C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_CageSphere_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_CageSphere_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CageSphere_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CageSphere_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CageSphere_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020B85 RID: 134021 RVA: 0x008DB688 File Offset: 0x008D9888
		protected BP_CageSphere_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE21 RID: 65057
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CageSphere.BP_CageSphere_C";

		// Token: 0x0400FE22 RID: 65058
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE23 RID: 65059
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE24 RID: 65060
		internal static int __PropertyOffset_1;

		// Token: 0x0400FE25 RID: 65061
		internal static int __PropertyOffset_2;

		// Token: 0x0400FE26 RID: 65062
		internal static int __PropertyOffset_3;

		// Token: 0x0400FE27 RID: 65063
		internal static int __PropertyOffset_4;

		// Token: 0x0400FE28 RID: 65064
		internal static int __PropertyOffset_5;

		// Token: 0x0400FE29 RID: 65065
		internal static int __PropertyOffset_6;

		// Token: 0x0400FE2A RID: 65066
		internal static int __PropertyOffset_7;

		// Token: 0x0400FE2B RID: 65067
		internal static int __PropertyOffset_8;

		// Token: 0x0400FE2C RID: 65068
		internal static int __PropertyOffset_9;

		// Token: 0x0400FE2D RID: 65069
		internal static int __PropertyOffset_10;

		// Token: 0x0400FE2E RID: 65070
		internal static int __PropertyOffset_11;

		// Token: 0x0400FE2F RID: 65071
		internal static int __PropertyOffset_12;

		// Token: 0x0400FE30 RID: 65072
		internal static int __PropertyOffset_13;

		// Token: 0x0400FE31 RID: 65073
		private static IntPtr __TickFunction_NativeFunctionPtr;

		// Token: 0x0400FE32 RID: 65074
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FE33 RID: 65075
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FE34 RID: 65076
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FE35 RID: 65077
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009C2B RID: 39979
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312DB RID: 201435
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C2C RID: 39980
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040312DC RID: 201436
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
