using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.WaveVertexAnim
{
	// Token: 0x02003BD1 RID: 15313
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaveVertexAnim/BP_WaveVertexAnim.BP_WaveVertexAnim_C")]
	[UnrealStructLayout(1480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1477)]
	public class BP_WaveVertexAnim_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060225BD RID: 140733 RVA: 0x00906CA4 File Offset: 0x00904EA4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaveVertexAnim_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaveVertexAnim/BP_WaveVertexAnim.BP_WaveVertexAnim_C");
			}
			return BP_WaveVertexAnim_C._ClassPtr;
		}

		// Token: 0x060225BE RID: 140734 RVA: 0x00906CC8 File Offset: 0x00904EC8
		public BP_WaveVertexAnim_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaveVertexAnim_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060225BF RID: 140735 RVA: 0x00906CF0 File Offset: 0x00904EF0
		[NullableContext(1)]
		public BP_WaveVertexAnim_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaveVertexAnim_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B1D RID: 15133
		// (get) Token: 0x060225C0 RID: 140736 RVA: 0x00906D23 File Offset: 0x00904F23
		// (set) Token: 0x060225C1 RID: 140737 RVA: 0x00906D37 File Offset: 0x00904F37
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaveVertexAnim_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaveVertexAnim_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003B1E RID: 15134
		// (get) Token: 0x060225C2 RID: 140738 RVA: 0x00906D4C File Offset: 0x00904F4C
		// (set) Token: 0x060225C3 RID: 140739 RVA: 0x00906D60 File Offset: 0x00904F60
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaveVertexAnim_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaveVertexAnim_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003B1F RID: 15135
		// (get) Token: 0x060225C4 RID: 140740 RVA: 0x00906D75 File Offset: 0x00904F75
		// (set) Token: 0x060225C5 RID: 140741 RVA: 0x00906D85 File Offset: 0x00904F85
		public unsafe float VertexWaveStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaveVertexAnim_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaveVertexAnim_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003B20 RID: 15136
		// (get) Token: 0x060225C6 RID: 140742 RVA: 0x00906D96 File Offset: 0x00904F96
		// (set) Token: 0x060225C7 RID: 140743 RVA: 0x00906DA6 File Offset: 0x00904FA6
		public unsafe bool OnWavePlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaveVertexAnim_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaveVertexAnim_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x060225C8 RID: 140744 RVA: 0x00906DB7 File Offset: 0x00904FB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetMPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaveVertexAnim_C.__SetMPC_NativeFunctionPtr, null);
		}

		// Token: 0x060225C9 RID: 140745 RVA: 0x00906DCB File Offset: 0x00904FCB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaveVertexAnim_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060225CA RID: 140746 RVA: 0x00906DDF File Offset: 0x00904FDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaveVertexAnim_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060225CB RID: 140747 RVA: 0x00906DF4 File Offset: 0x00904FF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaveVertexAnim_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaveVertexAnim_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaveVertexAnim_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaveVertexAnim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaveVertexAnim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060225CC RID: 140748 RVA: 0x00906E3C File Offset: 0x0090503C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaveVertexAnim_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaveVertexAnim_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaveVertexAnim_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaveVertexAnim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaveVertexAnim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060225CD RID: 140749 RVA: 0x00906E83 File Offset: 0x00905083
		protected BP_WaveVertexAnim_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010DBE RID: 69054
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaveVertexAnim/BP_WaveVertexAnim.BP_WaveVertexAnim_C";

		// Token: 0x04010DBF RID: 69055
		private static IntPtr _ClassPtr;

		// Token: 0x04010DC0 RID: 69056
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010DC1 RID: 69057
		internal static int __PropertyOffset_1;

		// Token: 0x04010DC2 RID: 69058
		internal static int __PropertyOffset_2;

		// Token: 0x04010DC3 RID: 69059
		internal static int __PropertyOffset_3;

		// Token: 0x04010DC4 RID: 69060
		internal static int __PropertyOffset_4;

		// Token: 0x04010DC5 RID: 69061
		private static IntPtr __SetMPC_NativeFunctionPtr;

		// Token: 0x04010DC6 RID: 69062
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010DC7 RID: 69063
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009D6E RID: 40302
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314EC RID: 201964
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
