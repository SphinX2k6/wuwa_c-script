using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_Cymbal1
{
	// Token: 0x02003C48 RID: 15432
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PBD_Cymbal1/BP_PBD_Cymbal1.BP_PBD_Cymbal1_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1492)]
	public class BP_PBD_Cymbal1_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023BAF RID: 146351 RVA: 0x0092B3E4 File Offset: 0x009295E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PBD_Cymbal1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PBD_Cymbal1/BP_PBD_Cymbal1.BP_PBD_Cymbal1_C");
			}
			return BP_PBD_Cymbal1_C._ClassPtr;
		}

		// Token: 0x06023BB0 RID: 146352 RVA: 0x0092B408 File Offset: 0x00929608
		public BP_PBD_Cymbal1_C() : this(BuiltinUtils.AllocNativeUObject(BP_PBD_Cymbal1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023BB1 RID: 146353 RVA: 0x0092B430 File Offset: 0x00929630
		[NullableContext(1)]
		public BP_PBD_Cymbal1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PBD_Cymbal1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004341 RID: 17217
		// (get) Token: 0x06023BB2 RID: 146354 RVA: 0x0092B463 File Offset: 0x00929663
		// (set) Token: 0x06023BB3 RID: 146355 RVA: 0x0092B477 File Offset: 0x00929677
		public unsafe UStaticMeshComponent Base
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PBD_Cymbal1_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PBD_Cymbal1_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004342 RID: 17218
		// (get) Token: 0x06023BB4 RID: 146356 RVA: 0x0092B48C File Offset: 0x0092968C
		// (set) Token: 0x06023BB5 RID: 146357 RVA: 0x0092B4A0 File Offset: 0x009296A0
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PBD_Cymbal1_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PBD_Cymbal1_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004343 RID: 17219
		// (get) Token: 0x06023BB6 RID: 146358 RVA: 0x0092B4B5 File Offset: 0x009296B5
		// (set) Token: 0x06023BB7 RID: 146359 RVA: 0x0092B4C5 File Offset: 0x009296C5
		public unsafe float PlayerImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PBD_Cymbal1_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PBD_Cymbal1_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004344 RID: 17220
		// (get) Token: 0x06023BB8 RID: 146360 RVA: 0x0092B4D6 File Offset: 0x009296D6
		// (set) Token: 0x06023BB9 RID: 146361 RVA: 0x0092B4EA File Offset: 0x009296EA
		public unsafe FRotator Delta_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PBD_Cymbal1_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PBD_Cymbal1_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004345 RID: 17221
		// (get) Token: 0x06023BBA RID: 146362 RVA: 0x0092B4FF File Offset: 0x009296FF
		// (set) Token: 0x06023BBB RID: 146363 RVA: 0x0092B50F File Offset: 0x0092970F
		public unsafe float X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PBD_Cymbal1_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PBD_Cymbal1_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004346 RID: 17222
		// (get) Token: 0x06023BBC RID: 146364 RVA: 0x0092B520 File Offset: 0x00929720
		// (set) Token: 0x06023BBD RID: 146365 RVA: 0x0092B530 File Offset: 0x00929730
		public unsafe float Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PBD_Cymbal1_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PBD_Cymbal1_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004347 RID: 17223
		// (get) Token: 0x06023BBE RID: 146366 RVA: 0x0092B541 File Offset: 0x00929741
		// (set) Token: 0x06023BBF RID: 146367 RVA: 0x0092B551 File Offset: 0x00929751
		public unsafe float LerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PBD_Cymbal1_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PBD_Cymbal1_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x06023BC0 RID: 146368 RVA: 0x0092B564 File Offset: 0x00929764
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PBD_Cymbal1_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PBD_Cymbal1_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PBD_Cymbal1_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PBD_Cymbal1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PBD_Cymbal1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023BC1 RID: 146369 RVA: 0x0092B5AC File Offset: 0x009297AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PBD_Cymbal1_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PBD_Cymbal1_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PBD_Cymbal1_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PBD_Cymbal1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PBD_Cymbal1_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023BC2 RID: 146370 RVA: 0x0092B5F3 File Offset: 0x009297F3
		protected BP_PBD_Cymbal1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A7E RID: 72318
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_Cymbal1/BP_PBD_Cymbal1.BP_PBD_Cymbal1_C";

		// Token: 0x04011A7F RID: 72319
		private static IntPtr _ClassPtr;

		// Token: 0x04011A80 RID: 72320
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A81 RID: 72321
		internal static int __PropertyOffset_1;

		// Token: 0x04011A82 RID: 72322
		internal static int __PropertyOffset_2;

		// Token: 0x04011A83 RID: 72323
		internal static int __PropertyOffset_3;

		// Token: 0x04011A84 RID: 72324
		internal static int __PropertyOffset_4;

		// Token: 0x04011A85 RID: 72325
		internal static int __PropertyOffset_5;

		// Token: 0x04011A86 RID: 72326
		internal static int __PropertyOffset_6;

		// Token: 0x04011A87 RID: 72327
		internal static int __PropertyOffset_7;

		// Token: 0x04011A88 RID: 72328
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009E93 RID: 40595
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031759 RID: 202585
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
