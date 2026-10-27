using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence
{
	// Token: 0x02003AD8 RID: 15064
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/BP_DisableLut_Seq.BP_DisableLut_Seq_C")]
	[UnrealStructLayout(1472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1471)]
	public class BP_DisableLut_Seq_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602085F RID: 133215 RVA: 0x008D5132 File Offset: 0x008D3332
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DisableLut_Seq_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/BP_DisableLut_Seq.BP_DisableLut_Seq_C");
			}
			return BP_DisableLut_Seq_C._ClassPtr;
		}

		// Token: 0x06020860 RID: 133216 RVA: 0x008D5158 File Offset: 0x008D3358
		public BP_DisableLut_Seq_C() : this(BuiltinUtils.AllocNativeUObject(BP_DisableLut_Seq_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020861 RID: 133217 RVA: 0x008D5180 File Offset: 0x008D3380
		[NullableContext(1)]
		public BP_DisableLut_Seq_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DisableLut_Seq_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x06020862 RID: 133218 RVA: 0x008D51B3 File Offset: 0x008D33B3
		// (set) Token: 0x06020863 RID: 133219 RVA: 0x008D51C7 File Offset: 0x008D33C7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DisableLut_Seq_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DisableLut_Seq_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x06020864 RID: 133220 RVA: 0x008D51DC File Offset: 0x008D33DC
		// (set) Token: 0x06020865 RID: 133221 RVA: 0x008D51EC File Offset: 0x008D33EC
		public unsafe float SceneLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DisableLut_Seq_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DisableLut_Seq_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x06020866 RID: 133222 RVA: 0x008D51FD File Offset: 0x008D33FD
		// (set) Token: 0x06020867 RID: 133223 RVA: 0x008D520D File Offset: 0x008D340D
		public unsafe bool DisableLut_Store
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DisableLut_Seq_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DisableLut_Seq_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x06020868 RID: 133224 RVA: 0x008D521E File Offset: 0x008D341E
		// (set) Token: 0x06020869 RID: 133225 RVA: 0x008D522E File Offset: 0x008D342E
		public unsafe bool DisableLut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DisableLut_Seq_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DisableLut_Seq_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003138 RID: 12600
		// (get) Token: 0x0602086A RID: 133226 RVA: 0x008D523F File Offset: 0x008D343F
		// (set) Token: 0x0602086B RID: 133227 RVA: 0x008D524F File Offset: 0x008D344F
		public unsafe bool EnableLut_Lerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DisableLut_Seq_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DisableLut_Seq_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602086C RID: 133228 RVA: 0x008D5260 File Offset: 0x008D3460
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TickGlobalGI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableLut_Seq_C.__TickGlobalGI_NativeFunctionPtr, null);
		}

		// Token: 0x0602086D RID: 133229 RVA: 0x008D5274 File Offset: 0x008D3474
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TickFunction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableLut_Seq_C.__TickFunction_NativeFunctionPtr, null);
		}

		// Token: 0x0602086E RID: 133230 RVA: 0x008D5288 File Offset: 0x008D3488
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableLut_Seq_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602086F RID: 133231 RVA: 0x008D529C File Offset: 0x008D349C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DisableLut_Seq_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020870 RID: 133232 RVA: 0x008D52B1 File Offset: 0x008D34B1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableLut_Seq_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020871 RID: 133233 RVA: 0x008D52C5 File Offset: 0x008D34C5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DisableLut_Seq_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020872 RID: 133234 RVA: 0x008D52DC File Offset: 0x008D34DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DisableLut_Seq_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DisableLut_Seq_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DisableLut_Seq_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DisableLut_Seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableLut_Seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020873 RID: 133235 RVA: 0x008D5324 File Offset: 0x008D3524
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DisableLut_Seq_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DisableLut_Seq_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DisableLut_Seq_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DisableLut_Seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DisableLut_Seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020874 RID: 133236 RVA: 0x008D536C File Offset: 0x008D356C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_DisableLut_Seq_C.__EditorTick_FunctionParams* ptr = stackalloc BP_DisableLut_Seq_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DisableLut_Seq_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DisableLut_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableLut_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020875 RID: 133237 RVA: 0x008D53B4 File Offset: 0x008D35B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_DisableLut_Seq_C.__EditorTick_FunctionParams* ptr = stackalloc BP_DisableLut_Seq_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DisableLut_Seq_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DisableLut_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DisableLut_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020876 RID: 133238 RVA: 0x008D53FB File Offset: 0x008D35FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableLut_Seq_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06020877 RID: 133239 RVA: 0x008D540F File Offset: 0x008D360F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DisableLut_Seq_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020878 RID: 133240 RVA: 0x008D5424 File Offset: 0x008D3624
		protected BP_DisableLut_Seq_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC23 RID: 64547
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/BP_DisableLut_Seq.BP_DisableLut_Seq_C";

		// Token: 0x0400FC24 RID: 64548
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC25 RID: 64549
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC26 RID: 64550
		internal static int __PropertyOffset_1;

		// Token: 0x0400FC27 RID: 64551
		internal static int __PropertyOffset_2;

		// Token: 0x0400FC28 RID: 64552
		internal static int __PropertyOffset_3;

		// Token: 0x0400FC29 RID: 64553
		internal static int __PropertyOffset_4;

		// Token: 0x0400FC2A RID: 64554
		internal static int __PropertyOffset_5;

		// Token: 0x0400FC2B RID: 64555
		private static IntPtr __TickGlobalGI_NativeFunctionPtr;

		// Token: 0x0400FC2C RID: 64556
		private static IntPtr __TickFunction_NativeFunctionPtr;

		// Token: 0x0400FC2D RID: 64557
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FC2E RID: 64558
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FC2F RID: 64559
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FC30 RID: 64560
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400FC31 RID: 64561
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x02009BD0 RID: 39888
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031262 RID: 201314
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009BD1 RID: 39889
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031263 RID: 201315
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
