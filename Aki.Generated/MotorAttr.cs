using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E2E RID: 3630
	public struct MotorAttr : IFlatbufferObject
	{
		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x0600969B RID: 38555 RVA: 0x0028AC39 File Offset: 0x00288E39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600969C RID: 38556 RVA: 0x0028AC46 File Offset: 0x00288E46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600969D RID: 38557 RVA: 0x0028AC50 File Offset: 0x00288E50
		public static MotorAttr GetRootAsMotorAttr(ByteBuffer _bb)
		{
			return MotorAttr.GetRootAsMotorAttr(_bb, default(MotorAttr));
		}

		// Token: 0x0600969E RID: 38558 RVA: 0x0028AC6C File Offset: 0x00288E6C
		public static MotorAttr GetRootAsMotorAttr(ByteBuffer _bb, MotorAttr obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600969F RID: 38559 RVA: 0x0028AC89 File Offset: 0x00288E89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060096A0 RID: 38560 RVA: 0x0028AC98 File Offset: 0x00288E98
		public MotorAttr __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x060096A1 RID: 38561 RVA: 0x0028ACA8 File Offset: 0x00288EA8
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

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x060096A2 RID: 38562 RVA: 0x0028ACE4 File Offset: 0x00288EE4
		public string PropertyId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060096A3 RID: 38563 RVA: 0x0028AD1B File Offset: 0x00288F1B
		public Span<byte> GetPropertyIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060096A4 RID: 38564 RVA: 0x0028AD2A File Offset: 0x00288F2A
		public byte[] GetPropertyIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x060096A5 RID: 38565 RVA: 0x0028AD44 File Offset: 0x00288F44
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060096A6 RID: 38566 RVA: 0x0028AD7B File Offset: 0x00288F7B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060096A7 RID: 38567 RVA: 0x0028AD8A File Offset: 0x00288F8A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x060096A8 RID: 38568 RVA: 0x0028ADA4 File Offset: 0x00288FA4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060096A9 RID: 38569 RVA: 0x0028ADDC File Offset: 0x00288FDC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060096AA RID: 38570 RVA: 0x0028ADEC File Offset: 0x00288FEC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x060096AB RID: 38571 RVA: 0x0028AE04 File Offset: 0x00289004
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060096AC RID: 38572 RVA: 0x0028AE3C File Offset: 0x0028903C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060096AD RID: 38573 RVA: 0x0028AE4C File Offset: 0x0028904C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x060096AE RID: 38574 RVA: 0x0028AE64 File Offset: 0x00289064
		public int ShowMain
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x060096AF RID: 38575 RVA: 0x0028AEA4 File Offset: 0x002890A4
		public int ShowMainOrder
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x060096B0 RID: 38576 RVA: 0x0028AEE4 File Offset: 0x002890E4
		public int ShowProperty
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x060096B1 RID: 38577 RVA: 0x0028AF24 File Offset: 0x00289124
		public int ShowDetailOrder
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x060096B2 RID: 38578 RVA: 0x0028AF64 File Offset: 0x00289164
		public int SpecialLevelShow
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x060096B3 RID: 38579 RVA: 0x0028AFA4 File Offset: 0x002891A4
		public string Suffix
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060096B4 RID: 38580 RVA: 0x0028AFDC File Offset: 0x002891DC
		public Span<byte> GetSuffixBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060096B5 RID: 38581 RVA: 0x0028AFEC File Offset: 0x002891EC
		public byte[] GetSuffixArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x060096B6 RID: 38582 RVA: 0x0028B004 File Offset: 0x00289204
		public bool IsPercent
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x060096B7 RID: 38583 RVA: 0x0028B044 File Offset: 0x00289244
		public bool IsNumber
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004ED3 RID: 20179
		private Table __p;
	}
}
