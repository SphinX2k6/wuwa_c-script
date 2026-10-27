using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Billboard
{
	// Token: 0x02003DE3 RID: 15843
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Billboard/BP_Billboard.BP_Billboard_C")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 228)]
	public class BP_Billboard_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027855 RID: 161877 RVA: 0x00993A38 File Offset: 0x00991C38
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Billboard_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Billboard/BP_Billboard.BP_Billboard_C");
			}
			return BP_Billboard_C._ClassPtr;
		}

		// Token: 0x06027856 RID: 161878 RVA: 0x00993A5C File Offset: 0x00991C5C
		public BP_Billboard_C() : this(BuiltinUtils.AllocNativeUObject(BP_Billboard_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027857 RID: 161879 RVA: 0x00993A84 File Offset: 0x00991C84
		[NullableContext(1)]
		public BP_Billboard_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Billboard_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005893 RID: 22675
		// (get) Token: 0x06027858 RID: 161880 RVA: 0x00993AB7 File Offset: 0x00991CB7
		// (set) Token: 0x06027859 RID: 161881 RVA: 0x00993ACB File Offset: 0x00991CCB
		public unsafe TEnumAsByte<E_BillboardMode> 广告版轴向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Billboard_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Billboard_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005894 RID: 22676
		// (get) Token: 0x0602785A RID: 161882 RVA: 0x00993AE0 File Offset: 0x00991CE0
		// (set) Token: 0x0602785B RID: 161883 RVA: 0x00993AF0 File Offset: 0x00991CF0
		public unsafe bool 每帧更新
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Billboard_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Billboard_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005895 RID: 22677
		// (get) Token: 0x0602785C RID: 161884 RVA: 0x00993B01 File Offset: 0x00991D01
		// (set) Token: 0x0602785D RID: 161885 RVA: 0x00993B11 File Offset: 0x00991D11
		public unsafe bool 固定大小
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Billboard_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Billboard_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005896 RID: 22678
		// (get) Token: 0x0602785E RID: 161886 RVA: 0x00993B22 File Offset: 0x00991D22
		// (set) Token: 0x0602785F RID: 161887 RVA: 0x00993B32 File Offset: 0x00991D32
		public unsafe float 缩放尺寸
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Billboard_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Billboard_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005897 RID: 22679
		// (get) Token: 0x06027860 RID: 161888 RVA: 0x00993B43 File Offset: 0x00991D43
		// (set) Token: 0x06027861 RID: 161889 RVA: 0x00993B53 File Offset: 0x00991D53
		public unsafe float 最大距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Billboard_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Billboard_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x06027862 RID: 161890 RVA: 0x00993B64 File Offset: 0x00991D64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalculateScaleSize(float Scale, FVectorDouble CameraLocation, ref FVector NewParam)
		{
			BP_Billboard_C.__CalculateScaleSize_FunctionParams* ptr = stackalloc BP_Billboard_C.__CalculateScaleSize_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_Billboard_C.__CalculateScaleSize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Billboard_C.__CalculateScaleSize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Scale = Scale;
			ptr->CameraLocation = CameraLocation;
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Billboard_C.__CalculateScaleSize_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x06027863 RID: 161891 RVA: 0x00993BCC File Offset: 0x00991DCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetActorScaleSize(FVector Scale, bool bRelativeScale)
		{
			BP_Billboard_C.__SetActorScaleSize_FunctionParams* ptr = stackalloc BP_Billboard_C.__SetActorScaleSize_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_Billboard_C.__SetActorScaleSize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Billboard_C.__SetActorScaleSize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Scale = Scale;
			ptr->bRelativeScale = bRelativeScale;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Billboard_C.__SetActorScaleSize_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027864 RID: 161892 RVA: 0x00993C1C File Offset: 0x00991E1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetActorRotation(FRotator Rotation)
		{
			BP_Billboard_C.__SetActorRotation_FunctionParams* ptr = stackalloc BP_Billboard_C.__SetActorRotation_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Billboard_C.__SetActorRotation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Billboard_C.__SetActorRotation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Rotation = Rotation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Billboard_C.__SetActorRotation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027865 RID: 161893 RVA: 0x00993C64 File Offset: 0x00991E64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalculateRotation(FVectorDouble CameraPosition, ref FRotator Rotation)
		{
			BP_Billboard_C.__CalculateRotation_FunctionParams* ptr = stackalloc BP_Billboard_C.__CalculateRotation_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_Billboard_C.__CalculateRotation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Billboard_C.__CalculateRotation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CameraPosition = CameraPosition;
			ptr->Rotation = Rotation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Billboard_C.__CalculateRotation_NativeFunctionPtr, (void*)ptr);
			Rotation = ptr->Rotation;
		}

		// Token: 0x06027866 RID: 161894 RVA: 0x00993CC5 File Offset: 0x00991EC5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Billboard_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06027867 RID: 161895 RVA: 0x00993CD9 File Offset: 0x00991ED9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Billboard_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027868 RID: 161896 RVA: 0x00993CF0 File Offset: 0x00991EF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Billboard_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Billboard_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Billboard_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Billboard_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Billboard_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027869 RID: 161897 RVA: 0x00993D38 File Offset: 0x00991F38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Billboard_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Billboard_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Billboard_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Billboard_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Billboard_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602786A RID: 161898 RVA: 0x00993D7F File Offset: 0x00991F7F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Run()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Billboard_C.__Run_NativeFunctionPtr, null);
		}

		// Token: 0x0602786B RID: 161899 RVA: 0x00993D93 File Offset: 0x00991F93
		protected BP_Billboard_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013FA4 RID: 81828
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Billboard/BP_Billboard.BP_Billboard_C";

		// Token: 0x04013FA5 RID: 81829
		private static IntPtr _ClassPtr;

		// Token: 0x04013FA6 RID: 81830
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013FA7 RID: 81831
		internal static int __PropertyOffset_1;

		// Token: 0x04013FA8 RID: 81832
		internal static int __PropertyOffset_2;

		// Token: 0x04013FA9 RID: 81833
		internal static int __PropertyOffset_3;

		// Token: 0x04013FAA RID: 81834
		internal static int __PropertyOffset_4;

		// Token: 0x04013FAB RID: 81835
		internal static int __PropertyOffset_5;

		// Token: 0x04013FAC RID: 81836
		private static IntPtr __CalculateScaleSize_NativeFunctionPtr;

		// Token: 0x04013FAD RID: 81837
		private static IntPtr __SetActorScaleSize_NativeFunctionPtr;

		// Token: 0x04013FAE RID: 81838
		private static IntPtr __SetActorRotation_NativeFunctionPtr;

		// Token: 0x04013FAF RID: 81839
		private static IntPtr __CalculateRotation_NativeFunctionPtr;

		// Token: 0x04013FB0 RID: 81840
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013FB1 RID: 81841
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013FB2 RID: 81842
		private static IntPtr __Run_NativeFunctionPtr;

		// Token: 0x0200A241 RID: 41537
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __CalculateScaleSize_FunctionParams
		{
			// Token: 0x04031ECE RID: 204494
			[FieldOffset(0)]
			public float Scale;

			// Token: 0x04031ECF RID: 204495
			[FieldOffset(8)]
			public FVectorDouble CameraLocation;

			// Token: 0x04031ED0 RID: 204496
			[FieldOffset(32)]
			public FVector NewParam;
		}

		// Token: 0x0200A242 RID: 41538
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetActorScaleSize_FunctionParams
		{
			// Token: 0x04031ED1 RID: 204497
			[FieldOffset(0)]
			public FVector Scale;

			// Token: 0x04031ED2 RID: 204498
			[FieldOffset(12)]
			public bool bRelativeScale;
		}

		// Token: 0x0200A243 RID: 41539
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetActorRotation_FunctionParams
		{
			// Token: 0x04031ED3 RID: 204499
			[FieldOffset(0)]
			public FRotator Rotation;
		}

		// Token: 0x0200A244 RID: 41540
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __CalculateRotation_FunctionParams
		{
			// Token: 0x04031ED4 RID: 204500
			[FieldOffset(0)]
			public FVectorDouble CameraPosition;

			// Token: 0x04031ED5 RID: 204501
			[FieldOffset(24)]
			public FRotator Rotation;
		}

		// Token: 0x0200A245 RID: 41541
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031ED6 RID: 204502
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
