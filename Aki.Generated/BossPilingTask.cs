using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C22 RID: 3106
	public struct BossPilingTask : IFlatbufferObject
	{
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06005474 RID: 21620 RVA: 0x00206C32 File Offset: 0x00204E32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x00206C3F File Offset: 0x00204E3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005476 RID: 21622 RVA: 0x00206C48 File Offset: 0x00204E48
		public static BossPilingTask GetRootAsBossPilingTask(ByteBuffer _bb)
		{
			return BossPilingTask.GetRootAsBossPilingTask(_bb, default(BossPilingTask));
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x00206C64 File Offset: 0x00204E64
		public static BossPilingTask GetRootAsBossPilingTask(ByteBuffer _bb, BossPilingTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x00206C81 File Offset: 0x00204E81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x00206C90 File Offset: 0x00204E90
		public BossPilingTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600547A RID: 21626 RVA: 0x00206CA0 File Offset: 0x00204EA0
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

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600547B RID: 21627 RVA: 0x00206CDC File Offset: 0x00204EDC
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

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600547C RID: 21628 RVA: 0x00206D18 File Offset: 0x00204F18
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

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600547D RID: 21629 RVA: 0x00206D54 File Offset: 0x00204F54
		public int RewardCount
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

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600547E RID: 21630 RVA: 0x00206D94 File Offset: 0x00204F94
		public int BelongLevel
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

		// Token: 0x0400511D RID: 20765
		private Table __p;
	}
}
