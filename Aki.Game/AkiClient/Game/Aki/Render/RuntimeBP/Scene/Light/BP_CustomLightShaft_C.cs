using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B00 RID: 15104
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CustomLightShaft.BP_CustomLightShaft_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1096)]
	public class BP_CustomLightShaft_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020C9B RID: 134299 RVA: 0x008DD3D8 File Offset: 0x008DB5D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CustomLightShaft_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CustomLightShaft.BP_CustomLightShaft_C");
			}
			return BP_CustomLightShaft_C._ClassPtr;
		}

		// Token: 0x06020C9C RID: 134300 RVA: 0x008DD3FC File Offset: 0x008DB5FC
		public BP_CustomLightShaft_C() : this(BuiltinUtils.AllocNativeUObject(BP_CustomLightShaft_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020C9D RID: 134301 RVA: 0x008DD424 File Offset: 0x008DB624
		[NullableContext(1)]
		public BP_CustomLightShaft_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CustomLightShaft_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x06020C9E RID: 134302 RVA: 0x008DD457 File Offset: 0x008DB657
		// (set) Token: 0x06020C9F RID: 134303 RVA: 0x008DD46B File Offset: 0x008DB66B
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomLightShaft_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomLightShaft_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x06020CA0 RID: 134304 RVA: 0x008DD480 File Offset: 0x008DB680
		// (set) Token: 0x06020CA1 RID: 134305 RVA: 0x008DD490 File Offset: 0x008DB690
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomLightShaft_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomLightShaft_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x06020CA2 RID: 134306 RVA: 0x008DD4A1 File Offset: 0x008DB6A1
		// (set) Token: 0x06020CA3 RID: 134307 RVA: 0x008DD4B1 File Offset: 0x008DB6B1
		public unsafe float Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomLightShaft_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomLightShaft_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x06020CA4 RID: 134308 RVA: 0x008DD4C2 File Offset: 0x008DB6C2
		// (set) Token: 0x06020CA5 RID: 134309 RVA: 0x008DD4D2 File Offset: 0x008DB6D2
		public unsafe float BackIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomLightShaft_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomLightShaft_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x06020CA6 RID: 134310 RVA: 0x008DD4E3 File Offset: 0x008DB6E3
		// (set) Token: 0x06020CA7 RID: 134311 RVA: 0x008DD4F3 File Offset: 0x008DB6F3
		public unsafe float Soft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomLightShaft_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomLightShaft_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x06020CA8 RID: 134312 RVA: 0x008DD504 File Offset: 0x008DB704
		// (set) Token: 0x06020CA9 RID: 134313 RVA: 0x008DD518 File Offset: 0x008DB718
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomLightShaft_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomLightShaft_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06020CAA RID: 134314 RVA: 0x008DD52D File Offset: 0x008DB72D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void tick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomLightShaft_C.__tick_NativeFunctionPtr, null);
		}

		// Token: 0x06020CAB RID: 134315 RVA: 0x008DD541 File Offset: 0x008DB741
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomLightShaft_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020CAC RID: 134316 RVA: 0x008DD555 File Offset: 0x008DB755
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomLightShaft_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020CAD RID: 134317 RVA: 0x008DD56A File Offset: 0x008DB76A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomLightShaft_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020CAE RID: 134318 RVA: 0x008DD57E File Offset: 0x008DB77E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomLightShaft_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020CAF RID: 134319 RVA: 0x008DD594 File Offset: 0x008DB794
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CustomLightShaft_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CustomLightShaft_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CustomLightShaft_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CustomLightShaft_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomLightShaft_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020CB0 RID: 134320 RVA: 0x008DD5DC File Offset: 0x008DB7DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CustomLightShaft_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CustomLightShaft_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CustomLightShaft_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CustomLightShaft_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomLightShaft_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020CB1 RID: 134321 RVA: 0x008DD624 File Offset: 0x008DB824
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_CustomLightShaft_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_CustomLightShaft_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CustomLightShaft_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CustomLightShaft_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomLightShaft_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020CB2 RID: 134322 RVA: 0x008DD670 File Offset: 0x008DB870
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_CustomLightShaft_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_CustomLightShaft_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CustomLightShaft_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CustomLightShaft_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomLightShaft_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020CB3 RID: 134323 RVA: 0x008DD6BC File Offset: 0x008DB8BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomLightShaft_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06020CB4 RID: 134324 RVA: 0x008DD6D0 File Offset: 0x008DB8D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomLightShaft_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020CB5 RID: 134325 RVA: 0x008DD6E5 File Offset: 0x008DB8E5
		protected BP_CustomLightShaft_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FED5 RID: 65237
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CustomLightShaft.BP_CustomLightShaft_C";

		// Token: 0x0400FED6 RID: 65238
		private static IntPtr _ClassPtr;

		// Token: 0x0400FED7 RID: 65239
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FED8 RID: 65240
		internal static int __PropertyOffset_1;

		// Token: 0x0400FED9 RID: 65241
		internal static int __PropertyOffset_2;

		// Token: 0x0400FEDA RID: 65242
		internal static int __PropertyOffset_3;

		// Token: 0x0400FEDB RID: 65243
		internal static int __PropertyOffset_4;

		// Token: 0x0400FEDC RID: 65244
		internal static int __PropertyOffset_5;

		// Token: 0x0400FEDD RID: 65245
		internal static int __PropertyOffset_6;

		// Token: 0x0400FEDE RID: 65246
		private static IntPtr __tick_NativeFunctionPtr;

		// Token: 0x0400FEDF RID: 65247
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FEE0 RID: 65248
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FEE1 RID: 65249
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FEE2 RID: 65250
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0400FEE3 RID: 65251
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x02009C3B RID: 39995
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312EB RID: 201451
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C3C RID: 39996
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040312EC RID: 201452
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
