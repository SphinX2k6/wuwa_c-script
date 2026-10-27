using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.HLOD
{
	// Token: 0x02003C9E RID: 15518
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/HLOD/SPCG_HLODNormalmapPatternInfo.SPCG_HLODNormalmapPatternInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SPCG_HLODNormalmapPatternInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602464C RID: 149068 RVA: 0x0093D5C0 File Offset: 0x0093B7C0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPCG_HLODNormalmapPatternInfo._ScriptStructPtr != 0) ? SPCG_HLODNormalmapPatternInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/HLOD/SPCG_HLODNormalmapPatternInfo.SPCG_HLODNormalmapPatternInfo", ref SPCG_HLODNormalmapPatternInfo._ScriptStructPtr);
		}

		// Token: 0x170046D0 RID: 18128
		// (get) Token: 0x0602464D RID: 149069 RVA: 0x0093D5E4 File Offset: 0x0093B7E4
		// (set) Token: 0x0602464E RID: 149070 RVA: 0x0093D5F8 File Offset: 0x0093B7F8
		public unsafe string pattern_info
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPCG_HLODNormalmapPatternInfo.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPCG_HLODNormalmapPatternInfo.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x0602464F RID: 149071 RVA: 0x0093D60D File Offset: 0x0093B80D
		public SPCG_HLODNormalmapPatternInfo()
		{
		}

		// Token: 0x06024650 RID: 149072 RVA: 0x0093D615 File Offset: 0x0093B815
		public SPCG_HLODNormalmapPatternInfo(string pattern_info)
		{
			this.pattern_info = pattern_info;
		}

		// Token: 0x06024651 RID: 149073 RVA: 0x0093D624 File Offset: 0x0093B824
		protected override IntPtr GetUStructPtr()
		{
			return SPCG_HLODNormalmapPatternInfo.StaticStruct();
		}

		// Token: 0x06024652 RID: 149074 RVA: 0x0093D630 File Offset: 0x0093B830
		[NullableContext(2)]
		public SPCG_HLODNormalmapPatternInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024653 RID: 149075 RVA: 0x0093D63A File Offset: 0x0093B83A
		public SPCG_HLODNormalmapPatternInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024654 RID: 149076 RVA: 0x0093D645 File Offset: 0x0093B845
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPCG_HLODNormalmapPatternInfo(Pointer, false, true);
		}

		// Token: 0x06024655 RID: 149077 RVA: 0x0093D64F File Offset: 0x0093B84F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPCG_HLODNormalmapPatternInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040120E3 RID: 73955
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/HLOD/SPCG_HLODNormalmapPatternInfo.SPCG_HLODNormalmapPatternInfo";

		// Token: 0x040120E4 RID: 73956
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040120E5 RID: 73957
		internal static int __PropertyOffset_0;
	}
}
