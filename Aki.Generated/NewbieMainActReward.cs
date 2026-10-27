using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E82 RID: 3714
	public struct NewbieMainActReward : IFlatbufferObject
	{
		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x06009E69 RID: 40553 RVA: 0x0029C211 File Offset: 0x0029A411
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x0029C21E File Offset: 0x0029A41E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009E6B RID: 40555 RVA: 0x0029C228 File Offset: 0x0029A428
		public static NewbieMainActReward GetRootAsNewbieMainActReward(ByteBuffer _bb)
		{
			return NewbieMainActReward.GetRootAsNewbieMainActReward(_bb, default(NewbieMainActReward));
		}

		// Token: 0x06009E6C RID: 40556 RVA: 0x0029C244 File Offset: 0x0029A444
		public static NewbieMainActReward GetRootAsNewbieMainActReward(ByteBuffer _bb, NewbieMainActReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009E6D RID: 40557 RVA: 0x0029C261 File Offset: 0x0029A461
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009E6E RID: 40558 RVA: 0x0029C270 File Offset: 0x0029A470
		public NewbieMainActReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x06009E6F RID: 40559 RVA: 0x0029C280 File Offset: 0x0029A480
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

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x06009E70 RID: 40560 RVA: 0x0029C2BC File Offset: 0x0029A4BC
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

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x06009E71 RID: 40561 RVA: 0x0029C2F8 File Offset: 0x0029A4F8
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

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x06009E72 RID: 40562 RVA: 0x0029C334 File Offset: 0x0029A534
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

		// Token: 0x04004F30 RID: 20272
		private Table __p;
	}
}
