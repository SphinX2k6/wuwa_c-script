using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Controller
{
	// Token: 0x02003AF1 RID: 15089
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_UINiagaraController.SE_UINiagaraController_C")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class SE_UINiagaraController_C : SE_ControllerBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020AD1 RID: 133841 RVA: 0x008D9E57 File Offset: 0x008D8057
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SE_UINiagaraController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_UINiagaraController.SE_UINiagaraController_C");
			}
			return SE_UINiagaraController_C._ClassPtr;
		}

		// Token: 0x06020AD2 RID: 133842 RVA: 0x008D9E7C File Offset: 0x008D807C
		public SE_UINiagaraController_C() : this(BuiltinUtils.AllocNativeUObject(SE_UINiagaraController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020AD3 RID: 133843 RVA: 0x008D9EA4 File Offset: 0x008D80A4
		[NullableContext(1)]
		public SE_UINiagaraController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SE_UINiagaraController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x06020AD4 RID: 133844 RVA: 0x008D9ED8 File Offset: 0x008D80D8
		// (set) Token: 0x06020AD5 RID: 133845 RVA: 0x008D9F11 File Offset: 0x008D8111
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
					result = (this._CachedNiagara = new TArray<UUINiagara>(base.NativePtr + (IntPtr)SE_UINiagaraController_C.__PropertyOffset_1, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedNiagara.CopyAssign(value);
			}
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x06020AD6 RID: 133846 RVA: 0x008D9F1F File Offset: 0x008D811F
		// (set) Token: 0x06020AD7 RID: 133847 RVA: 0x008D9F2F File Offset: 0x008D812F
		public unsafe bool HasAdapted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SE_UINiagaraController_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SE_UINiagaraController_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x06020AD8 RID: 133848 RVA: 0x008D9F40 File Offset: 0x008D8140
		// (set) Token: 0x06020AD9 RID: 133849 RVA: 0x008D9F54 File Offset: 0x008D8154
		public unsafe FVector2D ViewportSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SE_UINiagaraController_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SE_UINiagaraController_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x06020ADA RID: 133850 RVA: 0x008D9F69 File Offset: 0x008D8169
		// (set) Token: 0x06020ADB RID: 133851 RVA: 0x008D9F79 File Offset: 0x008D8179
		public unsafe bool UseAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SE_UINiagaraController_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SE_UINiagaraController_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x06020ADC RID: 133852 RVA: 0x008D9F8A File Offset: 0x008D818A
		// (set) Token: 0x06020ADD RID: 133853 RVA: 0x008D9F9A File Offset: 0x008D819A
		public unsafe float AspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SE_UINiagaraController_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SE_UINiagaraController_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x06020ADE RID: 133854 RVA: 0x008D9FAB File Offset: 0x008D81AB
		// (set) Token: 0x06020ADF RID: 133855 RVA: 0x008D9FBB File Offset: 0x008D81BB
		public unsafe bool ControlByWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SE_UINiagaraController_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SE_UINiagaraController_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x06020AE0 RID: 133856 RVA: 0x008D9FCC File Offset: 0x008D81CC
		// (set) Token: 0x06020AE1 RID: 133857 RVA: 0x008D9FE0 File Offset: 0x008D81E0
		[Nullable(2)]
		public unsafe AUIContainerActor AdaptTo
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIContainerActor>(base.NativePtr / (IntPtr)sizeof(void*) + SE_UINiagaraController_C.__PropertyOffset_7);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SE_UINiagaraController_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x06020AE2 RID: 133858 RVA: 0x008D9FF8 File Offset: 0x008D81F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CaculatePoint(FVector2D LeftBottomPoint, FVector2D RightTopPoint, ref FVector2D NewLeftBottomPoint, ref FVector2D NewRightTopPoint)
		{
			SE_UINiagaraController_C.__CaculatePoint_FunctionParams* ptr = stackalloc SE_UINiagaraController_C.__CaculatePoint_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(SE_UINiagaraController_C.__CaculatePoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UINiagaraController_C.__CaculatePoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LeftBottomPoint = LeftBottomPoint;
			ptr->RightTopPoint = RightTopPoint;
			ptr->NewLeftBottomPoint = NewLeftBottomPoint;
			ptr->NewRightTopPoint = NewRightTopPoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UINiagaraController_C.__CaculatePoint_NativeFunctionPtr, (void*)ptr);
			NewLeftBottomPoint = ptr->NewLeftBottomPoint;
			NewRightTopPoint = ptr->NewRightTopPoint;
		}

		// Token: 0x06020AE3 RID: 133859 RVA: 0x008DA07A File Offset: 0x008D827A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AdjustToScreenEditor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UINiagaraController_C.__AdjustToScreenEditor_NativeFunctionPtr, null);
		}

		// Token: 0x06020AE4 RID: 133860 RVA: 0x008DA08E File Offset: 0x008D828E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AdjustToScreen()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UINiagaraController_C.__AdjustToScreen_NativeFunctionPtr, null);
		}

		// Token: 0x06020AE5 RID: 133861 RVA: 0x008DA0A2 File Offset: 0x008D82A2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UINiagaraController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020AE6 RID: 133862 RVA: 0x008DA0B6 File Offset: 0x008D82B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, SE_UINiagaraController_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020AE7 RID: 133863 RVA: 0x008DA0CC File Offset: 0x008D82CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			SE_UINiagaraController_C.__ReceiveTick_FunctionParams* ptr = stackalloc SE_UINiagaraController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_UINiagaraController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UINiagaraController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UINiagaraController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AE8 RID: 133864 RVA: 0x008DA114 File Offset: 0x008D8314
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			SE_UINiagaraController_C.__ReceiveTick_FunctionParams* ptr = stackalloc SE_UINiagaraController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_UINiagaraController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UINiagaraController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, SE_UINiagaraController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020AE9 RID: 133865 RVA: 0x008DA15C File Offset: 0x008D835C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyAlpha(float alpha)
		{
			SE_UINiagaraController_C.__ApplyAlpha_FunctionParams* ptr = stackalloc SE_UINiagaraController_C.__ApplyAlpha_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_UINiagaraController_C.__ApplyAlpha_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UINiagaraController_C.__ApplyAlpha_NativeFunctionPtr, (void*)ptr, 1);
			ptr->alpha = alpha;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UINiagaraController_C.__ApplyAlpha_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AEA RID: 133866 RVA: 0x008DA1A4 File Offset: 0x008D83A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyVisibility(bool visibility)
		{
			SE_UINiagaraController_C.__ApplyVisibility_FunctionParams* ptr = stackalloc SE_UINiagaraController_C.__ApplyVisibility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(SE_UINiagaraController_C.__ApplyVisibility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UINiagaraController_C.__ApplyVisibility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->visibility = visibility;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UINiagaraController_C.__ApplyVisibility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AEB RID: 133867 RVA: 0x008DA1EA File Offset: 0x008D83EA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UINiagaraController_C.__BeforeStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020AEC RID: 133868 RVA: 0x008DA200 File Offset: 0x008D8400
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyEnvironmentFactor(float EnvironmentFactor)
		{
			SE_UINiagaraController_C.__ApplyEnvironmentFactor_FunctionParams* ptr = stackalloc SE_UINiagaraController_C.__ApplyEnvironmentFactor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_UINiagaraController_C.__ApplyEnvironmentFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UINiagaraController_C.__ApplyEnvironmentFactor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EnvironmentFactor = EnvironmentFactor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UINiagaraController_C.__ApplyEnvironmentFactor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AED RID: 133869 RVA: 0x008DA246 File Offset: 0x008D8446
		protected SE_UINiagaraController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDBE RID: 64958
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_UINiagaraController.SE_UINiagaraController_C";

		// Token: 0x0400FDBF RID: 64959
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDC0 RID: 64960
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDC1 RID: 64961
		internal static int __PropertyOffset_1;

		// Token: 0x0400FDC2 RID: 64962
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUINiagara> _CachedNiagara;

		// Token: 0x0400FDC3 RID: 64963
		internal static int __PropertyOffset_2;

		// Token: 0x0400FDC4 RID: 64964
		internal static int __PropertyOffset_3;

		// Token: 0x0400FDC5 RID: 64965
		internal static int __PropertyOffset_4;

		// Token: 0x0400FDC6 RID: 64966
		internal static int __PropertyOffset_5;

		// Token: 0x0400FDC7 RID: 64967
		internal static int __PropertyOffset_6;

		// Token: 0x0400FDC8 RID: 64968
		internal static int __PropertyOffset_7;

		// Token: 0x0400FDC9 RID: 64969
		private static IntPtr __CaculatePoint_NativeFunctionPtr;

		// Token: 0x0400FDCA RID: 64970
		private static IntPtr __AdjustToScreenEditor_NativeFunctionPtr;

		// Token: 0x0400FDCB RID: 64971
		private static IntPtr __AdjustToScreen_NativeFunctionPtr;

		// Token: 0x0400FDCC RID: 64972
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FDCD RID: 64973
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FDCE RID: 64974
		private static IntPtr __ApplyAlpha_NativeFunctionPtr;

		// Token: 0x0400FDCF RID: 64975
		private static IntPtr __ApplyVisibility_NativeFunctionPtr;

		// Token: 0x0400FDD0 RID: 64976
		private static IntPtr __BeforeStart_NativeFunctionPtr;

		// Token: 0x0400FDD1 RID: 64977
		private static IntPtr __ApplyEnvironmentFactor_NativeFunctionPtr;

		// Token: 0x02009C14 RID: 39956
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __CaculatePoint_FunctionParams
		{
			// Token: 0x040312B7 RID: 201399
			[FieldOffset(0)]
			public FVector2D LeftBottomPoint;

			// Token: 0x040312B8 RID: 201400
			[FieldOffset(8)]
			public FVector2D RightTopPoint;

			// Token: 0x040312B9 RID: 201401
			[FieldOffset(16)]
			public FVector2D NewLeftBottomPoint;

			// Token: 0x040312BA RID: 201402
			[FieldOffset(24)]
			public FVector2D NewRightTopPoint;
		}

		// Token: 0x02009C15 RID: 39957
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312BB RID: 201403
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C16 RID: 39958
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ApplyAlpha_FunctionParams
		{
			// Token: 0x040312BC RID: 201404
			[FieldOffset(0)]
			public float alpha;
		}

		// Token: 0x02009C17 RID: 39959
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ApplyVisibility_FunctionParams
		{
			// Token: 0x040312BD RID: 201405
			[FieldOffset(0)]
			public bool visibility;
		}

		// Token: 0x02009C18 RID: 39960
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ApplyEnvironmentFactor_FunctionParams
		{
			// Token: 0x040312BE RID: 201406
			[FieldOffset(0)]
			public float EnvironmentFactor;
		}
	}
}
