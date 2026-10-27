using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001110 RID: 4368
	public struct SwimBuff : IFlatbufferObject
	{
		// Token: 0x17003983 RID: 14723
		// (get) Token: 0x0600DC73 RID: 56435 RVA: 0x0032887C File Offset: 0x00326A7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DC74 RID: 56436 RVA: 0x00328889 File Offset: 0x00326A89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DC75 RID: 56437 RVA: 0x00328890 File Offset: 0x00326A90
		public static SwimBuff GetRootAsSwimBuff(ByteBuffer _bb)
		{
			return SwimBuff.GetRootAsSwimBuff(_bb, default(SwimBuff));
		}

		// Token: 0x0600DC76 RID: 56438 RVA: 0x003288AC File Offset: 0x00326AAC
		public static SwimBuff GetRootAsSwimBuff(ByteBuffer _bb, SwimBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DC77 RID: 56439 RVA: 0x003288C9 File Offset: 0x00326AC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DC78 RID: 56440 RVA: 0x003288D8 File Offset: 0x00326AD8
		public SwimBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003984 RID: 14724
		// (get) Token: 0x0600DC79 RID: 56441 RVA: 0x003288E8 File Offset: 0x00326AE8
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

		// Token: 0x17003985 RID: 14725
		// (get) Token: 0x0600DC7A RID: 56442 RVA: 0x00328924 File Offset: 0x00326B24
		public int BuffId
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

		// Token: 0x0400524D RID: 21069
		private Table __p;
	}
}
