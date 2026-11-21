using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB2 RID: 3762
	public struct LinkageReward : IFlatbufferObject
	{
		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x06009470 RID: 38000 RVA: 0x00296826 File Offset: 0x00294A26
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009471 RID: 38001 RVA: 0x00296833 File Offset: 0x00294A33
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009472 RID: 38002 RVA: 0x0029683C File Offset: 0x00294A3C
		public static LinkageReward GetRootAsLinkageReward(ByteBuffer _bb)
		{
			return LinkageReward.GetRootAsLinkageReward(_bb, default(LinkageReward));
		}

		// Token: 0x06009473 RID: 38003 RVA: 0x00296858 File Offset: 0x00294A58
		public static LinkageReward GetRootAsLinkageReward(ByteBuffer _bb, LinkageReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009474 RID: 38004 RVA: 0x00296875 File Offset: 0x00294A75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009475 RID: 38005 RVA: 0x00296884 File Offset: 0x00294A84
		public LinkageReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x06009476 RID: 38006 RVA: 0x00296894 File Offset: 0x00294A94
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

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06009477 RID: 38007 RVA: 0x002968D0 File Offset: 0x00294AD0
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

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06009478 RID: 38008 RVA: 0x0029690C File Offset: 0x00294B0C
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

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x06009479 RID: 38009 RVA: 0x00296948 File Offset: 0x00294B48
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

		// Token: 0x04005448 RID: 21576
		private Table __p;
	}
}
