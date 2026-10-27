using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Bullet
{
	// Token: 0x02004024 RID: 16420
	[UnrealObjectPath("/Game/Aki/Core/Fight/Bullet/BulletCommonDataAsset.BulletCommonDataAsset_C")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 236)]
	public class BulletCommonDataAsset_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A1C6 RID: 172486 RVA: 0x009D65A6 File Offset: 0x009D47A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BulletCommonDataAsset_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/Bullet/BulletCommonDataAsset.BulletCommonDataAsset_C");
			}
			return BulletCommonDataAsset_C._ClassPtr;
		}

		// Token: 0x0602A1C7 RID: 172487 RVA: 0x009D65CC File Offset: 0x009D47CC
		public BulletCommonDataAsset_C() : this(BuiltinUtils.AllocNativeUObject(BulletCommonDataAsset_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A1C8 RID: 172488 RVA: 0x009D65F4 File Offset: 0x009D47F4
		[NullableContext(1)]
		public BulletCommonDataAsset_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BulletCommonDataAsset_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170066BA RID: 26298
		// (get) Token: 0x0602A1C9 RID: 172489 RVA: 0x009D6628 File Offset: 0x009D4828
		// (set) Token: 0x0602A1CA RID: 172490 RVA: 0x009D6661 File Offset: 0x009D4861
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
					result = (this._TakeAim = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_0, this));
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

		// Token: 0x170066BB RID: 26299
		// (get) Token: 0x0602A1CB RID: 172491 RVA: 0x009D6670 File Offset: 0x009D4870
		// (set) Token: 0x0602A1CC RID: 172492 RVA: 0x009D66A9 File Offset: 0x009D48A9
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
					result = (this._Obstacles = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_1, this));
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

		// Token: 0x170066BC RID: 26300
		// (get) Token: 0x0602A1CD RID: 172493 RVA: 0x009D66B8 File Offset: 0x009D48B8
		// (set) Token: 0x0602A1CE RID: 172494 RVA: 0x009D66F1 File Offset: 0x009D48F1
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
					result = (this._HitPoint = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_2, this));
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

		// Token: 0x170066BD RID: 26301
		// (get) Token: 0x0602A1CF RID: 172495 RVA: 0x009D6700 File Offset: 0x009D4900
		// (set) Token: 0x0602A1D0 RID: 172496 RVA: 0x009D6739 File Offset: 0x009D4939
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
					result = (this._FastMoveTraceBullet_Type1 = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_3, this));
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

		// Token: 0x170066BE RID: 26302
		// (get) Token: 0x0602A1D1 RID: 172497 RVA: 0x009D6748 File Offset: 0x009D4948
		// (set) Token: 0x0602A1D2 RID: 172498 RVA: 0x009D6781 File Offset: 0x009D4981
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
					result = (this._FastMoveTraceBullet_Type2 = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_4, this));
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

		// Token: 0x170066BF RID: 26303
		// (get) Token: 0x0602A1D3 RID: 172499 RVA: 0x009D6790 File Offset: 0x009D4990
		// (set) Token: 0x0602A1D4 RID: 172500 RVA: 0x009D67C9 File Offset: 0x009D49C9
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
					result = (this._FastMoveTraceBullet_Type3 = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_5, this));
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

		// Token: 0x170066C0 RID: 26304
		// (get) Token: 0x0602A1D5 RID: 172501 RVA: 0x009D67D8 File Offset: 0x009D49D8
		// (set) Token: 0x0602A1D6 RID: 172502 RVA: 0x009D6811 File Offset: 0x009D4A11
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
					result = (this._FastMoveTraceBullet_Type1_Special = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_6, this));
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

		// Token: 0x170066C1 RID: 26305
		// (get) Token: 0x0602A1D7 RID: 172503 RVA: 0x009D6820 File Offset: 0x009D4A20
		// (set) Token: 0x0602A1D8 RID: 172504 RVA: 0x009D6859 File Offset: 0x009D4A59
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
					result = (this._FastMoveTraceBullet_Type2_Special = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_7, this));
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

		// Token: 0x170066C2 RID: 26306
		// (get) Token: 0x0602A1D9 RID: 172505 RVA: 0x009D6868 File Offset: 0x009D4A68
		// (set) Token: 0x0602A1DA RID: 172506 RVA: 0x009D68A1 File Offset: 0x009D4AA1
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
					result = (this._FastMoveTraceBullet_Only_Bullet = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_8, this));
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

		// Token: 0x170066C3 RID: 26307
		// (get) Token: 0x0602A1DB RID: 172507 RVA: 0x009D68AF File Offset: 0x009D4AAF
		// (set) Token: 0x0602A1DC RID: 172508 RVA: 0x009D68BF File Offset: 0x009D4ABF
		public unsafe float OnHitMaterialDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170066C4 RID: 26308
		// (get) Token: 0x0602A1DD RID: 172509 RVA: 0x009D68D0 File Offset: 0x009D4AD0
		// (set) Token: 0x0602A1DE RID: 172510 RVA: 0x009D68E0 File Offset: 0x009D4AE0
		public unsafe float OnHitMaterialDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170066C5 RID: 26309
		// (get) Token: 0x0602A1DF RID: 172511 RVA: 0x009D68F1 File Offset: 0x009D4AF1
		// (set) Token: 0x0602A1E0 RID: 172512 RVA: 0x009D6901 File Offset: 0x009D4B01
		public unsafe float OnHitMaterialCd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BulletCommonDataAsset_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x0602A1E1 RID: 172513 RVA: 0x009D6912 File Offset: 0x009D4B12
		protected BulletCommonDataAsset_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B04 RID: 88836
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/Bullet/BulletCommonDataAsset.BulletCommonDataAsset_C";

		// Token: 0x04015B05 RID: 88837
		private static IntPtr _ClassPtr;

		// Token: 0x04015B06 RID: 88838
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015B07 RID: 88839
		internal static int __PropertyOffset_0;

		// Token: 0x04015B08 RID: 88840
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _TakeAim;

		// Token: 0x04015B09 RID: 88841
		internal static int __PropertyOffset_1;

		// Token: 0x04015B0A RID: 88842
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _Obstacles;

		// Token: 0x04015B0B RID: 88843
		internal static int __PropertyOffset_2;

		// Token: 0x04015B0C RID: 88844
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _HitPoint;

		// Token: 0x04015B0D RID: 88845
		internal static int __PropertyOffset_3;

		// Token: 0x04015B0E RID: 88846
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _FastMoveTraceBullet_Type1;

		// Token: 0x04015B0F RID: 88847
		internal static int __PropertyOffset_4;

		// Token: 0x04015B10 RID: 88848
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _FastMoveTraceBullet_Type2;

		// Token: 0x04015B11 RID: 88849
		internal static int __PropertyOffset_5;

		// Token: 0x04015B12 RID: 88850
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _FastMoveTraceBullet_Type3;

		// Token: 0x04015B13 RID: 88851
		internal static int __PropertyOffset_6;

		// Token: 0x04015B14 RID: 88852
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _FastMoveTraceBullet_Type1_Special;

		// Token: 0x04015B15 RID: 88853
		internal static int __PropertyOffset_7;

		// Token: 0x04015B16 RID: 88854
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _FastMoveTraceBullet_Type2_Special;

		// Token: 0x04015B17 RID: 88855
		internal static int __PropertyOffset_8;

		// Token: 0x04015B18 RID: 88856
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _FastMoveTraceBullet_Only_Bullet;

		// Token: 0x04015B19 RID: 88857
		internal static int __PropertyOffset_9;

		// Token: 0x04015B1A RID: 88858
		internal static int __PropertyOffset_10;

		// Token: 0x04015B1B RID: 88859
		internal static int __PropertyOffset_11;
	}
}
