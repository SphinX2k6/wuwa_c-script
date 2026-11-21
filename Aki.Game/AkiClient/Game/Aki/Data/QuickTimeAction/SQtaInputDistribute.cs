using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.QuickTimeAction
{
	// Token: 0x0200317F RID: 12671
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/QuickTimeAction/SQtaInputDistribute.SQtaInputDistribute")]
	[UnrealStructLayout(5, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 5)]
	public class SQtaInputDistribute : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F412 RID: 128018 RVA: 0x00929B53 File Offset: 0x00927D53
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQtaInputDistribute._ScriptStructPtr != 0) ? SQtaInputDistribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/QuickTimeAction/SQtaInputDistribute.SQtaInputDistribute", ref SQtaInputDistribute._ScriptStructPtr);
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0601F413 RID: 128019 RVA: 0x00929B77 File Offset: 0x00927D77
		// (set) Token: 0x0601F414 RID: 128020 RVA: 0x00929B87 File Offset: 0x00927D87
		public unsafe bool FightInputRoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_FightInputRoot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_FightInputRoot) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x0601F415 RID: 128021 RVA: 0x00929B98 File Offset: 0x00927D98
		// (set) Token: 0x0601F416 RID: 128022 RVA: 0x00929BA8 File Offset: 0x00927DA8
		public unsafe bool FightActionInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_FightActionInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_FightActionInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x0601F417 RID: 128023 RVA: 0x00929BB9 File Offset: 0x00927DB9
		// (set) Token: 0x0601F418 RID: 128024 RVA: 0x00929BC9 File Offset: 0x00927DC9
		public unsafe bool FightAxisInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_FightAxisInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_FightAxisInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x0601F419 RID: 128025 RVA: 0x00929BDA File Offset: 0x00927DDA
		// (set) Token: 0x0601F41A RID: 128026 RVA: 0x00929BEA File Offset: 0x00927DEA
		public unsafe bool InteractionRoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_InteractionRoot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_InteractionRoot) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x0601F41B RID: 128027 RVA: 0x00929BFB File Offset: 0x00927DFB
		// (set) Token: 0x0601F41C RID: 128028 RVA: 0x00929C0B File Offset: 0x00927E0B
		public unsafe bool UiInputRoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_UiInputRoot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQtaInputDistribute.__PropertyOffset_UiInputRoot) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F41D RID: 128029 RVA: 0x00929C1C File Offset: 0x00927E1C
		public SQtaInputDistribute()
		{
		}

		// Token: 0x0601F41E RID: 128030 RVA: 0x00929C24 File Offset: 0x00927E24
		protected override IntPtr GetUStructPtr()
		{
			return SQtaInputDistribute.StaticStruct();
		}

		// Token: 0x0601F41F RID: 128031 RVA: 0x00929C30 File Offset: 0x00927E30
		[NullableContext(2)]
		public SQtaInputDistribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F420 RID: 128032 RVA: 0x00929C3A File Offset: 0x00927E3A
		public SQtaInputDistribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F421 RID: 128033 RVA: 0x00929C45 File Offset: 0x00927E45
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQtaInputDistribute(Pointer, false, true);
		}

		// Token: 0x0601F422 RID: 128034 RVA: 0x00929C4F File Offset: 0x00927E4F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQtaInputDistribute(Pointer, MemoryOwner);
		}

		// Token: 0x04010B9E RID: 68510
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/QuickTimeAction/SQtaInputDistribute.SQtaInputDistribute";

		// Token: 0x04010B9F RID: 68511
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010BA0 RID: 68512
		internal static int __PropertyOffset_FightInputRoot;

		// Token: 0x04010BA1 RID: 68513
		internal static int __PropertyOffset_FightActionInput;

		// Token: 0x04010BA2 RID: 68514
		internal static int __PropertyOffset_FightAxisInput;

		// Token: 0x04010BA3 RID: 68515
		internal static int __PropertyOffset_InteractionRoot;

		// Token: 0x04010BA4 RID: 68516
		internal static int __PropertyOffset_UiInputRoot;
	}
}
