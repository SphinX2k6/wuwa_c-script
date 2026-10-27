using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ED2 RID: 16082
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SBattleQte.SBattleQte")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SBattleQte : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028A6C RID: 166508 RVA: 0x009B1520 File Offset: 0x009AF720
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBattleQte._ScriptStructPtr != 0) ? SBattleQte._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SBattleQte.SBattleQte", ref SBattleQte._ScriptStructPtr);
		}

		// Token: 0x17005EEB RID: 24299
		// (get) Token: 0x06028A6D RID: 166509 RVA: 0x009B1544 File Offset: 0x009AF744
		// (set) Token: 0x06028A6E RID: 166510 RVA: 0x009B1554 File Offset: 0x009AF754
		public unsafe int QteId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBattleQte.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBattleQte.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005EEC RID: 24300
		// (get) Token: 0x06028A6F RID: 166511 RVA: 0x009B1565 File Offset: 0x009AF765
		// (set) Token: 0x06028A70 RID: 166512 RVA: 0x009B1579 File Offset: 0x009AF779
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBattleQte.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBattleQte.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17005EED RID: 24301
		// (get) Token: 0x06028A71 RID: 166513 RVA: 0x009B1590 File Offset: 0x009AF790
		// (set) Token: 0x06028A72 RID: 166514 RVA: 0x009B15D3 File Offset: 0x009AF7D3
		public TArray<SBattleQteAction> SuccessActions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SBattleQteAction> result;
				if ((result = this._SuccessActions) == null)
				{
					result = (this._SuccessActions = new TArray<SBattleQteAction>(base.NativePtr + (IntPtr)SBattleQte.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SuccessActions.CopyAssign(value);
			}
		}

		// Token: 0x17005EEE RID: 24302
		// (get) Token: 0x06028A73 RID: 166515 RVA: 0x009B15E4 File Offset: 0x009AF7E4
		// (set) Token: 0x06028A74 RID: 166516 RVA: 0x009B1627 File Offset: 0x009AF827
		public TArray<SBattleQteAction> FailActions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SBattleQteAction> result;
				if ((result = this._FailActions) == null)
				{
					result = (this._FailActions = new TArray<SBattleQteAction>(base.NativePtr + (IntPtr)SBattleQte.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FailActions.CopyAssign(value);
			}
		}

		// Token: 0x06028A75 RID: 166517 RVA: 0x009B1635 File Offset: 0x009AF835
		public SBattleQte()
		{
		}

		// Token: 0x06028A76 RID: 166518 RVA: 0x009B163D File Offset: 0x009AF83D
		public SBattleQte(int QteId, string Desc, TArray<SBattleQteAction> SuccessActions, TArray<SBattleQteAction> FailActions)
		{
			this.QteId = QteId;
			this.Desc = Desc;
			this.SuccessActions = SuccessActions;
			this.FailActions = FailActions;
		}

		// Token: 0x06028A77 RID: 166519 RVA: 0x009B1662 File Offset: 0x009AF862
		protected override IntPtr GetUStructPtr()
		{
			return SBattleQte.StaticStruct();
		}

		// Token: 0x06028A78 RID: 166520 RVA: 0x009B166E File Offset: 0x009AF86E
		[NullableContext(2)]
		public SBattleQte(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028A79 RID: 166521 RVA: 0x009B1678 File Offset: 0x009AF878
		public SBattleQte(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028A7A RID: 166522 RVA: 0x009B1683 File Offset: 0x009AF883
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBattleQte(Pointer, false, true);
		}

		// Token: 0x06028A7B RID: 166523 RVA: 0x009B168D File Offset: 0x009AF88D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBattleQte(Pointer, MemoryOwner);
		}

		// Token: 0x04014C74 RID: 85108
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SBattleQte.SBattleQte";

		// Token: 0x04014C75 RID: 85109
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014C76 RID: 85110
		internal static int __PropertyOffset_0;

		// Token: 0x04014C77 RID: 85111
		internal static int __PropertyOffset_1;

		// Token: 0x04014C78 RID: 85112
		internal static int __PropertyOffset_2;

		// Token: 0x04014C79 RID: 85113
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SBattleQteAction> _SuccessActions;

		// Token: 0x04014C7A RID: 85114
		internal static int __PropertyOffset_3;

		// Token: 0x04014C7B RID: 85115
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SBattleQteAction> _FailActions;
	}
}
