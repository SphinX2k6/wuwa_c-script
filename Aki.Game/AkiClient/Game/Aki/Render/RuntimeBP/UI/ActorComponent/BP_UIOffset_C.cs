using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UI.ActorComponent
{
	// Token: 0x02003AA3 RID: 15011
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UI/ActorComponent/BP_UIOffset.BP_UIOffset_C")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 285)]
	public class BP_UIOffset_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060201E8 RID: 131560 RVA: 0x008CA21D File Offset: 0x008C841D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_UIOffset_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/UI/ActorComponent/BP_UIOffset.BP_UIOffset_C");
			}
			return BP_UIOffset_C._ClassPtr;
		}

		// Token: 0x060201E9 RID: 131561 RVA: 0x008CA244 File Offset: 0x008C8444
		public BP_UIOffset_C() : this(BuiltinUtils.AllocNativeUObject(BP_UIOffset_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060201EA RID: 131562 RVA: 0x008CA26C File Offset: 0x008C846C
		public BP_UIOffset_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_UIOffset_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x060201EB RID: 131563 RVA: 0x008CA2A0 File Offset: 0x008C84A0
		// (set) Token: 0x060201EC RID: 131564 RVA: 0x008CA2D9 File Offset: 0x008C84D9
		public TArray<S_UIitemOffset> ActorDistances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<S_UIitemOffset> result;
				if ((result = this._ActorDistances) == null)
				{
					result = (this._ActorDistances = new TArray<S_UIitemOffset>(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.ActorDistances.CopyAssign(value);
			}
		}

		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x060201ED RID: 131565 RVA: 0x008CA2E8 File Offset: 0x008C84E8
		// (set) Token: 0x060201EE RID: 131566 RVA: 0x008CA321 File Offset: 0x008C8521
		public TArray<FVector2D> InitPosRecord
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._InitPosRecord) == null)
				{
					result = (this._InitPosRecord = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.InitPosRecord.CopyAssign(value);
			}
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x060201EF RID: 131567 RVA: 0x008CA32F File Offset: 0x008C852F
		// (set) Token: 0x060201F0 RID: 131568 RVA: 0x008CA343 File Offset: 0x008C8543
		public unsafe FVector2D ScaleXY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x060201F1 RID: 131569 RVA: 0x008CA358 File Offset: 0x008C8558
		// (set) Token: 0x060201F2 RID: 131570 RVA: 0x008CA368 File Offset: 0x008C8568
		public unsafe float LerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x060201F3 RID: 131571 RVA: 0x008CA379 File Offset: 0x008C8579
		// (set) Token: 0x060201F4 RID: 131572 RVA: 0x008CA389 File Offset: 0x008C8589
		public unsafe float IdleLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x060201F5 RID: 131573 RVA: 0x008CA39A File Offset: 0x008C859A
		// (set) Token: 0x060201F6 RID: 131574 RVA: 0x008CA3AE File Offset: 0x008C85AE
		public unsafe FVector2D VittualMousePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x060201F7 RID: 131575 RVA: 0x008CA3C3 File Offset: 0x008C85C3
		// (set) Token: 0x060201F8 RID: 131576 RVA: 0x008CA3D3 File Offset: 0x008C85D3
		public unsafe bool MobilePlatform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x060201F9 RID: 131577 RVA: 0x008CA3E4 File Offset: 0x008C85E4
		// (set) Token: 0x060201FA RID: 131578 RVA: 0x008CA3F4 File Offset: 0x008C85F4
		public unsafe float MobileSmoothLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x060201FB RID: 131579 RVA: 0x008CA405 File Offset: 0x008C8605
		// (set) Token: 0x060201FC RID: 131580 RVA: 0x008CA415 File Offset: 0x008C8615
		public unsafe float MobileOffsetFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x060201FD RID: 131581 RVA: 0x008CA426 File Offset: 0x008C8626
		// (set) Token: 0x060201FE RID: 131582 RVA: 0x008CA436 File Offset: 0x008C8636
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIOffset_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x060201FF RID: 131583 RVA: 0x008CA448 File Offset: 0x008C8648
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LrepVirtualMousePos(FVector2D NewPos, float DeltaSecond, ref FVector2D Output_Get)
		{
			BP_UIOffset_C.__LrepVirtualMousePos_FunctionParams* ptr = stackalloc BP_UIOffset_C.__LrepVirtualMousePos_FunctionParams[(UIntPtr)67] + 15L / (long)sizeof(BP_UIOffset_C.__LrepVirtualMousePos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIOffset_C.__LrepVirtualMousePos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewPos = NewPos;
			ptr->DeltaSecond = DeltaSecond;
			ptr->Output_Get = Output_Get;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIOffset_C.__LrepVirtualMousePos_NativeFunctionPtr, (void*)ptr);
			Output_Get = ptr->Output_Get;
		}

		// Token: 0x06020200 RID: 131584 RVA: 0x008CA4AD File Offset: 0x008C86AD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePlatform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIOffset_C.__UpdatePlatform_NativeFunctionPtr, null);
		}

		// Token: 0x06020201 RID: 131585 RVA: 0x008CA4C4 File Offset: 0x008C86C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetOffset(float DeltaSecond, ref FVector2D NewParam)
		{
			BP_UIOffset_C.__GetOffset_FunctionParams* ptr = stackalloc BP_UIOffset_C.__GetOffset_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_UIOffset_C.__GetOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIOffset_C.__GetOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSecond = DeltaSecond;
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIOffset_C.__GetOffset_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x06020202 RID: 131586 RVA: 0x008CA528 File Offset: 0x008C8728
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetMouseViewportPos(ref FVector2D NewParam)
		{
			BP_UIOffset_C.__GetMouseViewportPos_FunctionParams* ptr = stackalloc BP_UIOffset_C.__GetMouseViewportPos_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_UIOffset_C.__GetMouseViewportPos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIOffset_C.__GetMouseViewportPos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewParam = NewParam;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIOffset_C.__GetMouseViewportPos_NativeFunctionPtr, (void*)ptr);
			NewParam = ptr->NewParam;
		}

		// Token: 0x06020203 RID: 131587 RVA: 0x008CA582 File Offset: 0x008C8782
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIOffset_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020204 RID: 131588 RVA: 0x008CA596 File Offset: 0x008C8796
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UIOffset_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020205 RID: 131589 RVA: 0x008CA5AC File Offset: 0x008C87AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_UIOffset_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_UIOffset_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UIOffset_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIOffset_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIOffset_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020206 RID: 131590 RVA: 0x008CA5F4 File Offset: 0x008C87F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_UIOffset_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_UIOffset_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UIOffset_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIOffset_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UIOffset_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020207 RID: 131591 RVA: 0x008CA63B File Offset: 0x008C883B
		protected BP_UIOffset_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F83E RID: 63550
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UI/ActorComponent/BP_UIOffset.BP_UIOffset_C";

		// Token: 0x0400F83F RID: 63551
		private static IntPtr _ClassPtr;

		// Token: 0x0400F840 RID: 63552
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F841 RID: 63553
		internal static int __PropertyOffset_1;

		// Token: 0x0400F842 RID: 63554
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<S_UIitemOffset> _ActorDistances;

		// Token: 0x0400F843 RID: 63555
		internal static int __PropertyOffset_2;

		// Token: 0x0400F844 RID: 63556
		[Nullable(2)]
		private TArray<FVector2D> _InitPosRecord;

		// Token: 0x0400F845 RID: 63557
		internal static int __PropertyOffset_3;

		// Token: 0x0400F846 RID: 63558
		internal static int __PropertyOffset_4;

		// Token: 0x0400F847 RID: 63559
		internal static int __PropertyOffset_5;

		// Token: 0x0400F848 RID: 63560
		internal static int __PropertyOffset_6;

		// Token: 0x0400F849 RID: 63561
		internal static int __PropertyOffset_7;

		// Token: 0x0400F84A RID: 63562
		internal static int __PropertyOffset_8;

		// Token: 0x0400F84B RID: 63563
		internal static int __PropertyOffset_9;

		// Token: 0x0400F84C RID: 63564
		internal static int __PropertyOffset_10;

		// Token: 0x0400F84D RID: 63565
		private static IntPtr __LrepVirtualMousePos_NativeFunctionPtr;

		// Token: 0x0400F84E RID: 63566
		private static IntPtr __UpdatePlatform_NativeFunctionPtr;

		// Token: 0x0400F84F RID: 63567
		private static IntPtr __GetOffset_NativeFunctionPtr;

		// Token: 0x0400F850 RID: 63568
		private static IntPtr __GetMouseViewportPos_NativeFunctionPtr;

		// Token: 0x0400F851 RID: 63569
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F852 RID: 63570
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009B78 RID: 39800
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected ref struct __LrepVirtualMousePos_FunctionParams
		{
			// Token: 0x040311BC RID: 201148
			[FieldOffset(0)]
			public FVector2D NewPos;

			// Token: 0x040311BD RID: 201149
			[FieldOffset(8)]
			public float DeltaSecond;

			// Token: 0x040311BE RID: 201150
			[FieldOffset(12)]
			public FVector2D Output_Get;
		}

		// Token: 0x02009B79 RID: 39801
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __GetOffset_FunctionParams
		{
			// Token: 0x040311BF RID: 201151
			[FieldOffset(0)]
			public float DeltaSecond;

			// Token: 0x040311C0 RID: 201152
			[FieldOffset(4)]
			public FVector2D NewParam;
		}

		// Token: 0x02009B7A RID: 39802
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __GetMouseViewportPos_FunctionParams
		{
			// Token: 0x040311C1 RID: 201153
			[FieldOffset(0)]
			public FVector2D NewParam;
		}

		// Token: 0x02009B7B RID: 39803
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311C2 RID: 201154
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
