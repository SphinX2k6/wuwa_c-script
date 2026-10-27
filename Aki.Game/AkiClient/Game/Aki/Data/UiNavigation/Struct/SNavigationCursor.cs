using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiNavigation.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiNavigation.Struct
{
	// Token: 0x02003E87 RID: 16007
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/UiNavigation/Struct/SNavigationCursor.SNavigationCursor")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 9)]
	public class SNavigationCursor : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028691 RID: 165521 RVA: 0x009ABFA1 File Offset: 0x009AA1A1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNavigationCursor._ScriptStructPtr != 0) ? SNavigationCursor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiNavigation/Struct/SNavigationCursor.SNavigationCursor", ref SNavigationCursor._ScriptStructPtr);
		}

		// Token: 0x17005D99 RID: 23961
		// (get) Token: 0x06028692 RID: 165522 RVA: 0x009ABFC5 File Offset: 0x009AA1C5
		// (set) Token: 0x06028693 RID: 165523 RVA: 0x009ABFD9 File Offset: 0x009AA1D9
		public unsafe TEnumAsByte<ECursorOffsetType> OffsetType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationCursor.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationCursor.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005D9A RID: 23962
		// (get) Token: 0x06028694 RID: 165524 RVA: 0x009ABFEE File Offset: 0x009AA1EE
		// (set) Token: 0x06028695 RID: 165525 RVA: 0x009ABFFE File Offset: 0x009AA1FE
		public unsafe int BoundOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationCursor.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationCursor.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005D9B RID: 23963
		// (get) Token: 0x06028696 RID: 165526 RVA: 0x009AC00F File Offset: 0x009AA20F
		// (set) Token: 0x06028697 RID: 165527 RVA: 0x009AC01F File Offset: 0x009AA21F
		public unsafe bool Switch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationCursor.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationCursor.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028698 RID: 165528 RVA: 0x009AC030 File Offset: 0x009AA230
		public SNavigationCursor()
		{
		}

		// Token: 0x06028699 RID: 165529 RVA: 0x009AC038 File Offset: 0x009AA238
		public SNavigationCursor(TEnumAsByte<ECursorOffsetType> OffsetType, int BoundOffset, bool Switch)
		{
			this.OffsetType = OffsetType;
			this.BoundOffset = BoundOffset;
			this.Switch = Switch;
		}

		// Token: 0x0602869A RID: 165530 RVA: 0x009AC055 File Offset: 0x009AA255
		protected override IntPtr GetUStructPtr()
		{
			return SNavigationCursor.StaticStruct();
		}

		// Token: 0x0602869B RID: 165531 RVA: 0x009AC061 File Offset: 0x009AA261
		[NullableContext(2)]
		public SNavigationCursor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602869C RID: 165532 RVA: 0x009AC06B File Offset: 0x009AA26B
		public SNavigationCursor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602869D RID: 165533 RVA: 0x009AC076 File Offset: 0x009AA276
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNavigationCursor(Pointer, false, true);
		}

		// Token: 0x0602869E RID: 165534 RVA: 0x009AC080 File Offset: 0x009AA280
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNavigationCursor(Pointer, MemoryOwner);
		}

		// Token: 0x040149A9 RID: 84393
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/UiNavigation/Struct/SNavigationCursor.SNavigationCursor";

		// Token: 0x040149AA RID: 84394
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040149AB RID: 84395
		internal static int __PropertyOffset_0;

		// Token: 0x040149AC RID: 84396
		internal static int __PropertyOffset_1;

		// Token: 0x040149AD RID: 84397
		internal static int __PropertyOffset_2;
	}
}
