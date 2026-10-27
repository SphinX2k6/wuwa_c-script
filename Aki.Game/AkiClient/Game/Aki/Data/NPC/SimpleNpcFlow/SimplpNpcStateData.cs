using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow
{
	// Token: 0x02003EF2 RID: 16114
	[UnrealObjectPath("/Game/Aki/Data/NPC/SimpleNpcFlow/SimplpNpcStateData.SimplpNpcStateData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SimplpNpcStateData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028CD6 RID: 167126 RVA: 0x009B5009 File Offset: 0x009B3209
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SimplpNpcStateData._ScriptStructPtr != 0) ? SimplpNpcStateData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/NPC/SimpleNpcFlow/SimplpNpcStateData.SimplpNpcStateData", ref SimplpNpcStateData._ScriptStructPtr);
		}

		// Token: 0x17005FAD RID: 24493
		// (get) Token: 0x06028CD7 RID: 167127 RVA: 0x009B502D File Offset: 0x009B322D
		// (set) Token: 0x06028CD8 RID: 167128 RVA: 0x009B503D File Offset: 0x009B323D
		public unsafe bool MeetAllConditions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SimplpNpcStateData.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SimplpNpcStateData.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005FAE RID: 24494
		// (get) Token: 0x06028CD9 RID: 167129 RVA: 0x009B5050 File Offset: 0x009B3250
		// (set) Token: 0x06028CDA RID: 167130 RVA: 0x009B5093 File Offset: 0x009B3293
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
					result = (this._WorldStateMap = new TMap<TEnumAsByte<ESimpleNpcWorldState>, int>(base.NativePtr + (IntPtr)SimplpNpcStateData.__PropertyOffset_1, base.MemoryOwner ?? this));
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

		// Token: 0x06028CDB RID: 167131 RVA: 0x009B50A1 File Offset: 0x009B32A1
		public SimplpNpcStateData()
		{
		}

		// Token: 0x06028CDC RID: 167132 RVA: 0x009B50A9 File Offset: 0x009B32A9
		public SimplpNpcStateData(bool MeetAllConditions, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<ESimpleNpcWorldState>, int> WorldStateMap)
		{
			this.MeetAllConditions = MeetAllConditions;
			this.WorldStateMap = WorldStateMap;
		}

		// Token: 0x06028CDD RID: 167133 RVA: 0x009B50BF File Offset: 0x009B32BF
		protected override IntPtr GetUStructPtr()
		{
			return SimplpNpcStateData.StaticStruct();
		}

		// Token: 0x06028CDE RID: 167134 RVA: 0x009B50CB File Offset: 0x009B32CB
		[NullableContext(2)]
		public SimplpNpcStateData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028CDF RID: 167135 RVA: 0x009B50D5 File Offset: 0x009B32D5
		public SimplpNpcStateData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028CE0 RID: 167136 RVA: 0x009B50E0 File Offset: 0x009B32E0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SimplpNpcStateData(Pointer, false, true);
		}

		// Token: 0x06028CE1 RID: 167137 RVA: 0x009B50EA File Offset: 0x009B32EA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SimplpNpcStateData(Pointer, MemoryOwner);
		}

		// Token: 0x04014DD5 RID: 85461
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/NPC/SimpleNpcFlow/SimplpNpcStateData.SimplpNpcStateData";

		// Token: 0x04014DD6 RID: 85462
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014DD7 RID: 85463
		internal static int __PropertyOffset_0;

		// Token: 0x04014DD8 RID: 85464
		internal static int __PropertyOffset_1;

		// Token: 0x04014DD9 RID: 85465
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<ESimpleNpcWorldState>, int> _WorldStateMap;
	}
}
