using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MusicInteraction
{
	// Token: 0x02003C4D RID: 15437
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MusicInteraction/BP_MusicMesh.BP_MusicMesh_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class BP_MusicMesh_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023C40 RID: 146496 RVA: 0x0092C388 File Offset: 0x0092A588
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MusicMesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MusicInteraction/BP_MusicMesh.BP_MusicMesh_C");
			}
			return BP_MusicMesh_C._ClassPtr;
		}

		// Token: 0x06023C41 RID: 146497 RVA: 0x0092C3AC File Offset: 0x0092A5AC
		public BP_MusicMesh_C() : this(BuiltinUtils.AllocNativeUObject(BP_MusicMesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023C42 RID: 146498 RVA: 0x0092C3D4 File Offset: 0x0092A5D4
		[NullableContext(1)]
		public BP_MusicMesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MusicMesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004373 RID: 17267
		// (get) Token: 0x06023C43 RID: 146499 RVA: 0x0092C407 File Offset: 0x0092A607
		// (set) Token: 0x06023C44 RID: 146500 RVA: 0x0092C41B File Offset: 0x0092A61B
		public unsafe UStaticMeshComponent StaticMeshComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicMesh_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicMesh_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004374 RID: 17268
		// (get) Token: 0x06023C45 RID: 146501 RVA: 0x0092C430 File Offset: 0x0092A630
		// (set) Token: 0x06023C46 RID: 146502 RVA: 0x0092C444 File Offset: 0x0092A644
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicMesh_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicMesh_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004375 RID: 17269
		// (get) Token: 0x06023C47 RID: 146503 RVA: 0x0092C459 File Offset: 0x0092A659
		// (set) Token: 0x06023C48 RID: 146504 RVA: 0x0092C469 File Offset: 0x0092A669
		public unsafe bool 双拍触发
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004376 RID: 17270
		// (get) Token: 0x06023C49 RID: 146505 RVA: 0x0092C47A File Offset: 0x0092A67A
		// (set) Token: 0x06023C4A RID: 146506 RVA: 0x0092C48A File Offset: 0x0092A68A
		public unsafe float DelayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004377 RID: 17271
		// (get) Token: 0x06023C4B RID: 146507 RVA: 0x0092C49B File Offset: 0x0092A69B
		// (set) Token: 0x06023C4C RID: 146508 RVA: 0x0092C4AB File Offset: 0x0092A6AB
		public unsafe bool Activate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004378 RID: 17272
		// (get) Token: 0x06023C4D RID: 146509 RVA: 0x0092C4BC File Offset: 0x0092A6BC
		// (set) Token: 0x06023C4E RID: 146510 RVA: 0x0092C4D0 File Offset: 0x0092A6D0
		public unsafe UStaticMesh 模型资产
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicMesh_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicMesh_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004379 RID: 17273
		// (get) Token: 0x06023C4F RID: 146511 RVA: 0x0092C4E5 File Offset: 0x0092A6E5
		// (set) Token: 0x06023C50 RID: 146512 RVA: 0x0092C4F5 File Offset: 0x0092A6F5
		public unsafe float 特效延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700437A RID: 17274
		// (get) Token: 0x06023C51 RID: 146513 RVA: 0x0092C506 File Offset: 0x0092A706
		// (set) Token: 0x06023C52 RID: 146514 RVA: 0x0092C516 File Offset: 0x0092A716
		public unsafe float LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700437B RID: 17275
		// (get) Token: 0x06023C53 RID: 146515 RVA: 0x0092C527 File Offset: 0x0092A727
		// (set) Token: 0x06023C54 RID: 146516 RVA: 0x0092C537 File Offset: 0x0092A737
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700437C RID: 17276
		// (get) Token: 0x06023C55 RID: 146517 RVA: 0x0092C548 File Offset: 0x0092A748
		// (set) Token: 0x06023C56 RID: 146518 RVA: 0x0092C558 File Offset: 0x0092A758
		public unsafe float 单拍时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicMesh_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x06023C57 RID: 146519 RVA: 0x0092C569 File Offset: 0x0092A769
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MusicMesh_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023C58 RID: 146520 RVA: 0x0092C57D File Offset: 0x0092A77D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MusicMesh_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023C59 RID: 146521 RVA: 0x0092C594 File Offset: 0x0092A794
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_MusicMesh_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MusicMesh_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MusicMesh_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MusicMesh_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MusicMesh_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023C5A RID: 146522 RVA: 0x0092C5DC File Offset: 0x0092A7DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_MusicMesh_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MusicMesh_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MusicMesh_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MusicMesh_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MusicMesh_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023C5B RID: 146523 RVA: 0x0092C624 File Offset: 0x0092A824
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MusicMesh_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MusicMesh_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MusicMesh_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MusicMesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MusicMesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023C5C RID: 146524 RVA: 0x0092C66C File Offset: 0x0092A86C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MusicMesh_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MusicMesh_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MusicMesh_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MusicMesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MusicMesh_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023C5D RID: 146525 RVA: 0x0092C6B3 File Offset: 0x0092A8B3
		protected BP_MusicMesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011AD1 RID: 72401
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MusicInteraction/BP_MusicMesh.BP_MusicMesh_C";

		// Token: 0x04011AD2 RID: 72402
		private static IntPtr _ClassPtr;

		// Token: 0x04011AD3 RID: 72403
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011AD4 RID: 72404
		internal static int __PropertyOffset_1;

		// Token: 0x04011AD5 RID: 72405
		internal static int __PropertyOffset_2;

		// Token: 0x04011AD6 RID: 72406
		internal static int __PropertyOffset_3;

		// Token: 0x04011AD7 RID: 72407
		internal static int __PropertyOffset_4;

		// Token: 0x04011AD8 RID: 72408
		internal static int __PropertyOffset_5;

		// Token: 0x04011AD9 RID: 72409
		internal static int __PropertyOffset_6;

		// Token: 0x04011ADA RID: 72410
		internal static int __PropertyOffset_7;

		// Token: 0x04011ADB RID: 72411
		internal static int __PropertyOffset_8;

		// Token: 0x04011ADC RID: 72412
		internal static int __PropertyOffset_9;

		// Token: 0x04011ADD RID: 72413
		internal static int __PropertyOffset_10;

		// Token: 0x04011ADE RID: 72414
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011ADF RID: 72415
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011AE0 RID: 72416
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009E9B RID: 40603
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031761 RID: 202593
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E9C RID: 40604
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031762 RID: 202594
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
