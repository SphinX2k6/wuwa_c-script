using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Bullet
{
	// Token: 0x02003284 RID: 12932
	[UnrealObjectPath("/Game/Aki/Core/Fight/Bullet/BulletCommonDataAsset.BulletCommonDataAsset_C")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 236)]
	public class BulletCommonDataAsset_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020566 RID: 132454 RVA: 0x00943A06 File Offset: 0x00941C06
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BulletCommonDataAsset_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/Bullet/BulletCommonDataAsset.BulletCommonDataAsset_C");
			}
			return BulletCommonDataAsset_C._ClassPtr;
		}

		// Token: 0x06020567 RID: 132455 RVA: 0x00943A2C File Offset: 0x00941C2C
		public BulletCommonDataAsset_C() : this(BuiltinUtils.AllocNativeUObject(BulletCommonDataAsset_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020568 RID: 132456 RVA: 0x00943A54 File Offset: 0x00941C54
		[NullableContext(1)]
		public BulletCommonDataAsset_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BulletCommonDataAsset_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E7F RID: 15999
		// (get) Token: 0x06020569 RID: 132457 RVA: 0x00943A88 File Offset: 0x00941C88
		// (set) Token: 0x0602056A RID: 132458 RVA: 0x00943AC1 File Offset: 0x00941CC1
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> TakeAim
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._TakeAim) == null)
				{
					result = (this._TakeAim = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_TakeAim, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.TakeAim.CopyAssign(value);
			}
		}

		// Token: 0x17003E80 RID: 16000
		// (get) Token: 0x0602056B RID: 132459 RVA: 0x00943AD0 File Offset: 0x00941CD0
		// (set) Token: 0x0602056C RID: 132460 RVA: 0x00943B09 File Offset: 0x00941D09
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> Obstacles
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._Obstacles) == null)
				{
					result = (this._Obstacles = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_Obstacles, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.Obstacles.CopyAssign(value);
			}
		}

		// Token: 0x17003E81 RID: 16001
		// (get) Token: 0x0602056D RID: 132461 RVA: 0x00943B18 File Offset: 0x00941D18
		// (set) Token: 0x0602056E RID: 132462 RVA: 0x00943B51 File Offset: 0x00941D51
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> HitPoint
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._HitPoint) == null)
				{
					result = (this._HitPoint = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_HitPoint, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.HitPoint.CopyAssign(value);
			}
		}

		// Token: 0x17003E82 RID: 16002
		// (get) Token: 0x0602056F RID: 132463 RVA: 0x00943B60 File Offset: 0x00941D60
		// (set) Token: 0x06020570 RID: 132464 RVA: 0x00943B99 File Offset: 0x00941D99
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> FastMoveTraceBullet_Type1
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._FastMoveTraceBullet_Type1) == null)
				{
					result = (this._FastMoveTraceBullet_Type1 = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_FastMoveTraceBullet_Type1, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.FastMoveTraceBullet_Type1.CopyAssign(value);
			}
		}

		// Token: 0x17003E83 RID: 16003
		// (get) Token: 0x06020571 RID: 132465 RVA: 0x00943BA8 File Offset: 0x00941DA8
		// (set) Token: 0x06020572 RID: 132466 RVA: 0x00943BE1 File Offset: 0x00941DE1
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> FastMoveTraceBullet_Type2
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._FastMoveTraceBullet_Type2) == null)
				{
					result = (this._FastMoveTraceBullet_Type2 = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_FastMoveTraceBullet_Type2, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.FastMoveTraceBullet_Type2.CopyAssign(value);
			}
		}

		// Token: 0x17003E84 RID: 16004
		// (get) Token: 0x06020573 RID: 132467 RVA: 0x00943BF0 File Offset: 0x00941DF0
		// (set) Token: 0x06020574 RID: 132468 RVA: 0x00943C29 File Offset: 0x00941E29
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> FastMoveTraceBullet_Type3
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._FastMoveTraceBullet_Type3) == null)
				{
					result = (this._FastMoveTraceBullet_Type3 = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_FastMoveTraceBullet_Type3, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.FastMoveTraceBullet_Type3.CopyAssign(value);
			}
		}

		// Token: 0x17003E85 RID: 16005
		// (get) Token: 0x06020575 RID: 132469 RVA: 0x00943C38 File Offset: 0x00941E38
		// (set) Token: 0x06020576 RID: 132470 RVA: 0x00943C71 File Offset: 0x00941E71
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> FastMoveTraceBullet_Type1_Special
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._FastMoveTraceBullet_Type1_Special) == null)
				{
					result = (this._FastMoveTraceBullet_Type1_Special = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_FastMoveTraceBullet_Type1_Special, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.FastMoveTraceBullet_Type1_Special.CopyAssign(value);
			}
		}

		// Token: 0x17003E86 RID: 16006
		// (get) Token: 0x06020577 RID: 132471 RVA: 0x00943C80 File Offset: 0x00941E80
		// (set) Token: 0x06020578 RID: 132472 RVA: 0x00943CB9 File Offset: 0x00941EB9
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> FastMoveTraceBullet_Type2_Special
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._FastMoveTraceBullet_Type2_Special) == null)
				{
					result = (this._FastMoveTraceBullet_Type2_Special = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_FastMoveTraceBullet_Type2_Special, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.FastMoveTraceBullet_Type2_Special.CopyAssign(value);
			}
		}

		// Token: 0x17003E87 RID: 16007
		// (get) Token: 0x06020579 RID: 132473 RVA: 0x00943CC8 File Offset: 0x00941EC8
		// (set) Token: 0x0602057A RID: 132474 RVA: 0x00943D01 File Offset: 0x00941F01
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> FastMoveTraceBullet_Only_Bullet
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._FastMoveTraceBullet_Only_Bullet) == null)
				{
					result = (this._FastMoveTraceBullet_Only_Bullet = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_FastMoveTraceBullet_Only_Bullet, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.FastMoveTraceBullet_Only_Bullet.CopyAssign(value);
			}
		}

		// Token: 0x17003E88 RID: 16008
		// (get) Token: 0x0602057B RID: 132475 RVA: 0x00943D0F File Offset: 0x00941F0F
		// (set) Token: 0x0602057C RID: 132476 RVA: 0x00943D1F File Offset: 0x00941F1F
		public unsafe float OnHitMaterialDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_OnHitMaterialDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_OnHitMaterialDelay) = value;
			}
		}

		// Token: 0x17003E89 RID: 16009
		// (get) Token: 0x0602057D RID: 132477 RVA: 0x00943D30 File Offset: 0x00941F30
		// (set) Token: 0x0602057E RID: 132478 RVA: 0x00943D40 File Offset: 0x00941F40
		public unsafe float OnHitMaterialDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_OnHitMaterialDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_OnHitMaterialDuration) = value;
			}
		}

		// Token: 0x17003E8A RID: 16010
		// (get) Token: 0x0602057F RID: 132479 RVA: 0x00943D51 File Offset: 0x00941F51
		// (set) Token: 0x06020580 RID: 132480 RVA: 0x00943D61 File Offset: 0x00941F61
		public unsafe float OnHitMaterialCd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_OnHitMaterialCd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_OnHitMaterialCd) = value;
			}
		}

		// Token: 0x06020581 RID: 132481 RVA: 0x00943D72 File Offset: 0x00941F72
		protected BulletCommonDataAsset_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011751 RID: 71505
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/Bullet/BulletCommonDataAsset.BulletCommonDataAsset_C";

		// Token: 0x04011752 RID: 71506
		private static IntPtr _ClassPtr;

		// Token: 0x04011753 RID: 71507
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011754 RID: 71508
		internal static int __PropertyOffset_TakeAim;

		// Token: 0x04011755 RID: 71509
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _TakeAim;

		// Token: 0x04011756 RID: 71510
		internal static int __PropertyOffset_Obstacles;

		// Token: 0x04011757 RID: 71511
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _Obstacles;

		// Token: 0x04011758 RID: 71512
		internal static int __PropertyOffset_HitPoint;

		// Token: 0x04011759 RID: 71513
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _HitPoint;

		// Token: 0x0401175A RID: 71514
		internal static int __PropertyOffset_FastMoveTraceBullet_Type1;

		// Token: 0x0401175B RID: 71515
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _FastMoveTraceBullet_Type1;

		// Token: 0x0401175C RID: 71516
		internal static int __PropertyOffset_FastMoveTraceBullet_Type2;

		// Token: 0x0401175D RID: 71517
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _FastMoveTraceBullet_Type2;

		// Token: 0x0401175E RID: 71518
		internal static int __PropertyOffset_FastMoveTraceBullet_Type3;

		// Token: 0x0401175F RID: 71519
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _FastMoveTraceBullet_Type3;

		// Token: 0x04011760 RID: 71520
		internal static int __PropertyOffset_FastMoveTraceBullet_Type1_Special;

		// Token: 0x04011761 RID: 71521
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _FastMoveTraceBullet_Type1_Special;

		// Token: 0x04011762 RID: 71522
		internal static int __PropertyOffset_FastMoveTraceBullet_Type2_Special;

		// Token: 0x04011763 RID: 71523
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _FastMoveTraceBullet_Type2_Special;

		// Token: 0x04011764 RID: 71524
		internal static int __PropertyOffset_FastMoveTraceBullet_Only_Bullet;

		// Token: 0x04011765 RID: 71525
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _FastMoveTraceBullet_Only_Bullet;

		// Token: 0x04011766 RID: 71526
		internal static int __PropertyOffset_OnHitMaterialDelay;

		// Token: 0x04011767 RID: 71527
		internal static int __PropertyOffset_OnHitMaterialDuration;

		// Token: 0x04011768 RID: 71528
		internal static int __PropertyOffset_OnHitMaterialCd;
	}
}
