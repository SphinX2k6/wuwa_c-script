using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE8 RID: 3304
	public struct GachaWeaponTransform : IFlatbufferObject
	{
		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x060078D3 RID: 30931 RVA: 0x002475A4 File Offset: 0x002457A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060078D4 RID: 30932 RVA: 0x002475B1 File Offset: 0x002457B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060078D5 RID: 30933 RVA: 0x002475B8 File Offset: 0x002457B8
		public static GachaWeaponTransform GetRootAsGachaWeaponTransform(ByteBuffer _bb)
		{
			return GachaWeaponTransform.GetRootAsGachaWeaponTransform(_bb, default(GachaWeaponTransform));
		}

		// Token: 0x060078D6 RID: 30934 RVA: 0x002475D4 File Offset: 0x002457D4
		public static GachaWeaponTransform GetRootAsGachaWeaponTransform(ByteBuffer _bb, GachaWeaponTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060078D7 RID: 30935 RVA: 0x002475F1 File Offset: 0x002457F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x00247600 File Offset: 0x00245800
		public GachaWeaponTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x060078D9 RID: 30937 RVA: 0x00247610 File Offset: 0x00245810
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

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x060078DA RID: 30938 RVA: 0x0024764C File Offset: 0x0024584C
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

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x060078DB RID: 30939 RVA: 0x002476AC File Offset: 0x002458AC
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

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x060078DC RID: 30940 RVA: 0x0024770C File Offset: 0x0024590C
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

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x060078DD RID: 30941 RVA: 0x00247750 File Offset: 0x00245950
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

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x060078DE RID: 30942 RVA: 0x00247790 File Offset: 0x00245990
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

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x060078DF RID: 30943 RVA: 0x002477F0 File Offset: 0x002459F0
		public bool ShowScabbard
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x060078E0 RID: 30944 RVA: 0x00247830 File Offset: 0x00245A30
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

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x060078E1 RID: 30945 RVA: 0x00247890 File Offset: 0x00245A90
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

		// Token: 0x060078E2 RID: 30946 RVA: 0x002478C8 File Offset: 0x00245AC8
		public Span<byte> GetWeaponTypeTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060078E3 RID: 30947 RVA: 0x002478D8 File Offset: 0x00245AD8
		public byte[] GetWeaponTypeTextureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D59 RID: 19801
		private Table __p;
	}
}
