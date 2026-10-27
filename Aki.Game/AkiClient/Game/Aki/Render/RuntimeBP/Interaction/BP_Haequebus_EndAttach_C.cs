using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D14 RID: 15636
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_Haequebus_EndAttach.BP_Haequebus_EndAttach_C")]
	[UnrealStructLayout(1464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1464)]
	public class BP_Haequebus_EndAttach_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060257BA RID: 153530 RVA: 0x0095AE92 File Offset: 0x00959092
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Haequebus_EndAttach_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_Haequebus_EndAttach.BP_Haequebus_EndAttach_C");
			}
			return BP_Haequebus_EndAttach_C._ClassPtr;
		}

		// Token: 0x060257BB RID: 153531 RVA: 0x0095AEB8 File Offset: 0x009590B8
		public BP_Haequebus_EndAttach_C() : this(BuiltinUtils.AllocNativeUObject(BP_Haequebus_EndAttach_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060257BC RID: 153532 RVA: 0x0095AEE0 File Offset: 0x009590E0
		[NullableContext(1)]
		public BP_Haequebus_EndAttach_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Haequebus_EndAttach_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CE3 RID: 19683
		// (get) Token: 0x060257BD RID: 153533 RVA: 0x0095AF13 File Offset: 0x00959113
		// (set) Token: 0x060257BE RID: 153534 RVA: 0x0095AF27 File Offset: 0x00959127
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Haequebus_EndAttach_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Haequebus_EndAttach_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x060257BF RID: 153535 RVA: 0x0095AF3C File Offset: 0x0095913C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Haequebus_EndAttach_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Haequebus_EndAttach_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Haequebus_EndAttach_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Haequebus_EndAttach_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Haequebus_EndAttach_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060257C0 RID: 153536 RVA: 0x0095AF84 File Offset: 0x00959184
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Haequebus_EndAttach_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Haequebus_EndAttach_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Haequebus_EndAttach_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Haequebus_EndAttach_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Haequebus_EndAttach_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060257C1 RID: 153537 RVA: 0x0095AFCC File Offset: 0x009591CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Haequebus_EndAttach_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Haequebus_EndAttach_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Haequebus_EndAttach_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Haequebus_EndAttach_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Haequebus_EndAttach_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060257C2 RID: 153538 RVA: 0x0095B014 File Offset: 0x00959214
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Haequebus_EndAttach_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Haequebus_EndAttach_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Haequebus_EndAttach_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Haequebus_EndAttach_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Haequebus_EndAttach_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060257C3 RID: 153539 RVA: 0x0095B05B File Offset: 0x0095925B
		protected BP_Haequebus_EndAttach_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B44 RID: 76612
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_Haequebus_EndAttach.BP_Haequebus_EndAttach_C";

		// Token: 0x04012B45 RID: 76613
		private static IntPtr _ClassPtr;

		// Token: 0x04012B46 RID: 76614
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B47 RID: 76615
		internal static int __PropertyOffset_1;

		// Token: 0x04012B48 RID: 76616
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012B49 RID: 76617
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009FFF RID: 40959
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A9A RID: 203418
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A000 RID: 40960
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031A9B RID: 203419
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
