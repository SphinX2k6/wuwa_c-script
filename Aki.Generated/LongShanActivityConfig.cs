using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EBE RID: 3774
	public struct LongShanActivityConfig : IFlatbufferObject
	{
		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x0600957D RID: 38269 RVA: 0x00298E3B File Offset: 0x0029703B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600957E RID: 38270 RVA: 0x00298E48 File Offset: 0x00297048
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600957F RID: 38271 RVA: 0x00298E50 File Offset: 0x00297050
		public static LongShanActivityConfig GetRootAsLongShanActivityConfig(ByteBuffer _bb)
		{
			return LongShanActivityConfig.GetRootAsLongShanActivityConfig(_bb, default(LongShanActivityConfig));
		}

		// Token: 0x06009580 RID: 38272 RVA: 0x00298E6C File Offset: 0x0029706C
		public static LongShanActivityConfig GetRootAsLongShanActivityConfig(ByteBuffer _bb, LongShanActivityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009581 RID: 38273 RVA: 0x00298E89 File Offset: 0x00297089
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009582 RID: 38274 RVA: 0x00298E98 File Offset: 0x00297098
		public LongShanActivityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x06009583 RID: 38275 RVA: 0x00298EA8 File Offset: 0x002970A8
		public int ActivityId
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

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x06009584 RID: 38276 RVA: 0x00298EE4 File Offset: 0x002970E4
		public int Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005459 RID: 21593
		private Table __p;
	}
}
