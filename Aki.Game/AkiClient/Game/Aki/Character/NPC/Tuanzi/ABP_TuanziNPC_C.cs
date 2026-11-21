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
	// Token: 0x020032AF RID: 12975
	[UnrealObjectPath("/Game/Aki/Character/NPC/Tuanzi/ABP_TuanziNPC.ABP_TuanziNPC_C")]
	[UnrealStructLayout(8832, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 8819)]
	public class ABP_TuanziNPC_C : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A4A RID: 133706 RVA: 0x0094BC5A File Offset: 0x00949E5A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_TuanziNPC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Tuanzi/ABP_TuanziNPC.ABP_TuanziNPC_C");
			}
			return ABP_TuanziNPC_C._ClassPtr;
		}

		// Token: 0x06020A4B RID: 133707 RVA: 0x0094BC80 File Offset: 0x00949E80
		public ABP_TuanziNPC_C() : this(BuiltinUtils.AllocNativeUObject(ABP_TuanziNPC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A4C RID: 133708 RVA: 0x0094BCA8 File Offset: 0x00949EA8
		[NullableContext(1)]
		public ABP_TuanziNPC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_TuanziNPC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004031 RID: 16433
		// (get) Token: 0x06020A4D RID: 133709 RVA: 0x0094BCDB File Offset: 0x00949EDB
		// (set) Token: 0x06020A4E RID: 133710 RVA: 0x0094BCEB File Offset: 0x00949EEB
		public unsafe float JumpHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_JumpHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_JumpHeight) = value;
			}
		}

		// Token: 0x17004032 RID: 16434
		// (get) Token: 0x06020A4F RID: 133711 RVA: 0x0094BCFC File Offset: 0x00949EFC
		// (set) Token: 0x06020A50 RID: 133712 RVA: 0x0094BD0C File Offset: 0x00949F0C
		public unsafe float JumpDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_JumpDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_JumpDistance) = value;
			}
		}

		// Token: 0x17004033 RID: 16435
		// (get) Token: 0x06020A51 RID: 133713 RVA: 0x0094BD1D File Offset: 0x00949F1D
		// (set) Token: 0x06020A52 RID: 133714 RVA: 0x0094BD31 File Offset: 0x00949F31
		public unsafe TEnumAsByte<EDangoState> CurrentState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_CurrentState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_CurrentState) = value;
			}
		}

		// Token: 0x17004034 RID: 16436
		// (get) Token: 0x06020A53 RID: 133715 RVA: 0x0094BD46 File Offset: 0x00949F46
		// (set) Token: 0x06020A54 RID: 133716 RVA: 0x0094BD56 File Offset: 0x00949F56
		public unsafe bool IsBeginStandbyPerform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_IsBeginStandbyPerform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_IsBeginStandbyPerform) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004035 RID: 16437
		// (get) Token: 0x06020A55 RID: 133717 RVA: 0x0094BD67 File Offset: 0x00949F67
		// (set) Token: 0x06020A56 RID: 133718 RVA: 0x0094BD77 File Offset: 0x00949F77
		public unsafe int StandbyPerformIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_StandbyPerformIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_StandbyPerformIndex) = value;
			}
		}

		// Token: 0x17004036 RID: 16438
		// (get) Token: 0x06020A57 RID: 133719 RVA: 0x0094BD88 File Offset: 0x00949F88
		// (set) Token: 0x06020A58 RID: 133720 RVA: 0x0094BD9C File Offset: 0x00949F9C
		public unsafe TEnumAsByte<EDangoActionPerformType> ActionPerformType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_ActionPerformType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_ActionPerformType) = value;
			}
		}

		// Token: 0x17004037 RID: 16439
		// (get) Token: 0x06020A59 RID: 133721 RVA: 0x0094BDB1 File Offset: 0x00949FB1
		// (set) Token: 0x06020A5A RID: 133722 RVA: 0x0094BDC1 File Offset: 0x00949FC1
		public unsafe bool IsJumpForward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_IsJumpForward) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_IsJumpForward) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004038 RID: 16440
		// (get) Token: 0x06020A5B RID: 133723 RVA: 0x0094BDD2 File Offset: 0x00949FD2
		// (set) Token: 0x06020A5C RID: 133724 RVA: 0x0094BDE2 File Offset: 0x00949FE2
		public unsafe bool bForceReturnToStand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_bForceReturnToStand) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_TuanziNPC_C.__PropertyOffset_bForceReturnToStand) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020A5D RID: 133725 RVA: 0x0094BDF4 File Offset: 0x00949FF4
		[SkipLocalsInit]
		public unsafe virtual void StartJumpBackwardWithParams(float JumpHeight, float JumpDistance)
		{
			ABP_TuanziNPC_C.__StartJumpBackwardWithParams_FunctionParams* ptr = stackalloc ABP_TuanziNPC_C.__StartJumpBackwardWithParams_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_TuanziNPC_C.__StartJumpBackwardWithParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_TuanziNPC_C.__StartJumpBackwardWithParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->JumpHeight = JumpHeight;
			ptr->JumpDistance = JumpDistance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TuanziNPC_C.__StartJumpBackwardWithParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A5E RID: 133726 RVA: 0x0094BE41 File Offset: 0x0094A041
		[SkipLocalsInit]
		public virtual void ReturnStand()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TuanziNPC_C.__ReturnStand_NativeFunctionPtr, null);
		}

		// Token: 0x06020A5F RID: 133727 RVA: 0x0094BE58 File Offset: 0x0094A058
		[SkipLocalsInit]
		public unsafe virtual void StartActionPerform(EDangoActionPerformType ActionPerformType)
		{
			ABP_TuanziNPC_C.__StartActionPerform_FunctionParams* ptr = stackalloc ABP_TuanziNPC_C.__StartActionPerform_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(ABP_TuanziNPC_C.__StartActionPerform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_TuanziNPC_C.__StartActionPerform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ActionPerformType = ActionPerformType;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TuanziNPC_C.__StartActionPerform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A60 RID: 133728 RVA: 0x0094BEA4 File Offset: 0x0094A0A4
		[SkipLocalsInit]
		public unsafe virtual void StartStandPerform(int StandbyPerformIndex)
		{
			ABP_TuanziNPC_C.__StartStandPerform_FunctionParams* ptr = stackalloc ABP_TuanziNPC_C.__StartStandPerform_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(ABP_TuanziNPC_C.__StartStandPerform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_TuanziNPC_C.__StartStandPerform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StandbyPerformIndex = StandbyPerformIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TuanziNPC_C.__StartStandPerform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A61 RID: 133729 RVA: 0x0094BEEC File Offset: 0x0094A0EC
		[SkipLocalsInit]
		public unsafe virtual void StartJumpWithParams(float JumpHeight, float JumpDistance)
		{
			ABP_TuanziNPC_C.__StartJumpWithParams_FunctionParams* ptr = stackalloc ABP_TuanziNPC_C.__StartJumpWithParams_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(ABP_TuanziNPC_C.__StartJumpWithParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_TuanziNPC_C.__StartJumpWithParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->JumpHeight = JumpHeight;
			ptr->JumpDistance = JumpDistance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_TuanziNPC_C.__StartJumpWithParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020A62 RID: 133730 RVA: 0x0094BF39 File Offset: 0x0094A139
		protected ABP_TuanziNPC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A79 RID: 72313
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Tuanzi/ABP_TuanziNPC.ABP_TuanziNPC_C";

		// Token: 0x04011A7A RID: 72314
		private static IntPtr _ClassPtr;

		// Token: 0x04011A7B RID: 72315
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A7C RID: 72316
		internal static int __PropertyOffset_JumpHeight;

		// Token: 0x04011A7D RID: 72317
		internal static int __PropertyOffset_JumpDistance;

		// Token: 0x04011A7E RID: 72318
		internal static int __PropertyOffset_CurrentState;

		// Token: 0x04011A7F RID: 72319
		internal static int __PropertyOffset_IsBeginStandbyPerform;

		// Token: 0x04011A80 RID: 72320
		internal static int __PropertyOffset_StandbyPerformIndex;

		// Token: 0x04011A81 RID: 72321
		internal static int __PropertyOffset_ActionPerformType;

		// Token: 0x04011A82 RID: 72322
		internal static int __PropertyOffset_IsJumpForward;

		// Token: 0x04011A83 RID: 72323
		internal static int __PropertyOffset_bForceReturnToStand;

		// Token: 0x04011A84 RID: 72324
		private static IntPtr __StartJumpBackwardWithParams_NativeFunctionPtr;

		// Token: 0x04011A85 RID: 72325
		private static IntPtr __ReturnStand_NativeFunctionPtr;

		// Token: 0x04011A86 RID: 72326
		private static IntPtr __StartActionPerform_NativeFunctionPtr;

		// Token: 0x04011A87 RID: 72327
		private static IntPtr __StartStandPerform_NativeFunctionPtr;

		// Token: 0x04011A88 RID: 72328
		private static IntPtr __StartJumpWithParams_NativeFunctionPtr;

		// Token: 0x02008FA1 RID: 36769
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __StartJumpBackwardWithParams_FunctionParams
		{
			// Token: 0x0402CD41 RID: 183617
			[FieldOffset(0)]
			public float JumpHeight;

			// Token: 0x0402CD42 RID: 183618
			[FieldOffset(4)]
			public float JumpDistance;
		}

		// Token: 0x02008FA2 RID: 36770
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __StartActionPerform_FunctionParams
		{
			// Token: 0x0402CD43 RID: 183619
			[FieldOffset(0)]
			public TEnumAsByte<EDangoActionPerformType> ActionPerformType;
		}

		// Token: 0x02008FA3 RID: 36771
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __StartStandPerform_FunctionParams
		{
			// Token: 0x0402CD44 RID: 183620
			[FieldOffset(0)]
			public int StandbyPerformIndex;
		}

		// Token: 0x02008FA4 RID: 36772
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __StartJumpWithParams_FunctionParams
		{
			// Token: 0x0402CD45 RID: 183621
			[FieldOffset(0)]
			public float JumpHeight;

			// Token: 0x0402CD46 RID: 183622
			[FieldOffset(4)]
			public float JumpDistance;
		}
	}
}
