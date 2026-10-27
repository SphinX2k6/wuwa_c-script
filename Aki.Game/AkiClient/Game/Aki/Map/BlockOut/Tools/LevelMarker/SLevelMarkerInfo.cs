using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Map.BlockOut.Tools.LevelMarker
{
	// Token: 0x02003E4E RID: 15950
	[UnrealObjectPath("/Game/Aki/Map/BlockOut/Tools/LevelMarker/SLevelMarkerInfo.SLevelMarkerInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SLevelMarkerInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028186 RID: 164230 RVA: 0x009A3DCE File Offset: 0x009A1FCE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLevelMarkerInfo._ScriptStructPtr != 0) ? SLevelMarkerInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Map/BlockOut/Tools/LevelMarker/SLevelMarkerInfo.SLevelMarkerInfo", ref SLevelMarkerInfo._ScriptStructPtr);
		}

		// Token: 0x17005BBB RID: 23483
		// (get) Token: 0x06028187 RID: 164231 RVA: 0x009A3DF2 File Offset: 0x009A1FF2
		// (set) Token: 0x06028188 RID: 164232 RVA: 0x009A3E06 File Offset: 0x009A2006
		public unsafe TEnumAsByte<ELevelMarkerType> MarkInfoType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLevelMarkerInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLevelMarkerInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005BBC RID: 23484
		// (get) Token: 0x06028189 RID: 164233 RVA: 0x009A3E1C File Offset: 0x009A201C
		// (set) Token: 0x0602818A RID: 164234 RVA: 0x009A3E5F File Offset: 0x009A205F
		[Nullable(1)]
		public unsafe FText MarkInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._MarkInfo) == null)
				{
					result = (this._MarkInfo = new FText(base.NativePtr + (IntPtr)SLevelMarkerInfo.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)SLevelMarkerInfo.__PropertyOffset_1)), value.NativePtr, 1);
			}
		}

		// Token: 0x0602818B RID: 164235 RVA: 0x009A3E7A File Offset: 0x009A207A
		public SLevelMarkerInfo()
		{
		}

		// Token: 0x0602818C RID: 164236 RVA: 0x009A3E82 File Offset: 0x009A2082
		public SLevelMarkerInfo(TEnumAsByte<ELevelMarkerType> MarkInfoType, [Nullable(1)] FText MarkInfo)
		{
			this.MarkInfoType = MarkInfoType;
			this.MarkInfo = MarkInfo;
		}

		// Token: 0x0602818D RID: 164237 RVA: 0x009A3E98 File Offset: 0x009A2098
		protected override IntPtr GetUStructPtr()
		{
			return SLevelMarkerInfo.StaticStruct();
		}

		// Token: 0x0602818E RID: 164238 RVA: 0x009A3EA4 File Offset: 0x009A20A4
		[NullableContext(2)]
		public SLevelMarkerInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602818F RID: 164239 RVA: 0x009A3EAE File Offset: 0x009A20AE
		public SLevelMarkerInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028190 RID: 164240 RVA: 0x009A3EB9 File Offset: 0x009A20B9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SLevelMarkerInfo(Pointer, false, true);
		}

		// Token: 0x06028191 RID: 164241 RVA: 0x009A3EC3 File Offset: 0x009A20C3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SLevelMarkerInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014663 RID: 83555
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Map/BlockOut/Tools/LevelMarker/SLevelMarkerInfo.SLevelMarkerInfo";

		// Token: 0x04014664 RID: 83556
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014665 RID: 83557
		internal static int __PropertyOffset_0;

		// Token: 0x04014666 RID: 83558
		internal static int __PropertyOffset_1;

		// Token: 0x04014667 RID: 83559
		[Nullable(2)]
		private FText _MarkInfo;
	}
}
