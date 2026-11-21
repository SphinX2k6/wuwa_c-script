using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003197 RID: 12695
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SBattleQte.SBattleQte")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SBattleQte : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F4A1 RID: 128161 RVA: 0x0092A741 File Offset: 0x00928941
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBattleQte._ScriptStructPtr != 0) ? SBattleQte._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SBattleQte.SBattleQte", ref SBattleQte._ScriptStructPtr);
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x0601F4A2 RID: 128162 RVA: 0x0092A765 File Offset: 0x00928965
		// (set) Token: 0x0601F4A3 RID: 128163 RVA: 0x0092A775 File Offset: 0x00928975
		public unsafe int QteId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBattleQte.__PropertyOffset_QteId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBattleQte.__PropertyOffset_QteId) = value;
			}
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x0601F4A4 RID: 128164 RVA: 0x0092A786 File Offset: 0x00928986
		// (set) Token: 0x0601F4A5 RID: 128165 RVA: 0x0092A79A File Offset: 0x0092899A
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBattleQte.__PropertyOffset_Desc)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBattleQte.__PropertyOffset_Desc)), value);
			}
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x0601F4A6 RID: 128166 RVA: 0x0092A7B0 File Offset: 0x009289B0
		// (set) Token: 0x0601F4A7 RID: 128167 RVA: 0x0092A7F3 File Offset: 0x009289F3
		public TArray<SBattleQteAction> SuccessActions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SBattleQteAction> result;
				if ((result = this._SuccessActions) == null)
				{
					result = (this._SuccessActions = new TArray<SBattleQteAction>(base.NativePtr + (IntPtr)SBattleQte.__PropertyOffset_SuccessActions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SuccessActions.CopyAssign(value);
			}
		}

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x0601F4A8 RID: 128168 RVA: 0x0092A804 File Offset: 0x00928A04
		// (set) Token: 0x0601F4A9 RID: 128169 RVA: 0x0092A847 File Offset: 0x00928A47
		public TArray<SBattleQteAction> FailActions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SBattleQteAction> result;
				if ((result = this._FailActions) == null)
				{
					result = (this._FailActions = new TArray<SBattleQteAction>(base.NativePtr + (IntPtr)SBattleQte.__PropertyOffset_FailActions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FailActions.CopyAssign(value);
			}
		}

		// Token: 0x0601F4AA RID: 128170 RVA: 0x0092A855 File Offset: 0x00928A55
		public SBattleQte()
		{
		}

		// Token: 0x0601F4AB RID: 128171 RVA: 0x0092A85D File Offset: 0x00928A5D
		protected override IntPtr GetUStructPtr()
		{
			return SBattleQte.StaticStruct();
		}

		// Token: 0x0601F4AC RID: 128172 RVA: 0x0092A869 File Offset: 0x00928A69
		[NullableContext(2)]
		public SBattleQte(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4AD RID: 128173 RVA: 0x0092A873 File Offset: 0x00928A73
		public SBattleQte(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4AE RID: 128174 RVA: 0x0092A87E File Offset: 0x00928A7E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBattleQte(Pointer, false, true);
		}

		// Token: 0x0601F4AF RID: 128175 RVA: 0x0092A888 File Offset: 0x00928A88
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBattleQte(Pointer, MemoryOwner);
		}

		// Token: 0x04010C5B RID: 68699
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SBattleQte.SBattleQte";

		// Token: 0x04010C5C RID: 68700
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010C5D RID: 68701
		internal static int __PropertyOffset_QteId;

		// Token: 0x04010C5E RID: 68702
		internal static int __PropertyOffset_Desc;

		// Token: 0x04010C5F RID: 68703
		internal static int __PropertyOffset_SuccessActions;

		// Token: 0x04010C60 RID: 68704
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SBattleQteAction> _SuccessActions;

		// Token: 0x04010C61 RID: 68705
		internal static int __PropertyOffset_FailActions;

		// Token: 0x04010C62 RID: 68706
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SBattleQteAction> _FailActions;
	}
}
