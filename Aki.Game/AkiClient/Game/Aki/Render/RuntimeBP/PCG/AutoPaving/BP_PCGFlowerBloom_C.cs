using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.AutoPaving
{
	// Token: 0x02003CDD RID: 15581
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/AutoPaving/BP_PCGFlowerBloom.BP_PCGFlowerBloom_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1486)]
	public class BP_PCGFlowerBloom_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024FE5 RID: 151525 RVA: 0x0094E13F File Offset: 0x0094C33F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PCGFlowerBloom_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/AutoPaving/BP_PCGFlowerBloom.BP_PCGFlowerBloom_C");
			}
			return BP_PCGFlowerBloom_C._ClassPtr;
		}

		// Token: 0x06024FE6 RID: 151526 RVA: 0x0094E164 File Offset: 0x0094C364
		public BP_PCGFlowerBloom_C() : this(BuiltinUtils.AllocNativeUObject(BP_PCGFlowerBloom_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024FE7 RID: 151527 RVA: 0x0094E18C File Offset: 0x0094C38C
		[NullableContext(1)]
		public BP_PCGFlowerBloom_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PCGFlowerBloom_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A3B RID: 19003
		// (get) Token: 0x06024FE8 RID: 151528 RVA: 0x0094E1BF File Offset: 0x0094C3BF
		// (set) Token: 0x06024FE9 RID: 151529 RVA: 0x0094E1D3 File Offset: 0x0094C3D3
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGFlowerBloom_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGFlowerBloom_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004A3C RID: 19004
		// (get) Token: 0x06024FEA RID: 151530 RVA: 0x0094E1E8 File Offset: 0x0094C3E8
		// (set) Token: 0x06024FEB RID: 151531 RVA: 0x0094E1FC File Offset: 0x0094C3FC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGFlowerBloom_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PCGFlowerBloom_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004A3D RID: 19005
		// (get) Token: 0x06024FEC RID: 151532 RVA: 0x0094E211 File Offset: 0x0094C411
		// (set) Token: 0x06024FED RID: 151533 RVA: 0x0094E221 File Offset: 0x0094C421
		public unsafe bool EdirotTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGFlowerBloom_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGFlowerBloom_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A3E RID: 19006
		// (get) Token: 0x06024FEE RID: 151534 RVA: 0x0094E232 File Offset: 0x0094C432
		// (set) Token: 0x06024FEF RID: 151535 RVA: 0x0094E242 File Offset: 0x0094C442
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGFlowerBloom_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGFlowerBloom_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004A3F RID: 19007
		// (get) Token: 0x06024FF0 RID: 151536 RVA: 0x0094E253 File Offset: 0x0094C453
		// (set) Token: 0x06024FF1 RID: 151537 RVA: 0x0094E263 File Offset: 0x0094C463
		public unsafe float CustomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGFlowerBloom_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGFlowerBloom_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004A40 RID: 19008
		// (get) Token: 0x06024FF2 RID: 151538 RVA: 0x0094E274 File Offset: 0x0094C474
		// (set) Token: 0x06024FF3 RID: 151539 RVA: 0x0094E284 File Offset: 0x0094C484
		public unsafe bool Finished
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGFlowerBloom_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGFlowerBloom_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A41 RID: 19009
		// (get) Token: 0x06024FF4 RID: 151540 RVA: 0x0094E295 File Offset: 0x0094C495
		// (set) Token: 0x06024FF5 RID: 151541 RVA: 0x0094E2A5 File Offset: 0x0094C4A5
		public unsafe bool Started
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PCGFlowerBloom_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PCGFlowerBloom_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024FF6 RID: 151542 RVA: 0x0094E2B6 File Offset: 0x0094C4B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGFlowerBloom_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024FF7 RID: 151543 RVA: 0x0094E2CA File Offset: 0x0094C4CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PCGFlowerBloom_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024FF8 RID: 151544 RVA: 0x0094E2E0 File Offset: 0x0094C4E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PCGFlowerBloom_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PCGFlowerBloom_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PCGFlowerBloom_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGFlowerBloom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGFlowerBloom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024FF9 RID: 151545 RVA: 0x0094E328 File Offset: 0x0094C528
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PCGFlowerBloom_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PCGFlowerBloom_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PCGFlowerBloom_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGFlowerBloom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PCGFlowerBloom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024FFA RID: 151546 RVA: 0x0094E370 File Offset: 0x0094C570
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_PCGFlowerBloom_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PCGFlowerBloom_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PCGFlowerBloom_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGFlowerBloom_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PCGFlowerBloom_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024FFB RID: 151547 RVA: 0x0094E3B8 File Offset: 0x0094C5B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_PCGFlowerBloom_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PCGFlowerBloom_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PCGFlowerBloom_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PCGFlowerBloom_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PCGFlowerBloom_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024FFC RID: 151548 RVA: 0x0094E3FF File Offset: 0x0094C5FF
		protected BP_PCGFlowerBloom_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401265F RID: 75359
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/AutoPaving/BP_PCGFlowerBloom.BP_PCGFlowerBloom_C";

		// Token: 0x04012660 RID: 75360
		private static IntPtr _ClassPtr;

		// Token: 0x04012661 RID: 75361
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012662 RID: 75362
		internal static int __PropertyOffset_1;

		// Token: 0x04012663 RID: 75363
		internal static int __PropertyOffset_2;

		// Token: 0x04012664 RID: 75364
		internal static int __PropertyOffset_3;

		// Token: 0x04012665 RID: 75365
		internal static int __PropertyOffset_4;

		// Token: 0x04012666 RID: 75366
		internal static int __PropertyOffset_5;

		// Token: 0x04012667 RID: 75367
		internal static int __PropertyOffset_6;

		// Token: 0x04012668 RID: 75368
		internal static int __PropertyOffset_7;

		// Token: 0x04012669 RID: 75369
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401266A RID: 75370
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401266B RID: 75371
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009F9D RID: 40861
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040319E3 RID: 203235
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F9E RID: 40862
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040319E4 RID: 203236
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
