using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.PathLine.FogLine
{
	// Token: 0x020031AC RID: 12716
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/FogLine/S_FogToAreaIDs.S_FogToAreaIDs")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 18)]
	public class S_FogToAreaIDs : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F660 RID: 128608 RVA: 0x0092CEE2 File Offset: 0x0092B0E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_FogToAreaIDs._ScriptStructPtr != 0) ? S_FogToAreaIDs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/PathLine/FogLine/S_FogToAreaIDs.S_FogToAreaIDs", ref S_FogToAreaIDs._ScriptStructPtr);
		}

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x0601F661 RID: 128609 RVA: 0x0092CF08 File Offset: 0x0092B108
		// (set) Token: 0x0601F662 RID: 128610 RVA: 0x0092CF4B File Offset: 0x0092B14B
		public TArray<int> AreaFogIDs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._AreaFogIDs) == null)
				{
					result = (this._AreaFogIDs = new TArray<int>(base.NativePtr + (IntPtr)S_FogToAreaIDs.__PropertyOffset_AreaFogIDs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AreaFogIDs.CopyAssign(value);
			}
		}

		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x0601F663 RID: 128611 RVA: 0x0092CF59 File Offset: 0x0092B159
		// (set) Token: 0x0601F664 RID: 128612 RVA: 0x0092CF69 File Offset: 0x0092B169
		public unsafe bool IsFogP1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_FogToAreaIDs.__PropertyOffset_IsFogP1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_FogToAreaIDs.__PropertyOffset_IsFogP1) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x0601F665 RID: 128613 RVA: 0x0092CF7A File Offset: 0x0092B17A
		// (set) Token: 0x0601F666 RID: 128614 RVA: 0x0092CF8A File Offset: 0x0092B18A
		public unsafe bool IsFogP2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_FogToAreaIDs.__PropertyOffset_IsFogP2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_FogToAreaIDs.__PropertyOffset_IsFogP2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F667 RID: 128615 RVA: 0x0092CF9B File Offset: 0x0092B19B
		public S_FogToAreaIDs()
		{
		}

		// Token: 0x0601F668 RID: 128616 RVA: 0x0092CFA3 File Offset: 0x0092B1A3
		protected override IntPtr GetUStructPtr()
		{
			return S_FogToAreaIDs.StaticStruct();
		}

		// Token: 0x0601F669 RID: 128617 RVA: 0x0092CFAF File Offset: 0x0092B1AF
		[NullableContext(2)]
		public S_FogToAreaIDs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F66A RID: 128618 RVA: 0x0092CFB9 File Offset: 0x0092B1B9
		public S_FogToAreaIDs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F66B RID: 128619 RVA: 0x0092CFC4 File Offset: 0x0092B1C4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_FogToAreaIDs(Pointer, false, true);
		}

		// Token: 0x0601F66C RID: 128620 RVA: 0x0092CFCE File Offset: 0x0092B1CE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_FogToAreaIDs(Pointer, MemoryOwner);
		}

		// Token: 0x04010D4C RID: 68940
		public const string __ObjectPath = "/Game/Aki/Data/PathLine/FogLine/S_FogToAreaIDs.S_FogToAreaIDs";

		// Token: 0x04010D4D RID: 68941
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D4E RID: 68942
		internal static int __PropertyOffset_AreaFogIDs;

		// Token: 0x04010D4F RID: 68943
		[Nullable(2)]
		private TArray<int> _AreaFogIDs;

		// Token: 0x04010D50 RID: 68944
		internal static int __PropertyOffset_IsFogP1;

		// Token: 0x04010D51 RID: 68945
		internal static int __PropertyOffset_IsFogP2;
	}
}
