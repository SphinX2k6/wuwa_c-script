using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001185 RID: 4485
	public struct RoverRogueShop : IFlatbufferObject
	{
		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x0600D739 RID: 55097 RVA: 0x00328FDC File Offset: 0x003271DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D73A RID: 55098 RVA: 0x00328FE9 File Offset: 0x003271E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D73B RID: 55099 RVA: 0x00328FF0 File Offset: 0x003271F0
		public static RoverRogueShop GetRootAsRoverRogueShop(ByteBuffer _bb)
		{
			return RoverRogueShop.GetRootAsRoverRogueShop(_bb, default(RoverRogueShop));
		}

		// Token: 0x0600D73C RID: 55100 RVA: 0x0032900C File Offset: 0x0032720C
		public static RoverRogueShop GetRootAsRoverRogueShop(ByteBuffer _bb, RoverRogueShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D73D RID: 55101 RVA: 0x00329029 File Offset: 0x00327229
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D73E RID: 55102 RVA: 0x00329038 File Offset: 0x00327238
		public RoverRogueShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x0600D73F RID: 55103 RVA: 0x00329048 File Offset: 0x00327248
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

		// Token: 0x04005796 RID: 22422
		private Table __p;
	}
}
