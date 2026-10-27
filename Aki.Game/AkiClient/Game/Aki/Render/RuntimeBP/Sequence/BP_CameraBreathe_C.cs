using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence
{
	// Token: 0x02003AD5 RID: 15061
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/BP_CameraBreathe.BP_CameraBreathe_C")]
	[UnrealStructLayout(1560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1560)]
	public class BP_CameraBreathe_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020819 RID: 133145 RVA: 0x008D4994 File Offset: 0x008D2B94
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CameraBreathe_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/BP_CameraBreathe.BP_CameraBreathe_C");
			}
			return BP_CameraBreathe_C._ClassPtr;
		}

		// Token: 0x0602081A RID: 133146 RVA: 0x008D49B8 File Offset: 0x008D2BB8
		public BP_CameraBreathe_C() : this(BuiltinUtils.AllocNativeUObject(BP_CameraBreathe_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602081B RID: 133147 RVA: 0x008D49E0 File Offset: 0x008D2BE0
		[NullableContext(1)]
		public BP_CameraBreathe_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CameraBreathe_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x0602081C RID: 133148 RVA: 0x008D4A13 File Offset: 0x008D2C13
		// (set) Token: 0x0602081D RID: 133149 RVA: 0x008D4A27 File Offset: 0x008D2C27
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraBreathe_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraBreathe_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x0602081E RID: 133150 RVA: 0x008D4A3C File Offset: 0x008D2C3C
		// (set) Token: 0x0602081F RID: 133151 RVA: 0x008D4A50 File Offset: 0x008D2C50
		public unsafe ACameraActor Camera
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACameraActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraBreathe_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraBreathe_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x06020820 RID: 133152 RVA: 0x008D4A65 File Offset: 0x008D2C65
		// (set) Token: 0x06020821 RID: 133153 RVA: 0x008D4A79 File Offset: 0x008D2C79
		public unsafe AActor CameraAttachActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraBreathe_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraBreathe_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x06020822 RID: 133154 RVA: 0x008D4A8E File Offset: 0x008D2C8E
		// (set) Token: 0x06020823 RID: 133155 RVA: 0x008D4A9E File Offset: 0x008D2C9E
		public unsafe float CameraNewFocalLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x06020824 RID: 133156 RVA: 0x008D4AAF File Offset: 0x008D2CAF
		// (set) Token: 0x06020825 RID: 133157 RVA: 0x008D4AC3 File Offset: 0x008D2CC3
		public unsafe FVectorDouble CameraMoveTransform_D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x06020826 RID: 133158 RVA: 0x008D4AD8 File Offset: 0x008D2CD8
		// (set) Token: 0x06020827 RID: 133159 RVA: 0x008D4AE8 File Offset: 0x008D2CE8
		public unsafe float PositionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x06020828 RID: 133160 RVA: 0x008D4AF9 File Offset: 0x008D2CF9
		// (set) Token: 0x06020829 RID: 133161 RVA: 0x008D4B09 File Offset: 0x008D2D09
		public unsafe float FOVIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x0602082A RID: 133162 RVA: 0x008D4B1A File Offset: 0x008D2D1A
		// (set) Token: 0x0602082B RID: 133163 RVA: 0x008D4B2A File Offset: 0x008D2D2A
		public unsafe float StartManualFocusDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x0602082C RID: 133164 RVA: 0x008D4B3B File Offset: 0x008D2D3B
		// (set) Token: 0x0602082D RID: 133165 RVA: 0x008D4B4B File Offset: 0x008D2D4B
		public unsafe float DifParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x0602082E RID: 133166 RVA: 0x008D4B5C File Offset: 0x008D2D5C
		// (set) Token: 0x0602082F RID: 133167 RVA: 0x008D4B6C File Offset: 0x008D2D6C
		public unsafe float K_ManualFocusDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x06020830 RID: 133168 RVA: 0x008D4B7D File Offset: 0x008D2D7D
		// (set) Token: 0x06020831 RID: 133169 RVA: 0x008D4B91 File Offset: 0x008D2D91
		public unsafe FVectorDouble SequenceCenterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraBreathe_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x06020832 RID: 133170 RVA: 0x008D4BA6 File Offset: 0x008D2DA6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraBreathe_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x06020833 RID: 133171 RVA: 0x008D4BBA File Offset: 0x008D2DBA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraBreathe_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020834 RID: 133172 RVA: 0x008D4BCE File Offset: 0x008D2DCE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraBreathe_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020835 RID: 133173 RVA: 0x008D4BE4 File Offset: 0x008D2DE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CameraBreathe_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CameraBreathe_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraBreathe_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraBreathe_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraBreathe_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020836 RID: 133174 RVA: 0x008D4C2C File Offset: 0x008D2E2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CameraBreathe_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CameraBreathe_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraBreathe_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraBreathe_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraBreathe_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020837 RID: 133175 RVA: 0x008D4C74 File Offset: 0x008D2E74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CameraBreathe_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CameraBreathe_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraBreathe_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraBreathe_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraBreathe_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020838 RID: 133176 RVA: 0x008D4CBC File Offset: 0x008D2EBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CameraBreathe_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CameraBreathe_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraBreathe_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraBreathe_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraBreathe_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020839 RID: 133177 RVA: 0x008D4D03 File Offset: 0x008D2F03
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraBreathe_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0602083A RID: 133178 RVA: 0x008D4D17 File Offset: 0x008D2F17
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraBreathe_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602083B RID: 133179 RVA: 0x008D4D2C File Offset: 0x008D2F2C
		protected BP_CameraBreathe_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBFC RID: 64508
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/BP_CameraBreathe.BP_CameraBreathe_C";

		// Token: 0x0400FBFD RID: 64509
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBFE RID: 64510
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBFF RID: 64511
		internal static int __PropertyOffset_1;

		// Token: 0x0400FC00 RID: 64512
		internal static int __PropertyOffset_2;

		// Token: 0x0400FC01 RID: 64513
		internal static int __PropertyOffset_3;

		// Token: 0x0400FC02 RID: 64514
		internal static int __PropertyOffset_4;

		// Token: 0x0400FC03 RID: 64515
		internal static int __PropertyOffset_5;

		// Token: 0x0400FC04 RID: 64516
		internal static int __PropertyOffset_6;

		// Token: 0x0400FC05 RID: 64517
		internal static int __PropertyOffset_7;

		// Token: 0x0400FC06 RID: 64518
		internal static int __PropertyOffset_8;

		// Token: 0x0400FC07 RID: 64519
		internal static int __PropertyOffset_9;

		// Token: 0x0400FC08 RID: 64520
		internal static int __PropertyOffset_10;

		// Token: 0x0400FC09 RID: 64521
		internal static int __PropertyOffset_11;

		// Token: 0x0400FC0A RID: 64522
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x0400FC0B RID: 64523
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FC0C RID: 64524
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FC0D RID: 64525
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400FC0E RID: 64526
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x02009BCC RID: 39884
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403125E RID: 201310
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009BCD RID: 39885
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403125F RID: 201311
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
