using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003D9E RID: 15774
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaRelativeVelocityOffsetComponent.NinjaRelativeVelocityOffsetComponent_C")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 262)]
	public class NinjaRelativeVelocityOffsetComponent_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060272A1 RID: 160417 RVA: 0x00989A8C File Offset: 0x00987C8C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NinjaRelativeVelocityOffsetComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaRelativeVelocityOffsetComponent.NinjaRelativeVelocityOffsetComponent_C");
			}
			return NinjaRelativeVelocityOffsetComponent_C._ClassPtr;
		}

		// Token: 0x060272A2 RID: 160418 RVA: 0x00989AB0 File Offset: 0x00987CB0
		public NinjaRelativeVelocityOffsetComponent_C() : this(BuiltinUtils.AllocNativeUObject(NinjaRelativeVelocityOffsetComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060272A3 RID: 160419 RVA: 0x00989AD8 File Offset: 0x00987CD8
		[NullableContext(1)]
		public NinjaRelativeVelocityOffsetComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NinjaRelativeVelocityOffsetComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170056AB RID: 22187
		// (get) Token: 0x060272A4 RID: 160420 RVA: 0x00989B0B File Offset: 0x00987D0B
		// (set) Token: 0x060272A5 RID: 160421 RVA: 0x00989B1F File Offset: 0x00987D1F
		[Nullable(2)]
		public unsafe NinjaLiveComponent_C NinjaLiveComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<NinjaLiveComponent_C>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170056AC RID: 22188
		// (get) Token: 0x060272A6 RID: 160422 RVA: 0x00989B34 File Offset: 0x00987D34
		// (set) Token: 0x060272A7 RID: 160423 RVA: 0x00989B44 File Offset: 0x00987D44
		public unsafe float ScaleX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170056AD RID: 22189
		// (get) Token: 0x060272A8 RID: 160424 RVA: 0x00989B55 File Offset: 0x00987D55
		// (set) Token: 0x060272A9 RID: 160425 RVA: 0x00989B65 File Offset: 0x00987D65
		public unsafe float ScaleY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170056AE RID: 22190
		// (get) Token: 0x060272AA RID: 160426 RVA: 0x00989B76 File Offset: 0x00987D76
		// (set) Token: 0x060272AB RID: 160427 RVA: 0x00989B8A File Offset: 0x00987D8A
		public unsafe FVector WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170056AF RID: 22191
		// (get) Token: 0x060272AC RID: 160428 RVA: 0x00989B9F File Offset: 0x00987D9F
		// (set) Token: 0x060272AD RID: 160429 RVA: 0x00989BAF File Offset: 0x00987DAF
		public unsafe bool UseWorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056B0 RID: 22192
		// (get) Token: 0x060272AE RID: 160430 RVA: 0x00989BC0 File Offset: 0x00987DC0
		// (set) Token: 0x060272AF RID: 160431 RVA: 0x00989BD4 File Offset: 0x00987DD4
		public unsafe FVector2D HorizontalFacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170056B1 RID: 22193
		// (get) Token: 0x060272B0 RID: 160432 RVA: 0x00989BE9 File Offset: 0x00987DE9
		// (set) Token: 0x060272B1 RID: 160433 RVA: 0x00989BF9 File Offset: 0x00987DF9
		public unsafe float ClampDotProdct
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170056B2 RID: 22194
		// (get) Token: 0x060272B2 RID: 160434 RVA: 0x00989C0A File Offset: 0x00987E0A
		// (set) Token: 0x060272B3 RID: 160435 RVA: 0x00989C1A File Offset: 0x00987E1A
		public unsafe bool UseViewProjectionMatrix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056B3 RID: 22195
		// (get) Token: 0x060272B4 RID: 160436 RVA: 0x00989C2B File Offset: 0x00987E2B
		// (set) Token: 0x060272B5 RID: 160437 RVA: 0x00989C3B File Offset: 0x00987E3B
		public unsafe bool DebugMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaRelativeVelocityOffsetComponent_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x060272B6 RID: 160438 RVA: 0x00989C4C File Offset: 0x00987E4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LocateNinjaLiveComponent()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaRelativeVelocityOffsetComponent_C.__LocateNinjaLiveComponent_NativeFunctionPtr, null);
		}

		// Token: 0x060272B7 RID: 160439 RVA: 0x00989C60 File Offset: 0x00987E60
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetOffsets(NinjaLiveComponent_C NinjaLiveComponent, FVector2D Velocity)
		{
			NinjaRelativeVelocityOffsetComponent_C.__SetOffsets_FunctionParams* ptr = stackalloc NinjaRelativeVelocityOffsetComponent_C.__SetOffsets_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaRelativeVelocityOffsetComponent_C.__SetOffsets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaRelativeVelocityOffsetComponent_C.__SetOffsets_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NinjaLiveComponent = ((NinjaLiveComponent != null) ? NinjaLiveComponent.NativePtr : IntPtr.Zero);
			ptr->Velocity = Velocity;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaRelativeVelocityOffsetComponent_C.__SetOffsets_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060272B8 RID: 160440 RVA: 0x00989CBC File Offset: 0x00987EBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CompareIndividualOffsets(ref FVector2D Velocity)
		{
			NinjaRelativeVelocityOffsetComponent_C.__CompareIndividualOffsets_FunctionParams* ptr = stackalloc NinjaRelativeVelocityOffsetComponent_C.__CompareIndividualOffsets_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(NinjaRelativeVelocityOffsetComponent_C.__CompareIndividualOffsets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaRelativeVelocityOffsetComponent_C.__CompareIndividualOffsets_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Velocity = Velocity;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaRelativeVelocityOffsetComponent_C.__CompareIndividualOffsets_NativeFunctionPtr, (void*)ptr);
			Velocity = ptr->Velocity;
		}

		// Token: 0x060272B9 RID: 160441 RVA: 0x00989D14 File Offset: 0x00987F14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ViewProjectionTransform(ref FVector2D Velocity)
		{
			NinjaRelativeVelocityOffsetComponent_C.__ViewProjectionTransform_FunctionParams* ptr = stackalloc NinjaRelativeVelocityOffsetComponent_C.__ViewProjectionTransform_FunctionParams[(UIntPtr)3023] + 15L / (long)sizeof(NinjaRelativeVelocityOffsetComponent_C.__ViewProjectionTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaRelativeVelocityOffsetComponent_C.__ViewProjectionTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Velocity = Velocity;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaRelativeVelocityOffsetComponent_C.__ViewProjectionTransform_NativeFunctionPtr, (void*)ptr);
			Velocity = ptr->Velocity;
		}

		// Token: 0x060272BA RID: 160442 RVA: 0x00989D70 File Offset: 0x00987F70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ProjectOffsetToScreen(bool PlayerViewportRelative, ref FVector2D Velocity, ref bool IsValid)
		{
			NinjaRelativeVelocityOffsetComponent_C.__ProjectOffsetToScreen_FunctionParams* ptr = stackalloc NinjaRelativeVelocityOffsetComponent_C.__ProjectOffsetToScreen_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(NinjaRelativeVelocityOffsetComponent_C.__ProjectOffsetToScreen_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaRelativeVelocityOffsetComponent_C.__ProjectOffsetToScreen_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerViewportRelative = PlayerViewportRelative;
			ptr->Velocity = Velocity;
			ptr->IsValid = IsValid;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaRelativeVelocityOffsetComponent_C.__ProjectOffsetToScreen_NativeFunctionPtr, (void*)ptr);
			Velocity = ptr->Velocity;
			IsValid = ptr->IsValid;
		}

		// Token: 0x060272BB RID: 160443 RVA: 0x00989DE4 File Offset: 0x00987FE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DrawDebug2D(FVector2D Direction, float Scale, float ArrowSize, FLinearColor Color, float Duration, float Thickness)
		{
			NinjaRelativeVelocityOffsetComponent_C.__DrawDebug2D_FunctionParams* ptr = stackalloc NinjaRelativeVelocityOffsetComponent_C.__DrawDebug2D_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(NinjaRelativeVelocityOffsetComponent_C.__DrawDebug2D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaRelativeVelocityOffsetComponent_C.__DrawDebug2D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Direction = Direction;
			ptr->Scale = Scale;
			ptr->ArrowSize = ArrowSize;
			ptr->Color = Color;
			ptr->Duration = Duration;
			ptr->Thickness = Thickness;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaRelativeVelocityOffsetComponent_C.__DrawDebug2D_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060272BC RID: 160444 RVA: 0x00989E53 File Offset: 0x00988053
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetRelativeVelocityOffset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaRelativeVelocityOffsetComponent_C.__SetRelativeVelocityOffset_NativeFunctionPtr, null);
		}

		// Token: 0x060272BD RID: 160445 RVA: 0x00989E68 File Offset: 0x00988068
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			NinjaRelativeVelocityOffsetComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaRelativeVelocityOffsetComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaRelativeVelocityOffsetComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaRelativeVelocityOffsetComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaRelativeVelocityOffsetComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060272BE RID: 160446 RVA: 0x00989EB0 File Offset: 0x009880B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			NinjaRelativeVelocityOffsetComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaRelativeVelocityOffsetComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaRelativeVelocityOffsetComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaRelativeVelocityOffsetComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaRelativeVelocityOffsetComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060272BF RID: 160447 RVA: 0x00989EF7 File Offset: 0x009880F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaRelativeVelocityOffsetComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060272C0 RID: 160448 RVA: 0x00989F0B File Offset: 0x0098810B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaRelativeVelocityOffsetComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060272C1 RID: 160449 RVA: 0x00989F20 File Offset: 0x00988120
		protected NinjaRelativeVelocityOffsetComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013BE5 RID: 80869
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaRelativeVelocityOffsetComponent.NinjaRelativeVelocityOffsetComponent_C";

		// Token: 0x04013BE6 RID: 80870
		private static IntPtr _ClassPtr;

		// Token: 0x04013BE7 RID: 80871
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013BE8 RID: 80872
		internal static int __PropertyOffset_1;

		// Token: 0x04013BE9 RID: 80873
		internal static int __PropertyOffset_2;

		// Token: 0x04013BEA RID: 80874
		internal static int __PropertyOffset_3;

		// Token: 0x04013BEB RID: 80875
		internal static int __PropertyOffset_4;

		// Token: 0x04013BEC RID: 80876
		internal static int __PropertyOffset_5;

		// Token: 0x04013BED RID: 80877
		internal static int __PropertyOffset_6;

		// Token: 0x04013BEE RID: 80878
		internal static int __PropertyOffset_7;

		// Token: 0x04013BEF RID: 80879
		internal static int __PropertyOffset_8;

		// Token: 0x04013BF0 RID: 80880
		internal static int __PropertyOffset_9;

		// Token: 0x04013BF1 RID: 80881
		private static IntPtr __LocateNinjaLiveComponent_NativeFunctionPtr;

		// Token: 0x04013BF2 RID: 80882
		private static IntPtr __SetOffsets_NativeFunctionPtr;

		// Token: 0x04013BF3 RID: 80883
		private static IntPtr __CompareIndividualOffsets_NativeFunctionPtr;

		// Token: 0x04013BF4 RID: 80884
		private static IntPtr __ViewProjectionTransform_NativeFunctionPtr;

		// Token: 0x04013BF5 RID: 80885
		private static IntPtr __ProjectOffsetToScreen_NativeFunctionPtr;

		// Token: 0x04013BF6 RID: 80886
		private static IntPtr __DrawDebug2D_NativeFunctionPtr;

		// Token: 0x04013BF7 RID: 80887
		private static IntPtr __SetRelativeVelocityOffset_NativeFunctionPtr;

		// Token: 0x04013BF8 RID: 80888
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013BF9 RID: 80889
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A1E2 RID: 41442
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetOffsets_FunctionParams
		{
			// Token: 0x04031E35 RID: 204341
			[FieldOffset(0)]
			public IntPtr NinjaLiveComponent;

			// Token: 0x04031E36 RID: 204342
			[FieldOffset(8)]
			public FVector2D Velocity;
		}

		// Token: 0x0200A1E3 RID: 41443
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __CompareIndividualOffsets_FunctionParams
		{
			// Token: 0x04031E37 RID: 204343
			[FieldOffset(0)]
			public FVector2D Velocity;
		}

		// Token: 0x0200A1E4 RID: 41444
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3008)]
		protected ref struct __ViewProjectionTransform_FunctionParams
		{
			// Token: 0x04031E38 RID: 204344
			[FieldOffset(0)]
			public FVector2D Velocity;
		}

		// Token: 0x0200A1E5 RID: 41445
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected ref struct __ProjectOffsetToScreen_FunctionParams
		{
			// Token: 0x04031E39 RID: 204345
			[FieldOffset(0)]
			public bool PlayerViewportRelative;

			// Token: 0x04031E3A RID: 204346
			[FieldOffset(4)]
			public FVector2D Velocity;

			// Token: 0x04031E3B RID: 204347
			[FieldOffset(12)]
			public bool IsValid;
		}

		// Token: 0x0200A1E6 RID: 41446
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __DrawDebug2D_FunctionParams
		{
			// Token: 0x04031E3C RID: 204348
			[FieldOffset(0)]
			public FVector2D Direction;

			// Token: 0x04031E3D RID: 204349
			[FieldOffset(8)]
			public float Scale;

			// Token: 0x04031E3E RID: 204350
			[FieldOffset(12)]
			public float ArrowSize;

			// Token: 0x04031E3F RID: 204351
			[FieldOffset(16)]
			public FLinearColor Color;

			// Token: 0x04031E40 RID: 204352
			[FieldOffset(32)]
			public float Duration;

			// Token: 0x04031E41 RID: 204353
			[FieldOffset(36)]
			public float Thickness;
		}

		// Token: 0x0200A1E7 RID: 41447
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031E42 RID: 204354
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
