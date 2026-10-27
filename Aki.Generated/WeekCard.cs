using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A1 RID: 4513
	public struct WeekCard : IFlatbufferObject
	{
		// Token: 0x17003E4E RID: 15950
		// (get) Token: 0x0600E8E6 RID: 59622 RVA: 0x00344EB8 File Offset: 0x003430B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E8E7 RID: 59623 RVA: 0x00344EC5 File Offset: 0x003430C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E8E8 RID: 59624 RVA: 0x00344ECC File Offset: 0x003430CC
		public static WeekCard GetRootAsWeekCard(ByteBuffer _bb)
		{
			return WeekCard.GetRootAsWeekCard(_bb, default(WeekCard));
		}

		// Token: 0x0600E8E9 RID: 59625 RVA: 0x00344EE8 File Offset: 0x003430E8
		public static WeekCard GetRootAsWeekCard(ByteBuffer _bb, WeekCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E8EA RID: 59626 RVA: 0x00344F05 File Offset: 0x00343105
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E8EB RID: 59627 RVA: 0x00344F14 File Offset: 0x00343114
		public WeekCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E4F RID: 15951
		// (get) Token: 0x0600E8EC RID: 59628 RVA: 0x00344F24 File Offset: 0x00343124
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

		// Token: 0x17003E50 RID: 15952
		// (get) Token: 0x0600E8ED RID: 59629 RVA: 0x00344F60 File Offset: 0x00343160
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

		// Token: 0x17003E51 RID: 15953
		// (get) Token: 0x0600E8EE RID: 59630 RVA: 0x00344F9C File Offset: 0x0034319C
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

		// Token: 0x17003E52 RID: 15954
		// (get) Token: 0x0600E8EF RID: 59631 RVA: 0x00344FD8 File Offset: 0x003431D8
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

		// Token: 0x17003E53 RID: 15955
		// (get) Token: 0x0600E8F0 RID: 59632 RVA: 0x00345018 File Offset: 0x00343218
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

		// Token: 0x17003E54 RID: 15956
		// (get) Token: 0x0600E8F1 RID: 59633 RVA: 0x00345058 File Offset: 0x00343258
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

		// Token: 0x0600E8F2 RID: 59634 RVA: 0x00345090 File Offset: 0x00343290
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E8F3 RID: 59635 RVA: 0x003450A0 File Offset: 0x003432A0
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E55 RID: 15957
		// (get) Token: 0x0600E8F4 RID: 59636 RVA: 0x003450B8 File Offset: 0x003432B8
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

		// Token: 0x0600E8F5 RID: 59637 RVA: 0x003450F0 File Offset: 0x003432F0
		public Span<byte> GetDiscountTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E8F6 RID: 59638 RVA: 0x00345100 File Offset: 0x00343300
		public byte[] GetDiscountTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x040052ED RID: 21229
		private Table __p;
	}
}
