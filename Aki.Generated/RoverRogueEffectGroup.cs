using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001077 RID: 4215
	public struct RoverRogueEffectGroup : IFlatbufferObject
	{
		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x0600CD9C RID: 52636 RVA: 0x00305B00 File Offset: 0x00303D00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CD9D RID: 52637 RVA: 0x00305B0D File Offset: 0x00303D0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CD9E RID: 52638 RVA: 0x00305B14 File Offset: 0x00303D14
		public static RoverRogueEffectGroup GetRootAsRoverRogueEffectGroup(ByteBuffer _bb)
		{
			return RoverRogueEffectGroup.GetRootAsRoverRogueEffectGroup(_bb, default(RoverRogueEffectGroup));
		}

		// Token: 0x0600CD9F RID: 52639 RVA: 0x00305B30 File Offset: 0x00303D30
		public static RoverRogueEffectGroup GetRootAsRoverRogueEffectGroup(ByteBuffer _bb, RoverRogueEffectGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CDA0 RID: 52640 RVA: 0x00305B4D File Offset: 0x00303D4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CDA1 RID: 52641 RVA: 0x00305B5C File Offset: 0x00303D5C
		public RoverRogueEffectGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x0600CDA2 RID: 52642 RVA: 0x00305B6C File Offset: 0x00303D6C
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

		// Token: 0x04005181 RID: 20865
		private Table __p;
	}
}
