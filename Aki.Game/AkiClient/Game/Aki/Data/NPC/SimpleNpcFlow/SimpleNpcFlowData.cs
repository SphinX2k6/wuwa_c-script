using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow
{
	// Token: 0x02003EF1 RID: 16113
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/NPC/SimpleNpcFlow/SimpleNpcFlowData.SimpleNpcFlowData")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class SimpleNpcFlowData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028CC0 RID: 167104 RVA: 0x009B4E21 File Offset: 0x009B3021
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SimpleNpcFlowData._ScriptStructPtr != 0) ? SimpleNpcFlowData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/NPC/SimpleNpcFlow/SimpleNpcFlowData.SimpleNpcFlowData", ref SimpleNpcFlowData._ScriptStructPtr);
		}

		// Token: 0x17005FA6 RID: 24486
		// (get) Token: 0x06028CC1 RID: 167105 RVA: 0x009B4E45 File Offset: 0x009B3045
		// (set) Token: 0x06028CC2 RID: 167106 RVA: 0x009B4E59 File Offset: 0x009B3059
		[Nullable(0)]
		public unsafe TEnumAsByte<ESimpleNpcFlowIndex> Pawn
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005FA7 RID: 24487
		// (get) Token: 0x06028CC3 RID: 167107 RVA: 0x009B4E6E File Offset: 0x009B306E
		// (set) Token: 0x06028CC4 RID: 167108 RVA: 0x009B4E82 File Offset: 0x009B3082
		[Nullable(0)]
		public unsafe TEnumAsByte<ESimpleNpcFlowCheckType> CheckType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_1);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005FA8 RID: 24488
		// (get) Token: 0x06028CC5 RID: 167109 RVA: 0x009B4E97 File Offset: 0x009B3097
		// (set) Token: 0x06028CC6 RID: 167110 RVA: 0x009B4EA7 File Offset: 0x009B30A7
		public unsafe int CheckValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005FA9 RID: 24489
		// (get) Token: 0x06028CC7 RID: 167111 RVA: 0x009B4EB8 File Offset: 0x009B30B8
		// (set) Token: 0x06028CC8 RID: 167112 RVA: 0x009B4ECC File Offset: 0x009B30CC
		public unsafe string FlowListName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SimpleNpcFlowData.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SimpleNpcFlowData.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17005FAA RID: 24490
		// (get) Token: 0x06028CC9 RID: 167113 RVA: 0x009B4EE1 File Offset: 0x009B30E1
		// (set) Token: 0x06028CCA RID: 167114 RVA: 0x009B4EF5 File Offset: 0x009B30F5
		public unsafe string FlowSubTitle
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SimpleNpcFlowData.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SimpleNpcFlowData.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x17005FAB RID: 24491
		// (get) Token: 0x06028CCB RID: 167115 RVA: 0x009B4F0A File Offset: 0x009B310A
		// (set) Token: 0x06028CCC RID: 167116 RVA: 0x009B4F1A File Offset: 0x009B311A
		public unsafe float LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005FAC RID: 24492
		// (get) Token: 0x06028CCD RID: 167117 RVA: 0x009B4F2C File Offset: 0x009B312C
		// (set) Token: 0x06028CCE RID: 167118 RVA: 0x009B4F6F File Offset: 0x009B316F
		public SimplpNpcStateData WorldState
		{
			get
			{
				base.FastCheckIsValid();
				SimplpNpcStateData result;
				if ((result = this._WorldState) == null)
				{
					result = (this._WorldState = new SimplpNpcStateData(base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SimplpNpcStateData.StaticStruct(), base.NativePtr + (IntPtr)SimpleNpcFlowData.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06028CCF RID: 167119 RVA: 0x009B4F90 File Offset: 0x009B3190
		public SimpleNpcFlowData()
		{
		}

		// Token: 0x06028CD0 RID: 167120 RVA: 0x009B4F98 File Offset: 0x009B3198
		public SimpleNpcFlowData([Nullable(0)] TEnumAsByte<ESimpleNpcFlowIndex> Pawn, [Nullable(0)] TEnumAsByte<ESimpleNpcFlowCheckType> CheckType, int CheckValue, string FlowListName, string FlowSubTitle, float LoopTime, SimplpNpcStateData WorldState)
		{
			this.Pawn = Pawn;
			this.CheckType = CheckType;
			this.CheckValue = CheckValue;
			this.FlowListName = FlowListName;
			this.FlowSubTitle = FlowSubTitle;
			this.LoopTime = LoopTime;
			this.WorldState = WorldState;
		}

		// Token: 0x06028CD1 RID: 167121 RVA: 0x009B4FD5 File Offset: 0x009B31D5
		protected override IntPtr GetUStructPtr()
		{
			return SimpleNpcFlowData.StaticStruct();
		}

		// Token: 0x06028CD2 RID: 167122 RVA: 0x009B4FE1 File Offset: 0x009B31E1
		[NullableContext(2)]
		public SimpleNpcFlowData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028CD3 RID: 167123 RVA: 0x009B4FEB File Offset: 0x009B31EB
		public SimpleNpcFlowData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028CD4 RID: 167124 RVA: 0x009B4FF6 File Offset: 0x009B31F6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SimpleNpcFlowData(Pointer, false, true);
		}

		// Token: 0x06028CD5 RID: 167125 RVA: 0x009B5000 File Offset: 0x009B3200
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SimpleNpcFlowData(Pointer, MemoryOwner);
		}

		// Token: 0x04014DCB RID: 85451
		public const string __ObjectPath = "/Game/Aki/Data/NPC/SimpleNpcFlow/SimpleNpcFlowData.SimpleNpcFlowData";

		// Token: 0x04014DCC RID: 85452
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014DCD RID: 85453
		internal static int __PropertyOffset_0;

		// Token: 0x04014DCE RID: 85454
		internal static int __PropertyOffset_1;

		// Token: 0x04014DCF RID: 85455
		internal static int __PropertyOffset_2;

		// Token: 0x04014DD0 RID: 85456
		internal static int __PropertyOffset_3;

		// Token: 0x04014DD1 RID: 85457
		internal static int __PropertyOffset_4;

		// Token: 0x04014DD2 RID: 85458
		internal static int __PropertyOffset_5;

		// Token: 0x04014DD3 RID: 85459
		internal static int __PropertyOffset_6;

		// Token: 0x04014DD4 RID: 85460
		[Nullable(2)]
		private SimplpNpcStateData _WorldState;
	}
}
