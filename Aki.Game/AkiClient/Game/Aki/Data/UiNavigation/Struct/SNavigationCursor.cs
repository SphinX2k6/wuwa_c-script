using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiNavigation.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiNavigation.Struct
{
	// Token: 0x0200315E RID: 12638
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/UiNavigation/Struct/SNavigationCursor.SNavigationCursor")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 9)]
	public class SNavigationCursor : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F1F9 RID: 127481 RVA: 0x00927071 File Offset: 0x00925271
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNavigationCursor._ScriptStructPtr != 0) ? SNavigationCursor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiNavigation/Struct/SNavigationCursor.SNavigationCursor", ref SNavigationCursor._ScriptStructPtr);
		}

		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x0601F1FA RID: 127482 RVA: 0x00927095 File Offset: 0x00925295
		// (set) Token: 0x0601F1FB RID: 127483 RVA: 0x009270A9 File Offset: 0x009252A9
		public unsafe TEnumAsByte<ECursorOffsetType> OffsetType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationCursor.__PropertyOffset_OffsetType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationCursor.__PropertyOffset_OffsetType) = value;
			}
		}

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x0601F1FC RID: 127484 RVA: 0x009270BE File Offset: 0x009252BE
		// (set) Token: 0x0601F1FD RID: 127485 RVA: 0x009270CE File Offset: 0x009252CE
		public unsafe int BoundOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationCursor.__PropertyOffset_BoundOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationCursor.__PropertyOffset_BoundOffset) = value;
			}
		}

		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x0601F1FE RID: 127486 RVA: 0x009270DF File Offset: 0x009252DF
		// (set) Token: 0x0601F1FF RID: 127487 RVA: 0x009270EF File Offset: 0x009252EF
		public unsafe bool Switch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNavigationCursor.__PropertyOffset_Switch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNavigationCursor.__PropertyOffset_Switch) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F200 RID: 127488 RVA: 0x00927100 File Offset: 0x00925300
		public SNavigationCursor()
		{
		}

		// Token: 0x0601F201 RID: 127489 RVA: 0x00927108 File Offset: 0x00925308
		protected override IntPtr GetUStructPtr()
		{
			return SNavigationCursor.StaticStruct();
		}

		// Token: 0x0601F202 RID: 127490 RVA: 0x00927114 File Offset: 0x00925314
		[NullableContext(2)]
		public SNavigationCursor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F203 RID: 127491 RVA: 0x0092711E File Offset: 0x0092531E
		public SNavigationCursor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F204 RID: 127492 RVA: 0x00927129 File Offset: 0x00925329
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNavigationCursor(Pointer, false, true);
		}

		// Token: 0x0601F205 RID: 127493 RVA: 0x00927133 File Offset: 0x00925333
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNavigationCursor(Pointer, MemoryOwner);
		}

		// Token: 0x04010A2A RID: 68138
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/UiNavigation/Struct/SNavigationCursor.SNavigationCursor";

		// Token: 0x04010A2B RID: 68139
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A2C RID: 68140
		internal static int __PropertyOffset_OffsetType;

		// Token: 0x04010A2D RID: 68141
		internal static int __PropertyOffset_BoundOffset;

		// Token: 0x04010A2E RID: 68142
		internal static int __PropertyOffset_Switch;
	}
}
