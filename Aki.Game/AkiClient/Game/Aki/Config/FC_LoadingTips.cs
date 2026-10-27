using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Config
{
	// Token: 0x02004025 RID: 16421
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Config/FC_LoadingTips.FC_LoadingTips")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FC_LoadingTips : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602A1E2 RID: 172514 RVA: 0x009D691B File Offset: 0x009D4B1B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FC_LoadingTips._ScriptStructPtr != 0) ? FC_LoadingTips._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Config/FC_LoadingTips.FC_LoadingTips", ref FC_LoadingTips._ScriptStructPtr);
		}

		// Token: 0x170066C6 RID: 26310
		// (get) Token: 0x0602A1E3 RID: 172515 RVA: 0x009D693F File Offset: 0x009D4B3F
		// (set) Token: 0x0602A1E4 RID: 172516 RVA: 0x009D694F File Offset: 0x009D4B4F
		public unsafe int KuroRowId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FC_LoadingTips.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FC_LoadingTips.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170066C7 RID: 26311
		// (get) Token: 0x0602A1E5 RID: 172517 RVA: 0x009D6960 File Offset: 0x009D4B60
		// (set) Token: 0x0602A1E6 RID: 172518 RVA: 0x009D6970 File Offset: 0x009D4B70
		public unsafe int Lv
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FC_LoadingTips.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FC_LoadingTips.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170066C8 RID: 26312
		// (get) Token: 0x0602A1E7 RID: 172519 RVA: 0x009D6984 File Offset: 0x009D4B84
		// (set) Token: 0x0602A1E8 RID: 172520 RVA: 0x009D69C7 File Offset: 0x009D4BC7
		public TArray<int> TipsId
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TipsId) == null)
				{
					result = (this._TipsId = new TArray<int>(base.NativePtr + (IntPtr)FC_LoadingTips.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TipsId.CopyAssign(value);
			}
		}

		// Token: 0x0602A1E9 RID: 172521 RVA: 0x009D69D5 File Offset: 0x009D4BD5
		public FC_LoadingTips()
		{
		}

		// Token: 0x0602A1EA RID: 172522 RVA: 0x009D69DD File Offset: 0x009D4BDD
		public FC_LoadingTips(int KuroRowId, int Lv, TArray<int> TipsId)
		{
			this.KuroRowId = KuroRowId;
			this.Lv = Lv;
			this.TipsId = TipsId;
		}

		// Token: 0x0602A1EB RID: 172523 RVA: 0x009D69FA File Offset: 0x009D4BFA
		protected override IntPtr GetUStructPtr()
		{
			return FC_LoadingTips.StaticStruct();
		}

		// Token: 0x0602A1EC RID: 172524 RVA: 0x009D6A06 File Offset: 0x009D4C06
		[NullableContext(2)]
		public FC_LoadingTips(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A1ED RID: 172525 RVA: 0x009D6A10 File Offset: 0x009D4C10
		public FC_LoadingTips(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A1EE RID: 172526 RVA: 0x009D6A1B File Offset: 0x009D4C1B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FC_LoadingTips(Pointer, false, true);
		}

		// Token: 0x0602A1EF RID: 172527 RVA: 0x009D6A25 File Offset: 0x009D4C25
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FC_LoadingTips(Pointer, MemoryOwner);
		}

		// Token: 0x04015B1C RID: 88860
		public const string __ObjectPath = "/Game/Aki/Config/FC_LoadingTips.FC_LoadingTips";

		// Token: 0x04015B1D RID: 88861
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015B1E RID: 88862
		internal static int __PropertyOffset_0;

		// Token: 0x04015B1F RID: 88863
		internal static int __PropertyOffset_1;

		// Token: 0x04015B20 RID: 88864
		internal static int __PropertyOffset_2;

		// Token: 0x04015B21 RID: 88865
		[Nullable(2)]
		private TArray<int> _TipsId;
	}
}
