using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Tuanzi
{
	// Token: 0x0200418D RID: 16781
	[UnrealObjectPath("/Game/Aki/Character/NPC/Tuanzi/ABP_TuanziNPC.ABP_TuanziNPC_C")]
	[UnrealStructLayout(8816, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 8803)]
	public class ABP_TuanziNPC_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B742 RID: 177986 RVA: 0x00A0147E File Offset: 0x009FF67E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_TuanziNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Tuanzi/ABP_TuanziNPC.ABP_TuanziNPC_C");
			}
			return ABP_TuanziNPC_C._ClassPtr;
		}

		// Token: 0x0602B743 RID: 177987 RVA: 0x00A014A4 File Offset: 0x009FF6A4
		public ABP_TuanziNPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_TuanziNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B744 RID: 177988 RVA: 0x00A014CC File Offset: 0x009FF6CC
		[NullableContext(1)]
		public ABP_TuanziNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_TuanziNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B2E RID: 27438
		// (get) Token: 0x0602B745 RID: 177989 RVA: 0x00A014FF File Offset: 0x009FF6FF
		// (set) Token: 0x0602B746 RID: 177990 RVA: 0x00A0150F File Offset: 0x009FF70F
		public unsafe float JumpHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17006B2F RID: 27439
		// (get) Token: 0x0602B747 RID: 177991 RVA: 0x00A01520 File Offset: 0x009FF720
		// (set) Token: 0x0602B748 RID: 177992 RVA: 0x00A01530 File Offset: 0x009FF730
		public unsafe float JumpDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x17006B30 RID: 27440
		// (get) Token: 0x0602B749 RID: 177993 RVA: 0x00A01541 File Offset: 0x009FF741
		// (set) Token: 0x0602B74A RID: 177994 RVA: 0x00A01555 File Offset: 0x009FF755
		public unsafe TEnumAsByte<EDangoState> CurrentState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_55);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_55) = value;
			}
		}

		// Token: 0x17006B31 RID: 27441
		// (get) Token: 0x0602B74B RID: 177995 RVA: 0x00A0156A File Offset: 0x009FF76A
		// (set) Token: 0x0602B74C RID: 177996 RVA: 0x00A0157A File Offset: 0x009FF77A
		public unsafe bool IsBeginStandbyPerform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_56) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_56) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B32 RID: 27442
		// (get) Token: 0x0602B74D RID: 177997 RVA: 0x00A0158B File Offset: 0x009FF78B
		// (set) Token: 0x0602B74E RID: 177998 RVA: 0x00A0159B File Offset: 0x009FF79B
		public unsafe int StandbyPerformIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x17006B33 RID: 27443
		// (get) Token: 0x0602B74F RID: 177999 RVA: 0x00A015AC File Offset: 0x009FF7AC
		// (set) Token: 0x0602B750 RID: 178000 RVA: 0x00A015C0 File Offset: 0x009FF7C0
		public unsafe TEnumAsByte<EDangoActionPerformType> ActionPerformType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_58);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x17006B34 RID: 27444
		// (get) Token: 0x0602B751 RID: 178001 RVA: 0x00A015D5 File Offset: 0x009FF7D5
		// (set) Token: 0x0602B752 RID: 178002 RVA: 0x00A015E5 File Offset: 0x009FF7E5
		public unsafe bool IsJumpForward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_59) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_59) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006B35 RID: 27445
		// (get) Token: 0x0602B753 RID: 178003 RVA: 0x00A015F6 File Offset: 0x009FF7F6
		// (set) Token: 0x0602B754 RID: 178004 RVA: 0x00A01606 File Offset: 0x009FF806
		public unsafe bool bForceReturnToStand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_60) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_60) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B755 RID: 178005 RVA: 0x00A01618 File Offset: 0x009FF818
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_TuanziNPC_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_TuanziNPC_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_TuanziNPC_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_TuanziNPC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TuanziNPC_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602B756 RID: 178006 RVA: 0x00A016A0 File Offset: 0x009FF8A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void StartJumpBackwardWithParams(float JumpHeight, float JumpDistance)
		{
			ABP_TuanziNPC_C.__StartJumpBackwardWithParams_FunctionParams* ptr = stackalloc ABP_TuanziNPC_C.__StartJumpBackwardWithParams_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_TuanziNPC_C.__StartJumpBackwardWithParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_TuanziNPC_C.__StartJumpBackwardWithParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->JumpHeight = JumpHeight;
			ptr->JumpDistance = JumpDistance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TuanziNPC_C.__StartJumpBackwardWithParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B757 RID: 178007 RVA: 0x00A016ED File Offset: 0x009FF8ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ReturnStand()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TuanziNPC_C.__ReturnStand_NativeFunctionPtr, null);
		}

		// Token: 0x0602B758 RID: 178008 RVA: 0x00A01704 File Offset: 0x009FF904
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void StartActionPerform(EDangoActionPerformType ActionPerformType)
		{
			ABP_TuanziNPC_C.__StartActionPerform_FunctionParams* ptr = stackalloc ABP_TuanziNPC_C.__StartActionPerform_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_TuanziNPC_C.__StartActionPerform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_TuanziNPC_C.__StartActionPerform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ActionPerformType = ActionPerformType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TuanziNPC_C.__StartActionPerform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B759 RID: 178009 RVA: 0x00A01750 File Offset: 0x009FF950
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void StartStandPerform(int StandbyPerformIndex)
		{
			ABP_TuanziNPC_C.__StartStandPerform_FunctionParams* ptr = stackalloc ABP_TuanziNPC_C.__StartStandPerform_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ABP_TuanziNPC_C.__StartStandPerform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_TuanziNPC_C.__StartStandPerform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StandbyPerformIndex = StandbyPerformIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TuanziNPC_C.__StartStandPerform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B75A RID: 178010 RVA: 0x00A01798 File Offset: 0x009FF998
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void StartJumpWithParams(float JumpHeight, float JumpDistance)
		{
			ABP_TuanziNPC_C.__StartJumpWithParams_FunctionParams* ptr = stackalloc ABP_TuanziNPC_C.__StartJumpWithParams_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_TuanziNPC_C.__StartJumpWithParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_TuanziNPC_C.__StartJumpWithParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->JumpHeight = JumpHeight;
			ptr->JumpDistance = JumpDistance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TuanziNPC_C.__StartJumpWithParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B75B RID: 178011 RVA: 0x00A017E5 File Offset: 0x009FF9E5
		protected ABP_TuanziNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040169E5 RID: 92645
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Tuanzi/ABP_TuanziNPC.ABP_TuanziNPC_C";

		// Token: 0x040169E6 RID: 92646
		private static IntPtr _ClassPtr;

		// Token: 0x040169E7 RID: 92647
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040169E8 RID: 92648
		internal static int __PropertyOffset_53;

		// Token: 0x040169E9 RID: 92649
		internal static int __PropertyOffset_54;

		// Token: 0x040169EA RID: 92650
		internal static int __PropertyOffset_55;

		// Token: 0x040169EB RID: 92651
		internal static int __PropertyOffset_56;

		// Token: 0x040169EC RID: 92652
		internal static int __PropertyOffset_57;

		// Token: 0x040169ED RID: 92653
		internal static int __PropertyOffset_58;

		// Token: 0x040169EE RID: 92654
		internal static int __PropertyOffset_59;

		// Token: 0x040169EF RID: 92655
		internal static int __PropertyOffset_60;

		// Token: 0x040169F0 RID: 92656
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x040169F1 RID: 92657
		private static IntPtr __StartJumpBackwardWithParams_NativeFunctionPtr;

		// Token: 0x040169F2 RID: 92658
		private static IntPtr __ReturnStand_NativeFunctionPtr;

		// Token: 0x040169F3 RID: 92659
		private static IntPtr __StartActionPerform_NativeFunctionPtr;

		// Token: 0x040169F4 RID: 92660
		private static IntPtr __StartStandPerform_NativeFunctionPtr;

		// Token: 0x040169F5 RID: 92661
		private static IntPtr __StartJumpWithParams_NativeFunctionPtr;

		// Token: 0x0200A530 RID: 42288
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403239F RID: 205727
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A531 RID: 42289
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __StartJumpBackwardWithParams_FunctionParams
		{
			// Token: 0x040323A0 RID: 205728
			[FieldOffset(0)]
			public float JumpHeight;

			// Token: 0x040323A1 RID: 205729
			[FieldOffset(4)]
			public float JumpDistance;
		}

		// Token: 0x0200A532 RID: 42290
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __StartActionPerform_FunctionParams
		{
			// Token: 0x040323A2 RID: 205730
			[FieldOffset(0)]
			public TEnumAsByte<EDangoActionPerformType> ActionPerformType;
		}

		// Token: 0x0200A533 RID: 42291
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StartStandPerform_FunctionParams
		{
			// Token: 0x040323A3 RID: 205731
			[FieldOffset(0)]
			public int StandbyPerformIndex;
		}

		// Token: 0x0200A534 RID: 42292
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __StartJumpWithParams_FunctionParams
		{
			// Token: 0x040323A4 RID: 205732
			[FieldOffset(0)]
			public float JumpHeight;

			// Token: 0x040323A5 RID: 205733
			[FieldOffset(4)]
			public float JumpDistance;
		}
	}
}
