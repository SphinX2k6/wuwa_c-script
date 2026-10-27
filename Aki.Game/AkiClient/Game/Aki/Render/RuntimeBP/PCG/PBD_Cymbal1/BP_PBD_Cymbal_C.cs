using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_Cymbal1
{
	// Token: 0x02003C49 RID: 15433
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PBD_Cymbal1/BP_PBD_Cymbal.BP_PBD_Cymbal_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1492)]
	public class BP_PBD_Cymbal_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023BC3 RID: 146371 RVA: 0x0092B5FC File Offset: 0x009297FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PBD_Cymbal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PBD_Cymbal1/BP_PBD_Cymbal.BP_PBD_Cymbal_C");
			}
			return BP_PBD_Cymbal_C._ClassPtr;
		}

		// Token: 0x06023BC4 RID: 146372 RVA: 0x0092B620 File Offset: 0x00929820
		public BP_PBD_Cymbal_C() : this(BuiltinUtils.AllocNativeUObject(BP_PBD_Cymbal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023BC5 RID: 146373 RVA: 0x0092B648 File Offset: 0x00929848
		[NullableContext(1)]
		public BP_PBD_Cymbal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PBD_Cymbal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004348 RID: 17224
		// (get) Token: 0x06023BC6 RID: 146374 RVA: 0x0092B67B File Offset: 0x0092987B
		// (set) Token: 0x06023BC7 RID: 146375 RVA: 0x0092B68F File Offset: 0x0092988F
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PBD_Cymbal_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PBD_Cymbal_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004349 RID: 17225
		// (get) Token: 0x06023BC8 RID: 146376 RVA: 0x0092B6A4 File Offset: 0x009298A4
		// (set) Token: 0x06023BC9 RID: 146377 RVA: 0x0092B6B8 File Offset: 0x009298B8
		public unsafe UStaticMeshComponent Base
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PBD_Cymbal_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PBD_Cymbal_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700434A RID: 17226
		// (get) Token: 0x06023BCA RID: 146378 RVA: 0x0092B6CD File Offset: 0x009298CD
		// (set) Token: 0x06023BCB RID: 146379 RVA: 0x0092B6DD File Offset: 0x009298DD
		public unsafe float PlayerImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PBD_Cymbal_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PBD_Cymbal_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700434B RID: 17227
		// (get) Token: 0x06023BCC RID: 146380 RVA: 0x0092B6EE File Offset: 0x009298EE
		// (set) Token: 0x06023BCD RID: 146381 RVA: 0x0092B6FE File Offset: 0x009298FE
		public unsafe float LerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PBD_Cymbal_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PBD_Cymbal_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700434C RID: 17228
		// (get) Token: 0x06023BCE RID: 146382 RVA: 0x0092B70F File Offset: 0x0092990F
		// (set) Token: 0x06023BCF RID: 146383 RVA: 0x0092B723 File Offset: 0x00929923
		public unsafe FRotator Delta_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PBD_Cymbal_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PBD_Cymbal_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700434D RID: 17229
		// (get) Token: 0x06023BD0 RID: 146384 RVA: 0x0092B738 File Offset: 0x00929938
		// (set) Token: 0x06023BD1 RID: 146385 RVA: 0x0092B748 File Offset: 0x00929948
		public unsafe float X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PBD_Cymbal_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PBD_Cymbal_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700434E RID: 17230
		// (get) Token: 0x06023BD2 RID: 146386 RVA: 0x0092B759 File Offset: 0x00929959
		// (set) Token: 0x06023BD3 RID: 146387 RVA: 0x0092B769 File Offset: 0x00929969
		public unsafe float Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PBD_Cymbal_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PBD_Cymbal_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x06023BD4 RID: 146388 RVA: 0x0092B77C File Offset: 0x0092997C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PBD_Cymbal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PBD_Cymbal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PBD_Cymbal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PBD_Cymbal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PBD_Cymbal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023BD5 RID: 146389 RVA: 0x0092B7C4 File Offset: 0x009299C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PBD_Cymbal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PBD_Cymbal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PBD_Cymbal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PBD_Cymbal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PBD_Cymbal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023BD6 RID: 146390 RVA: 0x0092B80B File Offset: 0x00929A0B
		protected BP_PBD_Cymbal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A89 RID: 72329
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_Cymbal1/BP_PBD_Cymbal.BP_PBD_Cymbal_C";

		// Token: 0x04011A8A RID: 72330
		private static IntPtr _ClassPtr;

		// Token: 0x04011A8B RID: 72331
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A8C RID: 72332
		internal static int __PropertyOffset_1;

		// Token: 0x04011A8D RID: 72333
		internal static int __PropertyOffset_2;

		// Token: 0x04011A8E RID: 72334
		internal static int __PropertyOffset_3;

		// Token: 0x04011A8F RID: 72335
		internal static int __PropertyOffset_4;

		// Token: 0x04011A90 RID: 72336
		internal static int __PropertyOffset_5;

		// Token: 0x04011A91 RID: 72337
		internal static int __PropertyOffset_6;

		// Token: 0x04011A92 RID: 72338
		internal static int __PropertyOffset_7;

		// Token: 0x04011A93 RID: 72339
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009E94 RID: 40596
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403175A RID: 202586
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
