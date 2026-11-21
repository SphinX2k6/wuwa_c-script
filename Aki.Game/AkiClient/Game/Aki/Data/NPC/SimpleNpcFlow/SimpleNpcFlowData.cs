using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow
{
	// Token: 0x020031B2 RID: 12722
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/NPC/SimpleNpcFlow/SimpleNpcFlowData.SimpleNpcFlowData")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class SimpleNpcFlowData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F692 RID: 128658 RVA: 0x0092D359 File Offset: 0x0092B559
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SimpleNpcFlowData._ScriptStructPtr != 0) ? SimpleNpcFlowData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/NPC/SimpleNpcFlow/SimpleNpcFlowData.SimpleNpcFlowData", ref SimpleNpcFlowData._ScriptStructPtr);
		}

		// Token: 0x1700391C RID: 14620
		// (get) Token: 0x0601F693 RID: 128659 RVA: 0x0092D37D File Offset: 0x0092B57D
		// (set) Token: 0x0601F694 RID: 128660 RVA: 0x0092D391 File Offset: 0x0092B591
		[Nullable(0)]
		public unsafe TEnumAsByte<ESimpleNpcFlowIndex> Pawn
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_Pawn);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_Pawn) = value;
			}
		}

		// Token: 0x1700391D RID: 14621
		// (get) Token: 0x0601F695 RID: 128661 RVA: 0x0092D3A6 File Offset: 0x0092B5A6
		// (set) Token: 0x0601F696 RID: 128662 RVA: 0x0092D3BA File Offset: 0x0092B5BA
		[Nullable(0)]
		public unsafe TEnumAsByte<ESimpleNpcFlowCheckType> CheckType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_CheckType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_CheckType) = value;
			}
		}

		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x0601F697 RID: 128663 RVA: 0x0092D3CF File Offset: 0x0092B5CF
		// (set) Token: 0x0601F698 RID: 128664 RVA: 0x0092D3DF File Offset: 0x0092B5DF
		public unsafe int CheckValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_CheckValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_CheckValue) = value;
			}
		}

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x0601F699 RID: 128665 RVA: 0x0092D3F0 File Offset: 0x0092B5F0
		// (set) Token: 0x0601F69A RID: 128666 RVA: 0x0092D404 File Offset: 0x0092B604
		public unsafe string FlowListName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SimpleNpcFlowData.__PropertyOffset_FlowListName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SimpleNpcFlowData.__PropertyOffset_FlowListName)), value);
			}
		}

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x0601F69B RID: 128667 RVA: 0x0092D419 File Offset: 0x0092B619
		// (set) Token: 0x0601F69C RID: 128668 RVA: 0x0092D42D File Offset: 0x0092B62D
		public unsafe string FlowSubTitle
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SimpleNpcFlowData.__PropertyOffset_FlowSubTitle)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SimpleNpcFlowData.__PropertyOffset_FlowSubTitle)), value);
			}
		}

		// Token: 0x17003921 RID: 14625
		// (get) Token: 0x0601F69D RID: 128669 RVA: 0x0092D442 File Offset: 0x0092B642
		// (set) Token: 0x0601F69E RID: 128670 RVA: 0x0092D452 File Offset: 0x0092B652
		public unsafe float LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_LoopTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_LoopTime) = value;
			}
		}

		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x0601F69F RID: 128671 RVA: 0x0092D464 File Offset: 0x0092B664
		// (set) Token: 0x0601F6A0 RID: 128672 RVA: 0x0092D4A7 File Offset: 0x0092B6A7
		public SimplpNpcStateData WorldState
		{
			get
			{
				base.FastCheckIsValid();
				SimplpNpcStateData result;
				if ((result = this._WorldState) == null)
				{
					result = (this._WorldState = new SimplpNpcStateData(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_WorldState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SimplpNpcStateData.StaticStruct(), base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_WorldState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F6A1 RID: 128673 RVA: 0x0092D4C8 File Offset: 0x0092B6C8
		public SimpleNpcFlowData()
		{
		}

		// Token: 0x0601F6A2 RID: 128674 RVA: 0x0092D4D0 File Offset: 0x0092B6D0
		protected override IntPtr GetUStructPtr()
		{
			return SimpleNpcFlowData.StaticStruct();
		}

		// Token: 0x0601F6A3 RID: 128675 RVA: 0x0092D4DC File Offset: 0x0092B6DC
		[NullableContext(2)]
		public SimpleNpcFlowData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F6A4 RID: 128676 RVA: 0x0092D4E6 File Offset: 0x0092B6E6
		public SimpleNpcFlowData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F6A5 RID: 128677 RVA: 0x0092D4F1 File Offset: 0x0092B6F1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SimpleNpcFlowData(Pointer, false, true);
		}

		// Token: 0x0601F6A6 RID: 128678 RVA: 0x0092D4FB File Offset: 0x0092B6FB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SimpleNpcFlowData(Pointer, MemoryOwner);
		}

		// Token: 0x04010D84 RID: 68996
		public const string __ObjectPath = "/Game/Aki/Data/NPC/SimpleNpcFlow/SimpleNpcFlowData.SimpleNpcFlowData";

		// Token: 0x04010D85 RID: 68997
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D86 RID: 68998
		internal static int __PropertyOffset_Pawn;

		// Token: 0x04010D87 RID: 68999
		internal static int __PropertyOffset_CheckType;

		// Token: 0x04010D88 RID: 69000
		internal static int __PropertyOffset_CheckValue;

		// Token: 0x04010D89 RID: 69001
		internal static int __PropertyOffset_FlowListName;

		// Token: 0x04010D8A RID: 69002
		internal static int __PropertyOffset_FlowSubTitle;

		// Token: 0x04010D8B RID: 69003
		internal static int __PropertyOffset_LoopTime;

		// Token: 0x04010D8C RID: 69004
		internal static int __PropertyOffset_WorldState;

		// Token: 0x04010D8D RID: 69005
		[Nullable(2)]
		private SimplpNpcStateData _WorldState;
	}
}
