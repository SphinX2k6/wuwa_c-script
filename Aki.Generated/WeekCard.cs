using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012D7 RID: 4823
	public struct WeekCard : IFlatbufferObject
	{
		// Token: 0x170041B3 RID: 16819
		// (get) Token: 0x0600F657 RID: 63063 RVA: 0x0036FB44 File Offset: 0x0036DD44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F658 RID: 63064 RVA: 0x0036FB51 File Offset: 0x0036DD51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F659 RID: 63065 RVA: 0x0036FB58 File Offset: 0x0036DD58
		public static WeekCard GetRootAsWeekCard(ByteBuffer _bb)
		{
			return WeekCard.GetRootAsWeekCard(_bb, default(WeekCard));
		}

		// Token: 0x0600F65A RID: 63066 RVA: 0x0036FB74 File Offset: 0x0036DD74
		public static WeekCard GetRootAsWeekCard(ByteBuffer _bb, WeekCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F65B RID: 63067 RVA: 0x0036FB91 File Offset: 0x0036DD91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F65C RID: 63068 RVA: 0x0036FBA0 File Offset: 0x0036DDA0
		public WeekCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041B4 RID: 16820
		// (get) Token: 0x0600F65D RID: 63069 RVA: 0x0036FBB0 File Offset: 0x0036DDB0
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

		// Token: 0x170041B5 RID: 16821
		// (get) Token: 0x0600F65E RID: 63070 RVA: 0x0036FBEC File Offset: 0x0036DDEC
		public int PayGiftId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170041B6 RID: 16822
		// (get) Token: 0x0600F65F RID: 63071 RVA: 0x0036FC28 File Offset: 0x0036DE28
		public int HelpGroupId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170041B7 RID: 16823
		// (get) Token: 0x0600F660 RID: 63072 RVA: 0x0036FC64 File Offset: 0x0036DE64
		public int Days
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170041B8 RID: 16824
		// (get) Token: 0x0600F661 RID: 63073 RVA: 0x0036FCA4 File Offset: 0x0036DEA4
		public int ShowType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170041B9 RID: 16825
		// (get) Token: 0x0600F662 RID: 63074 RVA: 0x0036FCE4 File Offset: 0x0036DEE4
		public string Title
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F663 RID: 63075 RVA: 0x0036FD1C File Offset: 0x0036DF1C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600F664 RID: 63076 RVA: 0x0036FD2C File Offset: 0x0036DF2C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170041BA RID: 16826
		// (get) Token: 0x0600F665 RID: 63077 RVA: 0x0036FD44 File Offset: 0x0036DF44
		public string DiscountTexture
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F666 RID: 63078 RVA: 0x0036FD7C File Offset: 0x0036DF7C
		public Span<byte> GetDiscountTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600F667 RID: 63079 RVA: 0x0036FD8C File Offset: 0x0036DF8C
		public byte[] GetDiscountTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005930 RID: 22832
		private Table __p;
	}
}
