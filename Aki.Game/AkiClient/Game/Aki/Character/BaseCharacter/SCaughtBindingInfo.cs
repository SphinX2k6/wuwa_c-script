using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200333B RID: 13115
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCaughtBindingInfo.SCaughtBindingInfo")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class SCaughtBindingInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602124F RID: 135759 RVA: 0x0095A355 File Offset: 0x00958555
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCaughtBindingInfo._ScriptStructPtr != 0) ? SCaughtBindingInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCaughtBindingInfo.SCaughtBindingInfo", ref SCaughtBindingInfo._ScriptStructPtr);
		}

		// Token: 0x170042D1 RID: 17105
		// (get) Token: 0x06021250 RID: 135760 RVA: 0x0095A379 File Offset: 0x00958579
		// (set) Token: 0x06021251 RID: 135761 RVA: 0x0095A38D File Offset: 0x0095858D
		public unsafe string BulletId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_BulletId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_BulletId)), value);
			}
		}

		// Token: 0x170042D2 RID: 17106
		// (get) Token: 0x06021252 RID: 135762 RVA: 0x0095A3A2 File Offset: 0x009585A2
		// (set) Token: 0x06021253 RID: 135763 RVA: 0x0095A3B2 File Offset: 0x009585B2
		public unsafe bool DestroyBullet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_DestroyBullet) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_DestroyBullet) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042D3 RID: 17107
		// (get) Token: 0x06021254 RID: 135764 RVA: 0x0095A3C3 File Offset: 0x009585C3
		// (set) Token: 0x06021255 RID: 135765 RVA: 0x0095A3D3 File Offset: 0x009585D3
		public unsafe bool SummonChildBullet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_SummonChildBullet) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_SummonChildBullet) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042D4 RID: 17108
		// (get) Token: 0x06021256 RID: 135766 RVA: 0x0095A3E4 File Offset: 0x009585E4
		// (set) Token: 0x06021257 RID: 135767 RVA: 0x0095A3F8 File Offset: 0x009585F8
		public unsafe string EndBulletId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_EndBulletId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_EndBulletId)), value);
			}
		}

		// Token: 0x170042D5 RID: 17109
		// (get) Token: 0x06021258 RID: 135768 RVA: 0x0095A40D File Offset: 0x0095860D
		// (set) Token: 0x06021259 RID: 135769 RVA: 0x0095A421 File Offset: 0x00958621
		public unsafe string TargetMontagePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_TargetMontagePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_TargetMontagePath)), value);
			}
		}

		// Token: 0x170042D6 RID: 17110
		// (get) Token: 0x0602125A RID: 135770 RVA: 0x0095A436 File Offset: 0x00958636
		// (set) Token: 0x0602125B RID: 135771 RVA: 0x0095A44A File Offset: 0x0095864A
		public unsafe string TargetBoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_TargetBoneName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_TargetBoneName)), value);
			}
		}

		// Token: 0x170042D7 RID: 17111
		// (get) Token: 0x0602125C RID: 135772 RVA: 0x0095A45F File Offset: 0x0095865F
		// (set) Token: 0x0602125D RID: 135773 RVA: 0x0095A473 File Offset: 0x00958673
		[Nullable(0)]
		public unsafe TEnumAsByte<ECaughtDirectionType> CaughtDirectionType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_CaughtDirectionType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_CaughtDirectionType) = value;
			}
		}

		// Token: 0x170042D8 RID: 17112
		// (get) Token: 0x0602125E RID: 135774 RVA: 0x0095A488 File Offset: 0x00958688
		// (set) Token: 0x0602125F RID: 135775 RVA: 0x0095A4CB File Offset: 0x009586CB
		[Nullable(new byte[]
		{
			1,
			0,
			0
		})]
		public TMap<TEnumAsByte<ECollisionChannel>, TEnumAsByte<ECollisionResponse>> CollisionResponseToChannel
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<ECollisionChannel>, TEnumAsByte<ECollisionResponse>> result;
				if ((result = this._CollisionResponseToChannel) == null)
				{
					result = (this._CollisionResponseToChannel = new TMap<TEnumAsByte<ECollisionChannel>, TEnumAsByte<ECollisionResponse>>(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_CollisionResponseToChannel, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				0
			})]
			set
			{
				this.CollisionResponseToChannel.CopyAssign(value);
			}
		}

		// Token: 0x170042D9 RID: 17113
		// (get) Token: 0x06021260 RID: 135776 RVA: 0x0095A4DC File Offset: 0x009586DC
		// (set) Token: 0x06021261 RID: 135777 RVA: 0x0095A51F File Offset: 0x0095871F
		public TArray<long> SourceBuffIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._SourceBuffIds) == null)
				{
					result = (this._SourceBuffIds = new TArray<long>(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_SourceBuffIds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SourceBuffIds.CopyAssign(value);
			}
		}

		// Token: 0x170042DA RID: 17114
		// (get) Token: 0x06021262 RID: 135778 RVA: 0x0095A530 File Offset: 0x00958730
		// (set) Token: 0x06021263 RID: 135779 RVA: 0x0095A573 File Offset: 0x00958773
		public TArray<long> TargetBuffIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._TargetBuffIds) == null)
				{
					result = (this._TargetBuffIds = new TArray<long>(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_TargetBuffIds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TargetBuffIds.CopyAssign(value);
			}
		}

		// Token: 0x06021264 RID: 135780 RVA: 0x0095A581 File Offset: 0x00958781
		public SCaughtBindingInfo()
		{
		}

		// Token: 0x06021265 RID: 135781 RVA: 0x0095A589 File Offset: 0x00958789
		protected override IntPtr GetUStructPtr()
		{
			return SCaughtBindingInfo.StaticStruct();
		}

		// Token: 0x06021266 RID: 135782 RVA: 0x0095A595 File Offset: 0x00958795
		[NullableContext(2)]
		public SCaughtBindingInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021267 RID: 135783 RVA: 0x0095A59F File Offset: 0x0095879F
		public SCaughtBindingInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021268 RID: 135784 RVA: 0x0095A5AA File Offset: 0x009587AA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCaughtBindingInfo(Pointer, false, true);
		}

		// Token: 0x06021269 RID: 135785 RVA: 0x0095A5B4 File Offset: 0x009587B4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCaughtBindingInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040121F1 RID: 74225
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCaughtBindingInfo.SCaughtBindingInfo";

		// Token: 0x040121F2 RID: 74226
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040121F3 RID: 74227
		internal static int __PropertyOffset_BulletId;

		// Token: 0x040121F4 RID: 74228
		internal static int __PropertyOffset_DestroyBullet;

		// Token: 0x040121F5 RID: 74229
		internal static int __PropertyOffset_SummonChildBullet;

		// Token: 0x040121F6 RID: 74230
		internal static int __PropertyOffset_EndBulletId;

		// Token: 0x040121F7 RID: 74231
		internal static int __PropertyOffset_TargetMontagePath;

		// Token: 0x040121F8 RID: 74232
		internal static int __PropertyOffset_TargetBoneName;

		// Token: 0x040121F9 RID: 74233
		internal static int __PropertyOffset_CaughtDirectionType;

		// Token: 0x040121FA RID: 74234
		internal static int __PropertyOffset_CollisionResponseToChannel;

		// Token: 0x040121FB RID: 74235
		[Nullable(new byte[]
		{
			2,
			0,
			0
		})]
		private TMap<TEnumAsByte<ECollisionChannel>, TEnumAsByte<ECollisionResponse>> _CollisionResponseToChannel;

		// Token: 0x040121FC RID: 74236
		internal static int __PropertyOffset_SourceBuffIds;

		// Token: 0x040121FD RID: 74237
		[Nullable(2)]
		private TArray<long> _SourceBuffIds;

		// Token: 0x040121FE RID: 74238
		internal static int __PropertyOffset_TargetBuffIds;

		// Token: 0x040121FF RID: 74239
		[Nullable(2)]
		private TArray<long> _TargetBuffIds;
	}
}
