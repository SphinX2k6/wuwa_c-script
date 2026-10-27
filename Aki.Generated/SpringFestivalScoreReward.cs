using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010EB RID: 4331
	public struct SpringFestivalScoreReward : IFlatbufferObject
	{
		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x0600D8E6 RID: 55526 RVA: 0x00320455 File Offset: 0x0031E655
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D8E7 RID: 55527 RVA: 0x00320462 File Offset: 0x0031E662
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D8E8 RID: 55528 RVA: 0x0032046C File Offset: 0x0031E66C
		public static SpringFestivalScoreReward GetRootAsSpringFestivalScoreReward(ByteBuffer _bb)
		{
			return SpringFestivalScoreReward.GetRootAsSpringFestivalScoreReward(_bb, default(SpringFestivalScoreReward));
		}

		// Token: 0x0600D8E9 RID: 55529 RVA: 0x00320488 File Offset: 0x0031E688
		public static SpringFestivalScoreReward GetRootAsSpringFestivalScoreReward(ByteBuffer _bb, SpringFestivalScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D8EA RID: 55530 RVA: 0x003204A5 File Offset: 0x0031E6A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D8EB RID: 55531 RVA: 0x003204B4 File Offset: 0x0031E6B4
		public SpringFestivalScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x0600D8EC RID: 55532 RVA: 0x003204C4 File Offset: 0x0031E6C4
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

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x0600D8ED RID: 55533 RVA: 0x00320500 File Offset: 0x0031E700
		public int Activity
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

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x0600D8EE RID: 55534 RVA: 0x0032053C File Offset: 0x0031E73C
		public int Index
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

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x0600D8EF RID: 55535 RVA: 0x00320578 File Offset: 0x0031E778
		public int Score
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

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x0600D8F0 RID: 55536 RVA: 0x003205B8 File Offset: 0x0031E7B8
		public int DropId
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

		// Token: 0x0400521F RID: 21023
		private Table __p;
	}
}
