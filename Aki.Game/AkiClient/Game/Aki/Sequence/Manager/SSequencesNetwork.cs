using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003A31 RID: 14897
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/SSequencesNetwork.SSequencesNetwork")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class SSequencesNetwork : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F5E0 RID: 128480 RVA: 0x008B6952 File Offset: 0x008B4B52
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSequencesNetwork._ScriptStructPtr != 0) ? SSequencesNetwork._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Sequence/Manager/SSequencesNetwork.SSequencesNetwork", ref SSequencesNetwork._ScriptStructPtr);
		}

		// Token: 0x17002B04 RID: 11012
		// (get) Token: 0x0601F5E1 RID: 128481 RVA: 0x008B6978 File Offset: 0x008B4B78
		// (set) Token: 0x0601F5E2 RID: 128482 RVA: 0x008B69BB File Offset: 0x008B4BBB
		public SSequencesNetwrokNode StartSequence
		{
			get
			{
				base.FastCheckIsValid();
				SSequencesNetwrokNode result;
				if ((result = this._StartSequence) == null)
				{
					result = (this._StartSequence = new SSequencesNetwrokNode(base.NativePtr + (IntPtr)SSequencesNetwork.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSequencesNetwrokNode.StaticStruct(), base.NativePtr + (IntPtr)SSequencesNetwork.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x0601F5E3 RID: 128483 RVA: 0x008B69DC File Offset: 0x008B4BDC
		// (set) Token: 0x0601F5E4 RID: 128484 RVA: 0x008B6A1F File Offset: 0x008B4C1F
		public TArray<SSequencesNetwrokNode> ProcessSequences
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSequencesNetwrokNode> result;
				if ((result = this._ProcessSequences) == null)
				{
					result = (this._ProcessSequences = new TArray<SSequencesNetwrokNode>(base.NativePtr + (IntPtr)SSequencesNetwork.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ProcessSequences.CopyAssign(value);
			}
		}

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x0601F5E5 RID: 128485 RVA: 0x008B6A30 File Offset: 0x008B4C30
		// (set) Token: 0x0601F5E6 RID: 128486 RVA: 0x008B6A73 File Offset: 0x008B4C73
		public TArray<SSequencesNetwrokNode> EndSequences
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSequencesNetwrokNode> result;
				if ((result = this._EndSequences) == null)
				{
					result = (this._EndSequences = new TArray<SSequencesNetwrokNode>(base.NativePtr + (IntPtr)SSequencesNetwork.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EndSequences.CopyAssign(value);
			}
		}

		// Token: 0x0601F5E7 RID: 128487 RVA: 0x008B6A81 File Offset: 0x008B4C81
		public SSequencesNetwork()
		{
		}

		// Token: 0x0601F5E8 RID: 128488 RVA: 0x008B6A89 File Offset: 0x008B4C89
		public SSequencesNetwork(SSequencesNetwrokNode StartSequence, TArray<SSequencesNetwrokNode> ProcessSequences, TArray<SSequencesNetwrokNode> EndSequences)
		{
			this.StartSequence = StartSequence;
			this.ProcessSequences = ProcessSequences;
			this.EndSequences = EndSequences;
		}

		// Token: 0x0601F5E9 RID: 128489 RVA: 0x008B6AA6 File Offset: 0x008B4CA6
		protected override IntPtr GetUStructPtr()
		{
			return SSequencesNetwork.StaticStruct();
		}

		// Token: 0x0601F5EA RID: 128490 RVA: 0x008B6AB2 File Offset: 0x008B4CB2
		[NullableContext(2)]
		public SSequencesNetwork(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F5EB RID: 128491 RVA: 0x008B6ABC File Offset: 0x008B4CBC
		public SSequencesNetwork(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F5EC RID: 128492 RVA: 0x008B6AC7 File Offset: 0x008B4CC7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSequencesNetwork(Pointer, false, true);
		}

		// Token: 0x0601F5ED RID: 128493 RVA: 0x008B6AD1 File Offset: 0x008B4CD1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSequencesNetwork(Pointer, MemoryOwner);
		}

		// Token: 0x0400F0FB RID: 61691
		public const string __ObjectPath = "/Game/Aki/Sequence/Manager/SSequencesNetwork.SSequencesNetwork";

		// Token: 0x0400F0FC RID: 61692
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F0FD RID: 61693
		internal static int __PropertyOffset_0;

		// Token: 0x0400F0FE RID: 61694
		[Nullable(2)]
		private SSequencesNetwrokNode _StartSequence;

		// Token: 0x0400F0FF RID: 61695
		internal static int __PropertyOffset_1;

		// Token: 0x0400F100 RID: 61696
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSequencesNetwrokNode> _ProcessSequences;

		// Token: 0x0400F101 RID: 61697
		internal static int __PropertyOffset_2;

		// Token: 0x0400F102 RID: 61698
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSequencesNetwrokNode> _EndSequences;
	}
}
