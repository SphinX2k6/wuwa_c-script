using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GateAnimation
{
	// Token: 0x02003CC2 RID: 15554
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GateAnimation/BP_MeshKeyTransformController.BP_MeshKeyTransformController_C")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class BP_MeshKeyTransformController_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024C2F RID: 150575 RVA: 0x00947964 File Offset: 0x00945B64
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MeshKeyTransformController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GateAnimation/BP_MeshKeyTransformController.BP_MeshKeyTransformController_C");
			}
			return BP_MeshKeyTransformController_C._ClassPtr;
		}

		// Token: 0x06024C30 RID: 150576 RVA: 0x00947988 File Offset: 0x00945B88
		public BP_MeshKeyTransformController_C() : this(BuiltinUtils.AllocNativeUObject(BP_MeshKeyTransformController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024C31 RID: 150577 RVA: 0x009479B0 File Offset: 0x00945BB0
		[NullableContext(1)]
		public BP_MeshKeyTransformController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MeshKeyTransformController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048F2 RID: 18674
		// (get) Token: 0x06024C32 RID: 150578 RVA: 0x009479E3 File Offset: 0x00945BE3
		// (set) Token: 0x06024C33 RID: 150579 RVA: 0x009479F7 File Offset: 0x00945BF7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshKeyTransformController_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshKeyTransformController_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170048F3 RID: 18675
		// (get) Token: 0x06024C34 RID: 150580 RVA: 0x00947A0C File Offset: 0x00945C0C
		// (set) Token: 0x06024C35 RID: 150581 RVA: 0x00947A1C File Offset: 0x00945C1C
		public unsafe float CustomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshKeyTransformController_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshKeyTransformController_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170048F4 RID: 18676
		// (get) Token: 0x06024C36 RID: 150582 RVA: 0x00947A2D File Offset: 0x00945C2D
		// (set) Token: 0x06024C37 RID: 150583 RVA: 0x00947A3D File Offset: 0x00945C3D
		public unsafe int Random
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshKeyTransformController_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshKeyTransformController_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170048F5 RID: 18677
		// (get) Token: 0x06024C38 RID: 150584 RVA: 0x00947A50 File Offset: 0x00945C50
		// (set) Token: 0x06024C39 RID: 150585 RVA: 0x00947A89 File Offset: 0x00945C89
		[Nullable(1)]
		public TArray<BP_MeshKeyTransform_C> MeshActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<BP_MeshKeyTransform_C> result;
				if ((result = this._MeshActors) == null)
				{
					result = (this._MeshActors = new TArray<BP_MeshKeyTransform_C>(base.NativePtr + (IntPtr)BP_MeshKeyTransformController_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MeshActors.CopyAssign(value);
			}
		}

		// Token: 0x170048F6 RID: 18678
		// (get) Token: 0x06024C3A RID: 150586 RVA: 0x00947A97 File Offset: 0x00945C97
		// (set) Token: 0x06024C3B RID: 150587 RVA: 0x00947AA7 File Offset: 0x00945CA7
		public unsafe float LastTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshKeyTransformController_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshKeyTransformController_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170048F7 RID: 18679
		// (get) Token: 0x06024C3C RID: 150588 RVA: 0x00947AB8 File Offset: 0x00945CB8
		// (set) Token: 0x06024C3D RID: 150589 RVA: 0x00947AC8 File Offset: 0x00945CC8
		public unsafe int LastRandom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshKeyTransformController_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshKeyTransformController_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06024C3E RID: 150590 RVA: 0x00947AD9 File Offset: 0x00945CD9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateTransform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshKeyTransformController_C.__UpdateTransform_NativeFunctionPtr, null);
		}

		// Token: 0x06024C3F RID: 150591 RVA: 0x00947AED File Offset: 0x00945CED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SyncMeshActors()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshKeyTransformController_C.__SyncMeshActors_NativeFunctionPtr, null);
		}

		// Token: 0x06024C40 RID: 150592 RVA: 0x00947B01 File Offset: 0x00945D01
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshKeyTransformController_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024C41 RID: 150593 RVA: 0x00947B15 File Offset: 0x00945D15
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshKeyTransformController_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024C42 RID: 150594 RVA: 0x00947B2C File Offset: 0x00945D2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MeshKeyTransformController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshKeyTransformController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshKeyTransformController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshKeyTransformController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshKeyTransformController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024C43 RID: 150595 RVA: 0x00947B74 File Offset: 0x00945D74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MeshKeyTransformController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshKeyTransformController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshKeyTransformController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshKeyTransformController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshKeyTransformController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024C44 RID: 150596 RVA: 0x00947BBC File Offset: 0x00945DBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_MeshKeyTransformController_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MeshKeyTransformController_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshKeyTransformController_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshKeyTransformController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshKeyTransformController_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024C45 RID: 150597 RVA: 0x00947C04 File Offset: 0x00945E04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_MeshKeyTransformController_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MeshKeyTransformController_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshKeyTransformController_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshKeyTransformController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshKeyTransformController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024C46 RID: 150598 RVA: 0x00947C4B File Offset: 0x00945E4B
		protected BP_MeshKeyTransformController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401243C RID: 74812
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GateAnimation/BP_MeshKeyTransformController.BP_MeshKeyTransformController_C";

		// Token: 0x0401243D RID: 74813
		private static IntPtr _ClassPtr;

		// Token: 0x0401243E RID: 74814
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401243F RID: 74815
		internal static int __PropertyOffset_1;

		// Token: 0x04012440 RID: 74816
		internal static int __PropertyOffset_2;

		// Token: 0x04012441 RID: 74817
		internal static int __PropertyOffset_3;

		// Token: 0x04012442 RID: 74818
		internal static int __PropertyOffset_4;

		// Token: 0x04012443 RID: 74819
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_MeshKeyTransform_C> _MeshActors;

		// Token: 0x04012444 RID: 74820
		internal static int __PropertyOffset_5;

		// Token: 0x04012445 RID: 74821
		internal static int __PropertyOffset_6;

		// Token: 0x04012446 RID: 74822
		private static IntPtr __UpdateTransform_NativeFunctionPtr;

		// Token: 0x04012447 RID: 74823
		private static IntPtr __SyncMeshActors_NativeFunctionPtr;

		// Token: 0x04012448 RID: 74824
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012449 RID: 74825
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401244A RID: 74826
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009F66 RID: 40806
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403195C RID: 203100
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F67 RID: 40807
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403195D RID: 203101
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
