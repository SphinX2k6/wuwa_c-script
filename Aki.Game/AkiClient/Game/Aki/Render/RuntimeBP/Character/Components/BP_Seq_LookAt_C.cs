using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Components
{
	// Token: 0x02003E2C RID: 15916
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Components/BP_Seq_LookAt.BP_Seq_LookAt_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1493)]
	public class BP_Seq_LookAt_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027EA7 RID: 163495 RVA: 0x0099F240 File Offset: 0x0099D440
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Seq_LookAt_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Components/BP_Seq_LookAt.BP_Seq_LookAt_C");
			}
			return BP_Seq_LookAt_C._ClassPtr;
		}

		// Token: 0x06027EA8 RID: 163496 RVA: 0x0099F264 File Offset: 0x0099D464
		public BP_Seq_LookAt_C() : this(BuiltinUtils.AllocNativeUObject(BP_Seq_LookAt_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027EA9 RID: 163497 RVA: 0x0099F28C File Offset: 0x0099D48C
		[NullableContext(1)]
		public BP_Seq_LookAt_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Seq_LookAt_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005AB9 RID: 23225
		// (get) Token: 0x06027EAA RID: 163498 RVA: 0x0099F2BF File Offset: 0x0099D4BF
		// (set) Token: 0x06027EAB RID: 163499 RVA: 0x0099F2D3 File Offset: 0x0099D4D3
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_LookAt_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_LookAt_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005ABA RID: 23226
		// (get) Token: 0x06027EAC RID: 163500 RVA: 0x0099F2E8 File Offset: 0x0099D4E8
		// (set) Token: 0x06027EAD RID: 163501 RVA: 0x0099F2FC File Offset: 0x0099D4FC
		public unsafe ANiagaraActor Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ANiagaraActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_LookAt_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_LookAt_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005ABB RID: 23227
		// (get) Token: 0x06027EAE RID: 163502 RVA: 0x0099F311 File Offset: 0x0099D511
		// (set) Token: 0x06027EAF RID: 163503 RVA: 0x0099F325 File Offset: 0x0099D525
		public unsafe AActor Target
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_LookAt_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Seq_LookAt_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005ABC RID: 23228
		// (get) Token: 0x06027EB0 RID: 163504 RVA: 0x0099F33A File Offset: 0x0099D53A
		// (set) Token: 0x06027EB1 RID: 163505 RVA: 0x0099F34A File Offset: 0x0099D54A
		public unsafe float Pitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_LookAt_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_LookAt_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005ABD RID: 23229
		// (get) Token: 0x06027EB2 RID: 163506 RVA: 0x0099F35B File Offset: 0x0099D55B
		// (set) Token: 0x06027EB3 RID: 163507 RVA: 0x0099F36B File Offset: 0x0099D56B
		public unsafe float Yaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_LookAt_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_LookAt_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005ABE RID: 23230
		// (get) Token: 0x06027EB4 RID: 163508 RVA: 0x0099F37C File Offset: 0x0099D57C
		// (set) Token: 0x06027EB5 RID: 163509 RVA: 0x0099F38C File Offset: 0x0099D58C
		public unsafe float Roll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_LookAt_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_LookAt_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005ABF RID: 23231
		// (get) Token: 0x06027EB6 RID: 163510 RVA: 0x0099F39D File Offset: 0x0099D59D
		// (set) Token: 0x06027EB7 RID: 163511 RVA: 0x0099F3AD File Offset: 0x0099D5AD
		public unsafe bool bOverrideNiagaraRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Seq_LookAt_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Seq_LookAt_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027EB8 RID: 163512 RVA: 0x0099F3C0 File Offset: 0x0099D5C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Seq_LookAt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Seq_LookAt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Seq_LookAt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Seq_LookAt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Seq_LookAt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027EB9 RID: 163513 RVA: 0x0099F408 File Offset: 0x0099D608
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Seq_LookAt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Seq_LookAt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Seq_LookAt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Seq_LookAt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Seq_LookAt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027EBA RID: 163514 RVA: 0x0099F450 File Offset: 0x0099D650
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Seq_LookAt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Seq_LookAt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Seq_LookAt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Seq_LookAt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Seq_LookAt_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027EBB RID: 163515 RVA: 0x0099F498 File Offset: 0x0099D698
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Seq_LookAt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Seq_LookAt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Seq_LookAt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Seq_LookAt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Seq_LookAt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027EBC RID: 163516 RVA: 0x0099F4DF File Offset: 0x0099D6DF
		protected BP_Seq_LookAt_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014419 RID: 82969
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Components/BP_Seq_LookAt.BP_Seq_LookAt_C";

		// Token: 0x0401441A RID: 82970
		private static IntPtr _ClassPtr;

		// Token: 0x0401441B RID: 82971
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401441C RID: 82972
		internal static int __PropertyOffset_1;

		// Token: 0x0401441D RID: 82973
		internal static int __PropertyOffset_2;

		// Token: 0x0401441E RID: 82974
		internal static int __PropertyOffset_3;

		// Token: 0x0401441F RID: 82975
		internal static int __PropertyOffset_4;

		// Token: 0x04014420 RID: 82976
		internal static int __PropertyOffset_5;

		// Token: 0x04014421 RID: 82977
		internal static int __PropertyOffset_6;

		// Token: 0x04014422 RID: 82978
		internal static int __PropertyOffset_7;

		// Token: 0x04014423 RID: 82979
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04014424 RID: 82980
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A2A6 RID: 41638
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031FCA RID: 204746
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A2A7 RID: 41639
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031FCB RID: 204747
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
