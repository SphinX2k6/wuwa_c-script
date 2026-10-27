using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001078 RID: 4216
	public struct RoverRogueEffectType : IFlatbufferObject
	{
		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x0600CDA3 RID: 52643 RVA: 0x00305BA8 File Offset: 0x00303DA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CDA4 RID: 52644 RVA: 0x00305BB5 File Offset: 0x00303DB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CDA5 RID: 52645 RVA: 0x00305BBC File Offset: 0x00303DBC
		public static RoverRogueEffectType GetRootAsRoverRogueEffectType(ByteBuffer _bb)
		{
			return RoverRogueEffectType.GetRootAsRoverRogueEffectType(_bb, default(RoverRogueEffectType));
		}

		// Token: 0x0600CDA6 RID: 52646 RVA: 0x00305BD8 File Offset: 0x00303DD8
		public static RoverRogueEffectType GetRootAsRoverRogueEffectType(ByteBuffer _bb, RoverRogueEffectType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CDA7 RID: 52647 RVA: 0x00305BF5 File Offset: 0x00303DF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CDA8 RID: 52648 RVA: 0x00305C04 File Offset: 0x00303E04
		public RoverRogueEffectType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x0600CDA9 RID: 52649 RVA: 0x00305C14 File Offset: 0x00303E14
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

		// Token: 0x04005182 RID: 20866
		private Table __p;
	}
}
