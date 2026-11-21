using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010DA RID: 4314
	public struct RogueResBondShop : IFlatbufferObject
	{
		// Token: 0x1700303E RID: 12350
		// (get) Token: 0x0600C72C RID: 50988 RVA: 0x00305611 File Offset: 0x00303811
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C72D RID: 50989 RVA: 0x0030561E File Offset: 0x0030381E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C72E RID: 50990 RVA: 0x00305628 File Offset: 0x00303828
		public static RogueResBondShop GetRootAsRogueResBondShop(ByteBuffer _bb)
		{
			return RogueResBondShop.GetRootAsRogueResBondShop(_bb, default(RogueResBondShop));
		}

		// Token: 0x0600C72F RID: 50991 RVA: 0x00305644 File Offset: 0x00303844
		public static RogueResBondShop GetRootAsRogueResBondShop(ByteBuffer _bb, RogueResBondShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C730 RID: 50992 RVA: 0x00305661 File Offset: 0x00303861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C731 RID: 50993 RVA: 0x00305670 File Offset: 0x00303870
		public RogueResBondShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700303F RID: 12351
		// (get) Token: 0x0600C732 RID: 50994 RVA: 0x00305680 File Offset: 0x00303880
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

		// Token: 0x040056C1 RID: 22209
		private Table __p;
	}
}
