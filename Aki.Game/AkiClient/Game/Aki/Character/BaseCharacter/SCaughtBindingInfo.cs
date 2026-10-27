using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042FE RID: 17150
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCaughtBindingInfo.SCaughtBindingInfo")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class SCaughtBindingInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C52E RID: 181550 RVA: 0x00A1D14E File Offset: 0x00A1B34E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCaughtBindingInfo._ScriptStructPtr != 0) ? SCaughtBindingInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCaughtBindingInfo.SCaughtBindingInfo", ref SCaughtBindingInfo._ScriptStructPtr);
		}

		// Token: 0x17006EB7 RID: 28343
		// (get) Token: 0x0602C52F RID: 181551 RVA: 0x00A1D172 File Offset: 0x00A1B372
		// (set) Token: 0x0602C530 RID: 181552 RVA: 0x00A1D186 File Offset: 0x00A1B386
		public unsafe string BulletId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006EB8 RID: 28344
		// (get) Token: 0x0602C531 RID: 181553 RVA: 0x00A1D19B File Offset: 0x00A1B39B
		// (set) Token: 0x0602C532 RID: 181554 RVA: 0x00A1D1AB File Offset: 0x00A1B3AB
		public unsafe bool DestroyBullet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006EB9 RID: 28345
		// (get) Token: 0x0602C533 RID: 181555 RVA: 0x00A1D1BC File Offset: 0x00A1B3BC
		// (set) Token: 0x0602C534 RID: 181556 RVA: 0x00A1D1CC File Offset: 0x00A1B3CC
		public unsafe bool SummonChildBullet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006EBA RID: 28346
		// (get) Token: 0x0602C535 RID: 181557 RVA: 0x00A1D1DD File Offset: 0x00A1B3DD
		// (set) Token: 0x0602C536 RID: 181558 RVA: 0x00A1D1F1 File Offset: 0x00A1B3F1
		public unsafe string EndBulletId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17006EBB RID: 28347
		// (get) Token: 0x0602C537 RID: 181559 RVA: 0x00A1D206 File Offset: 0x00A1B406
		// (set) Token: 0x0602C538 RID: 181560 RVA: 0x00A1D21A File Offset: 0x00A1B41A
		public unsafe string TargetMontagePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x17006EBC RID: 28348
		// (get) Token: 0x0602C539 RID: 181561 RVA: 0x00A1D22F File Offset: 0x00A1B42F
		// (set) Token: 0x0602C53A RID: 181562 RVA: 0x00A1D243 File Offset: 0x00A1B443
		public unsafe string TargetBoneName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtBindingInfo.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x17006EBD RID: 28349
		// (get) Token: 0x0602C53B RID: 181563 RVA: 0x00A1D258 File Offset: 0x00A1B458
		// (set) Token: 0x0602C53C RID: 181564 RVA: 0x00A1D26C File Offset: 0x00A1B46C
		[Nullable(0)]
		public unsafe TEnumAsByte<ECaughtDirectionType> CaughtDirectionType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_6);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006EBE RID: 28350
		// (get) Token: 0x0602C53D RID: 181565 RVA: 0x00A1D284 File Offset: 0x00A1B484
		// (set) Token: 0x0602C53E RID: 181566 RVA: 0x00A1D2C7 File Offset: 0x00A1B4C7
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
					result = (this._CollisionResponseToChannel = new TMap<TEnumAsByte<ECollisionChannel>, TEnumAsByte<ECollisionResponse>>(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_7, base.MemoryOwner ?? this));
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

		// Token: 0x17006EBF RID: 28351
		// (get) Token: 0x0602C53F RID: 181567 RVA: 0x00A1D2D8 File Offset: 0x00A1B4D8
		// (set) Token: 0x0602C540 RID: 181568 RVA: 0x00A1D31B File Offset: 0x00A1B51B
		public TArray<long> SourceBuffIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._SourceBuffIds) == null)
				{
					result = (this._SourceBuffIds = new TArray<long>(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SourceBuffIds.CopyAssign(value);
			}
		}

		// Token: 0x17006EC0 RID: 28352
		// (get) Token: 0x0602C541 RID: 181569 RVA: 0x00A1D32C File Offset: 0x00A1B52C
		// (set) Token: 0x0602C542 RID: 181570 RVA: 0x00A1D36F File Offset: 0x00A1B56F
		public TArray<long> TargetBuffIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._TargetBuffIds) == null)
				{
					result = (this._TargetBuffIds = new TArray<long>(base.NativePtr + (IntPtr)SCaughtBindingInfo.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TargetBuffIds.CopyAssign(value);
			}
		}

		// Token: 0x0602C543 RID: 181571 RVA: 0x00A1D37D File Offset: 0x00A1B57D
		public SCaughtBindingInfo()
		{
		}

		// Token: 0x0602C544 RID: 181572 RVA: 0x00A1D388 File Offset: 0x00A1B588
		public SCaughtBindingInfo(string BulletId, bool DestroyBullet, bool SummonChildBullet, string EndBulletId, string TargetMontagePath, string TargetBoneName, [Nullable(0)] TEnumAsByte<ECaughtDirectionType> CaughtDirectionType, [Nullable(new byte[]
		{
			1,
			0,
			0
		})] TMap<TEnumAsByte<ECollisionChannel>, TEnumAsByte<ECollisionResponse>> CollisionResponseToChannel, TArray<long> SourceBuffIds, TArray<long> TargetBuffIds)
		{
			this.BulletId = BulletId;
			this.DestroyBullet = DestroyBullet;
			this.SummonChildBullet = SummonChildBullet;
			this.EndBulletId = EndBulletId;
			this.TargetMontagePath = TargetMontagePath;
			this.TargetBoneName = TargetBoneName;
			this.CaughtDirectionType = CaughtDirectionType;
			this.CollisionResponseToChannel = CollisionResponseToChannel;
			this.SourceBuffIds = SourceBuffIds;
			this.TargetBuffIds = TargetBuffIds;
		}

		// Token: 0x0602C545 RID: 181573 RVA: 0x00A1D3E8 File Offset: 0x00A1B5E8
		protected override IntPtr GetUStructPtr()
		{
			return SCaughtBindingInfo.StaticStruct();
		}

		// Token: 0x0602C546 RID: 181574 RVA: 0x00A1D3F4 File Offset: 0x00A1B5F4
		[NullableContext(2)]
		public SCaughtBindingInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C547 RID: 181575 RVA: 0x00A1D3FE File Offset: 0x00A1B5FE
		public SCaughtBindingInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C548 RID: 181576 RVA: 0x00A1D409 File Offset: 0x00A1B609
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCaughtBindingInfo(Pointer, false, true);
		}

		// Token: 0x0602C549 RID: 181577 RVA: 0x00A1D413 File Offset: 0x00A1B613
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCaughtBindingInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040175EF RID: 95727
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCaughtBindingInfo.SCaughtBindingInfo";

		// Token: 0x040175F0 RID: 95728
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040175F1 RID: 95729
		internal static int __PropertyOffset_0;

		// Token: 0x040175F2 RID: 95730
		internal static int __PropertyOffset_1;

		// Token: 0x040175F3 RID: 95731
		internal static int __PropertyOffset_2;

		// Token: 0x040175F4 RID: 95732
		internal static int __PropertyOffset_3;

		// Token: 0x040175F5 RID: 95733
		internal static int __PropertyOffset_4;

		// Token: 0x040175F6 RID: 95734
		internal static int __PropertyOffset_5;

		// Token: 0x040175F7 RID: 95735
		internal static int __PropertyOffset_6;

		// Token: 0x040175F8 RID: 95736
		internal static int __PropertyOffset_7;

		// Token: 0x040175F9 RID: 95737
		[Nullable(new byte[]
		{
			2,
			0,
			0
		})]
		private TMap<TEnumAsByte<ECollisionChannel>, TEnumAsByte<ECollisionResponse>> _CollisionResponseToChannel;

		// Token: 0x040175FA RID: 95738
		internal static int __PropertyOffset_8;

		// Token: 0x040175FB RID: 95739
		[Nullable(2)]
		private TArray<long> _SourceBuffIds;

		// Token: 0x040175FC RID: 95740
		internal static int __PropertyOffset_9;

		// Token: 0x040175FD RID: 95741
		[Nullable(2)]
		private TArray<long> _TargetBuffIds;
	}
}
