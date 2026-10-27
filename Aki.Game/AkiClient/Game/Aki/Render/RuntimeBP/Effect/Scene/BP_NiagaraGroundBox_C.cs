using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene
{
	// Token: 0x02003DCA RID: 15818
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_NiagaraGroundBox.BP_NiagaraGroundBox_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class BP_NiagaraGroundBox_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027672 RID: 161394 RVA: 0x00990270 File Offset: 0x0098E470
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NiagaraGroundBox_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_NiagaraGroundBox.BP_NiagaraGroundBox_C");
			}
			return BP_NiagaraGroundBox_C._ClassPtr;
		}

		// Token: 0x06027673 RID: 161395 RVA: 0x00990294 File Offset: 0x0098E494
		public BP_NiagaraGroundBox_C() : this(BuiltinUtils.AllocNativeUObject(BP_NiagaraGroundBox_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027674 RID: 161396 RVA: 0x009902BC File Offset: 0x0098E4BC
		[NullableContext(1)]
		public BP_NiagaraGroundBox_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NiagaraGroundBox_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170057F5 RID: 22517
		// (get) Token: 0x06027675 RID: 161397 RVA: 0x009902EF File Offset: 0x0098E4EF
		// (set) Token: 0x06027676 RID: 161398 RVA: 0x00990303 File Offset: 0x0098E503
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NiagaraGroundBox_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NiagaraGroundBox_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170057F6 RID: 22518
		// (get) Token: 0x06027677 RID: 161399 RVA: 0x00990318 File Offset: 0x0098E518
		// (set) Token: 0x06027678 RID: 161400 RVA: 0x0099032C File Offset: 0x0098E52C
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NiagaraGroundBox_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NiagaraGroundBox_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170057F7 RID: 22519
		// (get) Token: 0x06027679 RID: 161401 RVA: 0x00990341 File Offset: 0x0098E541
		// (set) Token: 0x0602767A RID: 161402 RVA: 0x00990351 File Offset: 0x0098E551
		public unsafe float Precision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170057F8 RID: 22520
		// (get) Token: 0x0602767B RID: 161403 RVA: 0x00990362 File Offset: 0x0098E562
		// (set) Token: 0x0602767C RID: 161404 RVA: 0x00990372 File Offset: 0x0098E572
		public unsafe int MaxSample
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170057F9 RID: 22521
		// (get) Token: 0x0602767D RID: 161405 RVA: 0x00990384 File Offset: 0x0098E584
		// (set) Token: 0x0602767E RID: 161406 RVA: 0x009903BD File Offset: 0x0098E5BD
		[Nullable(1)]
		public TArray<FVector> ResArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._ResArray) == null)
				{
					result = (this._ResArray = new TArray<FVector>(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ResArray.CopyAssign(value);
			}
		}

		// Token: 0x170057FA RID: 22522
		// (get) Token: 0x0602767F RID: 161407 RVA: 0x009903CB File Offset: 0x0098E5CB
		// (set) Token: 0x06027680 RID: 161408 RVA: 0x009903DB File Offset: 0x0098E5DB
		public unsafe float TraceElement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170057FB RID: 22523
		// (get) Token: 0x06027681 RID: 161409 RVA: 0x009903EC File Offset: 0x0098E5EC
		// (set) Token: 0x06027682 RID: 161410 RVA: 0x009903FC File Offset: 0x0098E5FC
		public unsafe int XSample
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170057FC RID: 22524
		// (get) Token: 0x06027683 RID: 161411 RVA: 0x0099040D File Offset: 0x0098E60D
		// (set) Token: 0x06027684 RID: 161412 RVA: 0x0099041D File Offset: 0x0098E61D
		public unsafe int YSample
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170057FD RID: 22525
		// (get) Token: 0x06027685 RID: 161413 RVA: 0x0099042E File Offset: 0x0098E62E
		// (set) Token: 0x06027686 RID: 161414 RVA: 0x0099043E File Offset: 0x0098E63E
		public unsafe bool EnableDebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170057FE RID: 22526
		// (get) Token: 0x06027687 RID: 161415 RVA: 0x0099044F File Offset: 0x0098E64F
		// (set) Token: 0x06027688 RID: 161416 RVA: 0x0099045F File Offset: 0x0098E65F
		public unsafe int TempIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NiagaraGroundBox_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170057FF RID: 22527
		// (get) Token: 0x06027689 RID: 161417 RVA: 0x00990470 File Offset: 0x0098E670
		// (set) Token: 0x0602768A RID: 161418 RVA: 0x00990484 File Offset: 0x0098E684
		public unsafe UNiagaraSystem NiagaraAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NiagaraGroundBox_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NiagaraGroundBox_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x0602768B RID: 161419 RVA: 0x00990499 File Offset: 0x0098E699
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EvalSample()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NiagaraGroundBox_C.__EvalSample_NativeFunctionPtr, null);
		}

		// Token: 0x0602768C RID: 161420 RVA: 0x009904AD File Offset: 0x0098E6AD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Refresh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NiagaraGroundBox_C.__Refresh_NativeFunctionPtr, null);
		}

		// Token: 0x0602768D RID: 161421 RVA: 0x009904C4 File Offset: 0x0098E6C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TraceImpl(bool DrawOnly)
		{
			BP_NiagaraGroundBox_C.__TraceImpl_FunctionParams* ptr = stackalloc BP_NiagaraGroundBox_C.__TraceImpl_FunctionParams[(UIntPtr)671] + 15L / (long)sizeof(BP_NiagaraGroundBox_C.__TraceImpl_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NiagaraGroundBox_C.__TraceImpl_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DrawOnly = DrawOnly;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NiagaraGroundBox_C.__TraceImpl_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602768E RID: 161422 RVA: 0x0099050D File Offset: 0x0098E70D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Calculate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NiagaraGroundBox_C.__Calculate_NativeFunctionPtr, null);
		}

		// Token: 0x0602768F RID: 161423 RVA: 0x00990521 File Offset: 0x0098E721
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DebugDraw()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NiagaraGroundBox_C.__DebugDraw_NativeFunctionPtr, null);
		}

		// Token: 0x06027690 RID: 161424 RVA: 0x00990538 File Offset: 0x0098E738
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_NiagaraGroundBox_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NiagaraGroundBox_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NiagaraGroundBox_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NiagaraGroundBox_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NiagaraGroundBox_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027691 RID: 161425 RVA: 0x00990580 File Offset: 0x0098E780
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_NiagaraGroundBox_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NiagaraGroundBox_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NiagaraGroundBox_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NiagaraGroundBox_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NiagaraGroundBox_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027692 RID: 161426 RVA: 0x009905C7 File Offset: 0x0098E7C7
		protected BP_NiagaraGroundBox_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E45 RID: 81477
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_NiagaraGroundBox.BP_NiagaraGroundBox_C";

		// Token: 0x04013E46 RID: 81478
		private static IntPtr _ClassPtr;

		// Token: 0x04013E47 RID: 81479
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E48 RID: 81480
		internal static int __PropertyOffset_1;

		// Token: 0x04013E49 RID: 81481
		internal static int __PropertyOffset_2;

		// Token: 0x04013E4A RID: 81482
		internal static int __PropertyOffset_3;

		// Token: 0x04013E4B RID: 81483
		internal static int __PropertyOffset_4;

		// Token: 0x04013E4C RID: 81484
		internal static int __PropertyOffset_5;

		// Token: 0x04013E4D RID: 81485
		private TArray<FVector> _ResArray;

		// Token: 0x04013E4E RID: 81486
		internal static int __PropertyOffset_6;

		// Token: 0x04013E4F RID: 81487
		internal static int __PropertyOffset_7;

		// Token: 0x04013E50 RID: 81488
		internal static int __PropertyOffset_8;

		// Token: 0x04013E51 RID: 81489
		internal static int __PropertyOffset_9;

		// Token: 0x04013E52 RID: 81490
		internal static int __PropertyOffset_10;

		// Token: 0x04013E53 RID: 81491
		internal static int __PropertyOffset_11;

		// Token: 0x04013E54 RID: 81492
		private static IntPtr __EvalSample_NativeFunctionPtr;

		// Token: 0x04013E55 RID: 81493
		private static IntPtr __Refresh_NativeFunctionPtr;

		// Token: 0x04013E56 RID: 81494
		private static IntPtr __TraceImpl_NativeFunctionPtr;

		// Token: 0x04013E57 RID: 81495
		private static IntPtr __Calculate_NativeFunctionPtr;

		// Token: 0x04013E58 RID: 81496
		private static IntPtr __DebugDraw_NativeFunctionPtr;

		// Token: 0x04013E59 RID: 81497
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A221 RID: 41505
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 656)]
		protected ref struct __TraceImpl_FunctionParams
		{
			// Token: 0x04031E8B RID: 204427
			[FieldOffset(0)]
			public bool DrawOnly;
		}

		// Token: 0x0200A222 RID: 41506
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031E8C RID: 204428
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
