using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200107B RID: 4219
	public struct RoverRogueGoods : IFlatbufferObject
	{
		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x0600CDCD RID: 52685 RVA: 0x0030607D File Offset: 0x0030427D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CDCE RID: 52686 RVA: 0x0030608A File Offset: 0x0030428A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CDCF RID: 52687 RVA: 0x00306094 File Offset: 0x00304294
		public static RoverRogueGoods GetRootAsRoverRogueGoods(ByteBuffer _bb)
		{
			return RoverRogueGoods.GetRootAsRoverRogueGoods(_bb, default(RoverRogueGoods));
		}

		// Token: 0x0600CDD0 RID: 52688 RVA: 0x003060B0 File Offset: 0x003042B0
		public static RoverRogueGoods GetRootAsRoverRogueGoods(ByteBuffer _bb, RoverRogueGoods obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CDD1 RID: 52689 RVA: 0x003060CD File Offset: 0x003042CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CDD2 RID: 52690 RVA: 0x003060DC File Offset: 0x003042DC
		public RoverRogueGoods __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x0600CDD3 RID: 52691 RVA: 0x003060EC File Offset: 0x003042EC
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

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x0600CDD4 RID: 52692 RVA: 0x00306128 File Offset: 0x00304328
		public int Type
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

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x0600CDD5 RID: 52693 RVA: 0x00306164 File Offset: 0x00304364
		public int Param
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

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x0600CDD6 RID: 52694 RVA: 0x003061A0 File Offset: 0x003043A0
		public int Price
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

		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x0600CDD7 RID: 52695 RVA: 0x003061E0 File Offset: 0x003043E0
		public int Discount
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

		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x0600CDD8 RID: 52696 RVA: 0x00306220 File Offset: 0x00304420
		public int ShowItemId
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

		// Token: 0x04005185 RID: 20869
		private Table __p;
	}
}
