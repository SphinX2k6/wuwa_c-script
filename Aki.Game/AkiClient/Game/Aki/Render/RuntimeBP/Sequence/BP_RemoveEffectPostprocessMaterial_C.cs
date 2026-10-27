using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence
{
	// Token: 0x02003ADB RID: 15067
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/BP_RemoveEffectPostprocessMaterial.BP_RemoveEffectPostprocessMaterial_C")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1068)]
	public class BP_RemoveEffectPostprocessMaterial_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020899 RID: 133273 RVA: 0x008D5811 File Offset: 0x008D3A11
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RemoveEffectPostprocessMaterial_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/BP_RemoveEffectPostprocessMaterial.BP_RemoveEffectPostprocessMaterial_C");
			}
			return BP_RemoveEffectPostprocessMaterial_C._ClassPtr;
		}

		// Token: 0x0602089A RID: 133274 RVA: 0x008D5838 File Offset: 0x008D3A38
		public BP_RemoveEffectPostprocessMaterial_C() : this(BuiltinUtils.AllocNativeUObject(BP_RemoveEffectPostprocessMaterial_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602089B RID: 133275 RVA: 0x008D5860 File Offset: 0x008D3A60
		[NullableContext(1)]
		public BP_RemoveEffectPostprocessMaterial_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RemoveEffectPostprocessMaterial_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x0602089C RID: 133276 RVA: 0x008D5893 File Offset: 0x008D3A93
		// (set) Token: 0x0602089D RID: 133277 RVA: 0x008D58A7 File Offset: 0x008D3AA7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RemoveEffectPostprocessMaterial_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RemoveEffectPostprocessMaterial_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x0602089E RID: 133278 RVA: 0x008D58BC File Offset: 0x008D3ABC
		// (set) Token: 0x0602089F RID: 133279 RVA: 0x008D58CC File Offset: 0x008D3ACC
		public unsafe int handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RemoveEffectPostprocessMaterial_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RemoveEffectPostprocessMaterial_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x060208A0 RID: 133280 RVA: 0x008D58DD File Offset: 0x008D3ADD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RemoveEffectPostprocessMaterial_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060208A1 RID: 133281 RVA: 0x008D58F1 File Offset: 0x008D3AF1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RemoveEffectPostprocessMaterial_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060208A2 RID: 133282 RVA: 0x008D5908 File Offset: 0x008D3B08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_RemoveEffectPostprocessMaterial_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RemoveEffectPostprocessMaterial_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RemoveEffectPostprocessMaterial_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RemoveEffectPostprocessMaterial_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RemoveEffectPostprocessMaterial_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208A3 RID: 133283 RVA: 0x008D5954 File Offset: 0x008D3B54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_RemoveEffectPostprocessMaterial_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RemoveEffectPostprocessMaterial_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RemoveEffectPostprocessMaterial_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RemoveEffectPostprocessMaterial_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RemoveEffectPostprocessMaterial_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060208A4 RID: 133284 RVA: 0x008D59A0 File Offset: 0x008D3BA0
		protected BP_RemoveEffectPostprocessMaterial_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC45 RID: 64581
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/BP_RemoveEffectPostprocessMaterial.BP_RemoveEffectPostprocessMaterial_C";

		// Token: 0x0400FC46 RID: 64582
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC47 RID: 64583
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC48 RID: 64584
		internal static int __PropertyOffset_1;

		// Token: 0x0400FC49 RID: 64585
		internal static int __PropertyOffset_2;

		// Token: 0x0400FC4A RID: 64586
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FC4B RID: 64587
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009BD4 RID: 39892
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031266 RID: 201318
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
