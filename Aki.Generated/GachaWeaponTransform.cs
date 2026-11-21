using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DCC RID: 3532
	public struct GachaWeaponTransform : IFlatbufferObject
	{
		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x06007EDE RID: 32478 RVA: 0x00266084 File Offset: 0x00264284
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007EDF RID: 32479 RVA: 0x00266091 File Offset: 0x00264291
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007EE0 RID: 32480 RVA: 0x00266098 File Offset: 0x00264298
		public static GachaWeaponTransform GetRootAsGachaWeaponTransform(ByteBuffer _bb)
		{
			return GachaWeaponTransform.GetRootAsGachaWeaponTransform(_bb, default(GachaWeaponTransform));
		}

		// Token: 0x06007EE1 RID: 32481 RVA: 0x002660B4 File Offset: 0x002642B4
		public static GachaWeaponTransform GetRootAsGachaWeaponTransform(ByteBuffer _bb, GachaWeaponTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007EE2 RID: 32482 RVA: 0x002660D1 File Offset: 0x002642D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007EE3 RID: 32483 RVA: 0x002660E0 File Offset: 0x002642E0
		public GachaWeaponTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x06007EE4 RID: 32484 RVA: 0x002660F0 File Offset: 0x002642F0
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

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x06007EE5 RID: 32485 RVA: 0x0026612C File Offset: 0x0026432C
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

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x06007EE6 RID: 32486 RVA: 0x0026618C File Offset: 0x0026438C
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

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x06007EE7 RID: 32487 RVA: 0x002661EC File Offset: 0x002643EC
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

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06007EE8 RID: 32488 RVA: 0x00266230 File Offset: 0x00264430
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

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06007EE9 RID: 32489 RVA: 0x00266270 File Offset: 0x00264470
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

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06007EEA RID: 32490 RVA: 0x002662D0 File Offset: 0x002644D0
		public bool ShowScabbard
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06007EEB RID: 32491 RVA: 0x00266310 File Offset: 0x00264510
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

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06007EEC RID: 32492 RVA: 0x00266370 File Offset: 0x00264570
		public string WeaponTypeTexture
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007EED RID: 32493 RVA: 0x002663A8 File Offset: 0x002645A8
		public Span<byte> GetWeaponTypeTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007EEE RID: 32494 RVA: 0x002663B8 File Offset: 0x002645B8
		public byte[] GetWeaponTypeTextureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0400533D RID: 21309
		private Table __p;
	}
}
