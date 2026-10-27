using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Controller
{
	// Token: 0x02003AF0 RID: 15088
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_NiagaraController.SE_NiagaraController_C")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class SE_NiagaraController_C : SE_ControllerBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020AC1 RID: 133825 RVA: 0x008D9BBA File Offset: 0x008D7DBA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SE_NiagaraController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_NiagaraController.SE_NiagaraController_C");
			}
			return SE_NiagaraController_C._ClassPtr;
		}

		// Token: 0x06020AC2 RID: 133826 RVA: 0x008D9BE0 File Offset: 0x008D7DE0
		public SE_NiagaraController_C() : this(BuiltinUtils.AllocNativeUObject(SE_NiagaraController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020AC3 RID: 133827 RVA: 0x008D9C08 File Offset: 0x008D7E08
		[NullableContext(1)]
		public SE_NiagaraController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SE_NiagaraController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x06020AC4 RID: 133828 RVA: 0x008D9C3C File Offset: 0x008D7E3C
		// (set) Token: 0x06020AC5 RID: 133829 RVA: 0x008D9C75 File Offset: 0x008D7E75
		[Nullable(1)]
		public TArray<UUINiagara> CachedNiagara
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UUINiagara> result;
				if ((result = this._CachedNiagara) == null)
				{
					result = (this._CachedNiagara = new TArray<UUINiagara>(base.NativePtr + (IntPtr)SE_NiagaraController_C.__PropertyOffset_1, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedNiagara.CopyAssign(value);
			}
		}

		// Token: 0x06020AC6 RID: 133830 RVA: 0x008D9C83 File Offset: 0x008D7E83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AdjustToScreenEditor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_NiagaraController_C.__AdjustToScreenEditor_NativeFunctionPtr, null);
		}

		// Token: 0x06020AC7 RID: 133831 RVA: 0x008D9C97 File Offset: 0x008D7E97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AdjustToScreen()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_NiagaraController_C.__AdjustToScreen_NativeFunctionPtr, null);
		}

		// Token: 0x06020AC8 RID: 133832 RVA: 0x008D9CAB File Offset: 0x008D7EAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_NiagaraController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020AC9 RID: 133833 RVA: 0x008D9CBF File Offset: 0x008D7EBF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, SE_NiagaraController_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020ACA RID: 133834 RVA: 0x008D9CD4 File Offset: 0x008D7ED4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			SE_NiagaraController_C.__ReceiveTick_FunctionParams* ptr = stackalloc SE_NiagaraController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_NiagaraController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_NiagaraController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_NiagaraController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020ACB RID: 133835 RVA: 0x008D9D1C File Offset: 0x008D7F1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			SE_NiagaraController_C.__ReceiveTick_FunctionParams* ptr = stackalloc SE_NiagaraController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_NiagaraController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_NiagaraController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, SE_NiagaraController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020ACC RID: 133836 RVA: 0x008D9D64 File Offset: 0x008D7F64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyAlpha(float alpha)
		{
			SE_NiagaraController_C.__ApplyAlpha_FunctionParams* ptr = stackalloc SE_NiagaraController_C.__ApplyAlpha_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_NiagaraController_C.__ApplyAlpha_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_NiagaraController_C.__ApplyAlpha_NativeFunctionPtr, (void*)ptr, 1);
			ptr->alpha = alpha;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_NiagaraController_C.__ApplyAlpha_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020ACD RID: 133837 RVA: 0x008D9DAC File Offset: 0x008D7FAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyVisibility(bool visibility)
		{
			SE_NiagaraController_C.__ApplyVisibility_FunctionParams* ptr = stackalloc SE_NiagaraController_C.__ApplyVisibility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(SE_NiagaraController_C.__ApplyVisibility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_NiagaraController_C.__ApplyVisibility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->visibility = visibility;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_NiagaraController_C.__ApplyVisibility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020ACE RID: 133838 RVA: 0x008D9DF2 File Offset: 0x008D7FF2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_NiagaraController_C.__BeforeStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020ACF RID: 133839 RVA: 0x008D9E08 File Offset: 0x008D8008
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyEnvironmentFactor(float EnvironmentFactor)
		{
			SE_NiagaraController_C.__ApplyEnvironmentFactor_FunctionParams* ptr = stackalloc SE_NiagaraController_C.__ApplyEnvironmentFactor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_NiagaraController_C.__ApplyEnvironmentFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_NiagaraController_C.__ApplyEnvironmentFactor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EnvironmentFactor = EnvironmentFactor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_NiagaraController_C.__ApplyEnvironmentFactor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AD0 RID: 133840 RVA: 0x008D9E4E File Offset: 0x008D804E
		protected SE_NiagaraController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDB1 RID: 64945
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_NiagaraController.SE_NiagaraController_C";

		// Token: 0x0400FDB2 RID: 64946
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDB3 RID: 64947
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDB4 RID: 64948
		internal static int __PropertyOffset_1;

		// Token: 0x0400FDB5 RID: 64949
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUINiagara> _CachedNiagara;

		// Token: 0x0400FDB6 RID: 64950
		private static IntPtr __AdjustToScreenEditor_NativeFunctionPtr;

		// Token: 0x0400FDB7 RID: 64951
		private static IntPtr __AdjustToScreen_NativeFunctionPtr;

		// Token: 0x0400FDB8 RID: 64952
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FDB9 RID: 64953
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FDBA RID: 64954
		private static IntPtr __ApplyAlpha_NativeFunctionPtr;

		// Token: 0x0400FDBB RID: 64955
		private static IntPtr __ApplyVisibility_NativeFunctionPtr;

		// Token: 0x0400FDBC RID: 64956
		private static IntPtr __BeforeStart_NativeFunctionPtr;

		// Token: 0x0400FDBD RID: 64957
		private static IntPtr __ApplyEnvironmentFactor_NativeFunctionPtr;

		// Token: 0x02009C10 RID: 39952
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312B3 RID: 201395
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C11 RID: 39953
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ApplyAlpha_FunctionParams
		{
			// Token: 0x040312B4 RID: 201396
			[FieldOffset(0)]
			public float alpha;
		}

		// Token: 0x02009C12 RID: 39954
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ApplyVisibility_FunctionParams
		{
			// Token: 0x040312B5 RID: 201397
			[FieldOffset(0)]
			public bool visibility;
		}

		// Token: 0x02009C13 RID: 39955
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ApplyEnvironmentFactor_FunctionParams
		{
			// Token: 0x040312B6 RID: 201398
			[FieldOffset(0)]
			public float EnvironmentFactor;
		}
	}
}
