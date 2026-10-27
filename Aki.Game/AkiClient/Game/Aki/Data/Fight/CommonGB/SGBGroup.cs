using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.CommonGB
{
	// Token: 0x02003F80 RID: 16256
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/CommonGB/SGBGroup.SGBGroup")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SGBGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060297F6 RID: 169974 RVA: 0x009C59D5 File Offset: 0x009C3BD5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGBGroup._ScriptStructPtr != 0) ? SGBGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/CommonGB/SGBGroup.SGBGroup", ref SGBGroup._ScriptStructPtr);
		}

		// Token: 0x1700639F RID: 25503
		// (get) Token: 0x060297F7 RID: 169975 RVA: 0x009C59FC File Offset: 0x009C3BFC
		// (set) Token: 0x060297F8 RID: 169976 RVA: 0x009C5A3F File Offset: 0x009C3C3F
		public TArray<UKuroBpDataAssetGroup> GBGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroBpDataAssetGroup> result;
				if ((result = this._GBGroup) == null)
				{
					result = (this._GBGroup = new TArray<UKuroBpDataAssetGroup>(base.NativePtr + (IntPtr)SGBGroup.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GBGroup.CopyAssign(value);
			}
		}

		// Token: 0x060297F9 RID: 169977 RVA: 0x009C5A4D File Offset: 0x009C3C4D
		public SGBGroup()
		{
		}

		// Token: 0x060297FA RID: 169978 RVA: 0x009C5A55 File Offset: 0x009C3C55
		public SGBGroup(TArray<UKuroBpDataAssetGroup> GBGroup)
		{
			this.GBGroup = GBGroup;
		}

		// Token: 0x060297FB RID: 169979 RVA: 0x009C5A64 File Offset: 0x009C3C64
		protected override IntPtr GetUStructPtr()
		{
			return SGBGroup.StaticStruct();
		}

		// Token: 0x060297FC RID: 169980 RVA: 0x009C5A70 File Offset: 0x009C3C70
		[NullableContext(2)]
		public SGBGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060297FD RID: 169981 RVA: 0x009C5A7A File Offset: 0x009C3C7A
		public SGBGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060297FE RID: 169982 RVA: 0x009C5A85 File Offset: 0x009C3C85
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGBGroup(Pointer, false, true);
		}

		// Token: 0x060297FF RID: 169983 RVA: 0x009C5A8F File Offset: 0x009C3C8F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGBGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0401545A RID: 87130
		public const string __ObjectPath = "/Game/Aki/Data/Fight/CommonGB/SGBGroup.SGBGroup";

		// Token: 0x0401545B RID: 87131
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401545C RID: 87132
		internal static int __PropertyOffset_0;

		// Token: 0x0401545D RID: 87133
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroBpDataAssetGroup> _GBGroup;
	}
}
