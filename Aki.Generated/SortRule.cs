using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200120D RID: 4621
	public struct SortRule : IFlatbufferObject
	{
		// Token: 0x17003AEA RID: 15082
		// (get) Token: 0x0600E49C RID: 58524 RVA: 0x00348279 File Offset: 0x00346479
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E49D RID: 58525 RVA: 0x00348286 File Offset: 0x00346486
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E49E RID: 58526 RVA: 0x00348290 File Offset: 0x00346490
		public static SortRule GetRootAsSortRule(ByteBuffer _bb)
		{
			return SortRule.GetRootAsSortRule(_bb, default(SortRule));
		}

		// Token: 0x0600E49F RID: 58527 RVA: 0x003482AC File Offset: 0x003464AC
		public static SortRule GetRootAsSortRule(ByteBuffer _bb, SortRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E4A0 RID: 58528 RVA: 0x003482C9 File Offset: 0x003464C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E4A1 RID: 58529 RVA: 0x003482D8 File Offset: 0x003464D8
		public SortRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AEB RID: 15083
		// (get) Token: 0x0600E4A2 RID: 58530 RVA: 0x003482E8 File Offset: 0x003464E8
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

		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x0600E4A3 RID: 58531 RVA: 0x00348324 File Offset: 0x00346524
		public int DataId
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

		// Token: 0x17003AED RID: 15085
		// (get) Token: 0x0600E4A4 RID: 58532 RVA: 0x00348360 File Offset: 0x00346560
		public string Name
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

		// Token: 0x0600E4A5 RID: 58533 RVA: 0x00348397 File Offset: 0x00346597
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E4A6 RID: 58534 RVA: 0x003483A6 File Offset: 0x003465A6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AEE RID: 15086
		// (get) Token: 0x0600E4A7 RID: 58535 RVA: 0x003483C0 File Offset: 0x003465C0
		public string Icon
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

		// Token: 0x0600E4A8 RID: 58536 RVA: 0x003483F8 File Offset: 0x003465F8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E4A9 RID: 58537 RVA: 0x00348408 File Offset: 0x00346608
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AEF RID: 15087
		// (get) Token: 0x0600E4AA RID: 58538 RVA: 0x00348420 File Offset: 0x00346620
		public int AttributeId
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

		// Token: 0x17003AF0 RID: 15088
		// (get) Token: 0x0600E4AB RID: 58539 RVA: 0x00348460 File Offset: 0x00346660
		public int AddType
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

		// Token: 0x0400584D RID: 22605
		private Table __p;
	}
}
