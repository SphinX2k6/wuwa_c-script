using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA7 RID: 3495
	public struct KurotatoLimitAward : IFlatbufferObject
	{
		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06008A8D RID: 35469 RVA: 0x002702C1 File Offset: 0x0026E4C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008A8E RID: 35470 RVA: 0x002702CE File Offset: 0x0026E4CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008A8F RID: 35471 RVA: 0x002702D8 File Offset: 0x0026E4D8
		public static KurotatoLimitAward GetRootAsKurotatoLimitAward(ByteBuffer _bb)
		{
			return KurotatoLimitAward.GetRootAsKurotatoLimitAward(_bb, default(KurotatoLimitAward));
		}

		// Token: 0x06008A90 RID: 35472 RVA: 0x002702F4 File Offset: 0x0026E4F4
		public static KurotatoLimitAward GetRootAsKurotatoLimitAward(ByteBuffer _bb, KurotatoLimitAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008A91 RID: 35473 RVA: 0x00270311 File Offset: 0x0026E511
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x00270320 File Offset: 0x0026E520
		public KurotatoLimitAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06008A93 RID: 35475 RVA: 0x00270330 File Offset: 0x0026E530
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

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x06008A94 RID: 35476 RVA: 0x0027036C File Offset: 0x0026E56C
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

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x06008A95 RID: 35477 RVA: 0x002703A8 File Offset: 0x0026E5A8
		public int DropId
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

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x06008A96 RID: 35478 RVA: 0x002703E4 File Offset: 0x0026E5E4
		public int TabId
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

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x06008A97 RID: 35479 RVA: 0x00270424 File Offset: 0x0026E624
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

		// Token: 0x06008A98 RID: 35480 RVA: 0x0027045C File Offset: 0x0026E65C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008A99 RID: 35481 RVA: 0x0027046C File Offset: 0x0026E66C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E39 RID: 20025
		private Table __p;
	}
}
