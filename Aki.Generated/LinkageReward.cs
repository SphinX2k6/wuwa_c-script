using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DCD RID: 3533
	public struct LinkageReward : IFlatbufferObject
	{
		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x06008E54 RID: 36436 RVA: 0x00278335 File Offset: 0x00276535
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008E55 RID: 36437 RVA: 0x00278342 File Offset: 0x00276542
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008E56 RID: 36438 RVA: 0x0027834C File Offset: 0x0027654C
		public static LinkageReward GetRootAsLinkageReward(ByteBuffer _bb)
		{
			return LinkageReward.GetRootAsLinkageReward(_bb, default(LinkageReward));
		}

		// Token: 0x06008E57 RID: 36439 RVA: 0x00278368 File Offset: 0x00276568
		public static LinkageReward GetRootAsLinkageReward(ByteBuffer _bb, LinkageReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008E58 RID: 36440 RVA: 0x00278385 File Offset: 0x00276585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008E59 RID: 36441 RVA: 0x00278394 File Offset: 0x00276594
		public LinkageReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x06008E5A RID: 36442 RVA: 0x002783A4 File Offset: 0x002765A4
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

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x06008E5B RID: 36443 RVA: 0x002783E0 File Offset: 0x002765E0
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

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x06008E5C RID: 36444 RVA: 0x0027841C File Offset: 0x0027661C
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

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x06008E5D RID: 36445 RVA: 0x00278458 File Offset: 0x00276658
		public int KeepDropId
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

		// Token: 0x04004E63 RID: 20067
		private Table __p;
	}
}
