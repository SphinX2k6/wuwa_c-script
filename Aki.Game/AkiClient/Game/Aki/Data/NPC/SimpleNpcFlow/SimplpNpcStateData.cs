using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow
{
	// Token: 0x020031B3 RID: 12723
	[UnrealObjectPath("/Game/Aki/Data/NPC/SimpleNpcFlow/SimplpNpcStateData.SimplpNpcStateData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SimplpNpcStateData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F6A7 RID: 128679 RVA: 0x0092D504 File Offset: 0x0092B704
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SimplpNpcStateData._ScriptStructPtr != 0) ? SimplpNpcStateData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/NPC/SimpleNpcFlow/SimplpNpcStateData.SimplpNpcStateData", ref SimplpNpcStateData._ScriptStructPtr);
		}

		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x0601F6A8 RID: 128680 RVA: 0x0092D528 File Offset: 0x0092B728
		// (set) Token: 0x0601F6A9 RID: 128681 RVA: 0x0092D538 File Offset: 0x0092B738
		public unsafe bool MeetAllConditions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SimplpNpcStateData.__PropertyOffset_MeetAllConditions) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SimplpNpcStateData.__PropertyOffset_MeetAllConditions) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x0601F6AA RID: 128682 RVA: 0x0092D54C File Offset: 0x0092B74C
		// (set) Token: 0x0601F6AB RID: 128683 RVA: 0x0092D58F File Offset: 0x0092B78F
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<ESimpleNpcWorldState>, int> WorldStateMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ESimpleNpcWorldState>, int> result;
				if ((result = this._WorldStateMap) == null)
				{
					result = (this._WorldStateMap = new TMap<TEnumAsByte<ESimpleNpcWorldState>, int>(base.NativePtr + (IntPtr)SimplpNpcStateData.__PropertyOffset_WorldStateMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.WorldStateMap.CopyAssign(value);
			}
		}

		// Token: 0x0601F6AC RID: 128684 RVA: 0x0092D59D File Offset: 0x0092B79D
		public SimplpNpcStateData()
		{
		}

		// Token: 0x0601F6AD RID: 128685 RVA: 0x0092D5A5 File Offset: 0x0092B7A5
		protected override IntPtr GetUStructPtr()
		{
			return SimplpNpcStateData.StaticStruct();
		}

		// Token: 0x0601F6AE RID: 128686 RVA: 0x0092D5B1 File Offset: 0x0092B7B1
		[NullableContext(2)]
		public SimplpNpcStateData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F6AF RID: 128687 RVA: 0x0092D5BB File Offset: 0x0092B7BB
		public SimplpNpcStateData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F6B0 RID: 128688 RVA: 0x0092D5C6 File Offset: 0x0092B7C6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SimplpNpcStateData(Pointer, false, true);
		}

		// Token: 0x0601F6B1 RID: 128689 RVA: 0x0092D5D0 File Offset: 0x0092B7D0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SimplpNpcStateData(Pointer, MemoryOwner);
		}

		// Token: 0x04010D8E RID: 69006
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/NPC/SimpleNpcFlow/SimplpNpcStateData.SimplpNpcStateData";

		// Token: 0x04010D8F RID: 69007
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D90 RID: 69008
		internal static int __PropertyOffset_MeetAllConditions;

		// Token: 0x04010D91 RID: 69009
		internal static int __PropertyOffset_WorldStateMap;

		// Token: 0x04010D92 RID: 69010
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<ESimpleNpcWorldState>, int> _WorldStateMap;
	}
}
