using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001208 RID: 4616
	public struct SolarSchoolSummaryItem : IFlatbufferObject
	{
		// Token: 0x17003AC2 RID: 15042
		// (get) Token: 0x0600E433 RID: 58419 RVA: 0x003474C8 File Offset: 0x003456C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E434 RID: 58420 RVA: 0x003474D5 File Offset: 0x003456D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E435 RID: 58421 RVA: 0x003474DC File Offset: 0x003456DC
		public static SolarSchoolSummaryItem GetRootAsSolarSchoolSummaryItem(ByteBuffer _bb)
		{
			return SolarSchoolSummaryItem.GetRootAsSolarSchoolSummaryItem(_bb, default(SolarSchoolSummaryItem));
		}

		// Token: 0x0600E436 RID: 58422 RVA: 0x003474F8 File Offset: 0x003456F8
		public static SolarSchoolSummaryItem GetRootAsSolarSchoolSummaryItem(ByteBuffer _bb, SolarSchoolSummaryItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E437 RID: 58423 RVA: 0x00347515 File Offset: 0x00345715
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E438 RID: 58424 RVA: 0x00347524 File Offset: 0x00345724
		public SolarSchoolSummaryItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AC3 RID: 15043
		// (get) Token: 0x0600E439 RID: 58425 RVA: 0x00347534 File Offset: 0x00345734
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

		// Token: 0x17003AC4 RID: 15044
		// (get) Token: 0x0600E43A RID: 58426 RVA: 0x00347570 File Offset: 0x00345770
		public int ActivityId
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

		// Token: 0x17003AC5 RID: 15045
		// (get) Token: 0x0600E43B RID: 58427 RVA: 0x003475AC File Offset: 0x003457AC
		public int Sort
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

		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x0600E43C RID: 58428 RVA: 0x003475E8 File Offset: 0x003457E8
		public int ContentType
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

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x0600E43D RID: 58429 RVA: 0x00347628 File Offset: 0x00345828
		public string TitleText
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

		// Token: 0x0600E43E RID: 58430 RVA: 0x00347660 File Offset: 0x00345860
		public Span<byte> GetTitleTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E43F RID: 58431 RVA: 0x00347670 File Offset: 0x00345870
		public byte[] GetTitleTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x0600E440 RID: 58432 RVA: 0x00347688 File Offset: 0x00345888
		public string ContentText
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

		// Token: 0x0600E441 RID: 58433 RVA: 0x003476C0 File Offset: 0x003458C0
		public Span<byte> GetContentTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E442 RID: 58434 RVA: 0x003476D0 File Offset: 0x003458D0
		public byte[] GetContentTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x0600E443 RID: 58435 RVA: 0x003476E8 File Offset: 0x003458E8
		public string Comments
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

		// Token: 0x0600E444 RID: 58436 RVA: 0x00347720 File Offset: 0x00345920
		public Span<byte> GetCommentsBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E445 RID: 58437 RVA: 0x00347730 File Offset: 0x00345930
		public byte[] GetCommentsArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005848 RID: 22600
		private Table __p;
	}
}
