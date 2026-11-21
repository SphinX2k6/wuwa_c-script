using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E97 RID: 3735
	public struct KurotatoScoreAward : IFlatbufferObject
	{
		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x0600919E RID: 37278 RVA: 0x00290B9D File Offset: 0x0028ED9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600919F RID: 37279 RVA: 0x00290BAA File Offset: 0x0028EDAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060091A0 RID: 37280 RVA: 0x00290BB4 File Offset: 0x0028EDB4
		public static KurotatoScoreAward GetRootAsKurotatoScoreAward(ByteBuffer _bb)
		{
			return KurotatoScoreAward.GetRootAsKurotatoScoreAward(_bb, default(KurotatoScoreAward));
		}

		// Token: 0x060091A1 RID: 37281 RVA: 0x00290BD0 File Offset: 0x0028EDD0
		public static KurotatoScoreAward GetRootAsKurotatoScoreAward(ByteBuffer _bb, KurotatoScoreAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060091A2 RID: 37282 RVA: 0x00290BED File Offset: 0x0028EDED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060091A3 RID: 37283 RVA: 0x00290BFC File Offset: 0x0028EDFC
		public KurotatoScoreAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x060091A4 RID: 37284 RVA: 0x00290C0C File Offset: 0x0028EE0C
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

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x060091A5 RID: 37285 RVA: 0x00290C48 File Offset: 0x0028EE48
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

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x060091A6 RID: 37286 RVA: 0x00290C84 File Offset: 0x0028EE84
		public int Score
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

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x060091A7 RID: 37287 RVA: 0x00290CC0 File Offset: 0x0028EEC0
		public int DropId
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

		// Token: 0x04005429 RID: 21545
		private Table __p;
	}
}
