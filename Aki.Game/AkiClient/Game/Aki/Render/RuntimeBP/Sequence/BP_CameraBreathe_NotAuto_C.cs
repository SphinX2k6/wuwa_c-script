using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence
{
	// Token: 0x02003AD6 RID: 15062
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/BP_CameraBreathe_NotAuto.BP_CameraBreathe_NotAuto_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1524)]
	public class BP_CameraBreathe_NotAuto_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602083C RID: 133180 RVA: 0x008D4D35 File Offset: 0x008D2F35
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CameraBreathe_NotAuto_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/BP_CameraBreathe_NotAuto.BP_CameraBreathe_NotAuto_C");
			}
			return BP_CameraBreathe_NotAuto_C._ClassPtr;
		}

		// Token: 0x0602083D RID: 133181 RVA: 0x008D4D5C File Offset: 0x008D2F5C
		public BP_CameraBreathe_NotAuto_C() : this(BuiltinUtils.AllocNativeUObject(BP_CameraBreathe_NotAuto_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602083E RID: 133182 RVA: 0x008D4D84 File Offset: 0x008D2F84
		[NullableContext(1)]
		public BP_CameraBreathe_NotAuto_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CameraBreathe_NotAuto_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x0602083F RID: 133183 RVA: 0x008D4DB7 File Offset: 0x008D2FB7
		// (set) Token: 0x06020840 RID: 133184 RVA: 0x008D4DCB File Offset: 0x008D2FCB
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraBreathe_NotAuto_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraBreathe_NotAuto_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x06020841 RID: 133185 RVA: 0x008D4DE0 File Offset: 0x008D2FE0
		// (set) Token: 0x06020842 RID: 133186 RVA: 0x008D4DF4 File Offset: 0x008D2FF4
		public unsafe ACameraActor Camera
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACameraActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraBreathe_NotAuto_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraBreathe_NotAuto_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x06020843 RID: 133187 RVA: 0x008D4E09 File Offset: 0x008D3009
		// (set) Token: 0x06020844 RID: 133188 RVA: 0x008D4E1D File Offset: 0x008D301D
		public unsafe AActor CameraAttachActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraBreathe_NotAuto_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraBreathe_NotAuto_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x06020845 RID: 133189 RVA: 0x008D4E32 File Offset: 0x008D3032
		// (set) Token: 0x06020846 RID: 133190 RVA: 0x008D4E46 File Offset: 0x008D3046
		public unsafe FVectorDouble CameraMoveTransform_D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraBreathe_NotAuto_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraBreathe_NotAuto_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x06020847 RID: 133191 RVA: 0x008D4E5B File Offset: 0x008D305B
		// (set) Token: 0x06020848 RID: 133192 RVA: 0x008D4E6B File Offset: 0x008D306B
		public unsafe float PositionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraBreathe_NotAuto_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraBreathe_NotAuto_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x06020849 RID: 133193 RVA: 0x008D4E7C File Offset: 0x008D307C
		// (set) Token: 0x0602084A RID: 133194 RVA: 0x008D4E8C File Offset: 0x008D308C
		public unsafe float FOVIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraBreathe_NotAuto_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraBreathe_NotAuto_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x0602084B RID: 133195 RVA: 0x008D4E9D File Offset: 0x008D309D
		// (set) Token: 0x0602084C RID: 133196 RVA: 0x008D4EB1 File Offset: 0x008D30B1
		public unsafe FVector SequenceCenterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraBreathe_NotAuto_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraBreathe_NotAuto_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x0602084D RID: 133197 RVA: 0x008D4EC6 File Offset: 0x008D30C6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraBreathe_NotAuto_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x0602084E RID: 133198 RVA: 0x008D4EDA File Offset: 0x008D30DA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraBreathe_NotAuto_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602084F RID: 133199 RVA: 0x008D4EEE File Offset: 0x008D30EE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraBreathe_NotAuto_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020850 RID: 133200 RVA: 0x008D4F04 File Offset: 0x008D3104
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CameraBreathe_NotAuto_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CameraBreathe_NotAuto_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraBreathe_NotAuto_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraBreathe_NotAuto_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraBreathe_NotAuto_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020851 RID: 133201 RVA: 0x008D4F4C File Offset: 0x008D314C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CameraBreathe_NotAuto_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CameraBreathe_NotAuto_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraBreathe_NotAuto_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraBreathe_NotAuto_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraBreathe_NotAuto_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020852 RID: 133202 RVA: 0x008D4F94 File Offset: 0x008D3194
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CameraBreathe_NotAuto_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CameraBreathe_NotAuto_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraBreathe_NotAuto_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraBreathe_NotAuto_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraBreathe_NotAuto_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020853 RID: 133203 RVA: 0x008D4FDC File Offset: 0x008D31DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CameraBreathe_NotAuto_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CameraBreathe_NotAuto_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraBreathe_NotAuto_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraBreathe_NotAuto_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraBreathe_NotAuto_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020854 RID: 133204 RVA: 0x008D5023 File Offset: 0x008D3223
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraBreathe_NotAuto_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06020855 RID: 133205 RVA: 0x008D5037 File Offset: 0x008D3237
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraBreathe_NotAuto_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020856 RID: 133206 RVA: 0x008D504C File Offset: 0x008D324C
		protected BP_CameraBreathe_NotAuto_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC0F RID: 64527
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/BP_CameraBreathe_NotAuto.BP_CameraBreathe_NotAuto_C";

		// Token: 0x0400FC10 RID: 64528
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC11 RID: 64529
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC12 RID: 64530
		internal static int __PropertyOffset_1;

		// Token: 0x0400FC13 RID: 64531
		internal static int __PropertyOffset_2;

		// Token: 0x0400FC14 RID: 64532
		internal static int __PropertyOffset_3;

		// Token: 0x0400FC15 RID: 64533
		internal static int __PropertyOffset_4;

		// Token: 0x0400FC16 RID: 64534
		internal static int __PropertyOffset_5;

		// Token: 0x0400FC17 RID: 64535
		internal static int __PropertyOffset_6;

		// Token: 0x0400FC18 RID: 64536
		internal static int __PropertyOffset_7;

		// Token: 0x0400FC19 RID: 64537
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x0400FC1A RID: 64538
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FC1B RID: 64539
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FC1C RID: 64540
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400FC1D RID: 64541
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x02009BCE RID: 39886
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031260 RID: 201312
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009BCF RID: 39887
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031261 RID: 201313
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
