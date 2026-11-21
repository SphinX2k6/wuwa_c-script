using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001172 RID: 4466
	public struct RoverRogueEffectGroup : IFlatbufferObject
	{
		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x0600D56F RID: 54639 RVA: 0x00325264 File Offset: 0x00323464
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D570 RID: 54640 RVA: 0x00325271 File Offset: 0x00323471
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D571 RID: 54641 RVA: 0x00325278 File Offset: 0x00323478
		public static RoverRogueEffectGroup GetRootAsRoverRogueEffectGroup(ByteBuffer _bb)
		{
			return RoverRogueEffectGroup.GetRootAsRoverRogueEffectGroup(_bb, default(RoverRogueEffectGroup));
		}

		// Token: 0x0600D572 RID: 54642 RVA: 0x00325294 File Offset: 0x00323494
		public static RoverRogueEffectGroup GetRootAsRoverRogueEffectGroup(ByteBuffer _bb, RoverRogueEffectGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D573 RID: 54643 RVA: 0x003252B1 File Offset: 0x003234B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D574 RID: 54644 RVA: 0x003252C0 File Offset: 0x003234C0
		public RoverRogueEffectGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003548 RID: 13640
		// (get) Token: 0x0600D575 RID: 54645 RVA: 0x003252D0 File Offset: 0x003234D0
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

		// Token: 0x04005780 RID: 22400
		private Table __p;
	}
}
