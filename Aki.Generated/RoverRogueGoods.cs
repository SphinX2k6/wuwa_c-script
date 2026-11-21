using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001176 RID: 4470
	public struct RoverRogueGoods : IFlatbufferObject
	{
		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x0600D5A0 RID: 54688 RVA: 0x003257C5 File Offset: 0x003239C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D5A1 RID: 54689 RVA: 0x003257D2 File Offset: 0x003239D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D5A2 RID: 54690 RVA: 0x003257DC File Offset: 0x003239DC
		public static RoverRogueGoods GetRootAsRoverRogueGoods(ByteBuffer _bb)
		{
			return RoverRogueGoods.GetRootAsRoverRogueGoods(_bb, default(RoverRogueGoods));
		}

		// Token: 0x0600D5A3 RID: 54691 RVA: 0x003257F8 File Offset: 0x003239F8
		public static RoverRogueGoods GetRootAsRoverRogueGoods(ByteBuffer _bb, RoverRogueGoods obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D5A4 RID: 54692 RVA: 0x00325815 File Offset: 0x00323A15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D5A5 RID: 54693 RVA: 0x00325824 File Offset: 0x00323A24
		public RoverRogueGoods __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x0600D5A6 RID: 54694 RVA: 0x00325834 File Offset: 0x00323A34
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

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x0600D5A7 RID: 54695 RVA: 0x00325870 File Offset: 0x00323A70
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

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x0600D5A8 RID: 54696 RVA: 0x003258AC File Offset: 0x00323AAC
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

		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x0600D5A9 RID: 54697 RVA: 0x003258E8 File Offset: 0x00323AE8
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

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0600D5AA RID: 54698 RVA: 0x00325928 File Offset: 0x00323B28
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

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x0600D5AB RID: 54699 RVA: 0x00325968 File Offset: 0x00323B68
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

		// Token: 0x04005784 RID: 22404
		private Table __p;
	}
}
