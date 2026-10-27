using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB2 RID: 3506
	public struct KurotatoScoreAward : IFlatbufferObject
	{
		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x06008B82 RID: 35714 RVA: 0x00272241 File Offset: 0x00270441
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x0027224E File Offset: 0x0027044E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008B84 RID: 35716 RVA: 0x00272258 File Offset: 0x00270458
		public static KurotatoScoreAward GetRootAsKurotatoScoreAward(ByteBuffer _bb)
		{
			return KurotatoScoreAward.GetRootAsKurotatoScoreAward(_bb, default(KurotatoScoreAward));
		}

		// Token: 0x06008B85 RID: 35717 RVA: 0x00272274 File Offset: 0x00270474
		public static KurotatoScoreAward GetRootAsKurotatoScoreAward(ByteBuffer _bb, KurotatoScoreAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008B86 RID: 35718 RVA: 0x00272291 File Offset: 0x00270491
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008B87 RID: 35719 RVA: 0x002722A0 File Offset: 0x002704A0
		public KurotatoScoreAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x06008B88 RID: 35720 RVA: 0x002722B0 File Offset: 0x002704B0
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

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06008B89 RID: 35721 RVA: 0x002722EC File Offset: 0x002704EC
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

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x06008B8A RID: 35722 RVA: 0x00272328 File Offset: 0x00270528
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

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x06008B8B RID: 35723 RVA: 0x00272364 File Offset: 0x00270564
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

		// Token: 0x04004E44 RID: 20036
		private Table __p;
	}
}
