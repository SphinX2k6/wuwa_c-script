using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200108A RID: 4234
	public struct RoverRogueShop : IFlatbufferObject
	{
		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x0600CF66 RID: 53094 RVA: 0x003099C8 File Offset: 0x00307BC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CF67 RID: 53095 RVA: 0x003099D5 File Offset: 0x00307BD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CF68 RID: 53096 RVA: 0x003099DC File Offset: 0x00307BDC
		public static RoverRogueShop GetRootAsRoverRogueShop(ByteBuffer _bb)
		{
			return RoverRogueShop.GetRootAsRoverRogueShop(_bb, default(RoverRogueShop));
		}

		// Token: 0x0600CF69 RID: 53097 RVA: 0x003099F8 File Offset: 0x00307BF8
		public static RoverRogueShop GetRootAsRoverRogueShop(ByteBuffer _bb, RoverRogueShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CF6A RID: 53098 RVA: 0x00309A15 File Offset: 0x00307C15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CF6B RID: 53099 RVA: 0x00309A24 File Offset: 0x00307C24
		public RoverRogueShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x0600CF6C RID: 53100 RVA: 0x00309A34 File Offset: 0x00307C34
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

		// Token: 0x04005197 RID: 20887
		private Table __p;
	}
}
