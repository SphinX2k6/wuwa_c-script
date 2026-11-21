using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D2B RID: 3371
	public struct ExhibitWeaponTransform : IFlatbufferObject
	{
		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x060070E0 RID: 28896 RVA: 0x00246103 File Offset: 0x00244303
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060070E1 RID: 28897 RVA: 0x00246110 File Offset: 0x00244310
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060070E2 RID: 28898 RVA: 0x00246118 File Offset: 0x00244318
		public static ExhibitWeaponTransform GetRootAsExhibitWeaponTransform(ByteBuffer _bb)
		{
			return ExhibitWeaponTransform.GetRootAsExhibitWeaponTransform(_bb, default(ExhibitWeaponTransform));
		}

		// Token: 0x060070E3 RID: 28899 RVA: 0x00246134 File Offset: 0x00244334
		public static ExhibitWeaponTransform GetRootAsExhibitWeaponTransform(ByteBuffer _bb, ExhibitWeaponTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060070E4 RID: 28900 RVA: 0x00246151 File Offset: 0x00244351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060070E5 RID: 28901 RVA: 0x00246160 File Offset: 0x00244360
		public ExhibitWeaponTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x060070E6 RID: 28902 RVA: 0x00246170 File Offset: 0x00244370
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x060070E7 RID: 28903 RVA: 0x002461AC File Offset: 0x002443AC
		public Vector? Location
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x060070E8 RID: 28904 RVA: 0x0024620C File Offset: 0x0024440C
		public Vector? Rotation
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x060070E9 RID: 28905 RVA: 0x0024626C File Offset: 0x0024446C
		public float Size
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x060070EA RID: 28906 RVA: 0x002462B0 File Offset: 0x002444B0
		public int RotateTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x060070EB RID: 28907 RVA: 0x002462F0 File Offset: 0x002444F0
		public Vector? ScabbardOffset
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x060070EC RID: 28908 RVA: 0x00246350 File Offset: 0x00244550
		public bool ShowScabbard
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x060070ED RID: 28909 RVA: 0x00246390 File Offset: 0x00244590
		public Vector? AxisRotate
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x060070EE RID: 28910 RVA: 0x002463F0 File Offset: 0x002445F0
		public Vector? ScabbardRotationOffset
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x04005270 RID: 21104
		private Table __p;
	}
}
