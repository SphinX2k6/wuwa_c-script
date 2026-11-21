using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay
{
	// Token: 0x020032AC RID: 12972
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Poker.ABP_BaseRole_Gameplay_Poker_C")]
	[UnrealStructLayout(14096, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 14090)]
	public class ABP_BaseRole_Gameplay_Poker_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060209FE RID: 133630 RVA: 0x0094B447 File Offset: 0x00949647
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_Gameplay_Poker_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Poker.ABP_BaseRole_Gameplay_Poker_C");
			}
			return ABP_BaseRole_Gameplay_Poker_C._ClassPtr;
		}

		// Token: 0x060209FF RID: 133631 RVA: 0x0094B46C File Offset: 0x0094966C
		public ABP_BaseRole_Gameplay_Poker_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Poker_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A00 RID: 133632 RVA: 0x0094B494 File Offset: 0x00949694
		[NullableContext(1)]
		public ABP_BaseRole_Gameplay_Poker_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Poker_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004019 RID: 16409
		// (get) Token: 0x06020A01 RID: 133633 RVA: 0x0094B4C7 File Offset: 0x009496C7
		// (set) Token: 0x06020A02 RID: 133634 RVA: 0x0094B4DB File Offset: 0x009496DB
		public unsafe TEnumAsByte<EPokerStateType> PokerState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_PokerState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_PokerState) = value;
			}
		}

		// Token: 0x1700401A RID: 16410
		// (get) Token: 0x06020A03 RID: 133635 RVA: 0x0094B4F0 File Offset: 0x009496F0
		// (set) Token: 0x06020A04 RID: 133636 RVA: 0x0094B500 File Offset: 0x00949700
		public unsafe float 猜鬼牌表演倒计时
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_猜鬼牌表演倒计时);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_猜鬼牌表演倒计时) = value;
			}
		}

		// Token: 0x1700401B RID: 16411
		// (get) Token: 0x06020A05 RID: 133637 RVA: 0x0094B511 File Offset: 0x00949711
		// (set) Token: 0x06020A06 RID: 133638 RVA: 0x0094B521 File Offset: 0x00949721
		public unsafe int PokerPerformanceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_PokerPerformanceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_PokerPerformanceIndex) = value;
			}
		}

		// Token: 0x1700401C RID: 16412
		// (get) Token: 0x06020A07 RID: 133639 RVA: 0x0094B532 File Offset: 0x00949732
		// (set) Token: 0x06020A08 RID: 133640 RVA: 0x0094B542 File Offset: 0x00949742
		public unsafe float DeltaTimeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_DeltaTimeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_DeltaTimeX) = value;
			}
		}

		// Token: 0x1700401D RID: 16413
		// (get) Token: 0x06020A09 RID: 133641 RVA: 0x0094B553 File Offset: 0x00949753
		// (set) Token: 0x06020A0A RID: 133642 RVA: 0x0094B567 File Offset: 0x00949767
		public unsafe TEnumAsByte<EPokerIdleState> IdleState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_IdleState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_IdleState) = value;
			}
		}

		// Token: 0x1700401E RID: 16414
		// (get) Token: 0x06020A0B RID: 133643 RVA: 0x0094B57C File Offset: 0x0094977C
		// (set) Token: 0x06020A0C RID: 133644 RVA: 0x0094B58C File Offset: 0x0094978C
		public unsafe bool bIdleTimerActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_bIdleTimerActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_bIdleTimerActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700401F RID: 16415
		// (get) Token: 0x06020A0D RID: 133645 RVA: 0x0094B59D File Offset: 0x0094979D
		// (set) Token: 0x06020A0E RID: 133646 RVA: 0x0094B5AD File Offset: 0x009497AD
		public unsafe int BeChooseEmotionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_BeChooseEmotionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_BeChooseEmotionIndex) = value;
			}
		}

		// Token: 0x17004020 RID: 16416
		// (get) Token: 0x06020A0F RID: 133647 RVA: 0x0094B5BE File Offset: 0x009497BE
		// (set) Token: 0x06020A10 RID: 133648 RVA: 0x0094B5CE File Offset: 0x009497CE
		public unsafe bool bPlayerInteractiveStage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_bPlayerInteractiveStage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_bPlayerInteractiveStage) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004021 RID: 16417
		// (get) Token: 0x06020A11 RID: 133649 RVA: 0x0094B5DF File Offset: 0x009497DF
		// (set) Token: 0x06020A12 RID: 133650 RVA: 0x0094B5EF File Offset: 0x009497EF
		public unsafe bool bForceEndLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_bForceEndLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_bForceEndLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020A13 RID: 133651 RVA: 0x0094B600 File Offset: 0x00949800
		[SkipLocalsInit]
		public virtual void InitPerformanceTickTime()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__InitPerformanceTickTime_NativeFunctionPtr, null);
		}

		// Token: 0x06020A14 RID: 133652 RVA: 0x0094B614 File Offset: 0x00949814
		[SkipLocalsInit]
		public unsafe virtual void SetPlayerInteractiveStage(bool isInteractive)
		{
			ABP_BaseRole_Gameplay_Poker_C.__SetPlayerInteractiveStage_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Poker_C.__SetPlayerInteractiveStage_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Poker_C.__SetPlayerInteractiveStage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Poker_C.__SetPlayerInteractiveStage_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isInteractive = isInteractive;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__SetPlayerInteractiveStage_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A15 RID: 133653 RVA: 0x0094B65C File Offset: 0x0094985C
		[SkipLocalsInit]
		public unsafe virtual void SetBeChooseEmotionIndex(int index)
		{
			ABP_BaseRole_Gameplay_Poker_C.__SetBeChooseEmotionIndex_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Poker_C.__SetBeChooseEmotionIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Poker_C.__SetBeChooseEmotionIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Poker_C.__SetBeChooseEmotionIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->index = index;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__SetBeChooseEmotionIndex_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A16 RID: 133654 RVA: 0x0094B6A2 File Offset: 0x009498A2
		[SkipLocalsInit]
		public virtual void ReturnIdel()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__ReturnIdel_NativeFunctionPtr, null);
		}

		// Token: 0x06020A17 RID: 133655 RVA: 0x0094B6B8 File Offset: 0x009498B8
		[SkipLocalsInit]
		public unsafe virtual void SetPokerIdleState(EPokerIdleState IdleState)
		{
			ABP_BaseRole_Gameplay_Poker_C.__SetPokerIdleState_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Poker_C.__SetPokerIdleState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Poker_C.__SetPokerIdleState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Poker_C.__SetPokerIdleState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IdleState = IdleState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__SetPokerIdleState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A18 RID: 133656 RVA: 0x0094B704 File Offset: 0x00949904
		[SkipLocalsInit]
		public unsafe virtual void SetPokerState(EPokerStateType PokerState)
		{
			ABP_BaseRole_Gameplay_Poker_C.__SetPokerState_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Poker_C.__SetPokerState_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Poker_C.__SetPokerState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Poker_C.__SetPokerState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PokerState = PokerState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__SetPokerState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A19 RID: 133657 RVA: 0x0094B74F File Offset: 0x0094994F
		[SkipLocalsInit]
		public virtual void 设置猜鬼牌表演倒计时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__设置猜鬼牌表演倒计时_NativeFunctionPtr, null);
		}

		// Token: 0x06020A1A RID: 133658 RVA: 0x0094B764 File Offset: 0x00949964
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A1B RID: 133659 RVA: 0x0094B7AC File Offset: 0x009499AC
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A1C RID: 133660 RVA: 0x0094B7F2 File Offset: 0x009499F2
		protected ABP_BaseRole_Gameplay_Poker_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A4C RID: 72268
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Poker.ABP_BaseRole_Gameplay_Poker_C";

		// Token: 0x04011A4D RID: 72269
		private static IntPtr _ClassPtr;

		// Token: 0x04011A4E RID: 72270
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A4F RID: 72271
		internal static int __PropertyOffset_PokerState;

		// Token: 0x04011A50 RID: 72272
		internal static int __PropertyOffset_猜鬼牌表演倒计时;

		// Token: 0x04011A51 RID: 72273
		internal static int __PropertyOffset_PokerPerformanceIndex;

		// Token: 0x04011A52 RID: 72274
		internal static int __PropertyOffset_DeltaTimeX;

		// Token: 0x04011A53 RID: 72275
		internal static int __PropertyOffset_IdleState;

		// Token: 0x04011A54 RID: 72276
		internal static int __PropertyOffset_bIdleTimerActive;

		// Token: 0x04011A55 RID: 72277
		internal static int __PropertyOffset_BeChooseEmotionIndex;

		// Token: 0x04011A56 RID: 72278
		internal static int __PropertyOffset_bPlayerInteractiveStage;

		// Token: 0x04011A57 RID: 72279
		internal static int __PropertyOffset_bForceEndLoop;

		// Token: 0x04011A58 RID: 72280
		private static IntPtr __InitPerformanceTickTime_NativeFunctionPtr;

		// Token: 0x04011A59 RID: 72281
		private static IntPtr __SetPlayerInteractiveStage_NativeFunctionPtr;

		// Token: 0x04011A5A RID: 72282
		private static IntPtr __SetBeChooseEmotionIndex_NativeFunctionPtr;

		// Token: 0x04011A5B RID: 72283
		private static IntPtr __ReturnIdel_NativeFunctionPtr;

		// Token: 0x04011A5C RID: 72284
		private static IntPtr __SetPokerIdleState_NativeFunctionPtr;

		// Token: 0x04011A5D RID: 72285
		private static IntPtr __SetPokerState_NativeFunctionPtr;

		// Token: 0x04011A5E RID: 72286
		private static IntPtr __设置猜鬼牌表演倒计时_NativeFunctionPtr;

		// Token: 0x04011A5F RID: 72287
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x02008F9A RID: 36762
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __SetPlayerInteractiveStage_FunctionParams
		{
			// Token: 0x0402CD3A RID: 183610
			[FieldOffset(0)]
			public bool isInteractive;
		}

		// Token: 0x02008F9B RID: 36763
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetBeChooseEmotionIndex_FunctionParams
		{
			// Token: 0x0402CD3B RID: 183611
			[FieldOffset(0)]
			public int index;
		}

		// Token: 0x02008F9C RID: 36764
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetPokerIdleState_FunctionParams
		{
			// Token: 0x0402CD3C RID: 183612
			[FieldOffset(0)]
			public TEnumAsByte<EPokerIdleState> IdleState;
		}

		// Token: 0x02008F9D RID: 36765
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __SetPokerState_FunctionParams
		{
			// Token: 0x0402CD3D RID: 183613
			[FieldOffset(0)]
			public TEnumAsByte<EPokerStateType> PokerState;
		}

		// Token: 0x02008F9E RID: 36766
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CD3E RID: 183614
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
